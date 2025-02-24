namespace GenClass
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cboType = new ComboBox();
            label2 = new Label();
            txtServer = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            btnVerify = new Button();
            label5 = new Label();
            cboDb = new ComboBox();
            label6 = new Label();
            btnGenerate = new Button();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 44);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // cboType
            // 
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "SQL", "MySQL" });
            cboType.Location = new Point(128, 36);
            cboType.Name = "cboType";
            cboType.Size = new Size(121, 23);
            cboType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 73);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Server";
            // 
            // txtServer
            // 
            txtServer.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtServer.Location = new Point(128, 65);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(121, 23);
            txtServer.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(128, 94);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(121, 23);
            txtUsername.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 102);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(128, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(121, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 131);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(174, 152);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(75, 23);
            btnVerify.TabIndex = 8;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 36);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 9;
            label5.Text = "Database";
            // 
            // cboDb
            // 
            cboDb.FormattingEnabled = true;
            cboDb.Location = new Point(409, 28);
            cboDb.Name = "cboDb";
            cboDb.Size = new Size(284, 23);
            cboDb.TabIndex = 10;
            cboDb.SelectedIndexChanged += cboDb_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 73);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 11;
            label6.Text = "Table";
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerate.Location = new Point(618, 255);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 14;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(410, 65);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(283, 184);
            checkedListBox1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 311);
            Controls.Add(checkedListBox1);
            Controls.Add(btnGenerate);
            Controls.Add(label6);
            Controls.Add(cboDb);
            Controls.Add(label5);
            Controls.Add(btnVerify);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtServer);
            Controls.Add(label2);
            Controls.Add(cboType);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboType;
        private Label label2;
        private TextBox txtServer;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private Button btnVerify;
        private Label label5;
        private ComboBox cboDb;
        private Label label6;
        private ComboBox cboTable;
        private CheckedListBox lst;
        private Button btnGenerate;
        private CheckedListBox checkedListBox1;
    }
}
