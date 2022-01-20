namespace X_Commerce
{
    partial class Facturar
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
            this.labelTitleFORMULARY = new System.Windows.Forms.Label();
            this.iconPictureBoxTITLE = new FontAwesome.Sharp.IconPictureBox();
            this.panelDeABAJO = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnFacturar = new FontAwesome.Sharp.IconButton();
            this.nudTotalPagar = new System.Windows.Forms.NumericUpDown();
            this.labelTotalPAGAR = new System.Windows.Forms.Label();
            this.nudPagarCon = new System.Windows.Forms.NumericUpDown();
            this.labelPagarCON = new System.Windows.Forms.Label();
            this.labelFormaDelPAGO = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.labelVUELTO = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.panelDeARRIBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxTITLE)).BeginInit();
            this.panelDeABAJO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagarCon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeARRIBA
            // 
            this.panelDeARRIBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelDeARRIBA.Controls.Add(this.labelTitleFORMULARY);
            this.panelDeARRIBA.Controls.Add(this.iconPictureBoxTITLE);
            this.panelDeARRIBA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeARRIBA.Location = new System.Drawing.Point(0, 0);
            this.panelDeARRIBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDeARRIBA.Name = "panelDeARRIBA";
            this.panelDeARRIBA.Size = new System.Drawing.Size(631, 71);
            this.panelDeARRIBA.TabIndex = 0;
            // 
            // labelTitleFORMULARY
            // 
            this.labelTitleFORMULARY.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleFORMULARY.ForeColor = System.Drawing.Color.White;
            this.labelTitleFORMULARY.Location = new System.Drawing.Point(287, 12);
            this.labelTitleFORMULARY.Name = "labelTitleFORMULARY";
            this.labelTitleFORMULARY.Size = new System.Drawing.Size(259, 44);
            this.labelTitleFORMULARY.TabIndex = 5;
            this.labelTitleFORMULARY.Text = "Facturar";
            this.labelTitleFORMULARY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPictureBoxTITLE
            // 
            this.iconPictureBoxTITLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconPictureBoxTITLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxTITLE.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconPictureBoxTITLE.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxTITLE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxTITLE.IconSize = 44;
            this.iconPictureBoxTITLE.Location = new System.Drawing.Point(218, 10);
            this.iconPictureBoxTITLE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBoxTITLE.Name = "iconPictureBoxTITLE";
            this.iconPictureBoxTITLE.Size = new System.Drawing.Size(53, 44);
            this.iconPictureBoxTITLE.TabIndex = 4;
            this.iconPictureBoxTITLE.TabStop = false;
            // 
            // panelDeABAJO
            // 
            this.panelDeABAJO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelDeABAJO.Controls.Add(this.btnCancelar);
            this.panelDeABAJO.Controls.Add(this.btnFacturar);
            this.panelDeABAJO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeABAJO.Location = new System.Drawing.Point(0, 442);
            this.panelDeABAJO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDeABAJO.Name = "panelDeABAJO";
            this.panelDeABAJO.Size = new System.Drawing.Size(631, 100);
            this.panelDeABAJO.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btnCancelar.IconColor = System.Drawing.Color.DeepPink;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 35;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(359, 18);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(219, 64);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnFacturar.IconColor = System.Drawing.Color.DeepPink;
            this.btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturar.IconSize = 35;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(88, 18);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(217, 64);
            this.btnFacturar.TabIndex = 9;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // nudTotalPagar
            // 
            this.nudTotalPagar.Enabled = false;
            this.nudTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotalPagar.Location = new System.Drawing.Point(327, 176);
            this.nudTotalPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTotalPagar.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.nudTotalPagar.Name = "nudTotalPagar";
            this.nudTotalPagar.Size = new System.Drawing.Size(249, 34);
            this.nudTotalPagar.TabIndex = 5;
            this.nudTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotalPAGAR
            // 
            this.labelTotalPAGAR.AutoSize = true;
            this.labelTotalPAGAR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPAGAR.ForeColor = System.Drawing.Color.White;
            this.labelTotalPAGAR.Location = new System.Drawing.Point(59, 186);
            this.labelTotalPAGAR.Name = "labelTotalPAGAR";
            this.labelTotalPAGAR.Size = new System.Drawing.Size(168, 28);
            this.labelTotalPAGAR.TabIndex = 4;
            this.labelTotalPAGAR.Text = "Total a pagar";
            // 
            // nudPagarCon
            // 
            this.nudPagarCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPagarCon.Location = new System.Drawing.Point(327, 228);
            this.nudPagarCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPagarCon.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.nudPagarCon.Name = "nudPagarCon";
            this.nudPagarCon.Size = new System.Drawing.Size(249, 34);
            this.nudPagarCon.TabIndex = 7;
            this.nudPagarCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPagarCon.ValueChanged += new System.EventHandler(this.nudPagarCon_ValueChanged);
            // 
            // labelPagarCON
            // 
            this.labelPagarCON.AutoSize = true;
            this.labelPagarCON.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagarCON.ForeColor = System.Drawing.Color.White;
            this.labelPagarCON.Location = new System.Drawing.Point(59, 238);
            this.labelPagarCON.Name = "labelPagarCON";
            this.labelPagarCON.Size = new System.Drawing.Size(124, 28);
            this.labelPagarCON.TabIndex = 6;
            this.labelPagarCON.Text = "Paga con";
            // 
            // labelFormaDelPAGO
            // 
            this.labelFormaDelPAGO.AutoSize = true;
            this.labelFormaDelPAGO.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormaDelPAGO.ForeColor = System.Drawing.Color.White;
            this.labelFormaDelPAGO.Location = new System.Drawing.Point(59, 121);
            this.labelFormaDelPAGO.Name = "labelFormaDelPAGO";
            this.labelFormaDelPAGO.Size = new System.Drawing.Size(194, 28);
            this.labelFormaDelPAGO.TabIndex = 8;
            this.labelFormaDelPAGO.Text = "Forma de pago";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Cuenta Corriente"});
            this.cmbFormaPago.Location = new System.Drawing.Point(327, 121);
            this.cmbFormaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(249, 37);
            this.cmbFormaPago.TabIndex = 9;
            this.cmbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPago_SelectedIndexChanged);
            // 
            // labelVUELTO
            // 
            this.labelVUELTO.AutoSize = true;
            this.labelVUELTO.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVUELTO.ForeColor = System.Drawing.Color.White;
            this.labelVUELTO.Location = new System.Drawing.Point(287, 343);
            this.labelVUELTO.Name = "labelVUELTO";
            this.labelVUELTO.Size = new System.Drawing.Size(86, 28);
            this.labelVUELTO.TabIndex = 10;
            this.labelVUELTO.Text = "Vuelto";
            // 
            // txtVuelto
            // 
            this.txtVuelto.Enabled = false;
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(204, 388);
            this.txtVuelto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(249, 34);
            this.txtVuelto.TabIndex = 11;
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(631, 542);
            this.Controls.Add(this.txtVuelto);
            this.Controls.Add(this.labelVUELTO);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.labelFormaDelPAGO);
            this.Controls.Add(this.nudPagarCon);
            this.Controls.Add(this.labelPagarCON);
            this.Controls.Add(this.nudTotalPagar);
            this.Controls.Add(this.labelTotalPAGAR);
            this.Controls.Add(this.panelDeABAJO);
            this.Controls.Add(this.panelDeARRIBA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Facturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturando";
            this.Load += new System.EventHandler(this.Facturar_Load);
            this.panelDeARRIBA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxTITLE)).EndInit();
            this.panelDeABAJO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagarCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDeARRIBA;
        private System.Windows.Forms.Panel panelDeABAJO;
        private System.Windows.Forms.Label labelTitleFORMULARY;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxTITLE;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnFacturar;
        private System.Windows.Forms.NumericUpDown nudTotalPagar;
        private System.Windows.Forms.Label labelTotalPAGAR;
        private System.Windows.Forms.NumericUpDown nudPagarCon;
        private System.Windows.Forms.Label labelPagarCON;
        private System.Windows.Forms.Label labelFormaDelPAGO;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label labelVUELTO;
        private System.Windows.Forms.TextBox txtVuelto;
    }
}