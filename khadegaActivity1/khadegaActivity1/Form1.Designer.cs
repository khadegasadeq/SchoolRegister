namespace khadegaActivity1
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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("SE");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("IT");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("COM");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Engineering", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("manage");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Money");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Managment Collage ", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateOfBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbcoding = new System.Windows.Forms.CheckBox();
            this.chbwriting = new System.Windows.Forms.CheckBox();
            this.chbreading = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.listcity = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khadega School";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.dateOfBirthday);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(4, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 24);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // dateOfBirthday
            // 
            this.dateOfBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthday.Location = new System.Drawing.Point(57, 101);
            this.dateOfBirthday.Name = "dateOfBirthday";
            this.dateOfBirthday.Size = new System.Drawing.Size(93, 24);
            this.dateOfBirthday.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(81, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 24);
            this.txtPassword.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "DOB : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 24);
            this.txtName.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.rdoOther);
            this.groupBox2.Controls.Add(this.rdoFemale);
            this.groupBox2.Controls.Add(this.rdoMale);
            this.groupBox2.Location = new System.Drawing.Point(4, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Are You ? ";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(7, 69);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(64, 21);
            this.rdoOther.TabIndex = 4;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(6, 49);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(71, 21);
            this.rdoFemale.TabIndex = 0;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 26);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(55, 21);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.chbcoding);
            this.groupBox3.Controls.Add(this.chbwriting);
            this.groupBox3.Controls.Add(this.chbreading);
            this.groupBox3.Location = new System.Drawing.Point(4, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "what are your skills ?";
            // 
            // chbcoding
            // 
            this.chbcoding.AutoSize = true;
            this.chbcoding.Location = new System.Drawing.Point(6, 77);
            this.chbcoding.Name = "chbcoding";
            this.chbcoding.Size = new System.Drawing.Size(71, 21);
            this.chbcoding.TabIndex = 2;
            this.chbcoding.Text = "coding";
            this.chbcoding.UseVisualStyleBackColor = true;
            // 
            // chbwriting
            // 
            this.chbwriting.AutoSize = true;
            this.chbwriting.Location = new System.Drawing.Point(7, 50);
            this.chbwriting.Name = "chbwriting";
            this.chbwriting.Size = new System.Drawing.Size(70, 21);
            this.chbwriting.TabIndex = 1;
            this.chbwriting.Text = "writing";
            this.chbwriting.UseVisualStyleBackColor = true;
            // 
            // chbreading
            // 
            this.chbreading.AutoSize = true;
            this.chbreading.Location = new System.Drawing.Point(7, 23);
            this.chbreading.Name = "chbreading";
            this.chbreading.Size = new System.Drawing.Size(79, 21);
            this.chbreading.TabIndex = 0;
            this.chbreading.Text = "Reading";
            this.chbreading.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(476, 403);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Register :)";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // listcity
            // 
            this.listcity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listcity.FormattingEnabled = true;
            this.listcity.ItemHeight = 16;
            this.listcity.Items.AddRange(new object[] {
            "Taiz",
            "Sana\'a",
            "Aden"});
            this.listcity.Location = new System.Drawing.Point(293, 118);
            this.listcity.Name = "listcity";
            this.listcity.Size = new System.Drawing.Size(120, 84);
            this.listcity.TabIndex = 4;
            this.listcity.SelectedIndexChanged += new System.EventHandler(this.listcity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "You are from ?";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.treeView1.Location = new System.Drawing.Point(292, 225);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "Node1";
            treeNode15.Text = "SE";
            treeNode16.Name = "Node2";
            treeNode16.Text = "IT";
            treeNode17.Name = "Node4";
            treeNode17.Text = "COM";
            treeNode18.Name = "Node0";
            treeNode18.Text = "Engineering";
            treeNode19.Name = "Node6";
            treeNode19.Text = "manage";
            treeNode20.Name = "Node7";
            treeNode20.Text = "Money";
            treeNode21.Name = "Node5";
            treeNode21.Text = "Managment Collage ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(166, 141);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Yemen",
            "Egypt",
            "Oman",
            "Qatar"});
            this.cmbCountry.Location = new System.Drawing.Point(292, 33);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 24);
            this.cmbCountry.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Witch City if You are Yamani ?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(529, 212);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(34, 19);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "      ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(476, 441);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(476, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(591, 470);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 515);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listcity);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbcoding;
        private System.Windows.Forms.CheckBox chbwriting;
        private System.Windows.Forms.CheckBox chbreading;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox listcity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateOfBirthday;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

