namespace ProyectoEstructuras
{
    partial class ColaCircular
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
            this.btnDel = new System.Windows.Forms.Button();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 218);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(271, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Quitar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtCola
            // 
            this.txtCola.Location = new System.Drawing.Point(12, 49);
            this.txtCola.Multiline = true;
            this.txtCola.Name = "txtCola";
            this.txtCola.ReadOnly = true;
            this.txtCola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCola.Size = new System.Drawing.Size(271, 160);
            this.txtCola.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(12, 15);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(156, 20);
            this.txtDato.TabIndex = 4;
            // 
            // ColaCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 252);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDato);
            this.Name = "ColaCircular";
            this.Text = "ColaCircular";
            this.Load += new System.EventHandler(this.ColaCircular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDato;
    }
}