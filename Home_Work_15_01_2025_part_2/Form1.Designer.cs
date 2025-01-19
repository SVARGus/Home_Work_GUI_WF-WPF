namespace Home_Work_15_01_2025_part_2
{
    partial class Form1
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
            profileForm = new GroupBox();
            radioButtonGenderWoman = new RadioButton();
            radioButtonGenderMale = new RadioButton();
            textBoxPhone = new TextBox();
            textBoxCity = new TextBox();
            textBoxCountry = new TextBox();
            textBoxMiddlename = new TextBox();
            textBoxFirstname = new TextBox();
            textBoxLastname = new TextBox();
            dateTimePickerBirth = new DateTimePicker();
            labelGender = new Label();
            labelBirth = new Label();
            labelPhone = new Label();
            labelCity = new Label();
            labelCountry = new Label();
            labelMiddlename = new Label();
            labelFirstname = new Label();
            labelLastname = new Label();
            buttonShowResult = new Button();
            profileForm.SuspendLayout();
            SuspendLayout();
            // 
            // profileForm
            // 
            profileForm.Controls.Add(radioButtonGenderWoman);
            profileForm.Controls.Add(radioButtonGenderMale);
            profileForm.Controls.Add(textBoxPhone);
            profileForm.Controls.Add(textBoxCity);
            profileForm.Controls.Add(textBoxCountry);
            profileForm.Controls.Add(textBoxMiddlename);
            profileForm.Controls.Add(textBoxFirstname);
            profileForm.Controls.Add(textBoxLastname);
            profileForm.Controls.Add(dateTimePickerBirth);
            profileForm.Controls.Add(labelGender);
            profileForm.Controls.Add(labelBirth);
            profileForm.Controls.Add(labelPhone);
            profileForm.Controls.Add(labelCity);
            profileForm.Controls.Add(labelCountry);
            profileForm.Controls.Add(labelMiddlename);
            profileForm.Controls.Add(labelFirstname);
            profileForm.Controls.Add(labelLastname);
            profileForm.Location = new Point(12, 12);
            profileForm.Name = "profileForm";
            profileForm.Size = new Size(405, 343);
            profileForm.TabIndex = 0;
            profileForm.TabStop = false;
            profileForm.Text = "Анкета";
            // 
            // radioButtonGenderWoman
            // 
            radioButtonGenderWoman.AutoSize = true;
            radioButtonGenderWoman.Location = new Point(272, 300);
            radioButtonGenderWoman.Name = "radioButtonGenderWoman";
            radioButtonGenderWoman.Size = new Size(75, 19);
            radioButtonGenderWoman.TabIndex = 16;
            radioButtonGenderWoman.TabStop = true;
            radioButtonGenderWoman.Text = "Женский";
            radioButtonGenderWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderMale
            // 
            radioButtonGenderMale.AutoSize = true;
            radioButtonGenderMale.Location = new Point(166, 300);
            radioButtonGenderMale.Name = "radioButtonGenderMale";
            radioButtonGenderMale.Size = new Size(77, 19);
            radioButtonGenderMale.TabIndex = 15;
            radioButtonGenderMale.TabStop = true;
            radioButtonGenderMale.Text = "Мужской";
            radioButtonGenderMale.UseVisualStyleBackColor = true;
            radioButtonGenderMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(115, 193);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(251, 23);
            textBoxPhone.TabIndex = 14;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(115, 164);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(251, 23);
            textBoxCity.TabIndex = 13;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(115, 137);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(251, 23);
            textBoxCountry.TabIndex = 12;
            // 
            // textBoxMiddlename
            // 
            textBoxMiddlename.Location = new Point(115, 90);
            textBoxMiddlename.Name = "textBoxMiddlename";
            textBoxMiddlename.Size = new Size(251, 23);
            textBoxMiddlename.TabIndex = 11;
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(115, 61);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(251, 23);
            textBoxFirstname.TabIndex = 10;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(115, 32);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(251, 23);
            textBoxLastname.TabIndex = 9;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(166, 251);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(200, 23);
            dateTimePickerBirth.TabIndex = 8;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(19, 300);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(30, 15);
            labelGender.TabIndex = 7;
            labelGender.Text = "Пол";
            // 
            // labelBirth
            // 
            labelBirth.AutoSize = true;
            labelBirth.Location = new Point(19, 251);
            labelBirth.Name = "labelBirth";
            labelBirth.Size = new Size(90, 15);
            labelBirth.TabIndex = 6;
            labelBirth.Text = "Дата рождения";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(19, 193);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(55, 15);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Телефон";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(19, 164);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(40, 15);
            labelCity.TabIndex = 4;
            labelCity.Text = "Город";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(19, 137);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(46, 15);
            labelCountry.TabIndex = 3;
            labelCountry.Text = "Страна";
            // 
            // labelMiddlename
            // 
            labelMiddlename.AutoSize = true;
            labelMiddlename.Location = new Point(19, 90);
            labelMiddlename.Name = "labelMiddlename";
            labelMiddlename.Size = new Size(58, 15);
            labelMiddlename.TabIndex = 2;
            labelMiddlename.Text = "Отчество";
            // 
            // labelFirstname
            // 
            labelFirstname.AutoSize = true;
            labelFirstname.Location = new Point(19, 61);
            labelFirstname.Name = "labelFirstname";
            labelFirstname.Size = new Size(31, 15);
            labelFirstname.TabIndex = 1;
            labelFirstname.Text = "Имя";
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Location = new Point(19, 32);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(58, 15);
            labelLastname.TabIndex = 0;
            labelLastname.Text = "Фамилия";
            labelLastname.Click += label1_Click;
            // 
            // buttonShowResult
            // 
            buttonShowResult.BackColor = Color.FromArgb(128, 128, 255);
            buttonShowResult.Location = new Point(12, 361);
            buttonShowResult.Name = "buttonShowResult";
            buttonShowResult.Size = new Size(405, 23);
            buttonShowResult.TabIndex = 1;
            buttonShowResult.Text = "ПОСМОТРЕТЬ РЕЗУЛЬТАТЫ";
            buttonShowResult.UseVisualStyleBackColor = false;
            buttonShowResult.Click += buttonShowResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 396);
            Controls.Add(buttonShowResult);
            Controls.Add(profileForm);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Анкета";
            profileForm.ResumeLayout(false);
            profileForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox profileForm;
        private Button buttonShowResult;
        private Label labelLastname;
        private TextBox textBoxMiddlename;
        private TextBox textBoxFirstname;
        private TextBox textBoxLastname;
        private DateTimePicker dateTimePickerBirth;
        private Label labelGender;
        private Label labelBirth;
        private Label labelPhone;
        private Label labelCity;
        private Label labelCountry;
        private Label labelMiddlename;
        private Label labelFirstname;
        private RadioButton radioButtonGenderMale;
        private TextBox textBoxPhone;
        private TextBox textBoxCity;
        private TextBox textBoxCountry;
        private RadioButton radioButtonGenderWoman;
    }
}
