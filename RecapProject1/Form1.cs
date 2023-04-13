using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ListProducts()
        {
            using (NortwindContext context = new NortwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        void ListCategories()
        {
            using (NortwindContext context = new NortwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           ListCategories();
           ListProducts();
        }
    }
}
