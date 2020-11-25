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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCombBox();
            String DatabasePath = Application.StartupPath;
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0,x-1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            MessageBox.Show(conStr);
        }

        private void FillCombBox()

        {
            
            AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
            itm.name = "mervat";
            itm.id = "1";
            comboBox1.Items.Add((Object)itm);
            itm = new AuntRosieApplication.Classes.ListItem();
            itm.name = "Emad";
            itm.id = "10";
            comboBox1.Items.Add((Object)itm);
            itm = new AuntRosieApplication.Classes.ListItem();
            itm.name = "mahmoud";
            itm.id = "30";
            comboBox1.Items.Add((Object)itm);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
           
             Object obj = comboBox1.Items[comboBox1.SelectedIndex];

             itm = (AuntRosieApplication.Classes.ListItem)obj;

           MessageBox.Show(itm.id + ", " + itm.name);
           // MessageBox.Show(comboBox1.Items[comboBox1.SelectedIndex].ToString());
        }
       

    private void button1_Click(object sender, EventArgs e)
    {

            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                            "Index: " + selectedIndex.ToString());
        }  
    }
}
