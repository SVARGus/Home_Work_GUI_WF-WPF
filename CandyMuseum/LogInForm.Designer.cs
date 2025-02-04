namespace CandyMuseum
{
    partial class LogInForm
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
            buttonEnterStorage = new Button();
            label1 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonEnterStorage
            // 
            buttonEnterStorage.Location = new Point(109, 170);
            buttonEnterStorage.Margin = new Padding(3, 4, 3, 4);
            buttonEnterStorage.Name = "buttonEnterStorage";
            buttonEnterStorage.Size = new Size(86, 30);
            buttonEnterStorage.TabIndex = 0;
            buttonEnterStorage.Text = "Войти";
            buttonEnterStorage.UseVisualStyleBackColor = true;
            buttonEnterStorage.Click += buttonEnterStorage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(298, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите логин и пароль администратора";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(21, 68);
            textBoxLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(266, 27);
            textBoxLogin.TabIndex = 2;
            textBoxLogin.Text = "admin";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(21, 118);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(266, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.Text = "12345";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 224);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            Controls.Add(buttonEnterStorage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogInForm";
            Text = "LogInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnterStorage;
        private Label label1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
    }
}