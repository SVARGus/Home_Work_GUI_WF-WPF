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
            components = new System.ComponentModel.Container();
            groupBoxRefueling = new GroupBox();
            groupBoxPaidRefueling = new GroupBox();
            labelSumRefueling = new Label();
            labelRub3 = new Label();
            labelRub2 = new Label();
            textBoxEnterSum = new TextBox();
            labelLitre = new Label();
            textBoxEnterLiter = new TextBox();
            groupBoxLitreSum = new GroupBox();
            radioButtonSum = new RadioButton();
            radioButtonLitre = new RadioButton();
            labelRub1 = new Label();
            comboBoxPetrol = new ComboBox();
            productBindingSource = new BindingSource(components);
            labelPrice = new Label();
            labelPetrol = new Label();
            textBoxPriseOil = new TextBox();
            groupBoxMimiCafe = new GroupBox();
            textBoxProductCount4 = new TextBox();
            textBoxPrise4 = new TextBox();
            checkBox4 = new CheckBox();
            textBoxProductCount3 = new TextBox();
            textBoxPrise3 = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            groupBoxMimiCafe.SuspendLayout();
            groupBoxPaidCafe.SuspendLayout();
            groupBoxTotalPaid.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRefueling
            // 
            groupBoxRefueling.Controls.Add(groupBoxPaidRefueling);
            groupBoxRefueling.Controls.Add(labelRub2);
            groupBoxRefueling.Controls.Add(textBoxEnterSum);
            groupBoxRefueling.Controls.Add(labelLitre);
            groupBoxRefueling.Controls.Add(textBoxEnterLiter);
            groupBoxRefueling.Controls.Add(groupBoxLitreSum);
            groupBoxRefueling.Controls.Add(labelRub1);
            groupBoxRefueling.Controls.Add(comboBoxPetrol);
            groupBoxRefueling.Controls.Add(labelPrice);
            groupBoxRefueling.Controls.Add(labelPetrol);
            groupBoxRefueling.Controls.Add(textBoxPriseOil);
            groupBoxRefueling.Location = new Point(14, 16);
            groupBoxRefueling.Margin = new Padding(3, 4, 3, 4);
            groupBoxRefueling.Name = "groupBoxRefueling";
            groupBoxRefueling.Padding = new Padding(3, 4, 3, 4);
            groupBoxRefueling.Size = new Size(270, 385);
            groupBoxRefueling.TabIndex = 0;
            groupBoxRefueling.TabStop = false;
            groupBoxRefueling.Text = "Автозаправка";
            groupBoxRefueling.Enter += groupBoxRefueling_Enter;
            // 
            // groupBoxPaidRefueling
            // 
            groupBoxPaidRefueling.Controls.Add(labelSumRefueling);
            groupBoxPaidRefueling.Controls.Add(labelRub3);
            groupBoxPaidRefueling.Location = new Point(7, 255);
            groupBoxPaidRefueling.Margin = new Padding(3, 4, 3, 4);
            groupBoxPaidRefueling.Name = "groupBoxPaidRefueling";
            groupBoxPaidRefueling.Padding = new Padding(3, 4, 3, 4);
            groupBoxPaidRefueling.Size = new Size(239, 123);
            groupBoxPaidRefueling.TabIndex = 10;
            groupBoxPaidRefueling.TabStop = false;
            groupBoxPaidRefueling.Text = "К оплате";
            // 
            // labelSumRefueling
            // 
            labelSumRefueling.Font = new Font("Segoe UI", 20F);
            labelSumRefueling.Location = new Point(7, 60);
            labelSumRefueling.Name = "labelSumRefueling";
            labelSumRefueling.Size = new Size(178, 46);
            labelSumRefueling.TabIndex = 12;
            labelSumRefueling.Text = "0,00";
            labelSumRefueling.TextAlign = ContentAlignment.TopRight;
            // 
            // labelRub3
            // 
            labelRub3.AutoSize = true;
            labelRub3.Location = new Point(191, 84);
            labelRub3.Name = "labelRub3";
            labelRub3.Size = new Size(37, 20);
            labelRub3.TabIndex = 11;
            labelRub3.Text = "руб.";
            // 
            // labelRub2
            // 
            labelRub2.AutoSize = true;
            labelRub2.Location = new Point(211, 207);
            labelRub2.Name = "labelRub2";
            labelRub2.Size = new Size(37, 20);
            labelRub2.TabIndex = 9;
            labelRub2.Text = "руб.";
            // 
            // textBoxEnterSum
            // 
            textBoxEnterSum.Enabled = false;
            textBoxEnterSum.Location = new Point(142, 203);
            textBoxEnterSum.Margin = new Padding(3, 4, 3, 4);
            textBoxEnterSum.Name = "textBoxEnterSum";
            textBoxEnterSum.Size = new Size(62, 27);
            textBoxEnterSum.TabIndex = 8;
            textBoxEnterSum.KeyDown += textBoxEnter_KeyDown;
            textBoxEnterSum.KeyPress += textBoxEnter_KeyPress;
            textBoxEnterSum.Leave += textBoxEnterSum_UpdateLabelOnLeave;
            // 
            // labelLitre
            // 
            labelLitre.AutoSize = true;
            labelLitre.Location = new Point(211, 171);
            labelLitre.Name = "labelLitre";
            labelLitre.Size = new Size(20, 20);
            labelLitre.TabIndex = 7;
            labelLitre.Text = "л.";
            // 
            // textBoxEnterLiter
            // 
            textBoxEnterLiter.Enabled = false;
            textBoxEnterLiter.Location = new Point(142, 165);
            textBoxEnterLiter.Margin = new Padding(3, 4, 3, 4);
            textBoxEnterLiter.Name = "textBoxEnterLiter";
            textBoxEnterLiter.Size = new Size(62, 27);
            textBoxEnterLiter.TabIndex = 6;
            textBoxEnterLiter.KeyDown += textBoxEnter_KeyDown;
            textBoxEnterLiter.KeyPress += textBoxEnter_KeyPress;
            textBoxEnterLiter.Leave += textBoxEnterLiter_UpdateLabelOnLeave;
            // 
            // groupBoxLitreSum
            // 
            groupBoxLitreSum.Controls.Add(radioButtonSum);
            groupBoxLitreSum.Controls.Add(radioButtonLitre);
            groupBoxLitreSum.Location = new Point(7, 141);
            groupBoxLitreSum.Margin = new Padding(3, 4, 3, 4);
            groupBoxLitreSum.Name = "groupBoxLitreSum";
            groupBoxLitreSum.Padding = new Padding(3, 4, 3, 4);
            groupBoxLitreSum.Size = new Size(128, 105);
            groupBoxLitreSum.TabIndex = 5;
            groupBoxLitreSum.TabStop = false;
            // 
            // radioButtonSum
            // 
            radioButtonSum.AutoSize = true;
            radioButtonSum.Location = new Point(7, 63);
            radioButtonSum.Margin = new Padding(3, 4, 3, 4);
            radioButtonSum.Name = "radioButtonSum";
            radioButtonSum.Size = new Size(76, 24);
            radioButtonSum.TabIndex = 1;
            radioButtonSum.TabStop = true;
            radioButtonSum.Text = "Сумма";
            radioButtonSum.UseVisualStyleBackColor = true;
            radioButtonSum.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButtonLitre
            // 
            radioButtonLitre.AutoSize = true;
            radioButtonLitre.Location = new Point(7, 29);
            radioButtonLitre.Margin = new Padding(3, 4, 3, 4);
            radioButtonLitre.Name = "radioButtonLitre";
            radioButtonLitre.Size = new Size(83, 24);
            radioButtonLitre.TabIndex = 0;
            radioButtonLitre.TabStop = true;
            radioButtonLitre.Text = "Литраж";
            radioButtonLitre.UseVisualStyleBackColor = true;
            radioButtonLitre.CheckedChanged += radioButton_CheckedChanged;
            // 
            // labelRub1
            // 
            labelRub1.AutoSize = true;
            labelRub1.Location = new Point(211, 107);
            labelRub1.Name = "labelRub1";
            labelRub1.Size = new Size(37, 20);
            labelRub1.TabIndex = 4;
            labelRub1.Text = "руб.";
            // 
            // comboBoxPetrol
            // 
            comboBoxPetrol.DataSource = productBindingSource;
            comboBoxPetrol.DisplayMember = "Name";
            comboBoxPetrol.FormattingEnabled = true;
            comboBoxPetrol.Location = new Point(66, 47);
            comboBoxPetrol.Margin = new Padding(3, 4, 3, 4);
            comboBoxPetrol.Name = "comboBoxPetrol";
            comboBoxPetrol.Size = new Size(138, 28);
            comboBoxPetrol.TabIndex = 3;
            comboBoxPetrol.ValueMember = "Price";
            comboBoxPetrol.SelectedIndexChanged += comboBoxPetrol_SelectedIndexChanged;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(7, 107);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(45, 20);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Цена";
            // 
            // labelPetrol
            // 
            labelPetrol.AutoSize = true;
            labelPetrol.Location = new Point(7, 51);
            labelPetrol.Name = "labelPetrol";
            labelPetrol.Size = new Size(60, 20);
            labelPetrol.TabIndex = 1;
            labelPetrol.Text = "Бензин";
            // 
            // textBoxPriseOil
            // 
            textBoxPriseOil.Enabled = false;
            textBoxPriseOil.Location = new Point(66, 103);
            textBoxPriseOil.Margin = new Padding(3, 4, 3, 4);
            textBoxPriseOil.Name = "textBoxPriseOil";
            textBoxPriseOil.Size = new Size(138, 27);
            textBoxPriseOil.TabIndex = 0;
            textBoxPriseOil.Text = "0,00";
            textBoxPriseOil.TextChanged += textBoxPriseOil_TextChanged;
            // 
            // groupBoxMimiCafe
            // 
            groupBoxMimiCafe.Controls.Add(textBoxProductCount4);
            groupBoxMimiCafe.Controls.Add(textBoxPrise4);
            groupBoxMimiCafe.Controls.Add(checkBox4);
            groupBoxMimiCafe.Controls.Add(textBoxProductCount3);
            groupBoxMimiCafe.Controls.Add(textBoxPrise3);
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
            groupBoxMimiCafe.Location = new Point(335, 16);
            groupBoxMimiCafe.Margin = new Padding(3, 4, 3, 4);
            groupBoxMimiCafe.Name = "groupBoxMimiCafe";
            groupBoxMimiCafe.Padding = new Padding(3, 4, 3, 4);
            groupBoxMimiCafe.Size = new Size(270, 385);
            groupBoxMimiCafe.TabIndex = 1;
            groupBoxMimiCafe.TabStop = false;
            groupBoxMimiCafe.Text = "Мини-Кафе";
            // 
            // textBoxProductCount4
            // 
            textBoxProductCount4.Enabled = false;
            textBoxProductCount4.Location = new Point(198, 196);
            textBoxProductCount4.Margin = new Padding(3, 4, 3, 4);
            textBoxProductCount4.Name = "textBoxProductCount4";
            textBoxProductCount4.Size = new Size(61, 27);
            textBoxProductCount4.TabIndex = 27;
            textBoxProductCount4.KeyDown += textBoxEnter_KeyDown;
            textBoxProductCount4.KeyPress += textBoxProductCount_KeyPress;
            textBoxProductCount4.Leave += textBoxProductCount_Leave;
            // 
            // textBoxPrise4
            // 
            textBoxPrise4.Enabled = false;
            textBoxPrise4.Location = new Point(127, 196);
            textBoxPrise4.Margin = new Padding(3, 4, 3, 4);
            textBoxPrise4.Name = "textBoxPrise4";
            textBoxPrise4.Size = new Size(54, 27);
            textBoxPrise4.TabIndex = 26;
            textBoxPrise4.Text = "4,40";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(7, 199);
            checkBox4.Margin = new Padding(3, 4, 3, 4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(65, 24);
            checkBox4.TabIndex = 25;
            checkBox4.Text = "Кола";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // textBoxProductCount3
            // 
            textBoxProductCount3.Enabled = false;
            textBoxProductCount3.Location = new Point(198, 148);
            textBoxProductCount3.Margin = new Padding(3, 4, 3, 4);
            textBoxProductCount3.Name = "textBoxProductCount3";
            textBoxProductCount3.Size = new Size(61, 27);
            textBoxProductCount3.TabIndex = 24;
            textBoxProductCount3.KeyDown += textBoxEnter_KeyDown;
            textBoxProductCount3.KeyPress += textBoxProductCount_KeyPress;
            textBoxProductCount3.Leave += textBoxProductCount_Leave;
            // 
            // textBoxPrise3
            // 
            textBoxPrise3.Enabled = false;
            textBoxPrise3.Location = new Point(127, 148);
            textBoxPrise3.Margin = new Padding(3, 4, 3, 4);
            textBoxPrise3.Name = "textBoxPrise3";
            textBoxPrise3.Size = new Size(54, 27);
            textBoxPrise3.TabIndex = 23;
            textBoxPrise3.Text = "7,20";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(7, 153);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(120, 24);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "Фри-картоха";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // textBoxProductCount2
            // 
            textBoxProductCount2.Enabled = false;
            textBoxProductCount2.Location = new Point(198, 103);
            textBoxProductCount2.Margin = new Padding(3, 4, 3, 4);
            textBoxProductCount2.Name = "textBoxProductCount2";
            textBoxProductCount2.Size = new Size(61, 27);
            textBoxProductCount2.TabIndex = 21;
            textBoxProductCount2.KeyDown += textBoxEnter_KeyDown;
            textBoxProductCount2.KeyPress += textBoxProductCount_KeyPress;
            textBoxProductCount2.Leave += textBoxProductCount_Leave;
            // 
            // textBoxPrise2
            // 
            textBoxPrise2.Enabled = false;
            textBoxPrise2.Location = new Point(127, 103);
            textBoxPrise2.Margin = new Padding(3, 4, 3, 4);
            textBoxPrise2.Name = "textBoxPrise2";
            textBoxPrise2.Size = new Size(54, 27);
            textBoxPrise2.TabIndex = 20;
            textBoxPrise2.Text = "5,40";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(7, 108);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 24);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Гамбургер";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBoxProductCount1
            // 
            textBoxProductCount1.Enabled = false;
            textBoxProductCount1.Location = new Point(198, 61);
            textBoxProductCount1.Margin = new Padding(3, 4, 3, 4);
            textBoxProductCount1.Name = "textBoxProductCount1";
            textBoxProductCount1.Size = new Size(61, 27);
            textBoxProductCount1.TabIndex = 18;
            textBoxProductCount1.KeyDown += textBoxEnter_KeyDown;
            textBoxProductCount1.KeyPress += textBoxProductCount_KeyPress;
            textBoxProductCount1.Leave += textBoxProductCount_Leave;
            // 
            // textBoxPrise1
            // 
            textBoxPrise1.Enabled = false;
            textBoxPrise1.Location = new Point(127, 61);
            textBoxPrise1.Margin = new Padding(3, 4, 3, 4);
            textBoxPrise1.Name = "textBoxPrise1";
            textBoxPrise1.Size = new Size(54, 27);
            textBoxPrise1.TabIndex = 17;
            textBoxPrise1.Text = "4,00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 25);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 16;
            label2.Text = "Количество";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 15;
            label1.Text = "Цена";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(7, 67);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Хот-дог";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBoxPaidCafe
            // 
            groupBoxPaidCafe.Controls.Add(labelSumCafe);
            groupBoxPaidCafe.Controls.Add(label3);
            groupBoxPaidCafe.Location = new Point(7, 255);
            groupBoxPaidCafe.Margin = new Padding(3, 4, 3, 4);
            groupBoxPaidCafe.Name = "groupBoxPaidCafe";
            groupBoxPaidCafe.Padding = new Padding(3, 4, 3, 4);
            groupBoxPaidCafe.Size = new Size(239, 123);
            groupBoxPaidCafe.TabIndex = 13;
            groupBoxPaidCafe.TabStop = false;
            groupBoxPaidCafe.Text = "К оплате";
            // 
            // labelSumCafe
            // 
            labelSumCafe.Font = new Font("Segoe UI", 20F);
            labelSumCafe.Location = new Point(6, 60);
            labelSumCafe.Name = "labelSumCafe";
            labelSumCafe.Size = new Size(179, 46);
            labelSumCafe.TabIndex = 12;
            labelSumCafe.Text = "0,00";
            labelSumCafe.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 84);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 11;
            label3.Text = "руб.";
            // 
            // groupBoxTotalPaid
            // 
            groupBoxTotalPaid.Controls.Add(buttonFinalPaid);
            groupBoxTotalPaid.Controls.Add(labelTotalSum);
            groupBoxTotalPaid.Controls.Add(label5);
            groupBoxTotalPaid.Location = new Point(14, 429);
            groupBoxTotalPaid.Margin = new Padding(3, 4, 3, 4);
            groupBoxTotalPaid.Name = "groupBoxTotalPaid";
            groupBoxTotalPaid.Padding = new Padding(3, 4, 3, 4);
            groupBoxTotalPaid.Size = new Size(587, 155);
            groupBoxTotalPaid.TabIndex = 2;
            groupBoxTotalPaid.TabStop = false;
            groupBoxTotalPaid.Text = "ВСЕГО к оплате";
            // 
            // buttonFinalPaid
            // 
            buttonFinalPaid.BackColor = SystemColors.Control;
            buttonFinalPaid.Font = new Font("Segoe UI", 12F);
            buttonFinalPaid.Location = new Point(39, 80);
            buttonFinalPaid.Margin = new Padding(3, 4, 3, 4);
            buttonFinalPaid.Name = "buttonFinalPaid";
            buttonFinalPaid.Size = new Size(246, 51);
            buttonFinalPaid.TabIndex = 15;
            buttonFinalPaid.Text = "ОПЛАТИТЬ";
            buttonFinalPaid.UseVisualStyleBackColor = false;
            buttonFinalPaid.Click += buttonFinalPaid_Click;
            // 
            // labelTotalSum
            // 
            labelTotalSum.Font = new Font("Segoe UI", 20F);
            labelTotalSum.Location = new Point(291, 81);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(201, 46);
            labelTotalSum.TabIndex = 14;
            labelTotalSum.Text = "0,00";
            labelTotalSum.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 105);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 13;
            label5.Text = "руб.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 600);
            Controls.Add(groupBoxTotalPaid);
            Controls.Add(groupBoxMimiCafe);
            Controls.Add(groupBoxRefueling);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBoxRefueling.ResumeLayout(false);
            groupBoxRefueling.PerformLayout();
            groupBoxPaidRefueling.ResumeLayout(false);
            groupBoxPaidRefueling.PerformLayout();
            groupBoxLitreSum.ResumeLayout(false);
            groupBoxLitreSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
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
        private TextBox textBoxEnterSum;
        private Label labelLitre;
        private TextBox textBoxEnterLiter;
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
        private TextBox textBoxPrise3;
        private CheckBox checkBox3;
        private TextBox textBoxProductCount2;
        private TextBox textBoxPrise2;
        private CheckBox checkBox2;
        private GroupBox groupBoxTotalPaid;
        private Button buttonFinalPaid;
        private Label labelTotalSum;
        private Label label5;
        private BindingSource productBindingSource;
    }
}
