namespace formbuilder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tboxImpact = new System.Windows.Forms.TextBox();
            this.lstSeverity = new System.Windows.Forms.ListBox();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.lstCustPriority = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.tboxTicketNum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxExpected = new System.Windows.Forms.RichTextBox();
            this.tboxURL = new System.Windows.Forms.TextBox();
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxSteps = new System.Windows.Forms.RichTextBox();
            this.tboxWorkaround = new System.Windows.Forms.TextBox();
            this.tboxDetail = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tboxSubject = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tboxKnowledge = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.skinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pepeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asimovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxImpact
            // 
            this.tboxImpact.Location = new System.Drawing.Point(119, 129);
            this.tboxImpact.Name = "tboxImpact";
            this.tboxImpact.Size = new System.Drawing.Size(202, 20);
            this.tboxImpact.TabIndex = 4;
            this.tboxImpact.Leave += new System.EventHandler(this.tboxSubject_Leave);
            // 
            // lstSeverity
            // 
            this.lstSeverity.FormattingEnabled = true;
            this.lstSeverity.Location = new System.Drawing.Point(119, 80);
            this.lstSeverity.Name = "lstSeverity";
            this.lstSeverity.Size = new System.Drawing.Size(123, 43);
            this.lstSeverity.TabIndex = 3;
            // 
            // rtOutput
            // 
            this.rtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtOutput.Location = new System.Drawing.Point(439, 232);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.Size = new System.Drawing.Size(292, 214);
            this.rtOutput.TabIndex = 17;
            this.rtOutput.Text = "";
            // 
            // lstCustPriority
            // 
            this.lstCustPriority.FormattingEnabled = true;
            this.lstCustPriority.Location = new System.Drawing.Point(119, 155);
            this.lstCustPriority.Name = "lstCustPriority";
            this.lstCustPriority.Size = new System.Drawing.Size(123, 56);
            this.lstCustPriority.TabIndex = 6;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(439, 452);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(551, 452);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(373, 230);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(60, 23);
            this.btnClearAll.TabIndex = 17;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // tboxTicketNum
            // 
            this.tboxTicketNum.Location = new System.Drawing.Point(119, 26);
            this.tboxTicketNum.MaxLength = 7;
            this.tboxTicketNum.Name = "tboxTicketNum";
            this.tboxTicketNum.Size = new System.Drawing.Size(87, 20);
            this.tboxTicketNum.TabIndex = 1;
            this.tboxTicketNum.Leave += new System.EventHandler(this.tboxTicketNum_Leave);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(656, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save To File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Short Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = " Severity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = " Impact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = " Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Expected Results";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "V1";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tboxExpected
            // 
            this.tboxExpected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tboxExpected.Location = new System.Drawing.Point(119, 232);
            this.tboxExpected.Name = "tboxExpected";
            this.tboxExpected.Size = new System.Drawing.Size(248, 64);
            this.tboxExpected.TabIndex = 7;
            this.tboxExpected.Text = "";
            // 
            // tboxURL
            // 
            this.tboxURL.Location = new System.Drawing.Point(116, 32);
            this.tboxURL.MaxLength = 400;
            this.tboxURL.Name = "tboxURL";
            this.tboxURL.Size = new System.Drawing.Size(193, 20);
            this.tboxURL.TabIndex = 8;
            this.tboxURL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tboxUser
            // 
            this.tboxUser.Location = new System.Drawing.Point(116, 58);
            this.tboxUser.MaxLength = 60;
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(129, 20);
            this.tboxUser.TabIndex = 9;
            this.tboxUser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(116, 84);
            this.tboxPassword.MaxLength = 50;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(129, 20);
            this.tboxPassword.TabIndex = 10;
            this.tboxPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "URL";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tboxPassword);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tboxUser);
            this.groupBox1.Controls.Add(this.tboxURL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 120);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logins, URL & Passwords";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tboxSteps
            // 
            this.tboxSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxSteps.Location = new System.Drawing.Point(497, 24);
            this.tboxSteps.Name = "tboxSteps";
            this.tboxSteps.Size = new System.Drawing.Size(202, 43);
            this.tboxSteps.TabIndex = 11;
            this.tboxSteps.Text = "";
            // 
            // tboxWorkaround
            // 
            this.tboxWorkaround.Location = new System.Drawing.Point(497, 73);
            this.tboxWorkaround.Name = "tboxWorkaround";
            this.tboxWorkaround.Size = new System.Drawing.Size(202, 20);
            this.tboxWorkaround.TabIndex = 12;
            // 
            // tboxDetail
            // 
            this.tboxDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxDetail.Location = new System.Drawing.Point(497, 99);
            this.tboxDetail.Name = "tboxDetail";
            this.tboxDetail.Size = new System.Drawing.Size(202, 69);
            this.tboxDetail.TabIndex = 13;
            this.tboxDetail.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Steps to Reproduce";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Workaround";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(389, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Detailed Description";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tboxSubject
            // 
            this.tboxSubject.Location = new System.Drawing.Point(119, 51);
            this.tboxSubject.MaxLength = 150;
            this.tboxSubject.Name = "tboxSubject";
            this.tboxSubject.Size = new System.Drawing.Size(248, 20);
            this.tboxSubject.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Case ID";
            // 
            // tboxKnowledge
            // 
            this.tboxKnowledge.Location = new System.Drawing.Point(497, 191);
            this.tboxKnowledge.MaxLength = 150;
            this.tboxKnowledge.Name = "tboxKnowledge";
            this.tboxKnowledge.Size = new System.Drawing.Size(202, 20);
            this.tboxKnowledge.TabIndex = 39;
            this.tboxKnowledge.ReadOnlyChanged += new System.EventHandler(this.textBox1_ReadOnlyChanged);
            this.tboxKnowledge.TextChanged += new System.EventHandler(this.tboxKnowledge_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(392, 172);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 17);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Knowledgebase Utilised";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(436, 485);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 13);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Built by Corey Rodgers";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "https://www.linkedin.com/in/corey-rodgers/";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skinsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(766, 24);
            this.menuStrip2.TabIndex = 44;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // skinsToolStripMenuItem
            // 
            this.skinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pepeToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.asimovToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.skinsToolStripMenuItem.Name = "skinsToolStripMenuItem";
            this.skinsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.skinsToolStripMenuItem.Text = "Skins..";
            this.skinsToolStripMenuItem.Visible = false;
            // 
            // pepeToolStripMenuItem
            // 
            this.pepeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyToolStripMenuItem});
            this.pepeToolStripMenuItem.Name = "pepeToolStripMenuItem";
            this.pepeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pepeToolStripMenuItem.Text = "Pepe";
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.applyToolStripMenuItem.Text = "Apply";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyToolStripMenuItem1});
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // applyToolStripMenuItem1
            // 
            this.applyToolStripMenuItem1.Name = "applyToolStripMenuItem1";
            this.applyToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.applyToolStripMenuItem1.Text = "Apply";
            // 
            // asimovToolStripMenuItem
            // 
            this.asimovToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyToolStripMenuItem2});
            this.asimovToolStripMenuItem.Name = "asimovToolStripMenuItem";
            this.asimovToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asimovToolStripMenuItem.Text = "Asimov";
            // 
            // applyToolStripMenuItem2
            // 
            this.applyToolStripMenuItem2.Name = "applyToolStripMenuItem2";
            this.applyToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.applyToolStripMenuItem2.Text = "Apply";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyToolStripMenuItem3});
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // applyToolStripMenuItem3
            // 
            this.applyToolStripMenuItem3.Name = "applyToolStripMenuItem3";
            this.applyToolStripMenuItem3.Size = new System.Drawing.Size(105, 22);
            this.applyToolStripMenuItem3.Text = "Apply";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 507);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tboxKnowledge);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tboxSubject);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tboxDetail);
            this.Controls.Add(this.tboxWorkaround);
            this.Controls.Add(this.tboxSteps);
            this.Controls.Add(this.tboxExpected);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tboxTicketNum);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lstCustPriority);
            this.Controls.Add(this.rtOutput);
            this.Controls.Add(this.lstSeverity);
            this.Controls.Add(this.tboxImpact);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxImpact;
        private System.Windows.Forms.ListBox lstSeverity;
        private System.Windows.Forms.RichTextBox rtOutput;
        private System.Windows.Forms.ListBox lstCustPriority;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox tboxTicketNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tboxExpected;
        private System.Windows.Forms.TextBox tboxURL;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tboxSteps;
        private System.Windows.Forms.TextBox tboxWorkaround;
        private System.Windows.Forms.RichTextBox tboxDetail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tboxSubject;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tboxKnowledge;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem skinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pepeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asimovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem3;
    }
}

