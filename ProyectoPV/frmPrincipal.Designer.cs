namespace ProyectoPV
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPool = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reditoMensualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reditoAcumuladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotasVencidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicializacionPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotasGeneradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotasPagadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotasPagadasATiempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deudoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaPrestamosPVDataSet = new ProyectoPV.SistemaPrestamosPVDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deudoresTableAdapter = new ProyectoPV.SistemaPrestamosPVDataSetTableAdapters.DeudoresTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnPagarUltimaCuota = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deudoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaPrestamosPVDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pool-Gestión de cobros";
            // 
            // dgvPool
            // 
            this.dgvPool.AllowUserToAddRows = false;
            this.dgvPool.AllowUserToDeleteRows = false;
            this.dgvPool.AllowUserToOrderColumns = true;
            this.dgvPool.AutoGenerateColumns = false;
            this.dgvPool.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPool.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPool.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPool.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.capitalDataGridViewTextBoxColumn,
            this.interesDataGridViewTextBoxColumn,
            this.reditoMensualDataGridViewTextBoxColumn,
            this.reditoAcumuladoDataGridViewTextBoxColumn,
            this.cuotasVencidasDataGridViewTextBoxColumn,
            this.fechaInicializacionPrestamoDataGridViewTextBoxColumn,
            this.ultimoPagoDataGridViewTextBoxColumn,
            this.cuotasPagadasDataGridViewTextBoxColumn,
            this.cuotasPagadasATiempoDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.CuotasGeneradas});
            this.dgvPool.DataSource = this.deudoresBindingSource;
            this.dgvPool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPool.EnableHeadersVisualStyles = false;
            this.dgvPool.Location = new System.Drawing.Point(0, 191);
            this.dgvPool.MultiSelect = false;
            this.dgvPool.Name = "dgvPool";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPool.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPool.RowHeadersVisible = false;
            this.dgvPool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPool.Size = new System.Drawing.Size(1444, 196);
            this.dgvPool.TabIndex = 15;
            this.dgvPool.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPool_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            this.capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            this.capitalDataGridViewTextBoxColumn.Width = 60;
            // 
            // interesDataGridViewTextBoxColumn
            // 
            this.interesDataGridViewTextBoxColumn.DataPropertyName = "Interes";
            this.interesDataGridViewTextBoxColumn.HeaderText = "% Interes";
            this.interesDataGridViewTextBoxColumn.Name = "interesDataGridViewTextBoxColumn";
            this.interesDataGridViewTextBoxColumn.Width = 70;
            // 
            // reditoMensualDataGridViewTextBoxColumn
            // 
            this.reditoMensualDataGridViewTextBoxColumn.DataPropertyName = "ReditoMensual";
            this.reditoMensualDataGridViewTextBoxColumn.HeaderText = "Redito Mensual";
            this.reditoMensualDataGridViewTextBoxColumn.Name = "reditoMensualDataGridViewTextBoxColumn";
            this.reditoMensualDataGridViewTextBoxColumn.Width = 80;
            // 
            // reditoAcumuladoDataGridViewTextBoxColumn
            // 
            this.reditoAcumuladoDataGridViewTextBoxColumn.DataPropertyName = "ReditoAcumulado";
            this.reditoAcumuladoDataGridViewTextBoxColumn.HeaderText = "Redito Acumulado";
            this.reditoAcumuladoDataGridViewTextBoxColumn.Name = "reditoAcumuladoDataGridViewTextBoxColumn";
            this.reditoAcumuladoDataGridViewTextBoxColumn.Width = 85;
            // 
            // cuotasVencidasDataGridViewTextBoxColumn
            // 
            this.cuotasVencidasDataGridViewTextBoxColumn.DataPropertyName = "CuotasVencidas";
            this.cuotasVencidasDataGridViewTextBoxColumn.HeaderText = "Cuotas Vencidas";
            this.cuotasVencidasDataGridViewTextBoxColumn.Name = "cuotasVencidasDataGridViewTextBoxColumn";
            this.cuotasVencidasDataGridViewTextBoxColumn.Width = 85;
            // 
            // fechaInicializacionPrestamoDataGridViewTextBoxColumn
            // 
            this.fechaInicializacionPrestamoDataGridViewTextBoxColumn.DataPropertyName = "FechaInicializacionPrestamo";
            this.fechaInicializacionPrestamoDataGridViewTextBoxColumn.HeaderText = "Fecha Inicialización Prestamo";
            this.fechaInicializacionPrestamoDataGridViewTextBoxColumn.Name = "fechaInicializacionPrestamoDataGridViewTextBoxColumn";
            this.fechaInicializacionPrestamoDataGridViewTextBoxColumn.Width = 102;
            // 
            // CuotasGeneradas
            // 
            this.CuotasGeneradas.DataPropertyName = "CuotasGeneradas";
            this.CuotasGeneradas.HeaderText = "Cuotas Generadas";
            this.CuotasGeneradas.Name = "CuotasGeneradas";
            // 
            // ultimoPagoDataGridViewTextBoxColumn
            // 
            this.ultimoPagoDataGridViewTextBoxColumn.DataPropertyName = "UltimoPago";
            this.ultimoPagoDataGridViewTextBoxColumn.HeaderText = "Ultimo Pago";
            this.ultimoPagoDataGridViewTextBoxColumn.Name = "ultimoPagoDataGridViewTextBoxColumn";
            this.ultimoPagoDataGridViewTextBoxColumn.Width = 80;
            // 
            // cuotasPagadasDataGridViewTextBoxColumn
            // 
            this.cuotasPagadasDataGridViewTextBoxColumn.DataPropertyName = "CuotasPagadas";
            this.cuotasPagadasDataGridViewTextBoxColumn.HeaderText = "Cuotas Pagadas";
            this.cuotasPagadasDataGridViewTextBoxColumn.Name = "cuotasPagadasDataGridViewTextBoxColumn";
            this.cuotasPagadasDataGridViewTextBoxColumn.Width = 85;
            // 
            // cuotasPagadasATiempoDataGridViewTextBoxColumn
            // 
            this.cuotasPagadasATiempoDataGridViewTextBoxColumn.DataPropertyName = "CuotasPagadasATiempo";
            this.cuotasPagadasATiempoDataGridViewTextBoxColumn.HeaderText = "Cuotas Pagadas ATiempo";
            this.cuotasPagadasATiempoDataGridViewTextBoxColumn.Name = "cuotasPagadasATiempoDataGridViewTextBoxColumn";
            this.cuotasPagadasATiempoDataGridViewTextBoxColumn.Width = 80;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "% Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.Width = 65;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.Width = 80;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 75;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            this.telefono2DataGridViewTextBoxColumn.Width = 75;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // deudoresBindingSource
            // 
            this.deudoresBindingSource.DataMember = "Deudores";
            this.deudoresBindingSource.DataSource = this.sistemaPrestamosPVDataSet;
            // 
            // sistemaPrestamosPVDataSet
            // 
            this.sistemaPrestamosPVDataSet.DataSetName = "SistemaPrestamosPVDataSet";
            this.sistemaPrestamosPVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnPagos);
            this.groupBox2.Controls.Add(this.btnPagarUltimaCuota);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(574, 126);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACCIONES";
            // 
            // deudoresTableAdapter
            // 
            this.deudoresTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(998, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(435, 175);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FORMULARIOS";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1444, 191);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // btnPagos
            // 
            this.btnPagos.BackgroundImage = global::ProyectoPV.Properties.Resources.iconfinder_payment_1954199;
            this.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPagos.Enabled = false;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(24, 36);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(139, 78);
            this.btnPagos.TabIndex = 11;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnPagarUltimaCuota
            // 
            this.btnPagarUltimaCuota.Enabled = false;
            this.btnPagarUltimaCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarUltimaCuota.Image = global::ProyectoPV.Properties.Resources.iconfinder_Pay_click_computer_dollar_money_currency_2992655;
            this.btnPagarUltimaCuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagarUltimaCuota.Location = new System.Drawing.Point(265, 36);
            this.btnPagarUltimaCuota.Name = "btnPagarUltimaCuota";
            this.btnPagarUltimaCuota.Size = new System.Drawing.Size(262, 78);
            this.btnPagarUltimaCuota.TabIndex = 12;
            this.btnPagarUltimaCuota.Text = "Pagar Ultima Cuota";
            this.btnPagarUltimaCuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagarUltimaCuota.UseVisualStyleBackColor = true;
            this.btnPagarUltimaCuota.Click += new System.EventHandler(this.btnPagarUltimaCuota_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImage = global::ProyectoPV.Properties.Resources.dinero;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1444, 235);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "";
            this.button2.AccessibleName = "";
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(165, 105);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 66);
            this.button2.TabIndex = 52;
            this.button2.Tag = "";
            this.button2.Text = "Usuarios";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleDescription = "";
            this.btnSalir.AccessibleName = "";
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::ProyectoPV.Properties.Resources.Logout_icon;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(290, 27);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 66);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.AccessibleName = "";
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ProyectoPV.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_23211;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(42, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 66);
            this.button1.TabIndex = 52;
            this.button1.Text = "Clientes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Prestamos - Bienvenido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deudoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaPrestamosPVDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPagarUltimaCuota;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private SistemaPrestamosPVDataSet sistemaPrestamosPVDataSet;
        private System.Windows.Forms.BindingSource deudoresBindingSource;
        private SistemaPrestamosPVDataSetTableAdapters.DeudoresTableAdapter deudoresTableAdapter;
        private System.Windows.Forms.DataGridView dgvPool;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reditoMensualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reditoAcumuladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotasVencidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicializacionPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotasGeneradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotasPagadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotasPagadasATiempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSalir;
    }
}