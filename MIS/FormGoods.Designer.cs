namespace MIS
{
    partial class FrmGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoods));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.plGoodsKind = new System.Windows.Forms.Panel();
            this.rbKitchen = new System.Windows.Forms.RadioButton();
            this.rbReagent = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbCSR = new System.Windows.Forms.RadioButton();
            this.rbEtc = new System.Windows.Forms.RadioButton();
            this.rbPrint = new System.Windows.Forms.RadioButton();
            this.rbOffice = new System.Windows.Forms.RadioButton();
            this.rbTreatMat = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plApprKind = new System.Windows.Forms.Panel();
            this.rbNotAppr = new System.Windows.Forms.RadioButton();
            this.rbHalfAppr = new System.Windows.Forms.RadioButton();
            this.rbAppr = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtAskDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAskNum2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAskNum1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plAskKind = new System.Windows.Forms.Panel();
            this.rbRecall = new System.Windows.Forms.RadioButton();
            this.rbAsk = new System.Windows.Forms.RadioButton();
            this.lblAskKind = new System.Windows.Forms.Label();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.plGoodsKind.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plApprKind.SuspendLayout();
            this.plAskKind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.조ToolStripMenuItem,
            this.설ToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름으로저장ASToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새로만들기NToolStripMenuItem
            // 
            this.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem";
            this.새로만들기NToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.새로만들기NToolStripMenuItem.Text = "새로 만들기(&N)";
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            // 
            // 다른이름으로저장ASToolStripMenuItem
            // 
            this.다른이름으로저장ASToolStripMenuItem.Name = "다른이름으로저장ASToolStripMenuItem";
            this.다른이름으로저장ASToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.다른이름으로저장ASToolStripMenuItem.Text = "다른 이름으로 저장(&AS)";
            this.다른이름으로저장ASToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장ASToolStripMenuItem_Click);
            // 
            // 조ToolStripMenuItem
            // 
            this.조ToolStripMenuItem.Name = "조ToolStripMenuItem";
            this.조ToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.조ToolStripMenuItem.Text = "조회";
            // 
            // 설ToolStripMenuItem
            // 
            this.설ToolStripMenuItem.Name = "설ToolStripMenuItem";
            this.설ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.설ToolStripMenuItem.Text = "설정(&C)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripSeparator2,
            this.toolStripButton10});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "toolStripButton9";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "toolStripButton10";
            // 
            // plGoodsKind
            // 
            this.plGoodsKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plGoodsKind.Controls.Add(this.rbKitchen);
            this.plGoodsKind.Controls.Add(this.rbReagent);
            this.plGoodsKind.Controls.Add(this.rbMed);
            this.plGoodsKind.Controls.Add(this.rbCSR);
            this.plGoodsKind.Controls.Add(this.rbEtc);
            this.plGoodsKind.Controls.Add(this.rbPrint);
            this.plGoodsKind.Controls.Add(this.rbOffice);
            this.plGoodsKind.Controls.Add(this.rbTreatMat);
            this.plGoodsKind.Location = new System.Drawing.Point(108, 62);
            this.plGoodsKind.Name = "plGoodsKind";
            this.plGoodsKind.Size = new System.Drawing.Size(610, 26);
            this.plGoodsKind.TabIndex = 2;
            // 
            // rbKitchen
            // 
            this.rbKitchen.AutoSize = true;
            this.rbKitchen.ForeColor = System.Drawing.Color.Blue;
            this.rbKitchen.Location = new System.Drawing.Point(535, 5);
            this.rbKitchen.Name = "rbKitchen";
            this.rbKitchen.Size = new System.Drawing.Size(71, 16);
            this.rbKitchen.TabIndex = 7;
            this.rbKitchen.TabStop = true;
            this.rbKitchen.Text = "주방용품";
            this.rbKitchen.UseVisualStyleBackColor = true;
            this.rbKitchen.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // rbReagent
            // 
            this.rbReagent.AutoSize = true;
            this.rbReagent.ForeColor = System.Drawing.Color.Blue;
            this.rbReagent.Location = new System.Drawing.Point(470, 5);
            this.rbReagent.Name = "rbReagent";
            this.rbReagent.Size = new System.Drawing.Size(59, 16);
            this.rbReagent.TabIndex = 6;
            this.rbReagent.TabStop = true;
            this.rbReagent.Text = "시약품";
            this.rbReagent.UseVisualStyleBackColor = true;
            this.rbReagent.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.ForeColor = System.Drawing.Color.Blue;
            this.rbMed.Location = new System.Drawing.Point(417, 5);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(47, 16);
            this.rbMed.TabIndex = 5;
            this.rbMed.TabStop = true;
            this.rbMed.Text = "약품";
            this.rbMed.UseVisualStyleBackColor = true;
            this.rbMed.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rbCSR
            // 
            this.rbCSR.AutoSize = true;
            this.rbCSR.ForeColor = System.Drawing.Color.Blue;
            this.rbCSR.Location = new System.Drawing.Point(339, 5);
            this.rbCSR.Name = "rbCSR";
            this.rbCSR.Size = new System.Drawing.Size(72, 16);
            this.rbCSR.TabIndex = 4;
            this.rbCSR.TabStop = true;
            this.rbCSR.Text = "CSR용품";
            this.rbCSR.UseVisualStyleBackColor = true;
            // 
            // rbEtc
            // 
            this.rbEtc.AutoSize = true;
            this.rbEtc.ForeColor = System.Drawing.Color.Blue;
            this.rbEtc.Location = new System.Drawing.Point(234, 5);
            this.rbEtc.Name = "rbEtc";
            this.rbEtc.Size = new System.Drawing.Size(99, 16);
            this.rbEtc.TabIndex = 3;
            this.rbEtc.TabStop = true;
            this.rbEtc.Text = "그외 일반용품";
            this.rbEtc.UseVisualStyleBackColor = true;
            this.rbEtc.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbPrint
            // 
            this.rbPrint.AutoSize = true;
            this.rbPrint.ForeColor = System.Drawing.Color.Blue;
            this.rbPrint.Location = new System.Drawing.Point(157, 5);
            this.rbPrint.Name = "rbPrint";
            this.rbPrint.Size = new System.Drawing.Size(71, 16);
            this.rbPrint.TabIndex = 2;
            this.rbPrint.TabStop = true;
            this.rbPrint.Text = "인쇄용품";
            this.rbPrint.UseVisualStyleBackColor = true;
            this.rbPrint.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbOffice
            // 
            this.rbOffice.AutoSize = true;
            this.rbOffice.ForeColor = System.Drawing.Color.Blue;
            this.rbOffice.Location = new System.Drawing.Point(80, 5);
            this.rbOffice.Name = "rbOffice";
            this.rbOffice.Size = new System.Drawing.Size(71, 16);
            this.rbOffice.TabIndex = 1;
            this.rbOffice.TabStop = true;
            this.rbOffice.Text = "사무용품";
            this.rbOffice.UseVisualStyleBackColor = true;
            this.rbOffice.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbTreatMat
            // 
            this.rbTreatMat.AutoSize = true;
            this.rbTreatMat.ForeColor = System.Drawing.Color.Blue;
            this.rbTreatMat.Location = new System.Drawing.Point(3, 5);
            this.rbTreatMat.Name = "rbTreatMat";
            this.rbTreatMat.Size = new System.Drawing.Size(71, 16);
            this.rbTreatMat.TabIndex = 0;
            this.rbTreatMat.TabStop = true;
            this.rbTreatMat.Text = "진료재료";
            this.rbTreatMat.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.plApprKind);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.txtAskDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAskNum2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAskNum1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.plAskKind);
            this.panel2.Controls.Add(this.lblAskKind);
            this.panel2.Location = new System.Drawing.Point(6, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 72);
            this.panel2.TabIndex = 3;
            // 
            // plApprKind
            // 
            this.plApprKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plApprKind.Controls.Add(this.rbNotAppr);
            this.plApprKind.Controls.Add(this.rbHalfAppr);
            this.plApprKind.Controls.Add(this.rbAppr);
            this.plApprKind.Location = new System.Drawing.Point(660, 14);
            this.plApprKind.Name = "plApprKind";
            this.plApprKind.Size = new System.Drawing.Size(202, 45);
            this.plApprKind.TabIndex = 12;
            // 
            // rbNotAppr
            // 
            this.rbNotAppr.AutoSize = true;
            this.rbNotAppr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbNotAppr.Location = new System.Drawing.Point(136, 17);
            this.rbNotAppr.Name = "rbNotAppr";
            this.rbNotAppr.Size = new System.Drawing.Size(59, 16);
            this.rbNotAppr.TabIndex = 2;
            this.rbNotAppr.TabStop = true;
            this.rbNotAppr.Text = "미결재";
            this.rbNotAppr.UseVisualStyleBackColor = true;
            this.rbNotAppr.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // rbHalfAppr
            // 
            this.rbHalfAppr.AutoSize = true;
            this.rbHalfAppr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbHalfAppr.Location = new System.Drawing.Point(59, 17);
            this.rbHalfAppr.Name = "rbHalfAppr";
            this.rbHalfAppr.Size = new System.Drawing.Size(71, 16);
            this.rbHalfAppr.TabIndex = 1;
            this.rbHalfAppr.TabStop = true;
            this.rbHalfAppr.Text = "중간결재";
            this.rbHalfAppr.UseVisualStyleBackColor = true;
            this.rbHalfAppr.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // rbAppr
            // 
            this.rbAppr.AutoSize = true;
            this.rbAppr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbAppr.Location = new System.Drawing.Point(6, 17);
            this.rbAppr.Name = "rbAppr";
            this.rbAppr.Size = new System.Drawing.Size(47, 16);
            this.rbAppr.TabIndex = 0;
            this.rbAppr.TabStop = true;
            this.rbAppr.Text = "결재";
            this.rbAppr.UseVisualStyleBackColor = true;
            this.rbAppr.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(538, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 20);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtAskDate
            // 
            this.txtAskDate.Location = new System.Drawing.Point(538, 13);
            this.txtAskDate.Name = "txtAskDate";
            this.txtAskDate.Size = new System.Drawing.Size(110, 21);
            this.txtAskDate.TabIndex = 10;
            this.txtAskDate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(479, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "불출부서";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "청구일자";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAskNum2
            // 
            this.txtAskNum2.Location = new System.Drawing.Point(372, 13);
            this.txtAskNum2.Name = "txtAskNum2";
            this.txtAskNum2.Size = new System.Drawing.Size(87, 21);
            this.txtAskNum2.TabIndex = 7;
            this.txtAskNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "-";
            // 
            // txtAskNum1
            // 
            this.txtAskNum1.Location = new System.Drawing.Point(299, 14);
            this.txtAskNum1.Name = "txtAskNum1";
            this.txtAskNum1.Size = new System.Drawing.Size(50, 21);
            this.txtAskNum1.TabIndex = 5;
            this.txtAskNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(298, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "청구부서";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "청구번호";
            // 
            // plAskKind
            // 
            this.plAskKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAskKind.Controls.Add(this.rbRecall);
            this.plAskKind.Controls.Add(this.rbAsk);
            this.plAskKind.Location = new System.Drawing.Point(66, 17);
            this.plAskKind.Name = "plAskKind";
            this.plAskKind.Size = new System.Drawing.Size(152, 38);
            this.plAskKind.TabIndex = 1;
            // 
            // rbRecall
            // 
            this.rbRecall.AutoSize = true;
            this.rbRecall.ForeColor = System.Drawing.Color.Olive;
            this.rbRecall.Location = new System.Drawing.Point(85, 10);
            this.rbRecall.Name = "rbRecall";
            this.rbRecall.Size = new System.Drawing.Size(51, 16);
            this.rbRecall.TabIndex = 1;
            this.rbRecall.TabStop = true;
            this.rbRecall.Text = "반 납";
            this.rbRecall.UseVisualStyleBackColor = true;
            // 
            // rbAsk
            // 
            this.rbAsk.AutoSize = true;
            this.rbAsk.ForeColor = System.Drawing.Color.Olive;
            this.rbAsk.Location = new System.Drawing.Point(17, 10);
            this.rbAsk.Name = "rbAsk";
            this.rbAsk.Size = new System.Drawing.Size(51, 16);
            this.rbAsk.TabIndex = 0;
            this.rbAsk.TabStop = true;
            this.rbAsk.Text = "청 구";
            this.rbAsk.UseVisualStyleBackColor = true;
            this.rbAsk.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // lblAskKind
            // 
            this.lblAskKind.AutoSize = true;
            this.lblAskKind.Location = new System.Drawing.Point(3, 32);
            this.lblAskKind.Name = "lblAskKind";
            this.lblAskKind.Size = new System.Drawing.Size(53, 12);
            this.lblAskKind.TabIndex = 0;
            this.lblAskKind.Text = "청구구분";
            // 
            // dgvGoods
            // 
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvGoods.Location = new System.Drawing.Point(6, 172);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.RowTemplate.Height = 23;
            this.dgvGoods.Size = new System.Drawing.Size(882, 312);
            this.dgvGoods.TabIndex = 4;
            this.dgvGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "코 드";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "코드 명";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "규 격";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "불출단위";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "불출처 재고";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "부서 배정량";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "청구수량";
            this.Column7.Name = "Column7";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "저장하기(&S)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(91, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "불러오기(&L)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(176, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "삭제하기(&D)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(261, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "도움말(&H)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGoods);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plGoodsKind);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGoods";
            this.Text = "물품청구서 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.plGoodsKind.ResumeLayout(false);
            this.plGoodsKind.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.plApprKind.ResumeLayout(false);
            this.plApprKind.PerformLayout();
            this.plAskKind.ResumeLayout(false);
            this.plAskKind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.Panel plGoodsKind;
        private System.Windows.Forms.RadioButton rbKitchen;
        private System.Windows.Forms.RadioButton rbReagent;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbCSR;
        private System.Windows.Forms.RadioButton rbEtc;
        private System.Windows.Forms.RadioButton rbPrint;
        private System.Windows.Forms.RadioButton rbOffice;
        private System.Windows.Forms.RadioButton rbTreatMat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel plAskKind;
        private System.Windows.Forms.RadioButton rbRecall;
        private System.Windows.Forms.RadioButton rbAsk;
        private System.Windows.Forms.Label lblAskKind;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.TextBox txtAskNum2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAskNum1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAskDate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel plApprKind;
        private System.Windows.Forms.RadioButton rbNotAppr;
        private System.Windows.Forms.RadioButton rbHalfAppr;
        private System.Windows.Forms.RadioButton rbAppr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

