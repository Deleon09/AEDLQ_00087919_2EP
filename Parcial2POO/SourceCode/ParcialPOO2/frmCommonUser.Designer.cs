using System.ComponentModel;

namespace ParcialPOO2
{
    partial class frmCommonUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbupdateaddress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizardatos = new System.Windows.Forms.Button();
            this.txtnuevadireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminardireccion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDireccionaeliminar = new System.Windows.Forms.ComboBox();
            this.btnAgregardireccion = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminarorden = new System.Windows.Forms.Button();
            this.cmbAppordereliminar = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregarorden = new System.Windows.Forms.Button();
            this.cmbAddressCommon = new System.Windows.Forms.ComboBox();
            this.cmbproductosCommon = new System.Windows.Forms.ComboBox();
            this.txtfechapedido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvorders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDireccion)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvorders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvDireccion);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultas Direccion";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(192, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sus direcciones:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccion.Location = new System.Drawing.Point(8, 62);
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.Size = new System.Drawing.Size(614, 282);
            this.dgvDireccion.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage2.Controls.Add(this.cmbupdateaddress);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnActualizardatos);
            this.tabPage2.Controls.Add(this.txtnuevadireccion);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnEliminardireccion);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cmbDireccionaeliminar);
            this.tabPage2.Controls.Add(this.btnAgregardireccion);
            this.tabPage2.Controls.Add(this.txtDireccion);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento Direccion";
            // 
            // cmbupdateaddress
            // 
            this.cmbupdateaddress.FormattingEnabled = true;
            this.cmbupdateaddress.Location = new System.Drawing.Point(510, 241);
            this.cmbupdateaddress.Name = "cmbupdateaddress";
            this.cmbupdateaddress.Size = new System.Drawing.Size(114, 23);
            this.cmbupdateaddress.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 43);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione la direccion a actualizar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizardatos
            // 
            this.btnActualizardatos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnActualizardatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizardatos.Location = new System.Drawing.Point(425, 163);
            this.btnActualizardatos.Name = "btnActualizardatos";
            this.btnActualizardatos.Size = new System.Drawing.Size(129, 52);
            this.btnActualizardatos.TabIndex = 11;
            this.btnActualizardatos.Text = "Actualizar direccion";
            this.btnActualizardatos.UseVisualStyleBackColor = false;
            this.btnActualizardatos.Click += new System.EventHandler(this.btnActualizardatos_Click);
            // 
            // txtnuevadireccion
            // 
            this.txtnuevadireccion.Location = new System.Drawing.Point(510, 290);
            this.txtnuevadireccion.Name = "txtnuevadireccion";
            this.txtnuevadireccion.Size = new System.Drawing.Size(114, 23);
            this.txtnuevadireccion.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(345, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nueva direccion:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminardireccion
            // 
            this.btnEliminardireccion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnEliminardireccion.ForeColor = System.Drawing.Color.Red;
            this.btnEliminardireccion.Location = new System.Drawing.Point(85, 163);
            this.btnEliminardireccion.Name = "btnEliminardireccion";
            this.btnEliminardireccion.Size = new System.Drawing.Size(129, 52);
            this.btnEliminardireccion.TabIndex = 7;
            this.btnEliminardireccion.Text = "Eliminar direccion";
            this.btnEliminardireccion.UseVisualStyleBackColor = false;
            this.btnEliminardireccion.Click += new System.EventHandler(this.btnEliminardireccion_Click);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 51);
            this.label7.TabIndex = 6;
            this.label7.Text = "selecciona la direccion a eliminar:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDireccionaeliminar
            // 
            this.cmbDireccionaeliminar.FormattingEnabled = true;
            this.cmbDireccionaeliminar.Location = new System.Drawing.Point(167, 263);
            this.cmbDireccionaeliminar.Name = "cmbDireccionaeliminar";
            this.cmbDireccionaeliminar.Size = new System.Drawing.Size(118, 23);
            this.cmbDireccionaeliminar.TabIndex = 5;
            // 
            // btnAgregardireccion
            // 
            this.btnAgregardireccion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnAgregardireccion.ForeColor = System.Drawing.Color.White;
            this.btnAgregardireccion.Location = new System.Drawing.Point(227, 18);
            this.btnAgregardireccion.Name = "btnAgregardireccion";
            this.btnAgregardireccion.Size = new System.Drawing.Size(129, 52);
            this.btnAgregardireccion.TabIndex = 2;
            this.btnAgregardireccion.Text = "Agregar direccion";
            this.btnAgregardireccion.UseVisualStyleBackColor = false;
            this.btnAgregardireccion.Click += new System.EventHandler(this.btnAgregardireccion_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(283, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(154, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(142, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Su direccion:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage3.Controls.Add(this.btnEliminarorden);
            this.tabPage3.Controls.Add(this.cmbAppordereliminar);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btnAgregarorden);
            this.tabPage3.Controls.Add(this.cmbAddressCommon);
            this.tabPage3.Controls.Add(this.cmbproductosCommon);
            this.tabPage3.Controls.Add(this.txtfechapedido);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(636, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ordenes";
            // 
            // btnEliminarorden
            // 
            this.btnEliminarorden.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnEliminarorden.ForeColor = System.Drawing.Color.White;
            this.btnEliminarorden.Location = new System.Drawing.Point(407, 83);
            this.btnEliminarorden.Name = "btnEliminarorden";
            this.btnEliminarorden.Size = new System.Drawing.Size(101, 31);
            this.btnEliminarorden.TabIndex = 9;
            this.btnEliminarorden.Text = "Eliminar orden";
            this.btnEliminarorden.UseVisualStyleBackColor = false;
            this.btnEliminarorden.Click += new System.EventHandler(this.btnEliminarorden_Click);
            // 
            // cmbAppordereliminar
            // 
            this.cmbAppordereliminar.FormattingEnabled = true;
            this.cmbAppordereliminar.Location = new System.Drawing.Point(465, 182);
            this.cmbAppordereliminar.Name = "cmbAppordereliminar";
            this.cmbAppordereliminar.Size = new System.Drawing.Size(112, 23);
            this.cmbAppordereliminar.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(334, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 54);
            this.label13.TabIndex = 7;
            this.label13.Text = "Seleccione el id de la ordena eliminar:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarorden
            // 
            this.btnAgregarorden.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.btnAgregarorden.ForeColor = System.Drawing.Color.White;
            this.btnAgregarorden.Location = new System.Drawing.Point(80, 83);
            this.btnAgregarorden.Name = "btnAgregarorden";
            this.btnAgregarorden.Size = new System.Drawing.Size(101, 31);
            this.btnAgregarorden.TabIndex = 6;
            this.btnAgregarorden.Text = "Agregar orden";
            this.btnAgregarorden.UseVisualStyleBackColor = false;
            this.btnAgregarorden.Click += new System.EventHandler(this.btnAgregarorden_Click);
            // 
            // cmbAddressCommon
            // 
            this.cmbAddressCommon.FormattingEnabled = true;
            this.cmbAddressCommon.Location = new System.Drawing.Point(107, 232);
            this.cmbAddressCommon.Name = "cmbAddressCommon";
            this.cmbAddressCommon.Size = new System.Drawing.Size(117, 23);
            this.cmbAddressCommon.TabIndex = 5;
            // 
            // cmbproductosCommon
            // 
            this.cmbproductosCommon.FormattingEnabled = true;
            this.cmbproductosCommon.Location = new System.Drawing.Point(107, 182);
            this.cmbproductosCommon.Name = "cmbproductosCommon";
            this.cmbproductosCommon.Size = new System.Drawing.Size(117, 23);
            this.cmbproductosCommon.TabIndex = 4;
            // 
            // txtfechapedido
            // 
            this.txtfechapedido.Location = new System.Drawing.Point(106, 140);
            this.txtfechapedido.Name = "txtfechapedido";
            this.txtfechapedido.Size = new System.Drawing.Size(118, 23);
            this.txtfechapedido.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(21, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 33);
            this.label12.TabIndex = 2;
            this.label12.Text = "producto:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 33);
            this.label11.TabIndex = 1;
            this.label11.Text = "direccion:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fecha:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (192)))));
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.dgvorders);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(636, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultas ordenes";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(201, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 36);
            this.label14.TabIndex = 1;
            this.label14.Text = "Ordenes:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvorders
            // 
            this.dgvorders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorders.Location = new System.Drawing.Point(9, 51);
            this.dgvorders.Name = "dgvorders";
            this.dgvorders.Size = new System.Drawing.Size(614, 293);
            this.dgvorders.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "HUGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwelcome
            // 
            this.lblwelcome.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(290, 9);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(341, 35);
            this.lblwelcome.TabIndex = 2;
            this.lblwelcome.Text = "nothing";
            this.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCommonUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(653, 442);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCommonUser";
            this.Text = "frmCommonUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCommonUser_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCommonUser_FormClosed);
            this.Load += new System.EventHandler(this.frmCommonUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvDireccion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvorders)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregardireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnActualizardatos;
        private System.Windows.Forms.ComboBox cmbDireccionaeliminar;
        private System.Windows.Forms.Button btnEliminardireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.TextBox txtnuevadireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbupdateaddress;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregarorden;
        private System.Windows.Forms.Button btnEliminarorden;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvorders;
        private System.Windows.Forms.ComboBox cmbAppordereliminar;
        private System.Windows.Forms.ComboBox cmbAddressCommon;
        private System.Windows.Forms.ComboBox cmbproductosCommon;
        private System.Windows.Forms.TextBox txtfechapedido;
    }
}