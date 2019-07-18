using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_work_17_07_2019
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
        }

        private void LblProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Load Products 
           Product [] products =  ProductList.GetProducts();

            foreach (Product product in products)
            {
                lblProduct.Items.Add(product.Name);
            }
            //Load Categories

            Category[] categories = CategoryList.GetCategories();

            foreach (Category category in categories) 
            {
                cmvCategories.Items.Add(category.Name);
            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CmvCategories_TextChanged(object sender, EventArgs e)
        {
            Category[] categories = CategoryList.GetCategories();
            foreach (Category category in categories)
            {
                
                string testId = category.Id;
                MessageBox.Show(testId);

            }

            //Product[] products = ProductList.GetProducts();
            //foreach (Product product in products)
            //{
            //    //lblProduct.Items.RemoveAt(1);
            //    MessageBox.Show(product.CategoryId);    
            //}



            var slccategoriya = cmvCategories.GetItemText(cmvCategories.SelectedItem);

            //txtcate.Text = slccategoriya;

        }

        private void CmvCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category[] categories = CategoryList.GetCategories();
            foreach (Category category in categories)
            {

            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Txtcate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
