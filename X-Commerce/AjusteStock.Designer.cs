namespace X_Commerce
{
    partial class AjusteStock
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
            this.panelDeABAJO = new System.Windows.Forms.Panel();
            this.iconButtonCANCEL = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.nudStockAgregar = new System.Windows.Forms.NumericUpDown();
            this.labelDeSTOCK = new System.Windows.Forms.Label();
            this.iconPictureBoxTITLE = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleFORMULARY = new System.Windows.Forms.Label();
            this.iconPictureBoxCERRAR = new FontAwesome.Sharp.IconPictureBox();
            this.panelDeARRIBA = new System.Windows.Forms.Panel();
            this.panelDeABAJO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxTITLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCERRAR)).BeginInit();
            this.panelDeARRIBA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDeABAJO
            // 
            this.panelDeABAJO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelDeABAJO.Controls.Add(this.iconButtonCANCEL);
            this.panelDeABAJO.Controls.Add(this.btnGuardar);
            this.panelDeABAJO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeABAJO.Location = new System.Drawing.Point(0, 340);
            this.panelDeABAJO.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeABAJO.Name = "panelDeABAJO";
            this.panelDeABAJO.Size = new System.Drawing.Size(695, 123);
            this.panelDeABAJO.TabIndex = 1;
            // 
            // iconButtonCANCEL
            // 
            this.iconButtonCANCEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonCANCEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconButtonCANCEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCANCEL.FlatAppearance.BorderSize = 0;
            this.iconButtonCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCANCEL.ForeColor = System.Drawing.Color.White;
            this.iconButtonCANCEL.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.iconButtonCANCEL.IconColor = System.Drawing.Color.DeepPink;
            this.iconButtonCANCEL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCANCEL.IconSize = 35;
            this.iconButtonCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCANCEL.Location = new System.Drawing.Point(357, 30);
            this.iconButtonCANCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonCANCEL.Name = "iconButtonCANCEL";
            this.iconButtonCANCEL.Size = new System.Drawing.Size(219, 64);
            this.iconButtonCANCEL.TabIndex = 12;
            this.iconButtonCANCEL.Text = "Cancelar";
            this.iconButtonCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCANCEL.UseVisualStyleBackColor = false;
            this.iconButtonCANCEL.Click += new System.EventHandler(this.iconButtonCANCEL_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnGuardar.IconColor = System.Drawing.Color.DeepPink;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 35;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(117, 30);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(215, 64);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudStockAgregar
            // 
            this.nudStockAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockAgregar.Location = new System.Drawing.Point(325, 211);
            this.nudStockAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudStockAgregar.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.nudStockAgregar.Name = "nudStockAgregar";
            this.nudStockAgregar.Size = new System.Drawing.Size(232, 34);
            this.nudStockAgregar.TabIndex = 7;
            // 
            // labelDeSTOCK
            // 
            this.labelDeSTOCK.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeSTOCK.ForeColor = System.Drawing.Color.White;
            this.labelDeSTOCK.Location = new System.Drawing.Point(170, 213);
            this.labelDeSTOCK.Name = "labelDeSTOCK";
            this.labelDeSTOCK.Size = new System.Drawing.Size(149, 32);
            this.labelDeSTOCK.TabIndex = 6;
            this.labelDeSTOCK.Text = "Stock";
            // 
            // iconPictureBoxTITLE
            // 
            this.iconPictureBoxTITLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconPictureBoxTITLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxTITLE.ForeColor = System.Drawing.Color.DeepPink;
            this.iconPictureBoxTITLE.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconPictureBoxTITLE.IconColor = System.Drawing.Color.DeepPink;
            this.iconPictureBoxTITLE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxTITLE.IconSize = 44;
            this.iconPictureBoxTITLE.Location = new System.Drawing.Point(125, 28);
            this.iconPictureBoxTITLE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBoxTITLE.Name = "iconPictureBoxTITLE";
            this.iconPictureBoxTITLE.Size = new System.Drawing.Size(76, 44);
            this.iconPictureBoxTITLE.TabIndex = 7;
            this.iconPictureBoxTITLE.TabStop = false;
            // 
            // labelTitleFORMULARY
            // 
            this.labelTitleFORMULARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleFORMULARY.ForeColor = System.Drawing.Color.White;
            this.labelTitleFORMULARY.Location = new System.Drawing.Point(207, 28);
            this.labelTitleFORMULARY.Name = "labelTitleFORMULARY";
            this.labelTitleFORMULARY.Size = new System.Drawing.Size(369, 44);
            this.labelTitleFORMULARY.TabIndex = 8;
            this.labelTitleFORMULARY.Text = "Producto Seleccionado";
            this.labelTitleFORMULARY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPictureBoxCERRAR
            // 
            this.iconPictureBoxCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBoxCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconPictureBoxCERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxCERRAR.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBoxCERRAR.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxCERRAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCERRAR.IconSize = 44;
            this.iconPictureBoxCERRAR.Location = new System.Drawing.Point(615, 28);
            this.iconPictureBoxCERRAR.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBoxCERRAR.Name = "iconPictureBoxCERRAR";
            this.iconPictureBoxCERRAR.Size = new System.Drawing.Size(67, 44);
            this.iconPictureBoxCERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBoxCERRAR.TabIndex = 9;
            this.iconPictureBoxCERRAR.TabStop = false;
            this.iconPictureBoxCERRAR.Click += new System.EventHandler(this.iconPictureBoxCERRAR_Click);
            // 
            // panelDeARRIBA
            // 
            this.panelDeARRIBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelDeARRIBA.Controls.Add(this.iconPictureBoxCERRAR);
            this.panelDeARRIBA.Controls.Add(this.labelTitleFORMULARY);
            this.panelDeARRIBA.Controls.Add(this.iconPictureBoxTITLE);
            this.panelDeARRIBA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeARRIBA.Location = new System.Drawing.Point(0, 0);
            this.panelDeARRIBA.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeARRIBA.Name = "panelDeARRIBA";
            this.panelDeARRIBA.Size = new System.Drawing.Size(695, 123);
            this.panelDeARRIBA.TabIndex = 0;
            // 
            // AjusteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(695, 463);
            this.ControlBox = false;
            this.Controls.Add(this.nudStockAgregar);
            this.Controls.Add(this.labelDeSTOCK);
            this.Controls.Add(this.panelDeABAJO);
            this.Controls.Add(this.panelDeARRIBA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjusteStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Producto Seleccionado";
            this.panelDeABAJO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStockAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxTITLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCERRAR)).EndInit();
            this.panelDeARRIBA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDeABAJO;
        private FontAwesome.Sharp.IconButton iconButtonCANCEL;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.NumericUpDown nudStockAgregar;
        private System.Windows.Forms.Label labelDeSTOCK;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxTITLE;
        private System.Windows.Forms.Label labelTitleFORMULARY;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCERRAR;
        private System.Windows.Forms.Panel panelDeARRIBA;
    }
}