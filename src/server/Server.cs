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

namespace Who_Am_I_Server
{
    public partial class Server : Form
    {
        public NetworkStream Net_Stream;

        public StreamReader Server_Read;
        public StreamWriter Server_Write;

        private Thread ServerThread;
        private Thread ReadThread;

        private TcpListener server;

        private bool Server_Status = false;
        private bool Connect_Status = false;
        private int question_num;

        public Server()
        {
            InitializeComponent();
            txt_Ip.Select();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (txt_Ip.Text == "") //IP 입력 공백 확인
            {
                MessageBox.Show("개설할 Server IP를 입력하세요.");
                txt_Ip.Focus();
                return;
            }

            if (txt_Port.Text == "") // PORT 입력 공백 확인
            {
                MessageBox.Show("개설할 Server PORT를 입력하세요.");
                txt_Port.Focus();
                return;
            }

            if (txt_Answer.Text == "") // 정답 입력 공백 확인
            {
                MessageBox.Show("스무고개 문제의 정답을 입력하세요.");
                txt_Answer.Focus();
                return;
            }

            if (!Server_Status)  /* 서버 시작 */
            {
                ServerThread = new Thread(new ThreadStart(ServerStart));
                ServerThread.Start();              
            }          
           
        }
        private void btn_Respond_Click(object sender, EventArgs e)
        {
            if (!txt_Respond.ReadOnly)
            {
                if(txt_Respond.Text !="")
                {
                    Send("A"+txt_Respond.Text); // 응답 내용 전송
                    Send("R남은 질문횟수 : " + question_num); // 남은 횟수도 함께 전송
                }
                else
                {
                    MessageBox.Show("응답을 입력하세요.");
                    txt_Respond.Focus();
                }

            }

        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerStop();
        }

        public void ServerStart()
        {
            try
            {
                IPAddress ServerIP = IPAddress.Parse(txt_Ip.Text);
                int ServerPort = Convert.ToInt32(txt_Port.Text);
                server = new TcpListener(ServerIP, ServerPort);
                server.Start();
                Server_Status = true;
                txt_Answer.ReadOnly = true; // 정답 변경 불가
                btn_Start.ForeColor = Color.Red; // StartText 색상 변경
                Message("서버를 열었습니다! 클라이언트 접속 대기중입니다.");
                
                while(Server_Status)
                {
                    TcpClient client = server.AcceptTcpClient();

                    if(client.Connected)
                    {
                        Connect_Status = true;
                        Message("클라이언트가 접속하였습니다."); // 클라이언트 접속시 메세지 출력

                        Net_Stream = client.GetStream();
                        Server_Read = new StreamReader(Net_Stream);
                        Server_Write = new StreamWriter(Net_Stream);
                        ReadThread = new Thread(new ThreadStart(Receive));
                        ReadThread.Start();

                    }
                }

            }
            catch
            {
                Message("서버를 여는 도중에 오류가 발생하였습니다.");
                ServerStop();
                return;
            }
        }

        public void ServerStop()
        {
            if (!Connect_Status)
                return;

            server.Stop();
            Server_Read.Close();
            Server_Write.Close();

            Net_Stream.Close();
            ReadThread.Abort();
            ServerThread.Abort();

            Message("서비스를 종료합니다.");

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
                Server_Write.WriteLine(msg);
                Server_Write.Flush();

                if(msg[0]!='R' && msg[0]!='Y' && msg[0]!='N' && msg !="OK") // 질문에 대한 답변만 서버 폼에 출력
                {
                    Message("나의 답변 : "+msg.Substring(1));
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
                    string szMessage = Server_Read.ReadLine();

                    if(szMessage!=null)
                    {
                        if(szMessage == "Start") // 퀴즈 시작 요청 수신
                        {
                            question_num = 20; // initial 20
                            lbl_Count.Text = "남은 질문 횟수 : " + question_num; // 서버 폼 남은 질문횟수 표시 
                            txt_Respond.ReadOnly = false; // 서버폼 응답Text 활성화
                            Message("참가자 >>> 스무고개 퀴즈를 시작해주세요."); // 서버폼 스무 고개 퀴즈 시작 알림 메세지 출력
                            Send("OK"); // 퀴즈 시작 알림 송신[클라이언트 13,14 폼 활성화를 위함]
                        }
                        else if(szMessage[0] == 'A') // 답안 제출 수신
                        {
                            if(szMessage.Substring(1) == txt_Answer.Text) // 정답
                            {
                                Send("Y"+txt_Answer.Text+": 정답입니다!"); // 정답 여부 송신
                                Message("참가자가 제출한 답 >>" + szMessage.Substring(1)); // 제출한 답을 서버폼에 출력
                            }
                            else // 오답
                            {
                                Send("N"+szMessage.Substring(1)+": 정답이 아닙니다."); // 정답 여부 송신
                                Message("참가자가 제출한 답 >>" + szMessage.Substring(1));  // 제출한 답을 서버폼에 출력
                            }
                        }
                        else if(szMessage[0] == 'Q') // 질문 수신
                        {
                            Message("참가자의 질문 : " + szMessage.Substring(1)); // 질문 내용 출력
                            question_num--; // 질문 가능 횟수 감소
                            lbl_Count.Text = "남은 질문 횟수 : " + question_num; // 질문 가능 횟수 시각화 업데이트
                        }
                    }
                }
            }
            catch
            {
                Message("데이터를 읽는 과정에서 오류가 발생하였습니다.");
            }

            ServerStop();
        }


    }
}
