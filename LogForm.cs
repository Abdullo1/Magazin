using System;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Мagazine
{
    public partial class LogForm : MetroFramework.Forms.MetroForm
    {
        DB db = new DB();
        private string login = "";
        private string password = "";
        private string Gen_Way;
        private string Program_key;
        public LogForm()
        {
            InitializeComponent();
        }
        private void LogForm_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            metroTextBox1.Focus();
            Read_Keys();
        }
      

        void Read_Keys()
        {
            StreamReader Way_reader = new StreamReader("Config_way.txt");
            Gen_Way=Way_reader.ReadLine();
            Way_reader.Close();

            if(!string.IsNullOrEmpty(Gen_Way))
            {
                try
                {
                    StreamReader Key_reader = new StreamReader(Gen_Way);
                    Program_key = Key_reader.ReadLine();
                    login= Key_reader.ReadLine();
                    password= Key_reader.ReadLine();
                    Key_reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                }

            }

        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseConnection();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String Login = metroTextBox1.Text;
            String Password = metroTextBox2.Text;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [Personal] where [Login]=@Login AND [Password]=@Password", db.GetConnection());
            command.Parameters.AddWithValue("Login", SqlDbType.VarChar).Value = Login;
            command.Parameters.AddWithValue("Password", SqlDbType.VarChar).Value = Password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(!string.IsNullOrEmpty(Program_key))
            {
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    GeneralForm G_Form = new GeneralForm();
                    G_Form.ShowDialog();
                    this.Close();
                }
                else if (metroTextBox1.Text == login && metroTextBox2.Text == password)
                {
                    this.Hide();
                    Form_for_Admin form_for_admin = new Form_for_Admin();
                    form_for_admin.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Неправильный логин или пароль!");
            }
            else
            {
                if (MessageBox.Show("Отсутствует лицензия программы!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    this.Close();
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            db.CloseConnection();
            this.Close();
        }
    }
}
