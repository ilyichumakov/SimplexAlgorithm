using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Rows.Add(new object[] { "Мука 1 сорта, кг", "0,5", "0,5", "0", "0" });
            dataTable.Rows.Add(new object[] { "Мука 2 сорта, кг", "0", "0", "0,5", "0,5" });
            dataTable.Rows.Add(new object[] { "Маргарин, кг", "0,125", "0", "0", "0,125" });
            dataTable.Rows.Add(new object[] { "Яйцо, шт.", "2", "1", "1", "1" });
            dataTable.Rows.Add(new object[] { "Прибыль, за 1 кг", "14", "12", "5", "6" });
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            double[,] data = {
                {0.5, 0.5, 0, 0, 1, 0, 0, 0, 290 },
                {0, 0, 0.5, 0.5, 0, 1, 0, 0, 150 },
                {0.125, 0, 0, 0.125, 0, 0, 1, 0, 50 },
                {2, 1, 1, 1, 0, 0, 0, 1, 1280 }
            };
            SimplexMatrix simplex = new SimplexMatrix(data, new double[]{0, 14, 12, 5, 6 });
            simplex.ProcessMatrix(4, 4);
        }
    }
}
