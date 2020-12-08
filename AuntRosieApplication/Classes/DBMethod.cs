﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace AuntRosieApplication.Classes
{
    class DBMethod
    {

        public static string Reptype = null;
       public static ListItem selectedListItem = new ListItem();
       public  static  string[,] provincesArray = new string[,] {
                { "Newfoundland and Labrador","NL"},
{"Prince Edward Island", "PE" },
{"Nova Scotia","NS" },
{"New Brunswick","NB" },
{"Quebec","QC" },
{"Ontario", "ON" },
{"Manitoba","MB" },
{"Saskatchewan", "SK" },
{"Alberta","AB" },
{"British Columbia","BC" },
{ "Yukon", "YT" },
{"Northwest Territories","NT" },
{ "Nunavut","NU"}
            };

        /// <summary>
        /// Return connection string
        /// </summary>
        /// <returns>Connection string</returns>
        public static string GetConnectionString()
        {
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            return conStr;
        }


        public  static void  FillProvinces (ComboBox  cmb)
        {


             for (int i=0;i< 13; i++)
            {
                AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                itm.name = provincesArray[i,0];
                itm.id = provincesArray[i, 1];
                cmb.Items.Add((Object)itm);
            }


        }

        public static  void FillCombBox(DataTable dt, ComboBox cmb)

        {
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                    itm.name = row[1].ToString();
                    itm.id = row[0].ToString();
                    cmb.Items.Add((Object)itm);
                }
            }
        }

        public static void FillCombBoxPerson(DataTable dt, ComboBox cmb)

        {
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                    itm.name = row[1].ToString()+ " "+ row[2].ToString();
                    itm.id = row[0].ToString();
                    cmb.Items.Add((Object)itm);
                }
            }
        }

        public static String GetProvinceName(string provinceId)
        {

            
            for (int i = 0; i < 13; i++)
            {
                if (provincesArray[i, 1] == provinceId)
                    return provincesArray[i, 0];
            }
            return null;
        }


 public  static string GetSelectedItemID(ComboBox cmb )
        {
            if (cmb.SelectedIndex > -1)
            {
                AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                Object obj = cmb.Items[cmb.SelectedIndex];
                itm = (Classes.ListItem)obj;
                return itm.id;
            }
            return null;
        }

        public  static void relocation(Panel pnl, Form frm)
        {
            //relocation the login pannel 
            pnl.Left = (frm.Width - pnl.Width) / 2;
            pnl.Top = (frm.Height - pnl.Height) / 2;
        }

        public static void FillPaymentmethodCombo(ComboBox cmb)
        {
            AuntRosieApplication.Classes.ListItem itm1 = new AuntRosieApplication.Classes.ListItem();
            itm1.name = "Cash";
            itm1.id = "r";
            cmb.Items.Add((Object)itm1);
            AuntRosieApplication.Classes.ListItem itm2 = new AuntRosieApplication.Classes.ListItem();
            itm2.name = "Credit Card";
            itm2.id = "r";
            cmb.Items.Add((Object)itm2);
            AuntRosieApplication.Classes.ListItem itm3 = new AuntRosieApplication.Classes.ListItem();
            itm3.name = "Debit Card";
            itm3.id = "d";
            cmb.Items.Add((Object)itm3);


        }
    }
}
