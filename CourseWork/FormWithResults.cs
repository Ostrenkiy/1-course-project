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
            dataGridViewWorst.RowCount = 2;
            dataGridViewWorst.ColumnCount = n;
            for(int i = 0; i < n; i++)
            {
                dgv.Rows[1].Cells[i].Value = p[i].x;
                dgv.Rows[2].Cells[i].Value = p[i].y;
            }
        }

        void InitializeWorst()
        {
            InitializeDataGrid(dataGridViewWorst, data.worst, data.n);
        }

        void InitializeAverage()
        {
        }

        void InitializeBest()
        {
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
    }
}
