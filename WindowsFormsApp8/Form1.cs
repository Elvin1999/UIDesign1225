using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        List<Product> products= new List<Product>();    
        HomeUC homeUC = new HomeUC();
        public Form1()
        {
            InitializeComponent();
            LoadHomeControl();
            LoadProducts();
        }
        private void LoadProducts()
        {
            products.Add(new Product
            {
                Name="Asus Rog Strix",
                Price=1723.60,
                Image=Properties.Resources.asus
            });

            products.Add(new Product
            {
                Name="Iphone 13 Pro Max",
                Price=2200,
                Image=Properties.Resources.iphone
            });

            products.Add(new Product
            {
                Name="Zenbook Pro Slim",
                Price=3200.56,
                Image=Properties.Resources.zenbook
            });

            products.Add(new Product
            {
                Name="Samsung S22",
                Price=1155.45,
                Image=Properties.Resources.samsung
            });
        }
        private void LoadProductControls()
        {
            containerPanel.Controls.Clear();

            int x = 20;
            int y = 20;
            foreach (var p in products)
            {
                var productUC = new ProductUC();
                productUC.Location = new Point(x, y);
                y += 120;

                productUC.ProductName = p.Name;
                productUC.Price = p.Price;
                productUC.ProductImage=p.Image;
                productUC.DoubleClick += ProductUC_DoubleClick;

                containerPanel.Controls.Add(productUC);
            }
        }

        private void ProductUC_DoubleClick(object sender, EventArgs e)
        {
            foreach (var item in containerPanel.Controls)
            {
                if(item is ProductUC c)
                {
                    c.BackColor = Color.SpringGreen;
                }
            }
            var uc = sender as ProductUC;
            uc.BackColor = Color.DeepSkyBlue;
        }

        private void LoadHomeControl()
        {
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(homeUC);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            LoadProductControls();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            LoadHomeControl();
        }
    }
}
