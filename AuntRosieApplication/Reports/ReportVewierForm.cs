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
        private ReportDataSetTableAdapters.LowStockTableAdapter aLowStockAdapter;
        private ReportDataSetTableAdapters.EmpEventTableAdapter aEmpEventAdapter;
        public ReportVewierForm()
        {
            InitializeComponent();
        }

        private void ReportVewierForm_Load(object sender, EventArgs e)
        {
            if (Classes.DBMethod.Reptype == "All-Stock")
            {
                LoadStockRep();
            }
            else if (Classes.DBMethod.Reptype == "Low-Stock")
            {
                LoadLowStockRep();

            }
            else if (Classes.DBMethod.Reptype == "Emp-Event")
            { LoadEmpEvent(); }
        }
        private void  LoadStockRep()
        {
            StockReport astockRep = new StockReport();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aStockAdapter = new ReportDataSetTableAdapters.StockReportTableAdapter();
                //Fill the dataset 
                //aStockAdapter.Adapter.SelectCommand = new System.Data.SqlClient.SqlCommand(AuntRosieApplication.Inventory.frmInventoryStock.reportSql);


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

        private void LoadLowStockRep()
        {
            LowStockRep aLowStockRep = new LowStockRep();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aLowStockAdapter = new ReportDataSetTableAdapters.LowStockTableAdapter();
                //Fill the dataset 
               // aStockAdapter.Adapter.SelectCommand = new System.Data.SqlClient.SqlCommand(AuntRosieApplication.Inventory.frmInventoryStock.reportSql);


                aLowStockAdapter.Fill(aDataSet.LowStock);
                //Assign the filled dataset as the data source for the report
                aLowStockRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aLowStockRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }


        }
        private void LoadEmpEvent()
        {

            EmpEventRep aEmpEventRep = new EmpEventRep();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aEmpEventAdapter = new ReportDataSetTableAdapters.EmpEventTableAdapter();
                //Fill the dataset 
                // aStockAdapter.Adapter.SelectCommand = new System.Data.SqlClient.SqlCommand(AuntRosieApplication.Inventory.frmInventoryStock.reportSql);


                aEmpEventAdapter.Fill(aDataSet.EmpEvent);
                //Assign the filled dataset as the data source for the report
                aEmpEventRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aEmpEventRep;



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
