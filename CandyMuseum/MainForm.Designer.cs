namespace CandyMuseum
{
    partial class MainForm
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
            groupBoxCash = new GroupBox();
            checkedListBoxProductsCash = new CheckedListBox();
            label2 = new Label();
            labelSumCash = new Label();
            buttonEnterReceipt = new Button();
            label1 = new Label();
            numericUpDownVolumeProducts = new NumericUpDown();
            buttonAddProductCash = new Button();
            comboBoxProductList = new ComboBox();
            buttonEnterStorage = new Button();
            buttonEndShiftCash = new Button();
            groupBoxCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVolumeProducts).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCash
            // 
            groupBoxCash.Controls.Add(checkedListBoxProductsCash);
            groupBoxCash.Controls.Add(label2);
            groupBoxCash.Controls.Add(labelSumCash);
            groupBoxCash.Controls.Add(buttonEnterReceipt);
            groupBoxCash.Controls.Add(label1);
            groupBoxCash.Controls.Add(numericUpDownVolumeProducts);
            groupBoxCash.Controls.Add(buttonAddProductCash);
            groupBoxCash.Controls.Add(comboBoxProductList);
            groupBoxCash.Location = new Point(14, 16);
            groupBoxCash.Margin = new Padding(3, 4, 3, 4);
            groupBoxCash.Name = "groupBoxCash";
            groupBoxCash.Padding = new Padding(3, 4, 3, 4);
            groupBoxCash.Size = new Size(721, 507);
            groupBoxCash.TabIndex = 0;
            groupBoxCash.TabStop = false;
            groupBoxCash.Text = "Касса";
            // 
            // checkedListBoxProductsCash
            // 
            checkedListBoxProductsCash.FormattingEnabled = true;
            checkedListBoxProductsCash.Location = new Point(26, 111);
            checkedListBoxProductsCash.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxProductsCash.Name = "checkedListBoxProductsCash";
            checkedListBoxProductsCash.Size = new Size(661, 224);
            checkedListBoxProductsCash.TabIndex = 8;
            checkedListBoxProductsCash.ItemCheck += checkedListBoxProductsCash_ItemCheck;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 403);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 7;
            label2.Text = "руб.";
            // 
            // labelSumCash
            // 
            labelSumCash.AutoSize = true;
            labelSumCash.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelSumCash.Location = new Point(589, 385);
            labelSumCash.Name = "labelSumCash";
            labelSumCash.Size = new Size(50, 35);
            labelSumCash.TabIndex = 6;
            labelSumCash.Text = "0,0";
            // 
            // buttonEnterReceipt
            // 
            buttonEnterReceipt.Location = new Point(226, 444);
            buttonEnterReceipt.Margin = new Padding(3, 4, 3, 4);
            buttonEnterReceipt.Name = "buttonEnterReceipt";
            buttonEnterReceipt.Size = new Size(249, 31);
            buttonEnterReceipt.TabIndex = 5;
            buttonEnterReceipt.Text = "Выдать чек";
            buttonEnterReceipt.UseVisualStyleBackColor = true;
            buttonEnterReceipt.Click += buttonEnterReceipt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(661, 36);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 4;
            label1.Text = "шт.";
            // 
            // numericUpDownVolumeProducts
            // 
            numericUpDownVolumeProducts.Location = new Point(508, 29);
            numericUpDownVolumeProducts.Margin = new Padding(3, 4, 3, 4);
            numericUpDownVolumeProducts.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownVolumeProducts.Name = "numericUpDownVolumeProducts";
            numericUpDownVolumeProducts.Size = new Size(146, 27);
            numericUpDownVolumeProducts.TabIndex = 3;
            numericUpDownVolumeProducts.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAddProductCash
            // 
            buttonAddProductCash.Location = new Point(226, 69);
            buttonAddProductCash.Margin = new Padding(3, 4, 3, 4);
            buttonAddProductCash.Name = "buttonAddProductCash";
            buttonAddProductCash.Size = new Size(249, 31);
            buttonAddProductCash.TabIndex = 2;
            buttonAddProductCash.Text = "Добавить";
            buttonAddProductCash.UseVisualStyleBackColor = true;
            buttonAddProductCash.Click += buttonAddProductCash_Click;
            // 
            // comboBoxProductList
            // 
            comboBoxProductList.FormattingEnabled = true;
            comboBoxProductList.Location = new Point(26, 29);
            comboBoxProductList.Margin = new Padding(3, 4, 3, 4);
            comboBoxProductList.Name = "comboBoxProductList";
            comboBoxProductList.RightToLeft = RightToLeft.No;
            comboBoxProductList.Size = new Size(476, 28);
            comboBoxProductList.TabIndex = 0;
            // 
            // buttonEnterStorage
            // 
            buttonEnterStorage.Location = new Point(14, 541);
            buttonEnterStorage.Margin = new Padding(3, 4, 3, 4);
            buttonEnterStorage.Name = "buttonEnterStorage";
            buttonEnterStorage.Size = new Size(213, 43);
            buttonEnterStorage.TabIndex = 1;
            buttonEnterStorage.Text = "Склад";
            buttonEnterStorage.UseVisualStyleBackColor = true;
            buttonEnterStorage.Click += buttonEnterStorage_Click;
            // 
            // buttonEndShiftCash
            // 
            buttonEndShiftCash.BackColor = Color.IndianRed;
            buttonEndShiftCash.Location = new Point(522, 541);
            buttonEndShiftCash.Margin = new Padding(3, 4, 3, 4);
            buttonEndShiftCash.Name = "buttonEndShiftCash";
            buttonEndShiftCash.Size = new Size(213, 43);
            buttonEndShiftCash.TabIndex = 2;
            buttonEndShiftCash.Text = "Закончить смену";
            buttonEndShiftCash.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 600);
            Controls.Add(buttonEndShiftCash);
            Controls.Add(buttonEnterStorage);
            Controls.Add(groupBoxCash);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            groupBoxCash.ResumeLayout(false);
            groupBoxCash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVolumeProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCash;
        private Button buttonAddProductCash;
        private ComboBox comboBoxProductList;
        private Button buttonEnterReceipt;
        private Label label1;
        private NumericUpDown numericUpDownVolumeProducts;
        private Label label2;
        private Label labelSumCash;
        private Button buttonEnterStorage;
        private Button buttonEndShiftCash;
        private CheckedListBox checkedListBoxProductsCash;
    }
}
