
namespace WindowsFormsApplication1
{
    partial class Form14
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
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChbAsistencia = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNotaExamen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labeL6 = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.pnlResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el promedio de notas:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(211, 64);
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.Size = new System.Drawing.Size(167, 20);
            this.TxtNotas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cumple con la asistecia minima:";
            // 
            // ChbAsistencia
            // 
            this.ChbAsistencia.AutoSize = true;
            this.ChbAsistencia.Location = new System.Drawing.Point(211, 92);
            this.ChbAsistencia.Name = "ChbAsistencia";
            this.ChbAsistencia.Size = new System.Drawing.Size(15, 14);
            this.ChbAsistencia.TabIndex = 3;
            this.ChbAsistencia.UseVisualStyleBackColor = true;
            this.ChbAsistencia.CheckedChanged += new System.EventHandler(this.ChbAsistencia_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota: SI no cumple con la asistencia minima quedara reprobado por asistencia";
            // 
            // BtnNotaExamen
            // 
            this.BtnNotaExamen.Location = new System.Drawing.Point(36, 165);
            this.BtnNotaExamen.Name = "BtnNotaExamen";
            this.BtnNotaExamen.Size = new System.Drawing.Size(156, 23);
            this.BtnNotaExamen.TabIndex = 5;
            this.BtnNotaExamen.Text = "Obtener Nota Examen";
            this.BtnNotaExamen.UseVisualStyleBackColor = true;
            this.BtnNotaExamen.Click += new System.EventHandler(this.BtnNotaExamen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(198, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota:El promedio equivale a un 70% y la nota del examen a un 30%";
            // 
            // pnlResultado
            // 
            this.pnlResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlResultado.Controls.Add(this.TxtResultado);
            this.pnlResultado.Controls.Add(this.label5);
            this.pnlResultado.Location = new System.Drawing.Point(39, 215);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(407, 60);
            this.pnlResultado.TabIndex = 7;
            this.pnlResultado.Visible = false;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(227, 22);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(100, 20);
            this.TxtResultado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "La nota que debe obtener es :";
            // 
            // labeL6
            // 
            this.labeL6.AutoSize = true;
            this.labeL6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labeL6.ForeColor = System.Drawing.Color.White;
            this.labeL6.Location = new System.Drawing.Point(225, 21);
            this.labeL6.Name = "labeL6";
            this.labeL6.Size = new System.Drawing.Size(71, 13);
            this.labeL6.TabIndex = 8;
            this.labeL6.Text = "Nota Examen";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(250, 93);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 13);
            this.lblmensaje.TabIndex = 9;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 303);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.labeL6);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnNotaExamen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChbAsistencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNotas);
            this.Controls.Add(this.label1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChbAsistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNotaExamen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeL6;
        private System.Windows.Forms.Label lblmensaje;
    }
}