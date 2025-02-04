namespace CandyMuseum
{
    partial class StorageForm
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
            listBoxStorage = new ListBox();
            buttonRemoveProduct = new Button();
            buttonBack = new Button();
            buttonModifyProduct = new Button();
            buttonAddProduct = new Button();
            SuspendLayout();
            // 
            // listBoxStorage
            // 
            listBoxStorage.FormattingEnabled = true;
            listBoxStorage.Location = new Point(14, 21);
            listBoxStorage.Margin = new Padding(3, 4, 3, 4);
            listBoxStorage.Name = "listBoxStorage";
            listBoxStorage.Size = new Size(430, 404);
            listBoxStorage.TabIndex = 0;
            // 
            // buttonRemoveProduct
            // 
            buttonRemoveProduct.Location = new Point(14, 515);
            buttonRemoveProduct.Margin = new Padding(3, 4, 3, 4);
            buttonRemoveProduct.Name = "buttonRemoveProduct";
            buttonRemoveProduct.Size = new Size(431, 31);
            buttonRemoveProduct.TabIndex = 1;
            buttonRemoveProduct.Text = "Удалить товар";
            buttonRemoveProduct.UseVisualStyleBackColor = true;
            buttonRemoveProduct.Click += buttonRemoveProduct_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(14, 553);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(431, 31);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Вернуться";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonModifyProduct
            // 
            buttonModifyProduct.Location = new Point(14, 476);
            buttonModifyProduct.Margin = new Padding(3, 4, 3, 4);
            buttonModifyProduct.Name = "buttonModifyProduct";
            buttonModifyProduct.Size = new Size(431, 31);
            buttonModifyProduct.TabIndex = 3;
            buttonModifyProduct.Text = "Изменить товар";
            buttonModifyProduct.UseVisualStyleBackColor = true;
            buttonModifyProduct.Click += buttonModifyProduct_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(14, 437);
            buttonAddProduct.Margin = new Padding(3, 4, 3, 4);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(431, 31);
            buttonAddProduct.TabIndex = 4;
            buttonAddProduct.Text = "Добавить товар";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // StorageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 600);
            Controls.Add(buttonAddProduct);
            Controls.Add(buttonModifyProduct);
            Controls.Add(buttonBack);
            Controls.Add(buttonRemoveProduct);
            Controls.Add(listBoxStorage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StorageForm";
            Text = "Товары";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxStorage;
        private Button buttonRemoveProduct;
        private Button buttonBack;
        private Button buttonModifyProduct;
        private Button buttonAddProduct;
    }
}