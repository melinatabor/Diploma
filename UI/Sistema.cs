using BE;
using BLL;
using Servicios.SesionManager;
using System;
using System.Windows.Forms;
using MetroFramework;
using Abstraccion;
using System.Collections.Generic;

namespace UI
{
    public partial class Sistema : MetroFramework.Forms.MetroForm, ISubscriptor
    {
        private Dictionary<int, ToolStripMenuItem> _permisosMDI;
        private void InicializarPermisosMenuItems()
        {
            _permisosMDI = new Dictionary<int, ToolStripMenuItem>
            {
                { 7,  usuariosToolStripMenuItem     },
                { 11, idiomaToolStripMenuItem       },
                { 16, permisosToolStripMenuItem     },
                { 17, informesToolStripMenuItem     },
                { 24, historicosToolStripMenuItem   },
            };

            VerificarPermisos();
        }

        public Sistema()
        {
            try
            {
                InitializeComponent();
                usuarioLogeadoTxt.Text = $"User: {SesionManager.GetUsername()}";
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Gestion usuarios = new Gestion();
                usuarios.MdiParent = this;
                usuarios.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MetroMessageBox.Show(this, "Desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    // Es necesario cerrar los furmularios hijos para evitar un error al estar maximizados
                    foreach (Form childForm in this.MdiChildren)
                    {
                        childForm.Close();
                    }

                    RegistrarBitacora();
                    SesionManager.Logout();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MetroMessageBox.Show(this, "Desea cerrar la sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    RegistrarBitacora();
                    SesionManager.Logout();
                    Login login = new Login();
                    login.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RegistrarBitacora()
        {
            try
            {
                string username = SesionManager.GetUsername();

                BEUsuario usuarioActual = BLLUsuario.BuscarUsuarioPorUsername(username) ?? throw new Exception($"No existe el username: {username}");

                BEBitacora bitacora = new BEBitacora()
                {
                    Usuario = usuarioActual.Id,
                    Tipo = BEBitacora.BitacoraTipo.INFO,
                    Mensaje = "El usuario finalizó la sesión"
                };

                BLLBitacora.Agregar(bitacora);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitacora bitacora = new Bitacora();
                bitacora.MdiParent = this;
                bitacora.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Idioma idioma = new Idioma();
                idioma.MdiParent = this;
                idioma.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Permiso permiso = new Permiso();
                permiso.MdiParent = this;
                permiso.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            try
            {
                Subscribirse();
                Actualizar();
                InicializarPermisosMenuItems();
                
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

                // Actualizar los ToolStripMenuItem
                foreach (ToolStripMenuItem menuItem in this.MainMenuStrip.Items)
                    ActualizarToolStripMenuItem(menuItem, palabras);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Idioma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ActualizarToolStripMenuItem(ToolStripMenuItem menuItem, List<BEPalabra> palabras)
        {
            if (menuItem.Tag != null && menuItem.Tag.ToString() != "")
            {
                BEPalabra palabra = palabras.Find(pal => pal.Tag.Equals(menuItem.Tag.ToString()));

                if (palabra != null)
                    menuItem.Text = palabra.Traduccion;
            }

            // Actualizar recursivamente los subitems
            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenuItem)
                    ActualizarToolStripMenuItem(subMenuItem, palabras);
            }
        }

        private void VerificarPermisos()
        {
            foreach (var permisoMenu in _permisosMDI)
            {
                int permisoId = permisoMenu.Key;
                ToolStripMenuItem menuItem = permisoMenu.Value;

                bool permiso = BLLUsuario.VerificarPermiso(permisoId);

                // Ocultar o mostrar los menu items
                menuItem.Visible = permiso;
            }
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioHistorico usuarioHistorico = new UsuarioHistorico();
                usuarioHistorico.MdiParent = this;
                usuarioHistorico.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
