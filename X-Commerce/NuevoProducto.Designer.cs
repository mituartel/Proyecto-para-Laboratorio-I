namespace X_Commerce
{
    partial class NuevoProducto
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
            this.panelDeARRIBA = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDeABAJO = new System.Windows.Forms.Panel();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.labelCODIGO = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.labelCodeBARRA = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelDeDESCRIPCION = new System.Windows.Forms.Label();
            this.labelDePRECIO = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudStockInicial = new System.Windows.Forms.NumericUpDown();
            this.labelDeStockINICIAL = new System.Windows.Forms.Label();
            this.panelDeARRIBA.SuspendLayout();
            this.panelDeABAJO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeARRIBA
            // 
            this.panelDeARRIBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.panelDeARRIBA.Controls.Add(this.btnVolver);
            this.panelDeARRIBA.Controls.Add(this.label1);
            this.panelDeARRIBA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeARRIBA.Location = new System.Drawing.Point(0, 0);
            this.panelDeARRIBA.Name = "panelDeARRIBA";
            this.panelDeARRIBA.Size = new System.Drawing.Size(639, 100);
            this.panelDeARRIBA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nuevo Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDeABAJO
            // 
            this.panelDeABAJO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.panelDeABAJO.Controls.Add(this.btnGuardar);
            this.panelDeABAJO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeABAJO.Location = new System.Drawing.Point(0, 426);
            this.panelDeABAJO.Name = "panelDeABAJO";
            this.panelDeABAJO.Size = new System.Drawing.Size(639, 100);
            this.panelDeABAJO.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVolver.IconColor = System.Drawing.Color.Transparent;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 35;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(530, 0);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 52);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(214)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardar.IconColor = System.Drawing.Color.Transparent;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 35;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(242, 27);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 52);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelCODIGO
            // 
            this.labelCODIGO.AutoSize = true;
            this.labelCODIGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelCODIGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCODIGO.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelCODIGO.ForeColor = System.Drawing.Color.Black;
            this.labelCODIGO.Location = new System.Drawing.Point(36, 230);
            this.labelCODIGO.Name = "labelCODIGO";
            this.labelCODIGO.Size = new System.Drawing.Size(59, 18);
            this.labelCODIGO.TabIndex = 2;
            this.labelCODIGO.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(231, 230);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(184, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(232, 176);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(184, 24);
            this.txtCodigoBarra.TabIndex = 5;
            // 
            // labelCodeBARRA
            // 
            this.labelCodeBARRA.AutoSize = true;
            this.labelCodeBARRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCodeBARRA.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelCodeBARRA.ForeColor = System.Drawing.Color.Black;
            this.labelCodeBARRA.Location = new System.Drawing.Point(36, 182);
            this.labelCodeBARRA.Name = "labelCodeBARRA";
            this.labelCodeBARRA.Size = new System.Drawing.Size(122, 18);
            this.labelCodeBARRA.TabIndex = 4;
            this.labelCodeBARRA.Text = "Codigo de barra";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(231, 129);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(185, 24);
            this.txtDescripcion.TabIndex = 7;
            // 
            // labelDeDESCRIPCION
            // 
            this.labelDeDESCRIPCION.AutoSize = true;
            this.labelDeDESCRIPCION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDeDESCRIPCION.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelDeDESCRIPCION.ForeColor = System.Drawing.Color.Black;
            this.labelDeDESCRIPCION.Location = new System.Drawing.Point(36, 129);
            this.labelDeDESCRIPCION.Name = "labelDeDESCRIPCION";
            this.labelDeDESCRIPCION.Size = new System.Drawing.Size(93, 18);
            this.labelDeDESCRIPCION.TabIndex = 6;
            this.labelDeDESCRIPCION.Text = "Descripción";
            // 
            // labelDePRECIO
            // 
            this.labelDePRECIO.AutoSize = true;
            this.labelDePRECIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDePRECIO.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelDePRECIO.ForeColor = System.Drawing.Color.Black;
            this.labelDePRECIO.Location = new System.Drawing.Point(41, 276);
            this.labelDePRECIO.Name = "labelDePRECIO";
            this.labelDePRECIO.Size = new System.Drawing.Size(54, 18);
            this.labelDePRECIO.TabIndex = 8;
            this.labelDePRECIO.Text = "Precio";
            // 
            // nudPrecio
            // 
            this.nudPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecio.Location = new System.Drawing.Point(231, 276);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(184, 24);
            this.nudPrecio.TabIndex = 9;
            // 
            // nudStockInicial
            // 
            this.nudStockInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockInicial.Location = new System.Drawing.Point(231, 323);
            this.nudStockInicial.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nudStockInicial.Name = "nudStockInicial";
            this.nudStockInicial.Size = new System.Drawing.Size(184, 24);
            this.nudStockInicial.TabIndex = 11;
            // 
            // labelDeStockINICIAL
            // 
            this.labelDeStockINICIAL.AutoSize = true;
            this.labelDeStockINICIAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDeStockINICIAL.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelDeStockINICIAL.ForeColor = System.Drawing.Color.Black;
            this.labelDeStockINICIAL.Location = new System.Drawing.Point(41, 323);
            this.labelDeStockINICIAL.Name = "labelDeStockINICIAL";
            this.labelDeStockINICIAL.Size = new System.Drawing.Size(93, 18);
            this.labelDeStockINICIAL.TabIndex = 10;
            this.labelDeStockINICIAL.Text = "Stock Inicial";
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(639, 526);
            this.Controls.Add(this.nudStockInicial);
            this.Controls.Add(this.labelDeStockINICIAL);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.labelDePRECIO);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelDeDESCRIPCION);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.labelCodeBARRA);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelCODIGO);
            this.Controls.Add(this.panelDeABAJO);
            this.Controls.Add(this.panelDeARRIBA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.panelDeARRIBA.ResumeLayout(false);
            this.panelDeARRIBA.PerformLayout();
            this.panelDeABAJO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDeARRIBA;
        private System.Windows.Forms.Panel panelDeABAJO;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label labelCODIGO;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label labelCodeBARRA;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelDeDESCRIPCION;
        private System.Windows.Forms.Label labelDePRECIO;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudStockInicial;
        private System.Windows.Forms.Label labelDeStockINICIAL;
        private System.Windows.Forms.Label label1;
    }
}