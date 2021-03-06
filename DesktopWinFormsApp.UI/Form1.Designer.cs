
namespace DesktopWinFormsApp.UI
{
    partial class Form1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategoryForSearch = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductForSearch = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.lblProductNameForAddProduct = new System.Windows.Forms.Label();
            this.lblCategoryForAddProduct = new System.Windows.Forms.Label();
            this.lblUnitPriceForAddProduct = new System.Windows.Forms.Label();
            this.lblStockForAddProduct = new System.Windows.Forms.Label();
            this.lblQuantityPerUnitForAddProduct = new System.Windows.Forms.Label();
            this.tbxProductNameForAddProduct = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceForAddProduct = new System.Windows.Forms.TextBox();
            this.tbxStockForAddProduct = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitForAddProduct = new System.Windows.Forms.TextBox();
            this.cbxCategoryForAddProduct = new System.Windows.Forms.ComboBox();
            this.btnAddForAddProduct = new System.Windows.Forms.Button();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdateForUpdateProduct = new System.Windows.Forms.Button();
            this.cbxCategoryForUpdateProduct = new System.Windows.Forms.ComboBox();
            this.tbxQuantityPerUnitForUpdateProduct = new System.Windows.Forms.TextBox();
            this.tbxStockForUpdateProduct = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceForUpdateProduct = new System.Windows.Forms.TextBox();
            this.tbxProductNameForUpdateProduct = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitForUpdateProduct = new System.Windows.Forms.Label();
            this.lblStockForUpdateProduct = new System.Windows.Forms.Label();
            this.lblUnitPriceForUpdateProduct = new System.Windows.Forms.Label();
            this.lblCategoryForUpdateProduct = new System.Windows.Forms.Label();
            this.lblProductNameForUpdateProduct = new System.Windows.Forms.Label();
            this.btnDeleteForDeleteProduct = new System.Windows.Forms.Button();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategoryForSearch);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(1030, 100);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Search by category";
            // 
            // cbxCategoryForSearch
            // 
            this.cbxCategoryForSearch.FormattingEnabled = true;
            this.cbxCategoryForSearch.Location = new System.Drawing.Point(375, 42);
            this.cbxCategoryForSearch.Name = "cbxCategoryForSearch";
            this.cbxCategoryForSearch.Size = new System.Drawing.Size(320, 24);
            this.cbxCategoryForSearch.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(277, 49);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProductForSearch);
            this.gbxProduct.Controls.Add(this.lblProduct);
            this.gbxProduct.Location = new System.Drawing.Point(12, 130);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(1030, 100);
            this.gbxProduct.TabIndex = 1;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Search by product";
            // 
            // tbxProductForSearch
            // 
            this.tbxProductForSearch.Location = new System.Drawing.Point(375, 40);
            this.tbxProductForSearch.Name = "tbxProductForSearch";
            this.tbxProductForSearch.Size = new System.Drawing.Size(320, 22);
            this.tbxProductForSearch.TabIndex = 2;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(277, 45);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(57, 17);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 248);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1030, 238);
            this.dgwProduct.TabIndex = 2;
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.btnAddForAddProduct);
            this.gbxAddProduct.Controls.Add(this.cbxCategoryForAddProduct);
            this.gbxAddProduct.Controls.Add(this.tbxQuantityPerUnitForAddProduct);
            this.gbxAddProduct.Controls.Add(this.tbxStockForAddProduct);
            this.gbxAddProduct.Controls.Add(this.tbxUnitPriceForAddProduct);
            this.gbxAddProduct.Controls.Add(this.tbxProductNameForAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblQuantityPerUnitForAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblStockForAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblUnitPriceForAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblCategoryForAddProduct);
            this.gbxAddProduct.Controls.Add(this.lblProductNameForAddProduct);
            this.gbxAddProduct.Location = new System.Drawing.Point(12, 516);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(357, 276);
            this.gbxAddProduct.TabIndex = 3;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Add New Product";
            // 
            // lblProductNameForAddProduct
            // 
            this.lblProductNameForAddProduct.AutoSize = true;
            this.lblProductNameForAddProduct.Location = new System.Drawing.Point(13, 31);
            this.lblProductNameForAddProduct.Name = "lblProductNameForAddProduct";
            this.lblProductNameForAddProduct.Size = new System.Drawing.Size(98, 17);
            this.lblProductNameForAddProduct.TabIndex = 0;
            this.lblProductNameForAddProduct.Text = "Product Name";
            // 
            // lblCategoryForAddProduct
            // 
            this.lblCategoryForAddProduct.AutoSize = true;
            this.lblCategoryForAddProduct.Location = new System.Drawing.Point(13, 70);
            this.lblCategoryForAddProduct.Name = "lblCategoryForAddProduct";
            this.lblCategoryForAddProduct.Size = new System.Drawing.Size(65, 17);
            this.lblCategoryForAddProduct.TabIndex = 1;
            this.lblCategoryForAddProduct.Text = "Category";
            // 
            // lblUnitPriceForAddProduct
            // 
            this.lblUnitPriceForAddProduct.AutoSize = true;
            this.lblUnitPriceForAddProduct.Location = new System.Drawing.Point(13, 110);
            this.lblUnitPriceForAddProduct.Name = "lblUnitPriceForAddProduct";
            this.lblUnitPriceForAddProduct.Size = new System.Drawing.Size(69, 17);
            this.lblUnitPriceForAddProduct.TabIndex = 2;
            this.lblUnitPriceForAddProduct.Text = "Unit Price";
            // 
            // lblStockForAddProduct
            // 
            this.lblStockForAddProduct.AutoSize = true;
            this.lblStockForAddProduct.Location = new System.Drawing.Point(13, 153);
            this.lblStockForAddProduct.Name = "lblStockForAddProduct";
            this.lblStockForAddProduct.Size = new System.Drawing.Size(43, 17);
            this.lblStockForAddProduct.TabIndex = 3;
            this.lblStockForAddProduct.Text = "Stock";
            // 
            // lblQuantityPerUnitForAddProduct
            // 
            this.lblQuantityPerUnitForAddProduct.AutoSize = true;
            this.lblQuantityPerUnitForAddProduct.Location = new System.Drawing.Point(13, 200);
            this.lblQuantityPerUnitForAddProduct.Name = "lblQuantityPerUnitForAddProduct";
            this.lblQuantityPerUnitForAddProduct.Size = new System.Drawing.Size(116, 17);
            this.lblQuantityPerUnitForAddProduct.TabIndex = 4;
            this.lblQuantityPerUnitForAddProduct.Text = "Quantity Per Unit";
            // 
            // tbxProductNameForAddProduct
            // 
            this.tbxProductNameForAddProduct.Location = new System.Drawing.Point(135, 26);
            this.tbxProductNameForAddProduct.Name = "tbxProductNameForAddProduct";
            this.tbxProductNameForAddProduct.Size = new System.Drawing.Size(192, 22);
            this.tbxProductNameForAddProduct.TabIndex = 5;
            // 
            // tbxUnitPriceForAddProduct
            // 
            this.tbxUnitPriceForAddProduct.Location = new System.Drawing.Point(135, 105);
            this.tbxUnitPriceForAddProduct.Name = "tbxUnitPriceForAddProduct";
            this.tbxUnitPriceForAddProduct.Size = new System.Drawing.Size(192, 22);
            this.tbxUnitPriceForAddProduct.TabIndex = 6;
            // 
            // tbxStockForAddProduct
            // 
            this.tbxStockForAddProduct.Location = new System.Drawing.Point(135, 148);
            this.tbxStockForAddProduct.Name = "tbxStockForAddProduct";
            this.tbxStockForAddProduct.Size = new System.Drawing.Size(192, 22);
            this.tbxStockForAddProduct.TabIndex = 7;
            // 
            // tbxQuantityPerUnitForAddProduct
            // 
            this.tbxQuantityPerUnitForAddProduct.Location = new System.Drawing.Point(135, 197);
            this.tbxQuantityPerUnitForAddProduct.Name = "tbxQuantityPerUnitForAddProduct";
            this.tbxQuantityPerUnitForAddProduct.Size = new System.Drawing.Size(192, 22);
            this.tbxQuantityPerUnitForAddProduct.TabIndex = 8;
            // 
            // cbxCategoryForAddProduct
            // 
            this.cbxCategoryForAddProduct.FormattingEnabled = true;
            this.cbxCategoryForAddProduct.Location = new System.Drawing.Point(135, 63);
            this.cbxCategoryForAddProduct.Name = "cbxCategoryForAddProduct";
            this.cbxCategoryForAddProduct.Size = new System.Drawing.Size(192, 24);
            this.cbxCategoryForAddProduct.TabIndex = 9;
            // 
            // btnAddForAddProduct
            // 
            this.btnAddForAddProduct.Location = new System.Drawing.Point(54, 243);
            this.btnAddForAddProduct.Name = "btnAddForAddProduct";
            this.btnAddForAddProduct.Size = new System.Drawing.Size(238, 27);
            this.btnAddForAddProduct.TabIndex = 4;
            this.btnAddForAddProduct.Text = "Add Product";
            this.btnAddForAddProduct.UseVisualStyleBackColor = true;
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.btnUpdateForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.cbxCategoryForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.tbxQuantityPerUnitForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.tbxStockForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.tbxUnitPriceForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.tbxProductNameForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.lblQuantityPerUnitForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.lblStockForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.lblUnitPriceForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.lblCategoryForUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.lblProductNameForUpdateProduct);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(398, 516);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(357, 276);
            this.gbxUpdateProduct.TabIndex = 4;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Update Product";
            // 
            // btnUpdateForUpdateProduct
            // 
            this.btnUpdateForUpdateProduct.Location = new System.Drawing.Point(54, 243);
            this.btnUpdateForUpdateProduct.Name = "btnUpdateForUpdateProduct";
            this.btnUpdateForUpdateProduct.Size = new System.Drawing.Size(238, 27);
            this.btnUpdateForUpdateProduct.TabIndex = 4;
            this.btnUpdateForUpdateProduct.Text = "Update Product";
            this.btnUpdateForUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // cbxCategoryForUpdateProduct
            // 
            this.cbxCategoryForUpdateProduct.FormattingEnabled = true;
            this.cbxCategoryForUpdateProduct.Location = new System.Drawing.Point(135, 63);
            this.cbxCategoryForUpdateProduct.Name = "cbxCategoryForUpdateProduct";
            this.cbxCategoryForUpdateProduct.Size = new System.Drawing.Size(192, 24);
            this.cbxCategoryForUpdateProduct.TabIndex = 9;
            // 
            // tbxQuantityPerUnitForUpdateProduct
            // 
            this.tbxQuantityPerUnitForUpdateProduct.Location = new System.Drawing.Point(135, 197);
            this.tbxQuantityPerUnitForUpdateProduct.Name = "tbxQuantityPerUnitForUpdateProduct";
            this.tbxQuantityPerUnitForUpdateProduct.Size = new System.Drawing.Size(192, 22);
            this.tbxQuantityPerUnitForUpdateProduct.TabIndex = 8;
            // 
            // tbxStockForUpdateProduct
            // 
            this.tbxStockForUpdateProduct.Location = new System.Drawing.Point(135, 148);
            this.tbxStockForUpdateProduct.Name = "tbxStockForUpdateProduct";
            this.tbxStockForUpdateProduct.Size = new System.Drawing.Size(192, 22);
            this.tbxStockForUpdateProduct.TabIndex = 7;
            // 
            // tbxUnitPriceForUpdateProduct
            // 
            this.tbxUnitPriceForUpdateProduct.Location = new System.Drawing.Point(135, 105);
            this.tbxUnitPriceForUpdateProduct.Name = "tbxUnitPriceForUpdateProduct";
            this.tbxUnitPriceForUpdateProduct.Size = new System.Drawing.Size(192, 22);
            this.tbxUnitPriceForUpdateProduct.TabIndex = 6;
            // 
            // tbxProductNameForUpdateProduct
            // 
            this.tbxProductNameForUpdateProduct.Location = new System.Drawing.Point(135, 26);
            this.tbxProductNameForUpdateProduct.Name = "tbxProductNameForUpdateProduct";
            this.tbxProductNameForUpdateProduct.Size = new System.Drawing.Size(192, 22);
            this.tbxProductNameForUpdateProduct.TabIndex = 5;
            // 
            // lblQuantityPerUnitForUpdateProduct
            // 
            this.lblQuantityPerUnitForUpdateProduct.AutoSize = true;
            this.lblQuantityPerUnitForUpdateProduct.Location = new System.Drawing.Point(13, 200);
            this.lblQuantityPerUnitForUpdateProduct.Name = "lblQuantityPerUnitForUpdateProduct";
            this.lblQuantityPerUnitForUpdateProduct.Size = new System.Drawing.Size(116, 17);
            this.lblQuantityPerUnitForUpdateProduct.TabIndex = 4;
            this.lblQuantityPerUnitForUpdateProduct.Text = "Quantity Per Unit";
            // 
            // lblStockForUpdateProduct
            // 
            this.lblStockForUpdateProduct.AutoSize = true;
            this.lblStockForUpdateProduct.Location = new System.Drawing.Point(13, 153);
            this.lblStockForUpdateProduct.Name = "lblStockForUpdateProduct";
            this.lblStockForUpdateProduct.Size = new System.Drawing.Size(43, 17);
            this.lblStockForUpdateProduct.TabIndex = 3;
            this.lblStockForUpdateProduct.Text = "Stock";
            // 
            // lblUnitPriceForUpdateProduct
            // 
            this.lblUnitPriceForUpdateProduct.AutoSize = true;
            this.lblUnitPriceForUpdateProduct.Location = new System.Drawing.Point(13, 110);
            this.lblUnitPriceForUpdateProduct.Name = "lblUnitPriceForUpdateProduct";
            this.lblUnitPriceForUpdateProduct.Size = new System.Drawing.Size(69, 17);
            this.lblUnitPriceForUpdateProduct.TabIndex = 2;
            this.lblUnitPriceForUpdateProduct.Text = "Unit Price";
            // 
            // lblCategoryForUpdateProduct
            // 
            this.lblCategoryForUpdateProduct.AutoSize = true;
            this.lblCategoryForUpdateProduct.Location = new System.Drawing.Point(13, 70);
            this.lblCategoryForUpdateProduct.Name = "lblCategoryForUpdateProduct";
            this.lblCategoryForUpdateProduct.Size = new System.Drawing.Size(65, 17);
            this.lblCategoryForUpdateProduct.TabIndex = 1;
            this.lblCategoryForUpdateProduct.Text = "Category";
            // 
            // lblProductNameForUpdateProduct
            // 
            this.lblProductNameForUpdateProduct.AutoSize = true;
            this.lblProductNameForUpdateProduct.Location = new System.Drawing.Point(13, 31);
            this.lblProductNameForUpdateProduct.Name = "lblProductNameForUpdateProduct";
            this.lblProductNameForUpdateProduct.Size = new System.Drawing.Size(98, 17);
            this.lblProductNameForUpdateProduct.TabIndex = 0;
            this.lblProductNameForUpdateProduct.Text = "Product Name";
            // 
            // btnDeleteForDeleteProduct
            // 
            this.btnDeleteForDeleteProduct.Location = new System.Drawing.Point(849, 529);
            this.btnDeleteForDeleteProduct.Name = "btnDeleteForDeleteProduct";
            this.btnDeleteForDeleteProduct.Size = new System.Drawing.Size(193, 48);
            this.btnDeleteForDeleteProduct.TabIndex = 5;
            this.btnDeleteForDeleteProduct.Text = "Delete Selected Product";
            this.btnDeleteForDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 804);
            this.Controls.Add(this.btnDeleteForDeleteProduct);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategoryForSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox tbxProductForSearch;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.ComboBox cbxCategoryForAddProduct;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitForAddProduct;
        private System.Windows.Forms.TextBox tbxStockForAddProduct;
        private System.Windows.Forms.TextBox tbxUnitPriceForAddProduct;
        private System.Windows.Forms.TextBox tbxProductNameForAddProduct;
        private System.Windows.Forms.Label lblQuantityPerUnitForAddProduct;
        private System.Windows.Forms.Label lblStockForAddProduct;
        private System.Windows.Forms.Label lblUnitPriceForAddProduct;
        private System.Windows.Forms.Label lblCategoryForAddProduct;
        private System.Windows.Forms.Label lblProductNameForAddProduct;
        private System.Windows.Forms.Button btnAddForAddProduct;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.Button btnUpdateForUpdateProduct;
        private System.Windows.Forms.ComboBox cbxCategoryForUpdateProduct;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitForUpdateProduct;
        private System.Windows.Forms.TextBox tbxStockForUpdateProduct;
        private System.Windows.Forms.TextBox tbxUnitPriceForUpdateProduct;
        private System.Windows.Forms.TextBox tbxProductNameForUpdateProduct;
        private System.Windows.Forms.Label lblQuantityPerUnitForUpdateProduct;
        private System.Windows.Forms.Label lblStockForUpdateProduct;
        private System.Windows.Forms.Label lblUnitPriceForUpdateProduct;
        private System.Windows.Forms.Label lblCategoryForUpdateProduct;
        private System.Windows.Forms.Label lblProductNameForUpdateProduct;
        private System.Windows.Forms.Button btnDeleteForDeleteProduct;
    }
}

