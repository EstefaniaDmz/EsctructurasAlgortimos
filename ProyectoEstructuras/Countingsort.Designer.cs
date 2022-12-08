namespace ProyectoEstructuras
{
    partial class Countingsort
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
            this.btnDoDes = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoAsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoDes
            // 
            this.btnDoDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoDes.Location = new System.Drawing.Point(249, 72);
            this.btnDoDes.Name = "btnDoDes";
            this.btnDoDes.Size = new System.Drawing.Size(193, 22);
            this.btnDoDes.TabIndex = 46;
            this.btnDoDes.Text = "Ordenar Descendente";
            this.btnDoDes.UseVisualStyleBackColor = true;
            this.btnDoDes.Click += new System.EventHandler(this.btnDoDes_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(266, 12);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(176, 22);
            this.btnRandom.TabIndex = 45;
            this.btnRandom.Text = "Crear arreglo random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(17, 308);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(425, 23);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(17, 100);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(425, 202);
            this.txtResultado.TabIndex = 43;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(20, 46);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(422, 20);
            this.txtNum.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ingresar números a ordenar separados por comas:";
            // 
            // btnDoAsc
            // 
            this.btnDoAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoAsc.Location = new System.Drawing.Point(17, 72);
            this.btnDoAsc.Name = "btnDoAsc";
            this.btnDoAsc.Size = new System.Drawing.Size(196, 22);
            this.btnDoAsc.TabIndex = 40;
            this.btnDoAsc.Text = "Ordenar Ascendente";
            this.btnDoAsc.UseVisualStyleBackColor = true;
            this.btnDoAsc.Click += new System.EventHandler(this.btnDoAsc_Click);
            // 
            // Countingsort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 341);
            this.Controls.Add(this.btnDoDes);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoAsc);
            this.Name = "Countingsort";
            this.Text = "Countingsort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoDes;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoAsc;
    }
}