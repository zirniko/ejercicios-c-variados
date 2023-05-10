
namespace WindowsFormsApplication1
{
    partial class Form13
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbEmpanadas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbChilenitos = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.pnlEmpanadas = new System.Windows.Forms.Panel();
            this.pnlChilenitos = new System.Windows.Forms.Panel();
            this.pnlEmpanadas.SuspendLayout();
            this.pnlChilenitos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(82, 12);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(70, 20);
            this.txtCantidad1.TabIndex = 1;
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Location = new System.Drawing.Point(82, 20);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(70, 20);
            this.txtCantidad2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // chbEmpanadas
            // 
            this.chbEmpanadas.AutoSize = true;
            this.chbEmpanadas.Location = new System.Drawing.Point(89, 32);
            this.chbEmpanadas.Name = "chbEmpanadas";
            this.chbEmpanadas.Size = new System.Drawing.Size(15, 14);
            this.chbEmpanadas.TabIndex = 4;
            this.chbEmpanadas.UseVisualStyleBackColor = true;
            this.chbEmpanadas.CheckedChanged += new System.EventHandler(this.chbEmpanadas_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empanadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Cada docena 12,000)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "(Cada docena 2,500)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chilenitos:";
            // 
            // chbChilenitos
            // 
            this.chbChilenitos.AutoSize = true;
            this.chbChilenitos.Location = new System.Drawing.Point(89, 96);
            this.chbChilenitos.Name = "chbChilenitos";
            this.chbChilenitos.Size = new System.Drawing.Size(15, 14);
            this.chbChilenitos.TabIndex = 7;
            this.chbChilenitos.UseVisualStyleBackColor = true;
            this.chbChilenitos.CheckedChanged += new System.EventHandler(this.chbChilenitos_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Solo se vende por docena";
            // 
            // BtnTotal
            // 
            this.BtnTotal.Location = new System.Drawing.Point(174, 149);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(129, 32);
            this.BtnTotal.TabIndex = 11;
            this.BtnTotal.Text = "Total";
            this.BtnTotal.UseVisualStyleBackColor = true;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // pnlEmpanadas
            // 
            this.pnlEmpanadas.Controls.Add(this.label1);
            this.pnlEmpanadas.Controls.Add(this.txtCantidad1);
            this.pnlEmpanadas.Location = new System.Drawing.Point(141, 12);
            this.pnlEmpanadas.Name = "pnlEmpanadas";
            this.pnlEmpanadas.Size = new System.Drawing.Size(162, 57);
            this.pnlEmpanadas.TabIndex = 12;
            this.pnlEmpanadas.Visible = false;
            // 
            // pnlChilenitos
            // 
            this.pnlChilenitos.Controls.Add(this.label2);
            this.pnlChilenitos.Controls.Add(this.txtCantidad2);
            this.pnlChilenitos.Location = new System.Drawing.Point(141, 80);
            this.pnlChilenitos.Name = "pnlChilenitos";
            this.pnlChilenitos.Size = new System.Drawing.Size(162, 56);
            this.pnlChilenitos.TabIndex = 13;
            this.pnlChilenitos.Visible = false;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 197);
            this.Controls.Add(this.pnlChilenitos);
            this.Controls.Add(this.pnlEmpanadas);
            this.Controls.Add(this.BtnTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chbChilenitos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbEmpanadas);
            this.Name = "Form13";
            this.Text = "Form13";
            this.pnlEmpanadas.ResumeLayout(false);
            this.pnlEmpanadas.PerformLayout();
            this.pnlChilenitos.ResumeLayout(false);
            this.pnlChilenitos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbEmpanadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbChilenitos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnTotal;
        private System.Windows.Forms.Panel pnlEmpanadas;
        private System.Windows.Forms.Panel pnlChilenitos;
    }
}