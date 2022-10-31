using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_HospitalDataSet.Пол". При необходимости она может быть перемещена или удалена.
            this.полTableAdapter.Fill(this.bD_HospitalDataSet.Пол);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_HospitalDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.bD_HospitalDataSet.Персонал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_HospitalDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_кадровTableAdapter.Fill(this.bD_HospitalDataSet.Отдел_кадров);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Выйти из программы ?", "Запрос",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question))
                Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            отделКадровBindingSource.EndEdit();
            отдел_кадровTableAdapter.Update(bD_HospitalDataSet);
        }
    }
}
