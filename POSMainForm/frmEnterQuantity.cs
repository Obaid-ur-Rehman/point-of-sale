using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POSMainForm
{
    public partial class frmEnterQuantity : Form
    {

        frmPOS POSForm;
        double ItemPrice;
        public frmEnterQuantity(frmPOS pos, double itemPrice)
        {
            InitializeComponent();
            POSForm = pos;
            ItemPrice = itemPrice;
        }

        private void txtAdminPassword_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void frmEnterQuantity_Load(object sender, EventArgs e)
        {

            lblItemPrice.Text = Strings.Format(ItemPrice, "#,##0.00");
            if (POSForm.isNewQuantity == true)
            {
                txtQuantity.Text = POSForm.oldItemQuantity.ToString();
            }
            else
            {
                txtQuantity.Text = "0";
            }
           
            txtQuantity.SelectAll();
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {

            double quantity = 0;
            if (Convert.ToDouble(txtQuantity.Text) <= 0)
            {
                quantity = 1;
            }
            else
            {
                quantity = Convert.ToDouble(txtQuantity.Text);
            }


            if (e.KeyCode == Keys.Enter)
            {
                if (POSForm.isNewQuantity == true)
                {
                    POSForm.NewItemQuantity = quantity;
                }
                else 
                {
                    POSForm.ItemQuantity = quantity;
                }
                this.Close();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtQuantity.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == ".")
            {
                txtQuantity.Text = "0.";
                txtQuantity.SelectionStart = txtQuantity.TextLength;

            }
            if (txtQuantity.Text == "")
            {
                lblTotalPrice.Text = "0.00";
                txtQuantity.Text = "0";
                txtQuantity.SelectAll();
            }
            else
            {
                lblTotalPrice.Text = Strings.Format(Convert.ToDouble(txtQuantity.Text) * ItemPrice, "#,##0.00").ToString();
                POSForm.txtQuantity.Text = txtQuantity.Text;
            }
        }

       
    }
}
