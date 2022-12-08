namespace ProyectoEstructuras
{
    partial class Bicola
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
            this.btnDelH = new System.Windows.Forms.Button();
            this.btnDelT = new System.Windows.Forms.Button();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.btnAddT = new System.Windows.Forms.Button();
            this.btnAddH = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelH
            // 
            this.btnDelH.Location = new System.Drawing.Point(12, 289);
            this.btnDelH.Name = "btnDelH";
            this.btnDelH.Size = new System.Drawing.Size(124, 23);
            this.btnDelH.TabIndex = 11;
            this.btnDelH.Text = "Eliminar Frente";
            this.btnDelH.UseVisualStyleBackColor = true;
            this.btnDelH.Click += new System.EventHandler(this.btnDelH_Click);
            // 
            // btnDelT
            // 
            this.btnDelT.Location = new System.Drawing.Point(142, 289);
            this.btnDelT.Name = "btnDelT";
            this.btnDelT.Size = new System.Drawing.Size(124, 23);
            this.btnDelT.TabIndex = 10;
            this.btnDelT.Text = "Eliminar Final";
            this.btnDelT.UseVisualStyleBackColor = true;
            this.btnDelT.Click += new System.EventHandler(this.btnDelT_Click);
            // 
            // txtCola
            // 
            this.txtCola.Location = new System.Drawing.Point(12, 79);
            this.txtCola.Multiline = true;
            this.txtCola.Name = "txtCola";
            this.txtCola.ReadOnly = true;
            this.txtCola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCola.Size = new System.Drawing.Size(254, 204);
            this.txtCola.TabIndex = 9;
            // 
            // btnAddT
            // 
            this.btnAddT.Location = new System.Drawing.Point(142, 38);
            this.btnAddT.Name = "btnAddT";
            this.btnAddT.Size = new System.Drawing.Size(124, 23);
            this.btnAddT.TabIndex = 8;
            this.btnAddT.Text = "Agregar Final";
            this.btnAddT.UseVisualStyleBackColor = true;
            this.btnAddT.Click += new System.EventHandler(this.btnAddT_Click);
            // 
            // btnAddH
            // 
            this.btnAddH.Location = new System.Drawing.Point(12, 38);
            this.btnAddH.Name = "btnAddH";
            this.btnAddH.Size = new System.Drawing.Size(124, 23);
            this.btnAddH.TabIndex = 7;
            this.btnAddH.Text = "Agregar Frente";
            this.btnAddH.UseVisualStyleBackColor = true;
            this.btnAddH.Click += new System.EventHandler(this.btnAddH_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(12, 12);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(254, 20);
            this.txtDato.TabIndex = 6;
            // 
            // Bicola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 325);
            this.Controls.Add(this.btnDelH);
            this.Controls.Add(this.btnDelT);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.btnAddT);
            this.Controls.Add(this.btnAddH);
            this.Controls.Add(this.txtDato);
            this.Name = "Bicola";
            this.Text = "Bicola";
            this.Load += new System.EventHandler(this.Bicola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelH;
        private System.Windows.Forms.Button btnDelT;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Button btnAddT;
        private System.Windows.Forms.Button btnAddH;
        private System.Windows.Forms.TextBox txtDato;
    }
}