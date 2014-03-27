using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormWithResults : Form
    {
        TestingResults data;
        public FormWithResults(TestingResults tRes)
        {
            InitializeComponent();
            data = tRes;
            InitializeCases();
        }

        void InitializeDataGrid(DataGridView dgv, Points[] p, int n)
        {
            dgv.RowCount = 2;
            dgv.ColumnCount = n;
            dgv.Rows[0].HeaderCell.Value = "Длина теста";
            dgv.Rows[1].HeaderCell.Value = "Время работы";
            for(int i = 0; i < n; i++)
            {
                dgv.Rows[0].Cells[i].Value = p[i].x;
                dgv.Rows[1].Cells[i].Value = p[i].y;
            }
        }

        void InitializeWorst()
        {
            InitializeDataGrid(dataGridViewWorst, data.worst, data.n);
        }

        void InitializeAverage()
        {
            InitializeDataGrid(dataGridViewAverage, data.average, data.n);
        }

        void InitializeBest()
        {
            InitializeDataGrid(dataGridViewBest, data.best, data.n);
        }

        private void InitializeCases()
        {
            InitializeWorst();
            InitializeAverage();
            InitializeBest();
        }

        private void FormWithResults_Load(object sender, EventArgs e)
        {

        }

        private void tabPageWorst_Click(object sender, EventArgs e)
        {

        }
    }
}
