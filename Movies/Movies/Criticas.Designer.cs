namespace Movies
{
    partial class Criticas
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Nombre", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.listView_criticas = new System.Windows.Forms.ListView();
            this.button_createReview = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_mensaje = new System.Windows.Forms.RichTextBox();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mensaje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "[Nombre pelicula]";
            // 
            // listView_criticas
            // 
            this.listView_criticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Mensaje});
            listViewGroup2.Header = "Nombre";
            listViewGroup2.Name = "listViewGroup1";
            this.listView_criticas.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView_criticas.Location = new System.Drawing.Point(12, 71);
            this.listView_criticas.Name = "listView_criticas";
            this.listView_criticas.Size = new System.Drawing.Size(427, 322);
            this.listView_criticas.TabIndex = 1;
            this.listView_criticas.UseCompatibleStateImageBehavior = false;
            this.listView_criticas.View = System.Windows.Forms.View.Details;
            this.listView_criticas.SelectedIndexChanged += new System.EventHandler(this.listView_criticas_SelectedIndexChanged);
            // 
            // button_createReview
            // 
            this.button_createReview.Location = new System.Drawing.Point(643, 282);
            this.button_createReview.Name = "button_createReview";
            this.button_createReview.Size = new System.Drawing.Size(128, 39);
            this.button_createReview.TabIndex = 2;
            this.button_createReview.Text = "Hacer critica";
            this.button_createReview.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(558, 385);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(213, 39);
            this.button_salir.TabIndex = 3;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(558, 93);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(194, 26);
            this.textBox_nombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mensaje:";
            // 
            // richTextBox_mensaje
            // 
            this.richTextBox_mensaje.Location = new System.Drawing.Point(558, 141);
            this.richTextBox_mensaje.Name = "richTextBox_mensaje";
            this.richTextBox_mensaje.Size = new System.Drawing.Size(194, 130);
            this.richTextBox_mensaje.TabIndex = 7;
            this.richTextBox_mensaje.Text = "";
            // 
            // Nombre
            // 
            this.Nombre.Width = 135;
            // 
            // Mensaje
            // 
            this.Mensaje.Width = 301;
            // 
            // Criticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_mensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_createReview);
            this.Controls.Add(this.listView_criticas);
            this.Controls.Add(this.label1);
            this.Name = "Criticas";
            this.Text = "Criticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_criticas;
        private System.Windows.Forms.Button button_createReview;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_mensaje;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Mensaje;
    }
}