namespace Home_Work_20_01_2025_part_1
{
    partial class UserForm
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
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            textBoxPhone = new TextBox();
            label5 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(453, 25);
            label1.TabIndex = 0;
            label1.Text = "Анкетные данные";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(229, 41);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(211, 27);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(229, 74);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(211, 27);
            textBoxLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(211, 25);
            label3.TabIndex = 3;
            label3.Text = "Фамилия";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(229, 107);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(211, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(211, 25);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(229, 140);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(211, 27);
            textBoxPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(211, 25);
            label5.TabIndex = 7;
            label5.Text = "Телефон";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 195);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(211, 29);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(229, 195);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(211, 29);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 236);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPhone);
            Controls.Add(label5);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxPhone;
        private Label label5;
        private Button buttonSave;
        private Button buttonCancel;
    }
}