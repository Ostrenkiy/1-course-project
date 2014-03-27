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
        string[] symbols = { Char.ConvertFromUtf32(0x2070), Char.ConvertFromUtf32(0x00B9), Char.ConvertFromUtf32(0x00B2), Char.ConvertFromUtf32(0x00B3), Char.ConvertFromUtf32(0x2074), Char.ConvertFromUtf32(0x2075), Char.ConvertFromUtf32(0x2076), Char.ConvertFromUtf32(0x2077), Char.ConvertFromUtf32(0x2078), Char.ConvertFromUtf32(0x2079) };
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

        string MakeSuperscriptNumber(int x)
        {
            string xString = x.ToString();
            string res = "";
            for (int i = 0; i < xString.Length; i++)
            {
                res += symbols[Int32.Parse(xString[i]+"")];
            }
            return res;

        }

        bool EqualsNil(double x)
        {
            if (Math.Abs(x) < 0.000001)
                return true;
            else
                return false;
        }


        void InitializeLabel(Label lb, double[] coeff, int n)
        {
            lb.Text = String.Format("{0:F6}", coeff[0]);
            string format = "{0:F6}*x{1}";
            for (int i = 1; i < n; i++)
            {
                if(!EqualsNil(coeff[i]))
                    if (coeff[i] < 0)
                        lb.Text += " - " + String.Format(format, Math.Abs(coeff[i]), MakeSuperscriptNumber(i));
                    else
                        lb.Text += " + " + String.Format(format, coeff[i], MakeSuperscriptNumber(i));
            }
        }

        void InitializeWorst()
        {
            InitializeDataGrid(dataGridViewWorst, data.worst, data.n);
            InitializeLabel(labelWorst, data.coeffWorst, data.n);
        }

        void InitializeAverage()
        {
            InitializeDataGrid(dataGridViewAverage, data.average, data.n);
            InitializeLabel(labelAverage, data.coeffAverage, data.n);
        }

        void InitializeBest()
        {
            InitializeDataGrid(dataGridViewBest, data.best, data.n);
            InitializeLabel(labelBest, data.coeffBest, data.n);
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
