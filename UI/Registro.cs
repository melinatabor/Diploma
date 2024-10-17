using BE;
using BLL;
using System;
using System.Windows.Forms;
using Servicios.Validador;
using MetroFramework;
using Abstraccion;
using System.Collections.Generic;
using Servicios.SesionManager;

namespace UI
{
    public partial class Registro : MaterialSkin.Controls.MaterialForm, ISubscriptor
    {
        private bool emailValido = false;
        private bool pswValida = false;

        public Registro()
        {
            InitializeComponent();
        }

        private BEUsuario ObtenerDatos()
        {
            try
            {
                if (CamposInvalidos()) throw new Exception("Los datos ingresados son incorrectos");

                BEUsuario nuevoUsuario = new BEUsuario()
                {
                    Nombre   = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email    = txtEmail.Text,
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

        private bool CamposInvalidos()
        {
            return String.IsNullOrEmpty(txtNombre.Text.Trim()) || 
                String.IsNullOrEmpty(txtApellido.Text.Trim()) || 
                String.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                String.IsNullOrEmpty(txtUsername.Text.Trim()) ||
                String.IsNullOrEmpty(txtPsw.Text.Trim());
        }

        private void RegistrarBitacora(BEUsuario usuario, string mensaje, BEBitacora.BitacoraTipo tipo = BEBitacora.BitacoraTipo.INFO)
        {
            try
            {
                BEBitacora bitacora = new BEBitacora()
                {
                    Usuario = usuario.Id,
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
                    RegistrarBitacora(nuevoUsuario, $"Se ha registrado un nuevo usuario con Id: {nuevoUsuario.Id}");
                }
                Close();

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

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Validador.Validar(txtEmail.Text.Trim(), Validador.TipoValidacion.Email))
                {
                    toolTipFormRegistro.SetToolTip(txtEmail, "");
                    emailValido = true;
                }
                else
                {
                    toolTipFormRegistro.SetToolTip(txtEmail, "Falta agregar el @ o el formato del email es incorrecto.");
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
                    toolTipFormRegistro.SetToolTip(txtPsw, "");
                    pswValida = true;
                }
                else
                {
                    toolTipFormRegistro.SetToolTip(txtPsw, "Requiere al menos una letra minúscula.\r\n" +
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

        public void Subscribirse()
        {
            try
            {
                BLLIdioma.RegistrarSubscriptor(this);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Subscripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            if (control is MaterialSkin.Controls.MaterialTextBox materialTextBox)
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
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Registro Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            try
            {
                // Necesario para el registro que esta en la seccion del Login
                if (SesionManager.GetSession() != null)
                {
                    Subscribirse();
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
