using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using MySql.Data.MySqlClient;

namespace POSMainForm
{
    public partial class frmPOS : Form
    {

        bool isPasswordCorrect;
        bool isPasswordCancel;
        double itemQuantity;

       // double lastItemPrice;
        
        int StaffID;
        public frmPOS(int staffID)
        {
            InitializeComponent();
            StaffID = staffID;
        }

        public int productID;

        //Do not check for same names
        public bool clearInvoice;

        //----Basket Information
        double totalNumberOfItems;

        double totalAmountOfItems;
        //----Discount
        bool isDiscount;

        double discountPercent;
        //----Quantity
        public bool isNewQuantity;
        public double oldItemQuantity;

        double noOfItems;
        private void GetVAT()
        {
            try
            {
                SQLConn.sqL = "SELECT VatPercent FROm VatSetting";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                if (SQLConn.dr.Read() == true)
                {
                    lblVatPercent.Text = (Convert.ToDouble(SQLConn.dr[0]) / 100).ToString();
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

        public void GetInvoiceNo()
        {
            try
            {
                SQLConn.sqL = "SELECT InvoiceNo FROM Transactions ORDER BY InvoiceNO DESC";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    lblInvoice.Text = (Convert.ToInt32(SQLConn.dr["InvoiceNo"]) + 1).ToString();
                }
                else
                {
                    lblInvoice.Text = "100100000";
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


        public void GetProductInfo()
        {
            if (IsValidQuantity(noOfItems) == false)
            {
                Interaction.MsgBox("The number of quantity you have entered is greater than the number of Quantity On Hand", MsgBoxStyle.Exclamation, "Warning");
                return;
            }

            double discountAmount = 0;
            try
            {
                SQLConn.sqL = "SELECT ProductCode, Description, UnitPrice, ProductNo FROM Product WHERE  ProductNo = '" + productID + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    txtItemCode.Text = SQLConn.dr["ProductCOde"].ToString();
                    txtItemDesc.Text = SQLConn.dr["Description"].ToString();

                    //Validate Discount
                    if (isDiscount == true)
                    {
                        discountAmount = Conversion.Val(SQLConn.dr["UnitPrice"]) * (Conversion.Val(discountPercent) / 100);
                        txtPrice.Text = Strings.Format(Conversion.Val(SQLConn.dr["UnitPrice"]) - discountAmount, "#,##0.00");
                        txtPrice.Tag = Strings.Format(Conversion.Val(SQLConn.dr["UnitPrice"]), "#,##0.00");
                    }
                    else
                    {
                        txtPrice.Text = Strings.Format(SQLConn.dr["UnitPrice"], "#,##0.00");
                        txtPrice.Tag = Strings.Format(Conversion.Val(SQLConn.dr["UnitPrice"]), "#,##0.00");
                        discountAmount = 0;
                    }

                    //Validate Quantity
                    if (isNewQuantity == true)
                    {
                        txtQuantity.Text = noOfItems.ToString();
                    }
                    else
                    {
                        txtQuantity.Text = "1";
                    }

                    txtTotal.Text = Strings.Format(Conversion.Val(txtPrice.Text.Replace(",", "")) * Conversion.Val(txtQuantity.Text), "#,##0.00");
                    isNewQuantity = false;
                    frmEnterQuantity ep = new frmEnterQuantity(this, Convert.ToDouble(SQLConn.dr["UnitPrice"]));
                    ep.ShowDialog();

                    txtQuantity.Text = itemQuantity.ToString();
                    txtTotal.Text = Strings.Format(Conversion.Val(txtPrice.Text.Replace(",", "")) * Conversion.Val(txtQuantity.Text), "#,##0.00");
                 

                    //Adding Item to Gridview to Display
                    dgw.Rows.Add(SQLConn.dr["ProductNo"], SQLConn.dr["ProductCode"], SQLConn.dr["Description"], txtPrice.Tag, txtQuantity.Text, txtTotal.Text, Strings.Format(discountAmount * Conversion.Val(txtQuantity.Text), "#,##0.00"));

                    //Scroll to the last row.
                    this.dgw.FirstDisplayedScrollingRowIndex = this.dgw.RowCount - 1;
 
                    //'Select the last row.
                   // this.dgw.Rows[this.dgw.RowCount - 1].Selected = true;

                   // dgw.CurrentCell = dgw.Rows[this.dgw.RowCount -1].Cells[0];


                   //dgw.SelectedRows.Clear();
                    dgw.ClearSelection();
                   //dgw.Rows[this.dgw.RowCount - 1].Selected = true;

                  
                   
                  
                    //-Get Basket Info
                    BasketInformation();

                    //Clear text fields
                    txtBarcode.Clear();
                    txtItemCode.Clear();
                    txtItemDesc.Clear();
                    txtPrice.Text = "0.00";
                    txtTotal.Text = "0.00";
                    txtQuantity.Text = "1";

                    //Set Product ID
                    productID = 0;

                    //et Discount to Zero
                    discountPercent = 0;
                    isDiscount = false;

                    //Set Quantity to False
                    isNewQuantity = false;
                    noOfItems = 1;

                    //Set Focus back to barcode
                    txtBarcode.Focus();
                }
            }
            catch (Exception)
            {
                //Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void BasketInformation()
        {
            //Total number of Items
            totalNumberOfItems += Convert.ToDouble((txtQuantity.Text));
            lblTotalItems.Text = totalNumberOfItems.ToString();

            //Compute total Amount and Display
            totalAmountOfItems += Conversion.Val(txtTotal.Text.Replace(",", ""));
            lblTotalAmount.Text = Strings.Format(totalAmountOfItems, "#,##0.00");

            //Get Vat Amount and Display
            double vatAmount = 0;
            vatAmount = totalAmountOfItems * Conversion.Val(lblVatPercent.Text);
            lblVAT.Text = Strings.Format(vatAmount, "#,##0.00");

            //GET SubtotalAmount
            double subTotalAmount = 0;
            subTotalAmount = totalAmountOfItems - vatAmount;
            lblSubTotal.Text = Strings.Format(subTotalAmount, "#,##0.00");
        }

        public void NewTransaction()
        {
            txtItemCode.Text = "";
            txtItemDesc.Text = "";
            txtPrice.Text = "0.00";
            txtQuantity.Text = "1";
            txtTotal.Text = "0.00";

            totalAmountOfItems = 0;
            totalNumberOfItems = 0;

            lblTotalItems.Text = "0";
            lblVAT.Text = "0.00";
            lblSubTotal.Text = "0.00";
            lblTotalAmount.Text = "0.00";

            dgw.Rows.Clear();
            GetInvoiceNo();
            txtBarcode.Focus();
        }

        private bool IsValidQuantity(double EnteredQuantity)
        {
            bool ret = false;
            try
            {
                SQLConn.sqL = "SELECT * FROM PRODUCT WHERE StocksOnHand >= " + EnteredQuantity + "";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                if (SQLConn.dr.Read() == true)
                {
                    ret = true;
                }
                else
                {
                    ret = false;
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

        private void RemoveItem()
        {
            //-----------------DECREASE BASKETINFORMATION-------------------------'
            //Total number of Items
            totalNumberOfItems -= Convert.ToInt32(dgw.CurrentRow.Cells[4].Value);
            lblTotalItems.Text = totalNumberOfItems.ToString();

            //Compute total Amount and Display
            totalAmountOfItems -= Convert.ToDouble(dgw.CurrentRow.Cells[5].Value);
            lblTotalAmount.Text = Strings.Format(totalAmountOfItems, "#,##0.00");

            //Get Vat Amount and Display 
            double vatAmount = 0;
            vatAmount = totalAmountOfItems * Conversion.Val(lblVatPercent.Text);
            lblVAT.Text = Strings.Format(vatAmount, "#,##0.00");

            //GET SubtotalAmount
            double subTotalAmount = 0;
            subTotalAmount = totalAmountOfItems - vatAmount;
            lblSubTotal.Text = Strings.Format(subTotalAmount, "#,##0.00");


            dgw.Rows.Remove(dgw.SelectedRows[0]);
            txtBarcode.Focus();
        }

        public void AddTransaction()
        {
            try
            {
                SQLConn.sqL = "INSERT INTO Transactions(InvoiceNo, TDate, TTime, NonVatTotal, VatAmount, TotalAmount, StaffID) VALUES('" + lblInvoice.Text + "', '" + System.DateTime.Now.ToString("MM/dd/yyyy") + "', '" + System.DateTime.Now.ToString("hh:mm:ss") + "', '" + lblSubTotal.Text.Replace(",", "") + "', '" + lblVAT.Text.Replace(",", "") + "', '" + lblTotalAmount.Text + "', '" + lblStaffID.Text + "')";
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

        public void AddTransactionDetails()
        {
            try
            {
                SQLConn.sqL = "INSERT INTO TransactionDetails(InvoiceNo, ProductNo, ItemPrice, Quantity, Discount) VALUES(@InvoiceNo, @ProductNo, @ItemPrice, @Quantity, @Discount)";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.Parameters.Add("InvoiceNo", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                SQLConn.cmd.Parameters.Add("ProductNo", MySql.Data.MySqlClient.MySqlDbType.Int32);
                SQLConn.cmd.Parameters.Add("ItemPrice", MySql.Data.MySqlClient.MySqlDbType.Double);
                SQLConn.cmd.Parameters.Add("Quantity", MySql.Data.MySqlClient.MySqlDbType.Double);
                SQLConn.cmd.Parameters.Add("Discount", MySql.Data.MySqlClient.MySqlDbType.Double);

                for (int i = 0; i <= dgw.Rows.Count - 1; i++)
                {
                    SQLConn.cmd.Parameters["InvoiceNo"].Value = lblInvoice.Text;
                    SQLConn.cmd.Parameters["ProductNo"].Value = dgw.Rows[i].Cells[0].Value;
                    SQLConn.cmd.Parameters["ItemPrice"].Value = Convert.ToDouble(dgw.Rows[i].Cells[3].Value.ToString().Replace(",", ""));
                    SQLConn.cmd.Parameters["Quantity"].Value = Convert.ToDouble(dgw.Rows[i].Cells[4].Value);
                    SQLConn.cmd.Parameters["Discount"].Value = Convert.ToDouble(dgw.Rows[i].Cells[6].Value.ToString().Replace(",", ""));
                    SQLConn.cmd.ExecuteNonQuery();
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

        //Decrease product's stocks on hand
        public void UpdateProductQuantity()
        {
            try
            {
                SQLConn.sqL = "UPDATE Product SET StocksOnHand = StocksOnHand - @Quantity WHERE ProductNo = @ProductNo";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.Parameters.Add("ProductNo", MySql.Data.MySqlClient.MySqlDbType.Int32);
                SQLConn.cmd.Parameters.Add("Quantity", MySql.Data.MySqlClient.MySqlDbType.Double);

                for (int i = 0; i <= dgw.Rows.Count - 1; i++)
                {
                    SQLConn.cmd.Parameters["ProductNo"].Value = dgw.Rows[i].Cells[0].Value;
                    SQLConn.cmd.Parameters["Quantity"].Value = Convert.ToDouble(dgw.Rows[i].Cells[4].Value);
                    SQLConn.cmd.ExecuteNonQuery();
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

        private void EnterNewQuantity()
        {
            try
            {
              

                if (dgw.Rows.Count <= 0) {
                    Interaction.MsgBox("Please select item.",MsgBoxStyle.Exclamation, "Edit Quantity");
                    return;
                }

                isNewQuantity = true;
                //=============Get the last item entered when entering quantity==================//
                //add isSelected variable, this will verify if the user selected item in the datagridview to put new quantity
                //lastItemPrice =  Convert.ToDouble(dgw.Rows[dgw.Rows.Count -1].Cells[3].Value);
                //replace Convert.ToDouble(dgw.CurrentRow.Cells[3].Value in sending data to other form when applying this idea
                //=============END of Get the last item entered when entering quantity==================//
                oldItemQuantity = Convert.ToDouble(dgw.CurrentRow.Cells[4].Value);
                frmEnterQuantity ep = new frmEnterQuantity(this, Convert.ToDouble(dgw.CurrentRow.Cells[3].Value));
                ep.ShowDialog();

                //-----------------DECREASE BASKETINFORMATION-------------------------'
                //Total number of Items
                totalNumberOfItems -= oldItemQuantity;

                //Compute total Amount and Display
                totalAmountOfItems -= oldItemQuantity * Convert.ToDouble(dgw.CurrentRow.Cells[3].Value);

               
                //Total number of Items
                totalNumberOfItems += NewItemQuantity;
                lblTotalItems.Text = totalNumberOfItems.ToString();

                //Compute total Amount and Display
                totalAmountOfItems += (NewItemQuantity * Convert.ToDouble(dgw.CurrentRow.Cells[3].Value));
                lblTotalAmount.Text = Strings.Format(totalAmountOfItems, "#,##0.00");

                //Get Vat Amount and Display
                lblVAT.Text = Strings.Format(totalAmountOfItems * Conversion.Val(lblVatPercent.Text), "#,##0.00");

                //GET SubtotalAmount
                lblSubTotal.Text = Strings.Format(totalAmountOfItems - (totalAmountOfItems * Conversion.Val(lblVatPercent.Text)), "#,##0.00");


                dgw.CurrentRow.Cells[4].Value = NewItemQuantity;
                dgw.CurrentRow.Cells[5].Value = Strings.Format(NewItemQuantity * Convert.ToDouble(dgw.CurrentRow.Cells[3].Value), "#,##0.00");

                txtBarcode.Focus();
            }
            catch(Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {

            //if (My.MyProject.Forms.frmLogin.isCashier == true)
            //{
            //    My.MyProject.Forms.frmLogin.Show();
            //    My.MyProject.Forms.frmLogin.txtUsername.Text = "";

            //    My.MyProject.Forms.frmLogin.txtPassword.Text = "";
            //    My.MyProject.Forms.frmLogin.txtUsername.Focus();
            //    this.Close();
            //}

            this.Close();
        }

        private void frmPOS_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnNewTran.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnRemoveItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnSettlepayment.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnDiscount.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnQuantity.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnClose.PerformClick();
            }
            else if (e.KeyCode == Keys.F7)
            {
                btnRePrint.PerformClick();
            }
            else if (e.KeyCode == Keys.F8)
            {
                btnAddProduct.PerformClick();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                dgwInvoice.Rows.Clear();
                dgwInvoice.Visible = false;
            }
        }

        private void getStaffInfo()
        {
            try
            {
                SQLConn.sqL = "SELECT CONCAT(lastname, ', ', Firstname, ' ', MI) as StaffName, Role FROM Staff WHERE StaffID = '" + lblStaffID.Text + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    lblPosition.Text = SQLConn.dr["Role"].ToString();
                    lblCustName.Text = SQLConn.dr["Staffname"].ToString();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }

        }

        private void frmPOS_Load(System.Object sender, System.EventArgs e)
        {
            
            lblStaffID.Text = StaffID.ToString();
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            dgwInvoice.Visible = false;
            getStaffInfo();
            GetVAT();
            GetInvoiceNo();
            GetItemDescriptionForAutoComplete();
            //GetBarcodeForAutoComplete();
            GetBarcodeForAutoComplete();
            //GetBarcodeForAutoComplete();
            txtBarcode.Focus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lblPosition.Text.ToUpper() != "ADMIN")
            {
                if (Interaction.MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit POS") == MsgBoxResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text.ToUpper() == "NO BARCODE") 
            {
                return;
            }
            

            string input = txtBarcode.Text;
            int index = input.IndexOf(" ");
            if (index > 0)
            input = input.Substring(0, index);

            if (GetProductIDByBarcodeCount(input) > 1)
            {
                frmSameBarcodeItems sbi = new frmSameBarcodeItems(input, this);
                sbi.Show();
            }
            else
            {
                productID = GetProductIDByBarcode(input);
                GetProductInfo();
            }

           
        }

        private void btnNewTran_Click(object sender, EventArgs e)
        {
            NewTransaction();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgw.Rows.Count <= 0)
            {
                return;
            }
            
            RemoveItem();
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            EnterNewQuantity();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmEnterPassword ep = new frmEnterPassword(this);
            ep.ShowDialog();

            if (isPasswordCancel == true)
            {
                return;
            }

            if (isPasswordCorrect == false)
            {
                Interaction.MsgBox("Incorrect Password. Please try again.",MsgBoxStyle.Exclamation, "Admin Password");
                return;
            }

            try
            {
                isDiscount = true;
                discountPercent = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("ENTER PERCENT DISCOUNT : ", "Discount"));
                txtBarcode.Focus();
            }
            catch 
            {
                Interaction.MsgBox("Item(s) has " + discountPercent + " percent discount.", MsgBoxStyle.Exclamation, "Discount");
                txtBarcode.Focus();
            }
        }

        private void btnSettlepayment_Click(object sender, EventArgs e)
        {
            if (Conversion.Val(lblTotalAmount.Text.Replace(",", "")) < 1)
            {
                Interaction.MsgBox("No transaction to be paid.", MsgBoxStyle.Exclamation, "Payment");
                txtBarcode.Focus();
                return;
            }
            frmPayment p = new frmPayment(lblInvoice.Text, Convert.ToDouble(lblTotalAmount.Text.Replace(",","")));
            p.ShowDialog();
        }

        public void GetItemDescriptionForAutoComplete()
        {
            try
            {
                SQLConn.sqL = "SELECT Distinct CONCAT(TRIM(Description),'  => P', FORMAT(UnitPrice,2)) As Description  FROM Product Order By Description";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(SQLConn.cmd);
                da.Fill(ds, "list");
                
                var source = new List<string>();

                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    
                    source.Add(ds.Tables[0].Rows[i]["Description"].ToString());
                }
            
                this.txtItemDesc.AutoCompleteList = source;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }


        }
       

        public void GetBarcodeForAutoComplete()
        {
            try
            {
                SQLConn.sqL = "SELECT CONCAT(Barcode,' - ', TRIM(Description),'  => P', FORMAT(UnitPrice,2)) as Barcode FROM Product Order By Barcode";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(SQLConn.cmd);
                da.Fill(ds, "list");

                var source = new List<string>();

                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {

                    source.Add(ds.Tables[0].Rows[i]["Barcode"].ToString());
                }

                this.txtBarcode.AutoCompleteList = source;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }

        }

        private int GetProductIDByBarcodeCount(string barcode)
        {
            int ret = 0;

            try
            {
                SQLConn.sqL = "SELECT COUNT(*) totalProduct FROM Product WHERE barcode = '" + barcode + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    ret = Convert.ToInt32(SQLConn.dr[0]);
                }

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
            return ret;
        }

        private int GetProductIDByBarcode(string barcode)
        {
            int ret = 0;

            try
            {
                SQLConn.sqL = "SELECT ProductNo FROM Product WHERE barcode = '" + barcode + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    ret = Convert.ToInt32(SQLConn.dr[0]);
                }

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
            return ret;
        }


        public int GetProductID()
        {
            int ret = 0;

            string input = txtItemDesc.Text;
            int index = input.LastIndexOf("=");
            if (index > 0)
            input = input.Substring(0, (index-2));

          
            try
            {
                SQLConn.sqL = "SELECT ProductNo FROM Product WHERE Description = @Description";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.Parameters.AddWithValue("@Description", input);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    ret = Convert.ToInt32(SQLConn.dr[0]);
                }

            }
            catch (Exception ex)
             {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
            return ret;
        }

        private void txtItemDesc_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtItemDesc.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                dgw.Focus();
            }
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            dgwInvoice.Visible = true;

            try
            {
                SQLConn.sqL = "SELECT TDate, InvoiceNo FROM Transactions WHERE TDate = '" + DateTime.Now.ToString("MM/dd/yyyy") + "' ORDER BY InvoiceNo Desc";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                dgwInvoice.Rows.Clear();

                while(SQLConn.dr.Read()==true)
                {
                    dgwInvoice.Rows.Add(SQLConn.dr[0].ToString(), SQLConn.dr[1].ToString());
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void dgwInvoice_DoubleClick(object sender, EventArgs e)
        {
            
            string InvoiceNo = dgwInvoice.CurrentRow.Cells[1].Value.ToString();
            frmPrintReceipt rp = new frmPrintReceipt(InvoiceNo);
            rp.Show();

            dgwInvoice.Visible = false;
        }

        public bool IsPasswordCorrect
        {
            get { return isPasswordCorrect; }
            set { isPasswordCorrect = value; }
        }

        public bool IsPasswordCancel
        {
            get { return isPasswordCancel; }
            set { isPasswordCancel = value; }
        }

        public double ItemQuantity
        {
            get { return itemQuantity; }
            set { itemQuantity = value; }
        }

        public double NewItemQuantity
        {
            get { return itemQuantity; }
            set { itemQuantity = value; }
        }

    

        public void txtItemDesc_TextChanged(object sender, EventArgs e)
        {
            if(clearInvoice)
                productID = GetProductID();
                GetProductInfo();  
        }

        private void txtItemDesc_KeyDown_1(object sender, KeyEventArgs e)
        {
           
        }

        private void dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnterNewQuantity();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgw.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private string RefreshInvoiceNo()
        {
            string ret = "";
            try
            {
                string strSql = "SELECT InvoiceNo FROM Transactions ORDER BY InvoiceNO DESC";
                using (MySqlConnection conn = new MySqlConnection("Server = '" + SQLConn.ServerMySQL + "';  " + "Port = '" + SQLConn.PortMySQL + "'; " + "Database = '" + SQLConn.DBNameMySQL + "'; " + "user id = '" + SQLConn.UserNameMySQL + "'; " + "password = '" + SQLConn.PwdMySQL + "'"))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(strSql, conn))
                    {

                        SQLConn.dr = cmd.ExecuteReader();
                      
                        if (SQLConn.dr.Read() == true)
                        {
                            ret = (Convert.ToInt32(SQLConn.dr["InvoiceNo"]) + 1).ToString();
                        }
                        else
                        {
                            ret = "100100000";
                        }

                    }
                }            
            }
            catch (Exception)
            {}
            return ret;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProductQuick aeP = new frmAddProductQuick(this);
            aeP.ShowDialog();
        }

        public string ProductDescription
        {
            get { return txtItemDesc.Text; }
            set { txtItemDesc.Text = value; }
        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbClearInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if (!clearInvoice)
                clearInvoice = true;
            else
                clearInvoice = false;
        }
    }
}
