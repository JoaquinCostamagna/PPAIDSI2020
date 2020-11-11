namespace RestaurantePPAI.Pantallas
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
            this.btnFinalizarDetalles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinalizarDetalles
            // 
            this.btnFinalizarDetalles.Location = new System.Drawing.Point(251, 148);
            this.btnFinalizarDetalles.Name = "btnFinalizarDetalles";
            this.btnFinalizarDetalles.Size = new System.Drawing.Size(320, 121);
            this.btnFinalizarDetalles.TabIndex = 0;
            this.btnFinalizarDetalles.Text = "Finalizar la preparación de pedido";
            this.btnFinalizarDetalles.UseVisualStyleBackColor = true;
            this.btnFinalizarDetalles.Click += new System.EventHandler(this.btnFinalizarDetalles_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizarDetalles);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizarDetalles;
    }
}