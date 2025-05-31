namespace ProyectoInventario
{
    partial class FormDetallesVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetallesVenta));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvDetallesVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDetallesVentas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRegresar, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(268, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1099, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegresar.Location = new System.Drawing.Point(451, 463);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(196, 47);
            this.btnRegresar.TabIndex = 19;
            this.btnRegresar.Text = "Volver";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvDetallesVentas
            // 
            this.dgvDetallesVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallesVentas.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvDetallesVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesVentas.Location = new System.Drawing.Point(4, 4);
            this.dgvDetallesVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDetallesVentas.Name = "dgvDetallesVentas";
            this.dgvDetallesVentas.RowHeadersWidth = 51;
            this.dgvDetallesVentas.Size = new System.Drawing.Size(1091, 316);
            this.dgvDetallesVentas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 44);
            this.label1.TabIndex = 33;
            this.label1.Text = "Detalles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(-1, 13);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(265, 155);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // FormDetallesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1390, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(286, 13);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDetallesVenta";
            this.Text = "FormDetallesVenta";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDetallesVentas;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}