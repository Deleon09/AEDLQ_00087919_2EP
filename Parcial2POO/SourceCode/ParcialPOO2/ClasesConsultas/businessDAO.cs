using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialPOO2
{
    public static class businessDAO
    {
        
        public static List<business> getLista()
        {
            string sql = "select * from business";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<business> lista = new List<business>();
            foreach (DataRow fila in dt.Rows)
            {
                business u = new business();
                u.idbusiness = Convert.ToInt32(fila[0].ToString());
                u.name = fila[1].ToString();
                u.description = fila[2].ToString();

                lista.Add(u);
            }
            return lista;
        }
        
        
        public static void crearNuevo(string name, string description)
        {
            string sql = String.Format(
                "insert into business(name, description) " +
                "values('{0}', '{1}');",
                name, description);
            
            Conexion.realizarAccion(sql);
        }
        
        public static void eliminar(int idbusiness)
        {
            string sql = String.Format(
                "delete from product where idbusiness ={0}; " +
                "delete from business where idbusiness={0};",
                idbusiness);
            
            Conexion.realizarAccion(sql);
        }
        
    }
}