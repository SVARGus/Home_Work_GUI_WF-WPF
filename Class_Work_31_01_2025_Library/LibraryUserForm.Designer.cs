namespace Home_and_Class_Work_31_01_2025_Library
{
    partial class LibraryUserForm
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
            textBoxPublisher = new TextBox();
            textBoxGenre = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxTitle = new TextBox();
            textBoxDescription = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bookListBox = new ListBox();
            SuspendLayout();
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Location = new Point(709, 143);
            textBoxPublisher.Margin = new Padding(3, 4, 3, 4);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.ReadOnly = true;
            textBoxPublisher.Size = new Size(443, 27);
            textBoxPublisher.TabIndex = 20;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(709, 104);
            textBoxGenre.Margin = new Padding(3, 4, 3, 4);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.ReadOnly = true;
            textBoxGenre.Size = new Size(443, 27);
            textBoxGenre.TabIndex = 19;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(709, 65);
            textBoxAuthor.Margin = new Padding(3, 4, 3, 4);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.ReadOnly = true;
            textBoxAuthor.Size = new Size(443, 27);
            textBoxAuthor.TabIndex = 18;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(709, 27);
            textBoxTitle.Margin = new Padding(3, 4, 3, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.ReadOnly = true;
            textBoxTitle.Size = new Size(443, 27);
            textBoxTitle.TabIndex = 17;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(545, 197);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(607, 511);
            textBoxDescription.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(545, 140);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 15;
            label4.Text = "Издатель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(548, 101);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 14;
            label3.Text = "Жанр";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(545, 63);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 13;
            label2.Text = "Автор";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(545, 29);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 12;
            label1.Text = "Название текста";
            // 
            // bookListBox
            // 
            bookListBox.FormattingEnabled = true;
            bookListBox.Location = new Point(13, 24);
            bookListBox.Margin = new Padding(3, 4, 3, 4);
            bookListBox.Name = "bookListBox";
            bookListBox.Size = new Size(500, 684);
            bookListBox.TabIndex = 11;
            bookListBox.Click += bookListBox_Click;
            // 
            // LibraryUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 732);
            Controls.Add(textBoxPublisher);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bookListBox);
            Name = "LibraryUserForm";
            Text = "LibraryUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPublisher;
        private TextBox textBoxGenre;
        private TextBox textBoxAuthor;
        private TextBox textBoxTitle;
        private TextBox textBoxDescription;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox bookListBox;
    }
}