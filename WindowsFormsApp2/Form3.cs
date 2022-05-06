using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string
                a1 = textBox2.Text,
                a2 = textBox3.Text,
                a3 = textBox4.Text,
                a4 = textBox5.Text;
            int Code = Convert.ToInt32(textBox1.Text);
            this.адресаTableAdapter.UpdateQuery(a1, a2, a3, a4, Code);



        }

        private void адресаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.адресаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.addressDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
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
