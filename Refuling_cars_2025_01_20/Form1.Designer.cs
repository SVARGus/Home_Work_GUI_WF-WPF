namespace Refuling_cars_2025_01_20
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
            groupBoxRefueling = new GroupBox();
            groupBoxPaidRefueling = new GroupBox();
            labelSumRefueling = new Label();
            labelRub3 = new Label();
            labelRub2 = new Label();
            textBox3 = new TextBox();
            labelLitre = new Label();
            textBox2 = new TextBox();
            groupBoxLitreSum = new GroupBox();
            radioButtonSum = new RadioButton();
            radioButtonLitre = new RadioButton();
            labelRub1 = new Label();
            comboBoxPetrol = new ComboBox();
            labelPrice = new Label();
            labelPetrol = new Label();
            textBoxPriseOil = new TextBox();
            groupBoxMimiCafe = new GroupBox();
            textBoxProductCount4 = new TextBox();
            textBoxPrise4 = new TextBox();
            checkBox4 = new CheckBox();
            textBoxProductCount3 = new TextBox();
            textBoxPris3 = new TextBox();
            checkBox3 = new CheckBox();
            textBoxProductCount2 = new TextBox();
            textBoxPrise2 = new TextBox();
            checkBox2 = new CheckBox();
            textBoxProductCount1 = new TextBox();
            textBoxPrise1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            groupBoxPaidCafe = new GroupBox();
            labelSumCafe = new Label();
            label3 = new Label();
            groupBoxTotalPaid = new GroupBox();
            buttonFinalPaid = new Button();
            labelTotalSum = new Label();
            label5 = new Label();
            groupBoxRefueling.SuspendLayout();
            groupBoxPaidRefueling.SuspendLayout();
            groupBoxLitreSum.SuspendLayout();
            groupBoxMimiCafe.SuspendLayout();
            groupBoxPaidCafe.SuspendLayout();
            groupBoxTotalPaid.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRefueling
            // 
            groupBoxRefueling.Controls.Add(groupBoxPaidRefueling);
            groupBoxRefueling.Controls.Add(labelRub2);
            groupBoxRefueling.Controls.Add(textBox3);
            groupBoxRefueling.Controls.Add(labelLitre);
            groupBoxRefueling.Controls.Add(textBox2);
            groupBoxRefueling.Controls.Add(groupBoxLitreSum);
            groupBoxRefueling.Controls.Add(labelRub1);
            groupBoxRefueling.Controls.Add(comboBoxPetrol);
            groupBoxRefueling.Controls.Add(labelPrice);
            groupBoxRefueling.Controls.Add(labelPetrol);
            groupBoxRefueling.Controls.Add(textBoxPriseOil);
            groupBoxRefueling.Location = new Point(12, 12);
            groupBoxRefueling.Name = "groupBoxRefueling";
            groupBoxRefueling.Size = new Size(236, 289);
            groupBoxRefueling.TabIndex = 0;
            groupBoxRefueling.TabStop = false;
            groupBoxRefueling.Text = "Автозаправка";
            groupBoxRefueling.Enter += groupBoxRefueling_Enter;
            // 
            // groupBoxPaidRefueling
            // 
            groupBoxPaidRefueling.Controls.Add(labelSumRefueling);
            groupBoxPaidRefueling.Controls.Add(labelRub3);
            groupBoxPaidRefueling.Location = new Point(6, 191);
            groupBoxPaidRefueling.Name = "groupBoxPaidRefueling";
            groupBoxPaidRefueling.Size = new Size(209, 92);
            groupBoxPaidRefueling.TabIndex = 10;
            groupBoxPaidRefueling.TabStop = false;
            groupBoxPaidRefueling.Text = "К оплате";
            // 
            // labelSumRefueling
            // 
            labelSumRefueling.AutoSize = true;
            labelSumRefueling.Font = new Font("Segoe UI", 20F);
            labelSumRefueling.Location = new Point(86, 45);
            labelSumRefueling.Name = "labelSumRefueling";
            labelSumRefueling.Size = new Size(83, 37);
            labelSumRefueling.TabIndex = 12;
            labelSumRefueling.Text = "00,00";
            // 
            // labelRub3
            // 
            labelRub3.AutoSize = true;
            labelRub3.Location = new Point(167, 63);
            labelRub3.Name = "labelRub3";
            labelRub3.Size = new Size(30, 15);
            labelRub3.TabIndex = 11;
            labelRub3.Text = "руб.";
            // 
            // labelRub2
            // 
            labelRub2.AutoSize = true;
            labelRub2.Location = new Point(185, 155);
            labelRub2.Name = "labelRub2";
            labelRub2.Size = new Size(30, 15);
            labelRub2.TabIndex = 9;
            labelRub2.Text = "руб.";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 23);
            textBox3.TabIndex = 8;
            // 
            // labelLitre
            // 
            labelLitre.AutoSize = true;
            labelLitre.Location = new Point(185, 128);
            labelLitre.Name = "labelLitre";
            labelLitre.Size = new Size(17, 15);
            labelLitre.TabIndex = 7;
            labelLitre.Text = "л.";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(55, 23);
            textBox2.TabIndex = 6;
            // 
            // groupBoxLitreSum
            // 
            groupBoxLitreSum.Controls.Add(radioButtonSum);
            groupBoxLitreSum.Controls.Add(radioButtonLitre);
            groupBoxLitreSum.Location = new Point(6, 106);
            groupBoxLitreSum.Name = "groupBoxLitreSum";
            groupBoxLitreSum.Size = new Size(112, 79);
            groupBoxLitreSum.TabIndex = 5;
            groupBoxLitreSum.TabStop = false;
            // 
            // radioButtonSum
            // 
            radioButtonSum.AutoSize = true;
            radioButtonSum.Location = new Point(6, 47);
            radioButtonSum.Name = "radioButtonSum";
            radioButtonSum.Size = new Size(63, 19);
            radioButtonSum.TabIndex = 1;
            radioButtonSum.TabStop = true;
            radioButtonSum.Text = "Сумма";
            radioButtonSum.UseVisualStyleBackColor = true;
            // 
            // radioButtonLitre
            // 
            radioButtonLitre.AutoSize = true;
            radioButtonLitre.Location = new Point(6, 22);
            radioButtonLitre.Name = "radioButtonLitre";
            radioButtonLitre.Size = new Size(67, 19);
            radioButtonLitre.TabIndex = 0;
            radioButtonLitre.TabStop = true;
            radioButtonLitre.Text = "Литраж";
            radioButtonLitre.UseVisualStyleBackColor = true;
            // 
            // labelRub1
            // 
            labelRub1.AutoSize = true;
            labelRub1.Location = new Point(185, 80);
            labelRub1.Name = "labelRub1";
            labelRub1.Size = new Size(30, 15);
            labelRub1.TabIndex = 4;
            labelRub1.Text = "руб.";
            // 
            // comboBoxPetrol
            // 
            comboBoxPetrol.FormattingEnabled = true;
            comboBoxPetrol.Items.AddRange(new object[] { "АИ-80", "АИ-92", "АИ-95", "АИ-98", "АИ-100" });
            comboBoxPetrol.Location = new Point(58, 35);
            comboBoxPetrol.Name = "comboBoxPetrol";
            comboBoxPetrol.Size = new Size(121, 23);
            comboBoxPetrol.TabIndex = 3;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(6, 80);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(35, 15);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Цена";
            // 
            // labelPetrol
            // 
            labelPetrol.AutoSize = true;
            labelPetrol.Location = new Point(6, 38);
            labelPetrol.Name = "labelPetrol";
            labelPetrol.Size = new Size(46, 15);
            labelPetrol.TabIndex = 1;
            labelPetrol.Text = "Бензин";
            // 
            // textBoxPriseOil
            // 
            textBoxPriseOil.Enabled = false;
            textBoxPriseOil.Location = new Point(58, 77);
            textBoxPriseOil.Name = "textBoxPriseOil";
            textBoxPriseOil.Size = new Size(121, 23);
            textBoxPriseOil.TabIndex = 0;
            textBoxPriseOil.TextChanged += textBoxPriseOil_TextChanged;
            // 
            // groupBoxMimiCafe
            // 
            groupBoxMimiCafe.Controls.Add(textBoxProductCount4);
            groupBoxMimiCafe.Controls.Add(textBoxPrise4);
            groupBoxMimiCafe.Controls.Add(checkBox4);
            groupBoxMimiCafe.Controls.Add(textBoxProductCount3);
            groupBoxMimiCafe.Controls.Add(textBoxPris3);
            groupBoxMimiCafe.Controls.Add(checkBox3);
            groupBoxMimiCafe.Controls.Add(textBoxProductCount2);
            groupBoxMimiCafe.Controls.Add(textBoxPrise2);
            groupBoxMimiCafe.Controls.Add(checkBox2);
            groupBoxMimiCafe.Controls.Add(textBoxProductCount1);
            groupBoxMimiCafe.Controls.Add(textBoxPrise1);
            groupBoxMimiCafe.Controls.Add(label2);
            groupBoxMimiCafe.Controls.Add(label1);
            groupBoxMimiCafe.Controls.Add(checkBox1);
            groupBoxMimiCafe.Controls.Add(groupBoxPaidCafe);
            groupBoxMimiCafe.Location = new Point(293, 12);
            groupBoxMimiCafe.Name = "groupBoxMimiCafe";
            groupBoxMimiCafe.Size = new Size(236, 289);
            groupBoxMimiCafe.TabIndex = 1;
            groupBoxMimiCafe.TabStop = false;
            groupBoxMimiCafe.Text = "Мини-Кафе";
            // 
            // textBoxProductCount4
            // 
            textBoxProductCount4.Location = new Point(173, 147);
            textBoxProductCount4.Name = "textBoxProductCount4";
            textBoxProductCount4.Size = new Size(54, 23);
            textBoxProductCount4.TabIndex = 27;
            // 
            // textBoxPrise4
            // 
            textBoxPrise4.Enabled = false;
            textBoxPrise4.Location = new Point(111, 147);
            textBoxPrise4.Name = "textBoxPrise4";
            textBoxPrise4.Size = new Size(48, 23);
            textBoxPrise4.TabIndex = 26;
            textBoxPrise4.Text = "4,40";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 149);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(53, 19);
            checkBox4.TabIndex = 25;
            checkBox4.Text = "Кола";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBoxProductCount3
            // 
            textBoxProductCount3.Location = new Point(173, 111);
            textBoxProductCount3.Name = "textBoxProductCount3";
            textBoxProductCount3.Size = new Size(54, 23);
            textBoxProductCount3.TabIndex = 24;
            // 
            // textBoxPris3
            // 
            textBoxPris3.Enabled = false;
            textBoxPris3.Location = new Point(111, 111);
            textBoxPris3.Name = "textBoxPris3";
            textBoxPris3.Size = new Size(48, 23);
            textBoxPris3.TabIndex = 23;
            textBoxPris3.Text = "7,20";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 115);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(97, 19);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "Фри-картоха";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBoxProductCount2
            // 
            textBoxProductCount2.Location = new Point(173, 77);
            textBoxProductCount2.Name = "textBoxProductCount2";
            textBoxProductCount2.Size = new Size(54, 23);
            textBoxProductCount2.TabIndex = 21;
            // 
            // textBoxPrise2
            // 
            textBoxPrise2.Enabled = false;
            textBoxPrise2.Location = new Point(111, 77);
            textBoxPrise2.Name = "textBoxPrise2";
            textBoxPrise2.Size = new Size(48, 23);
            textBoxPrise2.TabIndex = 20;
            textBoxPrise2.Text = "5,40";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 81);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(85, 19);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Гамбургер";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBoxProductCount1
            // 
            textBoxProductCount1.Location = new Point(173, 46);
            textBoxProductCount1.Name = "textBoxProductCount1";
            textBoxProductCount1.Size = new Size(54, 23);
            textBoxProductCount1.TabIndex = 18;
            // 
            // textBoxPrise1
            // 
            textBoxPrise1.Enabled = false;
            textBoxPrise1.Location = new Point(111, 46);
            textBoxPrise1.Name = "textBoxPrise1";
            textBoxPrise1.Size = new Size(48, 23);
            textBoxPrise1.TabIndex = 17;
            textBoxPrise1.Text = "4,00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 19);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 16;
            label2.Text = "Количество";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 19);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 15;
            label1.Text = "Цена";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 50);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Хот-дог";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBoxPaidCafe
            // 
            groupBoxPaidCafe.Controls.Add(labelSumCafe);
            groupBoxPaidCafe.Controls.Add(label3);
            groupBoxPaidCafe.Location = new Point(6, 191);
            groupBoxPaidCafe.Name = "groupBoxPaidCafe";
            groupBoxPaidCafe.Size = new Size(209, 92);
            groupBoxPaidCafe.TabIndex = 13;
            groupBoxPaidCafe.TabStop = false;
            groupBoxPaidCafe.Text = "К оплате";
            // 
            // labelSumCafe
            // 
            labelSumCafe.AutoSize = true;
            labelSumCafe.Font = new Font("Segoe UI", 20F);
            labelSumCafe.Location = new Point(86, 45);
            labelSumCafe.Name = "labelSumCafe";
            labelSumCafe.Size = new Size(83, 37);
            labelSumCafe.TabIndex = 12;
            labelSumCafe.Text = "00,00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 63);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 11;
            label3.Text = "руб.";
            // 
            // groupBoxTotalPaid
            // 
            groupBoxTotalPaid.Controls.Add(buttonFinalPaid);
            groupBoxTotalPaid.Controls.Add(labelTotalSum);
            groupBoxTotalPaid.Controls.Add(label5);
            groupBoxTotalPaid.Location = new Point(12, 322);
            groupBoxTotalPaid.Name = "groupBoxTotalPaid";
            groupBoxTotalPaid.Size = new Size(514, 116);
            groupBoxTotalPaid.TabIndex = 2;
            groupBoxTotalPaid.TabStop = false;
            groupBoxTotalPaid.Text = "ВСЕГО к оплате";
            // 
            // buttonFinalPaid
            // 
            buttonFinalPaid.BackColor = SystemColors.Control;
            buttonFinalPaid.Font = new Font("Segoe UI", 12F);
            buttonFinalPaid.Location = new Point(34, 60);
            buttonFinalPaid.Name = "buttonFinalPaid";
            buttonFinalPaid.Size = new Size(215, 38);
            buttonFinalPaid.TabIndex = 15;
            buttonFinalPaid.Text = "ОПЛАТИТЬ";
            buttonFinalPaid.UseVisualStyleBackColor = false;
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.Font = new Font("Segoe UI", 20F);
            labelTotalSum.Location = new Point(344, 61);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(83, 37);
            labelTotalSum.TabIndex = 14;
            labelTotalSum.Text = "00,00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 79);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 13;
            label5.Text = "руб.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(groupBoxTotalPaid);
            Controls.Add(groupBoxMimiCafe);
            Controls.Add(groupBoxRefueling);
            Name = "Form1";
            Text = "Form1";
            groupBoxRefueling.ResumeLayout(false);
            groupBoxRefueling.PerformLayout();
            groupBoxPaidRefueling.ResumeLayout(false);
            groupBoxPaidRefueling.PerformLayout();
            groupBoxLitreSum.ResumeLayout(false);
            groupBoxLitreSum.PerformLayout();
            groupBoxMimiCafe.ResumeLayout(false);
            groupBoxMimiCafe.PerformLayout();
            groupBoxPaidCafe.ResumeLayout(false);
            groupBoxPaidCafe.PerformLayout();
            groupBoxTotalPaid.ResumeLayout(false);
            groupBoxTotalPaid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRefueling;
        private GroupBox groupBoxMimiCafe;
        private Label labelPrice;
        private Label labelPetrol;
        private TextBox textBoxPriseOil;
        private GroupBox groupBoxLitreSum;
        private Label labelRub1;
        private ComboBox comboBoxPetrol;
        private TextBox textBox3;
        private Label labelLitre;
        private TextBox textBox2;
        private RadioButton radioButtonSum;
        private RadioButton radioButtonLitre;
        private Label labelRub2;
        private GroupBox groupBoxPaidRefueling;
        private Label labelRub3;
        private Label labelSumRefueling;
        private GroupBox groupBoxPaidCafe;
        private Label labelSumCafe;
        private Label label3;
        private TextBox textBoxProductCount1;
        private TextBox textBoxPrise1;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBoxProductCount4;
        private TextBox textBoxPrise4;
        private CheckBox checkBox4;
        private TextBox textBoxProductCount3;
        private TextBox textBoxPris3;
        private CheckBox checkBox3;
        private TextBox textBoxProductCount2;
        private TextBox textBoxPrise2;
        private CheckBox checkBox2;
        private GroupBox groupBoxTotalPaid;
        private Button buttonFinalPaid;
        private Label labelTotalSum;
        private Label label5;
    }
}
