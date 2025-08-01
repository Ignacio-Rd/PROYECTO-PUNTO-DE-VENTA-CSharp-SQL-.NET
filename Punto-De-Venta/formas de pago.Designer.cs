namespace TPFinalNivel2_RuizDiaz
{
    partial class formas_de_pago
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
            this.dgv_metodopago = new System.Windows.Forms.DataGridView();
            this.btn_eliminarmetodopago = new System.Windows.Forms.Button();
            this.btnAgregarMetodopago = new System.Windows.Forms.Button();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtporcentaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_metodopago)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_metodopago
            // 
            this.dgv_metodopago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_metodopago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_metodopago.Location = new System.Drawing.Point(72, 51);
            this.dgv_metodopago.Name = "dgv_metodopago";
            this.dgv_metodopago.Size = new System.Drawing.Size(356, 238);
            this.dgv_metodopago.TabIndex = 0;
            // 
            // btn_eliminarmetodopago
            // 
            this.btn_eliminarmetodopago.Location = new System.Drawing.Point(198, 402);
            this.btn_eliminarmetodopago.Name = "btn_eliminarmetodopago";
            this.btn_eliminarmetodopago.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarmetodopago.TabIndex = 1;
            this.btn_eliminarmetodopago.Text = "Eliminar";
            this.btn_eliminarmetodopago.UseVisualStyleBackColor = true;
            this.btn_eliminarmetodopago.Click += new System.EventHandler(this.btn_eliminarmetodopago_Click);
            // 
            // btnAgregarMetodopago
            // 
            this.btnAgregarMetodopago.Location = new System.Drawing.Point(198, 362);
            this.btnAgregarMetodopago.Name = "btnAgregarMetodopago";
            this.btnAgregarMetodopago.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMetodopago.TabIndex = 2;
            this.btnAgregarMetodopago.Text = "Agregar";
            this.btnAgregarMetodopago.UseVisualStyleBackColor = true;
            this.btnAgregarMetodopago.Click += new System.EventHandler(this.btnAgregarMetodopago_Click);
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(185, 304);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(100, 20);
            this.txtMetodoPago.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Forma de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "porcentaje";
            // 
            // Txtporcentaje
            // 
            this.Txtporcentaje.Location = new System.Drawing.Point(185, 336);
            this.Txtporcentaje.Name = "Txtporcentaje";
            this.Txtporcentaje.Size = new System.Drawing.Size(100, 20);
            this.Txtporcentaje.TabIndex = 6;
            // 
            // formas_de_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 437);
            this.Controls.Add(this.Txtporcentaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.btnAgregarMetodopago);
            this.Controls.Add(this.btn_eliminarmetodopago);
            this.Controls.Add(this.dgv_metodopago);
            this.Name = "formas_de_pago";
            this.Text = "metodo_de_pago";
            this.Load += new System.EventHandler(this.formas_de_pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_metodopago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_metodopago;
        private System.Windows.Forms.Button btn_eliminarmetodopago;
        private System.Windows.Forms.Button btnAgregarMetodopago;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtporcentaje;
    }
}