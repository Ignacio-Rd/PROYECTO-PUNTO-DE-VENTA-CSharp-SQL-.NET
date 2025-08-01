namespace TPFinalNivel2_RuizDiaz
{
    partial class REGISTRADORA_DE_COMPRAS
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
            this.DgvRegistradora = new System.Windows.Forms.DataGridView();
            this.codigo_Producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Total = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_metododepago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistradora)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvRegistradora
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistradora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvRegistradora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRegistradora.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRegistradora.Location = new System.Drawing.Point(38, 96);
            this.DgvRegistradora.MultiSelect = false;
            this.DgvRegistradora.Name = "DgvRegistradora";
            this.DgvRegistradora.RowTemplate.Height = 40;
            this.DgvRegistradora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRegistradora.Size = new System.Drawing.Size(940, 432);
            this.DgvRegistradora.TabIndex = 0;
            // 
            // codigo_Producto
            // 
            this.codigo_Producto.Location = new System.Drawing.Point(127, 596);
            this.codigo_Producto.Name = "codigo_Producto";
            this.codigo_Producto.Size = new System.Drawing.Size(199, 20);
            this.codigo_Producto.TabIndex = 1;
            this.codigo_Producto.TextChanged += new System.EventHandler(this.codigo_Producto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "código";
            // 
            // Btn_Total
            // 
            this.Btn_Total.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Total.Location = new System.Drawing.Point(389, 580);
            this.Btn_Total.Name = "Btn_Total";
            this.Btn_Total.Size = new System.Drawing.Size(280, 42);
            this.Btn_Total.TabIndex = 3;
            this.Btn_Total.Text = "FINALIZAR COMPRA";
            this.Btn_Total.UseVisualStyleBackColor = true;
            this.Btn_Total.Click += new System.EventHandler(this.Btn_Total_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(134, 49);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(27, 35);
            this.lbl_precio.TabIndex = 5;
            this.lbl_precio.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lbl_precio);
            this.groupBox1.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1056, 549);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COBRAR:";
            // 
            // cbx_metododepago
            // 
            this.cbx_metododepago.FormattingEnabled = true;
            this.cbx_metododepago.Location = new System.Drawing.Point(212, 50);
            this.cbx_metododepago.Name = "cbx_metododepago";
            this.cbx_metododepago.Size = new System.Drawing.Size(172, 21);
            this.cbx_metododepago.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "FORMA DE PAGO";
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(1105, 12);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(253, 49);
            this.btnEliminarArticulo.TabIndex = 9;
            this.btnEliminarArticulo.Text = "eliminar articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // REGISTRADORA_DE_COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 687);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_metododepago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigo_Producto);
            this.Controls.Add(this.DgvRegistradora);
            this.Name = "REGISTRADORA_DE_COMPRAS";
            this.Text = "REGISTRADORA_DE_COMPRAS";
            this.Load += new System.EventHandler(this.REGISTRADORA_DE_COMPRAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistradora)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRegistradora;
        private System.Windows.Forms.TextBox codigo_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Total;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_metododepago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarArticulo;
    }
}