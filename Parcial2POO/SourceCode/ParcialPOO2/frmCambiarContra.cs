using System;
using System.Windows.Forms;

namespace ParcialPOO2
{
    public partial class frmCambiarContra : Form
    {
        public frmCambiarContra()
        {
            InitializeComponent();
        }
        
        private void frmCambiarContra_Load(object sender, EventArgs e)
        {
            // Actualizar ComboBox
            cmbUsuarioCambiarcontra.DataSource = null;
            cmbUsuarioCambiarcontra.ValueMember = "password";
            cmbUsuarioCambiarcontra.DisplayMember = "username";
            cmbUsuarioCambiarcontra.DataSource = appuserDAO.getLista();
        }


        private void btnCambiarcontrasena_Click(object sender, EventArgs e)
        {
            bool actualIgual = cmbUsuarioCambiarcontra.SelectedValue.Equals(txtContrasenactual.Text);
            bool nuevaIgual = txtContrasenanueva.Text.Equals(txtRepetirnueva.Text);
            bool nuevaValida = txtContrasenanueva.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    appuserDAO.actualizarContra(cmbUsuarioCambiarcontra.Text, txtContrasenanueva.Text);
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}