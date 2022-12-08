namespace ProyectoEstructuras
{
    partial class Form1
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
            this.cmbEstructura = new System.Windows.Forms.ComboBox();
            this.cmbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbEstructura
            // 
            this.cmbEstructura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstructura.FormattingEnabled = true;
            this.cmbEstructura.Items.AddRange(new object[] {
            "Selecionar estructura de dato",
            "Lista enlazada",
            "Lista doble",
            "Lista circular",
            "Lista circular doble",
            "Pila",
            "Cola simple",
            "Cola circular",
            "Bicola",
            "Cola de prioridades",
            "Árboles",
            "Grafos"});
            this.cmbEstructura.Location = new System.Drawing.Point(12, 12);
            this.cmbEstructura.Name = "cmbEstructura";
            this.cmbEstructura.Size = new System.Drawing.Size(401, 21);
            this.cmbEstructura.TabIndex = 0;
            this.cmbEstructura.SelectedIndexChanged += new System.EventHandler(this.cmbEstructura_SelectedIndexChanged);
            // 
            // cmbAlgoritmo
            // 
            this.cmbAlgoritmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlgoritmo.FormattingEnabled = true;
            this.cmbAlgoritmo.Items.AddRange(new object[] {
            "Selecionar algoritmo de ordenamiento",
            "Burbuja",
            "Burbuja bidireccional",
            "Insercción",
            "Cuentas",
            "Árbol binario",
            "Mezcla Directa",
            "Radix",
            "Shell",
            "Selección",
            "Rápido"});
            this.cmbAlgoritmo.Location = new System.Drawing.Point(12, 97);
            this.cmbAlgoritmo.Name = "cmbAlgoritmo";
            this.cmbAlgoritmo.Size = new System.Drawing.Size(401, 21);
            this.cmbAlgoritmo.TabIndex = 1;
            this.cmbAlgoritmo.SelectedIndexChanged += new System.EventHandler(this.cmbAlgoritmo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 133);
            this.Controls.Add(this.cmbAlgoritmo);
            this.Controls.Add(this.cmbEstructura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstructura;
        private System.Windows.Forms.ComboBox cmbAlgoritmo;
    }
}

