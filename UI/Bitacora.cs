using BE;
using BLL;
using System;
using System.Windows.Forms;
using MetroFramework;
using Abstraccion;
using System.Collections.Generic;
using System.Globalization;
using static System.Net.WebRequestMethods;

namespace UI
{
    public partial class Bitacora : MetroFramework.Forms.MetroForm, ISubscriptor
    {
        private int _pagina = 1;
        private int _rowsPerPage = 5;
        private string _paginaTag = "Página:";

        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            try
            {
                dtFrom.Format = dtTo.Format = DateTimePickerFormat.Custom;
                dtFrom.CustomFormat = dtTo.CustomFormat = "dd-MM-yyyy";
                Subscribirse();
                Actualizar();
                labelPagina.Text = _paginaTag + " " + _pagina.ToString();

                dtFrom.Value = new DateTime(DateTime.Now.Year, 1, 1);
                dtTo.Value = DateTime.Now;

                comboBoxTipo.Items.Clear();
                comboBoxTipo.Items.Add(BEBitacora.BitacoraTipo.INFO);
                comboBoxTipo.Items.Add(BEBitacora.BitacoraTipo.ERROR);

                comboBoxUsuario.Items.Clear();
                foreach (BEUsuario usuario in BLLUsuario.Listar())
                    comboBoxUsuario.Items.Add(usuario.Username);

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtFrom.Value,
                    Hasta = dtTo.Value,
                    Tipo = null,
                    Usuario = null,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };
                gridBitacora.DataSource = null;
                gridBitacora.DataSource = BLLBitacora.Filtrar(criteria);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                _pagina -= 1;

                if (_pagina <= 1)
                {
                    btnLeft.Enabled = false;
                    labelPagina.Text = _paginaTag + " " + _pagina.ToString();
                    return;
                }

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtFrom.Value,
                    Hasta = dtTo.Value,
                    Tipo = comboBoxTipo.SelectedIndex + 1,
                    Usuario = comboBoxUsuario.Text,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };
                gridBitacora.DataSource = null;
                gridBitacora.DataSource = BLLBitacora.Filtrar(criteria);

                btnRight.Enabled = true;

                labelPagina.Text = _paginaTag + " " + _pagina.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                _pagina += 1;

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtFrom.Value,
                    Hasta = dtTo.Value,
                    Tipo = comboBoxTipo.SelectedIndex + 1,
                    Usuario = comboBoxUsuario.Text,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };

                var results = BLLBitacora.Filtrar(criteria);

                if (results.Count < _rowsPerPage)
                    btnRight.Enabled = false;

                else
                    btnRight.Enabled = true;

                gridBitacora.DataSource = null;
                gridBitacora.DataSource = results;

                btnLeft.Enabled = true;

                labelPagina.Text = _paginaTag + " " + _pagina.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                _pagina = 1;
                btnLeft.Enabled = false;

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtFrom.Value,
                    Hasta = dtTo.Value,
                    Tipo = comboBoxTipo.SelectedIndex + 1,
                    Usuario = comboBoxUsuario.Text,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };

                var results = BLLBitacora.Filtrar(criteria);

                if (results.Count < _rowsPerPage)
                    btnRight.Enabled = false;

                else
                    btnRight.Enabled = true;

                gridBitacora.DataSource = null;
                gridBitacora.DataSource = results;

                labelPagina.Text = _paginaTag + " " + _pagina.ToString();
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
                            if (control is MaterialSkin.Controls.MaterialComboBox materialComboBox)
                            {
                                materialComboBox.Hint = palabra.Traduccion;
                            }
                            else if (control is Label label && label.Name == "labelPagina")
                            {
                                label.Text = _paginaTag = palabra.Traduccion;
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
    }
}
