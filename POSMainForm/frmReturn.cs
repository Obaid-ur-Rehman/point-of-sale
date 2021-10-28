using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace POSMainForm
{
    public partial class frmReturn : Form
    {
        double totalItems;
        double vatTotal;
        double subTotal;
        double totalAmount;

        //----Basket Information
        double totalNumberOfItems;
        double totalAmountOfItems;

        double originalTotalAmount;
        double totalRefund;
        double preActionAmount;

        //----Quantity
        public bool isNewQuantity;
        public double oldItemQuantity;

        double itemQuantity;


        public frmReturn()
        {
            InitializeComponent();
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmListofTransactions lt = new frmListofTransactions(this);
            lt.ShowDialog();
        }

        private void LoadProducts(string invoiceNo) 
        {
            try
            {
                SQLConn.sqL = "SELECT TDetailNo, ProductCode, Description, ItemPrice, Quantity, Discount, (ItemPrice * Quantity) as ExtendedPrice, TD.ProductNo, VatAmount, NonVatTotal, TotalAmount, T.StaffID, CONCAT(Lastname, ', ', Firstname, ' ', MI) as Staffname FROM Transactions T INNER JOIN TransactionDetails TD ON T.InvoiceNo = TD.InvoiceNo INNER JOIN Product P ON P.ProductNo = TD.ProductNo INNER JOIN Staff S ON S.StaffID = T.StaffID WHERE T.InvoiceNo = '" + invoiceNo + "' ";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                dgw.Rows.Clear();
                double ctrItem = 0;
                if (SQLConn.dr.HasRows) 
                {
                    while (SQLConn.dr.Read() == true)
                    {
                        ctrItem = ctrItem + Convert.ToDouble(SQLConn.dr[4]);
                        totalAmountOfItems = totalAmountOfItems + Convert.ToDouble(SQLConn.dr[6]);
                        dgw.Rows.Add(SQLConn.dr[0].ToString(), SQLConn.dr[1].ToString(), SQLConn.dr[2].ToString(), SQLConn.dr[3].ToString(), SQLConn.dr[4].ToString(), SQLConn.dr[5].ToString(), SQLConn.dr[6].ToString(), SQLConn.dr[7].ToString(), "Return");
                    }

                    lblSubTotal.Text = SQLConn.dr[9].ToString();
                    lblVAT.Text = SQLConn.dr[8].ToString();
                    lblTotalAmount.Text = totalAmountOfItems.ToString();
                    lblTotalItems.Text = ctrItem.ToString();
                    lblUser.Tag = SQLConn.dr[11].ToString();
                    lblUser.Text = SQLConn.dr[12].ToString();
                    totalNumberOfItems = ctrItem;

                    originalTotalAmount = totalAmountOfItems;
                  
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void RemoveItem()
        {
            if ((dgw.Rows.Count <= 0))
            {
                Interaction.MsgBox("No items to remove.", MsgBoxStyle.Information, "Remove");
                return;
            }

            try
            {
                //totalItems = Convert.ToDouble(lblTotalItems.Text);
                //vatTotal = Convert.ToDouble(lblVAT.Text.Replace(",", ""));
                //subTotal = Convert.ToDouble(lblSubTotal.Text.Replace(",", ""));
                //totalAmount = Convert.ToDouble(lblTotalAmount.Text.Replace(",", ""));
                //totalItems = (totalItems - Convert.ToDouble(dgw.CurrentRow.Cells[4].Value));
                //vatTotal = (vatTotal -  (Convert.ToDouble(dgw.CurrentRow.Cells[6].Value) * GetVAT()));
                //subTotal = (subTotal - (Convert.ToDouble(dgw.CurrentRow.Cells[6].Value) -  (Convert.ToDouble(dgw.CurrentRow.Cells[6].Value) * GetVAT())));
                //totalAmount = (totalAmount - Convert.ToDouble(dgw.CurrentRow.Cells[6].Value));
                //lblTotalItems.Text = totalItems.ToString();
                //lblVAT.Text = Strings.FormatNumber(vatTotal);
                //lblSubTotal.Text = Strings.FormatNumber(subTotal);
                //lblTotalAmount.Text = Strings.FormatNumber(totalAmount).ToString();
               // dgw.Rows.Remove(dgw.SelectedRows[0]);

                lblTotalItems.Text = "0";
                lblVAT.Text = "0";
                lblSubTotal.Text = "0";
                totalAmount = (totalAmount - Convert.ToDouble(dgw.CurrentRow.Cells[6].Value));
                totalRefund +=  Convert.ToDouble(dgw.CurrentRow.Cells[6].Value);
                lblTotalAmount.Text = Strings.FormatNumber(totalRefund).ToString();
            }
            catch{}

        }

        private void UnRemoveItem()
        {
            if ((dgw.Rows.Count <= 0))
            {
                Interaction.MsgBox("No items to remove.", MsgBoxStyle.Information, "Remove");
                return;
            }

            try
            {
                //totalItems = Convert.ToDouble(lblTotalItems.Text);
                //vatTotal = Convert.ToDouble(lblVAT.Text.Replace(",", ""));
                //subTotal = Convert.ToDouble(lblSubTotal.Text.Replace(",", ""));
                //totalAmount = Convert.ToDouble(lblTotalAmount.Text.Replace(",", ""));
                //totalItems = (totalItems + Convert.ToDouble(dgw.CurrentRow.Cells[4].Value));
                //vatTotal = (vatTotal + (Convert.ToDouble(dgw.CurrentRow.Cells[6].Value) * GetVAT()));
                //subTotal = (subTotal + (Convert.ToDouble(dgw.CurrentRow.Cells[6].Value) + (Convert.ToDouble(dgw.CurrentRow.Cells[6].Value) * GetVAT())));
                //totalAmount = (totalAmount + Convert.ToDouble(dgw.CurrentRow.Cells[6].Value));
                //lblTotalItems.Text = totalItems.ToString();
                //lblVAT.Text = Strings.FormatNumber(vatTotal);
                //lblSubTotal.Text = Strings.FormatNumber(subTotal);
                //lblTotalAmount.Text = Strings.FormatNumber(totalAmount).ToString();
               // dgw.Rows.Remove(dgw.SelectedRows[0]);


                lblTotalItems.Text = "0";
                lblVAT.Text = "0";
                lblSubTotal.Text = "0";
                totalAmount = (totalAmount + Convert.ToDouble(dgw.CurrentRow.Cells[6].Value));
                totalRefund -= Convert.ToDouble(dgw.CurrentRow.Cells[6].Value);
                lblTotalAmount.Text = Strings.FormatNumber(totalRefund).ToString();
            }
            catch { }

        }

        private double GetVAT()
        {
            double ret = 0.0;
            try
            {

                SQLConn.sqL = "SELECT VatPercent FROM VATSetting";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if ((SQLConn.dr.Read() == true))
                {
                    ret = (Convert.ToDouble(SQLConn.dr[0]) / 100);
                }

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }

            return ret;
        }

        public void AddSalesReturn()
        {
            try
            {
                SQLConn.sqL = "INSERT INTO SalesReturn(InvoiceNo, ReturnDate, VatAmount, SubtotalAmount, TotalAmount, UserID) VALUES('" + txtInvoice.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + lblVAT.Text.Replace(",", "") + "', '" + lblSubTotal.Text.Replace(",", "") + "',  '" + lblTotalAmount.Text.Replace(",", "") + "', '" + lblUser.Tag + "')";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }

        }

        public void AddSalesReturnItems()
        {
            try
            {
                SQLConn.sqL = "INSERT INTO SalesReturnItem(InvoiceNo, ProductId, Quantity) VALUES(@InvoiceNo, @ProductId, @Quantity)";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.Parameters.Add("InvoiceNo", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                SQLConn.cmd.Parameters.Add("ProductId", MySql.Data.MySqlClient.MySqlDbType.Int32);
                SQLConn.cmd.Parameters.Add("Quantity", MySql.Data.MySqlClient.MySqlDbType.Double);
                for (int i = 0; (i<= (dgw.Rows.Count - 1)); i++)
                {
                    if (dgw.Rows[i].Cells[8].Value.ToString() == "Unreturn")
                    {
                        SQLConn.cmd.Parameters["InvoiceNo"].Value = txtInvoice.Text;
                        SQLConn.cmd.Parameters["ProductId"].Value = dgw.Rows[i].Cells[7].Value;
                        SQLConn.cmd.Parameters["Quantity"].Value = dgw.Rows[i].Cells[4].Value;
                        SQLConn.cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }

        }
        public void UpdateSales()
        {
            try
            {
                SQLConn.sqL = "UPDATE Transactions SET VatAmount = VatAmount - " + Convert.ToDouble(lblVAT.Text.Replace(",", "")) + ", NonVatTotal = NonVatTotal - " + Convert.ToDouble(lblSubTotal.Text.Replace(",", "")) + ", TotalAmount = TotalAmount - " + Convert.ToDouble(lblTotalAmount.Text.Replace(",", "")) + " WHERE InvoiceNo = '" + lblInvoice.Text + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }

        }

        public void UpdateProductQuantity()
        {
            try
            {
                SQLConn.sqL = "UPDATE Product SET StocksOnHand = StocksOnHand + @Quantity WHERE ProductNo = @ProductNo";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.Parameters.Add("ProductNo", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                SQLConn.cmd.Parameters.Add("Quantity", MySql.Data.MySqlClient.MySqlDbType.Double);
                for (int i = 0; (i<= (dgw.Rows.Count - 1)); i++)
                {
                    if (dgw.Rows[i].Cells[8].Value.ToString() == "Unreturn")
                    {
                        SQLConn.cmd.Parameters["ProductNo"].Value = dgw.Rows[i].Cells[7].Value;
                        SQLConn.cmd.Parameters["Quantity"].Value = Convert.ToDouble(dgw.Rows[i].Cells[4].Value);
                        SQLConn.cmd.ExecuteNonQuery();
                    }
                   
                }

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }

        }

        public void UPDATESalesItems()
        {
            try
            {
                SQLConn.sqL = "UPDATE TransactionDetails SET Quantity = Quantity -  @Quantity WHERE TDetailNo = @TDetailNo";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.Parameters.Add("TDetailNo", MySql.Data.MySqlClient.MySqlDbType.Int32);
                SQLConn.cmd.Parameters.Add("Quantity", MySql.Data.MySqlClient.MySqlDbType.Double);
                for (int i = 0; (i<= (dgw.Rows.Count - 1)); i++)
                {
                    if (dgw.Rows[i].Cells[8].Value.ToString() == "Unreturn")
                    {
                        SQLConn.cmd.Parameters["TDetailNo"].Value = dgw.Rows[i].Cells[0].Value;
                        SQLConn.cmd.Parameters["Quantity"].Value = dgw.Rows[i].Cells[4].Value;
                        SQLConn.cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }

        }

        private bool hasReturned()
        {
            bool ret = false;
            try
            {
                SQLConn.sqL = ("SELECT * FROM SalesReturn WHERE InvoiceNo = '"+ (txtInvoice.Text + "'"));
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                if ((SQLConn.dr.Read() == true))
                {
                    ret = true;
                }

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }

            return ret;
        }

        private void EnterNewQuantity()
        {
            try
            {


                if (dgw.Rows.Count <= 0)
                {
                    Interaction.MsgBox("Please select item.", MsgBoxStyle.Exclamation, "Edit Quantity");
                    return;
                }

                isNewQuantity = true;

                oldItemQuantity = Convert.ToDouble(dgw.CurrentRow.Cells[4].Value);
                frmQuantityReturn ep = new frmQuantityReturn(this, Convert.ToDouble(dgw.CurrentRow.Cells[3].Value));
                ep.ShowDialog();

                if (NewItemQuantity <= 0)
                {
                    return;
                }

                //-----------------DECREASE BASKETINFORMATION-------------------------'
                //Total number of Items
                totalNumberOfItems -= oldItemQuantity;

                //Compute total Amount and Display
                totalAmountOfItems -= oldItemQuantity * Convert.ToDouble(dgw.CurrentRow.Cells[3].Value);


                ////Total number of Items
                //totalNumberOfItems += NewItemQuantity;
                //lblTotalItems.Text = totalNumberOfItems.ToString();

                ////Compute total Amount and Display
                //totalAmountOfItems += (NewItemQuantity * Convert.ToDouble(dgw.CurrentRow.Cells[3].Value));
                //lblTotalAmount.Text = Strings.Format(totalAmountOfItems, "#,##0.00");

                ////Get Vat Amount and Display
                //lblVAT.Text = Strings.Format(totalAmountOfItems * GetVAT(), "#,##0.00");

                ////GET SubtotalAmount
                //lblSubTotal.Text = Strings.Format(totalAmountOfItems - (totalAmountOfItems * GetVAT()), "#,##0.00");


                dgw.CurrentRow.Cells[4].Value = NewItemQuantity;
                dgw.CurrentRow.Cells[6].Value = Strings.Format(NewItemQuantity * Convert.ToDouble(dgw.CurrentRow.Cells[3].Value), "#,##0.00");

                lblTotalItems.Text = "0";
                lblVAT.Text = "0";
                lblSubTotal.Text = "0";

                if (oldItemQuantity != NewItemQuantity)
                {
                    if (preActionAmount != 0) 
                    {
                        totalRefund -= preActionAmount;
                    }

                    preActionAmount = Convert.ToDouble(dgw.CurrentRow.Cells[6].Value);

                    totalAmount = (totalAmount - Convert.ToDouble(NewItemQuantity * Convert.ToDouble(dgw.CurrentRow.Cells[3].Value)));
                    totalRefund += Convert.ToDouble(dgw.CurrentRow.Cells[6].Value);
                    lblTotalAmount.Text = Strings.FormatNumber(totalRefund).ToString();
                }
                else
                {
                    totalAmount = (totalAmount + Convert.ToDouble(NewItemQuantity * Convert.ToDouble(dgw.CurrentRow.Cells[3].Value)));
                    //totalRefund -= Convert.ToDouble(dgw.CurrentRow.Cells[6].Value);
                    lblTotalAmount.Text = Strings.FormatNumber(totalRefund).ToString();
                }

                dgw.CurrentRow.Cells[8].Value = "Unreturn";
                dgw.CurrentRow.DefaultCellStyle.BackColor = Color.Teal;
                dgw.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Teal;
                dgw.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;

                
               

              
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
        }

        private void ClearFields()
        {
            txtInvoice.Text = "";
            lblUser.Text = "";
            lblTotalItems.Text = "";
            lblVAT.Text = "";
            lblSubTotal.Text = "";
            lblTotalAmount.Text = "";
            dgw.Rows.Clear();
        }


        public string InvoiceNo
        {
            get { return txtInvoice.Text; }
            set { txtInvoice.Text = value; }
        }

        public double NewItemQuantity
        {
            get { return itemQuantity; }
            set { itemQuantity = value; }
        }

        public double ItemQuantity
        {
            get { return itemQuantity; }
            set { itemQuantity = value; }
        }

        private void txtInvoice_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtInvoice.Text);
        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void btnNewTran_Click(object sender, EventArgs e)
        {
            if ((hasReturned() == true))
            {
                Interaction.MsgBox("This Invoice has already returned. You cannot return twice!", MsgBoxStyle.Exclamation, "Sales Return");
                return;
            }

            if (totalRefund <= 0) 
            {
                Interaction.MsgBox("No item(s) selected.", MsgBoxStyle.Exclamation, "Sales Return");
                return;
            }

            AddSalesReturn();
            AddSalesReturnItems();
            UpdateSales();
            UPDATESalesItems();
            UpdateProductQuantity();

            Interaction.MsgBox("Return successfully", MsgBoxStyle.Information, "Return Items");
            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterNewQuantity();
        }

        private void frmReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete))
            {
                RemoveItem();
            }

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                senderGrid.DefaultCellStyle.SelectionForeColor = Color.Red;

                if (senderGrid.CurrentRow.Cells[8].Value.ToString() == "Return")
                {
                    dgw.CurrentRow.Cells[8].Value = "Unreturn";
                    senderGrid.CurrentRow.DefaultCellStyle.BackColor = Color.Teal;
                    dgw.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Teal;
                    dgw.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
                    RemoveItem();
                }
                else 
                {
                    dgw.CurrentRow.Cells[8].Value = "Return";
                    senderGrid.CurrentRow.DefaultCellStyle.BackColor = DefaultBackColor;
                    dgw.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.SandyBrown;
                    dgw.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
                    UnRemoveItem();
                }

                if (originalTotalAmount != totalAmount)
                {
                    lblTotal.Text = "Refund Amount:";
                }
                else
                {
                    lblTotal.Text = "Total Amount:";
                    lblTotalAmount.Text = originalTotalAmount.ToString();
                }
               
            }

        }

        private void dgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgw.CurrentRow.Cells[8].Value.ToString() == "Unreturn")
            {
                dgw.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Teal;
                dgw.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
            else
            {
                dgw.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.SandyBrown;
                dgw.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
