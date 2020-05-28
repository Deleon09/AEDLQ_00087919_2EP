namespace ParcialPOO2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.btnCambiarcontrasena = new System.Windows.Forms.Button();
            this.btnIniciarsesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasena:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(287, 142);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(126, 23);
            this.cmbUsuario.TabIndex = 2;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(288, 192);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(125, 23);
            this.txtcontrasena.TabIndex = 3;
            this.txtcontrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontrasena_KeyDown);
            // 
            // btnCambiarcontrasena
            // 
            this.btnCambiarcontrasena.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnCambiarcontrasena.ForeColor = System.Drawing.Color.White;
            this.btnCambiarcontrasena.Location = new System.Drawing.Point(87, 273);
            this.btnCambiarcontrasena.Name = "btnCambiarcontrasena";
            this.btnCambiarcontrasena.Size = new System.Drawing.Size(143, 54);
            this.btnCambiarcontrasena.TabIndex = 4;
            this.btnCambiarcontrasena.Text = "Cambiar contrasena";
            this.btnCambiarcontrasena.UseVisualStyleBackColor = false;
            this.btnCambiarcontrasena.Click += new System.EventHandler(this.btnCambiarcontrasena_Click);
            // 
            // btnIniciarsesion
            // 
            this.btnIniciarsesion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnIniciarsesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarsesion.Location = new System.Drawing.Point(269, 273);
            this.btnIniciarsesion.Name = "btnIniciarsesion";
            this.btnIniciarsesion.Size = new System.Drawing.Size(143, 54);
            this.btnIniciarsesion.TabIndex = 5;
            this.btnIniciarsesion.Text = "Iniciar sesion";
            this.btnIniciarsesion.UseVisualStyleBackColor = false;
            this.btnIniciarsesion.Click += new System.EventHandler(this.btnIniciarsesion_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(156, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "HUGO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(464, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIniciarsesion);
            this.Controls.Add(this.btnCambiarcontrasena);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btnIniciarsesion;
        private System.Windows.Forms.Button btnCambiarcontrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}