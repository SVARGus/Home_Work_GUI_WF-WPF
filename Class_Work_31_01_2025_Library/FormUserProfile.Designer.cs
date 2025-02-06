namespace Class_Work_31_01_2025_Library
{
    partial class FormUserProfile
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            EmailTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            label5 = new Label();
            RoleComboBox = new ComboBox();
            passwordTextBox = new TextBox();
            label6 = new Label();
            btSaveAccount = new Button();
            btCancel = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(14, 47);
            label1.Name = "label1";
            label1.Size = new Size(133, 31);
            label1.TabIndex = 0;
            label1.Text = "Email / Login";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(14, 124);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 1;
            label2.Text = "FirstName";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(14, 163);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 2;
            label3.Text = "LastName";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(14, 201);
            label4.Name = "label4";
            label4.Size = new Size(133, 31);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(153, 47);
            EmailTextBox.Margin = new Padding(3, 4, 3, 4);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(163, 27);
            EmailTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(153, 124);
            firstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(163, 27);
            firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(153, 163);
            lastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(163, 27);
            lastNameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(153, 201);
            phoneTextBox.Margin = new Padding(3, 4, 3, 4);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(163, 27);
            phoneTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.Location = new Point(14, 240);
            label5.Name = "label5";
            label5.Size = new Size(133, 31);
            label5.TabIndex = 8;
            label5.Text = "Roles";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RoleComboBox
            // 
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Location = new Point(153, 240);
            RoleComboBox.Margin = new Padding(3, 4, 3, 4);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(163, 28);
            RoleComboBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(153, 85);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(163, 27);
            passwordTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.Location = new Point(14, 85);
            label6.Name = "label6";
            label6.Size = new Size(133, 31);
            label6.TabIndex = 10;
            label6.Text = "Password";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btSaveAccount
            // 
            btSaveAccount.Location = new Point(14, 304);
            btSaveAccount.Margin = new Padding(3, 4, 3, 4);
            btSaveAccount.Name = "btSaveAccount";
            btSaveAccount.Size = new Size(133, 31);
            btSaveAccount.TabIndex = 12;
            btSaveAccount.Text = "Сохранить";
            btSaveAccount.UseVisualStyleBackColor = true;
            btSaveAccount.Click += btSaveAccount_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(184, 304);
            btCancel.Margin = new Padding(3, 4, 3, 4);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(133, 31);
            btCancel.TabIndex = 13;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(337, 31);
            label7.TabIndex = 14;
            label7.Text = "Заполните анкетные данные";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormUserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 361);
            Controls.Add(label7);
            Controls.Add(btCancel);
            Controls.Add(btSaveAccount);
            Controls.Add(passwordTextBox);
            Controls.Add(label6);
            Controls.Add(RoleComboBox);
            Controls.Add(label5);
            Controls.Add(phoneTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUserProfile";
            Text = "Данные профиля пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox EmailTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox phoneTextBox;
        private Label label5;
        private ComboBox RoleComboBox;
        private TextBox passwordTextBox;
        private Label label6;
        private Button btSaveAccount;
        private Button btCancel;
        private Label label7;
    }
}