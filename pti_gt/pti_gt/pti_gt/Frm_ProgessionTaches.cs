using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pti_gt
{
    public partial class Frm_ProgessionTaches : Form
    {
        private short? numAdmin;

        public Frm_ProgessionTaches()
        {
            InitializeComponent();
        }
        public Frm_ProgessionTaches(short? numAdmin)
        {
            InitializeComponent();
            this.numAdmin = numAdmin;
        }


        private void Frm_ProgessionTaches_Load(object sender, EventArgs e)
        {             
            DataTable dt = tachesTableAdapter1.GetDataByCodeAdmin(this.numAdmin);
            string mess = Convert.ToString("terminer");
            dataGridView1.Height = dt.Rows.Count * 50;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button b = new Button();                
                
                
                if ( Convert.ToInt32(dt.Rows[i][6].ToString()) < 100)
                {
                    b.Text = dt.Rows[i][5].ToString();
                    dataGridView1.Rows.Add(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),dt.Rows[i][3].ToString() , dt.Rows[i][4].ToString() , dt.Rows[i][6]   );
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows.
        }
    }
}
