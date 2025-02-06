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
            components = new System.ComponentModel.Container();
            loginButton = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(58, 165);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(229, 33);
            loginButton.TabIndex = 0;
            loginButton.Text = "Вход";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(32, 59);
            textBoxLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(294, 27);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(32, 109);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(294, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(32, 17);
            label1.Name = "label1";
            label1.Size = new Size(295, 20);
            label1.TabIndex = 3;
            label1.Text = "Введите логин и пароль";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAutorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 233);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(loginButton);
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolTip toolTip1;
    }
}
