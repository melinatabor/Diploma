namespace UI
{
    partial class Idioma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ddIdiomas = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCambiarIdioma = new MetroFramework.Controls.MetroButton();
            this.dgvTraduccion = new MetroFramework.Controls.MetroGrid();
            this.labelTag = new System.Windows.Forms.Label();
            this.txtTraduccion = new MaterialSkin.Controls.MaterialTextBox();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.inputNuevoIdioma = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // ddIdiomas
            // 
            this.ddIdiomas.AutoResize = false;
            this.ddIdiomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddIdiomas.Depth = 0;
            this.ddIdiomas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddIdiomas.DropDownHeight = 174;
            this.ddIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddIdiomas.DropDownWidth = 121;
            this.ddIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ddIdiomas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddIdiomas.FormattingEnabled = true;
            this.ddIdiomas.Hint = "Seleccionar Idioma";
            this.ddIdiomas.IntegralHeight = false;
            this.ddIdiomas.ItemHeight = 43;
            this.ddIdiomas.Location = new System.Drawing.Point(12, 33);
            this.ddIdiomas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddIdiomas.MaxDropDownItems = 4;
            this.ddIdiomas.MouseState = MaterialSkin.MouseState.OUT;
            this.ddIdiomas.Name = "ddIdiomas";
            this.ddIdiomas.Size = new System.Drawing.Size(175, 49);
            this.ddIdiomas.StartIndex = 0;
            this.ddIdiomas.TabIndex = 1;
            this.ddIdiomas.Tag = "idiomasIdioma";
            this.ddIdiomas.SelectedIndexChanged += new System.EventHandler(this.ddIdiomas_SelectedIndexChanged);
            // 
            // btnCambiarIdioma
            // 
            this.btnCambiarIdioma.Location = new System.Drawing.Point(205, 33);
            this.btnCambiarIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCambiarIdioma.Name = "btnCambiarIdioma";
            this.btnCambiarIdioma.Size = new System.Drawing.Size(119, 31);
            this.btnCambiarIdioma.TabIndex = 2;
            this.btnCambiarIdioma.Tag = "btnCambiarIdioma";
            this.btnCambiarIdioma.Text = "Cambiar Idioma";
            this.btnCambiarIdioma.UseSelectable = true;
            this.btnCambiarIdioma.Click += new System.EventHandler(this.btnCambiarIdioma_Click);
            // 
            // dgvTraduccion
            // 
            this.dgvTraduccion.AllowUserToResizeRows = false;
            this.dgvTraduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTraduccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTraduccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTraduccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTraduccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraduccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTraduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraduccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraduccion.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTraduccion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTraduccion.EnableHeadersVisualStyles = false;
            this.dgvTraduccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTraduccion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTraduccion.Location = new System.Drawing.Point(10, 31);
            this.dgvTraduccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTraduccion.MultiSelect = false;
            this.dgvTraduccion.Name = "dgvTraduccion";
            this.dgvTraduccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraduccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTraduccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTraduccion.RowTemplate.Height = 33;
            this.dgvTraduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraduccion.Size = new System.Drawing.Size(378, 330);
            this.dgvTraduccion.TabIndex = 3;
            this.dgvTraduccion.SelectionChanged += new System.EventHandler(this.dgvTraduccion_SelectionChanged);
            // 
            // labelTag
            // 
            this.labelTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(425, 207);
            this.labelTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(29, 13);
            this.labelTag.TabIndex = 4;
            this.labelTag.Tag = "labelTag";
            this.labelTag.Text = "Tag:";
            // 
            // txtTraduccion
            // 
            this.txtTraduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTraduccion.AnimateReadOnly = false;
            this.txtTraduccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTraduccion.Depth = 0;
            this.txtTraduccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTraduccion.LeadingIcon = null;
            this.txtTraduccion.Location = new System.Drawing.Point(428, 235);
            this.txtTraduccion.MaxLength = 50;
            this.txtTraduccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTraduccion.Multiline = false;
            this.txtTraduccion.Name = "txtTraduccion";
            this.txtTraduccion.Size = new System.Drawing.Size(232, 50);
            this.txtTraduccion.TabIndex = 9;
            this.txtTraduccion.Tag = "";
            this.txtTraduccion.Text = "";
            this.txtTraduccion.TrailingIcon = null;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.AutoSize = false;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificar.Depth = 0;
            this.btnModificar.HighEmphasis = true;
            this.btnModificar.Icon = global::UI.Properties.Resources.Right;
            this.btnModificar.Location = new System.Drawing.Point(428, 285);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificar.Size = new System.Drawing.Size(232, 47);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Tag = "btnIdiomasModificar";
            this.btnModificar.Text = "Modificar Traducción";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // inputNuevoIdioma
            // 
            this.inputNuevoIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNuevoIdioma.AnimateReadOnly = false;
            this.inputNuevoIdioma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNuevoIdioma.Depth = 0;
            this.inputNuevoIdioma.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputNuevoIdioma.Hint = "Nuevo Idioma";
            this.inputNuevoIdioma.LeadingIcon = null;
            this.inputNuevoIdioma.Location = new System.Drawing.Point(428, 35);
            this.inputNuevoIdioma.MaxLength = 50;
            this.inputNuevoIdioma.MouseState = MaterialSkin.MouseState.OUT;
            this.inputNuevoIdioma.Multiline = false;
            this.inputNuevoIdioma.Name = "inputNuevoIdioma";
            this.inputNuevoIdioma.Size = new System.Drawing.Size(232, 50);
            this.inputNuevoIdioma.TabIndex = 11;
            this.inputNuevoIdioma.Tag = "nuevoIdioma";
            this.inputNuevoIdioma.Text = "";
            this.inputNuevoIdioma.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::UI.Properties.Resources.Right;
            this.materialButton1.Location = new System.Drawing.Point(428, 86);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(232, 47);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Tag = "btnAgregarIdioma";
            this.materialButton1.Text = "Agregar Idioma";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 371);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.inputNuevoIdioma);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtTraduccion);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.dgvTraduccion);
            this.Controls.Add(this.btnCambiarIdioma);
            this.Controls.Add(this.ddIdiomas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Idioma";
            this.Padding = new System.Windows.Forms.Padding(10, 31, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Tag = "formIdioma";
            this.Text = "Idiomas";
            this.Load += new System.EventHandler(this.Idioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox ddIdiomas;
        private MetroFramework.Controls.MetroButton btnCambiarIdioma;
        private MetroFramework.Controls.MetroGrid dgvTraduccion;
        private System.Windows.Forms.Label labelTag;
        private MaterialSkin.Controls.MaterialTextBox txtTraduccion;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialTextBox inputNuevoIdioma;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}