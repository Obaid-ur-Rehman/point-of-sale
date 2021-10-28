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
using System.Drawing.Printing;

namespace POSMainForm
{
    public partial class frmPrintReceipt : Form
    {
        string InvoiceNo;
        public frmPrintReceipt(string invoiceNo)
        {
            InitializeComponent();
            InvoiceNo = invoiceNo;
        }

        private void LoadItemstoDatagrid()
        {
            int y = 0;
            string description = null;
            try
            {

                SQLConn.sqL = "Select Quantity as TotalQuantity, Description, ItemPrice, ((ItemPrice * Quantity)-Discount) as Amount FROM Product as P, TransactionDetails as TD WHERE TD.ProductNo = P.ProductNo AND InvoiceNo ='" + InvoiceNo + "' ";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                dgw.Rows.Clear();
                while (SQLConn.dr.Read() == true)
                {
                    description = SQLConn.dr["Description"].ToString();
                    dgw.Rows.Add(System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(description.ToLower()), SQLConn.dr["TotalQuantity"], SQLConn.dr["ItemPrice"], SQLConn.dr["Amount"]);


                    if (description.Length >= 24)
                    {
                        dgw.Height += 57;
                        y += 57;
                    }
                    else if (description.Length >= 12)
                    {
                        dgw.Height += 38;
                        y += 38;
                    }
                    else
                    {
                        dgw.Height += 19;
                        y += 19;
                    }
                }
                Panel3.Location = new Point(9, 187 + (y - 20));
                Panel1.Height += y;
                this.Height += y;
                dgw.Height -= 17;
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

        private void LoadReceiptInfo()
        {

            try
            {

                SQLConn.sqL = "SELECT T.InvoiceNo, CONCAT(Lastname,', ', Firstname, ' ', MI, '.') as StaffName, Quantity, Description, ItemPrice, (ItemPRice * Quantity) as ItemAmount, VatAmount, NonVatTotal, TotalAmount, Cash, PChange FROM Product as P, TransactionDetails as TD, Transactions as T, Staff as S, Payment as Pay WHERE P.ProductNo = TD.ProductNo AND TD.InvoiceNo = T.InvoiceNo AND S.StaffID = T.StaffID AND Pay.InvoiceNo = T.InvoiceNO AND T.InvoiceNo = '" + InvoiceNo + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    lblInvoice.Text = SQLConn.dr["InvoiceNo"].ToString();
                    lblEmpName.Text = SQLConn.dr["StaffName"].ToString();
                    lblDate.Text = System.DateTime.Now.ToString("ddMMMyy") + " " + System.DateTime.Now.ToString("hh:mm tt");
                    lblVat.Text = Strings.FormatNumber(SQLConn.dr["VatAmount"]);
                    lblSubtotal.Text = Strings.FormatNumber(SQLConn.dr["NonVatTotal"]);
                    lblTotal.Text = Strings.FormatNumber(SQLConn.dr["TotalAmount"]);
                    lblCash.Text = Strings.FormatNumber(SQLConn.dr["Cash"]);
                    lblChange.Text = Strings.FormatNumber(SQLConn.dr["PChange"]);
                    LoadItemstoDatagrid();
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

        private void frmPrintReceipt_Load(object sender, EventArgs e)
        {
            dgw.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgw.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            GetCompanyInfo();
            LoadReceiptInfo();
            
            PrintDocument1.Print();
            this.Close();
        }

        private void PrintDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Bitmap bm = new Bitmap(this.Panel1.Width, this.Panel1.Height);
            Panel1.DrawToBitmap(bm, new Rectangle(0, 0, this.Panel1.Width, this.Panel1.Height));
            e.Graphics.DrawImage(bm, 3, 0);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            PageSetupDialog aPS = new PageSetupDialog();
            aPS.Document = PrintDocument1;
        }

        public void GetCompanyInfo()
        {
            try
            {
                SQLConn.sqL = "SELECT CompanyID, Name, Address, PhoneNo, TINNumber FROM Company";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read())
                {
                    lblTitle.Text = "C U S T O M E R  C O P Y" + Environment.NewLine + SQLConn.dr[1].ToString() + Environment.NewLine + SQLConn.dr[2] + Environment.NewLine + "Phone : " + SQLConn.dr[3] + Environment.NewLine + " TIN : " + SQLConn.dr[4] + " " + Environment.NewLine + "R E T A I L  I N V O I C E";

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
    }
}
