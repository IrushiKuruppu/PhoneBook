namespace PhoneBook
{
    partial class frmPhoneDiary
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
            lblFirstName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblLastName = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            btnSave = new Button();
            btnLoad = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            PhoneBook = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PhoneBook).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(33, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(33, 129);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(33, 96);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(33, 63);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 239);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(186, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(439, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(439, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(186, 93);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(439, 27);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(186, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(439, 27);
            txtLastName.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(666, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(666, 59);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(147, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(666, 93);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(147, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(666, 129);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // PhoneBook
            // 
            PhoneBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PhoneBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PhoneBook.Location = new Point(35, 200);
            PhoneBook.Name = "PhoneBook";
            PhoneBook.RowHeadersWidth = 51;
            PhoneBook.RowTemplate.Height = 29;
            PhoneBook.Size = new Size(787, 185);
            PhoneBook.TabIndex = 13;
            // 
            // frmPhoneDiary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 427);
            Controls.Add(PhoneBook);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(txtLastName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(lblLastName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblFirstName);
            Name = "frmPhoneDiary";
            Text = "Telephone Diary";
            Load += frmPhoneDiary_Load;
            ((System.ComponentModel.ISupportInitialize)PhoneBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblLastName;
        private Label label4;
        private TextBox txtFirstName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private Button btnSave;
        private Button btnLoad;
        private Button btnClear;
        private Button btnDelete;
        private DataGridView PhoneBook;
    }
}