namespace Movies
{
    partial class PerfilPersonas
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
            this.label_tipoPersona = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_tipoPersona
            // 
            this.label_tipoPersona.AutoSize = true;
            this.label_tipoPersona.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipoPersona.Location = new System.Drawing.Point(44, 41);
            this.label_tipoPersona.Name = "label_tipoPersona";
            this.label_tipoPersona.Size = new System.Drawing.Size(210, 40);
            this.label_tipoPersona.TabIndex = 1;
            this.label_tipoPersona.Text = "[label tipo]:";
            this.label_tipoPersona.Click += new System.EventHandler(this.label_tipoPersona_Click);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(260, 46);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(228, 35);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "[label nombre]";
            this.label_nombre.Click += new System.EventHandler(this.label_nombre_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(58, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 285);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(653, 356);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(109, 39);
            this.button_salir.TabIndex = 4;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // PerfilPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_tipoPersona);
            this.Name = "PerfilPersonas";
            this.Text = "PerfilPersonas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tipoPersona;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_salir;
    }
}