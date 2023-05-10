
namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtmontoPrestamo = new System.Windows.Forms.TextBox();
            this.txtNumCuotas = new System.Windows.Forms.TextBox();
            this.txtValorCuotas = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtInteresMensual = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.panelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(81, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos del prestamo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese el monto del prestamo a solicitar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingrese el numero de cuotas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Interes mensual en pesos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor de la cuota:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total a pagar por el credito:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(65, 58);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(51, 20);
            this.txtedad.TabIndex = 10;
            // 
            // txtmontoPrestamo
            // 
            this.txtmontoPrestamo.Location = new System.Drawing.Point(208, 106);
            this.txtmontoPrestamo.Name = "txtmontoPrestamo";
            this.txtmontoPrestamo.Size = new System.Drawing.Size(55, 20);
            this.txtmontoPrestamo.TabIndex = 11;
            // 
            // txtNumCuotas
            // 
            this.txtNumCuotas.Location = new System.Drawing.Point(193, 138);
            this.txtNumCuotas.Name = "txtNumCuotas";
            this.txtNumCuotas.Size = new System.Drawing.Size(70, 20);
            this.txtNumCuotas.TabIndex = 12;
            // 
            // txtValorCuotas
            // 
            this.txtValorCuotas.Location = new System.Drawing.Point(146, 39);
            this.txtValorCuotas.Name = "txtValorCuotas";
            this.txtValorCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtValorCuotas.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(146, 63);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(78, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // txtInteresMensual
            // 
            this.txtInteresMensual.Location = new System.Drawing.Point(146, 8);
            this.txtInteresMensual.Name = "txtInteresMensual";
            this.txtInteresMensual.Size = new System.Drawing.Size(100, 20);
            this.txtInteresMensual.TabIndex = 15;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCalcular.Location = new System.Drawing.Point(65, 164);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(155, 23);
            this.BtnCalcular.TabIndex = 16;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.txtInteresMensual);
            this.panelDatos.Controls.Add(this.txtTotal);
            this.panelDatos.Controls.Add(this.txtValorCuotas);
            this.panelDatos.Controls.Add(this.label9);
            this.panelDatos.Controls.Add(this.label8);
            this.panelDatos.Controls.Add(this.label7);
            this.panelDatos.Location = new System.Drawing.Point(10, 193);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(263, 90);
            this.panelDatos.TabIndex = 17;
            this.panelDatos.Visible = false;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(179, 61);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 13);
            this.lblmensaje.TabIndex = 18;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 296);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtNumCuotas);
            this.Controls.Add(this.txtmontoPrestamo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtmontoPrestamo;
        private System.Windows.Forms.TextBox txtNumCuotas;
        private System.Windows.Forms.TextBox txtValorCuotas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtInteresMensual;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblmensaje;
    }
}