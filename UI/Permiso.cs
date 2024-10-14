using Abstraccion;
using BE;
using BLL;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Permiso : MetroFramework.Forms.MetroForm, ISubscriptor
    {
        public Permiso()
        {
            InitializeComponent();
        }

        /*
         * No vamos a permitir el alta de permisos desde UI
         * 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BEPermiso permiso = new BEPermisoSimple() { Nombre = txtNombre.Text };

                if (string.IsNullOrEmpty(permiso.Nombre)) throw new Exception("El nombre del permiso no puede estar vacio.");

                DialogResult opcion = MetroMessageBox.Show(this, "Desea agregar un nuevo permiso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.No)
                    return;

                bool alta = BLLPermiso.AgregarPermisoSimple(permiso);

                if (alta)
                {
                    MetroMessageBox.Show(this, "Permiso agregado correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDGV();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }*/

        private void Permiso_Load(object sender, EventArgs e)
        {
            try
            {
                Subscribirse();
                Actualizar();

                ActualizarDGV();
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = BLLUsuario.Listar();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ActualizarDGV()
        {
            try
            {
                dgvPermisos.DataSource = null;
                dgvPermisos.DataSource = BLLPermiso.ListarPermisos();


                dgvFamilia.DataSource = null;
                dgvFamilia.DataSource = BLLPermiso.ListarFamilias();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LlenarTreeNode(TreeNode tree, BEPermiso permiso)
        {
            TreeNode treenode = new TreeNode(permiso.Nombre);

            treenode.Tag = permiso;
            tree.Nodes.Add(treenode);
            if (permiso.Hijos != null)
                foreach (var item in permiso.Hijos)
                {
                    LlenarTreeNode(treenode, item);
                }

        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                BEPermiso permiso = new BEFamilia() { Nombre = txtFamilia.Text };

                if (string.IsNullOrEmpty(permiso.Nombre)) throw new Exception("El nombre de la familia no puede estar vacio.");

                DialogResult opcion = MetroMessageBox.Show(this, "Desea agregar una nueva familia?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.No)
                    return;

                bool alta = BLLPermiso.AgregarFamilia(permiso);

                if (alta)
                {
                    MetroMessageBox.Show(this, "Familia agregada correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDGV();
                    txtFamilia.Text = "";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPermisos.SelectedRows.Count <= 0)    throw new Exception("Seleccione un permiso para agregar.");
                
                if (dgvFamilia.SelectedRows.Count <= 0)     throw new Exception("Seleccione una familia.");

                DialogResult opcion = MetroMessageBox.Show(this, "Desea agregar el permiso seleccionado a la familia seleccionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.No)
                    return;

                DataGridViewRow filaSeleccionada = dgvPermisos.SelectedRows[0];

                int idPermiso = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                BEPermiso permiso = BLLPermiso.BuscarPermiso(idPermiso);

                if (permiso == null) throw new Exception("El permiso no existe.");

                DataGridViewRow filaSeleccionadaFamilia = dgvFamilia.SelectedRows[0];

                int idFamilia = Convert.ToInt32(filaSeleccionadaFamilia.Cells[0].Value);

                BEPermiso familia = BLLPermiso.BuscarFamilia(idFamilia);

                if (familia == null) throw new Exception("La familia no existe.");

                // Verificar recursividad antes de agregar el permiso a la familia
                if (VerificarRecursividad(permiso, familia))
                {
                    throw new Exception("No se puede agregar el permiso a la familia ya que generaría una recursividad.");
                }

                bool alta = BLLPermiso.AgregarPermisoAFamilia(permiso, familia);

                if (alta)
                {
                    MetroMessageBox.Show(this, "Permiso agregado a familia correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BEPermiso familiaSeleccionada = (BEPermiso)dgvFamilia.CurrentRow.DataBoundItem;
                    ListarArbolRecursivo(familiaSeleccionada);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool VerificarRecursividad(BEPermiso permiso, BEPermiso familia)
        {
            List<BEPermiso> padres = BLLPermiso.ObtenerPadres(familia);

            return padres.Any(a => a.Id == permiso.Id);
        }

        private void ListarArbolRecursivo(BEPermiso familia)
        {
            try
            {
                treeView1.Nodes.Clear();

                TreeNode root = new TreeNode(familia.Nombre);
                root.Tag = familia;
                treeView1.Nodes.Add(root);

                List<BEPermiso> hijos = BLLPermiso.ListarHijosRecursivo(familia);

                foreach (var item in hijos)
                    LlenarTreeNode(root, item);

                treeView1.ExpandAll();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAsignarPermisoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPermisos.SelectedRows.Count <= 0) throw new Exception("Seleccione un permiso para agregar.");
                
                if (dgvUsuarios.SelectedRows.Count <= 0) throw new Exception("Seleccione un usuario.");

                DialogResult opcion = MetroMessageBox.Show(this, "Desea asingar el permiso al usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.No)
                    return;

                DataGridViewRow filaSeleccionada = dgvPermisos.SelectedRows[0];

                int idPermiso = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                BEPermiso permiso = BLLPermiso.BuscarPermiso(idPermiso);

                if (permiso == null) throw new Exception("El permiso no existe.");

                BEUsuario usuario = (BEUsuario)dgvUsuarios.CurrentRow.DataBoundItem;

                usuario = BLLUsuario.BuscarUsuarioPorUsername(usuario.Username);

                if (usuario == null) throw new Exception("El usuario no existe.");

                bool agregado = BLLUsuario.AsignarPermiso(usuario, permiso);

                if (agregado)
                {
                    MetroMessageBox.Show(this, "Permiso agregado a usuario correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvFamilia_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                BEPermiso familiaSeleccionada = (BEPermiso)dgvFamilia.CurrentRow.DataBoundItem;

                ListarArbolRecursivo(familiaSeleccionada);
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

                // Actualizar controles recursivamente
                ActualizarControles(this.Controls, palabras);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Idioma en Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ActualizarControles(Control.ControlCollection controls, List<BEPalabra> palabras)
        {
            foreach (Control control in controls)
            {
                if (control.Tag != null && control.Tag.ToString() != "")
                {
                    BEPalabra palabra = palabras.Find(pal => pal.Tag.Equals(control.Tag.ToString()));
                    if (palabra != null)
                    {
                        if (control is MaterialSkin.Controls.MaterialTextBox materialTextBox)
                            materialTextBox.Hint = palabra.Traduccion;
                        else
                            control.Text = palabra.Traduccion;
                    }
                }

                if (control.Controls.Count > 0)
                    ActualizarControles(control.Controls, palabras);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = (BEUsuario)dgvUsuarios.CurrentRow.DataBoundItem;

                List<BEPermiso> permisos = BLLUsuario.ObtenerPermisos(usuario);

                ListarPermisosUsuario(permisos);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ListarPermisosUsuario(List<BEPermiso> permisosUsuario)
        {
            try
            {
                treeViewPermUsuario.Nodes.Clear();

                TreeNode root = new TreeNode("Permisos de Usuario");
                treeViewPermUsuario.Nodes.Add(root);

                foreach (var permiso in permisosUsuario)
                {
                    TreeNode permisoNode = new TreeNode(permiso.Nombre);
                    permisoNode.Tag = permiso;
                    root.Nodes.Add(permisoNode);

                    if (permiso.EsPadre)
                    {
                        List<BEPermiso> hijos = BLLPermiso.ListarHijosRecursivo(permiso);
                        foreach (var hijo in hijos)
                        {
                            LlenarTreeNode(permisoNode, hijo);
                        }
                    }
                }

                treeViewPermUsuario.ExpandAll();

                /* Antes no mostrabamos los permisos padres:
                    treeViewPermUsuario.Nodes.Clear();

                     TreeNode root = new TreeNode("Permisos de Usuario");
                     treeViewPermUsuario.Nodes.Add(root);

                     List<BEPermiso> hijos = new List<BEPermiso>();
                     foreach (var item in permisosUsuario)
                     {
                         if (item.EsPadre)
                             hijos.AddRange(BLLPermiso.ListarHijosRecursivo(item));
                         else
                             hijos.Add(item);
                     }

                     foreach (var item in hijos)
                         LlenarTreeNode(root, item);

                     treeViewPermUsuario.ExpandAll();
                 */
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEliminarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFamilia.SelectedRows.Count <= 0) throw new Exception("Seleccione una familia.");

                DialogResult opcion = MetroMessageBox.Show(this, "Desea eliminar la familia?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.No)
                    return;

                DataGridViewRow filaSeleccionadaFamilia = dgvFamilia.SelectedRows[0];

                int idFamilia = Convert.ToInt32(filaSeleccionadaFamilia.Cells[0].Value);

                BEPermiso familia = BLLPermiso.BuscarFamilia(idFamilia);

                if (familia == null) throw new Exception("La familia no existe.");

                bool eliminado = BLLPermiso.EliminarFamilia(familia);

                if (eliminado)
                {
                    MetroMessageBox.Show(this, "Familia eliminada correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDGV();
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEliminarPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count <= 0) throw new Exception("Seleccione un usuario.");

                DialogResult opcion = MetroMessageBox.Show(this, "Desea eliminar los permisos asignados al usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.No)
                    return;

                BEUsuario usuario = (BEUsuario)dgvUsuarios.CurrentRow.DataBoundItem;

                bool eliminado = BLLUsuario.EliminarPermisos(usuario);

                if (eliminado)
                {
                    MetroMessageBox.Show(this, "Permisos eliminados correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
