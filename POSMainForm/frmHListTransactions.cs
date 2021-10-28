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
    public partial class frmHListTransactions : Form
    {
        public frmHListTransactions()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadInvoices(DateTime startDate, DateTime endDate)
        {

            try
            {
                SQLConn.sqL = "SELECT STR_TO_DATE(REPLACE(TDate, '-', '/'), '%m/%d/%Y') as TDate, InvoiceNo, CONCAT(lastname, ', ', firstname, ' ', MI) as StaffName, TotalAmount, Status FROM Transactions T INNER JOIN staff S ON T.StaffID = S.StaffID WHERE STR_TO_DATE(REPLACE(TDATE, '-', '/'), '%m/%d/%Y') BETWEEN '" + startDate.ToString("yyyy-MM-dd") + "' AND '" + endDate.ToString("yyyy-MM-dd") + "' AND InvoiceNo LIKE '%" + txtName.Text + "%' ORDER BY TDATE, InvoiceNo Desc";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                dgw.Rows.Clear();
                string status = "";
                while (SQLConn.dr.Read() == true)
                {
                    if (Convert.ToInt32(SQLConn.dr["Status"]) == 0)
                    {
                        status = "Hide";
                    }
                    else
                    {
                        status = "Unhide";
                    }
                    dgw.Rows.Add(status, Strings.Format(SQLConn.dr["TDate"], "MM/dd/yyyy"), SQLConn.dr["InvoiceNo"].ToString(), SQLConn.dr["StaffName"].ToString(), Strings.FormatNumber(SQLConn.dr["TotalAmount"]));
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


        private void UpdateInvoice(string InvoiceNo, int status)
        {

            try
            {
                SQLConn.sqL = "UPDATE Transactions SET Status = " + status + " WHERE InvoiceNo = " + InvoiceNo + "";
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


        private void LoadCompanySetting()
        {

            try
            {
                SQLConn.sqL = "SELECT HInvoice FROM Company";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

             
                if (SQLConn.dr.Read() == true)
                {
                    if (Convert.ToInt32(SQLConn.dr["HInvoice"]) == 1)
                    {
                        checkBox1.Checked = true;
                    }
                    else
                    {
                        checkBox1.Checked = false;
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

        private void UpdateCompany(int status)
        {

            try
            {
                SQLConn.sqL = "UPDATE Company SET HInvoice = " + status  ;
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


        private void frmHListTransactions_Load(object sender, EventArgs e)
        {
            LoadCompanySetting();
            LoadInvoices(dtStartDate.Value, dtEndDate.Value);
            
        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            LoadInvoices(dtStartDate.Value, dtEndDate.Value);
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            LoadInvoices(dtStartDate.Value, dtEndDate.Value);
        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                senderGrid.DefaultCellStyle.SelectionForeColor = Color.Red;

                if (senderGrid.CurrentRow.Cells[0].Value.ToString() == "Hide")
                {
                    dgw.CurrentRow.Cells[0].Value = "Unhide";
                    UpdateInvoice(dgw.CurrentRow.Cells[2].Value.ToString(), 1);
                    dgw.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                    dgw.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
                   
                }
                else
                {
                    dgw.CurrentRow.Cells[0].Value = "Hide";
                    UpdateInvoice(dgw.CurrentRow.Cells[2].Value.ToString(), 0);
                    dgw.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    dgw.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                  
                }
            }
        }

        private void dgw_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgw.Rows)
            {            
                if (Myrow.Cells[0].Value.ToString() == "Unhide")
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                    Myrow.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                UpdateCompany(1);
            }
            else
            {
                UpdateCompany(0);
            }
        }
    }
}
