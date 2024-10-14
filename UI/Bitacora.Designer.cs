namespace UI
{
    partial class Bitacora
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gridBitacora = new MetroFramework.Controls.MetroGrid();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.comboBoxTipo = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.labelPagina = new System.Windows.Forms.Label();
            this.btnLeft = new MaterialSkin.Controls.MaterialButton();
            this.btnRight = new MaterialSkin.Controls.MaterialButton();
            this.btnFiltrar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Tag = "labelHasta";
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 3;
            this.label1.Tag = "labelDesde";
            this.label1.Text = "Desde:";
            // 
            // gridBitacora
            // 
            this.gridBitacora.AllowUserToResizeRows = false;
            this.gridBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridBitacora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBitacora.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridBitacora.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridBitacora.EnableHeadersVisualStyles = false;
            this.gridBitacora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridBitacora.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBitacora.Location = new System.Drawing.Point(5, 221);
            this.gridBitacora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridBitacora.MultiSelect = false;
            this.gridBitacora.Name = "gridBitacora";
            this.gridBitacora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridBitacora.RowHeadersWidth = 82;
            this.gridBitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBitacora.Size = new System.Drawing.Size(1143, 185);
            this.gridBitacora.Style = MetroFramework.MetroColorStyle.Purple;
            this.gridBitacora.TabIndex = 1;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtFrom.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dtFrom.Location = new System.Drawing.Point(26, 161);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(309, 29);
            this.dtFrom.TabIndex = 11;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(370, 160);
            this.dtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(318, 29);
            this.dtTo.TabIndex = 12;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.AutoResize = false;
            this.comboBoxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTipo.Depth = 0;
            this.comboBoxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTipo.DropDownHeight = 118;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.DropDownWidth = 121;
            this.comboBoxTipo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Hint = "Seleccionar Tipo";
            this.comboBoxTipo.IntegralHeight = false;
            this.comboBoxTipo.ItemHeight = 29;
            this.comboBoxTipo.Location = new System.Drawing.Point(26, 62);
            this.comboBoxTipo.MaxDropDownItems = 4;
            this.comboBoxTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(223, 35);
            this.comboBoxTipo.StartIndex = 0;
            this.comboBoxTipo.TabIndex = 18;
            this.comboBoxTipo.Tag = "bitacoraTipo";
            this.comboBoxTipo.UseAccent = false;
            this.comboBoxTipo.UseTallSize = false;
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.AutoResize = false;
            this.comboBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxUsuario.Depth = 0;
            this.comboBoxUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxUsuario.DropDownHeight = 118;
            this.comboBoxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuario.DropDownWidth = 121;
            this.comboBoxUsuario.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Hint = "Seleccionar Usuario";
            this.comboBoxUsuario.IntegralHeight = false;
            this.comboBoxUsuario.ItemHeight = 29;
            this.comboBoxUsuario.Location = new System.Drawing.Point(282, 62);
            this.comboBoxUsuario.MaxDropDownItems = 4;
            this.comboBoxUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(406, 35);
            this.comboBoxUsuario.StartIndex = 0;
            this.comboBoxUsuario.TabIndex = 19;
            this.comboBoxUsuario.Tag = "bitacoraUsuario";
            this.comboBoxUsuario.UseAccent = false;
            this.comboBoxUsuario.UseTallSize = false;
            // 
            // labelPagina
            // 
            this.labelPagina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPagina.AutoSize = true;
            this.labelPagina.Font = new System.Drawing.Font("Segoe UI Semilight", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagina.Location = new System.Drawing.Point(516, 430);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(87, 30);
            this.labelPagina.TabIndex = 10;
            this.labelPagina.Tag = "labelPagina";
            this.labelPagina.Text = "Página: ";
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLeft.AutoSize = false;
            this.btnLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLeft.Depth = 0;
            this.btnLeft.Enabled = false;
            this.btnLeft.HighEmphasis = true;
            this.btnLeft.Icon = global::UI.Properties.Resources.Left;
            this.btnLeft.Location = new System.Drawing.Point(453, 430);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLeft.Size = new System.Drawing.Size(43, 40);
            this.btnLeft.TabIndex = 22;
            this.btnLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLeft.UseAccentColor = false;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRight.AutoSize = false;
            this.btnRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRight.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRight.Depth = 0;
            this.btnRight.HighEmphasis = true;
            this.btnRight.Icon = global::UI.Properties.Resources.Right;
            this.btnRight.Location = new System.Drawing.Point(676, 430);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRight.Name = "btnRight";
            this.btnRight.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRight.Size = new System.Drawing.Size(43, 40);
            this.btnRight.TabIndex = 21;
            this.btnRight.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRight.UseAccentColor = false;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.AutoSize = false;
            this.btnFiltrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFiltrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFiltrar.Depth = 0;
            this.btnFiltrar.HighEmphasis = true;
            this.btnFiltrar.Icon = global::UI.Properties.Resources.Filtrar;
            this.btnFiltrar.Location = new System.Drawing.Point(705, 62);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFiltrar.Size = new System.Drawing.Size(443, 148);
            this.btnFiltrar.TabIndex = 23;
            this.btnFiltrar.Tag = "btnFiltrarMovimientos";
            this.btnFiltrar.Text = "Filtrar Movimientos";
            this.btnFiltrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFiltrar.UseAccentColor = false;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 505);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.labelPagina);
            this.Controls.Add(this.gridBitacora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bitacora";
            this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Tag = "formBitacora";
            this.Text = "Bitácora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid gridBitacora;
        private MetroFramework.Controls.MetroDateTime dtFrom;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTipo;
        private MaterialSkin.Controls.MaterialComboBox comboBoxUsuario;
        private System.Windows.Forms.Label labelPagina;
        private MaterialSkin.Controls.MaterialButton btnRight;
        private MaterialSkin.Controls.MaterialButton btnLeft;
        private MaterialSkin.Controls.MaterialButton btnFiltrar;
    }
}