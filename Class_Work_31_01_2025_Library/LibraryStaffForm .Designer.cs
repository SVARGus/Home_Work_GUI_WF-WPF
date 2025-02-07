﻿namespace Home_and_Class_Work_31_01_2025_Library
{
    partial class LibraryStaffForm
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
            allBooksListBox.Location = new Point(12, 48);
            allBooksListBox.Name = "allBooksListBox";
            allBooksListBox.Size = new Size(765, 204);
            allBooksListBox.TabIndex = 0;
            // 
            // btCreateBook
            // 
            btCreateBook.Location = new Point(783, 65);
            btCreateBook.Name = "btCreateBook";
            btCreateBook.Size = new Size(180, 29);
            btCreateBook.TabIndex = 1;
            btCreateBook.Text = "Добавить книгу";
            btCreateBook.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            btExit.Location = new Point(783, 12);
            btExit.Name = "btExit";
            btExit.Size = new Size(180, 29);
            btExit.TabIndex = 2;
            btExit.Text = "Выход";
            btExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(765, 33);
            label1.TabIndex = 3;
            label1.Text = "Бибилиотечный фонд книг (полный перечень)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btEdeteBook
            // 
            btEdeteBook.Location = new Point(783, 114);
            btEdeteBook.Name = "btEdeteBook";
            btEdeteBook.Size = new Size(180, 29);
            btEdeteBook.TabIndex = 4;
            btEdeteBook.Text = "Редактировать книгу";
            btEdeteBook.UseVisualStyleBackColor = true;
            // 
            // btDeletedBook
            // 
            btDeletedBook.Location = new Point(783, 164);
            btDeletedBook.Name = "btDeletedBook";
            btDeletedBook.Size = new Size(180, 29);
            btDeletedBook.TabIndex = 5;
            btDeletedBook.Text = "Удалить книгу";
            btDeletedBook.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 264);
            label2.Name = "label2";
            label2.Size = new Size(765, 33);
            label2.TabIndex = 6;
            label2.Text = "Запросы на получение книг от посетителей";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookRequestsFromUsersListBox
            // 
            bookRequestsFromUsersListBox.FormattingEnabled = true;
            bookRequestsFromUsersListBox.Location = new Point(12, 309);
            bookRequestsFromUsersListBox.Name = "bookRequestsFromUsersListBox";
            bookRequestsFromUsersListBox.Size = new Size(765, 204);
            bookRequestsFromUsersListBox.TabIndex = 7;
            // 
            // btSaveBook
            // 
            btSaveBook.Location = new Point(783, 211);
            btSaveBook.Name = "btSaveBook";
            btSaveBook.Size = new Size(180, 29);
            btSaveBook.TabIndex = 8;
            btSaveBook.Text = "Экспорт книг";
            btSaveBook.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(783, 344);
            button1.Name = "button1";
            button1.Size = new Size(180, 29);
            button1.TabIndex = 9;
            button1.Text = "Обработать запрос";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(783, 419);
            button2.Name = "button2";
            button2.Size = new Size(180, 29);
            button2.TabIndex = 10;
            button2.Text = "Отклонить запрос";
            button2.UseVisualStyleBackColor = true;
            // 
            // LibraryStaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 530);
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
            Name = "LibraryStaffForm";
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