using System.ComponentModel;

namespace ParcialPOO2
{
    partial class frmAdministrator
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
                new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnActualizardatos = new System.Windows.Forms.Button();
            this.btnCrearusuario = new System.Windows.Forms.Button();
            this.txtNombrecompleto = new System.Windows.Forms.TextBox();
            this.txtNombredeusuario = new System.Windows.Forms.TextBox();
            this.grbusertype = new System.Windows.Forms.GroupBox();
            this.radUsuario = new System.Windows.Forms.RadioButton();
            this.radAdministrador = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminarusuario = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgregarnegocio = new System.Windows.Forms.Button();
            this.btnEliminarnegocio = new System.Windows.Forms.Button();
            this.cmbnegocios = new System.Windows.Forms.ComboBox();
            this.txtDescripcionnegocio = new System.Windows.Forms.TextBox();
            this.txtNombrenegocio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbProductoseliminar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarproducto = new System.Windows.Forms.Button();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.cmbbusinessforproduct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.lblbienvenida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grbusertype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvUsuarios)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(10, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Impact", 20.25F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(358, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(225, 167);
            this.label15.TabIndex = 1;
            this.label15.Text = "Bienvenido de nuevo!";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage2.Controls.Add(this.btnActualizardatos);
            this.tabPage2.Controls.Add(this.btnCrearusuario);
            this.tabPage2.Controls.Add(this.txtNombrecompleto);
            this.tabPage2.Controls.Add(this.txtNombredeusuario);
            this.tabPage2.Controls.Add(this.grbusertype);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvUsuarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear usuario";
            // 
            // btnActualizardatos
            // 
            this.btnActualizardatos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnActualizardatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizardatos.Location = new System.Drawing.Point(324, 318);
            this.btnActualizardatos.Name = "btnActualizardatos";
            this.btnActualizardatos.Size = new System.Drawing.Size(133, 30);
            this.btnActualizardatos.TabIndex = 7;
            this.btnActualizardatos.Text = "Actualizar datos";
            this.btnActualizardatos.UseVisualStyleBackColor = false;
            this.btnActualizardatos.Click += new System.EventHandler(this.btnActualizardatos_Click);
            // 
            // btnCrearusuario
            // 
            this.btnCrearusuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnCrearusuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearusuario.Location = new System.Drawing.Point(162, 318);
            this.btnCrearusuario.Name = "btnCrearusuario";
            this.btnCrearusuario.Size = new System.Drawing.Size(133, 30);
            this.btnCrearusuario.TabIndex = 6;
            this.btnCrearusuario.Text = "Crear usuario";
            this.btnCrearusuario.UseVisualStyleBackColor = false;
            this.btnCrearusuario.Click += new System.EventHandler(this.btnCrearusuario_Click);
            // 
            // txtNombrecompleto
            // 
            this.txtNombrecompleto.Location = new System.Drawing.Point(129, 37);
            this.txtNombrecompleto.Name = "txtNombrecompleto";
            this.txtNombrecompleto.Size = new System.Drawing.Size(98, 23);
            this.txtNombrecompleto.TabIndex = 5;
            // 
            // txtNombredeusuario
            // 
            this.txtNombredeusuario.Location = new System.Drawing.Point(359, 37);
            this.txtNombredeusuario.Name = "txtNombredeusuario";
            this.txtNombredeusuario.Size = new System.Drawing.Size(98, 23);
            this.txtNombredeusuario.TabIndex = 4;
            // 
            // grbusertype
            // 
            this.grbusertype.Controls.Add(this.radUsuario);
            this.grbusertype.Controls.Add(this.radAdministrador);
            this.grbusertype.ForeColor = System.Drawing.Color.White;
            this.grbusertype.Location = new System.Drawing.Point(472, 22);
            this.grbusertype.Name = "grbusertype";
            this.grbusertype.Size = new System.Drawing.Size(132, 78);
            this.grbusertype.TabIndex = 3;
            this.grbusertype.TabStop = false;
            this.grbusertype.Text = "tipo de usuario:";
            // 
            // radUsuario
            // 
            this.radUsuario.Checked = true;
            this.radUsuario.Location = new System.Drawing.Point(13, 50);
            this.radUsuario.Name = "radUsuario";
            this.radUsuario.Size = new System.Drawing.Size(107, 18);
            this.radUsuario.TabIndex = 1;
            this.radUsuario.TabStop = true;
            this.radUsuario.Text = "Usuario";
            this.radUsuario.UseVisualStyleBackColor = true;
            // 
            // radAdministrador
            // 
            this.radAdministrador.Location = new System.Drawing.Point(13, 25);
            this.radAdministrador.Name = "radAdministrador";
            this.radAdministrador.Size = new System.Drawing.Size(107, 18);
            this.radAdministrador.TabIndex = 0;
            this.radAdministrador.Text = "Administrador";
            this.radAdministrador.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre completo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 107);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(608, 207);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage3.Controls.Add(this.btnEliminarusuario);
            this.tabPage3.Controls.Add(this.cmbUsuarios);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(625, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento usuarios";
            // 
            // btnEliminarusuario
            // 
            this.btnEliminarusuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnEliminarusuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarusuario.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarusuario.Location = new System.Drawing.Point(231, 165);
            this.btnEliminarusuario.Name = "btnEliminarusuario";
            this.btnEliminarusuario.Size = new System.Drawing.Size(181, 61);
            this.btnEliminarusuario.TabIndex = 2;
            this.btnEliminarusuario.Text = "Eliminar usuario";
            this.btnEliminarusuario.UseVisualStyleBackColor = false;
            this.btnEliminarusuario.Click += new System.EventHandler(this.btnEliminarusuario_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(297, 85);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(150, 23);
            this.cmbUsuarios.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(156, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuarios:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.btnAgregarnegocio);
            this.tabPage4.Controls.Add(this.btnEliminarnegocio);
            this.tabPage4.Controls.Add(this.cmbnegocios);
            this.tabPage4.Controls.Add(this.txtDescripcionnegocio);
            this.tabPage4.Controls.Add(this.txtNombrenegocio);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(625, 361);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mantenimiento negocios";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(220, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 43);
            this.label13.TabIndex = 8;
            this.label13.Text = "Creacion:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(205, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 43);
            this.label12.TabIndex = 7;
            this.label12.Text = "Eliminacion:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarnegocio
            // 
            this.btnAgregarnegocio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnAgregarnegocio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarnegocio.Location = new System.Drawing.Point(402, 102);
            this.btnAgregarnegocio.Name = "btnAgregarnegocio";
            this.btnAgregarnegocio.Size = new System.Drawing.Size(125, 44);
            this.btnAgregarnegocio.TabIndex = 6;
            this.btnAgregarnegocio.Text = "Agregar negocio";
            this.btnAgregarnegocio.UseVisualStyleBackColor = false;
            this.btnAgregarnegocio.Click += new System.EventHandler(this.btnAgregarnegocio_Click);
            // 
            // btnEliminarnegocio
            // 
            this.btnEliminarnegocio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnEliminarnegocio.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarnegocio.Location = new System.Drawing.Point(339, 263);
            this.btnEliminarnegocio.Name = "btnEliminarnegocio";
            this.btnEliminarnegocio.Size = new System.Drawing.Size(125, 44);
            this.btnEliminarnegocio.TabIndex = 5;
            this.btnEliminarnegocio.Text = "Eliminar negocio";
            this.btnEliminarnegocio.UseVisualStyleBackColor = false;
            this.btnEliminarnegocio.Click += new System.EventHandler(this.btnEliminarnegocio_Click);
            // 
            // cmbnegocios
            // 
            this.cmbnegocios.FormattingEnabled = true;
            this.cmbnegocios.Location = new System.Drawing.Point(156, 275);
            this.cmbnegocios.Name = "cmbnegocios";
            this.cmbnegocios.Size = new System.Drawing.Size(144, 23);
            this.cmbnegocios.TabIndex = 4;
            // 
            // txtDescripcionnegocio
            // 
            this.txtDescripcionnegocio.Location = new System.Drawing.Point(233, 133);
            this.txtDescripcionnegocio.Name = "txtDescripcionnegocio";
            this.txtDescripcionnegocio.Size = new System.Drawing.Size(126, 23);
            this.txtDescripcionnegocio.TabIndex = 3;
            // 
            // txtNombrenegocio
            // 
            this.txtNombrenegocio.Location = new System.Drawing.Point(233, 93);
            this.txtNombrenegocio.Name = "txtNombrenegocio";
            this.txtNombrenegocio.Size = new System.Drawing.Size(126, 23);
            this.txtNombrenegocio.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(64, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "descripcion del negocio:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre del negocio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.cmbProductoseliminar);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.btnAgregarproducto);
            this.tabPage5.Controls.Add(this.txtproductname);
            this.tabPage5.Controls.Add(this.cmbbusinessforproduct);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(625, 361);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Mantenimiento productos";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(208, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 38);
            this.label11.TabIndex = 9;
            this.label11.Text = "Creacion:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(208, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 38);
            this.label10.TabIndex = 8;
            this.label10.Text = "Eliminacion:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(423, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Eliminar producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nombre del producto:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProductoseliminar
            // 
            this.cmbProductoseliminar.FormattingEnabled = true;
            this.cmbProductoseliminar.Location = new System.Drawing.Point(224, 265);
            this.cmbProductoseliminar.Name = "cmbProductoseliminar";
            this.cmbProductoseliminar.Size = new System.Drawing.Size(146, 23);
            this.cmbProductoseliminar.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre del producto:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarproducto
            // 
            this.btnAgregarproducto.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnAgregarproducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarproducto.Location = new System.Drawing.Point(423, 103);
            this.btnAgregarproducto.Name = "btnAgregarproducto";
            this.btnAgregarproducto.Size = new System.Drawing.Size(118, 57);
            this.btnAgregarproducto.TabIndex = 3;
            this.btnAgregarproducto.Text = "Agregar producto";
            this.btnAgregarproducto.UseVisualStyleBackColor = false;
            this.btnAgregarproducto.Click += new System.EventHandler(this.btnAgregarproducto_Click);
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(224, 147);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(146, 23);
            this.txtproductname.TabIndex = 2;
            // 
            // cmbbusinessforproduct
            // 
            this.cmbbusinessforproduct.FormattingEnabled = true;
            this.cmbbusinessforproduct.Location = new System.Drawing.Point(224, 93);
            this.cmbbusinessforproduct.Name = "cmbbusinessforproduct";
            this.cmbbusinessforproduct.Size = new System.Drawing.Size(146, 23);
            this.cmbbusinessforproduct.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Negocio al que se agregara el producto:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.dgvOrdenes);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(625, 361);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ordenes";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(143, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(332, 39);
            this.label14.TabIndex = 1;
            this.label14.Text = "Ordenes de los usuarios";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(6, 57);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(607, 297);
            this.dgvOrdenes.TabIndex = 0;
            // 
            // lblbienvenida
            // 
            this.lblbienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblbienvenida.ForeColor = System.Drawing.Color.White;
            this.lblbienvenida.Location = new System.Drawing.Point(309, 9);
            this.lblbienvenida.Name = "lblbienvenida";
            this.lblbienvenida.Size = new System.Drawing.Size(318, 30);
            this.lblbienvenida.TabIndex = 1;
            this.lblbienvenida.Text = "nothing";
            this.lblbienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Impact", 20.25F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(10, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "HUGO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(653, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblbienvenida);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdministrator_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdministrator_FormClosed);
            this.Load += new System.EventHandler(this.frmAdministrator_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grbusertype.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvUsuarios)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radAdministrador;
        private System.Windows.Forms.RadioButton radUsuario;
        private System.Windows.Forms.GroupBox grbusertype;
        private System.Windows.Forms.TextBox txtNombredeusuario;
        private System.Windows.Forms.TextBox txtNombrecompleto;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnCrearusuario;
        private System.Windows.Forms.Button btnActualizardatos;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Button btnEliminarusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblbienvenida;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarnegocio;
        private System.Windows.Forms.Button btnAgregarnegocio;
        private System.Windows.Forms.ComboBox cmbnegocios;
        private System.Windows.Forms.TextBox txtNombrenegocio;
        private System.Windows.Forms.TextBox txtDescripcionnegocio;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarproducto;
        private System.Windows.Forms.ComboBox cmbProductoseliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbbusinessforproduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
    }
}