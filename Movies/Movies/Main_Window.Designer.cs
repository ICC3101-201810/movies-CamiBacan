namespace Movies
{
    partial class Main_Window
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
            this.textBox_SearchBar = new System.Windows.Forms.TextBox();
            this.button_peliculas = new System.Windows.Forms.Button();
            this.button_actores = new System.Windows.Forms.Button();
            this.button_directores = new System.Windows.Forms.Button();
            this.Productores = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_estudios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_SearchBar
            // 
            this.textBox_SearchBar.Location = new System.Drawing.Point(77, 43);
            this.textBox_SearchBar.Name = "textBox_SearchBar";
            this.textBox_SearchBar.Size = new System.Drawing.Size(541, 26);
            this.textBox_SearchBar.TabIndex = 0;
            this.textBox_SearchBar.Text = "Search";
            this.textBox_SearchBar.TextChanged += new System.EventHandler(this.textBox_SearchBar_TextChanged);
            // 
            // button_peliculas
            // 
            this.button_peliculas.Location = new System.Drawing.Point(60, 94);
            this.button_peliculas.Name = "button_peliculas";
            this.button_peliculas.Size = new System.Drawing.Size(105, 34);
            this.button_peliculas.TabIndex = 1;
            this.button_peliculas.Text = "Películas";
            this.button_peliculas.UseVisualStyleBackColor = true;
            this.button_peliculas.Click += new System.EventHandler(this.button_peliculas_Click);
            // 
            // button_actores
            // 
            this.button_actores.Location = new System.Drawing.Point(191, 94);
            this.button_actores.Name = "button_actores";
            this.button_actores.Size = new System.Drawing.Size(105, 34);
            this.button_actores.TabIndex = 2;
            this.button_actores.Text = "Actores";
            this.button_actores.UseVisualStyleBackColor = true;
            // 
            // button_directores
            // 
            this.button_directores.Location = new System.Drawing.Point(315, 94);
            this.button_directores.Name = "button_directores";
            this.button_directores.Size = new System.Drawing.Size(105, 34);
            this.button_directores.TabIndex = 3;
            this.button_directores.Text = "Directores";
            this.button_directores.UseVisualStyleBackColor = true;
            // 
            // Productores
            // 
            this.Productores.Location = new System.Drawing.Point(446, 94);
            this.Productores.Name = "Productores";
            this.Productores.Size = new System.Drawing.Size(105, 34);
            this.Productores.TabIndex = 4;
            this.Productores.Text = "Productores";
            this.Productores.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(610, 396);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(111, 32);
            this.button_salir.TabIndex = 6;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(48, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(688, 221);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button_estudios
            // 
            this.button_estudios.Location = new System.Drawing.Point(576, 94);
            this.button_estudios.Name = "button_estudios";
            this.button_estudios.Size = new System.Drawing.Size(105, 34);
            this.button_estudios.TabIndex = 7;
            this.button_estudios.Text = "Estudios";
            this.button_estudios.UseVisualStyleBackColor = true;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_estudios);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Productores);
            this.Controls.Add(this.button_directores);
            this.Controls.Add(this.button_actores);
            this.Controls.Add(this.button_peliculas);
            this.Controls.Add(this.textBox_SearchBar);
            this.Name = "Main_Window";
            this.Text = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SearchBar;
        private System.Windows.Forms.Button button_peliculas;
        private System.Windows.Forms.Button button_actores;
        private System.Windows.Forms.Button button_directores;
        private System.Windows.Forms.Button Productores;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_estudios;
    }
}