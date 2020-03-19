﻿using System;
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
        int state;

        private void Form1_Load(object sender, EventArgs e)
        {
            inputData = new List<object[]>();

            inputData.Add(new object[] { "Мука 1 сорта, кг", "0,5", "0,5", "0", "0" });
            inputData.Add(new object[] { "Мука 2 сорта, кг", "0", "0", "0,5", "0,5" });
            inputData.Add(new object[] { "Маргарин, кг", "0,125", "0", "0", "0,125" });
            inputData.Add(new object[] { "Яйцо, шт.", "2", "1", "1", "1" });
            inputData.Add(new object[] { "Прибыль, за 1 кг", "14", "12", "5", "6" });            

            SimplexMatrixes = new List<DataGridView>();

            DrawInitial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SimplexMatrixes.Clear();

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
                var table = DrawSimplexTable(matrix, 4, 4);
                this.SimplexMatrixes.Add(table);
            }

            AnswerLabel.Text = "Ответ: ";
            AnswerLabel.Text += simplex.Result.ToString();
            AnswerLabel.Visible = true;
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
            
            return table;
        }

        private DataGridView DrawSimplexTable<T>(T[,] data, int freeCount, int basisCount)
        {
            DataGridView table = new DataGridView();

            table.Columns.Add("b", "Res");

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

        private void DrawInitial()
        {
            var arr = MathExtend.ListTo2DArr(inputData);

            var table = this.DrawTable(arr);            

            addRowsFromSource(table, ref dataTable);
            dataTable.Visible = true;
        }

        private void DrawAnother(int index)
        {
            DataGridView source = SimplexMatrixes[index];
            this.state = index;
            dgvContainer.Controls.Clear();
            dgvContainer.Controls.Add(source);
            source.Dock = DockStyle.Fill;
            LabelState.Text = (index + 1).ToString();
        }

        private void ProcessDataMode_Click(object sender, EventArgs e)
        {
            var ob = (ToolStripMenuItem)sender;
            if (ob.Checked)
            {               

                inputDataMode.Checked = false;
                inputDataMode.Enabled = true;

                if (SimplexMatrixes.Count > 0)
                    DrawAnother(0);

                setVisibility(false);
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
                setVisibility(true);
            }

            ob.Enabled = false;
        }

        private void setVisibility(bool state)
        {
            dgvContainer.Visible = !state;
            dataTable.Visible = state;
            button1.Visible = state;
            label1.Visible = state;
            nextMatrix.Visible = !state;
            prevMatrix.Visible = !state;
            LabelState.Visible = !state;
        }

        private void nextMatrix_Click(object sender, EventArgs e)
        {
            if (SimplexMatrixes.Count > state + 1)
                DrawAnother(state + 1);
            else
                DrawAnother(0);
        }

        private void prevMatrix_Click(object sender, EventArgs e)
        {
            if (0 < state)
                DrawAnother(state - 1);
            else
                DrawAnother(SimplexMatrixes.Count - 1);
        }
    }
}
