using DGVPrinterHelper;
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
    public partial class GeneralForm :MetroFramework.Forms.MetroForm
    {
        DB db = new DB();
        private bool chek_p, chek_c, chek_o;
        private bool insert_cli, dis_access;
        private bool chek_edit = false;
        double g_sum=0, g_sum_op=0, discount_value=0, discount_value_op = 0;
        double sum_debit = 0;
        double quantity; 
        string first_value;
        string first_value_op;
        string first_value_debit;
        private int count_p=0;
        private double SUM_RP=0, SUM_WP = 0;

        // private string debit_query = "SELECT  Clients.Id_client, Orders.Purchase_date, Clients.Surname, Clients.Name, Orders.General_Price, Orders.Paid, Clients.Last_payment_date AS L_P_D, Clients.How_many, Clients.All_debit, Orders.Id_order FROM  Clients INNER JOIN Orders ON Clients.Id_client = Orders.Id_client AND Clients.All_debit > 0 AND Orders.Paid < Orders.General_Price ORDER BY Clients.Surname";
        private string debit_query = "SELECT        Id_client AS [ID клиента], Surname AS Фамилия, Name AS Имя, Last_payment_date AS [Дата последней оплаты], How_many AS Сколько, All_debit AS [Суммарный долг] FROM Clients WHERE(All_debit > 0) ORDER BY Surname";
        public GeneralForm()
        {
            InitializeComponent();
 
        }


        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseConnection();
        }




        public DataTable InitializeGrid<T>(T sqlQuery) //заполнения грида
        {
            string Query = Convert.ToString(sqlQuery);
            DataTable table = new DataTable();
            DataSet ds;
            try
            {
                db.OpenConnection();
                SqlCommand commSelect = new SqlCommand(Query, db.GetConnection());
                    SqlDataAdapter Adapter = new SqlDataAdapter(commSelect);
                    ds = new DataSet();
                    Adapter.Fill(ds);
                    Adapter.Fill(table);
                db.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }


        private void GeneralForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "local_Db_DS.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.local_Db_DS.Personal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "local_Db_DS.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.local_Db_DS.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "local_Db_DS.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.local_Db_DS.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "local_Db_DS.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.local_Db_DS.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "local_Db_DS.Clients". При необходимости она может быть перемещена или удалена.

      


            Edit(false);
            Edit1(false);
            Edit2(false);
            Edit3(false);
            Edit4(false);


            visible_components_status(false);
            dis_access = false;

            Name_c.Enabled = false;
            Tel_number_c.Enabled = false;


            General_grid.Visible = false;
            Order_grid.Visible = false;
            P_table_btn.Enabled = false;
       

            Process_order.Enabled = false;

            Price.Text = Rp_price.Text;
            Price_op.Text = Op_price.Text;
            TB_ID_C.Text = Id_c.Text;
        }

        private void Edit(bool value)
        {
            metroTextBox1.Enabled = value;
            Description.Enabled = value;
            metroTextBox2.Enabled = value;
            metroTextBox3.Enabled = value;
            metroTextBox4.Enabled = value;
            metroTextBox5.Enabled = value;
            metroTextBox12.Enabled = value;
            Quantity_p.Enabled = value;

        }
        private void Edit1(bool value)
        {
            metroTextBox7.Enabled = value;
            metroTextBox8.Enabled = value;
            metroTextBox9.Enabled = value;
            metroTextBox10.Enabled = value;
            metroTextBox11.Enabled = value;
            metroTextBox13.Enabled = value;
        }
        private void Edit2(bool value)
        {
            TB_ID_P.Enabled = value;
            TB_ID_C.Enabled = value;
            Surname.Enabled = value;
           // Name_client.Enabled = value;
            Name_Products.Enabled = value;
            Quentity.Enabled = value;
            Price.Enabled = value;
            General_price.Enabled = value;
            discount.Enabled = value;
            Paid.Enabled = value;
            Debt.Enabled = value;
            Date.Enabled = value;
        }
        void Edit3(bool value)
        {
            Who.Enabled = value;
            Name_cl.Enabled = value;
            P_date.Enabled= value;

            Paid_Label.Enabled = value;
            Paid_Tb.Enabled = value;
            remainder.Enabled = value;
        }

        void Edit4(bool value)
        {
            Company.Enabled = value;
            Id_company.Enabled = value;
            Surname_personal.Enabled = value;
            Name_personal.Enabled = value;
            Tel_number_personal.Enabled = value;
        }

        void visible_components_status(bool value)
        {
            Id_c.Visible = value;
            Client_surname.Visible = value;
            TB_ID_C.Visible = value;
            TB_ID_P.Visible = value;
            General_op.Visible = value;
            Price_op.Visible = value;
            Op_price.Visible = value;
            Statistic_grid.Visible = value;
            Debit_client.Visible = value;
            Quantity_product.Visible = value;
        }

        void Refresh_Debt_grid(int i)
        {
            if (Debt_grid.SelectedRows.Count != 0 )
                Num_o_del.Text = Debt_grid[0, i].Value.ToString();
            //&& !string.IsNullOrEmpty(Debt_grid[0, i].Value.ToString())

        }


        void Print_order()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = ((DataRowView)personalBindingSource.Current).Row["Сompany"].ToString() + "\n" + ((DataRowView)personalBindingSource.Current).Row["ID_company"].ToString();
            printer.SubTitle = "Покупатель: "+Surname.Text+" "+ Name_c.Text+ "     Дата: "+Date.Text+ "\n" + "\n" + "Подпись продавца__________" + "   Тел: "+ ((DataRowView)personalBindingSource.Current).Row["Tel_number"].ToString()+ "\n" + "\n" + "Подпись получателя__________" + "   Тел: " + ((DataRowView)clientsBindingSource.Current).Row["Tel_number"].ToString() + "\n" + " ";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintDataGridView(DGV_for_print);
        }






        /********************************************************Интерфейс для уравления базой клиентов************************************************************************************/
        /******************************************************************Начало1***************************************************/
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            if (clientsBindingSource.Filter != string.Empty)
                clientsBindingSource.Filter = string.Empty;
            clientsTableAdapter.Fill(local_Db_DS.Clients);
            //  this.ClientGrid.Sort(this.ClientGrid.Columns[1], ListSortDirection.Ascending);
        }

        private void Serch_client_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Serch_client.Text))
                clientsBindingSource.Filter = string.Empty;
        }

        private void btn_search_client_Click(object sender, EventArgs e)
        {
            if (Serch_client.Text != "")
            {
                clientsBindingSource.Filter = string.Format("Surname ='" + Serch_client.Text + "' OR Name ='" + Serch_client.Text + "' OR Tel_number ='" + Serch_client.Text + "'");

            }
            else
                clientsBindingSource.Filter = string.Empty;
        }


        private void New_Client_Click(object sender, EventArgs e)
        {
            try
            {
                Edit1(true);
                local_Db_DS.Clients.AddClientsRow(local_Db_DS.Clients.NewClientsRow());
                clientsBindingSource.MoveLast();
                metroTextBox7.Focus();
                chek_c = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                local_Db_DS.Clients.RejectChanges();
            }


        }

        private void Save_Client_Click(object sender, EventArgs e)
        {

                try
                {
                    clientsBindingSource.EndEdit();
                    clientsTableAdapter.Update(local_Db_DS.Clients);
                    clientsTableAdapter.Fill(local_Db_DS.Clients);
                    //ClientGrid.Refresh();
  
                if (chek_c == true)
                {
                    MessageBox.Show("Успешно сохранена!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Успешно обновлена!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                }

        }

        private void Edit_Client_Click(object sender, EventArgs e)
        {
            Edit1(true);
            metroTextBox7.Focus();
            chek_c = false;
        }

        private void Delete_Client_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотитете удалить эту запись?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Num_C.Text != "")
                    {
                        db.OpenConnection();
                        SqlCommand command = new SqlCommand("DELETE FROM [Clients] WHERE [Id_client]=@Id_C", db.GetConnection());
                        command.Parameters.AddWithValue("@Id_C", Num_C.Text);
                        command.ExecuteNonQuery();
                        db.CloseConnection();

                        clientsBindingSource.RemoveCurrent();

                        local_Db_DS.AcceptChanges();
                        clientsTableAdapter.Fill(local_Db_DS.Clients);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void Cencel_Edit_Client_Click(object sender, EventArgs e)
        {
            local_Db_DS.Clients.RejectChanges();
            Edit1(false);
        }
        /******************************************************************Конец1***************************************************/




        //************************************************************************************Интерфейс для уравления базой продуктов********************************************************************
        /******************************************************************Начало2***************************************************/

       private void Get_Global_SUM_and_COUNT()
        {

            count_p = (int)productsTableAdapter.Count_quary();
            SUM_RP = (double)productsTableAdapter.SUM_RP_Query();
            SUM_WP = (double)productsTableAdapter.SUM_WP_Query();
            Count.Text = Convert.ToString(count_p);

            if (SUM_RP != 0 && SUM_WP !=0)
            {
                General_RPrice.Text = Convert.ToString(SUM_RP);
                General_WPrice.Text = Convert.ToString(SUM_WP);
                Future_profit.Text = Convert.ToString(SUM_RP-SUM_WP);
            }
            else
            {
                General_RPrice.Text = "0";
                General_WPrice.Text  = "0";
                Future_profit.Text = "0";
            }
            

        }

        private void Refresh_data_Click(object sender, EventArgs e)
        {
            Get_Global_SUM_and_COUNT();
            productsTableAdapter.Fill(local_Db_DS.Products);
        }

        private void Search_product_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Search_product.Text))
                productsBindingSource.Filter = string.Empty;
        }


        private void tabPage2_Enter(object sender, EventArgs e)
        {
            if (productsBindingSource.Filter != string.Empty)
                productsBindingSource.Filter = string.Empty;
            Get_Global_SUM_and_COUNT();
        }

        private void btn_search_product_Click(object sender, EventArgs e)
        {
            if (Search_product.Text != "")
            {
                productsBindingSource.Filter = $"Name LIKE '*{ Search_product.Text }*' OR Description ='*{ Search_product.Text }*' OR Material ='*{ Search_product.Text }*' OR Colour ='*{ Search_product.Text }*'";

            }
            else
                productsBindingSource.Filter = string.Empty;
        }

        private void New_product_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                local_Db_DS.Products.AddProductsRow(local_Db_DS.Products.NewProductsRow());
                productsBindingSource.MoveLast();
                metroTextBox1.Focus();
                chek_p = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                local_Db_DS.Clients.RejectChanges();
            }
        }

        private void Save_product_Click(object sender, EventArgs e)
        {
                try
                {
                    productsBindingSource.EndEdit();
                    productsTableAdapter.Update(local_Db_DS.Products);
                    productsTableAdapter.Fill(local_Db_DS.Products);
                // metroGrid1.Refresh();
     
                if (chek_p == true)
                        MessageBox.Show("Успешно сохранена!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Успешно обновлена!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                }
            
            Edit(false);
        }


        private void Edit_product_Click(object sender, EventArgs e)
        {
            Edit(true);
            metroTextBox1.Focus();
            chek_p = false;
        }

        private void Delete_product_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотитете удалить эту запись?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Num_P.Text != "")
                    {
                         db.OpenConnection();
                         SqlCommand command = new SqlCommand("DELETE FROM [Products] WHERE [Id_product]=@Id_product", db.GetConnection());
                         command.Parameters.AddWithValue("@Id_product", Num_P.Text);

                         command.ExecuteNonQuery();
                         db.CloseConnection();

                        productsBindingSource.RemoveCurrent();

                        local_Db_DS.AcceptChanges();
                        productsTableAdapter.Fill(local_Db_DS.Products);


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                }
            }
        }

        void Visible_colums_for_print(bool value)
        {
            metroGrid1.Columns[5].Visible = value;
            metroGrid1.Columns[7].Visible = value;
        }


        private void Print_price_list_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Прайс-лист";
            printer.SubTitle = "Дата: " + Date.Text;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            Visible_colums_for_print(false);
            printer.PrintDataGridView(metroGrid1);
            Visible_colums_for_print(true);
        }


        private void Cancel_edit_product_Click(object sender, EventArgs e)
        {
            Edit(false);
            local_Db_DS.Products.RejectChanges();
        }
        /******************************************************************Конец2***************************************************/





        //***************************************************************************************************Интерфейс для управления заказами*********************************************************************************
        /******************************************************************Начало3***************************************************/

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            clientsBindingSource.Filter = string.Empty;
        }

        private void Rp_price_TextChanged(object sender, EventArgs e)
        {
            Price.Text = Rp_price.Text;
        }

        private void Op_price_TextChanged(object sender, EventArgs e)
        {
            Price_op.Text = Op_price.Text;
        }

        private void New_order_Click(object sender, EventArgs e)
        {

            try
            {
                Edit(true);
                Edit1(true);
                Edit2(true);
                Edit4(true);

                local_Db_DS.Orders.AddOrdersRow(local_Db_DS.Orders.NewOrdersRow());

                ordersBindingSource.MoveLast();
                Surname.Focus();
                Date.Text = date_time.Text;

                TB_ID_C.Text = Id_c.Text;

                chek_o = true;
                g_sum = 0;
                g_sum_op = 0;
                quantity = 0;
                dis_access = true;
                chek_edit = false;

                Quantity_p.Enabled = true;
                metroTextBox13.Enabled = true;
                Quentity.Text = "";
                DGV_for_print.Rows.Clear();

                New_order.Enabled = false;
                Process_order.Enabled = true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                local_Db_DS.Orders.RejectChanges();
            }
        }

        void update_quantity_product()
        {
            try
            {
                productsBindingSource.EndEdit();
                productsTableAdapter.Update(local_Db_DS);
                metroGrid1.Refresh();

               // MessageBox.Show("Количество продукта обновлено!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
            }
        }

        void  insert_O()
        {
            try
            {
     
                ordersBindingSource.EndEdit();
                ordersTableAdapter.Update(local_Db_DS);
                Order_grid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
            }
        }

        void Update_client_debit()
        {
            try
            {
                clientsBindingSource.EndEdit();
                clientsTableAdapter.Update(local_Db_DS);
                ClientGrid.Refresh();


                MessageBox.Show("Долг обновлён!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
            }
        }

        void Insert_client()
        {
            try
            {
                Client_surname.Text = Surname.Text;

                clientsBindingSource.EndEdit();
                clientsTableAdapter.Update(local_Db_DS);
                ClientGrid.Refresh();


                MessageBox.Show("Клиент добавлен!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
            }
        }

        private void  Add_product_Click(object sender, EventArgs e)
        {

            if (insert_cli)
            {
                Insert_client();
                insert_cli = false;
            }
                

            if (chek_o)
            {
                insert_O();
                chek_o = false;
            }

            g_sum=Convert.ToDouble(General_price.Text);
            g_sum_op = Convert.ToDouble(General_op.Text);

            try
            {
                db.OpenConnection();
                SqlCommand command = new SqlCommand("INSERT INTO [Procurements] (id_order, id_product, Quantity, Price) VALUES( @id_order, @id_product, @Quantity, @Price)", db.GetConnection());
                command.Parameters.AddWithValue("@id_order", Num_O.Text);
                command.Parameters.AddWithValue("@id_product", TB_ID_P.Text);
                command.Parameters.AddWithValue("@Quantity", Quentity.Text);
                command.Parameters.AddWithValue("@Price", Price.Text);

                command.ExecuteNonQuery();
                db.CloseConnection();
                MessageBox.Show("Добавлено!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Quentity.Text != "")
                {

                    quantity = Convert.ToDouble(((DataRowView)productsBindingSource.Current).Row["Quantity_p"].ToString()) - Convert.ToDouble(Quentity.Text);
                    Quantity_p.Text = Convert.ToString(quantity);
                    Quantity_product.Text = Quantity_p.Text;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
            }

            update_quantity_product();


            //1) DGV_for_print.Rows.Add(Name_Products.Text + " " + Description.Text, Quentity.Text, Rp_price.Text, Price.Text);          
            //2) DGV_for_print.Rows.Add(Name_Products.Text + " (" + Description.Text + ", " + metroTextBox2.Text + ", " + metroTextBox3.Text+")", Quentity.Text, Rp_price.Text, Price.Text);
            DGV_for_print.Rows.Add(Name_Products.Text + " (" + ((DataRowView)productsBindingSource.Current).Row["Description"].ToString() + ", " + ((DataRowView)productsBindingSource.Current).Row["Material"].ToString() + ", " + ((DataRowView)productsBindingSource.Current).Row["Colour"].ToString() + ")", Quentity.Text, Rp_price.Text, Price.Text);

            Quentity.Text = "";

        }

        private void Add_Client_Click(object sender, EventArgs e)
        {

            try
            {
                Name_c.Enabled = true;
                Tel_number_c.Enabled = true;
                insert_cli = true;

                local_Db_DS.Clients.AddClientsRow(local_Db_DS.Clients.NewClientsRow());
                clientsBindingSource.MoveLast();

                TB_ID_C.Text = Id_c.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                local_Db_DS.Clients.RejectChanges();
            }
        }

        private void Process_order_Click(object sender, EventArgs e)
        {
            if (insert_cli)
                Insert_client();

            if (chek_o == true)
            {
                insert_O();

                //1) DGV_for_print.Rows.Add(Name_Products.Text + " " + Description.Text, Quentity.Text, Rp_price.Text, Price.Text);
                //2) DGV_for_print.Rows.Add(Name_Products.Text + " (" + Description.Text + ", " + metroTextBox2.Text + ", " + metroTextBox3.Text+")", Quentity.Text, Rp_price.Text, Price.Text);
                DGV_for_print.Rows.Add(Name_Products.Text + " (" + ((DataRowView)productsBindingSource.Current).Row["Description"].ToString() + ", " + ((DataRowView)productsBindingSource.Current).Row["Material"].ToString() + ", " + ((DataRowView)productsBindingSource.Current).Row["Colour"].ToString() + ")", Quentity.Text, Rp_price.Text, Price.Text);

                try
                {
                    db.OpenConnection();
                    SqlCommand command = new SqlCommand("INSERT INTO [Procurements] (id_order, id_product, Quantity, Price) VALUES( @id_order, @id_product, @Quantity, @Price)", db.GetConnection());
                    command.Parameters.AddWithValue("@id_order", Num_O.Text);
                    command.Parameters.AddWithValue("@id_product", TB_ID_P.Text);
                    command.Parameters.AddWithValue("@Quantity", Quentity.Text);
                    command.Parameters.AddWithValue("@Price", Price.Text);

                    command.ExecuteNonQuery();
                    db.CloseConnection();


                    MessageBox.Show("Оформлено!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (Quentity.Text != "")
                    {

                        quantity = Convert.ToDouble(((DataRowView)productsBindingSource.Current).Row["Quantity_p"].ToString()) - Convert.ToDouble(Quentity.Text);
                        Quantity_p.Text = Convert.ToString(quantity);
                        Quantity_product.Text = Quantity_p.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                }

                update_quantity_product();

            }
            else
            {
                try
                {
                    ordersBindingSource.EndEdit();
                    ordersTableAdapter.Update(local_Db_DS.Orders);
                    Order_grid.Refresh();

                    if (!chek_edit)
                        MessageBox.Show("Оформлено!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Сохранено!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    dis_access = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                }
            }

            if(Debt.Text !="" && Debt.Text != "0")
            {
                if(metroTextBox13.Text != "")
                {
                    sum_debit = Convert.ToDouble(metroTextBox13.Text) + Convert.ToDouble(Debt.Text);
                    metroTextBox13.Text = Convert.ToString(sum_debit);
                    Debit_client.Text = metroTextBox13.Text;
                    Update_client_debit();
                }
                else
                {
                    metroTextBox13.Text = Debt.Text;
                    Debit_client.Text = metroTextBox13.Text;
                    Update_client_debit();
                }
            }

            /*
            ordersTableAdapter.Fill(local_Db_DS.Orders);
            productsTableAdapter.Fill(local_Db_DS.Products);
            clientsTableAdapter.Fill(local_Db_DS.Clients);
            */

            if (!chek_edit)
            {
                DGV_for_print.Rows.Add();

                if (discount.Text != "" && discount.Text != "0")
                {
                    DGV_for_print.Rows.Add("","\n" + "Скидка:", "\n" + discount.Text + "%");
                    DGV_for_print.Rows.Add("", "Итоговая цена ", "без скидки:", first_value);
                    DGV_for_print.Rows.Add("", "Итоговая цена" , "со скидкой:", General_price.Text);
                }
                else
                    DGV_for_print.Rows.Add("", "", "\n" + "Итоговая цена:", "\n" + General_price.Text);

                Print_order();
            }


  

            Edit(false);
            Edit1(false);
            Edit2(false);
            Edit4(false);

            Name_c.Enabled = false;
            Tel_number_c.Enabled = false;
            insert_cli = false;
            Quantity_p.Enabled = false;
            metroTextBox13.Enabled = false;
            Quentity.Text = "";

            New_order.Enabled = true;
            Process_order.Enabled = false;
        }


        private void Edit_order_Click(object sender, EventArgs e)
        {
            Edit2(true);
            Surname.Focus();
            chek_o = false;
            dis_access = true;
            first_value = General_price.Text;
            first_value_op = General_op.Text;

            Quantity_p.Enabled = true;
            metroTextBox13.Enabled = true;
            chek_edit = true;
            Process_order.Enabled = true;
            New_order.Enabled = false;
            
            //Num_O.Text= ((DataRowView)ordersBindingSource.Current).Row["Id_order"].ToString();
        }




        private void General_table_button_Click(object sender, EventArgs e)
        {
            General_grid.Visible = true;
            Order_grid.Visible = false;
            Product_table.Visible = false;


            General_grid.DataSource = InitializeGrid("SELECT Orders.Id_order AS Номер_заказа, Orders.Purchase_date AS Дата_покупки, Clients.Surname AS Фамилия, Clients.Name AS Имя, Products.Name AS Продукт, Products.Description AS Описание, Products.Material AS Материал,  Procurements.Quantity AS Количество, Products.Unit AS Ед_изм, Procurements.Price AS Сколько, Orders.General_Price AS Сколько_всего, Orders.Paid AS Оплачено, Orders.Debt AS Долг FROM   Clients INNER JOIN  Orders ON Clients.Id_client = Orders.Id_client INNER JOIN   Procurements ON Orders.Id_order = Procurements.Id_order INNER JOIN      Products ON Procurements.Id_product = Products.Id_product ORDER BY Фамилия");

            back.Enabled = true;
            General_table_button.Enabled = false;
            P_table_btn.Enabled = true;
        }

      

        private void General_grid_SelectionChanged(object sender, EventArgs e)
        {

        }


        private void Delete_orders_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотитете удалить эту запись?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Num_O.Text != "")
                    {
                        db.OpenConnection();
                        SqlCommand command = new SqlCommand("DELETE FROM [Orders] WHERE Id_order=@Id_order", db.GetConnection());
                        command.Parameters.AddWithValue("@Id_order", Num_O.Text);
                        command.ExecuteNonQuery();
                        db.CloseConnection();

                        ordersBindingSource.RemoveCurrent();
                        local_Db_DS.AcceptChanges();
                        ordersTableAdapter.Fill(local_Db_DS.Orders);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            General_grid.Visible = false;
            Order_grid.Visible = true;
            Product_table.Visible = false;

            back.Enabled = false;
            General_table_button.Enabled = true;
            P_table_btn.Enabled = true;
        }



        //Панель для управления долгов 
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }



        private void Save_edit_Click(object sender, EventArgs e)
        {

            try
            {



                clientsBindingSource.EndEdit();

                db.OpenConnection();
                SqlCommand command = new SqlCommand("UPDATE [Clients] SET Last_payment_date=@Last_payment_date, How_many=@How_many, All_debit=@All_debit WHERE Id_client=@Id_client", db.GetConnection());

                command.Parameters.AddWithValue("@Id_client", Num_o_del.Text);
                command.Parameters.AddWithValue("@Last_payment_date", P_date.Text);

                if (remainder.Text=="0")
                {
                    command.Parameters.AddWithValue("@How_many", 0);

                }
                else 
                {
                    command.Parameters.AddWithValue("@How_many", Paid_Tb.Text);
                }

                command.Parameters.AddWithValue("@All_debit", remainder.Text);

                command.ExecuteNonQuery();
                db.CloseConnection();


                ClientGrid.Refresh();


                MessageBox.Show("Долг обновлен!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
            }


            Debt_grid.DataSource = InitializeGrid(debit_query);
            Paid_Tb.Text = "";

            Edit3(false);
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
           // discount.Text = ((DataRowView)productsBindingSource.Current).Row["Price"].ToString();
        }

        private void Quentity_TextChanged(object sender, EventArgs e)
        {
            if(Quentity.Text != "")
            {
                if (Quentity.Text == "1")
                {
                    if (g_sum > 0)
                    {
                        Price.Text = ((DataRowView)productsBindingSource.Current).Row["Retail_price"].ToString();
                        General_price.Text = Convert.ToString(g_sum + Convert.ToDouble(Price.Text));

                        Price_op.Text = ((DataRowView)productsBindingSource.Current).Row["Wholesale_price"].ToString();
                        General_op.Text = Convert.ToString(g_sum_op + Convert.ToDouble(Price_op.Text));
                    }
                    else
                    {
                        Price.Text = ((DataRowView)productsBindingSource.Current).Row["Retail_price"].ToString();
                        General_price.Text = Price.Text;

                        Price_op.Text = ((DataRowView)productsBindingSource.Current).Row["Wholesale_price"].ToString();
                        General_op.Text = Price_op.Text;
                    }

                }
                else if (Convert.ToDouble(Quentity.Text) > 1)
                {
                    try
                    {
                        double a = Convert.ToDouble(((DataRowView)productsBindingSource.Current).Row["Retail_price"].ToString());
                        double a1 = Convert.ToDouble(((DataRowView)productsBindingSource.Current).Row["Wholesale_price"].ToString());
                        double b = Convert.ToDouble(Quentity.Text);

                        Price.Text = Convert.ToString(a * b);
                        Price_op.Text = Convert.ToString(a1 * b);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
                    }

                }

            }
            else
            {
                Price.Text = ((DataRowView)productsBindingSource.Current).Row["Retail_price"].ToString();
                Price_op.Text = ((DataRowView)productsBindingSource.Current).Row["Wholesale_price"].ToString();

                if (g_sum > 0)
                {
                    General_price.Text = Convert.ToString(g_sum);
                    General_op.Text = Convert.ToString(g_sum_op);
                }

                else
                {
                    General_price.Text = "";
                    General_op.Text = "";
                }

            }
            first_value = General_price.Text;
            first_value_op = General_op.Text;

        }

        private void Price_op_TextChanged(object sender, EventArgs e)
        {
            if (Price_op.Text != "")
                General_op.Text = Convert.ToString(g_sum_op + Convert.ToDouble(Price_op.Text));
        }



        private void Paid_TextChanged(object sender, EventArgs e)
        {
            if (General_price.Text != "" && Paid.Text != "")
                Debt.Text = Convert.ToString(Convert.ToDouble(General_price.Text) - Convert.ToDouble(Paid.Text));
            else if (Paid.Text == "" || Paid.Text == "0")
                Debt.Text = General_price.Text;
        }

      

        private void discount_TextChanged(object sender, EventArgs e)
        {
            General_price.Text = first_value;
            General_op.Text = first_value_op;

            if (General_price.Text!="" && discount.Text != "" && discount.Text != "0" && dis_access)
            {
                    discount_value = (Convert.ToDouble(General_price.Text) * Convert.ToDouble(discount.Text)) / 100;
                    General_price.Text = Convert.ToString(Convert.ToDouble(General_price.Text) - discount_value);

                    discount_value_op = (Convert.ToDouble(General_op.Text) * Convert.ToDouble(discount.Text)) / 100;
                    General_op.Text = Convert.ToString(Convert.ToDouble(General_op.Text) - discount_value_op);
            }
            Paid.Text = "";
            Debt.Text = "";

        }

        private void Quentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                return;
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Name_Products_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Name_Products.Text))
            {
                label1.Text = Name_Products.SelectedValue.ToString(); 
            }

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

            if (Price.Text != "")
                General_price.Text = Convert.ToString(g_sum + Convert.ToDouble(Price.Text));
        }


        private void Surname_SelectedValueChanged(object sender, EventArgs e)
        {

        }


        private void Id_c_TextChanged(object sender, EventArgs e)
        {
            TB_ID_C.Text = Id_c.Text;
        }



        private void Cancel_prosess_Click_1(object sender, EventArgs e)
        {
            if (insert_cli)
            {
                local_Db_DS.Clients.RejectChanges();
                insert_cli = false;
            }
            Edit(true);
            Edit1(false);
            Edit2(false);
            Edit4(false);
            local_Db_DS.Orders.RejectChanges();
            dis_access = false;
            insert_cli = false;
            Name_c.Enabled = false;
            Tel_number_c.Enabled = false;
            Quantity_p.Enabled = false;
            metroTextBox13.Enabled = false;
            chek_edit = false;

            New_order.Enabled = true;
            Process_order.Enabled = false;


            discount.Text = "";
        }

        /******************************************************************Конец3***************************************************/











        /***********************************************************Панель для конроля долгов*****************************************************************************/

        //**********************************Начало4*******************************************


        private void tabPage4_Enter(object sender, EventArgs e)
        {
            Debt_grid.DataSource = InitializeGrid(debit_query);
        }

        private void Paid_Tb_TextChanged(object sender, EventArgs e)
        {
            if (Debt_grid.SelectedRows.Count != 0)
            {
               Paid_Label.Text = Debt_grid[4, Debt_grid.CurrentCell.RowIndex].Value.ToString();
               remainder.Text = Debt_grid[5, Debt_grid.CurrentCell.RowIndex].Value.ToString();
            }

            if (Paid_Tb.Text != "")
            {
                P_date.Text = date_time.Text;
                if ((Convert.ToDouble(remainder.Text) - Convert.ToDouble(Paid_Tb.Text)) < 0)
                    remainder.Text = "0";
                else
                {
                    remainder.Text = Convert.ToString(Convert.ToDouble(remainder.Text) - Convert.ToDouble(Paid_Tb.Text));

                    if (Paid_Label.Text != "")
                        Paid_Label.Text = Convert.ToString(Convert.ToDouble(Paid_Tb.Text) + Convert.ToDouble(Paid_Label.Text));
                    else
                    {
                        Paid_Label.Text = Paid_Tb.Text;
                    }
                }

            }
            else
            {
                if (Debt_grid.SelectedRows.Count != 0)
                    P_date.Text = Debt_grid[3, Debt_grid.CurrentCell.RowIndex].Value.ToString();
            }

        }

        private void Delete_debt_Click(object sender, EventArgs e)
        {
            if (Num_o_del.Text != "")
                clientsBindingSource.Filter = string.Format("Id_client='{0}'", Num_o_del.Text);
            else
                clientsBindingSource.Filter = string.Empty;

            try
            {


                clientsBindingSource.EndEdit();

                db.OpenConnection();
                SqlCommand command = new SqlCommand("UPDATE [Clients] SET Last_payment_date=@Last_payment_date, How_many=@How_many, All_debit=@All_debit WHERE Id_client=@Id_client", db.GetConnection());

                command.Parameters.AddWithValue("@Id_client", Num_o_del.Text);
                command.Parameters.AddWithValue("@Last_payment_date", "");
                command.Parameters.AddWithValue("@How_many", "0");
                command.Parameters.AddWithValue("@All_debit", "0");

                command.ExecuteNonQuery();
                db.CloseConnection();

                local_Db_DS.AcceptChanges();
                clientsTableAdapter.Fill(local_Db_DS.Clients);
                ClientGrid.Refresh();


                MessageBox.Show("Долг обнулен!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Debt_grid.DataSource = InitializeGrid(debit_query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
            }

        }


        private void Edit_debt_Click(object sender, EventArgs e)
        {
            Edit3(true);
            first_value_debit = remainder.Text;

        }






        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Debt_grid.RowCount; i++)
            {
                Debt_grid.Rows[i].Selected = false;
                for (int j = 0; j < Debt_grid.ColumnCount; j++)
                    if (Debt_grid.Rows[i].Cells[j].Value != null)
                        if (Debt_grid.Rows[i].Cells[j].Value.ToString().Contains(Search_box.Text))
                        {
                            Debt_grid.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Debt_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (Debt_grid.SelectedRows.Count != 0)
                Refresh_Debt_grid(Debt_grid.CurrentCell.RowIndex);

            if (Num_o_del.Text != "")
                clientsBindingSource.Filter = string.Format("Id_client='{0}'", Num_o_del.Text);
            else
                clientsBindingSource.Filter = string.Empty;
        }



        private void Cencel_edit_debt_Click(object sender, EventArgs e)
        {
            //local_Db_DS.Clients.RejectChanges();
            clientsBindingSource.Filter = string.Empty;
            Paid_Tb.Text = "";
            Edit3(false);
        }



        /******************************************************************Конец4***************************************************/




        //**************************************************************************************Панель упраление статистикой***********************************************************

        /******************************************************************Начало5***************************************************/
        private void Do_it_Click(object sender, EventArgs e)
        {
            //Statistic_grid.DataSource = InitializeGrid("SELECT SUM(General_Price_rp) AS [Всего продано 1], SUM(General_Price) AS [Всего продано 2] FROM Orders WHERE Purchase_date >="+"'"+From.Text+"'"+"AND Purchase_date <= "+"'"+To.Text+"'");
            Statistic_grid.DataSource = InitializeGrid("SELECT SUM(t2.GP1) AS Price1, SUM(t2.GP2) AS Price2, COALESCE (SUM(t1.debit), 0) AS Debit FROM (SELECT Id_client, Purchase_date, SUM(General_Price) AS GP1, SUM(General_Price_rp) AS GP2 FROM Orders GROUP BY Id_client, Purchase_date) AS t2 Left JOIN (SELECT Id_client, SUM(All_debit) AS debit FROM Clients GROUP BY Id_client) AS t1 ON t2.Id_client = t1.Id_client WHERE t2.Purchase_date >=" + "'" + From.Text + "'" + "AND t2.Purchase_date <= " + "'" + To.Text + "'");
            try
            {
                if(Statistic_grid[0, 0].Value.ToString() != "" && Statistic_grid[1, 0].Value.ToString() != "")
                {
                    Value_rp.Text = Statistic_grid[0, 0].Value.ToString();
                    Value_p.Text = Statistic_grid[1, 0].Value.ToString();
                    Debit_value.Text= Statistic_grid[2, 0].Value.ToString();
                    Profit.Text = Convert.ToString(Convert.ToDouble(Value_rp.Text)-Convert.ToDouble(Value_p.Text));
                }
                else
                {
                    Value_p.Text = "0";
                    Value_rp.Text = "0";
                    Profit.Text = "0";
                    Debit_value.Text = "0";
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
            }

        }



        /******************************************************************Конец5***************************************************/

        //****************************************************************************************Элементы меню****************************************************
        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
        }



        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
        }

        private void P_table_btn_Click(object sender, EventArgs e)
        {
            General_grid.Visible = false;
            Order_grid.Visible = false;
            Product_table.Visible = true;

            back.Enabled = true;
            General_table_button.Enabled = true;
            P_table_btn.Enabled = false;
        }

        private void оПриложенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program about_prog = new About_program();
            about_prog.Show();
        }

        private void новыйЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            db.CloseConnection();
        }











        //**************************************************************************************Панель упраление персоналом***********************************************************

        /******************************************************************Начало5***************************************************/

        private void Save_personal_Click(object sender, EventArgs e)
        {
            try
            {
                personalBindingSource.EndEdit();
                personalTableAdapter.Update(local_Db_DS.Personal);
                MessageBox.Show("Cохранено!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK);
            }
        }

        private void Edit_personal_Click(object sender, EventArgs e)
        {
            Edit4(true);
            Company.Focus();
        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            local_Db_DS.Personal.RejectChanges();
            Edit4(false);
        }

    }
}
