using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParcialPOO2
{
    public partial class frmCommonUser : Form
    {
        
        private appuser user;
        
        public frmCommonUser(appuser usuario)
        {
            InitializeComponent();
            user = usuario;
        }

        private void frmCommonUser_Load(object sender, EventArgs e)
        {
            lblwelcome.Text = 
                "Bienvenido " + user.username + " [Usuario]";
            
            actualizarControlesCommon();
        }

        private void actualizarControlesCommon()
        {
            // Realizar consulta a la base de datos
            List<address> lista = addressDAO.getListaunico(user.iduser);
            List<apporder> listilla = apporderDAO.getLista();
            List<product> liste = productDAO.getLista();
            
            // Tabla (data grid view Pedidos)
            dgvDireccion.DataSource = null;
            dgvDireccion.DataSource = lista;
            // Tabla (data grid view Ordenes)
            dgvorders.DataSource = null;
            dgvorders.DataSource = listilla;
            // Menu desplegable Address (combo box)
            cmbDireccionaeliminar.DataSource = null;
            cmbDireccionaeliminar.ValueMember = "idaddress";
            cmbDireccionaeliminar.DisplayMember = "Aaddress";
            cmbDireccionaeliminar.DataSource = lista;
            // Menu desplegable Address (combo box)
            cmbupdateaddress.DataSource = null;
            cmbupdateaddress.ValueMember = "idaddress";
            cmbupdateaddress.DisplayMember = "Aaddress";
            cmbupdateaddress.DataSource = lista;
            // Menu desplegable productos (combo box)
            cmbproductosCommon.DataSource = null;
            cmbproductosCommon.ValueMember = "idproduct";
            cmbproductosCommon.DisplayMember = "name";
            cmbproductosCommon.DataSource = liste;
            // Menu desplegable addresscommon (combo box)
            cmbAddressCommon.DataSource = null;
            cmbAddressCommon.ValueMember = "idaddress";
            cmbAddressCommon.DisplayMember = "Aaddress";
            cmbAddressCommon.DataSource = lista;
            // Menu desplegable appordereliminar (combo box)
            cmbAppordereliminar.DataSource = null;
            cmbAppordereliminar.ValueMember = "idproduct";
            cmbAppordereliminar.DisplayMember = "idorder";
            cmbAppordereliminar.DataSource = listilla;
        }
        
        private void frmCommonUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + user.username + "?", 
                "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        
        private void frmCommonUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregardireccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDireccion.Text.Length > 0)
                {
                    
                    addressDAO.crearNuevo(user.iduser,txtDireccion.Text);
                    
                    MessageBox.Show("¡Direccion agregada exitosamente!", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtDireccion.Clear();
                    actualizarControlesCommon();
                }
                else
                    MessageBox.Show("Favor complete los campos", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("La direccion que ha digitado, no se encuentra disponible.", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminardireccion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la direccion " + cmbDireccionaeliminar.Text + "?", 
                "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int p = (int) cmbDireccionaeliminar.SelectedValue;
                addressDAO.eliminar(p);
                
                MessageBox.Show("¡Direccion eliminada exitosamente!", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControlesCommon();
            }
        }
        
        private void btnActualizardatos_Click(object sender, EventArgs e)
        {
            int g = (int) cmbupdateaddress.SelectedValue;
            addressDAO.actualizarinfo(txtnuevadireccion.Text, g);
            
            MessageBox.Show("¡Direccion actualizada exitosamente!", 
                "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            actualizarControlesCommon();
        }


        private void btnAgregarorden_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfechapedido.Text.Length > 0)
                {
                    product w = (product) cmbproductosCommon.SelectedItem;
                    address l = (address) cmbAddressCommon.SelectedItem;
                    apporderDAO.crearNuevo(txtfechapedido.Text, w.idproduct, l.idaddress);
                    
                    MessageBox.Show("¡Orden agregada exitosamente!", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtfechapedido.Clear();
                    actualizarControlesCommon();
                }
                else
                    MessageBox.Show("Favor Complete los campos", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("La orden que ha digitado, no se encuentra disponible.", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnEliminarorden_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la orden " + cmbAppordereliminar.Text + "?", 
                "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                apporder z = (apporder) cmbAppordereliminar.SelectedItem;
                apporderDAO.eliminar(z.idorder);
                
                MessageBox.Show("¡Orden eliminada exitosamente!", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControlesCommon();
            }
        }
        
    }
}