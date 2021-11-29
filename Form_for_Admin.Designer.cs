namespace Мagazine
{
    partial class Form_for_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_for_Admin));
            this.metroLabel50 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel51 = new MetroFramework.Controls.MetroLabel();
            this.Password = new MetroFramework.Controls.MetroTextBox();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.local_Db_DS = new Мagazine.Local_Db_DS();
            this.Login = new MetroFramework.Controls.MetroTextBox();
            this.Id_company = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel43 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel46 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel47 = new MetroFramework.Controls.MetroLabel();
            this.Company = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel48 = new MetroFramework.Controls.MetroLabel();
            this.Tel_num_personal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel49 = new MetroFramework.Controls.MetroLabel();
            this.Name_p = new MetroFramework.Controls.MetroTextBox();
            this.Surname_p = new MetroFramework.Controls.MetroTextBox();
            this.Cancel_edit_p = new MetroFramework.Controls.MetroTile();
            this.Delete_p = new MetroFramework.Controls.MetroTile();
            this.Edit_p = new MetroFramework.Controls.MetroTile();
            this.New_p = new MetroFramework.Controls.MetroTile();
            this.Save_p = new MetroFramework.Controls.MetroTile();
            this.Exit = new MetroFramework.Controls.MetroTile();
            this.btn_open_GenForm = new MetroFramework.Controls.MetroTile();
            this.Personal_grid = new MetroFramework.Controls.MetroGrid();
            this.idpersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalTableAdapter = new Мagazine.Local_Db_DSTableAdapters.PersonalTableAdapter();
            this.ID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.local_Db_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personal_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel50
            // 
            this.metroLabel50.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel50.AutoSize = true;
            this.metroLabel50.Location = new System.Drawing.Point(59, 384);
            this.metroLabel50.Name = "metroLabel50";
            this.metroLabel50.Size = new System.Drawing.Size(69, 19);
            this.metroLabel50.TabIndex = 131;
            this.metroLabel50.Text = "Password*";
            this.metroLabel50.UseCustomBackColor = true;
            // 
            // metroLabel51
            // 
            this.metroLabel51.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel51.AutoSize = true;
            this.metroLabel51.Location = new System.Drawing.Point(59, 343);
            this.metroLabel51.Name = "metroLabel51";
            this.metroLabel51.Size = new System.Drawing.Size(47, 19);
            this.metroLabel51.TabIndex = 130;
            this.metroLabel51.Text = "Login*";
            this.metroLabel51.UseCustomBackColor = true;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.Password.CustomButton.Image = null;
            this.Password.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.Password.CustomButton.Name = "";
            this.Password.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password.CustomButton.TabIndex = 1;
            this.Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password.CustomButton.UseSelectable = true;
            this.Password.CustomButton.Visible = false;
            this.Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Password", true));
            this.Password.Lines = new string[0];
            this.Password.Location = new System.Drawing.Point(134, 384);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(241, 24);
            this.Password.TabIndex = 129;
            this.Password.UseSelectable = true;
            this.Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.local_Db_DS;
            // 
            // local_Db_DS
            // 
            this.local_Db_DS.DataSetName = "Local_Db_DS";
            this.local_Db_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.Login.CustomButton.Image = null;
            this.Login.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.Login.CustomButton.Name = "";
            this.Login.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.Login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Login.CustomButton.TabIndex = 1;
            this.Login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Login.CustomButton.UseSelectable = true;
            this.Login.CustomButton.Visible = false;
            this.Login.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Login", true));
            this.Login.Lines = new string[0];
            this.Login.Location = new System.Drawing.Point(134, 343);
            this.Login.MaxLength = 32767;
            this.Login.Name = "Login";
            this.Login.PasswordChar = '\0';
            this.Login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Login.SelectedText = "";
            this.Login.SelectionLength = 0;
            this.Login.SelectionStart = 0;
            this.Login.ShortcutsEnabled = true;
            this.Login.Size = new System.Drawing.Size(241, 24);
            this.Login.TabIndex = 128;
            this.Login.UseSelectable = true;
            this.Login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // Id_company
            // 
            this.Id_company.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.Id_company.CustomButton.Image = null;
            this.Id_company.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.Id_company.CustomButton.Name = "";
            this.Id_company.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.Id_company.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Id_company.CustomButton.TabIndex = 1;
            this.Id_company.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Id_company.CustomButton.UseSelectable = true;
            this.Id_company.CustomButton.Visible = false;
            this.Id_company.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ID_company", true));
            this.Id_company.Lines = new string[0];
            this.Id_company.Location = new System.Drawing.Point(173, 300);
            this.Id_company.MaxLength = 32767;
            this.Id_company.Name = "Id_company";
            this.Id_company.PasswordChar = '\0';
            this.Id_company.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Id_company.SelectedText = "";
            this.Id_company.SelectionLength = 0;
            this.Id_company.SelectionStart = 0;
            this.Id_company.ShortcutsEnabled = true;
            this.Id_company.Size = new System.Drawing.Size(202, 24);
            this.Id_company.TabIndex = 119;
            this.Id_company.UseSelectable = true;
            this.Id_company.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Id_company.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel43
            // 
            this.metroLabel43.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel43.AutoSize = true;
            this.metroLabel43.Location = new System.Drawing.Point(59, 303);
            this.metroLabel43.Name = "metroLabel43";
            this.metroLabel43.Size = new System.Drawing.Size(107, 19);
            this.metroLabel43.TabIndex = 127;
            this.metroLabel43.Text = "Номер копании";
            this.metroLabel43.UseCustomBackColor = true;
            // 
            // metroLabel46
            // 
            this.metroLabel46.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel46.AutoSize = true;
            this.metroLabel46.Location = new System.Drawing.Point(59, 178);
            this.metroLabel46.Name = "metroLabel46";
            this.metroLabel46.Size = new System.Drawing.Size(41, 19);
            this.metroLabel46.TabIndex = 126;
            this.metroLabel46.Text = "Имя*";
            this.metroLabel46.UseCustomBackColor = true;
            // 
            // metroLabel47
            // 
            this.metroLabel47.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel47.AutoSize = true;
            this.metroLabel47.Location = new System.Drawing.Point(59, 137);
            this.metroLabel47.Name = "metroLabel47";
            this.metroLabel47.Size = new System.Drawing.Size(71, 19);
            this.metroLabel47.TabIndex = 125;
            this.metroLabel47.Text = "Фамилия*";
            this.metroLabel47.UseCustomBackColor = true;
            // 
            // Company
            // 
            this.Company.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.Company.CustomButton.Image = null;
            this.Company.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.Company.CustomButton.Name = "";
            this.Company.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.Company.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Company.CustomButton.TabIndex = 1;
            this.Company.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Company.CustomButton.UseSelectable = true;
            this.Company.CustomButton.Visible = false;
            this.Company.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Сompany", true));
            this.Company.Lines = new string[0];
            this.Company.Location = new System.Drawing.Point(173, 261);
            this.Company.MaxLength = 32767;
            this.Company.Name = "Company";
            this.Company.PasswordChar = '\0';
            this.Company.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Company.SelectedText = "";
            this.Company.SelectionLength = 0;
            this.Company.SelectionStart = 0;
            this.Company.ShortcutsEnabled = true;
            this.Company.Size = new System.Drawing.Size(202, 24);
            this.Company.TabIndex = 118;
            this.Company.UseSelectable = true;
            this.Company.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Company.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel48
            // 
            this.metroLabel48.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.Location = new System.Drawing.Point(59, 266);
            this.metroLabel48.Name = "metroLabel48";
            this.metroLabel48.Size = new System.Drawing.Size(71, 19);
            this.metroLabel48.TabIndex = 124;
            this.metroLabel48.Text = "Компания";
            this.metroLabel48.UseCustomBackColor = true;
            // 
            // Tel_num_personal
            // 
            this.Tel_num_personal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.Tel_num_personal.CustomButton.Image = null;
            this.Tel_num_personal.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.Tel_num_personal.CustomButton.Name = "";
            this.Tel_num_personal.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.Tel_num_personal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tel_num_personal.CustomButton.TabIndex = 1;
            this.Tel_num_personal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Tel_num_personal.CustomButton.UseSelectable = true;
            this.Tel_num_personal.CustomButton.Visible = false;
            this.Tel_num_personal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Tel_number", true));
            this.Tel_num_personal.Lines = new string[0];
            this.Tel_num_personal.Location = new System.Drawing.Point(169, 220);
            this.Tel_num_personal.MaxLength = 32767;
            this.Tel_num_personal.Name = "Tel_num_personal";
            this.Tel_num_personal.PasswordChar = '\0';
            this.Tel_num_personal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Tel_num_personal.SelectedText = "";
            this.Tel_num_personal.SelectionLength = 0;
            this.Tel_num_personal.SelectionStart = 0;
            this.Tel_num_personal.ShortcutsEnabled = true;
            this.Tel_num_personal.Size = new System.Drawing.Size(206, 24);
            this.Tel_num_personal.TabIndex = 122;
            this.Tel_num_personal.UseSelectable = true;
            this.Tel_num_personal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Tel_num_personal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel49
            // 
            this.metroLabel49.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel49.AutoSize = true;
            this.metroLabel49.Location = new System.Drawing.Point(59, 220);
            this.metroLabel49.Name = "metroLabel49";
            this.metroLabel49.Size = new System.Drawing.Size(90, 19);
            this.metroLabel49.TabIndex = 123;
            this.metroLabel49.Text = "Теле. номер*";
            this.metroLabel49.UseCustomBackColor = true;
            // 
            // Name_p
            // 
            this.Name_p.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.Name_p.CustomButton.Image = null;
            this.Name_p.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.Name_p.CustomButton.Name = "";
            this.Name_p.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.Name_p.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Name_p.CustomButton.TabIndex = 1;
            this.Name_p.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Name_p.CustomButton.UseSelectable = true;
            this.Name_p.CustomButton.Visible = false;
            this.Name_p.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Name", true));
            this.Name_p.Lines = new string[0];
            this.Name_p.Location = new System.Drawing.Point(134, 178);
            this.Name_p.MaxLength = 32767;
            this.Name_p.Name = "Name_p";
            this.Name_p.PasswordChar = '\0';
            this.Name_p.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Name_p.SelectedText = "";
            this.Name_p.SelectionLength = 0;
            this.Name_p.SelectionStart = 0;
            this.Name_p.ShortcutsEnabled = true;
            this.Name_p.Size = new System.Drawing.Size(241, 24);
            this.Name_p.TabIndex = 121;
            this.Name_p.UseSelectable = true;
            this.Name_p.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Name_p.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // Surname_p
            // 
            this.Surname_p.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.Surname_p.CustomButton.Image = null;
            this.Surname_p.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.Surname_p.CustomButton.Name = "";
            this.Surname_p.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.Surname_p.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Surname_p.CustomButton.TabIndex = 1;
            this.Surname_p.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Surname_p.CustomButton.UseSelectable = true;
            this.Surname_p.CustomButton.Visible = false;
            this.Surname_p.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Surname", true));
            this.Surname_p.Lines = new string[0];
            this.Surname_p.Location = new System.Drawing.Point(156, 137);
            this.Surname_p.MaxLength = 32767;
            this.Surname_p.Name = "Surname_p";
            this.Surname_p.PasswordChar = '\0';
            this.Surname_p.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Surname_p.SelectedText = "";
            this.Surname_p.SelectionLength = 0;
            this.Surname_p.SelectionStart = 0;
            this.Surname_p.ShortcutsEnabled = true;
            this.Surname_p.Size = new System.Drawing.Size(219, 24);
            this.Surname_p.TabIndex = 120;
            this.Surname_p.UseSelectable = true;
            this.Surname_p.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Surname_p.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // Cancel_edit_p
            // 
            this.Cancel_edit_p.ActiveControl = null;
            this.Cancel_edit_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel_edit_p.BackColor = System.Drawing.Color.Lime;
            this.Cancel_edit_p.Location = new System.Drawing.Point(580, 497);
            this.Cancel_edit_p.Name = "Cancel_edit_p";
            this.Cancel_edit_p.Size = new System.Drawing.Size(116, 80);
            this.Cancel_edit_p.TabIndex = 117;
            this.Cancel_edit_p.Text = "Отмена";
            this.Cancel_edit_p.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancel_edit_p.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel_edit_p.UseSelectable = true;
            this.Cancel_edit_p.Click += new System.EventHandler(this.Cancel_edit_p_Click);
            // 
            // Delete_p
            // 
            this.Delete_p.ActiveControl = null;
            this.Delete_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_p.BackColor = System.Drawing.Color.Lime;
            this.Delete_p.Location = new System.Drawing.Point(445, 497);
            this.Delete_p.Name = "Delete_p";
            this.Delete_p.Size = new System.Drawing.Size(116, 80);
            this.Delete_p.TabIndex = 116;
            this.Delete_p.Text = "Удалить";
            this.Delete_p.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Delete_p.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete_p.UseSelectable = true;
            this.Delete_p.Click += new System.EventHandler(this.Delete_p_Click);
            // 
            // Edit_p
            // 
            this.Edit_p.ActiveControl = null;
            this.Edit_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Edit_p.Location = new System.Drawing.Point(312, 497);
            this.Edit_p.Name = "Edit_p";
            this.Edit_p.Size = new System.Drawing.Size(116, 80);
            this.Edit_p.TabIndex = 115;
            this.Edit_p.Text = "Редактировать";
            this.Edit_p.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Edit_p.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Edit_p.UseSelectable = true;
            this.Edit_p.Click += new System.EventHandler(this.Edit_p_Click);
            // 
            // New_p
            // 
            this.New_p.ActiveControl = null;
            this.New_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.New_p.Location = new System.Drawing.Point(49, 497);
            this.New_p.Name = "New_p";
            this.New_p.Size = new System.Drawing.Size(116, 80);
            this.New_p.TabIndex = 113;
            this.New_p.Text = "Новый";
            this.New_p.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.New_p.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.New_p.UseSelectable = true;
            this.New_p.Click += new System.EventHandler(this.New_p_Click);
            // 
            // Save_p
            // 
            this.Save_p.ActiveControl = null;
            this.Save_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save_p.Location = new System.Drawing.Point(180, 497);
            this.Save_p.Name = "Save_p";
            this.Save_p.Size = new System.Drawing.Size(116, 80);
            this.Save_p.TabIndex = 114;
            this.Save_p.Text = "Сохранить";
            this.Save_p.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Save_p.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_p.UseSelectable = true;
            this.Save_p.Click += new System.EventHandler(this.Save_p_Click);
            // 
            // Exit
            // 
            this.Exit.ActiveControl = null;
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit.BackColor = System.Drawing.Color.Lime;
            this.Exit.Location = new System.Drawing.Point(968, 497);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 80);
            this.Exit.TabIndex = 134;
            this.Exit.Text = "Выход";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Exit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.UseSelectable = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btn_open_GenForm
            // 
            this.btn_open_GenForm.ActiveControl = null;
            this.btn_open_GenForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_open_GenForm.BackColor = System.Drawing.Color.Lime;
            this.btn_open_GenForm.Location = new System.Drawing.Point(825, 497);
            this.btn_open_GenForm.Name = "btn_open_GenForm";
            this.btn_open_GenForm.Size = new System.Drawing.Size(124, 80);
            this.btn_open_GenForm.TabIndex = 133;
            this.btn_open_GenForm.Text = "Перейти \r\nк главному\r\nокну";
            this.btn_open_GenForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_open_GenForm.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_open_GenForm.UseSelectable = true;
            this.btn_open_GenForm.Click += new System.EventHandler(this.btn_open_GenForm_Click);
            // 
            // Personal_grid
            // 
            this.Personal_grid.AllowUserToResizeRows = false;
            this.Personal_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Personal_grid.AutoGenerateColumns = false;
            this.Personal_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Personal_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Personal_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Personal_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Personal_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Personal_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Personal_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpersonalDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.telnumberDataGridViewTextBoxColumn,
            this.сompanyDataGridViewTextBoxColumn,
            this.iDcompanyDataGridViewTextBoxColumn});
            this.Personal_grid.DataSource = this.personalBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Personal_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Personal_grid.EnableHeadersVisualStyles = false;
            this.Personal_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Personal_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Personal_grid.Location = new System.Drawing.Point(428, 95);
            this.Personal_grid.Name = "Personal_grid";
            this.Personal_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Personal_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Personal_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Personal_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Personal_grid.Size = new System.Drawing.Size(656, 342);
            this.Personal_grid.TabIndex = 135;
            // 
            // idpersonalDataGridViewTextBoxColumn
            // 
            this.idpersonalDataGridViewTextBoxColumn.DataPropertyName = "Id_personal";
            this.idpersonalDataGridViewTextBoxColumn.HeaderText = "Id_personal";
            this.idpersonalDataGridViewTextBoxColumn.Name = "idpersonalDataGridViewTextBoxColumn";
            this.idpersonalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // telnumberDataGridViewTextBoxColumn
            // 
            this.telnumberDataGridViewTextBoxColumn.DataPropertyName = "Tel_number";
            this.telnumberDataGridViewTextBoxColumn.HeaderText = "Tel_number";
            this.telnumberDataGridViewTextBoxColumn.Name = "telnumberDataGridViewTextBoxColumn";
            // 
            // сompanyDataGridViewTextBoxColumn
            // 
            this.сompanyDataGridViewTextBoxColumn.DataPropertyName = "Сompany";
            this.сompanyDataGridViewTextBoxColumn.HeaderText = "Сompany";
            this.сompanyDataGridViewTextBoxColumn.Name = "сompanyDataGridViewTextBoxColumn";
            // 
            // iDcompanyDataGridViewTextBoxColumn
            // 
            this.iDcompanyDataGridViewTextBoxColumn.DataPropertyName = "ID_company";
            this.iDcompanyDataGridViewTextBoxColumn.HeaderText = "ID_company";
            this.iDcompanyDataGridViewTextBoxColumn.Name = "iDcompanyDataGridViewTextBoxColumn";
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.ID.CustomButton.Image = null;
            this.ID.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.ID.CustomButton.Name = "";
            this.ID.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ID.CustomButton.TabIndex = 1;
            this.ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ID.CustomButton.UseSelectable = true;
            this.ID.CustomButton.Visible = false;
            this.ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Id_personal", true));
            this.ID.Lines = new string[0];
            this.ID.Location = new System.Drawing.Point(156, 95);
            this.ID.MaxLength = 32767;
            this.ID.Name = "ID";
            this.ID.PasswordChar = '\0';
            this.ID.ReadOnly = true;
            this.ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ID.SelectedText = "";
            this.ID.SelectionLength = 0;
            this.ID.SelectionStart = 0;
            this.ID.ShortcutsEnabled = true;
            this.ID.Size = new System.Drawing.Size(219, 24);
            this.ID.TabIndex = 136;
            this.ID.UseSelectable = true;
            this.ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(59, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 137;
            this.metroLabel1.Text = "ID персонала";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // Form_for_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 617);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Personal_grid);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btn_open_GenForm);
            this.Controls.Add(this.metroLabel50);
            this.Controls.Add(this.metroLabel51);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Id_company);
            this.Controls.Add(this.metroLabel43);
            this.Controls.Add(this.metroLabel46);
            this.Controls.Add(this.metroLabel47);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.metroLabel48);
            this.Controls.Add(this.Tel_num_personal);
            this.Controls.Add(this.metroLabel49);
            this.Controls.Add(this.Name_p);
            this.Controls.Add(this.Surname_p);
            this.Controls.Add(this.Cancel_edit_p);
            this.Controls.Add(this.Delete_p);
            this.Controls.Add(this.Edit_p);
            this.Controls.Add(this.New_p);
            this.Controls.Add(this.Save_p);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_for_Admin";
            this.Text = "Окно администратора";
            this.Load += new System.EventHandler(this.Form_for_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.local_Db_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personal_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel50;
        private MetroFramework.Controls.MetroLabel metroLabel51;
        private MetroFramework.Controls.MetroTextBox Password;
        private MetroFramework.Controls.MetroTextBox Login;
        private MetroFramework.Controls.MetroTextBox Id_company;
        private MetroFramework.Controls.MetroLabel metroLabel43;
        private MetroFramework.Controls.MetroLabel metroLabel46;
        private MetroFramework.Controls.MetroLabel metroLabel47;
        private MetroFramework.Controls.MetroTextBox Company;
        private MetroFramework.Controls.MetroLabel metroLabel48;
        private MetroFramework.Controls.MetroTextBox Tel_num_personal;
        private MetroFramework.Controls.MetroLabel metroLabel49;
        private MetroFramework.Controls.MetroTextBox Name_p;
        private MetroFramework.Controls.MetroTextBox Surname_p;
        private MetroFramework.Controls.MetroTile Cancel_edit_p;
        private MetroFramework.Controls.MetroTile Delete_p;
        private MetroFramework.Controls.MetroTile Edit_p;
        private MetroFramework.Controls.MetroTile New_p;
        private MetroFramework.Controls.MetroTile Save_p;
        private MetroFramework.Controls.MetroTile Exit;
        private MetroFramework.Controls.MetroTile btn_open_GenForm;
        private MetroFramework.Controls.MetroGrid Personal_grid;
        private Local_Db_DS local_Db_DS;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private Local_Db_DSTableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcompanyDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox ID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}