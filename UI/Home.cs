using BE;
using BLL;
using MaterialSkin.Controls;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Home : MaterialSkin.Controls.MaterialForm
    {
        public Home()
        {
            InitializeComponent();
            ActualizarListaUsuarios();
        }

        #region Tab Usuarios:
        private void ActualizarListaUsuarios()
        {
          
            
                listaUsuarios.Items.Clear();

                List<BEUsuario> usuarios = BLLUsuario.Listar();

                foreach (BEUsuario usuario in usuarios)
                {
                    string[] row =
                    {
                        usuario.Id.ToString(),
                        usuario.Nombre, 
                        usuario.Apellido,
                        usuario.Email,     
                        usuario.Username,
                        usuario.Password,
                        usuario.Activo.ToString(),
                    };

                    var item = new ListViewItem(row);

                    listaUsuarios.Items.Add(item);
                }
            

        }

       

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
