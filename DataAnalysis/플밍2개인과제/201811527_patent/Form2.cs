using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201811527_patent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();

        
        public DataTable patenttable = new CSVManager("./개인과제data.csv").datatable;

        private void CheckedListBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void CheckedListBox1_Click_1(object sender, EventArgs e)
        {
            string item = checkedListBox1.SelectedItem.ToString();

            for (int i = 0; i < patenttable.Rows.Count; i++)
            {
                for (int j = 0; j < patenttable.Columns.Count; j++)
                {
                    if (item == patenttable.Rows[i][j].ToString())
                    {
                        textBox1.Text = patenttable.Rows[i][0].ToString();
                        textBox2.Text = patenttable.Rows[i][1].ToString();
                        textBox3.Text = patenttable.Rows[i][2].ToString();
                        textBox4.Text = patenttable.Rows[i][3].ToString();
                        textBox5.Text = patenttable.Rows[i][4].ToString();
                        textBox6.Text = patenttable.Rows[i][5].ToString();
                    }
                }
            }
        }
    }
}
