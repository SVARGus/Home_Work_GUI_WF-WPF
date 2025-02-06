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
            accountListBox.ItemHeight = 25;
            accountListBox.Location = new Point(61, 117);
            accountListBox.Margin = new Padding(4, 5, 4, 5);
            accountListBox.Name = "accountListBox";
            accountListBox.Size = new Size(890, 354);
            accountListBox.TabIndex = 0;
            // 
            // btCreateAccount
            // 
            btCreateAccount.BackColor = Color.PaleGreen;
            btCreateAccount.Location = new Point(61, 38);
            btCreateAccount.Margin = new Padding(4, 5, 4, 5);
            btCreateAccount.Name = "btCreateAccount";
            btCreateAccount.Size = new Size(426, 38);
            btCreateAccount.TabIndex = 1;
            btCreateAccount.Text = "Создать пользователя";
            btCreateAccount.UseVisualStyleBackColor = false;
            btCreateAccount.Click += btCreateAccount_Click;
            // 
            // btExitAdmin
            // 
            btExitAdmin.Location = new Point(816, 38);
            btExitAdmin.Margin = new Padding(4, 5, 4, 5);
            btExitAdmin.Name = "btExitAdmin";
            btExitAdmin.Size = new Size(137, 38);
            btExitAdmin.TabIndex = 2;
            btExitAdmin.Text = "Выход";
            btExitAdmin.UseVisualStyleBackColor = true;
            btExitAdmin.Click += btExitAdmin_Click;
            // 
            // btImportAccount
            // 
            btImportAccount.Location = new Point(61, 558);
            btImportAccount.Margin = new Padding(4, 5, 4, 5);
            btImportAccount.Name = "btImportAccount";
            btImportAccount.Size = new Size(323, 38);
            btImportAccount.TabIndex = 3;
            btImportAccount.Text = "Импорт";
            btImportAccount.UseVisualStyleBackColor = true;
            btImportAccount.Click += btImportAccount_Click;
            // 
            // btDeleteAccount
            // 
            btDeleteAccount.BackColor = Color.IndianRed;
            btDeleteAccount.Location = new Point(630, 558);
            btDeleteAccount.Margin = new Padding(4, 5, 4, 5);
            btDeleteAccount.Name = "btDeleteAccount";
            btDeleteAccount.Size = new Size(323, 38);
            btDeleteAccount.TabIndex = 4;
            btDeleteAccount.Text = "Удалить";
            btDeleteAccount.UseVisualStyleBackColor = false;
            btDeleteAccount.Click += btDeleteAccount_Click;
            // 
            // btEdeteAccount
            // 
            btEdeteAccount.Location = new Point(630, 498);
            btEdeteAccount.Margin = new Padding(4, 5, 4, 5);
            btEdeteAccount.Name = "btEdeteAccount";
            btEdeteAccount.Size = new Size(323, 38);
            btEdeteAccount.TabIndex = 5;
            btEdeteAccount.Text = "Редактировать";
            btEdeteAccount.UseVisualStyleBackColor = true;
            btEdeteAccount.Click += btEdeteAccount_Click;
            // 
            // AdminMainWindows
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 628);
            Controls.Add(btEdeteAccount);
            Controls.Add(btDeleteAccount);
            Controls.Add(btImportAccount);
            Controls.Add(btExitAdmin);
            Controls.Add(btCreateAccount);
            Controls.Add(accountListBox);
            Margin = new Padding(4, 5, 4, 5);
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