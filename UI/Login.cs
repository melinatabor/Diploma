using System;
using System.Windows.Forms;
using MetroFramework;
using BE;
using BLL;
using Servicios.SesionManager;
using MaterialSkin.Controls;

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

                MaterialDialog materialDialog = new MaterialDialog(this, "Login", $"Usuario logeado: {SesionManager.GetUsername()}", "OK");
                materialDialog.ShowDialog(this);
                Home home = new Home();
                home.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
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
                MaterialDialog materialDialog = new MaterialDialog(this, "Error", ex.Message, "OK");
                materialDialog.ShowDialog(this);
                return;
            }
        }
    }
}
