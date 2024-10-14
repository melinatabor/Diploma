using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraccion;
using BE;
using BLL;
using MetroFramework;
using Servicios.SesionManager;

namespace UI
{
    public partial class Idioma : MetroFramework.Forms.MetroForm, ISubscriptor
    {
        private string _tag = "Traducción para ";

        public Idioma()
        {
            InitializeComponent();
        }

        private void Idioma_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarDgv();
                Subscribirse();
                Actualizar();
                ActualizarDropDown();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

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

        private void ActualizarDgv(int idIdioma = 1)
        {
            try
            {
                List<BETraduccion> lista = BLLTraduccion.Listar(idIdioma);

                dgvTraduccion.DataSource = null;
                dgvTraduccion.DataSource = lista;

                bool deshabilitarBtn = lista.Any(t => string.IsNullOrEmpty(t.Traduccion));
                btnCambiarIdioma.Enabled = !deshabilitarBtn;
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

        private void btnCambiarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                BEIdioma idioma = (BEIdioma) ddIdiomas.SelectedItem;
                if (idioma != null)
                {
                    BLLIdioma.CambiarIdioma(idioma.Id);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Idioma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ddIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddIdiomas.SelectedValue != null && ddIdiomas.SelectedValue is int selectedId)
                    ActualizarDgv(selectedId);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void dgvTraduccion_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTraduccion.SelectedRows.Count > 0)
                {
                    BETraduccion traduccion = (BETraduccion)dgvTraduccion.SelectedRows[0].DataBoundItem;

                    string tag = traduccion.Tag;
                    string trad = traduccion.Traduccion;

                    labelTag.Text = _tag + tag + ":";
                    txtTraduccion.Hint = trad;
                    txtTraduccion.Text = trad;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Idioma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTraduccion.SelectedRows.Count != 1)
                    throw new Exception("Debe seleccionar una traducción");
                    
                BETraduccion traduccion = (BETraduccion)dgvTraduccion.SelectedRows[0].DataBoundItem;

                BEIdioma idioma = (BEIdioma)ddIdiomas.SelectedItem;

                DialogResult result = MetroMessageBox.Show(
                    this, 
                    "¿Está seguro que desea modificar la traducción?",
                    "Confirmación", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                    return;

                BLLTraduccion.Modificar(idioma, traduccion, txtTraduccion.Text.Trim());

                ActualizarDgv(idioma.Id);

                txtTraduccion.Text = "";
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(inputNuevoIdioma.Text))
                {
                    MetroMessageBox.Show(this, "Debe ingresar un idioma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MetroMessageBox.Show(this, "¿Está seguro que desea agregar el idioma?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) 
                    return;

                BEIdioma idioma = new BEIdioma {
                    Idioma = inputNuevoIdioma.Text
                };

                bool agregado = BLLIdioma.Agregar(idioma);

                if (agregado)
                {
                    MetroMessageBox.Show(this, "Idioma agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDropDown();
                    inputNuevoIdioma.Text = "";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
