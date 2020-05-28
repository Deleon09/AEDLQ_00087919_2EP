using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialPOO2
{
    public static class productDAO
    {
        
        public static List<product> getLista()
        {
            string sql = "select * from product";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<product> lista = new List<product>();
            foreach (DataRow fila in dt.Rows)
            {
                product u = new product();
                u.idproduct = Convert.ToInt32(fila[0].ToString());
                u.idbusiness = Convert.ToInt32(fila[1].ToString());
                u.name = fila[2].ToString();

                lista.Add(u);
            }
            return lista;
        }
        
        public static void crearNuevo(int idbusiness, string name)
        {
            string sql = String.Format(
                "insert into product(idbusiness, name) " +
                "values({0}, '{1}');",
                idbusiness, name);
            
            Conexion.realizarAccion(sql);
        }
        
        public static void eliminar(int idproduct)
        {
            string sql = String.Format(
                "delete from apporder where idproduct ={0}; " +
                "delete from product where idproduct={0};",
                idproduct);
            
            Conexion.realizarAccion(sql);
        }
        
    }
}