namespace labManagement
    {
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ViewNoticePanel = new System.Windows.Forms.Panel();
            this.ViewPollPanel = new System.Windows.Forms.Panel();
            this.ComplainPanel = new System.Windows.Forms.Panel();
            this.viewGradePanel = new System.Windows.Forms.Panel();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelStudentid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSubmitComplain = new System.Windows.Forms.Button();
            this.textBoxComplain = new System.Windows.Forms.TextBox();
            this.buttonPollSubmit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.textBoxViewPoll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelViewNotice = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonViewGrade = new System.Windows.Forms.Button();
            this.buttonComplain = new System.Windows.Forms.Button();
            this.buttonViewPoll = new System.Windows.Forms.Button();
            this.buttonViewNotice = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ViewNoticePanel.SuspendLayout();
            this.ViewPollPanel.SuspendLayout();
            this.ComplainPanel.SuspendLayout();
            this.viewGradePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 432);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(271, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 432);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ViewNoticePanel);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(133, 39);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(844, 393);
            this.panel4.TabIndex = 10;
            // 
            // ViewNoticePanel
            // 
            this.ViewNoticePanel.Controls.Add(this.ViewPollPanel);
            this.ViewNoticePanel.Controls.Add(this.label3);
            this.ViewNoticePanel.Controls.Add(this.flowLayoutPanelViewNotice);
            this.ViewNoticePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewNoticePanel.Location = new System.Drawing.Point(0, 0);
            this.ViewNoticePanel.Name = "ViewNoticePanel";
            this.ViewNoticePanel.Size = new System.Drawing.Size(844, 393);
            this.ViewNoticePanel.TabIndex = 1;
            // 
            // ViewPollPanel
            // 
            this.ViewPollPanel.Controls.Add(this.ComplainPanel);
            this.ViewPollPanel.Controls.Add(this.buttonPollSubmit);
            this.ViewPollPanel.Controls.Add(this.flowLayoutPanel1);
            this.ViewPollPanel.Controls.Add(this.textBoxViewPoll);
            this.ViewPollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPollPanel.Location = new System.Drawing.Point(0, 0);
            this.ViewPollPanel.Name = "ViewPollPanel";
            this.ViewPollPanel.Size = new System.Drawing.Size(844, 393);
            this.ViewPollPanel.TabIndex = 1;
            // 
            // ComplainPanel
            // 
            this.ComplainPanel.Controls.Add(this.viewGradePanel);
            this.ComplainPanel.Controls.Add(this.label2);
            this.ComplainPanel.Controls.Add(this.buttonSubmitComplain);
            this.ComplainPanel.Controls.Add(this.textBoxComplain);
            this.ComplainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComplainPanel.Location = new System.Drawing.Point(0, 0);
            this.ComplainPanel.Name = "ComplainPanel";
            this.ComplainPanel.Size = new System.Drawing.Size(844, 393);
            this.ComplainPanel.TabIndex = 3;
            // 
            // viewGradePanel
            // 
            this.viewGradePanel.Controls.Add(this.labelGrade);
            this.viewGradePanel.Controls.Add(this.labelSection);
            this.viewGradePanel.Controls.Add(this.labelCourse);
            this.viewGradePanel.Controls.Add(this.labelStudentid);
            this.viewGradePanel.Controls.Add(this.label7);
            this.viewGradePanel.Controls.Add(this.label6);
            this.viewGradePanel.Controls.Add(this.label5);
            this.viewGradePanel.Controls.Add(this.label4);
            this.viewGradePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewGradePanel.Location = new System.Drawing.Point(0, 0);
            this.viewGradePanel.Name = "viewGradePanel";
            this.viewGradePanel.Size = new System.Drawing.Size(844, 393);
            this.viewGradePanel.TabIndex = 2;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGrade.Location = new System.Drawing.Point(601, 102);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(0, 24);
            this.labelGrade.TabIndex = 7;
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSection.Location = new System.Drawing.Point(416, 102);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(0, 24);
            this.labelSection.TabIndex = 6;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCourse.Location = new System.Drawing.Point(228, 102);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(0, 24);
            this.labelCourse.TabIndex = 5;
            // 
            // labelStudentid
            // 
            this.labelStudentid.AutoSize = true;
            this.labelStudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelStudentid.Location = new System.Drawing.Point(49, 102);
            this.labelStudentid.Name = "labelStudentid";
            this.labelStudentid.Size = new System.Drawing.Size(0, 24);
            this.labelStudentid.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(601, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Current Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(416, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(228, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(46, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Complain Box";
            // 
            // buttonSubmitComplain
            // 
            this.buttonSubmitComplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitComplain.Location = new System.Drawing.Point(53, 244);
            this.buttonSubmitComplain.Name = "buttonSubmitComplain";
            this.buttonSubmitComplain.Size = new System.Drawing.Size(139, 40);
            this.buttonSubmitComplain.TabIndex = 1;
            this.buttonSubmitComplain.Text = "Submit Complain";
            this.buttonSubmitComplain.UseVisualStyleBackColor = true;
            this.buttonSubmitComplain.Click += new System.EventHandler(this.buttonSubmitComplain_Click);
            // 
            // textBoxComplain
            // 
            this.textBoxComplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComplain.Location = new System.Drawing.Point(53, 112);
            this.textBoxComplain.Multiline = true;
            this.textBoxComplain.Name = "textBoxComplain";
            this.textBoxComplain.Size = new System.Drawing.Size(741, 105);
            this.textBoxComplain.TabIndex = 0;
            // 
            // buttonPollSubmit
            // 
            this.buttonPollSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPollSubmit.Location = new System.Drawing.Point(521, 141);
            this.buttonPollSubmit.Name = "buttonPollSubmit";
            this.buttonPollSubmit.Size = new System.Drawing.Size(104, 35);
            this.buttonPollSubmit.TabIndex = 2;
            this.buttonPollSubmit.Text = "Submit";
            this.buttonPollSubmit.UseVisualStyleBackColor = true;
            this.buttonPollSubmit.Click += new System.EventHandler(this.buttonPollSubmit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.radioButton4);
            this.flowLayoutPanel1.Controls.Add(this.radioButton5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(445, 227);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 11);
            this.radioButton1.MinimumSize = new System.Drawing.Size(300, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(300, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(3, 30);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 11);
            this.radioButton2.MinimumSize = new System.Drawing.Size(300, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(300, 13);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton3.Location = new System.Drawing.Point(3, 57);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 11);
            this.radioButton3.MinimumSize = new System.Drawing.Size(300, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(300, 13);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton4.Location = new System.Drawing.Point(3, 84);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 11);
            this.radioButton4.MinimumSize = new System.Drawing.Size(300, 0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(300, 13);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton5.Location = new System.Drawing.Point(3, 111);
            this.radioButton5.MinimumSize = new System.Drawing.Size(300, 0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(300, 13);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            // 
            // textBoxViewPoll
            // 
            this.textBoxViewPoll.Enabled = false;
            this.textBoxViewPoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxViewPoll.Location = new System.Drawing.Point(50, 27);
            this.textBoxViewPoll.Multiline = true;
            this.textBoxViewPoll.Name = "textBoxViewPoll";
            this.textBoxViewPoll.Size = new System.Drawing.Size(734, 78);
            this.textBoxViewPoll.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(34, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Notice";
            // 
            // flowLayoutPanelViewNotice
            // 
            this.flowLayoutPanelViewNotice.AutoScroll = true;
            this.flowLayoutPanelViewNotice.Location = new System.Drawing.Point(38, 33);
            this.flowLayoutPanelViewNotice.Name = "flowLayoutPanelViewNotice";
            this.flowLayoutPanelViewNotice.Size = new System.Drawing.Size(765, 319);
            this.flowLayoutPanelViewNotice.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 83);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(339, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogout.BackgroundImage")));
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogout.Location = new System.Drawing.Point(906, 4);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(30, 31);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.buttonViewGrade);
            this.panel3.Controls.Add(this.buttonComplain);
            this.panel3.Controls.Add(this.buttonViewPoll);
            this.panel3.Controls.Add(this.buttonViewNotice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 432);
            this.panel3.TabIndex = 8;
            // 
            // buttonViewGrade
            // 
            this.buttonViewGrade.BackColor = System.Drawing.Color.Firebrick;
            this.buttonViewGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewGrade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonViewGrade.Location = new System.Drawing.Point(2, 218);
            this.buttonViewGrade.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewGrade.Name = "buttonViewGrade";
            this.buttonViewGrade.Size = new System.Drawing.Size(129, 38);
            this.buttonViewGrade.TabIndex = 3;
            this.buttonViewGrade.Text = "View Grade";
            this.buttonViewGrade.UseVisualStyleBackColor = false;
            this.buttonViewGrade.Click += new System.EventHandler(this.buttonViewGrade_Click);
            // 
            // buttonComplain
            // 
            this.buttonComplain.BackColor = System.Drawing.Color.Firebrick;
            this.buttonComplain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComplain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonComplain.Location = new System.Drawing.Point(2, 177);
            this.buttonComplain.Margin = new System.Windows.Forms.Padding(2);
            this.buttonComplain.Name = "buttonComplain";
            this.buttonComplain.Size = new System.Drawing.Size(129, 38);
            this.buttonComplain.TabIndex = 2;
            this.buttonComplain.Text = "Complain";
            this.buttonComplain.UseVisualStyleBackColor = false;
            this.buttonComplain.Click += new System.EventHandler(this.buttonComplain_Click);
            // 
            // buttonViewPoll
            // 
            this.buttonViewPoll.BackColor = System.Drawing.Color.Firebrick;
            this.buttonViewPoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewPoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewPoll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonViewPoll.Location = new System.Drawing.Point(2, 136);
            this.buttonViewPoll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewPoll.Name = "buttonViewPoll";
            this.buttonViewPoll.Size = new System.Drawing.Size(129, 38);
            this.buttonViewPoll.TabIndex = 1;
            this.buttonViewPoll.Text = "View Poll";
            this.buttonViewPoll.UseVisualStyleBackColor = false;
            this.buttonViewPoll.Click += new System.EventHandler(this.buttonViewPoll_Click);
            // 
            // buttonViewNotice
            // 
            this.buttonViewNotice.BackColor = System.Drawing.Color.Firebrick;
            this.buttonViewNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewNotice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonViewNotice.Location = new System.Drawing.Point(2, 95);
            this.buttonViewNotice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewNotice.Name = "buttonViewNotice";
            this.buttonViewNotice.Size = new System.Drawing.Size(129, 38);
            this.buttonViewNotice.TabIndex = 0;
            this.buttonViewNotice.Text = "View Notice";
            this.buttonViewNotice.UseVisualStyleBackColor = false;
            this.buttonViewNotice.Click += new System.EventHandler(this.buttonViewNotice_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(940, 4);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 31);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "x";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ViewNoticePanel.ResumeLayout(false);
            this.ViewNoticePanel.PerformLayout();
            this.ViewPollPanel.ResumeLayout(false);
            this.ViewPollPanel.PerformLayout();
            this.ComplainPanel.ResumeLayout(false);
            this.ComplainPanel.PerformLayout();
            this.viewGradePanel.ResumeLayout(false);
            this.viewGradePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonComplain;
        private System.Windows.Forms.Button buttonViewPoll;
        private System.Windows.Forms.Button buttonViewNotice;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel ViewNoticePanel;
        private System.Windows.Forms.Panel ViewPollPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonPollSubmit;
        private System.Windows.Forms.Panel ComplainPanel;
        private System.Windows.Forms.Button buttonSubmitComplain;
        private System.Windows.Forms.Panel viewGradePanel;
        private System.Windows.Forms.Button buttonViewGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelViewNotice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxViewPoll;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton5;
        public System.Windows.Forms.TextBox textBoxComplain;
        public System.Windows.Forms.Label labelGrade;
        public System.Windows.Forms.Label labelSection;
        public System.Windows.Forms.Label labelCourse;
        public System.Windows.Forms.Label labelStudentid;
        }
    }