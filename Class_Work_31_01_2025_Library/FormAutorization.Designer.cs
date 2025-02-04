namespace Class_Work_31_01_2025_Library
{
    partial class FormAutorization
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
            loginButton = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(51, 124);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(200, 25);
            loginButton.TabIndex = 0;
            loginButton.Text = "Вход";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(28, 44);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(258, 23);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(28, 82);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(258, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(28, 13);
            label1.Name = "label1";
            label1.Size = new Size(258, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите логин и пароль";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAutorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 175);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(loginButton);
            Name = "FormAutorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label1;
    }
}
