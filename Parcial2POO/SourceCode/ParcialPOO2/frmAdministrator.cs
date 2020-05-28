using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParcialPOO2
{
    public partial class frmAdministrator : Form
    {

        private appuser user;
        
        public frmAdministrator(appuser usuario)
        {
            InitializeComponent();
            user = usuario;
        }

        private void frmAdministrator_Load(object sender, EventArgs e)
        {
            lblbienvenida.Text = 
                "Bienvenido " + user.username + "[Administrador]";
            
            actualizarControles();
        }
        
        private void actualizarControles()
        {
            // Realizar consulta a la base de datos
            List<appuser> lista = appuserDAO.getLista();
            List<business> listilla = businessDAO.getLista();
            List<product> listo = productDAO.getLista();
            List<apporder> liste = apporderDAO.getLista();

            // Tabla (data grid view usuarios)
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = lista;
            // Tabla (data grid view ordenes)
            dgvOrdenes.DataSource = null;
            dgvOrdenes.DataSource = liste;
            // Menu desplegable usuarios (combo box)
            cmbUsuarios.DataSource = null;
            cmbUsuarios.ValueMember = "password";
            cmbUsuarios.DisplayMember = "username";
            cmbUsuarios.DataSource = lista;
            // Menu desplegable business (combo box)
            cmbnegocios.DataSource = null;
            cmbnegocios.ValueMember = "idbusiness";
            cmbnegocios.DisplayMember = "name";
            cmbnegocios.DataSource = listilla;
            // Menu desplegable business de productos (combo box)
            cmbbusinessforproduct.DataSource = null;
            cmbbusinessforproduct.ValueMember = "idbusiness";
            cmbbusinessforproduct.DisplayMember = "name";
            cmbbusinessforproduct.DataSource = listilla;
            // Menu desplegable productos (combo box)
            cmbProductoseliminar.DataSource = null;
            cmbProductoseliminar.ValueMember = "idproduct";
            cmbProductoseliminar.DisplayMember = "name";
            cmbProductoseliminar.DataSource = listo;
            
        }


        private void frmAdministrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + user.username + "?", 
                "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void frmAdministrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btnCrearusuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombrecompleto.Text.Length > 0 && txtNombredeusuario.Text.Length > 0)
                {
                    appuserDAO.crearNuevo(txtNombrecompleto.Text, txtNombredeusuario.Text, radAdministrador.Checked);
                    
                    MessageBox.Show("¡Usuario agregado exitosamente!" , 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtNombrecompleto.Clear();
                    txtNombredeusuario.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Favor Complete los campos", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnActualizardatos_Click(object sender, EventArgs e)
        {
            actualizarControles();
        }
        
        
        private void btnEliminarusuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + cmbUsuarios.Text + "?", 
                "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                appuser w = (appuser) cmbUsuarios.SelectedItem;
                appuserDAO.eliminar(w.iduser);
                
                MessageBox.Show("¡Usuario eliminado exitosamente!", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }


        private void btnAgregarnegocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombrenegocio.Text.Length > 0 && txtDescripcionnegocio.Text.Length > 0)
                {
                    businessDAO.crearNuevo(txtNombrenegocio.Text, txtDescripcionnegocio.Text);
                    
                    MessageBox.Show("¡Negocio agregado exitosamente!" , 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtNombrenegocio.Clear();
                    txtDescripcionnegocio.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Favor Complete los campos", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (DatabaseException)
            {
                MessageBox.Show("El negocio que ha digitado, no se encuentra disponible.", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminarnegocio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el negocio " + cmbnegocios.Text + "?", 
                "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                business k = (business) cmbnegocios.SelectedItem;
                businessDAO.eliminar(k.idbusiness);
                
                MessageBox.Show("¡Negocio eliminado exitosamente!", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }


        private void btnAgregarproducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtproductname.Text.Length > 0)
                {
                    int idebusiness = (int) cmbbusinessforproduct.SelectedValue;
                    productDAO.crearNuevo(idebusiness, txtproductname.Text);
                    
                    MessageBox.Show("¡Producto agregado exitosamente!", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtproductname.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Favor completar los campos", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El producto que ha digitado, no se encuentra disponible.", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el producto " + cmbProductoseliminar.Text + "?", 
                "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ideproducto = (int) cmbProductoseliminar.SelectedValue;
                productDAO.eliminar(ideproducto);
                
                MessageBox.Show("¡Producto eliminado exitosamente!", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }
        
        
    }
}