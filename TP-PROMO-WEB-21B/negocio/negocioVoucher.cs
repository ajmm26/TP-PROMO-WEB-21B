using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using accesoDatos;



namespace negocio
{
    public class negocioVoucher
    {

        public static List<Voucher> Listar()
        {
            List<Voucher> lista = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select codigo,idCliente,fechaCanje,IdArticulo from Voucher");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                   Voucher voucher = new Voucher();
                     voucher.Codigo = (string)datos.Lector["codigo"];
                     voucher.IdCliente = (int)datos.Lector["idCliente"];
                     voucher.DateTime1 = (DateTime)datos.Lector["fechaCanje"];
                     voucher.IdArticulo = (int)datos.Lector["IdArticulo"];
                        lista.Add(voucher);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
