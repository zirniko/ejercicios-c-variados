﻿
namespace WindowsFormsApplication1
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.BtnSueldoLiquido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese sueldo bruto";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(164, 38);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(141, 20);
            this.txtSueldo.TabIndex = 2;
            // 
            // BtnSueldoLiquido
            // 
            this.BtnSueldoLiquido.Location = new System.Drawing.Point(115, 104);
            this.BtnSueldoLiquido.Name = "BtnSueldoLiquido";
            this.BtnSueldoLiquido.Size = new System.Drawing.Size(145, 47);
            this.BtnSueldoLiquido.TabIndex = 3;
            this.BtnSueldoLiquido.Text = "Suledo Liquido";
            this.BtnSueldoLiquido.UseVisualStyleBackColor = true;
            this.BtnSueldoLiquido.Click += new System.EventHandler(this.BtnSueldoLiquido_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 225);
            this.Controls.Add(this.BtnSueldoLiquido);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button BtnSueldoLiquido;
    }
}