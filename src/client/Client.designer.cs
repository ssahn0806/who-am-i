namespace Who_Am_I_Client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_Connect = new System.Windows.Forms.GroupBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.grp_Quiz = new System.Windows.Forms.GroupBox();
            this.btn_Quiz = new System.Windows.Forms.Button();
            this.btn_Question = new System.Windows.Forms.Button();
            this.btn_Answer = new System.Windows.Forms.Button();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.txt_All = new System.Windows.Forms.TextBox();
            this.grp_Connect.SuspendLayout();
            this.grp_Quiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Connect
            // 
            this.grp_Connect.Controls.Add(this.btn_Connect);
            this.grp_Connect.Controls.Add(this.txt_Port);
            this.grp_Connect.Controls.Add(this.lbl_Port);
            this.grp_Connect.Controls.Add(this.txt_Ip);
            this.grp_Connect.Controls.Add(this.lbl_Ip);
            this.grp_Connect.Location = new System.Drawing.Point(12, 34);
            this.grp_Connect.Name = "grp_Connect";
            this.grp_Connect.Size = new System.Drawing.Size(581, 133);
            this.grp_Connect.TabIndex = 0;
            this.grp_Connect.TabStop = false;
            this.grp_Connect.Text = "접속 정보";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Connect.Location = new System.Drawing.Point(16, 76);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(549, 39);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect [서버 접속]";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(444, 27);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(121, 28);
            this.txt_Port.TabIndex = 2;
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Port.Location = new System.Drawing.Point(369, 28);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(67, 25);
            this.lbl_Port.TabIndex = 8;
            this.lbl_Port.Text = "PORT :";
            // 
            // txt_Ip
            // 
            this.txt_Ip.Location = new System.Drawing.Point(54, 27);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(287, 28);
            this.txt_Ip.TabIndex = 1;
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Ip.Location = new System.Drawing.Point(11, 25);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(37, 25);
            this.lbl_Ip.TabIndex = 6;
            this.lbl_Ip.Text = "IP :";
            // 
            // grp_Quiz
            // 
            this.grp_Quiz.Controls.Add(this.btn_Quiz);
            this.grp_Quiz.Controls.Add(this.btn_Question);
            this.grp_Quiz.Controls.Add(this.btn_Answer);
            this.grp_Quiz.Controls.Add(this.txt_Question);
            this.grp_Quiz.Controls.Add(this.lbl_Question);
            this.grp_Quiz.Controls.Add(this.txt_Answer);
            this.grp_Quiz.Controls.Add(this.lbl_Answer);
            this.grp_Quiz.Location = new System.Drawing.Point(12, 244);
            this.grp_Quiz.Name = "grp_Quiz";
            this.grp_Quiz.Size = new System.Drawing.Size(581, 242);
            this.grp_Quiz.TabIndex = 10;
            this.grp_Quiz.TabStop = false;
            this.grp_Quiz.Text = "스무고개 퀴즈정보";
            // 
            // btn_Quiz
            // 
            this.btn_Quiz.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Quiz.Location = new System.Drawing.Point(16, 46);
            this.btn_Quiz.Name = "btn_Quiz";
            this.btn_Quiz.Size = new System.Drawing.Size(549, 39);
            this.btn_Quiz.TabIndex = 4;
            this.btn_Quiz.Text = "Quiz Start [퀴즈 시작]";
            this.btn_Quiz.UseVisualStyleBackColor = true;
            this.btn_Quiz.Click += new System.EventHandler(this.btn_Quiz_Click);
            // 
            // btn_Question
            // 
            this.btn_Question.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Question.Location = new System.Drawing.Point(439, 189);
            this.btn_Question.Name = "btn_Question";
            this.btn_Question.Size = new System.Drawing.Size(126, 35);
            this.btn_Question.TabIndex = 8;
            this.btn_Question.Text = "OK [전송]";
            this.btn_Question.UseVisualStyleBackColor = true;
            this.btn_Question.Click += new System.EventHandler(this.btn_Question_Click);
            // 
            // btn_Answer
            // 
            this.btn_Answer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Answer.Location = new System.Drawing.Point(439, 119);
            this.btn_Answer.Name = "btn_Answer";
            this.btn_Answer.Size = new System.Drawing.Size(126, 35);
            this.btn_Answer.TabIndex = 6;
            this.btn_Answer.Text = "OK [전송]";
            this.btn_Answer.UseVisualStyleBackColor = true;
            this.btn_Answer.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // txt_Question
            // 
            this.txt_Question.Location = new System.Drawing.Point(75, 191);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.ReadOnly = true;
            this.txt_Question.Size = new System.Drawing.Size(348, 28);
            this.txt_Question.TabIndex = 7;
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Question.Location = new System.Drawing.Point(11, 191);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(58, 25);
            this.lbl_Question.TabIndex = 8;
            this.lbl_Question.Text = "질문 :";
            // 
            // txt_Answer
            // 
            this.txt_Answer.Location = new System.Drawing.Point(75, 121);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.ReadOnly = true;
            this.txt_Answer.Size = new System.Drawing.Size(348, 28);
            this.txt_Answer.TabIndex = 5;
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Answer.Location = new System.Drawing.Point(11, 119);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(58, 25);
            this.lbl_Answer.TabIndex = 6;
            this.lbl_Answer.Text = "정답 :";
            // 
            // txt_All
            // 
            this.txt_All.Location = new System.Drawing.Point(614, 34);
            this.txt_All.Multiline = true;
            this.txt_All.Name = "txt_All";
            this.txt_All.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_All.Size = new System.Drawing.Size(565, 453);
            this.txt_All.TabIndex = 10;
            this.txt_All.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 507);
            this.Controls.Add(this.txt_All);
            this.Controls.Add(this.grp_Quiz);
            this.Controls.Add(this.grp_Connect);
            this.Name = "Client";
            this.Text = "ClientForm [2016726053 안승수]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.grp_Connect.ResumeLayout(false);
            this.grp_Connect.PerformLayout();
            this.grp_Quiz.ResumeLayout(false);
            this.grp_Quiz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Connect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.GroupBox grp_Quiz;
        private System.Windows.Forms.TextBox txt_Question;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.Button btn_Answer;
        private System.Windows.Forms.Button btn_Question;
        private System.Windows.Forms.Button btn_Quiz;
        private System.Windows.Forms.TextBox txt_All;
    }
}