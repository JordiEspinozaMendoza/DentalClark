namespace Dental_Clark_V1
{
    partial class home
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
            this.txtName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConsultInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtIncharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvConsults = new System.Windows.Forms.DataGridView();
            this.register = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtConsultID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.ComboBox();
            this.patientstableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new Dental_Clark_V1.DataSet3();
            this.patientstableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Dental_Clark_V1.DataSet2();
            this.dataSet1 = new Dental_Clark_V1.DataSet1();
            this.patientstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patients_tableTableAdapter = new Dental_Clark_V1.DataSet1TableAdapters.patients_tableTableAdapter();
            this.patients_tableTableAdapter1 = new Dental_Clark_V1.DataSet2TableAdapters.patients_tableTableAdapter();
            this.patients_tableTableAdapter2 = new Dental_Clark_V1.DataSet3TableAdapters.patients_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientstableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientstableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientstableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.txtName.Location = new System.Drawing.Point(13, 161);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 19);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Nombre del paciente";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.panel1.Location = new System.Drawing.Point(17, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.panel2.Location = new System.Drawing.Point(17, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 1);
            this.panel2.TabIndex = 17;
            // 
            // txtConsultInfo
            // 
            this.txtConsultInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.txtConsultInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtConsultInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.txtConsultInfo.Location = new System.Drawing.Point(117, 251);
            this.txtConsultInfo.Multiline = true;
            this.txtConsultInfo.Name = "txtConsultInfo";
            this.txtConsultInfo.Size = new System.Drawing.Size(350, 23);
            this.txtConsultInfo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(13, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Asunto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.panel3.Location = new System.Drawing.Point(17, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 1);
            this.panel3.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.txtPhone.Location = new System.Drawing.Point(117, 346);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(350, 23);
            this.txtPhone.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.label3.Location = new System.Drawing.Point(13, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Teléfono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.panel4.Location = new System.Drawing.Point(17, 467);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 1);
            this.panel4.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.txtEmail.Location = new System.Drawing.Point(117, 429);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(350, 23);
            this.txtEmail.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.label5.Location = new System.Drawing.Point(13, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Correo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.panel5.Location = new System.Drawing.Point(17, 553);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 1);
            this.panel5.TabIndex = 26;
            // 
            // txtIncharge
            // 
            this.txtIncharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.txtIncharge.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtIncharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.txtIncharge.Location = new System.Drawing.Point(117, 515);
            this.txtIncharge.Multiline = true;
            this.txtIncharge.Name = "txtIncharge";
            this.txtIncharge.Size = new System.Drawing.Size(349, 23);
            this.txtIncharge.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.label6.Location = new System.Drawing.Point(13, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Encargado";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvConsults
            // 
            this.dgvConsults.AllowUserToAddRows = false;
            this.dgvConsults.AllowUserToDeleteRows = false;
            this.dgvConsults.AllowUserToResizeColumns = false;
            this.dgvConsults.AllowUserToResizeRows = false;
            this.dgvConsults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.dgvConsults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsults.EnableHeadersVisualStyles = false;
            this.dgvConsults.GridColor = System.Drawing.Color.White;
            this.dgvConsults.Location = new System.Drawing.Point(503, 162);
            this.dgvConsults.MultiSelect = false;
            this.dgvConsults.Name = "dgvConsults";
            this.dgvConsults.ReadOnly = true;
            this.dgvConsults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsults.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvConsults.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsults.Size = new System.Drawing.Size(511, 423);
            this.dgvConsults.TabIndex = 27;
            this.dgvConsults.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConsults_RowHeaderMouseClick);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.register.Location = new System.Drawing.Point(17, 633);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(131, 33);
            this.register.TabIndex = 28;
            this.register.Text = "REGISTRAR";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.update.Location = new System.Drawing.Point(587, 633);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(131, 33);
            this.update.TabIndex = 31;
            this.update.Text = "ACTUALIZAR";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.button2.Location = new System.Drawing.Point(733, 633);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 33);
            this.button2.TabIndex = 32;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.btnClear.Location = new System.Drawing.Point(1338, 714);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 33);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "LIMPIAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtConsultID
            // 
            this.txtConsultID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.txtConsultID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultID.Enabled = false;
            this.txtConsultID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.txtConsultID.Location = new System.Drawing.Point(147, 76);
            this.txtConsultID.Multiline = true;
            this.txtConsultID.Name = "txtConsultID";
            this.txtConsultID.ReadOnly = true;
            this.txtConsultID.Size = new System.Drawing.Size(203, 18);
            this.txtConsultID.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.label7.Location = new System.Drawing.Point(17, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Num. consulta";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.txtDate.Location = new System.Drawing.Point(147, 105);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(203, 18);
            this.txtDate.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.label8.Location = new System.Drawing.Point(18, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Fecha consulta";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.panel7.Location = new System.Drawing.Point(514, 143);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(450, 1);
            this.panel7.TabIndex = 41;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.txtSearch.Location = new System.Drawing.Point(610, 105);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 23);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.label9.Location = new System.Drawing.Point(510, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Busqueda";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.txtUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.txtUsername.FormattingEnabled = true;
            this.txtUsername.Location = new System.Drawing.Point(204, 161);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(263, 21);
            this.txtUsername.TabIndex = 42;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // patientstableBindingSource2
            // 
            this.patientstableBindingSource2.DataMember = "patients_table";
            this.patientstableBindingSource2.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientstableBindingSource1
            // 
            this.patientstableBindingSource1.DataMember = "patients_table";
            this.patientstableBindingSource1.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientstableBindingSource
            // 
            this.patientstableBindingSource.DataMember = "patients_table";
            this.patientstableBindingSource.DataSource = this.dataSet1;
            // 
            // patients_tableTableAdapter
            // 
            this.patients_tableTableAdapter.ClearBeforeFill = true;
            // 
            // patients_tableTableAdapter1
            // 
            this.patients_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // patients_tableTableAdapter2
            // 
            this.patients_tableTableAdapter2.ClearBeforeFill = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1084, 773);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConsultID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.register);
            this.Controls.Add(this.dgvConsults);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtIncharge);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConsultInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(242)))), ((int)(((byte)(194)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.DoubleClick += new System.EventHandler(this.home_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientstableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientstableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientstableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtConsultInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtIncharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvConsults;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtConsultID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtUsername;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource patientstableBindingSource;
        private DataSet1TableAdapters.patients_tableTableAdapter patients_tableTableAdapter;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource patientstableBindingSource1;
        private DataSet2TableAdapters.patients_tableTableAdapter patients_tableTableAdapter1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource patientstableBindingSource2;
        private DataSet3TableAdapters.patients_tableTableAdapter patients_tableTableAdapter2;
    }
}