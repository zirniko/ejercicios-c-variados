namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.Btnpromedio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAprobado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlReprobado = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlAprobado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlReprobado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nota 2";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(156, 26);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 20);
            this.txtnota1.TabIndex = 2;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(156, 52);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 20);
            this.txtnota2.TabIndex = 3;
            // 
            // Btnpromedio
            // 
            this.Btnpromedio.Location = new System.Drawing.Point(98, 118);
            this.Btnpromedio.Name = "Btnpromedio";
            this.Btnpromedio.Size = new System.Drawing.Size(129, 23);
            this.Btnpromedio.TabIndex = 4;
            this.Btnpromedio.Text = "Obtener promedio";
            this.Btnpromedio.UseVisualStyleBackColor = true;
            this.Btnpromedio.Click += new System.EventHandler(this.Btnpromedio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promedio";
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(145, 168);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(100, 20);
            this.txtpromedio.TabIndex = 7;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(156, 79);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 20);
            this.txtnota3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "nota 3";
            // 
            // pnlAprobado
            // 
            this.pnlAprobado.Controls.Add(this.pictureBox1);
            this.pnlAprobado.Location = new System.Drawing.Point(313, 26);
            this.pnlAprobado.Name = "pnlAprobado";
            this.pnlAprobado.Size = new System.Drawing.Size(175, 150);
            this.pnlAprobado.TabIndex = 10;
            this.pnlAprobado.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlReprobado
            // 
            this.pnlReprobado.Controls.Add(this.pictureBox2);
            this.pnlReprobado.Location = new System.Drawing.Point(505, 26);
            this.pnlReprobado.Name = "pnlReprobado";
            this.pnlReprobado.Size = new System.Drawing.Size(161, 150);
            this.pnlReprobado.TabIndex = 11;
            this.pnlReprobado.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 227);
            this.Controls.Add(this.pnlReprobado);
            this.Controls.Add(this.pnlAprobado);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btnpromedio);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAprobado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlReprobado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.Button Btnpromedio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAprobado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlReprobado;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

