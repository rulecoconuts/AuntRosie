using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuntRosieApplication
{
    public partial class ReportVewierForm : Form
    {
        private ReportDataSet aDataSet;
        //table adapter object
        private ReportDataSetTableAdapters.StockReportTableAdapter aStockAdapter;
        public ReportVewierForm()
        {
            InitializeComponent();
        }

        private void ReportVewierForm_Load(object sender, EventArgs e)
        {
            //Declare a report object for use at run time
            //Instantiate the report
            // empReprtrpt aStockReport = new empReprtrpt();
            StockReport astockRep = new StockReport();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aStockAdapter = new ReportDataSetTableAdapters.StockReportTableAdapter();
                //Fill the dataset 
                 aStockAdapter.Adapter.SelectCommand =  new System.Data.SqlClient.SqlCommand( AuntRosieApplication.Inventory.frmInventoryStock.reportSql);
         
                
                aStockAdapter.Fill(aDataSet.StockReport);
                //Assign the filled dataset as the data source for the report
                astockRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = astockRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }


        }

        private void crvReports_Load(object sender, EventArgs e)
        {

        }
    }
}
