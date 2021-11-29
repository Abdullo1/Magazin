using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мagazine
{
    public partial class Form_for_Admin : MetroFramework.Forms.MetroForm
    {
        public Form_for_Admin()
        {
            InitializeComponent();
        }

        DB db = new DB();
        private void Form_for_Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "local_Db_DS.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.local_Db_DS.Personal);
            Edit(false);
            Save_p.Enabled = false;
        }

        private void btn_open_GenForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralForm G_Form = new GeneralForm();
            G_Form.ShowDialog();
            this.Close();
        }

        private void Edit(bool value)
        {
            Surname_p.Enabled = value;
            Name_p.Enabled = value;
            Tel_num_personal.Enabled = value;
            Company.Enabled = value;
            Id_company.Enabled = value;
            Login.Enabled = value;
            Password.Enabled = value;
        } 

        private void New_p_Click(object sender, EventArgs e)
        {
            Edit(true);
            local_Db_DS.Personal.AddPersonalRow(local_Db_DS.Personal.NewPersonalRow());
            personalBindingSource.MoveLast();
            Surname_p.Focus();
            New_p.Enabled = false;
            Save_p.Enabled = true;
        }

        private void Save_p_Click(object sender, EventArgs e)
        {
            try
            {
                personalBindingSource.EndEdit();
                personalTableAdapter.Update(local_Db_DS.Personal);
                Personal_grid.Refresh();
                local_Db_DS.AcceptChanges();
                MessageBox.Show("Сохранено!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Edit(false);
                New_p.Enabled = true;
                Save_p.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                New_p.Enabled = true;
                Save_p.Enabled = false;
            }
        }

        private void Edit_p_Click(object sender, EventArgs e)
        {
            Edit(true);
            Surname_p.Focus();
            Save_p.Enabled = true;
            New_p.Enabled = false;
        }

        private void Delete_p_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотитете удалить эту запись?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Personal_grid.SelectedRows.Count != 0 && ID.Text != "")
                    {
                        db.OpenConnection();
                        SqlCommand command = new SqlCommand("DELETE FROM [Personal] WHERE [Id_personal]=@Id_P", db.GetConnection());
                        command.Parameters.AddWithValue("@Id_P", ID.Text);
                        command.ExecuteNonQuery();
                        db.CloseConnection();

                        personalBindingSource.RemoveCurrent();
                        local_Db_DS.AcceptChanges();
                        personalTableAdapter.Fill(local_Db_DS.Personal);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void Cancel_edit_p_Click(object sender, EventArgs e)
        {
            local_Db_DS.Personal.RejectChanges();
            Edit(false);
            New_p.Enabled = true;
            Save_p.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
