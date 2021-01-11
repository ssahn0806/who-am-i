namespace Who_Am_I_Server
{
    partial class Server
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.txt_All = new System.Windows.Forms.TextBox();
            this.grp_connect = new System.Windows.Forms.GroupBox();
            this.txt_Respond = new System.Windows.Forms.TextBox();
            this.btn_Respond = new System.Windows.Forms.Button();
            this.grp_Quiz = new System.Windows.Forms.GroupBox();
            this.grp_connect.SuspendLayout();
            this.grp_Quiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Ip.Location = new System.Drawing.Point(6, 24);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(37, 25);
            this.lbl_Ip.TabIndex = 0;
            this.lbl_Ip.Text = "IP :";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Port.Location = new System.Drawing.Point(361, 25);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(67, 25);
            this.lbl_Port.TabIndex = 1;
            this.lbl_Port.Text = "PORT :";
            // 
            // txt_Ip
            // 
            this.txt_Ip.Location = new System.Drawing.Point(46, 25);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(287, 28);
            this.txt_Ip.TabIndex = 1;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(432, 25);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(121, 28);
            this.txt_Port.TabIndex = 2;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Start.Location = new System.Drawing.Point(9, 71);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(544, 39);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start [서버 시작]";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Name.Location = new System.Drawing.Point(140, 28);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(346, 108);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "Guess Who Am I?\r\n  - 스 무 고 개 - ";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Count.Location = new System.Drawing.Point(15, 44);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(142, 25);
            this.lbl_Count.TabIndex = 98;
            this.lbl_Count.Text = "남은 질문 횟수 :";
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Answer.Location = new System.Drawing.Point(39, 98);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(118, 25);
            this.lbl_Answer.TabIndex = 97;
            this.lbl_Answer.Text = "문제의 정답 :";
            // 
            // txt_Answer
            // 
            this.txt_Answer.Location = new System.Drawing.Point(158, 95);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(232, 28);
            this.txt_Answer.TabIndex = 3;
            // 
            // txt_All
            // 
            this.txt_All.Location = new System.Drawing.Point(624, 150);
            this.txt_All.Multiline = true;
            this.txt_All.Name = "txt_All";
            this.txt_All.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_All.Size = new System.Drawing.Size(568, 447);
            this.txt_All.TabIndex = 0;
            this.txt_All.TabStop = false;
            // 
            // grp_connect
            // 
            this.grp_connect.Controls.Add(this.lbl_Ip);
            this.grp_connect.Controls.Add(this.lbl_Port);
            this.grp_connect.Controls.Add(this.txt_Ip);
            this.grp_connect.Controls.Add(this.txt_Port);
            this.grp_connect.Controls.Add(this.btn_Start);
            this.grp_connect.Location = new System.Drawing.Point(624, 12);
            this.grp_connect.Name = "grp_connect";
            this.grp_connect.Size = new System.Drawing.Size(568, 124);
            this.grp_connect.TabIndex = 95;
            this.grp_connect.TabStop = false;
            this.grp_connect.Text = "서버 정보";
            // 
            // txt_Respond
            // 
            this.txt_Respond.Location = new System.Drawing.Point(624, 623);
            this.txt_Respond.Name = "txt_Respond";
            this.txt_Respond.ReadOnly = true;
            this.txt_Respond.Size = new System.Drawing.Size(412, 28);
            this.txt_Respond.TabIndex = 5;
            // 
            // btn_Respond
            // 
            this.btn_Respond.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Respond.Location = new System.Drawing.Point(1042, 618);
            this.btn_Respond.Name = "btn_Respond";
            this.btn_Respond.Size = new System.Drawing.Size(150, 38);
            this.btn_Respond.TabIndex = 6;
            this.btn_Respond.Text = "OK [전송]";
            this.btn_Respond.UseVisualStyleBackColor = true;
            this.btn_Respond.Click += new System.EventHandler(this.btn_Respond_Click);
            // 
            // grp_Quiz
            // 
            this.grp_Quiz.Controls.Add(this.lbl_Count);
            this.grp_Quiz.Controls.Add(this.lbl_Answer);
            this.grp_Quiz.Controls.Add(this.txt_Answer);
            this.grp_Quiz.Location = new System.Drawing.Point(129, 224);
            this.grp_Quiz.Name = "grp_Quiz";
            this.grp_Quiz.Size = new System.Drawing.Size(401, 150);
            this.grp_Quiz.TabIndex = 99;
            this.grp_Quiz.TabStop = false;
            this.grp_Quiz.Text = "출제 정보";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 682);
            this.Controls.Add(this.btn_Respond);
            this.Controls.Add(this.txt_Respond);
            this.Controls.Add(this.txt_All);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.grp_connect);
            this.Controls.Add(this.grp_Quiz);
            this.Name = "Server";
            this.Text = "ServerForm [2016726053 안승수]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.grp_connect.ResumeLayout(false);
            this.grp_connect.PerformLayout();
            this.grp_Quiz.ResumeLayout(false);
            this.grp_Quiz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.TextBox txt_All;
        private System.Windows.Forms.GroupBox grp_connect;
        private System.Windows.Forms.TextBox txt_Respond;
        private System.Windows.Forms.Button btn_Respond;
        private System.Windows.Forms.GroupBox grp_Quiz;
    }
}

