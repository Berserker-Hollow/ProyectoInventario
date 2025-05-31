namespace ProyectoInventario
{
    partial class FormResumenVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResumenVenta));
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("SimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(262, 28);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(339, 34);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Seleccionar Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(645, 38);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerar.Location = new System.Drawing.Point(423, 449);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(196, 47);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(645, 449);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(196, 47);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvResumen
            // 
            this.dgvResumen.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(262, 108);
            this.dgvResumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.RowHeadersWidth = 51;
            this.dgvResumen.Size = new System.Drawing.Size(665, 286);
            this.dgvResumen.TabIndex = 19;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.BackColor = System.Drawing.Color.White;
            this.lblTotalVentas.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(395, 666);
            this.lblTotalVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(367, 38);
            this.lblTotalVentas.TabIndex = 20;
            this.lblTotalVentas.Text = "Total de Ventas: Q0.00";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(-11, -6);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(265, 155);
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // FormResumenVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 573);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormResumenVenta";
            this.Text = "FormResumenVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}