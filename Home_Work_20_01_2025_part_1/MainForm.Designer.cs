namespace Home_Work_20_01_2025_part_1
{
    partial class MainForm
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
            listBoxUsers = new ListBox();
            buttonAddUser = new Button();
            buttonEditUser = new Button();
            buttonDeleteUser = new Button();
            buttonImportUser = new Button();
            buttonExportUser = new Button();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(29, 25);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(462, 224);
            listBoxUsers.TabIndex = 0;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(29, 275);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(462, 29);
            buttonAddUser.TabIndex = 1;
            buttonAddUser.Text = "Добавить нового Пользователя";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonEditUser
            // 
            buttonEditUser.Location = new Point(29, 310);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(208, 53);
            buttonEditUser.TabIndex = 2;
            buttonEditUser.Text = "Редактировать Пользователя";
            buttonEditUser.UseVisualStyleBackColor = true;
            buttonEditUser.Click += buttonEditUser_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Location = new Point(283, 310);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(208, 53);
            buttonDeleteUser.TabIndex = 3;
            buttonDeleteUser.Text = "Удалить Пользователя";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // buttonImportUser
            // 
            buttonImportUser.Location = new Point(283, 369);
            buttonImportUser.Name = "buttonImportUser";
            buttonImportUser.Size = new Size(208, 53);
            buttonImportUser.TabIndex = 5;
            buttonImportUser.Text = "Загрузить данные";
            buttonImportUser.UseVisualStyleBackColor = true;
            // 
            // buttonExportUser
            // 
            buttonExportUser.Location = new Point(29, 369);
            buttonExportUser.Name = "buttonExportUser";
            buttonExportUser.Size = new Size(208, 53);
            buttonExportUser.TabIndex = 4;
            buttonExportUser.Text = "Сохранить данные";
            buttonExportUser.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(buttonImportUser);
            Controls.Add(buttonExportUser);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonEditUser);
            Controls.Add(buttonAddUser);
            Controls.Add(listBoxUsers);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUsers;
        private Button buttonAddUser;
        private Button buttonEditUser;
        private Button buttonDeleteUser;
        private Button buttonImportUser;
        private Button buttonExportUser;
    }
}
