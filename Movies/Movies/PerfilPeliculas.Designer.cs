namespace Movies
{
    partial class PerfilPeliculas
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
            this.listView_peliculas = new System.Windows.Forms.ListView();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_tipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(650, 363);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(109, 39);
            this.button_salir.TabIndex = 8;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // listView_peliculas
            // 
            this.listView_peliculas.Location = new System.Drawing.Point(55, 117);
            this.listView_peliculas.Name = "listView_peliculas";
            this.listView_peliculas.Size = new System.Drawing.Size(538, 285);
            this.listView_peliculas.TabIndex = 7;
            this.listView_peliculas.UseCompatibleStateImageBehavior = false;
            this.listView_peliculas.View = System.Windows.Forms.View.List;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(257, 53);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(228, 35);
            this.label_nombre.TabIndex = 6;
            this.label_nombre.Text = "[label nombre]";
            // 
            // label_tipo
            // 
            this.label_tipo.AutoSize = true;
            this.label_tipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipo.Location = new System.Drawing.Point(41, 48);
            this.label_tipo.Name = "label_tipo";
            this.label_tipo.Size = new System.Drawing.Size(210, 40);
            this.label_tipo.TabIndex = 5;
            this.label_tipo.Text = "[label tipo]:";
            // 
            // PerfilPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.listView_peliculas);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_tipo);
            this.Name = "PerfilPeliculas";
            this.Text = "PerfilOtrasCosas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.ListView listView_peliculas;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_tipo;
    }
}