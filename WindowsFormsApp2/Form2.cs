using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string
                A1 = textBox1.Text,
                A2 = textBox2.Text,
                A3 = textBox3.Text,
                A4 = textBox4.Text;
            this.адресаTableAdapter.InsertQuery(A1, A2, A3, A4);
            this.адресаTableAdapter.Fill(this.addressDataSet.Адреса);
        }


        private void адресаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.адресаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.addressDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "addressDataSet.Адреса". При необходимости она может быть перемещена или удалена.
            this.адресаTableAdapter.Fill(this.addressDataSet.Адреса);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
