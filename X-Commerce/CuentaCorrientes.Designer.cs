namespace X_Commerce
{
    partial class CuentaCorrientes
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
            this.panelDeARRIBA = new System.Windows.Forms.Panel();
            this.txtSaldoPendiente = new System.Windows.Forms.TextBox();
            this.labelSaldoPENDIENTE = new System.Windows.Forms.Label();
            this.btnNuevoPago = new FontAwesome.Sharp.IconButton();
            this.panelDeABAJO = new System.Windows.Forms.Panel();
            this.iconButtonSALIENDO = new FontAwesome.Sharp.IconButton();
            this.panelDelMEDIO = new System.Windows.Forms.Panel();
            this.dgvCuentaCorriente = new System.Windows.Forms.DataGridView();
            this.panelDeARRIBA.SuspendLayout();
            this.panelDeABAJO.SuspendLayout();
            this.panelDelMEDIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaCorriente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeARRIBA
            // 
            this.panelDeARRIBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelDeARRIBA.Controls.Add(this.txtSaldoPendiente);
            this.panelDeARRIBA.Controls.Add(this.labelSaldoPENDIENTE);
            this.panelDeARRIBA.Controls.Add(this.btnNuevoPago);
            this.panelDeARRIBA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeARRIBA.Location = new System.Drawing.Point(0, 0);
            this.panelDeARRIBA.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeARRIBA.Name = "panelDeARRIBA";
            this.panelDeARRIBA.Size = new System.Drawing.Size(1060, 98);
            this.panelDeARRIBA.TabIndex = 0;
            // 
            // txtSaldoPendiente
            // 
            this.txtSaldoPendiente.Enabled = false;
            this.txtSaldoPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoPendiente.Location = new System.Drawing.Point(763, 33);
            this.txtSaldoPendiente.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldoPendiente.Name = "txtSaldoPendiente";
            this.txtSaldoPendiente.Size = new System.Drawing.Size(280, 34);
            this.txtSaldoPendiente.TabIndex = 2;
            // 
            // labelSaldoPENDIENTE
            // 
            this.labelSaldoPENDIENTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSaldoPENDIENTE.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoPENDIENTE.ForeColor = System.Drawing.Color.White;
            this.labelSaldoPENDIENTE.Location = new System.Drawing.Point(471, 37);
            this.labelSaldoPENDIENTE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaldoPENDIENTE.Name = "labelSaldoPENDIENTE";
            this.labelSaldoPENDIENTE.Size = new System.Drawing.Size(271, 37);
            this.labelSaldoPENDIENTE.TabIndex = 1;
            this.labelSaldoPENDIENTE.Text = "Saldo Pendiente";
            // 
            // btnNuevoPago
            // 
            this.btnNuevoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnNuevoPago.FlatAppearance.BorderSize = 0;
            this.btnNuevoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPago.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPago.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPago.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.btnNuevoPago.IconColor = System.Drawing.Color.DeepPink;
            this.btnNuevoPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoPago.IconSize = 35;
            this.btnNuevoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPago.Location = new System.Drawing.Point(16, 26);
            this.btnNuevoPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoPago.Name = "btnNuevoPago";
            this.btnNuevoPago.Size = new System.Drawing.Size(269, 52);
            this.btnNuevoPago.TabIndex = 0;
            this.btnNuevoPago.Text = "Nuevo Pago";
            this.btnNuevoPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPago.UseVisualStyleBackColor = false;
            this.btnNuevoPago.Click += new System.EventHandler(this.btnNuevoPago_Click);
            // 
            // panelDeABAJO
            // 
            this.panelDeABAJO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelDeABAJO.Controls.Add(this.iconButtonSALIENDO);
            this.panelDeABAJO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeABAJO.Location = new System.Drawing.Point(0, 451);
            this.panelDeABAJO.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeABAJO.Name = "panelDeABAJO";
            this.panelDeABAJO.Size = new System.Drawing.Size(1060, 98);
            this.panelDeABAJO.TabIndex = 1;
            // 
            // iconButtonSALIENDO
            // 
            this.iconButtonSALIENDO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconButtonSALIENDO.FlatAppearance.BorderSize = 0;
            this.iconButtonSALIENDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSALIENDO.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSALIENDO.ForeColor = System.Drawing.Color.White;
            this.iconButtonSALIENDO.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButtonSALIENDO.IconColor = System.Drawing.Color.DeepPink;
            this.iconButtonSALIENDO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSALIENDO.IconSize = 35;
            this.iconButtonSALIENDO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSALIENDO.Location = new System.Drawing.Point(887, 27);
            this.iconButtonSALIENDO.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSALIENDO.Name = "iconButtonSALIENDO";
            this.iconButtonSALIENDO.Size = new System.Drawing.Size(157, 57);
            this.iconButtonSALIENDO.TabIndex = 1;
            this.iconButtonSALIENDO.Text = "Salir";
            this.iconButtonSALIENDO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSALIENDO.UseVisualStyleBackColor = false;
            this.iconButtonSALIENDO.Click += new System.EventHandler(this.iconButtonSALIENDO_Click);
            // 
            // panelDelMEDIO
            // 
            this.panelDelMEDIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelDelMEDIO.Controls.Add(this.dgvCuentaCorriente);
            this.panelDelMEDIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDelMEDIO.Location = new System.Drawing.Point(0, 98);
            this.panelDelMEDIO.Margin = new System.Windows.Forms.Padding(4);
            this.panelDelMEDIO.Name = "panelDelMEDIO";
            this.panelDelMEDIO.Size = new System.Drawing.Size(1060, 353);
            this.panelDelMEDIO.TabIndex = 2;
            // 
            // dgvCuentaCorriente
            // 
            this.dgvCuentaCorriente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCuentaCorriente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCuentaCorriente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvCuentaCorriente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuentaCorriente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentaCorriente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentaCorriente.ColumnHeadersHeight = 30;
            this.dgvCuentaCorriente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCuentaCorriente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuentaCorriente.EnableHeadersVisualStyles = false;
            this.dgvCuentaCorriente.GridColor = System.Drawing.Color.DeepPink;
            this.dgvCuentaCorriente.Location = new System.Drawing.Point(0, 0);
            this.dgvCuentaCorriente.Name = "dgvCuentaCorriente";
            this.dgvCuentaCorriente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentaCorriente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentaCorriente.RowHeadersVisible = false;
            this.dgvCuentaCorriente.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCuentaCorriente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuentaCorriente.RowTemplate.Height = 24;
            this.dgvCuentaCorriente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentaCorriente.Size = new System.Drawing.Size(1060, 353);
            this.dgvCuentaCorriente.TabIndex = 2;
            // 
            // CuentaCorrientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 549);
            this.ControlBox = false;
            this.Controls.Add(this.panelDelMEDIO);
            this.Controls.Add(this.panelDeABAJO);
            this.Controls.Add(this.panelDeARRIBA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CuentaCorrientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CuentaCorriente_Load);
            this.panelDeARRIBA.ResumeLayout(false);
            this.panelDeARRIBA.PerformLayout();
            this.panelDeABAJO.ResumeLayout(false);
            this.panelDelMEDIO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaCorriente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDeARRIBA;
        private System.Windows.Forms.Panel panelDeABAJO;
        private System.Windows.Forms.Panel panelDelMEDIO;
        private FontAwesome.Sharp.IconButton btnNuevoPago;
        private System.Windows.Forms.TextBox txtSaldoPendiente;
        private System.Windows.Forms.Label labelSaldoPENDIENTE;
        private FontAwesome.Sharp.IconButton iconButtonSALIENDO;
        private System.Windows.Forms.DataGridView dgvCuentaCorriente;
    }
}