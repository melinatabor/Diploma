using Abstraccion;
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
    public partial class Home : MaterialSkin.Controls.MaterialForm, ISubscriptor
    {
        private bool emailValido = false;
        private bool pswValida = false;
        private int idUsuarioSeleccionado;
        private string _tag = "Traducción para ";

        public Home()
        {
            InitializeComponent();
            ActualizarListaUsuarios();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                Subscribirse();
                Actualizar();
                ActualizarDropDown();
                ActualizarListaIdiomas();
                ActualizarListaUsuarios();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #region Tab Idiomas:
        private void ActualizarDropDown()
        {
            try
            {
                ddIdiomas.DataSource = null;
                ddIdiomas.DataSource = BLLIdioma.Listar();
                ddIdiomas.DisplayMember = "Idioma";
                ddIdiomas.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void Subscribirse()
        {
            try
            {
                BLLIdioma.RegistrarSubscriptor(this);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Subscriptor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void Actualizar()
        {
            try
            {
                List<BEPalabra> palabras = BLLIdioma.ObtenerTags();

                // Actualizar el titulo del formulario
                if (this.Tag != null && this.Tag.ToString() != "")
                {
                    BEPalabra palabra = palabras.Find(pal => pal.Tag.Equals(this.Tag.ToString()));

                    if (palabra != null)
                    {
                        this.Text = palabra.Traduccion;
                        this.Refresh();
                    }
                }

                // Actualizar controles
                foreach (Control control in Controls)
                {
                    if (control.Tag != null && control.Tag.ToString() != "")
                    {
                        BEPalabra palabra = palabras.Find(pal => pal.Tag.Equals(control.Tag.ToString()));
                        if (palabra != null)
                        {
                            if (control is Label label && label.Name == "labelTag")
                            {
                                label.Text = _tag = palabra.Traduccion;
                            }
                            else if (control is MaterialSkin.Controls.MaterialComboBox materialComboBox)
                            {
                                materialComboBox.Hint = palabra.Traduccion;
                            }
                            else if (control is MaterialSkin.Controls.MaterialTextBox materialTextBox)
                            {
                                materialTextBox.Hint = palabra.Traduccion;
                            }
                            else
                            {
                                control.Text = palabra.Traduccion;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Idioma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ActualizarListaIdiomas(int idIdioma = 1)
        {
            listaIdiomas.Items.Clear();
            List<BETraduccion> idiomas = BLLTraduccion.Listar(idIdioma);

            foreach (BETraduccion idioma in idiomas)
            {
                string[] row =
                {
                        idioma.Id.ToString(),
                        idioma.Tag,
                        idioma.Neutro,
                        idioma.Traduccion,
                };

                var item = new ListViewItem(row);
                listaIdiomas.Items.Add(item);
            }
        }

        private void btnCambiarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                BEIdioma idioma = (BEIdioma)ddIdiomas.SelectedItem;
                if (idioma != null)
                {
                    BLLIdioma.CambiarIdioma(idioma.Id);
                }
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
                return;
            }
        }

        private void ddIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddIdiomas.SelectedValue != null && ddIdiomas.SelectedValue is int selectedId)
                    ActualizarListaIdiomas(selectedId);
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
                return;
            }
        }

        private void listaIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listaIdiomas.SelectedItems.Count > 0)
                {
                    ListViewItem filaSeleccionada = listaIdiomas.SelectedItems[0];
                    string tag = filaSeleccionada.SubItems[1].Text;
                    string trad = filaSeleccionada.SubItems[3].Text;

                    labelTag.Text = _tag + tag + ":";
                    txtTraduccion.Hint = trad;
                    txtTraduccion.Text = trad;
                }
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
                return;
            }
        }

        private void btnAgregarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(inputNuevoIdioma.Text))
                {
                    MaterialDialog dialog = new MaterialDialog(this, "Error", "Debe ingresar un idioma para poder agregarlo.", "OK");
                    dialog.ShowDialog(this);
                    return;
                }
                MaterialDialog materialDialog = new MaterialDialog(this, "Aviso", $"¿Esta seguro que desea agregar el idioma {inputNuevoIdioma.Text}?", "Sí, deseo agregarlo", true, "Cancelar");
                DialogResult result = materialDialog.ShowDialog(this);
               

                if (result != DialogResult.OK)
                    return;

                BEIdioma idioma = new BEIdioma
                {
                    Idioma = inputNuevoIdioma.Text
                };

                bool agregado = BLLIdioma.Agregar(idioma);

                if (agregado)
                {
                    MaterialDialog dialog = new MaterialDialog(this, "Éxito", "Idioma agregado correctamente", "OK");
                    dialog.ShowDialog(this);
                    ActualizarDropDown();
                    inputNuevoIdioma.Text = "";
                }
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
                return;
            }
        }

        private void btnModificarTraduccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaIdiomas.SelectedItems.Count != 1)
                    throw new Exception("Debe seleccionar una traducción");

                ListViewItem filaSeleccionada = listaIdiomas.SelectedItems[0];
                BETraduccion traduccion = new BETraduccion()
                {
                    Id = Convert.ToInt16(filaSeleccionada.SubItems[0].Text),
                    Tag = filaSeleccionada.SubItems[1].Text,
                    Neutro = filaSeleccionada.SubItems[2].Text,
                    Traduccion = txtTraduccion.Text
                };
                BEIdioma idioma = (BEIdioma)ddIdiomas.SelectedItem;

                MaterialDialog materialDialog = new MaterialDialog(this, "Aviso", $"¿Esta seguro que desea modificar la traduccion?", "Sí, deseo modificarlo", true, "Cancelar");
                DialogResult result = materialDialog.ShowDialog(this);

                if (result != DialogResult.OK)
                    return;

                BLLTraduccion.Modificar(idioma, traduccion, txtTraduccion.Text.Trim());

                ActualizarListaIdiomas(idioma.Id);

                txtTraduccion.Text = "";
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
                return;
            }
        }
        #endregion


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

                tabControlUsuarios.SelectedTab = tabModificar;
            }
            catch (Exception ex)
            {
                RegistrarBitacora(ex.Message, BEBitacora.BitacoraTipo.ERROR);
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaUsuarios.Items.Count <= 0) throw new Exception("No hay usuarios para eliminar.");
                if (listaUsuarios.SelectedItems.Count == 0) throw new Exception("Selecciona una fila para eliminar.");

                bool activo = Convert.ToBoolean(listaUsuarios.SelectedItems[0].SubItems[6].Text);
                if (!activo) throw new Exception("No se puede eliminar un usuario ya borrado.");
                BEUsuario usuario = BLLUsuario.ObtenerUsuario(idUsuarioSeleccionado);

                MaterialDialog materialDialog = new MaterialDialog(this, "Aviso", $"¿Esta seguro que desea eliminar el usuario {usuario.Nombre} {usuario.Apellido}?", "Sí, deseo eliminarlo", true, "Cancelar");
                DialogResult result = materialDialog.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    bool eliminado = BLLUsuario.Eliminar(usuario);
                    if (eliminado)
                    {
                        RegistrarBitacora($"El usuario ha eliminado el usuario con ID: {usuario.Id}", BEBitacora.BitacoraTipo.INFO);
                        MaterialSnackBar SnackBarMessage = new MaterialSnackBar($"Usuario {usuario.Id} eliminado con exito", 2500);
                        SnackBarMessage.Show(this);
                        ActualizarListaUsuarios();
                    }

                }
            }
            catch (Exception ex)
            {
                RegistrarBitacora(ex.Message, BEBitacora.BitacoraTipo.ERROR);
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
            }
        }

        private void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaUsuarios.SelectedItems.Count > 0)
            {
                idUsuarioSeleccionado = Convert.ToInt16(listaUsuarios.SelectedItems[0].SubItems[0].Text);

                BEUsuario usuario = BLLUsuario.ObtenerUsuario(idUsuarioSeleccionado);

                txtNombreModificado.Text = usuario.Nombre;
                txtApellidoModificado.Text = usuario.Apellido;
                txtEmailModificado.Text = usuario.Email;
                txtUsuarioModificado.Text = usuario.Username;
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

                    MaterialDialog materialDialog = new MaterialDialog(this, "Aviso", "Usuario agregado correctamente.", "OK");
                    materialDialog.ShowDialog(this);
                    nuevoUsuario = BLLUsuario.BuscarUsuarioPorUsername(nuevoUsuario.Username);
                    //RegistrarBitacora(nuevoUsuario, $"Se ha registrado un nuevo usuario con Id: {nuevoUsuario.Id}");
                }

                ActualizarListaUsuarios();
                tabControlUsuarios.SelectedTab = tabListaUsuarios;

            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
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
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
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
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
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
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
            }
        }


        #endregion


        #region Tab Modificar:

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = new BEUsuario(idUsuarioSeleccionado);
                usuario.Nombre = txtNombreModificado.Text;
                usuario.Apellido = txtApellidoModificado.Text;
                usuario.Email = txtEmailModificado.Text;
                usuario.Username = txtUsuarioModificado.Text;

                MaterialDialog materialDialog = new MaterialDialog(this, "Aviso", "¿Esta seguro que desea modificar el usuario?", "Sí, deseo modificarlo", true, "Cancelar");
                DialogResult result = materialDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    bool guardado = BLLUsuario.Editar(usuario);
                    if (guardado)
                    {
                        BLLUsuario.RecalcularDigitoVerificadorVertical();

                        RegistrarBitacora($"El usuario ha modificado un usuario", BEBitacora.BitacoraTipo.INFO);
                        MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Usuario modificado con exito", 2500);
                        SnackBarMessage.Show(this);
                    }
                    ActualizarListaUsuarios();
                    tabControlUsuarios.SelectedTab = tabListaUsuarios;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrarBitacora($"Ha ocurrido un error: {ex.Message}", BEBitacora.BitacoraTipo.ERROR);
                return;
            }
        }





        #endregion

      
    }
}
