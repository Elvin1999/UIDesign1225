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
    public partial class ProductUC : UserControl
    {
        public string ProductName
        {
            get => nameLbl.Text;
            set
            {
                nameLbl.Text = value;
            }
        }

        public double Price
        {
            get => double.Parse(priceLbl.Text);
            set
            {
                priceLbl.Text=value.ToString();
            }
        }

        public Image ProductImage
        {
            get
            {
                return imageBox.Image;
            }
            set
            {
                imageBox.Image = value;
            }
        }
        public ProductUC()
        {
            InitializeComponent();
        }
    }
}
