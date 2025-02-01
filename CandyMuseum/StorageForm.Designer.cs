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
            listBoxStorage.ItemHeight = 15;
            listBoxStorage.Location = new Point(12, 16);
            listBoxStorage.Name = "listBoxStorage";
            listBoxStorage.Size = new Size(377, 304);
            listBoxStorage.TabIndex = 0;
            // 
            // buttonRemoveProduct
            // 
            buttonRemoveProduct.Location = new Point(12, 386);
            buttonRemoveProduct.Name = "buttonRemoveProduct";
            buttonRemoveProduct.Size = new Size(377, 23);
            buttonRemoveProduct.TabIndex = 1;
            buttonRemoveProduct.Text = "Удалить товар";
            buttonRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 415);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(377, 23);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Вернуться";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonModifyProduct
            // 
            buttonModifyProduct.Location = new Point(12, 357);
            buttonModifyProduct.Name = "buttonModifyProduct";
            buttonModifyProduct.Size = new Size(377, 23);
            buttonModifyProduct.TabIndex = 3;
            buttonModifyProduct.Text = "Изменить товар";
            buttonModifyProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(12, 328);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(377, 23);
            buttonAddProduct.TabIndex = 4;
            buttonAddProduct.Text = "Добавить товар";
            buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // StorageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(buttonAddProduct);
            Controls.Add(buttonModifyProduct);
            Controls.Add(buttonBack);
            Controls.Add(buttonRemoveProduct);
            Controls.Add(listBoxStorage);
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