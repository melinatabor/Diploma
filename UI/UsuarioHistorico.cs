using Abstraccion;
using BE;
using BLL;
using MaterialSkin.Controls;
using MetroFramework;
using Servicios.SesionManager;
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
    public partial class UsuarioHistorico : MetroFramework.Forms.MetroForm, ISubscriptor
    {
        private Dictionary<int, MaterialButton> _permisos;
        private void InicializarPermisosMenuItems()
        {
            _permisos = new Dictionary<int, MaterialButton>
            {
                {25, btnRestaurarVersion }
            };

            VerificarPermisos();
        }

        public UsuarioHistorico()
        {
            InitializeComponent();
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
                            if (control is MaterialButton materialBtn)
                            {
                                materialBtn.Text = palabra.Traduccion;
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
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Usuarios Historico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UsuarioHistorico_Load(object sender, EventArgs e)
        {
            try
            {
                btnBuscarVersiones.AutoSizeMode = AutoSizeMode.GrowOnly;
                btnRestaurarVersion.AutoSizeMode = AutoSizeMode.GrowOnly;
                btnBuscarVersiones.Size = new Size(200, 36);
                btnRestaurarVersion.Size = new Size(200, 36);


                Subscribirse();
                Actualizar();
                //ActualizarDGV();
                ddUsuarios.Items.Clear();
                foreach (BEUsuario usuario in BLLUsuario.Listar())
                    ddUsuarios.Items.Add(usuario.Username);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ActualizarDGV(List<BEUsuario> lista)
        {
            try
            {
                dgvUsuariosHistoricos.DataSource = null;
                dgvUsuariosHistoricos.DataSource = lista;

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnBuscarVersiones_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddUsuarios.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Debe seleccionar un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string username = ddUsuarios.Items[ddUsuarios.SelectedIndex].ToString();

                BEUsuario usuario = BLLUsuario.BuscarUsuarioPorUsername(username);

                List<BEUsuario> lista = BLLUsuario.FiltrarHistoricosPorUsuario(usuario.Id);

                if (lista.Count > 0) 
                    ActualizarDGV(lista);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRestaurarVersion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuariosHistoricos.SelectedRows.Count == 1)
                {
                    DialogResult opcion = MetroMessageBox.Show(this, "Desea restaurar esta version?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcion == DialogResult.No)
                        return;

                    string username = ddUsuarios.Items[ddUsuarios.SelectedIndex].ToString();
                    BEUsuario usuario = BLLUsuario.BuscarUsuarioPorUsername(username);

                    BEUsuario usuarioHistorico = (BEUsuario)dgvUsuariosHistoricos.SelectedRows[0].DataBoundItem;
                    bool guardado = BLLUsuario.RestaurarVersion(usuarioHistorico, usuario);

                    if (guardado)
                    {
                        BLLUsuario.RecalcularDigitoVerificadorVertical();

                        MetroMessageBox.Show(
                            this,
                            $"Usuario Restaurado",
                            "Restaurado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }

                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void VerificarPermisos()
        {
            foreach (var p in _permisos)
            {
                int permisoId = p.Key;
                MaterialButton button = p.Value;

                bool permiso = BLLUsuario.VerificarPermiso(permisoId);

                // Ocultar o mostrar los menu items
                button.Visible = permiso;
            }
        }
    }
}
