using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialPOO2
{
    public static class addressDAO
    {
        
        public static List<address> getLista()
        {
            string sql = "select * from address";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<address> lista = new List<address>();
            foreach (DataRow fila in dt.Rows)
            {
                address u = new address();
                u.idaddress = Convert.ToInt32(fila[0].ToString());
                u.iduser = Convert.ToInt32(fila[1].ToString());
                u.Aaddress = fila[2].ToString();

                lista.Add(u);
            }
            return lista;
        }
        
        public static List<address> getListaunico(int iduser)
        {
            string sql = String.Format(
                "select * from address where iduser= {0};",
                iduser);

            DataTable dt = Conexion.realizarConsulta(sql);

            List<address> lista = new List<address>();                                  
            foreach (DataRow fila in dt.Rows)
            {
                address u = new address();
                u.idaddress = Convert.ToInt32(fila[0].ToString());
                u.iduser = Convert.ToInt32(fila[1].ToString());
                u.Aaddress = fila[2].ToString();

                lista.Add(u);
            }
            return lista;
        }
        
        public static void crearNuevo(int iduser, string Aaddress)
        {
            string sql = String.Format(
                "insert into address(iduser, address) " +
                "values({0}, '{1}');",
                iduser, Aaddress);
            
            Conexion.realizarAccion(sql);
        }
        
        public static void eliminar(int idaddress)
        {
            string sql = String.Format(
                "delete from apporder where idaddress ={0}; " +
                "delete from address where idaddress={0};",
                idaddress);
            
            Conexion.realizarAccion(sql);
        }
        
        public static void actualizarinfo(string newaddress, int idaddress)
        {
            string sql = String.Format(
                "update address set address='{0}' where idaddress= {1};",
                newaddress, idaddress);
            
            Conexion.realizarAccion(sql);
        }
        
    }
}