using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialPOO2
{
    public static class appuserDAO
    {
        
        public static List<appuser> getLista()
        {
            string sql = "select * from appuser";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<appuser> lista = new List<appuser>();
            foreach (DataRow fila in dt.Rows)
            {
                appuser u = new appuser();
                u.iduser = Convert.ToInt32(fila[0].ToString());
                u.fullname = fila[1].ToString();
                u.username = fila[2].ToString();
                u.password = fila[3].ToString();
                u.usertype = Convert.ToBoolean(fila[4].ToString());

                lista.Add(u);
            }
            return lista;
        }
        
        public static void actualizarContra(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update appuser set password='{0}' where username='{1}';",
                nuevaContra, usuario);
            
            Conexion.realizarAccion(sql);
        }
        
        public static void crearNuevo(string fullname, string username, bool usertype)
        {
            string sql = String.Format(
                "insert into appuser(fullname, username, password, usertype) " +
                "values('{0}', '{1}', '{1}', {2});",
                fullname, username, usertype ? "true" : "false");
            
            Conexion.realizarAccion(sql);
        }
        
        public static void eliminar(int iduser)
        {
            string sql = String.Format(
                "delete from address where iduser ={0}; " +
                "delete from appuser where iduser={0};",
                iduser);
            
            Conexion.realizarAccion(sql);
        }
        
    }
}