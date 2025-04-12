namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSaludar = new System.Windows.Forms.Button();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxSeccion = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxnota1 = new System.Windows.Forms.TextBox();
            this.textBoxnota2 = new System.Windows.Forms.TextBox();
            this.textBoxnota3 = new System.Windows.Forms.TextBox();
            this.textBoxnota4 = new System.Windows.Forms.TextBox();
            this.buttonNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaludar
            // 
            this.buttonSaludar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSaludar.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaludar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonSaludar.Location = new System.Drawing.Point(55, 349);
            this.buttonSaludar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaludar.Name = "buttonSaludar";
            this.buttonSaludar.Size = new System.Drawing.Size(111, 31);
            this.buttonSaludar.TabIndex = 0;
            this.buttonSaludar.Text = "Saludar";
            this.buttonSaludar.UseVisualStyleBackColor = false;
            this.buttonSaludar.Click += new System.EventHandler(this.buttonSaludar_Click);
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(188, 120);
            this.textBoxCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(132, 22);
            this.textBoxCarnet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(188, 168);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(280, 22);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxSeccion
            // 
            this.textBoxSeccion.Location = new System.Drawing.Point(188, 218);
            this.textBoxSeccion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSeccion.Name = "textBoxSeccion";
            this.textBoxSeccion.Size = new System.Drawing.Size(49, 22);
            this.textBoxSeccion.TabIndex = 7;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(188, 274);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(326, 22);
            this.textBoxCorreo.TabIndex = 8;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBuscar.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonBuscar.Location = new System.Drawing.Point(350, 111);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(72, 39);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonInsertar.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonInsertar.Location = new System.Drawing.Point(188, 349);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(89, 35);
            this.buttonInsertar.TabIndex = 10;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Información de estudiante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(635, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Notas del estudiante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(632, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nota 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(632, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nota 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nota 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nota 4";
            // 
            // textBoxnota1
            // 
            this.textBoxnota1.Location = new System.Drawing.Point(702, 125);
            this.textBoxnota1.Name = "textBoxnota1";
            this.textBoxnota1.Size = new System.Drawing.Size(250, 22);
            this.textBoxnota1.TabIndex = 17;
            // 
            // textBoxnota2
            // 
            this.textBoxnota2.Location = new System.Drawing.Point(702, 180);
            this.textBoxnota2.Name = "textBoxnota2";
            this.textBoxnota2.Size = new System.Drawing.Size(44, 22);
            this.textBoxnota2.TabIndex = 18;
            // 
            // textBoxnota3
            // 
            this.textBoxnota3.Location = new System.Drawing.Point(702, 234);
            this.textBoxnota3.Name = "textBoxnota3";
            this.textBoxnota3.Size = new System.Drawing.Size(42, 22);
            this.textBoxnota3.TabIndex = 19;
            // 
            // textBoxnota4
            // 
            this.textBoxnota4.Location = new System.Drawing.Point(702, 284);
            this.textBoxnota4.Name = "textBoxnota4";
            this.textBoxnota4.Size = new System.Drawing.Size(43, 22);
            this.textBoxnota4.TabIndex = 20;
            // 
            // buttonNotas
            // 
            this.buttonNotas.BackColor = System.Drawing.Color.Bisque;
            this.buttonNotas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotas.Location = new System.Drawing.Point(807, 183);
            this.buttonNotas.Name = "buttonNotas";
            this.buttonNotas.Size = new System.Drawing.Size(109, 53);
            this.buttonNotas.TabIndex = 21;
            this.buttonNotas.Text = "Ver notas";
            this.buttonNotas.UseVisualStyleBackColor = false;
            this.buttonNotas.Click += new System.EventHandler(this.buttonNotas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonNotas);
            this.Controls.Add(this.textBoxnota4);
            this.Controls.Add(this.textBoxnota3);
            this.Controls.Add(this.textBoxnota2);
            this.Controls.Add(this.textBoxnota1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxSeccion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.buttonSaludar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludar;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxSeccion;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxnota1;
        private System.Windows.Forms.TextBox textBoxnota2;
        private System.Windows.Forms.TextBox textBoxnota3;
        private System.Windows.Forms.TextBox textBoxnota4;
        private System.Windows.Forms.Button buttonNotas;
    }
}

