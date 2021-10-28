using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POSMainForm
{
    public partial class barcodePopup : Form
    {
        public barcodePopup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmListProduct.barcodeNumber = int.Parse(tbBarcodeNumber.Text);
            this.Close();
        }

        private void tbBarcodeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                TextBox TB = (TextBox)sender;
                int VisibleTime = 1000;  //in milliseconds

                ToolTip tt = new ToolTip();
                tt.Show("Only numbers are allowed", TB, 0, 0, VisibleTime);
            }
                
        }
    }
}
