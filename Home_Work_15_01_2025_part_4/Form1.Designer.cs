namespace Home_Work_15_01_2025_part_4
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
            buttonGame1 = new Button();
            buttonGame2 = new Button();
            label1 = new Label();
            textBoxEnterNum = new TextBox();
            SuspendLayout();
            // 
            // buttonGame1
            // 
            buttonGame1.Location = new Point(12, 77);
            buttonGame1.Name = "buttonGame1";
            buttonGame1.Size = new Size(140, 23);
            buttonGame1.TabIndex = 0;
            buttonGame1.Text = "Обычная угадайка";
            buttonGame1.UseVisualStyleBackColor = true;
            buttonGame1.Click += buttonGame1_Click;
            // 
            // buttonGame2
            // 
            buttonGame2.Location = new Point(195, 77);
            buttonGame2.Name = "buttonGame2";
            buttonGame2.Size = new Size(140, 23);
            buttonGame2.TabIndex = 1;
            buttonGame2.Text = "Больше - Меньше";
            buttonGame2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(260, 15);
            label1.TabIndex = 2;
            label1.Text = "В каком диапазоне будите загадывать: от 1 до ";
            // 
            // textBoxEnterNum
            // 
            textBoxEnterNum.Location = new Point(278, 33);
            textBoxEnterNum.Name = "textBoxEnterNum";
            textBoxEnterNum.Size = new Size(57, 23);
            textBoxEnterNum.TabIndex = 3;
            textBoxEnterNum.KeyPress += textBoxEnterNum_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 134);
            Controls.Add(textBoxEnterNum);
            Controls.Add(label1);
            Controls.Add(buttonGame2);
            Controls.Add(buttonGame1);
            Name = "Form1";
            Text = "Игра угадай число";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGame1;
        private Button buttonGame2;
        private Label label1;
        private TextBox textBoxEnterNum;
    }
}
