using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ6_3_WinForms
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        int n;
        int m;
        int i = 0;
        int j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MasGridView.DataSource = dt;
            MasGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void AddMasButton_Click(object sender, EventArgs e)
        {
            if (MasRowCountBox.Value <= 0 || MasColCountBox.Value <= 0)
            {
                MessageBox.Show("Некорректный ввод данных");
            }
            else
            {
                n = int.Parse(MasRowCountBox.Text);
                m = int.Parse(MasColCountBox.Text);
                AddMasButton.Enabled = false;
                label3.Visible = true;
                numericUpDown3.Visible = true;
                AddElementButton.Visible = true;
                for (i = 0; i < n; i++) dt.Rows.Add(dt.NewRow());
                for (j = 0; j < m; j++) dt.Columns.Add(j.ToString(), typeof(int));
                i = 0;
                j = 0;
            }
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            if (i != n)
            {
                dt.Rows[i][j] = numericUpDown3.Value;
                j++;
                if (j == m)
                {
                    i++;
                    j = 0;
                }
                label3.Text = $"Элемент массива [{i}][{j}]";
                if (i == n)
                {
                    label3.Text = "Массив заполнен";
                    AddElementButton.Visible = false;
                    if (m % 2 == 0) FinalButton.Visible = true;
                    else label4.Visible = true;
                }
            }
        }

        private void FinalButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j += 2)
                {
                    int temp = int.Parse(dt.Rows[i][j].ToString());
                    dt.Rows[i][j] = dt.Rows[i] [j + 1];
                    dt.Rows[i] [j + 1] = temp;
                }
            }
        }
    }
}
