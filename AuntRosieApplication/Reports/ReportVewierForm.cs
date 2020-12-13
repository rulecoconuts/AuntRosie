using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuntRosieApplication.Classes;

namespace AuntRosieApplication
{
    public partial class ReportVewierForm : Form
    {
        private ReportDataSet aDataSet;
        //table adapter object
        private ReportDataSetTableAdapters.StockReportTableAdapter aStockAdapter;
        private ReportDataSetTableAdapters.LowStockTableAdapter aLowStockAdapter;
        private ReportDataSetTableAdapters.EmpEventTableAdapter aEmpEventAdapter;
        private ReportDataSetTableAdapters.ChangePriceTableAdapter aChangePriceAdapter;
        private ReportDataSetTableAdapters.saleDetTableAdapter aSaleDetAdapter;

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
            else if (Classes.DBMethod.Reptype == "Diff-Price")
            { LoadDiffPrice(); }

            else if (Classes.DBMethod.Reptype == "Bill")
            { 
               
                LoadBill(); }
        }

        private void LoadBill()
        {           
            BillRep billRep = new BillRep();
            try
            {
                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
               // aDataSet.Reset();
                aSaleDetAdapter = new ReportDataSetTableAdapters.saleDetTableAdapter();
                //Fill the dataset 
                MessageBox.Show(DBMethod.SaleID.ToString());
                try
                {
                   

                    aSaleDetAdapter.Fill(aDataSet.saleDet,  52);
                   
                }
                catch( Exception ex)
                {
                   // MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR3");

                }
                //Assign the filled dataset as the data source for the report
                billRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = billRep;
            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
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
        private void LoadDiffPrice()
        {

            ChanagepriceRep aChangePriceRep = new ChanagepriceRep();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aChangePriceAdapter = new ReportDataSetTableAdapters.ChangePriceTableAdapter();

                aChangePriceAdapter.Fill(aDataSet.ChangePrice);
                //Assign the filled dataset as the data source for the report
                aChangePriceRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aChangePriceRep;



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
