using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialPOO2
{
    public static class apporderDAO
    {
        
        public static List<apporder> getLista()
        {
            string sql = "select * from apporder";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<apporder> lista = new List<apporder>();
            foreach (DataRow fila in dt.Rows)
            {
                apporder u = new apporder();
                u.idorder = Convert.ToInt32(fila[0].ToString());
                u.createdate = fila[1].ToString();
                u.idproduct = Convert.ToInt32(fila[2].ToString());
                u.idaddress = Convert.ToInt32(fila[3].ToString());

                lista.Add(u);
            }
            return lista;
        }
        
        
        public static void crearNuevo(string createdate, int idproduct, int idaddress)
        {
            string sql = String.Format(
                "insert into apporder(createdate, idproduct, idaddress) " +
                "values('{0}', {1}, {2});",
                createdate, idproduct, idaddress);
            
            Conexion.realizarAccion(sql);
        }
        
        public static void eliminar(int idorder)
        {
            string sql = String.Format(
                "delete from apporder where idorder={0};",
                idorder);
            
            Conexion.realizarAccion(sql);
        }
        
    }
}