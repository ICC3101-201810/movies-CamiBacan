﻿namespace Movies
{
    partial class Estudios
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
            this.button_salir = new System.Windows.Forms.Button();
            this.listBox_estudios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(611, 364);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(137, 42);
            this.button_salir.TabIndex = 14;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // listBox_estudios
            // 
            this.listBox_estudios.FormattingEnabled = true;
            this.listBox_estudios.ItemHeight = 20;
            this.listBox_estudios.Location = new System.Drawing.Point(59, 111);
            this.listBox_estudios.Name = "listBox_estudios";
            this.listBox_estudios.Size = new System.Drawing.Size(652, 224);
            this.listBox_estudios.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Estudios";
            // 
            // Estudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.listBox_estudios);
            this.Controls.Add(this.label1);
            this.Name = "Estudios";
            this.Text = "Estudios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.ListBox listBox_estudios;
        private System.Windows.Forms.Label label1;
    }
}