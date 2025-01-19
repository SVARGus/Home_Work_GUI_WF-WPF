namespace Home_Work_15_01_2025_part_1
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
            textBoxEnter = new TextBox();
            textBoxResult = new TextBox();
            buttonUpperCase = new Button();
            buttonLowerCase = new Button();
            buttonClearTextBox = new Button();
            SuspendLayout();
            // 
            // textBoxEnter
            // 
            textBoxEnter.Location = new Point(12, 12);
            textBoxEnter.Multiline = true;
            textBoxEnter.Name = "textBoxEnter";
            textBoxEnter.Size = new Size(780, 168);
            textBoxEnter.TabIndex = 0;
            // 
            // textBoxResult
            // 
            textBoxResult.Enabled = false;
            textBoxResult.Location = new Point(12, 233);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(780, 168);
            textBoxResult.TabIndex = 5;
            // 
            // buttonUpperCase
            // 
            buttonUpperCase.Location = new Point(12, 193);
            buttonUpperCase.Name = "buttonUpperCase";
            buttonUpperCase.Size = new Size(321, 23);
            buttonUpperCase.TabIndex = 2;
            buttonUpperCase.Text = "Верхний регистр";
            buttonUpperCase.UseVisualStyleBackColor = true;
            buttonUpperCase.Click += buttonUp_Click;
            // 
            // buttonLowerCase
            // 
            buttonLowerCase.Location = new Point(471, 193);
            buttonLowerCase.Name = "buttonLowerCase";
            buttonLowerCase.Size = new Size(321, 23);
            buttonLowerCase.TabIndex = 3;
            buttonLowerCase.Text = "Нижний регистр";
            buttonLowerCase.UseVisualStyleBackColor = true;
            buttonLowerCase.Click += buttonLower_Click;
            // 
            // buttonClearTextBox
            // 
            buttonClearTextBox.BackColor = Color.FromArgb(255, 128, 128);
            buttonClearTextBox.Location = new Point(320, 415);
            buttonClearTextBox.Name = "buttonClearTextBox";
            buttonClearTextBox.Size = new Size(180, 23);
            buttonClearTextBox.TabIndex = 4;
            buttonClearTextBox.Text = "Очистить";
            buttonClearTextBox.UseVisualStyleBackColor = false;
            buttonClearTextBox.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(buttonClearTextBox);
            Controls.Add(buttonLowerCase);
            Controls.Add(buttonUpperCase);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxEnter);
            Name = "Form1";
            Text = "Смена регистра";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEnter;
        private TextBox textBoxResult;
        private Button buttonUpperCase;
        private Button buttonLowerCase;
        private Button buttonClearTextBox;
        // buttonUpperCase buttonLowerCase buttonClearTextBox
    }
}
