using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void ProductPanel_Click(object sender, EventArgs e)
        {
            ProductPanel.BackColor = Color.White;
            ProductLabel.ForeColor =  Color.FromArgb(0, 0, 64);
            ProductpictureBox.BackColor = Color.FromArgb(0, 0, 64);

            ProductForm productForm = new ProductForm();
            productForm.TopLevel = false;
            FillPanel.Controls.Add(productForm);

            productForm.Size = FillPanel.Size;
            productForm.Location = new Point(0, 0);
            productForm.Show();

        }

      
    }
}
