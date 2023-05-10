
namespace WindowsFormsApplication1
{
    partial class Form6
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.BtnAutentificar = new System.Windows.Forms.Button();
            this.pnlpermitido = new System.Windows.Forms.Panel();
            this.pnlDenegado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Autorizar = new System.Windows.Forms.PictureBox();
            this.pnlpermitido.SuspendLayout();
            this.pnlDenegado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Autorizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(142, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(142, 87);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // BtnAutentificar
            // 
            this.BtnAutentificar.Location = new System.Drawing.Point(142, 129);
            this.BtnAutentificar.Name = "BtnAutentificar";
            this.BtnAutentificar.Size = new System.Drawing.Size(75, 23);
            this.BtnAutentificar.TabIndex = 4;
            this.BtnAutentificar.Text = "Autentificar";
            this.BtnAutentificar.UseVisualStyleBackColor = true;
            this.BtnAutentificar.Click += new System.EventHandler(this.BtnAutentificar_Click);
            // 
            // pnlpermitido
            // 
            this.pnlpermitido.Controls.Add(this.Autorizar);
            this.pnlpermitido.Location = new System.Drawing.Point(47, 189);
            this.pnlpermitido.Name = "pnlpermitido";
            this.pnlpermitido.Size = new System.Drawing.Size(109, 87);
            this.pnlpermitido.TabIndex = 5;
            this.pnlpermitido.Visible = false;
            // 
            // pnlDenegado
            // 
            this.pnlDenegado.Controls.Add(this.pictureBox1);
            this.pnlDenegado.Location = new System.Drawing.Point(222, 189);
            this.pnlDenegado.Name = "pnlDenegado";
            this.pnlDenegado.Size = new System.Drawing.Size(110, 77);
            this.pnlDenegado.TabIndex = 6;
            this.pnlDenegado.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.rechazado;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Autorizar
            // 
            this.Autorizar.Image = global::WindowsFormsApplication1.Properties.Resources.permitido;
            this.Autorizar.Location = new System.Drawing.Point(3, 14);
            this.Autorizar.Name = "Autorizar";
            this.Autorizar.Size = new System.Drawing.Size(100, 50);
            this.Autorizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Autorizar.TabIndex = 0;
            this.Autorizar.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 288);
            this.Controls.Add(this.pnlDenegado);
            this.Controls.Add(this.pnlpermitido);
            this.Controls.Add(this.BtnAutentificar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.pnlpermitido.ResumeLayout(false);
            this.pnlDenegado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Autorizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button BtnAutentificar;
        private System.Windows.Forms.Panel pnlpermitido;
        private System.Windows.Forms.PictureBox Autorizar;
        private System.Windows.Forms.Panel pnlDenegado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}