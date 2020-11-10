namespace RestaurantePPAI.Pantallas
{
    partial class pantallaMozo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaMozo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuarioLogeado = new System.Windows.Forms.Label();
            this.dgvSeleccionados = new System.Windows.Forms.DataGridView();
            this.numDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDeEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtListosParaServir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(563, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuarioLogeado
            // 
            this.lblUsuarioLogeado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioLogeado.AutoSize = true;
            this.lblUsuarioLogeado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogeado.Location = new System.Drawing.Point(408, 11);
            this.lblUsuarioLogeado.Name = "lblUsuarioLogeado";
            this.lblUsuarioLogeado.Size = new System.Drawing.Size(101, 48);
            this.lblUsuarioLogeado.TabIndex = 16;
            this.lblUsuarioLogeado.Text = "    Juan Garcia\r\n\r\n              Mozo";
            // 
            // dgvSeleccionados
            // 
            this.dgvSeleccionados.AllowUserToAddRows = false;
            this.dgvSeleccionados.AllowUserToDeleteRows = false;
            this.dgvSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeleccionados.BackgroundColor = System.Drawing.Color.White;
            this.dgvSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDetalle,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.tiempoDeEspera});
            this.dgvSeleccionados.Location = new System.Drawing.Point(14, 44);
            this.dgvSeleccionados.MultiSelect = false;
            this.dgvSeleccionados.Name = "dgvSeleccionados";
            this.dgvSeleccionados.ReadOnly = true;
            this.dgvSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccionados.Size = new System.Drawing.Size(572, 528);
            this.dgvSeleccionados.TabIndex = 2;
            // 
            // numDetalle
            // 
            this.numDetalle.HeaderText = "Numero de Detalle";
            this.numDetalle.Name = "numDetalle";
            this.numDetalle.ReadOnly = true;
            this.numDetalle.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre del Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre del Menu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Numero/s de Mesa/s";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 89;
            // 
            // tiempoDeEspera
            // 
            this.tiempoDeEspera.HeaderText = "Tiempo de Espera";
            this.tiempoDeEspera.Name = "tiempoDeEspera";
            this.tiempoDeEspera.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dgvSeleccionados);
            this.panel1.Controls.Add(this.txtListosParaServir);
            this.panel1.Location = new System.Drawing.Point(4, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 575);
            this.panel1.TabIndex = 14;
            // 
            // txtListosParaServir
            // 
            this.txtListosParaServir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListosParaServir.BackColor = System.Drawing.Color.White;
            this.txtListosParaServir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListosParaServir.ForeColor = System.Drawing.Color.Black;
            this.txtListosParaServir.Location = new System.Drawing.Point(14, 13);
            this.txtListosParaServir.Name = "txtListosParaServir";
            this.txtListosParaServir.Size = new System.Drawing.Size(572, 28);
            this.txtListosParaServir.TabIndex = 7;
            this.txtListosParaServir.Text = "DETALLES DE PEDIDO LISTOS PARA SERVIR";
            this.txtListosParaServir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pantallaMozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsuarioLogeado);
            this.Name = "pantallaMozo";
            this.Text = "pantallaMozo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioLogeado;
        private System.Windows.Forms.DataGridView dgvSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDeEspera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtListosParaServir;
    }
}