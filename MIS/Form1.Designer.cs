namespace MIS
{
    partial class MainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.picAffairs = new System.Windows.Forms.PictureBox();
            this.picGoods = new System.Windows.Forms.PictureBox();
            this.picSALM = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAffairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSALM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(19, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 19);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "아 이 디";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPwd.ForeColor = System.Drawing.Color.White;
            this.lblPwd.Location = new System.Drawing.Point(12, 61);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(89, 19);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "비밀번호";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(108, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(137, 21);
            this.txtId.TabIndex = 7;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(108, 61);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(137, 21);
            this.txtPwd.TabIndex = 8;
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResult.Location = new System.Drawing.Point(12, 120);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(189, 12);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "로그인하셔야 이용 가능합니다.";
            // 
            // picAffairs
            // 
            this.picAffairs.Location = new System.Drawing.Point(69, 401);
            this.picAffairs.Name = "picAffairs";
            this.picAffairs.Size = new System.Drawing.Size(240, 120);
            this.picAffairs.TabIndex = 4;
            this.picAffairs.TabStop = false;
            this.picAffairs.Click += new System.EventHandler(this.picAffairs_Click);
            this.picAffairs.MouseLeave += new System.EventHandler(this.picAffairs_MouseLeave);
            this.picAffairs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picAffairs_MouseMove);
            // 
            // picGoods
            // 
            this.picGoods.Location = new System.Drawing.Point(69, 275);
            this.picGoods.Name = "picGoods";
            this.picGoods.Size = new System.Drawing.Size(240, 120);
            this.picGoods.TabIndex = 2;
            this.picGoods.TabStop = false;
            this.picGoods.Click += new System.EventHandler(this.picGoods_Click);
            this.picGoods.MouseLeave += new System.EventHandler(this.picGoods_MouseLeave);
            this.picGoods.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picGoods_MouseMove);
            // 
            // picSALM
            // 
            this.picSALM.Location = new System.Drawing.Point(69, 149);
            this.picSALM.Name = "picSALM";
            this.picSALM.Size = new System.Drawing.Size(240, 120);
            this.picSALM.TabIndex = 1;
            this.picSALM.TabStop = false;
            this.picSALM.Click += new System.EventHandler(this.picSALM_Click);
            this.picSALM.MouseLeave += new System.EventHandler(this.picSALM_MouseLeave);
            this.picSALM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSALM_MouseMove);
            // 
            // picLogin
            // 
            this.picLogin.Location = new System.Drawing.Point(251, 12);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(120, 120);
            this.picLogin.TabIndex = 0;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(383, 538);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.picAffairs);
            this.Controls.Add(this.picGoods);
            this.Controls.Add(this.picSALM);
            this.Controls.Add(this.picLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "경영정보시스템";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAffairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSALM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picSALM;
        private System.Windows.Forms.PictureBox picGoods;
        private System.Windows.Forms.PictureBox picAffairs;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblResult;
    }
}

