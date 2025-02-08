namespace Home_and_Class_Work_31_01_2025_Library
{
    partial class OldForm_LibraryStaffForm
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
            allBooksListBox = new ListBox();
            btCreateBook = new Button();
            btExit = new Button();
            label1 = new Label();
            btEdeteBook = new Button();
            btDeletedBook = new Button();
            label2 = new Label();
            bookRequestsFromUsersListBox = new ListBox();
            btSaveBook = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // allBooksListBox
            // 
            allBooksListBox.FormattingEnabled = true;
            allBooksListBox.ItemHeight = 15;
            allBooksListBox.Location = new Point(10, 36);
            allBooksListBox.Margin = new Padding(3, 2, 3, 2);
            allBooksListBox.Name = "allBooksListBox";
            allBooksListBox.Size = new Size(670, 154);
            allBooksListBox.TabIndex = 0;
            // 
            // btCreateBook
            // 
            btCreateBook.Location = new Point(685, 49);
            btCreateBook.Margin = new Padding(3, 2, 3, 2);
            btCreateBook.Name = "btCreateBook";
            btCreateBook.Size = new Size(158, 22);
            btCreateBook.TabIndex = 1;
            btCreateBook.Text = "Добавить книгу";
            btCreateBook.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            btExit.Location = new Point(685, 9);
            btExit.Margin = new Padding(3, 2, 3, 2);
            btExit.Name = "btExit";
            btExit.Size = new Size(158, 22);
            btExit.TabIndex = 2;
            btExit.Text = "Выход";
            btExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(669, 25);
            label1.TabIndex = 3;
            label1.Text = "Бибилиотечный фонд книг (полный перечень)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btEdeteBook
            // 
            btEdeteBook.Location = new Point(685, 86);
            btEdeteBook.Margin = new Padding(3, 2, 3, 2);
            btEdeteBook.Name = "btEdeteBook";
            btEdeteBook.Size = new Size(158, 22);
            btEdeteBook.TabIndex = 4;
            btEdeteBook.Text = "Редактировать книгу";
            btEdeteBook.UseVisualStyleBackColor = true;
            // 
            // btDeletedBook
            // 
            btDeletedBook.Location = new Point(685, 123);
            btDeletedBook.Margin = new Padding(3, 2, 3, 2);
            btDeletedBook.Name = "btDeletedBook";
            btDeletedBook.Size = new Size(158, 22);
            btDeletedBook.TabIndex = 5;
            btDeletedBook.Text = "Удалить книгу";
            btDeletedBook.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(10, 198);
            label2.Name = "label2";
            label2.Size = new Size(669, 25);
            label2.TabIndex = 6;
            label2.Text = "Запросы на получение книг от посетителей";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookRequestsFromUsersListBox
            // 
            bookRequestsFromUsersListBox.FormattingEnabled = true;
            bookRequestsFromUsersListBox.ItemHeight = 15;
            bookRequestsFromUsersListBox.Location = new Point(10, 232);
            bookRequestsFromUsersListBox.Margin = new Padding(3, 2, 3, 2);
            bookRequestsFromUsersListBox.Name = "bookRequestsFromUsersListBox";
            bookRequestsFromUsersListBox.Size = new Size(670, 154);
            bookRequestsFromUsersListBox.TabIndex = 7;
            // 
            // btSaveBook
            // 
            btSaveBook.Location = new Point(685, 158);
            btSaveBook.Margin = new Padding(3, 2, 3, 2);
            btSaveBook.Name = "btSaveBook";
            btSaveBook.Size = new Size(158, 22);
            btSaveBook.TabIndex = 8;
            btSaveBook.Text = "Экспорт книг";
            btSaveBook.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(685, 258);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(158, 22);
            button1.TabIndex = 9;
            button1.Text = "Обработать запрос";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(685, 314);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(158, 22);
            button2.TabIndex = 10;
            button2.Text = "Отклонить запрос";
            button2.UseVisualStyleBackColor = true;
            // 
            // OldForm_LibraryStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 398);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btSaveBook);
            Controls.Add(bookRequestsFromUsersListBox);
            Controls.Add(label2);
            Controls.Add(btDeletedBook);
            Controls.Add(btEdeteBook);
            Controls.Add(label1);
            Controls.Add(btExit);
            Controls.Add(btCreateBook);
            Controls.Add(allBooksListBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OldForm_LibraryStaffForm";
            Text = "LibraryStaffForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox allBooksListBox;
        private Button btCreateBook;
        private Button btExit;
        private Label label1;
        private Button btEdeteBook;
        private Button btDeletedBook;
        private Label label2;
        private ListBox bookRequestsFromUsersListBox;
        private Button btSaveBook;
        private Button button1;
        private Button button2;
    }
}