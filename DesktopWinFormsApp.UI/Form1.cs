using DesktopWinFormsApp.Business.Abstract;
using DesktopWinFormsApp.Business.DependencyResolvers.Ninject;
using DesktopWinFormsApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWinFormsApp.UI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();

            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }
        private void LoadCategories()
        {
            cbxCategoryForSearch.DataSource = _categoryService.GetAll();
            cbxCategoryForSearch.DisplayMember = "CategoryName";
            cbxCategoryForSearch.ValueMember = "CategoryId";

            cbxCategoryForAddProduct.DataSource = _categoryService.GetAll();
            cbxCategoryForAddProduct.DisplayMember = "CategoryName";
            cbxCategoryForAddProduct.ValueMember = "CategoryId";

            cbxCategoryForUpdateProduct.DataSource = _categoryService.GetAll();
            cbxCategoryForUpdateProduct.DisplayMember = "CategoryName";
            cbxCategoryForUpdateProduct.ValueMember = "CategoryId";
        }

        private void cbxCategoryForSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategoryForSearch.SelectedValue));
        }

        private void tbxProductForSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxProductForSearch.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductForSearch.Text, Convert.ToInt32(cbxCategoryForSearch.SelectedValue));
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnDeleteForDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                        CategoryId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[2].Value),
                        ProductName = Convert.ToString(dgwProduct.CurrentRow.Cells[1].Value),
                        QuantityPerUnit = Convert.ToString(dgwProduct.CurrentRow.Cells[4].Value),
                        UnitPrice = Convert.ToDecimal(dgwProduct.CurrentRow.Cells[3].Value),
                        UnitsInStock = Convert.ToInt16(dgwProduct.CurrentRow.Cells[5].Value)
                    });
                    LoadProducts();
                    MessageBox.Show("Product deleted!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnAddForAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = tbxProductNameForAddProduct.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryForAddProduct.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceForAddProduct.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockForAddProduct.Text),
                    QuantityPerUnit = tbxQuantityPerUnitForAddProduct.Text
                });
                LoadProducts();
                MessageBox.Show("New Product Added!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdateForUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cbxCategoryForUpdateProduct.SelectedValue),
                    ProductName = tbxProductNameForUpdateProduct.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceForUpdateProduct.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockForUpdateProduct.Text),
                    QuantityPerUnit = tbxQuantityPerUnitForUpdateProduct.Text
                });
                LoadProducts();
                MessageBox.Show("Product updated!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
