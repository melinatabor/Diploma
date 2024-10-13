using BE;
using DAL;
using MPP.StoredProcedures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPUsuario
    {
        public static bool Agregar(BEUsuario usuario)
        {
            try
            {
                Hashtable queryParams = new Hashtable();
                queryParams.Add("@Name", usuario.Nombre);
                queryParams.Add("@Lastname", usuario.Apellido);
                queryParams.Add("@Email", usuario.Email);
                queryParams.Add("@Username", usuario.Username);
                queryParams.Add("@Password", usuario.Password);
                queryParams.Add("@Active", usuario.Active);

                return AccesoBD.ExecuteNonQuery(Usuario.SPAgregar, queryParams, true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
