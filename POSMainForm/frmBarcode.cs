using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace POSMainForm
{
    public partial class frmBarcode : Form
    {
        LinkedList<ListViewItem> selectedItems;
        public frmBarcode(LinkedList<ListViewItem> Items)
        {
            InitializeComponent();
            selectedItems = Items;
        }

        private void frmBarcode_Load(object sender, EventArgs e)
        {
            selectedProducts selectedProducts = new selectedProducts();

            DataTable t = selectedProducts.Tables.Add("product");
            t.Columns.Add("produtName", Type.GetType("System.String"));
            t.Columns.Add("productID", Type.GetType("System.String"));
            t.Columns.Add("productPrice", Type.GetType("System.String"));

            foreach (ListViewItem Item in selectedItems)
            {
                for (int i = 0; i < frmListProduct.barcodeNumber; i++)
                {
                    DataRow r;
                r = t.NewRow();
                r["produtName"] = Item.SubItems[2].Text;
                r["productID"] = Item.SubItems[3].Text;
                r["productPrice"] = Item.SubItems[5].Text;
                t.Rows.Add(r);
                

                }
                
            }
            
            test objRpt = new test();
            objRpt.SetDataSource(selectedProducts.Tables[1]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }

        private void test1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
