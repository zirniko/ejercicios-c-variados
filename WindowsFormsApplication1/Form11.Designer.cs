
namespace WindowsFormsApplication1
{
    partial class Form11
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
            this.txtSueldobruto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chBono = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSueldoLiqudo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesAFP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesSeguro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFonasa = new System.Windows.Forms.TextBox();
            this.BtnSueldoLiquido = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liquidacion";
            // 
            // txtSueldobruto
            // 
            this.txtSueldobruto.Location = new System.Drawing.Point(207, 46);
            this.txtSueldobruto.Name = "txtSueldobruto";
            this.txtSueldobruto.Size = new System.Drawing.Size(122, 20);
            this.txtSueldobruto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese sueldo bruto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiene Bono:";
            // 
            // chBono
            // 
            this.chBono.AutoSize = true;
            this.chBono.Location = new System.Drawing.Point(207, 87);
            this.chBono.Name = "chBono";
            this.chBono.Size = new System.Drawing.Size(15, 14);
            this.chBono.TabIndex = 4;
            this.chBono.UseVisualStyleBackColor = true;
            this.chBono.CheckedChanged += new System.EventHandler(this.chBono_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSueldoLiqudo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDesAFP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDesSeguro);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFonasa);
            this.panel1.Location = new System.Drawing.Point(75, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 197);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "El sueldo liquido es:";
            // 
            // txtSueldoLiqudo
            // 
            this.txtSueldoLiqudo.Location = new System.Drawing.Point(242, 172);
            this.txtSueldoLiqudo.Name = "txtSueldoLiqudo";
            this.txtSueldoLiqudo.Size = new System.Drawing.Size(122, 20);
            this.txtSueldoLiqudo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "El descuento por AFP es :  (11%)";
            // 
            // txtDesAFP
            // 
            this.txtDesAFP.Location = new System.Drawing.Point(242, 124);
            this.txtDesAFP.Name = "txtDesAFP";
            this.txtDesAFP.Size = new System.Drawing.Size(122, 20);
            this.txtDesAFP.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "El descuento por Seguro es: (3%)";
            // 
            // txtDesSeguro
            // 
            this.txtDesSeguro.Location = new System.Drawing.Point(242, 85);
            this.txtDesSeguro.Name = "txtDesSeguro";
            this.txtDesSeguro.Size = new System.Drawing.Size(122, 20);
            this.txtDesSeguro.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "El descuento por fonasa(7%):";
            // 
            // txtFonasa
            // 
            this.txtFonasa.Location = new System.Drawing.Point(239, 39);
            this.txtFonasa.Name = "txtFonasa";
            this.txtFonasa.Size = new System.Drawing.Size(122, 20);
            this.txtFonasa.TabIndex = 6;
            // 
            // BtnSueldoLiquido
            // 
            this.BtnSueldoLiquido.Location = new System.Drawing.Point(301, 76);
            this.BtnSueldoLiquido.Name = "BtnSueldoLiquido";
            this.BtnSueldoLiquido.Size = new System.Drawing.Size(135, 25);
            this.BtnSueldoLiquido.TabIndex = 6;
            this.BtnSueldoLiquido.Text = "Obtener Sueldo Liquido";
            this.BtnSueldoLiquido.UseVisualStyleBackColor = true;
            this.BtnSueldoLiquido.Click += new System.EventHandler(this.BtnSueldoLiquido_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "(Si tiene bono se aumenta el sueldo bruto en 12%)";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 380);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnSueldoLiquido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chBono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSueldobruto);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldobruto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSueldoLiqudo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesAFP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesSeguro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFonasa;
        private System.Windows.Forms.Button BtnSueldoLiquido;
        private System.Windows.Forms.Label label8;
    }
}