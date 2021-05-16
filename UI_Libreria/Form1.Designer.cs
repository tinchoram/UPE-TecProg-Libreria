
namespace UI_Libreria
{
    partial class FromLibreria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxLibros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownLibreria = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewLibreria = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.textBoxFactura = new System.Windows.Forms.TextBox();
            this.TextNumeroFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLibreria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibreria)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLibros
            // 
            this.comboBoxLibros.FormattingEnabled = true;
            this.comboBoxLibros.Location = new System.Drawing.Point(15, 25);
            this.comboBoxLibros.Name = "comboBoxLibros";
            this.comboBoxLibros.Size = new System.Drawing.Size(144, 21);
            this.comboBoxLibros.TabIndex = 0;
            this.comboBoxLibros.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Libro";
            // 
            // numUpDownLibreria
            // 
            this.numUpDownLibreria.Location = new System.Drawing.Point(165, 26);
            this.numUpDownLibreria.Name = "numUpDownLibreria";
            this.numUpDownLibreria.Size = new System.Drawing.Size(46, 20);
            this.numUpDownLibreria.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(196, 51);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewLibreria
            // 
            this.dataGridViewLibreria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibreria.Location = new System.Drawing.Point(247, 25);
            this.dataGridViewLibreria.Name = "dataGridViewLibreria";
            this.dataGridViewLibreria.Size = new System.Drawing.Size(812, 174);
            this.dataGridViewLibreria.TabIndex = 4;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(549, 256);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(259, 35);
            this.btnFacturar.TabIndex = 5;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxFactura
            // 
            this.textBoxFactura.Location = new System.Drawing.Point(247, 297);
            this.textBoxFactura.Multiline = true;
            this.textBoxFactura.Name = "textBoxFactura";
            this.textBoxFactura.ReadOnly = true;
            this.textBoxFactura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFactura.Size = new System.Drawing.Size(812, 185);
            this.textBoxFactura.TabIndex = 6;
            // 
            // TextNumeroFactura
            // 
            this.TextNumeroFactura.Location = new System.Drawing.Point(635, 230);
            this.TextNumeroFactura.Name = "TextNumeroFactura";
            this.TextNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.TextNumeroFactura.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero de Factura";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FromLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1071, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextNumeroFactura);
            this.Controls.Add(this.textBoxFactura);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.dataGridViewLibreria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.numUpDownLibreria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLibros);
            this.Name = "FromLibreria";
            this.Text = "Libreria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLibreria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibreria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownLibreria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridViewLibreria;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.TextBox textBoxFactura;
        private System.Windows.Forms.TextBox TextNumeroFactura;
        private System.Windows.Forms.Label label2;
    }
}

