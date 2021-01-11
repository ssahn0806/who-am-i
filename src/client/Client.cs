using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;


namespace Who_Am_I_Client
{
    public partial class Client : Form
    {
        public NetworkStream Net_Stream;
        public StreamReader Client_Read;
        public StreamWriter Client_Write;

        private Thread ClientThread;
        private int question_num;
        TcpClient client;
        public bool Connect_Status = false;
        
        public Client()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if(txt_Ip.Text =="") // IP 입력 공백 확인
            {
                txt_Ip.Focus();
                MessageBox.Show("연결할 Server IP를 입력하세요.");
                return;
            }

            if(txt_Port.Text =="") // PORT 입력 공백 확인
            {
                txt_Port.Focus();
                MessageBox.Show("연결할 Server PORT를 입력하세요.");
                return;
            }

            /* 서버 연결 */
            if(!Connect_Status)
            {
                Connect();
            }
           
        }

        private void btn_Quiz_Click(object sender, EventArgs e) // Quiz Start
        {
            if (Connect_Status)
            {
                Send("Start"); //스무고개 퀴즈 시작 요청 송신
            }
        }

        private void btn_Answer_Click(object sender, EventArgs e) // Quiz Answer
        {
            if (!txt_Answer.ReadOnly)
            {
                if (txt_Answer.Text != "")
                {
                    Send("A" + txt_Answer.Text); // 서버에 정답 전송
                } 
                else
                {
                    MessageBox.Show("정답을 입력하세요.");
                    txt_Answer.Focus();
                }
            }

        }

        private void btn_Question_Click(object sender, EventArgs e) // Quiz Question
        {
            if (!txt_Question.ReadOnly)
            {
                if (question_num > 0)
                {
                    if (txt_Question.Text != "")
                    {
                        Send("Q" + txt_Question.Text); // 서버에 질문 전송
                        question_num--; // 질문 가능 횟수 감소
                    }
                    else
                    {
                        MessageBox.Show("질문을 입력하세요.");
                        txt_Question.Focus();
                    }

                }
                else // 질문 가능 횟수가 0이면 더이상 질문 불가
                {
                    MessageBox.Show("더이상 질문할 수 없습니다.");
                }
            }

        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        public void Connect()
        {
            client = new TcpClient();

            try
            {
                IPAddress ConnectIP = IPAddress.Parse(txt_Ip.Text);
                int ConnectPort = Convert.ToInt32(txt_Port.Text);
                client.Connect(ConnectIP, ConnectPort);
            }
            catch(Exception e)
            {
                Connect_Status = false;
                Message(e.Message);
                Disconnect();
                return;
            }
            /* 연결 성공 */
            Connect_Status = true;
            Message("서버에 연결되었습니다.");
            btn_Connect.ForeColor = Color.Red; // Connect Text 색상 변경

            Net_Stream = client.GetStream();

            Client_Read = new StreamReader(Net_Stream);
            Client_Write = new StreamWriter(Net_Stream);

            ClientThread = new Thread(new ThreadStart(Receive));
            ClientThread.Start();
            
        }

        public void Disconnect()
        {
            if (!Connect_Status)
                return;

            Connect_Status = false;

            Client_Read.Close();
            Client_Write.Close();

            Net_Stream.Close();
            ClientThread.Abort();

            Message("서버와 연결을 해제합니다.");

        }
        public void Message(string msg)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                txt_All.AppendText(msg + "\r\n");
            }));
        }


        void Send(string msg)
        {
            try
            {
                Client_Write.WriteLine(msg);
                Client_Write.Flush();


                if(msg[0] == 'Q') // 질문한 내용을 클라이언트 폼에도 출력
                {
                    Message("나의 질문 : " + msg.Substring(1));
                }       
            }
            catch
            {
                Message("데이터 전송에 실패하였습니다.");
            }
        }
        public void Receive()
        {
            try
            {
                while(Connect_Status)
                {
                    string szMessage = Client_Read.ReadLine();

                    if(szMessage !=null)
                    {
                        if (szMessage == "OK") // 퀴즈 시작 알림 수신
                        {
                            Message("출제자 >>> 스무고개 퀴즈가 시작되었습니다.");
                            question_num = 20; // initial
                            btn_Quiz.ForeColor = Color.Red; // Quiz_Start 색상 변경
                            txt_Answer.ReadOnly = false; // 클라이언트 폼 13 활성화
                            txt_Question.ReadOnly = false; // 클라이언트 폼 14 활성화
                        }
                        else if (szMessage[0] == 'Y') // 제출 답안 판별 수신 결과: 정답
                        {
                            //Message("문제의 정답 : " + szMessage.Substring(1,szMessage.Length-9));
                            MessageBox.Show(szMessage.Substring(1)); // 정답 여부 출력
                        }
                        else if (szMessage[0] == 'N') // 제출 답안 판별 수신 결과: 오답
                        {
                            //Message("내가 제출한 오답 : " + szMessage.Substring(1,szMessage.Length-12));
                            MessageBox.Show(szMessage.Substring(1)); // 정답 여부 출력
                        }
                        else if (szMessage[0] == 'R') // 남은 질문 횟수 수신
                        {
                            Message(szMessage.Substring(1)+"\r\n"); // 남은 질문 횟수 출력
                        }
                        else if (szMessage[0] == 'A') // 질문에 대한 응답 수신
                        {
                            Message("출제자의 답변 >>> " + szMessage.Substring(1)); // 응답 내용 출력
                        }
                       
                    }
                }
            }
            catch
            {
                Message("데이터를 읽는 과정에서 오류가 발생하였습니다.");
            }
            Disconnect();
        }




       


    }
}
