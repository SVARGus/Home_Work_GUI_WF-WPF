namespace CandyMuseum
{
    partial class ProductCardForm
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
            textBoxNameProduct = new TextBox();
            groupBoxListProducer = new GroupBox();
            radioButtonProducer4 = new RadioButton();
            radioButtonProducer3 = new RadioButton();
            radioButtonProducer2 = new RadioButton();
            radioButtonProducer1 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            numericUpDownQuzntityProduct = new NumericUpDown();
            numericUpDownPriceProduct = new NumericUpDown();
            buttonSaveProduct = new Button();
            buttonBackProduct = new Button();
            groupBoxListProducer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuzntityProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 0;
            label1.Text = "  Название товара";
            // 
            // textBoxNameProduct
            // 
            textBoxNameProduct.Location = new Point(14, 65);
            textBoxNameProduct.Margin = new Padding(3, 4, 3, 4);
            textBoxNameProduct.Name = "textBoxNameProduct";
            textBoxNameProduct.Size = new Size(350, 27);
            textBoxNameProduct.TabIndex = 1;
            // 
            // groupBoxListProducer
            // 
            groupBoxListProducer.Controls.Add(radioButtonProducer4);
            groupBoxListProducer.Controls.Add(radioButtonProducer3);
            groupBoxListProducer.Controls.Add(radioButtonProducer2);
            groupBoxListProducer.Controls.Add(radioButtonProducer1);
            groupBoxListProducer.Location = new Point(14, 104);
            groupBoxListProducer.Margin = new Padding(3, 4, 3, 4);
            groupBoxListProducer.Name = "groupBoxListProducer";
            groupBoxListProducer.Padding = new Padding(3, 4, 3, 4);
            groupBoxListProducer.Size = new Size(351, 108);
            groupBoxListProducer.TabIndex = 2;
            groupBoxListProducer.TabStop = false;
            groupBoxListProducer.Text = "Производитель";
            // 
            // radioButtonProducer4
            // 
            radioButtonProducer4.AutoSize = true;
            radioButtonProducer4.Location = new Point(168, 63);
            radioButtonProducer4.Margin = new Padding(3, 4, 3, 4);
            radioButtonProducer4.Name = "radioButtonProducer4";
            radioButtonProducer4.Size = new Size(112, 24);
            radioButtonProducer4.TabIndex = 3;
            radioButtonProducer4.TabStop = true;
            radioButtonProducer4.Text = "Славяночка";
            radioButtonProducer4.UseVisualStyleBackColor = true;
            // 
            // radioButtonProducer3
            // 
            radioButtonProducer3.AutoSize = true;
            radioButtonProducer3.Location = new Point(168, 29);
            radioButtonProducer3.Margin = new Padding(3, 4, 3, 4);
            radioButtonProducer3.Name = "radioButtonProducer3";
            radioButtonProducer3.Size = new Size(152, 24);
            radioButtonProducer3.TabIndex = 2;
            radioButtonProducer3.TabStop = true;
            radioButtonProducer3.Text = "Красный октябрь";
            radioButtonProducer3.UseVisualStyleBackColor = true;
            // 
            // radioButtonProducer2
            // 
            radioButtonProducer2.AutoSize = true;
            radioButtonProducer2.Location = new Point(7, 63);
            radioButtonProducer2.Margin = new Padding(3, 4, 3, 4);
            radioButtonProducer2.Name = "radioButtonProducer2";
            radioButtonProducer2.Size = new Size(94, 24);
            radioButtonProducer2.TabIndex = 1;
            radioButtonProducer2.TabStop = true;
            radioButtonProducer2.Text = "Крупская";
            radioButtonProducer2.UseVisualStyleBackColor = true;
            // 
            // radioButtonProducer1
            // 
            radioButtonProducer1.AutoSize = true;
            radioButtonProducer1.Location = new Point(7, 29);
            radioButtonProducer1.Margin = new Padding(3, 4, 3, 4);
            radioButtonProducer1.Name = "radioButtonProducer1";
            radioButtonProducer1.Size = new Size(100, 24);
            radioButtonProducer1.TabIndex = 0;
            radioButtonProducer1.TabStop = true;
            radioButtonProducer1.Text = "Конти-Рус";
            radioButtonProducer1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 232);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 3;
            label2.Text = "Количество на складе";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 273);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 4;
            label3.Text = "Стоимость (шт)";
            // 
            // numericUpDownQuzntityProduct
            // 
            numericUpDownQuzntityProduct.Location = new Point(227, 229);
            numericUpDownQuzntityProduct.Margin = new Padding(3, 4, 3, 4);
            numericUpDownQuzntityProduct.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownQuzntityProduct.Name = "numericUpDownQuzntityProduct";
            numericUpDownQuzntityProduct.Size = new Size(137, 27);
            numericUpDownQuzntityProduct.TabIndex = 5;
            // 
            // numericUpDownPriceProduct
            // 
            numericUpDownPriceProduct.DecimalPlaces = 2;
            numericUpDownPriceProduct.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownPriceProduct.Location = new Point(227, 271);
            numericUpDownPriceProduct.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPriceProduct.Name = "numericUpDownPriceProduct";
            numericUpDownPriceProduct.Size = new Size(137, 27);
            numericUpDownPriceProduct.TabIndex = 6;
            numericUpDownPriceProduct.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // buttonSaveProduct
            // 
            buttonSaveProduct.Location = new Point(14, 327);
            buttonSaveProduct.Margin = new Padding(3, 4, 3, 4);
            buttonSaveProduct.Name = "buttonSaveProduct";
            buttonSaveProduct.Size = new Size(351, 31);
            buttonSaveProduct.TabIndex = 7;
            buttonSaveProduct.Text = "Сохранить";
            buttonSaveProduct.UseVisualStyleBackColor = true;
            buttonSaveProduct.Click += buttonSaveProduct_Click;
            // 
            // buttonBackProduct
            // 
            buttonBackProduct.Location = new Point(14, 365);
            buttonBackProduct.Margin = new Padding(3, 4, 3, 4);
            buttonBackProduct.Name = "buttonBackProduct";
            buttonBackProduct.Size = new Size(351, 31);
            buttonBackProduct.TabIndex = 8;
            buttonBackProduct.Text = "Отменить";
            buttonBackProduct.UseVisualStyleBackColor = true;
            buttonBackProduct.Click += buttonBackProduct_Click;
            // 
            // ProductCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 419);
            Controls.Add(buttonBackProduct);
            Controls.Add(buttonSaveProduct);
            Controls.Add(numericUpDownPriceProduct);
            Controls.Add(numericUpDownQuzntityProduct);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBoxListProducer);
            Controls.Add(textBoxNameProduct);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductCardForm";
            Text = "ProductCardForm";
            groupBoxListProducer.ResumeLayout(false);
            groupBoxListProducer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuzntityProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNameProduct;
        private GroupBox groupBoxListProducer;
        private RadioButton radioButtonProducer2;
        private RadioButton radioButtonProducer1;
        private RadioButton radioButtonProducer4;
        private RadioButton radioButtonProducer3;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownQuzntityProduct;
        private NumericUpDown numericUpDownPriceProduct;
        private Button buttonSaveProduct;
        private Button buttonBackProduct;
    }
}