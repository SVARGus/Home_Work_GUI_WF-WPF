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
            radioButtonProducer1 = new RadioButton();
            radioButtonProducer2 = new RadioButton();
            radioButtonProducer4 = new RadioButton();
            radioButtonProducer3 = new RadioButton();
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
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "  Название товара";
            // 
            // textBoxNameProduct
            // 
            textBoxNameProduct.Location = new Point(12, 49);
            textBoxNameProduct.Name = "textBoxNameProduct";
            textBoxNameProduct.Size = new Size(307, 23);
            textBoxNameProduct.TabIndex = 1;
            // 
            // groupBoxListProducer
            // 
            groupBoxListProducer.Controls.Add(radioButtonProducer4);
            groupBoxListProducer.Controls.Add(radioButtonProducer3);
            groupBoxListProducer.Controls.Add(radioButtonProducer2);
            groupBoxListProducer.Controls.Add(radioButtonProducer1);
            groupBoxListProducer.Location = new Point(12, 78);
            groupBoxListProducer.Name = "groupBoxListProducer";
            groupBoxListProducer.Size = new Size(307, 81);
            groupBoxListProducer.TabIndex = 2;
            groupBoxListProducer.TabStop = false;
            groupBoxListProducer.Text = "Производитель";
            // 
            // radioButtonProducer1
            // 
            radioButtonProducer1.AutoSize = true;
            radioButtonProducer1.Location = new Point(6, 22);
            radioButtonProducer1.Name = "radioButtonProducer1";
            radioButtonProducer1.Size = new Size(82, 19);
            radioButtonProducer1.TabIndex = 0;
            radioButtonProducer1.TabStop = true;
            radioButtonProducer1.Text = "Конти-Рус";
            radioButtonProducer1.UseVisualStyleBackColor = true;
            // 
            // radioButtonProducer2
            // 
            radioButtonProducer2.AutoSize = true;
            radioButtonProducer2.Location = new Point(6, 47);
            radioButtonProducer2.Name = "radioButtonProducer2";
            radioButtonProducer2.Size = new Size(76, 19);
            radioButtonProducer2.TabIndex = 1;
            radioButtonProducer2.TabStop = true;
            radioButtonProducer2.Text = "Крупская";
            radioButtonProducer2.UseVisualStyleBackColor = true;
            // 
            // radioButtonProducer4
            // 
            radioButtonProducer4.AutoSize = true;
            radioButtonProducer4.Location = new Point(147, 47);
            radioButtonProducer4.Name = "radioButtonProducer4";
            radioButtonProducer4.Size = new Size(91, 19);
            radioButtonProducer4.TabIndex = 3;
            radioButtonProducer4.TabStop = true;
            radioButtonProducer4.Text = "Славяночка";
            radioButtonProducer4.UseVisualStyleBackColor = true;
            // 
            // radioButtonProducer3
            // 
            radioButtonProducer3.AutoSize = true;
            radioButtonProducer3.Location = new Point(147, 22);
            radioButtonProducer3.Name = "radioButtonProducer3";
            radioButtonProducer3.Size = new Size(121, 19);
            radioButtonProducer3.TabIndex = 2;
            radioButtonProducer3.TabStop = true;
            radioButtonProducer3.Text = "Красный октябрь";
            radioButtonProducer3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 3;
            label2.Text = "Количество на складе";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Стоимость (кг)";
            // 
            // numericUpDownQuzntityProduct
            // 
            numericUpDownQuzntityProduct.DecimalPlaces = 3;
            numericUpDownQuzntityProduct.Increment = new decimal(new int[] { 0, 0, 0, 196608 });
            numericUpDownQuzntityProduct.Location = new Point(199, 172);
            numericUpDownQuzntityProduct.Name = "numericUpDownQuzntityProduct";
            numericUpDownQuzntityProduct.Size = new Size(120, 23);
            numericUpDownQuzntityProduct.TabIndex = 5;
            // 
            // numericUpDownPriceProduct
            // 
            numericUpDownPriceProduct.DecimalPlaces = 2;
            numericUpDownPriceProduct.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownPriceProduct.Location = new Point(199, 203);
            numericUpDownPriceProduct.Name = "numericUpDownPriceProduct";
            numericUpDownPriceProduct.Size = new Size(120, 23);
            numericUpDownPriceProduct.TabIndex = 6;
            numericUpDownPriceProduct.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // buttonSaveProduct
            // 
            buttonSaveProduct.Location = new Point(12, 245);
            buttonSaveProduct.Name = "buttonSaveProduct";
            buttonSaveProduct.Size = new Size(307, 23);
            buttonSaveProduct.TabIndex = 7;
            buttonSaveProduct.Text = "Сохранить";
            buttonSaveProduct.UseVisualStyleBackColor = true;
            // 
            // buttonBackProduct
            // 
            buttonBackProduct.Location = new Point(12, 274);
            buttonBackProduct.Name = "buttonBackProduct";
            buttonBackProduct.Size = new Size(307, 23);
            buttonBackProduct.TabIndex = 8;
            buttonBackProduct.Text = "Отменить";
            buttonBackProduct.UseVisualStyleBackColor = true;
            // 
            // ProductCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 314);
            Controls.Add(buttonBackProduct);
            Controls.Add(buttonSaveProduct);
            Controls.Add(numericUpDownPriceProduct);
            Controls.Add(numericUpDownQuzntityProduct);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBoxListProducer);
            Controls.Add(textBoxNameProduct);
            Controls.Add(label1);
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