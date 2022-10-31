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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_HospitalDataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this.bD_HospitalDataSet.Специальность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_HospitalDataSet.Принятие_пациентов". При необходимости она может быть перемещена или удалена.
            this.принятие_пациентовTableAdapter.Fill(this.bD_HospitalDataSet.Принятие_пациентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_HospitalDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.bD_HospitalDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_HospitalDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.bD_HospitalDataSet.Персонал);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Выйти из программы ?", "Запрос",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question))
                Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            персоналBindingSource.EndEdit();
            персоналTableAdapter.Update(bD_HospitalDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}

