namespace RestaurantePPAI.Pedidos
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
            this.dgvNotificados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtListosParaServir = new System.Windows.Forms.Label();
            this.pbxCampana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCampana)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuarioLogeado
            // 
            this.lblUsuarioLogeado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuarioLogeado.AutoSize = true;
            this.lblUsuarioLogeado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogeado.Location = new System.Drawing.Point(181, 8);
            this.lblUsuarioLogeado.Name = "lblUsuarioLogeado";
            this.lblUsuarioLogeado.Size = new System.Drawing.Size(101, 48);
            this.lblUsuarioLogeado.TabIndex = 16;
            this.lblUsuarioLogeado.Text = "    Juan Garcia\r\n\r\n              Mozo";
            // 
            // dgvNotificados
            // 
            this.dgvNotificados.AllowUserToAddRows = false;
            this.dgvNotificados.AllowUserToDeleteRows = false;
            this.dgvNotificados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNotificados.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.dgvNotificados.Location = new System.Drawing.Point(7, 42);
            this.dgvNotificados.MultiSelect = false;
            this.dgvNotificados.Name = "dgvNotificados";
            this.dgvNotificados.ReadOnly = true;
            this.dgvNotificados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotificados.Size = new System.Drawing.Size(334, 226);
            this.dgvNotificados.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Numero/s de Mesa/s";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad de Productos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dgvNotificados);
            this.panel1.Controls.Add(this.txtListosParaServir);
            this.panel1.Location = new System.Drawing.Point(9, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 271);
            this.panel1.TabIndex = 14;
            // 
            // txtListosParaServir
            // 
            this.txtListosParaServir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtListosParaServir.BackColor = System.Drawing.Color.White;
            this.txtListosParaServir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListosParaServir.ForeColor = System.Drawing.Color.Black;
            this.txtListosParaServir.Location = new System.Drawing.Point(7, 11);
            this.txtListosParaServir.Name = "txtListosParaServir";
            this.txtListosParaServir.Size = new System.Drawing.Size(334, 28);
            this.txtListosParaServir.TabIndex = 7;
            this.txtListosParaServir.Text = "PRODUCTOS A SERVIR";
            this.txtListosParaServir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxCampana
            // 
            this.pbxCampana.Image = global::RestaurantePPAI.Properties.Resources.campanita;
            this.pbxCampana.Location = new System.Drawing.Point(9, 8);
            this.pbxCampana.Name = "pbxCampana";
            this.pbxCampana.Size = new System.Drawing.Size(166, 50);
            this.pbxCampana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCampana.TabIndex = 17;
            this.pbxCampana.TabStop = false;
            this.pbxCampana.Visible = false;
            // 
            // pantallaMozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 348);
            this.Controls.Add(this.pbxCampana);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsuarioLogeado);
            this.Name = "pantallaMozo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productos a servir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pantallaMozo_FormClosing);
            this.Load += new System.EventHandler(this.pantallaMozo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificados)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCampana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioLogeado;
        private System.Windows.Forms.DataGridView dgvNotificados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtListosParaServir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox pbxCampana;
    }
}