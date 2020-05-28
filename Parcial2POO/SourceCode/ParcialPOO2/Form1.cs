using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialPOO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }
        
        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "password";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = appuserDAO.getLista();
        }


        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {

            if (cmbUsuario.SelectedValue.Equals(txtcontrasena.Text))
            {
                appuser u = (appuser) cmbUsuario.SelectedItem;
                
                MessageBox.Show("¡Bienvenido!", 
                    "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (u.usertype)
                {
                    frmAdministrator ventana = new frmAdministrator(u);
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    frmCommonUser ventana = new frmCommonUser(u);
                    ventana.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("¡Contraseña incorrecta!", "HUGO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void txtcontrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnIniciarsesion_Click(sender, e);
        }
        
        
        private void btnCambiarcontrasena_Click(object sender, EventArgs e)
        {
            frmCambiarContra unaVentana = new frmCambiarContra();
            unaVentana.ShowDialog();
            poblarControles();
        }
        
        
    }
}