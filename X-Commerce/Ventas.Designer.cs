namespace X_Commerce
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHEAD = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblElCLIENTE = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.TextBox();
            this.lblFechaDeLaFACTURA = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.cmbFacturas = new System.Windows.Forms.ComboBox();
            this.lblNumFACTURA = new System.Windows.Forms.Label();
            this.pnlBuscarPRODUCTOS = new System.Windows.Forms.Panel();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.nudSubTotal = new System.Windows.Forms.NumericUpDown();
            this.labelSubTOTAL = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelLaCANTIDAD = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.labelElPRECIO = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelLaDESCRIPCION = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labelElCODIGO = new System.Windows.Forms.Label();
            this.panelDeLosTOTALES = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelDelTOTAL = new System.Windows.Forms.Label();
            this.labelPORCIENTO = new System.Windows.Forms.Label();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.labelElDESCUENTO = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTOtal = new System.Windows.Forms.Label();
            this.btnCambiarCantidad = new FontAwesome.Sharp.IconButton();
            this.btnFacturar = new FontAwesome.Sharp.IconButton();
            this.btnEliminarItem = new FontAwesome.Sharp.IconButton();
            this.pnlDelMedio = new System.Windows.Forms.Panel();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.pnlHEAD.SuspendLayout();
            this.pnlBuscarPRODUCTOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panelDeLosTOTALES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            this.pnlDelMedio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHEAD
            // 
            this.pnlHEAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.pnlHEAD.Controls.Add(this.label1);
            this.pnlHEAD.Controls.Add(this.btnNuevoCliente);
            this.pnlHEAD.Controls.Add(this.btnBuscarCliente);
            this.pnlHEAD.Controls.Add(this.txtNombreCliente);
            this.pnlHEAD.Controls.Add(this.txtCodigoCliente);
            this.pnlHEAD.Controls.Add(this.lblElCLIENTE);
            this.pnlHEAD.Controls.Add(this.dtpFecha);
            this.pnlHEAD.Controls.Add(this.lblFechaDeLaFACTURA);
            this.pnlHEAD.Controls.Add(this.txtNumeroFactura);
            this.pnlHEAD.Controls.Add(this.cmbFacturas);
            this.pnlHEAD.Controls.Add(this.lblNumFACTURA);
            this.pnlHEAD.Controls.Add(this.pnlBuscarPRODUCTOS);
            this.pnlHEAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHEAD.Location = new System.Drawing.Point(0, 0);
            this.pnlHEAD.Name = "pnlHEAD";
            this.pnlHEAD.Size = new System.Drawing.Size(1040, 255);
            this.pnlHEAD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo de Factura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNuevoCliente.IconColor = System.Drawing.Color.White;
            this.btnNuevoCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoCliente.IconSize = 35;
            this.btnNuevoCliente.Location = new System.Drawing.Point(937, 0);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(75, 60);
            this.btnNuevoCliente.TabIndex = 13;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(856, 7);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 35);
            this.btnBuscarCliente.TabIndex = 12;
            this.btnBuscarCliente.Text = "LookUp";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(453, 63);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(337, 24);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Enabled = false;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(536, 30);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(184, 24);
            this.txtCodigoCliente.TabIndex = 10;
            // 
            // lblElCLIENTE
            // 
            this.lblElCLIENTE.AutoSize = true;
            this.lblElCLIENTE.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblElCLIENTE.ForeColor = System.Drawing.Color.White;
            this.lblElCLIENTE.Location = new System.Drawing.Point(451, 34);
            this.lblElCLIENTE.Name = "lblElCLIENTE";
            this.lblElCLIENTE.Size = new System.Drawing.Size(59, 18);
            this.lblElCLIENTE.TabIndex = 9;
            this.lblElCLIENTE.Text = "Cliente";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(154, 96);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(158, 24);
            this.dtpFecha.TabIndex = 8;
            // 
            // lblFechaDeLaFACTURA
            // 
            this.lblFechaDeLaFACTURA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaDeLaFACTURA.AutoSize = true;
            this.lblFechaDeLaFACTURA.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblFechaDeLaFACTURA.ForeColor = System.Drawing.Color.White;
            this.lblFechaDeLaFACTURA.Location = new System.Drawing.Point(38, 96);
            this.lblFechaDeLaFACTURA.Name = "lblFechaDeLaFACTURA";
            this.lblFechaDeLaFACTURA.Size = new System.Drawing.Size(51, 18);
            this.lblFechaDeLaFACTURA.TabIndex = 7;
            this.lblFechaDeLaFACTURA.Text = "Fecha";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumeroFactura.Enabled = false;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(160, 30);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(260, 24);
            this.txtNumeroFactura.TabIndex = 6;
            // 
            // cmbFacturas
            // 
            this.cmbFacturas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbFacturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFacturas.FormattingEnabled = true;
            this.cmbFacturas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFacturas.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbFacturas.Location = new System.Drawing.Point(160, 60);
            this.cmbFacturas.Name = "cmbFacturas";
            this.cmbFacturas.Size = new System.Drawing.Size(55, 25);
            this.cmbFacturas.TabIndex = 5;
            // 
            // lblNumFACTURA
            // 
            this.lblNumFACTURA.AutoSize = true;
            this.lblNumFACTURA.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblNumFACTURA.ForeColor = System.Drawing.Color.White;
            this.lblNumFACTURA.Location = new System.Drawing.Point(33, 30);
            this.lblNumFACTURA.Name = "lblNumFACTURA";
            this.lblNumFACTURA.Size = new System.Drawing.Size(121, 18);
            this.lblNumFACTURA.TabIndex = 4;
            this.lblNumFACTURA.Text = "Numero Factura";
            this.lblNumFACTURA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBuscarPRODUCTOS
            // 
            this.pnlBuscarPRODUCTOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.pnlBuscarPRODUCTOS.Controls.Add(this.btnAgregarProducto);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.nudSubTotal);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.labelSubTOTAL);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.nudCantidad);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.labelLaCANTIDAD);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.txtPrecio);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.labelElPRECIO);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.txtDescripcion);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.labelLaDESCRIPCION);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.txtCodigo);
            this.pnlBuscarPRODUCTOS.Controls.Add(this.labelElCODIGO);
            this.pnlBuscarPRODUCTOS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBuscarPRODUCTOS.Location = new System.Drawing.Point(0, 179);
            this.pnlBuscarPRODUCTOS.Name = "pnlBuscarPRODUCTOS";
            this.pnlBuscarPRODUCTOS.Size = new System.Drawing.Size(1040, 76);
            this.pnlBuscarPRODUCTOS.TabIndex = 2;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.IconSize = 30;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(891, 38);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(118, 39);
            this.btnAgregarProducto.TabIndex = 10;
            this.btnAgregarProducto.Text = "       Agregar";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // nudSubTotal
            // 
            this.nudSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSubTotal.Enabled = false;
            this.nudSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSubTotal.Location = new System.Drawing.Point(679, 49);
            this.nudSubTotal.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nudSubTotal.Name = "nudSubTotal";
            this.nudSubTotal.Size = new System.Drawing.Size(99, 24);
            this.nudSubTotal.TabIndex = 9;
            // 
            // labelSubTOTAL
            // 
            this.labelSubTOTAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubTOTAL.AutoSize = true;
            this.labelSubTOTAL.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelSubTOTAL.ForeColor = System.Drawing.Color.White;
            this.labelSubTOTAL.Location = new System.Drawing.Point(691, 19);
            this.labelSubTOTAL.Name = "labelSubTOTAL";
            this.labelSubTOTAL.Size = new System.Drawing.Size(76, 18);
            this.labelSubTOTAL.TabIndex = 8;
            this.labelSubTOTAL.Text = "Sub-Total";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(804, 47);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.ReadOnly = true;
            this.nudCantidad.Size = new System.Drawing.Size(72, 24);
            this.nudCantidad.TabIndex = 7;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // labelLaCANTIDAD
            // 
            this.labelLaCANTIDAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLaCANTIDAD.AutoSize = true;
            this.labelLaCANTIDAD.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelLaCANTIDAD.ForeColor = System.Drawing.Color.White;
            this.labelLaCANTIDAD.Location = new System.Drawing.Point(805, 19);
            this.labelLaCANTIDAD.Name = "labelLaCANTIDAD";
            this.labelLaCANTIDAD.Size = new System.Drawing.Size(71, 18);
            this.labelLaCANTIDAD.TabIndex = 6;
            this.labelLaCANTIDAD.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(563, 46);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 24);
            this.txtPrecio.TabIndex = 5;
            // 
            // labelElPRECIO
            // 
            this.labelElPRECIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelElPRECIO.AutoSize = true;
            this.labelElPRECIO.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelElPRECIO.ForeColor = System.Drawing.Color.White;
            this.labelElPRECIO.Location = new System.Drawing.Point(578, 19);
            this.labelElPRECIO.Name = "labelElPRECIO";
            this.labelElPRECIO.Size = new System.Drawing.Size(54, 18);
            this.labelElPRECIO.TabIndex = 4;
            this.labelElPRECIO.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(119, 45);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(421, 24);
            this.txtDescripcion.TabIndex = 3;
            // 
            // labelLaDESCRIPCION
            // 
            this.labelLaDESCRIPCION.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLaDESCRIPCION.AutoSize = true;
            this.labelLaDESCRIPCION.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelLaDESCRIPCION.ForeColor = System.Drawing.Color.White;
            this.labelLaDESCRIPCION.Location = new System.Drawing.Point(282, 19);
            this.labelLaDESCRIPCION.Name = "labelLaDESCRIPCION";
            this.labelLaDESCRIPCION.Size = new System.Drawing.Size(93, 18);
            this.labelLaDESCRIPCION.TabIndex = 2;
            this.labelLaDESCRIPCION.Text = "Descripción";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(12, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(85, 24);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // labelElCODIGO
            // 
            this.labelElCODIGO.AutoSize = true;
            this.labelElCODIGO.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelElCODIGO.ForeColor = System.Drawing.Color.White;
            this.labelElCODIGO.Location = new System.Drawing.Point(19, 19);
            this.labelElCODIGO.Name = "labelElCODIGO";
            this.labelElCODIGO.Size = new System.Drawing.Size(59, 18);
            this.labelElCODIGO.TabIndex = 0;
            this.labelElCODIGO.Text = "Código";
            // 
            // panelDeLosTOTALES
            // 
            this.panelDeLosTOTALES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.panelDeLosTOTALES.Controls.Add(this.txtTotal);
            this.panelDeLosTOTALES.Controls.Add(this.labelDelTOTAL);
            this.panelDeLosTOTALES.Controls.Add(this.labelPORCIENTO);
            this.panelDeLosTOTALES.Controls.Add(this.nudDescuento);
            this.panelDeLosTOTALES.Controls.Add(this.labelElDESCUENTO);
            this.panelDeLosTOTALES.Controls.Add(this.txtSubTotal);
            this.panelDeLosTOTALES.Controls.Add(this.lblSubTOtal);
            this.panelDeLosTOTALES.Controls.Add(this.btnCambiarCantidad);
            this.panelDeLosTOTALES.Controls.Add(this.btnFacturar);
            this.panelDeLosTOTALES.Controls.Add(this.btnEliminarItem);
            this.panelDeLosTOTALES.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeLosTOTALES.Location = new System.Drawing.Point(0, 468);
            this.panelDeLosTOTALES.Margin = new System.Windows.Forms.Padding(2);
            this.panelDeLosTOTALES.Name = "panelDeLosTOTALES";
            this.panelDeLosTOTALES.Size = new System.Drawing.Size(1040, 172);
            this.panelDeLosTOTALES.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(794, 110);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(164, 26);
            this.txtTotal.TabIndex = 10;
            // 
            // labelDelTOTAL
            // 
            this.labelDelTOTAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDelTOTAL.AutoSize = true;
            this.labelDelTOTAL.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelTOTAL.ForeColor = System.Drawing.Color.White;
            this.labelDelTOTAL.Location = new System.Drawing.Point(707, 110);
            this.labelDelTOTAL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDelTOTAL.Name = "labelDelTOTAL";
            this.labelDelTOTAL.Size = new System.Drawing.Size(42, 18);
            this.labelDelTOTAL.TabIndex = 9;
            this.labelDelTOTAL.Text = "Total";
            // 
            // labelPORCIENTO
            // 
            this.labelPORCIENTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPORCIENTO.AutoSize = true;
            this.labelPORCIENTO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPORCIENTO.ForeColor = System.Drawing.Color.White;
            this.labelPORCIENTO.Location = new System.Drawing.Point(898, 72);
            this.labelPORCIENTO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPORCIENTO.Name = "labelPORCIENTO";
            this.labelPORCIENTO.Size = new System.Drawing.Size(33, 19);
            this.labelPORCIENTO.TabIndex = 8;
            this.labelPORCIENTO.Text = "[%]";
            // 
            // nudDescuento
            // 
            this.nudDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDescuento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudDescuento.Location = new System.Drawing.Point(795, 70);
            this.nudDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.ReadOnly = true;
            this.nudDescuento.Size = new System.Drawing.Size(90, 26);
            this.nudDescuento.TabIndex = 7;
            this.nudDescuento.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
            // 
            // labelElDESCUENTO
            // 
            this.labelElDESCUENTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelElDESCUENTO.AutoSize = true;
            this.labelElDESCUENTO.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElDESCUENTO.ForeColor = System.Drawing.Color.White;
            this.labelElDESCUENTO.Location = new System.Drawing.Point(703, 71);
            this.labelElDESCUENTO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelElDESCUENTO.Name = "labelElDESCUENTO";
            this.labelElDESCUENTO.Size = new System.Drawing.Size(87, 18);
            this.labelElDESCUENTO.TabIndex = 6;
            this.labelElDESCUENTO.Text = "Descuento";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(794, 25);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(164, 26);
            this.txtSubTotal.TabIndex = 5;
            // 
            // lblSubTOtal
            // 
            this.lblSubTOtal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTOtal.AutoSize = true;
            this.lblSubTOtal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTOtal.ForeColor = System.Drawing.Color.White;
            this.lblSubTOtal.Location = new System.Drawing.Point(703, 25);
            this.lblSubTOtal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTOtal.Name = "lblSubTOtal";
            this.lblSubTOtal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubTOtal.Size = new System.Drawing.Size(75, 18);
            this.lblSubTOtal.TabIndex = 4;
            this.lblSubTOtal.Text = "Sub-Total";
            // 
            // btnCambiarCantidad
            // 
            this.btnCambiarCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCambiarCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.btnCambiarCantidad.FlatAppearance.BorderSize = 0;
            this.btnCambiarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarCantidad.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCambiarCantidad.ForeColor = System.Drawing.Color.White;
            this.btnCambiarCantidad.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCambiarCantidad.IconColor = System.Drawing.Color.White;
            this.btnCambiarCantidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarCantidad.IconSize = 33;
            this.btnCambiarCantidad.Location = new System.Drawing.Point(250, 25);
            this.btnCambiarCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarCantidad.Name = "btnCambiarCantidad";
            this.btnCambiarCantidad.Size = new System.Drawing.Size(98, 62);
            this.btnCambiarCantidad.TabIndex = 3;
            this.btnCambiarCantidad.Text = "Cambiar Cantidad";
            this.btnCambiarCantidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCambiarCantidad.UseVisualStyleBackColor = false;
            this.btnCambiarCantidad.Click += new System.EventHandler(this.btnActivarCantidad_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFacturar.IconColor = System.Drawing.Color.White;
            this.btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturar.IconSize = 33;
            this.btnFacturar.Location = new System.Drawing.Point(259, 91);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(77, 29);
            this.btnFacturar.TabIndex = 1;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.btnEliminarItem.FlatAppearance.BorderSize = 0;
            this.btnEliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarItem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarItem.ForeColor = System.Drawing.Color.White;
            this.btnEliminarItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminarItem.IconColor = System.Drawing.Color.White;
            this.btnEliminarItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarItem.IconSize = 33;
            this.btnEliminarItem.Location = new System.Drawing.Point(154, 25);
            this.btnEliminarItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(101, 101);
            this.btnEliminarItem.TabIndex = 0;
            this.btnEliminarItem.Text = "Eliminar Item";
            this.btnEliminarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarItem.UseVisualStyleBackColor = false;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // pnlDelMedio
            // 
            this.pnlDelMedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlDelMedio.Controls.Add(this.dgvVentas);
            this.pnlDelMedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDelMedio.Location = new System.Drawing.Point(0, 255);
            this.pnlDelMedio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDelMedio.Name = "pnlDelMedio";
            this.pnlDelMedio.Size = new System.Drawing.Size(1040, 213);
            this.pnlDelMedio.TabIndex = 2;
            // 
            // dgvVentas
            // 
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeight = 30;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.DeepPink;
            this.dgvVentas.Location = new System.Drawing.Point(-2, 2);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(1040, 213);
            this.dgvVentas.TabIndex = 1;
            this.dgvVentas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_RowEnter);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.pnlDelMedio);
            this.Controls.Add(this.panelDeLosTOTALES);
            this.Controls.Add(this.pnlHEAD);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.pnlHEAD.ResumeLayout(false);
            this.pnlHEAD.PerformLayout();
            this.pnlBuscarPRODUCTOS.ResumeLayout(false);
            this.pnlBuscarPRODUCTOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panelDeLosTOTALES.ResumeLayout(false);
            this.panelDeLosTOTALES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            this.pnlDelMedio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHEAD;
        private System.Windows.Forms.Panel pnlBuscarPRODUCTOS;
        private System.Windows.Forms.ComboBox cmbFacturas;
        private System.Windows.Forms.Label lblNumFACTURA;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox dtpFecha;
        private System.Windows.Forms.Label lblFechaDeLaFACTURA;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblElCLIENTE;
        private FontAwesome.Sharp.IconButton btnNuevoCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label labelElCODIGO;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelLaDESCRIPCION;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labelSubTOTAL;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label labelLaCANTIDAD;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label labelElPRECIO;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private System.Windows.Forms.NumericUpDown nudSubTotal;
        private System.Windows.Forms.Panel panelDeLosTOTALES;
        private FontAwesome.Sharp.IconButton btnEliminarItem;
        private FontAwesome.Sharp.IconButton btnFacturar;
        private FontAwesome.Sharp.IconButton btnCambiarCantidad;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTOtal;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label labelElDESCUENTO;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label labelDelTOTAL;
        private System.Windows.Forms.Label labelPORCIENTO;
        private System.Windows.Forms.Panel pnlDelMedio;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label1;
    }
}