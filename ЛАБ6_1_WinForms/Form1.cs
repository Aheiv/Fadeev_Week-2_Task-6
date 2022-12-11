using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ6_1_WinForms
{
    public partial class Form1 : Form
    {

        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();

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
            OneArray.DataSource = dt1;
            OneArray.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TwoArray.DataSource = dt2;
            TwoArray.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MasCountBox.Value <= 0)
            {
                MessageBox.Show("Некорректный ввод данных");
            }
            else
            {
                n = int.Parse(MasCountBox.Text);
                button1.Enabled = false;
                label4.Visible = true;
                numericUpDown1.Visible = true;
                AddButton.Visible = true;
                dt1.Rows.Add(dt1.NewRow());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (j == n - 1)
            {
                label4.Text = "Массив заполнен";
                dt1.Columns.Add(j.ToString(), typeof(int));
                dt1.Rows[0][j] = numericUpDown1.Value;
                j++;
                AddButton.Visible = false; 
            }
            else
            {
                dt1.Columns.Add(j.ToString(), typeof(int));
                dt1.Rows[0][j] = numericUpDown1.Value;
                j++;
                label4.Text = $"Введите элемент массива №{j}";
            }
        }

        private void NewMasButton_Click(object sender, EventArgs e)
        {
            if (MasRowCountBox.Value <= 0 || MasColCountBox.Value <= 0)
            {
                MessageBox.Show("Некорректный ввод данных");
            }
            else
            {
                n = int.Parse(MasRowCountBox.Text);
                m = int.Parse(MasColCountBox.Text);
                NewMasButton.Enabled = false;
                label5.Visible = true;
                numericUpDown2.Visible = true;
                AddButton2.Visible = true;
                for (i = 0; i < n; i++) dt2.Rows.Add(dt2.NewRow());
                for (j = 0; j < m; j++) dt2.Columns.Add(j.ToString(), typeof(int));
                i = 0;
                j = 0;
            }
        }

        private void AddButton2_Click(object sender, EventArgs e)
        {

            if (j != n)
            {
                dt2.Rows[j][i] = numericUpDown2.Value;
                i++;
                if (i == m)
                {
                    j++;
                    i = 0;
                }
                label5.Text = $"Введите элемент массива [{j}][{i}]";
                if (j == n)
                {
                    label5.Text = "Массив заполнен";
                    AddButton2.Visible = false;
                }
            }
        }

        private void NineButton1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                int temp = int.Parse(dt1.Rows[0][i].ToString());
                if (temp % 9 == 0) sum += temp;
            }
            NineRes1.Text = sum.ToString();
            j = 0;
        }

        private void NineButton2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    int temp = int.Parse(dt2.Rows[i][j].ToString());
                    if (temp % 9 == 0) sum += temp;
                }
                NineRes2.Text = sum.ToString();
            }
            j = 0;
        }
    }
}
