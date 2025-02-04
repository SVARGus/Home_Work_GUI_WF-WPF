namespace Class_Work_31_01_2025_Library
{
    partial class AdminMainWindows
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
            accountListBox = new ListBox();
            btCreateAccount = new Button();
            btExitAdmin = new Button();
            btImportAccount = new Button();
            btDeleteAccount = new Button();
            btEdeteAccount = new Button();
            SuspendLayout();
            // 
            // accountListBox
            // 
            accountListBox.FormattingEnabled = true;
            accountListBox.ItemHeight = 15;
            accountListBox.Location = new Point(43, 70);
            accountListBox.Name = "accountListBox";
            accountListBox.Size = new Size(624, 214);
            accountListBox.TabIndex = 0;
            // 
            // btCreateAccount
            // 
            btCreateAccount.BackColor = Color.PaleGreen;
            btCreateAccount.Location = new Point(43, 23);
            btCreateAccount.Name = "btCreateAccount";
            btCreateAccount.Size = new Size(298, 23);
            btCreateAccount.TabIndex = 1;
            btCreateAccount.Text = "Создать пользователя";
            btCreateAccount.UseVisualStyleBackColor = false;
            btCreateAccount.Click += btCreateAccount_Click;
            // 
            // btExitAdmin
            // 
            btExitAdmin.Location = new Point(571, 23);
            btExitAdmin.Name = "btExitAdmin";
            btExitAdmin.Size = new Size(96, 23);
            btExitAdmin.TabIndex = 2;
            btExitAdmin.Text = "Выход";
            btExitAdmin.UseVisualStyleBackColor = true;
            btExitAdmin.Click += btExitAdmin_Click;
            // 
            // btImportAccount
            // 
            btImportAccount.Location = new Point(43, 335);
            btImportAccount.Name = "btImportAccount";
            btImportAccount.Size = new Size(226, 23);
            btImportAccount.TabIndex = 3;
            btImportAccount.Text = "Импорт";
            btImportAccount.UseVisualStyleBackColor = true;
            btImportAccount.Click += btImportAccount_Click;
            // 
            // btDeleteAccount
            // 
            btDeleteAccount.BackColor = Color.IndianRed;
            btDeleteAccount.Location = new Point(441, 335);
            btDeleteAccount.Name = "btDeleteAccount";
            btDeleteAccount.Size = new Size(226, 23);
            btDeleteAccount.TabIndex = 4;
            btDeleteAccount.Text = "Удалить";
            btDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // btEdeteAccount
            // 
            btEdeteAccount.Location = new Point(441, 299);
            btEdeteAccount.Name = "btEdeteAccount";
            btEdeteAccount.Size = new Size(226, 23);
            btEdeteAccount.TabIndex = 5;
            btEdeteAccount.Text = "Редактировать";
            btEdeteAccount.UseVisualStyleBackColor = true;
            btEdeteAccount.Click += btEdeteAccount_Click;
            // 
            // AdminMainWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 377);
            Controls.Add(btEdeteAccount);
            Controls.Add(btDeleteAccount);
            Controls.Add(btImportAccount);
            Controls.Add(btExitAdmin);
            Controls.Add(btCreateAccount);
            Controls.Add(accountListBox);
            Name = "AdminMainWindows";
            Text = "AdminMainWindows";
            ResumeLayout(false);
        }

        #endregion

        private ListBox accountListBox;
        private Button btCreateAccount;
        private Button btExitAdmin;
        private Button btImportAccount;
        private Button btDeleteAccount;
        private Button btEdeteAccount;
    }
}