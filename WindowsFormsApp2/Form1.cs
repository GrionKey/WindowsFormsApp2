using System;
//using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Grion\\source\\repos\\WindowsFormsApp2\\Address.accdb";
        //private OleDbConnection myConnect;

        public Form1()
        {
            InitializeComponent();
            //myConnect = new OleDbConnection(connectionString);
            //myConnect.Open();
        }

        private void адресаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.адресаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.addressDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "addressDataSet.Адреса". При необходимости она может быть перемещена или удалена.
            this.адресаTableAdapter.Fill(this.addressDataSet.Адреса);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Now.ToString("F");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string City = textBox2.Text;
                this.адресаTableAdapter.FillBy(this.addressDataSet.Адреса, City);
            }
            catch { }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа учета адресов компаний v1.2" + "\n" +
                "Разработчик: Гришков К.А.", "Информация");
        }

        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)  //
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Code = Convert.ToInt32(textBox1.Text);                  // Сохранение значения в переменную
            this.адресаTableAdapter.DeleteQuery(Code);                  // Удаление строки
            this.адресаTableAdapter.Fill(this.addressDataSet.Адреса);   
            textBox1.Clear();       // Очищение пол
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //myConnect.Close();
        }

        private void сохранитьИВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.адресаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.addressDataSet);    // Сохранение

            Application.Exit();     // Выход
        }

        private void обновитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)  //
        {
            this.адресаTableAdapter.Fill(this.addressDataSet.Адреса);
        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Adress = textBox3.Text;
                this.адресаTableAdapter.FillBy1(this.addressDataSet.Адреса, Adress);
            }
            catch { }
        }
    }
}
