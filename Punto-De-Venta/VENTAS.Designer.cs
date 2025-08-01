namespace TPFinalNivel2_RuizDiaz
{
    partial class Venta_Por_Venta
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
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.DgvTotalDia = new System.Windows.Forms.DataGridView();
            this.DtpFiltro = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltrarFecha = new System.Windows.Forms.Button();
            this.DtpFiltroTotal = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltrarTotal = new System.Windows.Forms.Button();
            this.BtnBorrarVenta = new System.Windows.Forms.Button();
            this.BtnBorrarFecha = new System.Windows.Forms.Button();
            this.BtnVolverVenta = new System.Windows.Forms.Button();
            this.BtnVolverFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalDia)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVentas
            // 
            this.DgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVentas.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVentas.Location = new System.Drawing.Point(26, 121);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(559, 595);
            this.DgvVentas.TabIndex = 0;
            // 
            // DgvTotalDia
            // 
            this.DgvTotalDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTotalDia.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTotalDia.Location = new System.Drawing.Point(764, 121);
            this.DgvTotalDia.Name = "DgvTotalDia";
            this.DgvTotalDia.Size = new System.Drawing.Size(573, 595);
            this.DgvTotalDia.TabIndex = 1;
            // 
            // DtpFiltro
            // 
            this.DtpFiltro.Location = new System.Drawing.Point(26, 84);
            this.DtpFiltro.Name = "DtpFiltro";
            this.DtpFiltro.Size = new System.Drawing.Size(200, 20);
            this.DtpFiltro.TabIndex = 2;
            // 
            // BtnFiltrarFecha
            // 
            this.BtnFiltrarFecha.Location = new System.Drawing.Point(270, 81);
            this.BtnFiltrarFecha.Name = "BtnFiltrarFecha";
            this.BtnFiltrarFecha.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrarFecha.TabIndex = 3;
            this.BtnFiltrarFecha.Text = "Filtrar";
            this.BtnFiltrarFecha.UseVisualStyleBackColor = true;
            this.BtnFiltrarFecha.Click += new System.EventHandler(this.BtnFiltrarFecha_Click);
            // 
            // DtpFiltroTotal
            // 
            this.DtpFiltroTotal.Location = new System.Drawing.Point(764, 80);
            this.DtpFiltroTotal.Name = "DtpFiltroTotal";
            this.DtpFiltroTotal.Size = new System.Drawing.Size(200, 20);
            this.DtpFiltroTotal.TabIndex = 4;
            // 
            // BtnFiltrarTotal
            // 
            this.BtnFiltrarTotal.Location = new System.Drawing.Point(1007, 77);
            this.BtnFiltrarTotal.Name = "BtnFiltrarTotal";
            this.BtnFiltrarTotal.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrarTotal.TabIndex = 5;
            this.BtnFiltrarTotal.Text = "Filtrar";
            this.BtnFiltrarTotal.UseVisualStyleBackColor = true;
            this.BtnFiltrarTotal.Click += new System.EventHandler(this.BtnFiltrarTotal_Click);
            // 
            // BtnBorrarVenta
            // 
            this.BtnBorrarVenta.Location = new System.Drawing.Point(510, 80);
            this.BtnBorrarVenta.Name = "BtnBorrarVenta";
            this.BtnBorrarVenta.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrarVenta.TabIndex = 6;
            this.BtnBorrarVenta.Text = "Borrar";
            this.BtnBorrarVenta.UseVisualStyleBackColor = true;
            this.BtnBorrarVenta.Click += new System.EventHandler(this.BtnBorrarVenta_Click);
            // 
            // BtnBorrarFecha
            // 
            this.BtnBorrarFecha.Location = new System.Drawing.Point(1262, 77);
            this.BtnBorrarFecha.Name = "BtnBorrarFecha";
            this.BtnBorrarFecha.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrarFecha.TabIndex = 7;
            this.BtnBorrarFecha.Text = "Borrar";
            this.BtnBorrarFecha.UseVisualStyleBackColor = true;
            // 
            // BtnVolverVenta
            // 
            this.BtnVolverVenta.Location = new System.Drawing.Point(389, 81);
            this.BtnVolverVenta.Name = "BtnVolverVenta";
            this.BtnVolverVenta.Size = new System.Drawing.Size(75, 23);
            this.BtnVolverVenta.TabIndex = 8;
            this.BtnVolverVenta.Text = "Volver";
            this.BtnVolverVenta.UseVisualStyleBackColor = true;
            this.BtnVolverVenta.Click += new System.EventHandler(this.BtnVolverVenta_Click);
            // 
            // BtnVolverFecha
            // 
            this.BtnVolverFecha.Location = new System.Drawing.Point(1137, 77);
            this.BtnVolverFecha.Name = "BtnVolverFecha";
            this.BtnVolverFecha.Size = new System.Drawing.Size(75, 23);
            this.BtnVolverFecha.TabIndex = 9;
            this.BtnVolverFecha.Text = "Volver";
            this.BtnVolverFecha.UseVisualStyleBackColor = true;
            this.BtnVolverFecha.Click += new System.EventHandler(this.BtnVolverFecha_Click);
            // 
            // Venta_Por_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BtnVolverFecha);
            this.Controls.Add(this.BtnVolverVenta);
            this.Controls.Add(this.BtnBorrarFecha);
            this.Controls.Add(this.BtnBorrarVenta);
            this.Controls.Add(this.BtnFiltrarTotal);
            this.Controls.Add(this.DtpFiltroTotal);
            this.Controls.Add(this.BtnFiltrarFecha);
            this.Controls.Add(this.DtpFiltro);
            this.Controls.Add(this.DgvTotalDia);
            this.Controls.Add(this.DgvVentas);
            this.Name = "Venta_Por_Venta";
            this.Text = "TOTAL VENTA POR VENTA";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.DataGridView DgvTotalDia;
        private System.Windows.Forms.DateTimePicker DtpFiltro;
        private System.Windows.Forms.Button BtnFiltrarFecha;
        private System.Windows.Forms.DateTimePicker DtpFiltroTotal;
        private System.Windows.Forms.Button BtnFiltrarTotal;
        private System.Windows.Forms.Button BtnBorrarVenta;
        private System.Windows.Forms.Button BtnBorrarFecha;
        private System.Windows.Forms.Button BtnVolverVenta;
        private System.Windows.Forms.Button BtnVolverFecha;
    }
}