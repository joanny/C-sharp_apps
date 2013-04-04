using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace autoEcoleVS2005
{
    public partial class Fm_Vehiculedispo : Form
    {
        public Fm_Vehiculedispo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart;
            DataTable dt = dataTable1TableAdapter1.GetData(date);
          
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dt.Rows[i][6].ToString());
            }   


        }
    }
}
