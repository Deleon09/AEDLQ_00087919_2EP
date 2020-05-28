using System.ComponentModel;

namespace ParcialPOO2
{
    partial class frmCambiarContra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
                new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUsuarioCambiarcontra = new System.Windows.Forms.ComboBox();
            this.txtContrasenactual = new System.Windows.Forms.TextBox();
            this.txtContrasenanueva = new System.Windows.Forms.TextBox();
            this.txtRepetirnueva = new System.Windows.Forms.TextBox();
            this.btnCambiarcontrasena = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasena actual:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contrasena nueva:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(233, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Repetir nueva:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUsuarioCambiarcontra
            // 
            this.cmbUsuarioCambiarcontra.FormattingEnabled = true;
            this.cmbUsuarioCambiarcontra.Location = new System.Drawing.Point(346, 69);
            this.cmbUsuarioCambiarcontra.Name = "cmbUsuarioCambiarcontra";
            this.cmbUsuarioCambiarcontra.Size = new System.Drawing.Size(130, 23);
            this.cmbUsuarioCambiarcontra.TabIndex = 4;
            // 
            // txtContrasenactual
            // 
            this.txtContrasenactual.Location = new System.Drawing.Point(367, 157);
            this.txtContrasenactual.Name = "txtContrasenactual";
            this.txtContrasenactual.Size = new System.Drawing.Size(119, 23);
            this.txtContrasenactual.TabIndex = 5;
            // 
            // txtContrasenanueva
            // 
            this.txtContrasenanueva.Location = new System.Drawing.Point(367, 202);
            this.txtContrasenanueva.Name = "txtContrasenanueva";
            this.txtContrasenanueva.Size = new System.Drawing.Size(119, 23);
            this.txtContrasenanueva.TabIndex = 6;
            // 
            // txtRepetirnueva
            // 
            this.txtRepetirnueva.Location = new System.Drawing.Point(367, 242);
            this.txtRepetirnueva.Name = "txtRepetirnueva";
            this.txtRepetirnueva.Size = new System.Drawing.Size(119, 23);
            this.txtRepetirnueva.TabIndex = 7;
            // 
            // btnCambiarcontrasena
            // 
            this.btnCambiarcontrasena.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnCambiarcontrasena.ForeColor = System.Drawing.Color.White;
            this.btnCambiarcontrasena.Location = new System.Drawing.Point(164, 316);
            this.btnCambiarcontrasena.Name = "btnCambiarcontrasena";
            this.btnCambiarcontrasena.Size = new System.Drawing.Size(121, 46);
            this.btnCambiarcontrasena.TabIndex = 8;
            this.btnCambiarcontrasena.Text = "Cambiar contrasena";
            this.btnCambiarcontrasena.UseVisualStyleBackColor = false;
            this.btnCambiarcontrasena.Click += new System.EventHandler(this.btnCambiarcontrasena_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(356, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 46);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(37, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 48);
            this.label5.TabIndex = 10;
            this.label5.Text = "HUGO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmCambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(520, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarcontrasena);
            this.Controls.Add(this.txtRepetirnueva);
            this.Controls.Add(this.txtContrasenanueva);
            this.Controls.Add(this.txtContrasenactual);
            this.Controls.Add(this.cmbUsuarioCambiarcontra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCambiarContra";
            this.Text = "frmCambiarContra";
            this.Load += new System.EventHandler(this.frmCambiarContra_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasenanueva;
        private System.Windows.Forms.TextBox txtContrasenactual;
        private System.Windows.Forms.ComboBox cmbUsuarioCambiarcontra;
        private System.Windows.Forms.TextBox txtRepetirnueva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiarcontrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}