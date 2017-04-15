using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Cat_and_Mouse
{
    public partial class Form2 : Form
    {
        public Form2(List<double> X, List<double> Y)
        {
            

            InitializeComponent();
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = X.Count;

            dataGridView1.Columns[0].HeaderText = "Поколение";
            dataGridView1.Columns[1].HeaderText = "Жертв";
            dataGridView1.Columns[2].HeaderText = "Хищников";

            for (int i = 0; i < X.Count; i++)
            {
                dataGridView1[0, i].Value = i;
                dataGridView1[1, i].Value = X[i];
                dataGridView1[2, i].Value = Y[i];
            }

           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
