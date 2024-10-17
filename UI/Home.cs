using BE;
using BLL;
using MaterialSkin.Controls;
using MetroFramework;
using Servicios.SesionManager;
using Servicios.Validador;
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
        private bool emailValido = false;
        private bool pswValida = false;
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
            tabControlUsuarios.SelectedTab = tabRegistrar;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaUsuarios.Items.Count <= 0) throw new Exception("No hay usuarios para modificar.");
                if (listaUsuarios.SelectedItems.Count == 0) throw new Exception("Selecciona una fila para modificar.");

                ListViewItem filaSeleccionada = listaUsuarios.SelectedItems[0];

                int idUsuario = Convert.ToInt32(filaSeleccionada.SubItems[0].Text);

                Modificacion modificacion = new Modificacion(idUsuario);
                modificacion.Show();
                modificacion.FormClosed += (s, args) => ActualizarListaUsuarios();

            }
            catch (Exception ex)
            {
                RegistrarBitacora(ex.Message, BEBitacora.BitacoraTipo.ERROR);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaUsuarios.Items.Count <= 0) throw new Exception("No hay usuarios para eliminar.");
                if (listaUsuarios.SelectedItems.Count == 0) throw new Exception("Selecciona una fila para eliminar.");
                
                ListViewItem filaSeleccionada = listaUsuarios.SelectedItems[0];
                bool activo = Convert.ToBoolean(filaSeleccionada.SubItems[6].Text);
                if (!activo) throw new Exception("No se puede eliminar un usuario ya borrado.");

                BEUsuario usuario = new BEUsuario
                {
                    Id = Convert.ToInt32(filaSeleccionada.SubItems[0].Text),
                    Nombre = filaSeleccionada.SubItems[1].Text,          
                    Apellido = filaSeleccionada.SubItems[2].Text,            
                    Email = filaSeleccionada.SubItems[3].Text,               
                    Username = filaSeleccionada.SubItems[4].Text,             
                    Password = filaSeleccionada.SubItems[5].Text,             
                    Activo = activo
                };
                DialogResult respuesta = MetroMessageBox.Show(this, $"¿Esta seguro que desea eliminar el usuario {usuario.Nombre} {usuario.Apellido}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    bool eliminado = BLLUsuario.Eliminar(usuario);
                    if (eliminado)
                    {
                        RegistrarBitacora($"El usuario ha eliminado el usuario con ID: {usuario.Id}", BEBitacora.BitacoraTipo.INFO);
                        MetroMessageBox.Show(this, "Usuario eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarListaUsuarios();
                    }

                }
            }
            catch (Exception ex)
            {
                RegistrarBitacora(ex.Message, BEBitacora.BitacoraTipo.ERROR);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Tab Registrar:
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario nuevoUsuario = ObtenerDatos();

                if (nuevoUsuario is null) return;

                bool alta = BLLUsuario.Agregar(nuevoUsuario);

                if (alta)
                {
                    BLLUsuario.RecalcularDigitoVerificadorVertical();

                    MetroMessageBox.Show(this, "Usuario agregado correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nuevoUsuario = BLLUsuario.BuscarUsuarioPorUsername(nuevoUsuario.Username);
                    //RegistrarBitacora(nuevoUsuario, $"Se ha registrado un nuevo usuario con Id: {nuevoUsuario.Id}");
                }

                ActualizarListaUsuarios();
                tabControlUsuarios.SelectedTab = tabListaUsuarios;

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ValidarDatos()
        {
            if (!emailValido) throw new Exception("El email no es válido. Falta agregar el @ o el formato del email es incorrecto.");
            if (!pswValida) throw new Exception("La contraseña es inválida. Por favor, ingresala con el formato correcto.");
        }
        private bool CamposInvalidosRegistro()
        {
            return String.IsNullOrEmpty(txtNombre.Text.Trim()) ||
                String.IsNullOrEmpty(txtApellido.Text.Trim()) ||
                String.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                String.IsNullOrEmpty(txtUsername.Text.Trim()) ||
                String.IsNullOrEmpty(txtPsw.Text.Trim());
        }
        private BEUsuario ObtenerDatos()
        {
            try
            {
                if (CamposInvalidosRegistro()) throw new Exception("Los datos ingresados son incorrectos");

                BEUsuario nuevoUsuario = new BEUsuario()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = txtPsw.Text,
                };

                ValidarDatos();

                return nuevoUsuario;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void RegistrarBitacora(string mensaje, BEBitacora.BitacoraTipo tipo = BEBitacora.BitacoraTipo.INFO)
        {
            try
            {
                string username = SesionManager.GetUsername();

                BEUsuario usuarioActual = BLLUsuario.BuscarUsuarioPorUsername(username) ?? throw new Exception($"No existe el username: {username}");

                BEBitacora bitacora = new BEBitacora()
                {
                    Usuario = usuarioActual.Id,
                    Tipo = tipo,
                    Mensaje = mensaje
                };

                BLLBitacora.Agregar(bitacora);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Validador.Validar(txtEmail.Text.Trim(), Validador.TipoValidacion.Email))
                {
                    toolTipUsuarios.SetToolTip(txtEmail, "");
                    emailValido = true;
                }
                else
                {
                    toolTipUsuarios.SetToolTip(txtEmail, "Falta agregar el @ o el formato del email es incorrecto.");
                    emailValido = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtPsw_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Validador.Validar(txtPsw.Text.Trim(), Validador.TipoValidacion.Password))
                {
                    toolTipUsuarios.SetToolTip(txtPsw, "");
                    pswValida = true;
                }
                else
                {
                    toolTipUsuarios.SetToolTip(txtPsw, "Requiere al menos una letra minúscula.\r\n" +
                    "Requiere al menos una letra mayúscula.\r\n" +
                    "Requiere al menos un dígito.\r\n" +
                    "Requiere al menos un carácter especial entre @, $, !, %, *, ? o &.\r\n" +
                    "Debe tener al menos 8 caracteres de longitud.");
                    pswValida = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        #endregion

    }
}
