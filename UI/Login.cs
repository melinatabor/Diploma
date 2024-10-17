using System;
using System.Windows.Forms;
using MetroFramework;
using BE;
using BLL;
using Servicios.SesionManager;

namespace UI
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            // Aplicar focus en el formulario
            this.Shown += new EventHandler(this.LoginFocus);
        }

        private void LoginFocus(object sender, EventArgs e)
        {
            try
            {
                this.Activate();
                inputUsuario.Focus();
            }
            catch (Exception ex) { throw ex; }
        }

        private bool CamposInvalidos()
        {
            return String.IsNullOrEmpty(inputUsuario.Text.Trim()) ||
                String.IsNullOrEmpty(inputPsw.Text.Trim());
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposInvalidos()) throw new Exception("Los campos ingresados están vacíos. Por favor completalos.");

                BEUsuario usuario = new BEUsuario()
                {
                    Username = inputUsuario.Text,
                    Password = inputPsw.Text
                };

                BLLUsuario.Login(usuario);

                MetroMessageBox.Show(
                    this,
                    $"Usuario logeado: {SesionManager.GetUsername()}",
                    "Logeado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Home home = new Home();
                home.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Registro formRegistro = new Registro();
                formRegistro.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
