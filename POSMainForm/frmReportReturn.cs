using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;

namespace POSMainForm
{
    public partial class frmReportReturn : Form
    {
        DateTime StartDate;
        DateTime EndDate;

        public frmReportReturn(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            StartDate = startDate;
            EndDate = endDate;
        }

        private void frmReportReturn_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                SQLConn.sqL = "SELECT ReturnDate as DateReturn, SR.InvoiceNo, TotalAmount as AmountRefund, SUM(SRI.Quantity) as ItemQuantity, P.UnitPrice as ItemPrice, (SUM(SRI.Quantity) * P.UnitPrice) as ExtendedPrice, Description as Product, QtyTotal.TotQuantity as TotalItemReturn FROM SalesReturn as SR INNER JOIN SalesReturnItem SRI ON SR.InvoiceNo =SRI.InvoiceNo INNER JOIN Product P ON P.ProductNo = SRI.ProductID INNER JOIN (SELECT SUM(Quantity) as TotQuantity, InvoiceNo FROM SalesReturnItem GROUP BY InvoiceNo ) QtyTotal ON QtyTotal.InvoiceNo = SR.InvoiceNo WHERE ReturnDate BETWEEN '" + StartDate.ToString("yyyy-MM-dd") + "' AND '" + EndDate.ToString("yyyy-MM-dd") + "' GROUP BY P.ProductNo, SR.InvoiceNo ORDER By ReturnDate, SR.InvoiceNo";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.da = new MySqlDataAdapter(SQLConn.cmd);

                this.dsReportC.Return.Clear();
                SQLConn.da.Fill(this.dsReportC.Return);

                ReportParameter startDate = new ReportParameter("StartDate", StartDate.ToString());
                ReportParameter endDate = new ReportParameter("EndDate", EndDate.ToString());
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { startDate, endDate });

                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.ZoomPercent = 90;
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;

                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
        }
    }
}
