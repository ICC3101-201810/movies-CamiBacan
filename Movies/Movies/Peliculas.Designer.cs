namespace Movies
{
    partial class Peliculas
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
            this.listBox_peliculas = new System.Windows.Forms.ListBox();
            this.button_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Películas";
            // 
            // listBox_peliculas
            // 
            this.listBox_peliculas.FormattingEnabled = true;
            this.listBox_peliculas.ItemHeight = 20;
            this.listBox_peliculas.Location = new System.Drawing.Point(59, 113);
            this.listBox_peliculas.Name = "listBox_peliculas";
            this.listBox_peliculas.Size = new System.Drawing.Size(652, 224);
            this.listBox_peliculas.TabIndex = 1;
            this.listBox_peliculas.SelectedIndexChanged += new System.EventHandler(this.listBox_peliculas_SelectedIndexChanged);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(611, 366);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(137, 42);
            this.button_salir.TabIndex = 2;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.listBox_peliculas);
            this.Controls.Add(this.label1);
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_peliculas;
        private System.Windows.Forms.Button button_salir;
    }
}