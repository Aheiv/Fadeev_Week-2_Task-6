using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ6_4_WinForms
{
    public partial class Form1 : Form
    {
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();

        int n;
        int i = 0;
        int j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OldMas.DataSource = dt1;
            OldMas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            NewMas.DataSource = dt2;
            NewMas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            if (Add1.Value <= 0)
            {
                MessageBox.Show("Некорректный ввод данных");
            }
            else
            {
                n = int.Parse(Add1.Text);
                FirstButton.Enabled = false;
                label2.Visible = true;
                Add2.Visible = true;
                SecondButton.Visible = true;
                for (i = 0; i < n; i++) dt1.Rows.Add(dt1.NewRow());
                for (j = 0; j < n; j++) dt1.Columns.Add(j.ToString(), typeof(int));
                dt2.Rows.Add(dt2.NewRow());
                for (j = 0; j < n; j++) dt2.Columns.Add(j.ToString(), typeof(string));
                i = 0;
                j = 0;
            }
        }

        private void SecondButton_Click(object sender, EventArgs e)
        {
            if (i != n)
            {
                dt1.Rows[i][j] = Add2.Value;
                j++;
                if (j == n)
                {
                    i++;
                    j = 0;
                }
                label2.Text = $"Элемент массива [{i}][{j}]";

                if (i == n)
                {
                    label2.Text = "Массив заполнен";
                    SecondButton.Visible = false;
                    for (int j = 0; j < n; j++)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (int.Parse(dt1.Rows[i][j].ToString()) > 0)
                            {
                                dt2.Rows[0][j] = dt1.Rows[i][j].ToString();
                                break;
                            }
                            else if (int.Parse(dt1.Rows[i][j].ToString()) < 0)
                            {
                                dt2.Rows[0][j] = "Отсутствуют";
                            }
                        }
                    }
                }
            }
        }
    }
}
