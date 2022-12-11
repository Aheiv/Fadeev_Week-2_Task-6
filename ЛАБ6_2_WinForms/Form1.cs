using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ6_2_WinForms
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        int n;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Array.DataSource = dt;
            Array.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void AddArray_Click(object sender, EventArgs e)
        {
            if (MasCountDown.Value <= 0)
            {
                MessageBox.Show("Некорректный ввод данных!");
            }
            else
            {
                n = int.Parse(MasCountDown.Text);
                AddArray.Enabled = false;
                label2.Visible = true;
                ElemCountDown.Visible = true;
                AddElementButton.Visible = true;
                dt.Rows.Add(dt.NewRow());
            }
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            if (i == n - 1)
            {
                label2.Text = "Массив заполнен";
                dt.Columns.Add(i.ToString(), typeof(int));
                dt.Rows[0][i] = ElemCountDown.Value;
                i++;
                AddElementButton.Visible = false;
            }
            else
            {
                dt.Columns.Add(i.ToString(), typeof(int));
                dt.Rows[0][i] = ElemCountDown.Value;
                i++;
                label2.Text = $"Элемент массива №{i}";
            }
        }

        private void FirstMaxButton_Click(object sender, EventArgs e)
        {
            int max = int.Parse(dt.Rows[0][0].ToString());
            for (int i = 1; i < n; ++i)
                if (int.Parse(dt.Rows[0][i].ToString()) > max) max = int.Parse(dt.Rows[0][i].ToString());
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (max == int.Parse(dt.Rows[0][i].ToString()))
                {
                    index = i;
                    break;
                }
                else continue;
            }
            FirstMaxBox.Text = index.ToString();
        }
    }
}
