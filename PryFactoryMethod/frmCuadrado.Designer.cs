﻿namespace PryFactoryMethod
{
    partial class frmCuadrado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linfo = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrp = new System.Windows.Forms.TextBox();
            this.btnperimetro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnarea = new System.Windows.Forms.Button();
            this.txtladop = new System.Windows.Forms.TextBox();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.linfo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtrp);
            this.panel1.Controls.Add(this.btnperimetro);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnarea);
            this.panel1.Controls.Add(this.txtladop);
            this.panel1.Controls.Add(this.txtlado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 359);
            this.panel1.TabIndex = 3;
            // 
            // linfo
            // 
            this.linfo.FormattingEnabled = true;
            this.linfo.Location = new System.Drawing.Point(228, 239);
            this.linfo.Name = "linfo";
            this.linfo.Size = new System.Drawing.Size(206, 95);
            this.linfo.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(259, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 102;
            this.label7.Text = "Informacion";
            // 
            // txtrp
            // 
            this.txtrp.AcceptsReturn = true;
            this.txtrp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtrp.Location = new System.Drawing.Point(490, 306);
            this.txtrp.Name = "txtrp";
            this.txtrp.Size = new System.Drawing.Size(92, 33);
            this.txtrp.TabIndex = 101;
            // 
            // btnperimetro
            // 
            this.btnperimetro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnperimetro.Location = new System.Drawing.Point(443, 174);
            this.btnperimetro.Name = "btnperimetro";
            this.btnperimetro.Size = new System.Drawing.Size(157, 50);
            this.btnperimetro.TabIndex = 100;
            this.btnperimetro.Text = "calcular";
            this.btnperimetro.UseVisualStyleBackColor = true;
            this.btnperimetro.Click += new System.EventHandler(this.btnperimetro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(349, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 25);
            this.label6.TabIndex = 99;
            this.label6.Text = "Perimetro de un cuadrado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(485, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Resultado";
            // 
            // txtra
            // 
            this.txtra.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtra.Location = new System.Drawing.Point(83, 306);
            this.txtra.Name = "txtra";
            this.txtra.Size = new System.Drawing.Size(92, 33);
            this.txtra.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(78, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Resultado";
            // 
            // btnarea
            // 
            this.btnarea.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnarea.Location = new System.Drawing.Point(57, 174);
            this.btnarea.Name = "btnarea";
            this.btnarea.Size = new System.Drawing.Size(157, 50);
            this.btnarea.TabIndex = 15;
            this.btnarea.Text = "calcular";
            this.btnarea.UseVisualStyleBackColor = true;
            this.btnarea.Click += new System.EventHandler(this.btnarea_Click);
            // 
            // txtladop
            // 
            this.txtladop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtladop.Location = new System.Drawing.Point(490, 97);
            this.txtladop.Name = "txtladop";
            this.txtladop.Size = new System.Drawing.Size(110, 33);
            this.txtladop.TabIndex = 13;
            // 
            // txtlado
            // 
            this.txtlado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtlado.Location = new System.Drawing.Point(106, 97);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(108, 33);
            this.txtlado.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(405, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Area de un cuadrado";
            // 
            // frmCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(676, 389);
            this.Controls.Add(this.panel1);
            this.Name = "frmCuadrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCuadrado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox linfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrp;
        private System.Windows.Forms.Button btnperimetro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnarea;
        private System.Windows.Forms.TextBox txtladop;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}