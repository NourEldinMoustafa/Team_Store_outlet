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
            ProductPictureBox.BackColor = Color.FromArgb(0, 0, 64);
            headlineLabel.Text = "الأصناف";

            ProductForm productForm = new ProductForm();
            productForm.TopLevel = false;
            FillPanel.Controls.Add(productForm);
            //MessageBox.Show($"{FillPanel.Size}");
            productForm.Size = FillPanel.Size;

            productForm.Location = new Point(0, 0);
            productForm.Show();

        }
        
        private void LogoutPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{this.Width} , {this.Height} ");

            
            this.Close();
        }
    }
}
