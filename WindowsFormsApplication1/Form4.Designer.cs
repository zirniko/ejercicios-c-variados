
namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.chbox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbox1
            // 
            this.chbox1.AutoSize = true;
            this.chbox1.Location = new System.Drawing.Point(326, 98);
            this.chbox1.Name = "chbox1";
            this.chbox1.Size = new System.Drawing.Size(15, 14);
            this.chbox1.TabIndex = 0;
            this.chbox1.UseVisualStyleBackColor = true;
            this.chbox1.CheckedChanged += new System.EventHandler(this.chbox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esto es un Checkbox";
            // 
            // pnlPanel
            // 
            this.pnlPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPanel.Controls.Add(this.lbl1);
            this.pnlPanel.Location = new System.Drawing.Point(117, 139);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(246, 134);
            this.pnlPanel.TabIndex = 2;
            this.pnlPanel.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(76, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "label2";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 359);
            this.Controls.Add(this.pnlPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.pnlPanel.ResumeLayout(false);
            this.pnlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.Label lbl1;
    }
}