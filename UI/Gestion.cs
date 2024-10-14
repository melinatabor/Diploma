using Abstraccion;
using BE;
using BLL;
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
using MetroFramework;

namespace UI
{
    public partial class Gestion : MetroFramework.Forms.MetroForm, ISubscriptor
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void ActualizarDgv()
        {
            try
            {
                gridUsuarios.DataSource = null;
                gridUsuarios.DataSource = BLLUsuario.Listar();
            }
            catch (Exception ex)
            {
                RegistrarBitacora(ex.Message, BEBitacora.BitacoraTipo.ERROR);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            ActualizarDgv();
            Subscribirse();
            Actualizar();
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

        private void gridUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridUsuarios.Rows.Count > 0 && gridUsuarios.SelectedRows.Count > 0)
                {
                    BEUsuario usuario = (BEUsuario)gridUsuarios.CurrentRow.DataBoundItem;
                    if (usuario.Activo == false)
                    {
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        btnEliminar.Enabled = true;
                        btnModificar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Registro registro = new Registro();
                registro.Show();
                registro.FormClosed += (s, args) => ActualizarDgv();
            }
            catch (Exception ex)
            {
                RegistrarBitacora(ex.Message, BEBitacora.BitacoraTipo.ERROR);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridUsuarios.Rows.Count <= 0) throw new Exception("No hay usuarios para modificar.");
                if (gridUsuarios.SelectedRows.Count <= 0) throw new Exception("Selecciona una fila para modificar.");

                DataGridViewRow filaSeleccionada = gridUsuarios.SelectedRows[0];

                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                Modificacion modificacion = new Modificacion(idUsuario);
                modificacion.Show();
                modificacion.FormClosed += (s, args) => ActualizarDgv();

            }
            catch (Exception ex)
            {
                RegistrarBitacora(ex.Message, BEBitacora.BitacoraTipo.ERROR);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridUsuarios.Rows.Count <= 0) throw new Exception("No hay usuarios para eliminar.");
                if (gridUsuarios.SelectedRows.Count <= 0) throw new Exception("Selecciona una fila para eliminar.");
                BEUsuario usuario = (BEUsuario)gridUsuarios.CurrentRow.DataBoundItem;
                DialogResult respuesta = MetroMessageBox.Show(this, $"¿Esta seguro que desea eliminar el usuario {usuario.Nombre} {usuario.Apellido}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    bool eliminado = BLLUsuario.Eliminar(usuario);
                    if (eliminado)
                    {
                        RegistrarBitacora($"El usuario ha eliminado el usuario con ID: {usuario.Id}", BEBitacora.BitacoraTipo.INFO);
                        MetroMessageBox.Show(this, "Usuario eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDgv();
                    }

                }
            }
            catch (Exception ex)
            {
                RegistrarBitacora(ex.Message, BEBitacora.BitacoraTipo.ERROR);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            control.Text = palabra.Traduccion;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Idioma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
