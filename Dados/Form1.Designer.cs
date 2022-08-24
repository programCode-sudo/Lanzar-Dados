namespace Dados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cara1.jpg");
            this.imageList1.Images.SetKeyName(1, "Cara2.jpg");
            this.imageList1.Images.SetKeyName(2, "Cara3.jpg");
            this.imageList1.Images.SetKeyName(3, "Cara4.jpg");
            this.imageList1.Images.SetKeyName(4, "Cara5.jpg");
            this.imageList1.Images.SetKeyName(5, "Cara6.jpg");
            // 
            // pBox1
            // 
            this.pBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBox1.Location = new System.Drawing.Point(291, 29);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(203, 211);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBox1.TabIndex = 0;
            this.pBox1.TabStop = false;
            // 
            // pBox2
            // 
            this.pBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBox2.Location = new System.Drawing.Point(553, 29);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(203, 211);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBox2.TabIndex = 1;
            this.pBox2.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.White;
            this.btnJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btnJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Location = new System.Drawing.Point(76, 70);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(128, 37);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPuntuacion.Location = new System.Drawing.Point(516, 264);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(78, 13);
            this.lblPuntuacion.TabIndex = 3;
            this.lblPuntuacion.Text = "PUNTUACION";
            // 
            // btnLanzar
            // 
            this.btnLanzar.Enabled = false;
            this.btnLanzar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLanzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanzar.Location = new System.Drawing.Point(76, 140);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(128, 35);
            this.btnLanzar.TabIndex = 4;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dados.Properties.Resources._15526637_las_vegas_casino_background;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.pBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Label label2;
    }
}

