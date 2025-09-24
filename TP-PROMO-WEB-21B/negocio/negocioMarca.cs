using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using accesoDatos;


namespace negocio
{
    public class negocioMarca
    {
        List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from Marca");
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];
                    lista.Add(aux);

                }
                return Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }


           
        }
    }
}
