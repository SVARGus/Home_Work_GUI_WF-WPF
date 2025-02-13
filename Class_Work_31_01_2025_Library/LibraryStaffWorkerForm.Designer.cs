namespace Home_and_Class_Work_31_01_2025_Library
{
    partial class LibraryStaffWorkerForm
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
            menuStrip1 = new MenuStrip();
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            createBookToolStripMenuItem = new ToolStripMenuItem();
            deleteBookToolStripMenuItem = new ToolStripMenuItem();
            saveBaseBooksToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            saveTextBookToolStripMenuItem = new ToolStripMenuItem();
            loadTextInBookToolStripMenuItem = new ToolStripMenuItem();
            fornStileToolStripMenuItem = new ToolStripMenuItem();
            цветФонаToolStripMenuItem = new ToolStripMenuItem();
            redBackgtoundToolStripMenuItem = new ToolStripMenuItem();
            orangeBackgtoundToolStripMenuItem = new ToolStripMenuItem();
            yellowBackgtoundToolStripMenuItem = new ToolStripMenuItem();
            greenBackgtoundToolStripMenuItem = new ToolStripMenuItem();
            blueBackgtoundToolStripMenuItem = new ToolStripMenuItem();
            purpleBackgtoundToolStripMenuItem = new ToolStripMenuItem();
            blackBackgtoundToolStripMenuItem = new ToolStripMenuItem();
            whiteBackgtoundToolStripMenuItem = new ToolStripMenuItem();
            цветТекстаToolStripMenuItem = new ToolStripMenuItem();
            redTextToolStripMenuItem = new ToolStripMenuItem();
            orangeTextToolStripMenuItem = new ToolStripMenuItem();
            yellowTextToolStripMenuItem = new ToolStripMenuItem();
            greenTextToolStripMenuItem = new ToolStripMenuItem();
            blueTextToolStripMenuItem = new ToolStripMenuItem();
            purpleTextToolStripMenuItem = new ToolStripMenuItem();
            blackTextToolStripMenuItem = new ToolStripMenuItem();
            whiteTextToolStripMenuItem = new ToolStripMenuItem();
            сToolStripMenuItem = new ToolStripMenuItem();
            textSize8toolStripMenuItem = new ToolStripMenuItem();
            textSize9toolStripMenuItem = new ToolStripMenuItem();
            textSize10ToolStripMenuItem = new ToolStripMenuItem();
            textSize12ToolStripMenuItem = new ToolStripMenuItem();
            textSize14ToolStripMenuItem = new ToolStripMenuItem();
            textSize16ToolStripMenuItem = new ToolStripMenuItem();
            textSize18ToolStripMenuItem = new ToolStripMenuItem();
            textSize20ToolStripMenuItem = new ToolStripMenuItem();
            шрифтТекстаToolStripMenuItem = new ToolStripMenuItem();
            arialFontToolStripMenuItem = new ToolStripMenuItem();
            timesNewRomanFontToolStripMenuItem = new ToolStripMenuItem();
            calibriFontToolStripMenuItem = new ToolStripMenuItem();
            brushScriptMTFontToolStripMenuItem = new ToolStripMenuItem();
            segoeUIFontToolStripMenuItem = new ToolStripMenuItem();
            vivaldiFontToolStripMenuItem = new ToolStripMenuItem();
            bookListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDescription = new TextBox();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxGenre = new TextBox();
            textBoxPublisher = new TextBox();
            btEdeteCreate = new Button();
            btSave = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { главнаяToolStripMenuItem, textToolStripMenuItem, fornStileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1165, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            главнаяToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createBookToolStripMenuItem, deleteBookToolStripMenuItem, saveBaseBooksToolStripMenuItem });
            главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            главнаяToolStripMenuItem.Size = new Size(79, 24);
            главнаяToolStripMenuItem.Text = "Главная";
            // 
            // createBookToolStripMenuItem
            // 
            createBookToolStripMenuItem.Name = "createBookToolStripMenuItem";
            createBookToolStripMenuItem.Size = new Size(216, 26);
            createBookToolStripMenuItem.Text = "Создать книгу";
            createBookToolStripMenuItem.Click += createBookToolStripMenuItem_Click;
            // 
            // deleteBookToolStripMenuItem
            // 
            deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            deleteBookToolStripMenuItem.Size = new Size(216, 26);
            deleteBookToolStripMenuItem.Text = "Удалить книгу";
            deleteBookToolStripMenuItem.Click += deleteBookToolStripMenuItem_Click;
            // 
            // saveBaseBooksToolStripMenuItem
            // 
            saveBaseBooksToolStripMenuItem.Name = "saveBaseBooksToolStripMenuItem";
            saveBaseBooksToolStripMenuItem.Size = new Size(216, 26);
            saveBaseBooksToolStripMenuItem.Text = "Сохранение базы";
            saveBaseBooksToolStripMenuItem.Click += saveBaseBooksToolStripMenuItem_Click;
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveTextBookToolStripMenuItem, loadTextInBookToolStripMenuItem });
            textToolStripMenuItem.Enabled = false;
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(59, 24);
            textToolStripMenuItem.Text = "Текст";
            // 
            // saveTextBookToolStripMenuItem
            // 
            saveTextBookToolStripMenuItem.Name = "saveTextBookToolStripMenuItem";
            saveTextBookToolStripMenuItem.Size = new Size(224, 26);
            saveTextBookToolStripMenuItem.Text = "Сохранить";
            saveTextBookToolStripMenuItem.Click += saveTextBookToolStripMenuItem_Click;
            // 
            // loadTextInBookToolStripMenuItem
            // 
            loadTextInBookToolStripMenuItem.Name = "loadTextInBookToolStripMenuItem";
            loadTextInBookToolStripMenuItem.Size = new Size(224, 26);
            loadTextInBookToolStripMenuItem.Text = "Загрузить";
            loadTextInBookToolStripMenuItem.Click += loadTextInBookToolStripMenuItem_Click;
            // 
            // fornStileToolStripMenuItem
            // 
            fornStileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветФонаToolStripMenuItem, цветТекстаToolStripMenuItem, сToolStripMenuItem, шрифтТекстаToolStripMenuItem });
            fornStileToolStripMenuItem.Enabled = false;
            fornStileToolStripMenuItem.Name = "fornStileToolStripMenuItem";
            fornStileToolStripMenuItem.Size = new Size(63, 24);
            fornStileToolStripMenuItem.Text = "Стиль";
            // 
            // цветФонаToolStripMenuItem
            // 
            цветФонаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redBackgtoundToolStripMenuItem, orangeBackgtoundToolStripMenuItem, yellowBackgtoundToolStripMenuItem, greenBackgtoundToolStripMenuItem, blueBackgtoundToolStripMenuItem, purpleBackgtoundToolStripMenuItem, blackBackgtoundToolStripMenuItem, whiteBackgtoundToolStripMenuItem });
            цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            цветФонаToolStripMenuItem.Size = new Size(189, 26);
            цветФонаToolStripMenuItem.Text = "Цвет фона";
            // 
            // redBackgtoundToolStripMenuItem
            // 
            redBackgtoundToolStripMenuItem.Name = "redBackgtoundToolStripMenuItem";
            redBackgtoundToolStripMenuItem.Size = new Size(180, 26);
            redBackgtoundToolStripMenuItem.Text = "Красный";
            redBackgtoundToolStripMenuItem.Click += redBackgtoundToolStripMenuItem_Click;
            // 
            // orangeBackgtoundToolStripMenuItem
            // 
            orangeBackgtoundToolStripMenuItem.Name = "orangeBackgtoundToolStripMenuItem";
            orangeBackgtoundToolStripMenuItem.Size = new Size(180, 26);
            orangeBackgtoundToolStripMenuItem.Text = "Оранжевый";
            orangeBackgtoundToolStripMenuItem.Click += orangeBackgtoundToolStripMenuItem_Click;
            // 
            // yellowBackgtoundToolStripMenuItem
            // 
            yellowBackgtoundToolStripMenuItem.Name = "yellowBackgtoundToolStripMenuItem";
            yellowBackgtoundToolStripMenuItem.Size = new Size(180, 26);
            yellowBackgtoundToolStripMenuItem.Text = "Желтый";
            yellowBackgtoundToolStripMenuItem.Click += yellowBackgtoundToolStripMenuItem_Click;
            // 
            // greenBackgtoundToolStripMenuItem
            // 
            greenBackgtoundToolStripMenuItem.Name = "greenBackgtoundToolStripMenuItem";
            greenBackgtoundToolStripMenuItem.Size = new Size(180, 26);
            greenBackgtoundToolStripMenuItem.Text = "Зеленый";
            greenBackgtoundToolStripMenuItem.Click += greenBackgtoundToolStripMenuItem_Click;
            // 
            // blueBackgtoundToolStripMenuItem
            // 
            blueBackgtoundToolStripMenuItem.Name = "blueBackgtoundToolStripMenuItem";
            blueBackgtoundToolStripMenuItem.Size = new Size(180, 26);
            blueBackgtoundToolStripMenuItem.Text = "Синий";
            blueBackgtoundToolStripMenuItem.Click += blueBackgtoundToolStripMenuItem_Click;
            // 
            // purpleBackgtoundToolStripMenuItem
            // 
            purpleBackgtoundToolStripMenuItem.Name = "purpleBackgtoundToolStripMenuItem";
            purpleBackgtoundToolStripMenuItem.Size = new Size(180, 26);
            purpleBackgtoundToolStripMenuItem.Text = "Фиолетовый";
            purpleBackgtoundToolStripMenuItem.Click += purpleBackgtoundToolStripMenuItem_Click;
            // 
            // blackBackgtoundToolStripMenuItem
            // 
            blackBackgtoundToolStripMenuItem.Name = "blackBackgtoundToolStripMenuItem";
            blackBackgtoundToolStripMenuItem.Size = new Size(180, 26);
            blackBackgtoundToolStripMenuItem.Text = "Черный";
            blackBackgtoundToolStripMenuItem.Click += blackBackgtoundToolStripMenuItem_Click;
            // 
            // whiteBackgtoundToolStripMenuItem
            // 
            whiteBackgtoundToolStripMenuItem.BackColor = SystemColors.Control;
            whiteBackgtoundToolStripMenuItem.ForeColor = SystemColors.ControlText;
            whiteBackgtoundToolStripMenuItem.Name = "whiteBackgtoundToolStripMenuItem";
            whiteBackgtoundToolStripMenuItem.Size = new Size(180, 26);
            whiteBackgtoundToolStripMenuItem.Text = "Белый";
            whiteBackgtoundToolStripMenuItem.Click += whiteBackgtoundToolStripMenuItem_Click;
            // 
            // цветТекстаToolStripMenuItem
            // 
            цветТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redTextToolStripMenuItem, orangeTextToolStripMenuItem, yellowTextToolStripMenuItem, greenTextToolStripMenuItem, blueTextToolStripMenuItem, purpleTextToolStripMenuItem, blackTextToolStripMenuItem, whiteTextToolStripMenuItem });
            цветТекстаToolStripMenuItem.Name = "цветТекстаToolStripMenuItem";
            цветТекстаToolStripMenuItem.Size = new Size(189, 26);
            цветТекстаToolStripMenuItem.Text = "Цвет текста";
            // 
            // redTextToolStripMenuItem
            // 
            redTextToolStripMenuItem.Name = "redTextToolStripMenuItem";
            redTextToolStripMenuItem.Size = new Size(180, 26);
            redTextToolStripMenuItem.Text = "Красный";
            redTextToolStripMenuItem.Click += redTextToolStripMenuItem_Click;
            // 
            // orangeTextToolStripMenuItem
            // 
            orangeTextToolStripMenuItem.Name = "orangeTextToolStripMenuItem";
            orangeTextToolStripMenuItem.Size = new Size(180, 26);
            orangeTextToolStripMenuItem.Text = "Оранжевый";
            orangeTextToolStripMenuItem.Click += orangeTextToolStripMenuItem_Click;
            // 
            // yellowTextToolStripMenuItem
            // 
            yellowTextToolStripMenuItem.Name = "yellowTextToolStripMenuItem";
            yellowTextToolStripMenuItem.Size = new Size(180, 26);
            yellowTextToolStripMenuItem.Text = "Желтый";
            yellowTextToolStripMenuItem.Click += yellowTextToolStripMenuItem_Click;
            // 
            // greenTextToolStripMenuItem
            // 
            greenTextToolStripMenuItem.Name = "greenTextToolStripMenuItem";
            greenTextToolStripMenuItem.Size = new Size(180, 26);
            greenTextToolStripMenuItem.Text = "Зеленый";
            greenTextToolStripMenuItem.Click += greenTextToolStripMenuItem_Click;
            // 
            // blueTextToolStripMenuItem
            // 
            blueTextToolStripMenuItem.Name = "blueTextToolStripMenuItem";
            blueTextToolStripMenuItem.Size = new Size(180, 26);
            blueTextToolStripMenuItem.Text = "Синий";
            blueTextToolStripMenuItem.Click += blueTextToolStripMenuItem_Click;
            // 
            // purpleTextToolStripMenuItem
            // 
            purpleTextToolStripMenuItem.Name = "purpleTextToolStripMenuItem";
            purpleTextToolStripMenuItem.Size = new Size(180, 26);
            purpleTextToolStripMenuItem.Text = "Фиолетовый";
            purpleTextToolStripMenuItem.Click += purpleTextToolStripMenuItem_Click;
            // 
            // blackTextToolStripMenuItem
            // 
            blackTextToolStripMenuItem.Name = "blackTextToolStripMenuItem";
            blackTextToolStripMenuItem.Size = new Size(180, 26);
            blackTextToolStripMenuItem.Text = "Черный";
            blackTextToolStripMenuItem.Click += blackTextToolStripMenuItem_Click;
            // 
            // whiteTextToolStripMenuItem
            // 
            whiteTextToolStripMenuItem.Name = "whiteTextToolStripMenuItem";
            whiteTextToolStripMenuItem.Size = new Size(180, 26);
            whiteTextToolStripMenuItem.Text = "Белый";
            whiteTextToolStripMenuItem.Click += whiteTextToolStripMenuItem_Click;
            // 
            // сToolStripMenuItem
            // 
            сToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { textSize8toolStripMenuItem, textSize9toolStripMenuItem, textSize10ToolStripMenuItem, textSize12ToolStripMenuItem, textSize14ToolStripMenuItem, textSize16ToolStripMenuItem, textSize18ToolStripMenuItem, textSize20ToolStripMenuItem });
            сToolStripMenuItem.Name = "сToolStripMenuItem";
            сToolStripMenuItem.Size = new Size(189, 26);
            сToolStripMenuItem.Text = "Размер текста";
            // 
            // textSize8toolStripMenuItem
            // 
            textSize8toolStripMenuItem.Name = "textSize8toolStripMenuItem";
            textSize8toolStripMenuItem.Size = new Size(108, 26);
            textSize8toolStripMenuItem.Text = "8";
            textSize8toolStripMenuItem.Click += textSize8toolStripMenuItem_Click;
            // 
            // textSize9toolStripMenuItem
            // 
            textSize9toolStripMenuItem.Name = "textSize9toolStripMenuItem";
            textSize9toolStripMenuItem.Size = new Size(108, 26);
            textSize9toolStripMenuItem.Text = "9";
            textSize9toolStripMenuItem.Click += textSize9toolStripMenuItem_Click;
            // 
            // textSize10ToolStripMenuItem
            // 
            textSize10ToolStripMenuItem.Name = "textSize10ToolStripMenuItem";
            textSize10ToolStripMenuItem.Size = new Size(108, 26);
            textSize10ToolStripMenuItem.Text = "10";
            textSize10ToolStripMenuItem.Click += textSize10ToolStripMenuItem_Click;
            // 
            // textSize12ToolStripMenuItem
            // 
            textSize12ToolStripMenuItem.Name = "textSize12ToolStripMenuItem";
            textSize12ToolStripMenuItem.Size = new Size(108, 26);
            textSize12ToolStripMenuItem.Text = "12";
            textSize12ToolStripMenuItem.Click += textSize12ToolStripMenuItem_Click;
            // 
            // textSize14ToolStripMenuItem
            // 
            textSize14ToolStripMenuItem.Name = "textSize14ToolStripMenuItem";
            textSize14ToolStripMenuItem.Size = new Size(108, 26);
            textSize14ToolStripMenuItem.Text = "14";
            textSize14ToolStripMenuItem.Click += textSize14ToolStripMenuItem_Click;
            // 
            // textSize16ToolStripMenuItem
            // 
            textSize16ToolStripMenuItem.Name = "textSize16ToolStripMenuItem";
            textSize16ToolStripMenuItem.Size = new Size(108, 26);
            textSize16ToolStripMenuItem.Text = "16";
            textSize16ToolStripMenuItem.Click += textSize16ToolStripMenuItem_Click;
            // 
            // textSize18ToolStripMenuItem
            // 
            textSize18ToolStripMenuItem.Name = "textSize18ToolStripMenuItem";
            textSize18ToolStripMenuItem.Size = new Size(108, 26);
            textSize18ToolStripMenuItem.Text = "18";
            textSize18ToolStripMenuItem.Click += textSize18ToolStripMenuItem_Click;
            // 
            // textSize20ToolStripMenuItem
            // 
            textSize20ToolStripMenuItem.Name = "textSize20ToolStripMenuItem";
            textSize20ToolStripMenuItem.Size = new Size(108, 26);
            textSize20ToolStripMenuItem.Text = "20";
            textSize20ToolStripMenuItem.Click += textSize20ToolStripMenuItem_Click;
            // 
            // шрифтТекстаToolStripMenuItem
            // 
            шрифтТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arialFontToolStripMenuItem, timesNewRomanFontToolStripMenuItem, calibriFontToolStripMenuItem, brushScriptMTFontToolStripMenuItem, segoeUIFontToolStripMenuItem, vivaldiFontToolStripMenuItem });
            шрифтТекстаToolStripMenuItem.Name = "шрифтТекстаToolStripMenuItem";
            шрифтТекстаToolStripMenuItem.Size = new Size(189, 26);
            шрифтТекстаToolStripMenuItem.Text = "Шрифт текста";
            // 
            // arialFontToolStripMenuItem
            // 
            arialFontToolStripMenuItem.Name = "arialFontToolStripMenuItem";
            arialFontToolStripMenuItem.Size = new Size(216, 26);
            arialFontToolStripMenuItem.Text = "Arial";
            arialFontToolStripMenuItem.Click += arialFontToolStripMenuItem_Click;
            // 
            // timesNewRomanFontToolStripMenuItem
            // 
            timesNewRomanFontToolStripMenuItem.Name = "timesNewRomanFontToolStripMenuItem";
            timesNewRomanFontToolStripMenuItem.Size = new Size(216, 26);
            timesNewRomanFontToolStripMenuItem.Text = "Times New Roman";
            timesNewRomanFontToolStripMenuItem.Click += timeNewRomanFontToolStripMenuItem_Click;
            // 
            // calibriFontToolStripMenuItem
            // 
            calibriFontToolStripMenuItem.Name = "calibriFontToolStripMenuItem";
            calibriFontToolStripMenuItem.Size = new Size(216, 26);
            calibriFontToolStripMenuItem.Text = "Calibri";
            calibriFontToolStripMenuItem.Click += calibriFontToolStripMenuItem_Click;
            // 
            // brushScriptMTFontToolStripMenuItem
            // 
            brushScriptMTFontToolStripMenuItem.Name = "brushScriptMTFontToolStripMenuItem";
            brushScriptMTFontToolStripMenuItem.Size = new Size(216, 26);
            brushScriptMTFontToolStripMenuItem.Text = "Brush Script MT";
            brushScriptMTFontToolStripMenuItem.Click += brushScriptMTFontToolStripMenuItem_Click;
            // 
            // segoeUIFontToolStripMenuItem
            // 
            segoeUIFontToolStripMenuItem.Name = "segoeUIFontToolStripMenuItem";
            segoeUIFontToolStripMenuItem.Size = new Size(216, 26);
            segoeUIFontToolStripMenuItem.Text = "Segoe UI";
            segoeUIFontToolStripMenuItem.Click += segoeUIFontToolStripMenuItem_Click;
            // 
            // vivaldiFontToolStripMenuItem
            // 
            vivaldiFontToolStripMenuItem.Name = "vivaldiFontToolStripMenuItem";
            vivaldiFontToolStripMenuItem.Size = new Size(216, 26);
            vivaldiFontToolStripMenuItem.Text = "Vivaldi";
            vivaldiFontToolStripMenuItem.Click += vivaldiFontToolStripMenuItem_Click;
            // 
            // bookListBox
            // 
            bookListBox.FormattingEnabled = true;
            bookListBox.Location = new Point(14, 36);
            bookListBox.Margin = new Padding(3, 4, 3, 4);
            bookListBox.Name = "bookListBox";
            bookListBox.Size = new Size(500, 684);
            bookListBox.TabIndex = 1;
            bookListBox.Click += bookListBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(546, 41);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 2;
            label1.Text = "Название текста";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(546, 75);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 3;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(549, 113);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 4;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(546, 152);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 5;
            label4.Text = "Издатель";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(546, 209);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(607, 511);
            textBoxDescription.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Enabled = false;
            textBoxTitle.Location = new Point(710, 39);
            textBoxTitle.Margin = new Padding(3, 4, 3, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(299, 27);
            textBoxTitle.TabIndex = 7;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Enabled = false;
            textBoxAuthor.Location = new Point(710, 77);
            textBoxAuthor.Margin = new Padding(3, 4, 3, 4);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(299, 27);
            textBoxAuthor.TabIndex = 8;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Enabled = false;
            textBoxGenre.Location = new Point(710, 116);
            textBoxGenre.Margin = new Padding(3, 4, 3, 4);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(299, 27);
            textBoxGenre.TabIndex = 9;
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Enabled = false;
            textBoxPublisher.Location = new Point(710, 155);
            textBoxPublisher.Margin = new Padding(3, 4, 3, 4);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(299, 27);
            textBoxPublisher.TabIndex = 10;
            // 
            // btEdeteCreate
            // 
            btEdeteCreate.BackColor = Color.Chartreuse;
            btEdeteCreate.Location = new Point(1029, 36);
            btEdeteCreate.Margin = new Padding(3, 4, 3, 4);
            btEdeteCreate.Name = "btEdeteCreate";
            btEdeteCreate.Size = new Size(124, 87);
            btEdeteCreate.TabIndex = 11;
            btEdeteCreate.Text = "Начать редактировать";
            btEdeteCreate.UseVisualStyleBackColor = false;
            btEdeteCreate.Click += btEdeteCreate_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Gray;
            btSave.Enabled = false;
            btSave.Location = new Point(1029, 131);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(124, 55);
            btSave.TabIndex = 12;
            btSave.Text = "Сохранить";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // LibraryStaffWorkerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 732);
            Controls.Add(btSave);
            Controls.Add(btEdeteCreate);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LibraryStaffWorkerForm";
            Text = "LibraryStaffFormNew";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem fornStileToolStripMenuItem;
        private ToolStripMenuItem цветФонаToolStripMenuItem;
        private ToolStripMenuItem цветТекстаToolStripMenuItem;
        private ListBox bookListBox;
        private ToolStripMenuItem сToolStripMenuItem;
        private ToolStripMenuItem шрифтТекстаToolStripMenuItem;
        private ToolStripMenuItem arialFontToolStripMenuItem;
        private ToolStripMenuItem timesNewRomanFontToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDescription;
        private ToolStripMenuItem saveTextBookToolStripMenuItem;
        private ToolStripMenuItem loadTextInBookToolStripMenuItem;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxGenre;
        private TextBox textBoxPublisher;
        private Button btEdeteCreate;
        private Button btSave;
        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem createBookToolStripMenuItem;
        private ToolStripMenuItem deleteBookToolStripMenuItem;
        private ToolStripMenuItem saveBaseBooksToolStripMenuItem;
        private ToolStripMenuItem redBackgtoundToolStripMenuItem;
        private ToolStripMenuItem orangeBackgtoundToolStripMenuItem;
        private ToolStripMenuItem yellowBackgtoundToolStripMenuItem;
        private ToolStripMenuItem greenBackgtoundToolStripMenuItem;
        private ToolStripMenuItem blueBackgtoundToolStripMenuItem;
        private ToolStripMenuItem purpleBackgtoundToolStripMenuItem;
        private ToolStripMenuItem blackBackgtoundToolStripMenuItem;
        private ToolStripMenuItem whiteBackgtoundToolStripMenuItem;
        private ToolStripMenuItem redTextToolStripMenuItem;
        private ToolStripMenuItem orangeTextToolStripMenuItem;
        private ToolStripMenuItem yellowTextToolStripMenuItem;
        private ToolStripMenuItem greenTextToolStripMenuItem;
        private ToolStripMenuItem blueTextToolStripMenuItem;
        private ToolStripMenuItem purpleTextToolStripMenuItem;
        private ToolStripMenuItem blackTextToolStripMenuItem;
        private ToolStripMenuItem whiteTextToolStripMenuItem;
        private ToolStripMenuItem textSize8toolStripMenuItem;
        private ToolStripMenuItem textSize9toolStripMenuItem;
        private ToolStripMenuItem textSize10ToolStripMenuItem;
        private ToolStripMenuItem textSize12ToolStripMenuItem;
        private ToolStripMenuItem textSize14ToolStripMenuItem;
        private ToolStripMenuItem textSize16ToolStripMenuItem;
        private ToolStripMenuItem textSize18ToolStripMenuItem;
        private ToolStripMenuItem textSize20ToolStripMenuItem;
        private ToolStripMenuItem calibriFontToolStripMenuItem;
        private ToolStripMenuItem brushScriptMTFontToolStripMenuItem;
        private ToolStripMenuItem segoeUIFontToolStripMenuItem;
        private ToolStripMenuItem vivaldiFontToolStripMenuItem;
    }
}