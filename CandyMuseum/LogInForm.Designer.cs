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
            buttonEnterStorage.Location = new Point(136, 213);
            buttonEnterStorage.Margin = new Padding(4, 5, 4, 5);
            buttonEnterStorage.Name = "buttonEnterStorage";
            buttonEnterStorage.Size = new Size(107, 38);
            buttonEnterStorage.TabIndex = 0;
            buttonEnterStorage.Text = "Войти";
            buttonEnterStorage.UseVisualStyleBackColor = true;
            buttonEnterStorage.Click += buttonEnterStorage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 25);
            label1.TabIndex = 1;
            label1.Text = "Введите логин и пароль администратора";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(26, 85);
            textBoxLogin.Margin = new Padding(4, 5, 4, 5);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(331, 31);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(26, 148);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(331, 31);
            textBoxPassword.TabIndex = 3;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 280);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            Controls.Add(buttonEnterStorage);
            Margin = new Padding(4, 5, 4, 5);
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