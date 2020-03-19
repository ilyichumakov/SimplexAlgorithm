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

        private List<DataGridView> SimplexMatrixes;
        private List<object[]> inputData;

        private void Form1_Load(object sender, EventArgs e)
        {
            inputData = new List<object[]>();

            inputData.Add(new object[] { "Мука 1 сорта, кг", "0,5", "0,5", "0", "0" });
            inputData.Add(new object[] { "Мука 2 сорта, кг", "0", "0", "0,5", "0,5" });
            inputData.Add(new object[] { "Маргарин, кг", "0,125", "0", "0", "0,125" });
            inputData.Add(new object[] { "Яйцо, шт.", "2", "1", "1", "1" });
            inputData.Add(new object[] { "Прибыль, за 1 кг", "14", "12", "5", "6" });            

            SimplexMatrixes = new List<DataGridView>();
            var arr = MathExtend.ListTo2DArr(inputData);

            var table = this.DrawTable(arr);

            addRowsFromSource(table, ref dataTable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SimplexMatrixes.Clear();

            //double[,] data = {
            //    {0.5, 0.5, 0, 0, 1, 0, 0, 0, 290 },
            //    {0, 0, 0.5, 0.5, 0, 1, 0, 0, 150 },
            //    {0.125, 0, 0, 0.125, 0, 0, 1, 0, 50 },
            //    {2, 1, 1, 1, 0, 0, 0, 1, 1280 }
            //};

            double[,] data = {
                {cell(0,1), cell(0,2), cell(0,3), cell(0,4), 1, 0, 0, 0, 290 },
                {cell(1,1), cell(1,2), cell(1,3), cell(1,4), 0, 1, 0, 0, 150 },
                {cell(2,1), cell(2,2), cell(2,3), cell(2,4), 0, 0, 1, 0, 50 },
                {cell(3,1), cell(3,2), cell(3,3), cell(3,4), 0, 0, 0, 1, 1280 }
            };

            SimplexMatrix simplex = new SimplexMatrix(data, new double[]{0, 14, 12, 5, 6 });
            simplex.ProcessMatrix(4, 4);            

            foreach(double[,] matrix in simplex.Steps)
            {
                DrawSimplexTable(matrix, 4, 4);
            }          
        }

        private double cell(int i, int j)
        {
            return Double.Parse(dataTable.Rows[i].Cells[j].Value.ToString());
        }

        private DataGridView DrawTable<T>(T[,] data)
        {
            DataGridView table = new DataGridView();            

            for (int i = 0; i < data.GetUpperBound(0) + 1; i++) // z row, basis variables
            {
                table.Columns.Add("x" + (i + 1).ToString(), "x" + (i + 1).ToString());
            }            

            for (int i = 0; i < data.GetUpperBound(0) + 1; i++) // z row, basis variables
            {
                object[] row = new object[data.GetUpperBound(1) + 1];
                for (int j = 0; j < data.GetUpperBound(1) + 1; j++)
                {
                    row[j] = data[i, j];
                }
                table.Rows.Add(row);
            }

            //this.SimplexMatrixes.Add(table);
            return table;
        }

        private DataGridView DrawSimplexTable<T>(T[,] data, int freeCount, int basisCount)
        {
            DataGridView table = new DataGridView();

            table.Columns.Add("b", "b");

            for (int i = 0; i < basisCount + freeCount; i++) // z row, basis variables
            {
                table.Columns.Add("x" + (i + 1).ToString(), "x" + (i + 1).ToString());
            }

            table.Columns.Add("Sum", "Сумма");

            for (int i = 0; i < basisCount + 2; i++) // z row, basis variables
            {
                object[] row = new object[basisCount + freeCount + 2];
                for(int j = 0; j < basisCount + freeCount + 2; j++)
                {
                    row[j] = data[i, j];
                }
                table.Rows.Add(row);
            }

            //this.SimplexMatrixes.Add(table);
            return table;
        }

        private void addRowsFromSource(DataGridView source, ref DataGridView target)
        {
            foreach (DataGridViewRow row in source.Rows)
            {
                object[] nLine = new object[row.Cells.Count];
                int i = 0;
                foreach (DataGridViewCell c in row.Cells)
                {
                    nLine[i] = c.Value;
                    i++;
                }
                target.Rows.Add(nLine);
            }
        }

        private void RedrawTables(object sender, EventArgs e)
        {
            var ob = (ToolStripMenuItem)sender;
            if (ob.Checked)
            {
                inputDataMode.Checked = false;
                inputDataMode.Enabled = true;
            }

            ob.Enabled = false;
        }

        private void ProcessDataMode_Click(object sender, EventArgs e)
        {
            var ob = (ToolStripMenuItem)sender;
            if (ob.Checked)
            {
                inputDataMode.Checked = false;
                inputDataMode.Enabled = true;
            }

            ob.Enabled = false;
        }

        private void inputDataMode_Click(object sender, EventArgs e)
        {
            var ob = (ToolStripMenuItem)sender;
            if (ob.Checked)
            {
                ProcessDataMode.Checked = false;
                ProcessDataMode.Enabled = true;
            }

            ob.Enabled = false;
        }
    }
}
