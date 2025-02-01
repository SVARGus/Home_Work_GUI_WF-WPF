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
            comboBox1 = new ComboBox();
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
            groupBoxCash.Controls.Add(comboBox1);
            groupBoxCash.Location = new Point(12, 12);
            groupBoxCash.Name = "groupBoxCash";
            groupBoxCash.Size = new Size(631, 380);
            groupBoxCash.TabIndex = 0;
            groupBoxCash.TabStop = false;
            groupBoxCash.Text = "Касса";
            // 
            // checkedListBoxProductsCash
            // 
            checkedListBoxProductsCash.FormattingEnabled = true;
            checkedListBoxProductsCash.Location = new Point(23, 83);
            checkedListBoxProductsCash.Name = "checkedListBoxProductsCash";
            checkedListBoxProductsCash.Size = new Size(579, 184);
            checkedListBoxProductsCash.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 302);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 7;
            label2.Text = "руб.";
            // 
            // labelSumCash
            // 
            labelSumCash.AutoSize = true;
            labelSumCash.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelSumCash.Location = new Point(515, 289);
            labelSumCash.Name = "labelSumCash";
            labelSumCash.Size = new Size(41, 28);
            labelSumCash.TabIndex = 6;
            labelSumCash.Text = "0,0";
            // 
            // buttonEnterReceipt
            // 
            buttonEnterReceipt.Location = new Point(198, 333);
            buttonEnterReceipt.Name = "buttonEnterReceipt";
            buttonEnterReceipt.Size = new Size(218, 23);
            buttonEnterReceipt.TabIndex = 5;
            buttonEnterReceipt.Text = "Выдать чек";
            buttonEnterReceipt.UseVisualStyleBackColor = true;
            buttonEnterReceipt.Click += buttonEnterReceipt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(562, 26);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "кг";
            // 
            // numericUpDownVolumeProducts
            // 
            numericUpDownVolumeProducts.Location = new Point(428, 22);
            numericUpDownVolumeProducts.Name = "numericUpDownVolumeProducts";
            numericUpDownVolumeProducts.Size = new Size(128, 23);
            numericUpDownVolumeProducts.TabIndex = 3;
            numericUpDownVolumeProducts.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAddProductCash
            // 
            buttonAddProductCash.Location = new Point(198, 52);
            buttonAddProductCash.Name = "buttonAddProductCash";
            buttonAddProductCash.Size = new Size(218, 23);
            buttonAddProductCash.TabIndex = 2;
            buttonAddProductCash.Text = "Добавить";
            buttonAddProductCash.UseVisualStyleBackColor = true;
            buttonAddProductCash.Click += buttonAddProductCash_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(359, 23);
            comboBox1.TabIndex = 0;
            // 
            // buttonEnterStorage
            // 
            buttonEnterStorage.Location = new Point(12, 406);
            buttonEnterStorage.Name = "buttonEnterStorage";
            buttonEnterStorage.Size = new Size(186, 32);
            buttonEnterStorage.TabIndex = 1;
            buttonEnterStorage.Text = "Склад";
            buttonEnterStorage.UseVisualStyleBackColor = true;
            buttonEnterStorage.Click += buttonEnterStorage_Click;
            // 
            // buttonEndShiftCash
            // 
            buttonEndShiftCash.BackColor = Color.IndianRed;
            buttonEndShiftCash.Location = new Point(457, 406);
            buttonEndShiftCash.Name = "buttonEndShiftCash";
            buttonEndShiftCash.Size = new Size(186, 32);
            buttonEndShiftCash.TabIndex = 2;
            buttonEndShiftCash.Text = "Закончить смену";
            buttonEndShiftCash.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 450);
            Controls.Add(buttonEndShiftCash);
            Controls.Add(buttonEnterStorage);
            Controls.Add(groupBoxCash);
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
        private ComboBox comboBox1;
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
