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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_HospitalDataSet.Диагноз". При необходимости она может быть перемещена или удалена.
            this.диагнозTableAdapter.Fill(this.bD_HospitalDataSet.Диагноз);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_HospitalDataSet.Принятие_пациентов". При необходимости она может быть перемещена или удалена.
            this.принятие_пациентовTableAdapter.Fill(this.bD_HospitalDataSet.Принятие_пациентов);

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
           принятиеПациентовBindingSource.EndEdit();
           принятие_пациентовTableAdapter.Update(bD_HospitalDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
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
