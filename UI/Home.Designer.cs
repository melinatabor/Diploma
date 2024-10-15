namespace UI
{
    partial class Home
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.listaUsuarios = new MaterialSkin.Controls.MaterialListView();
            this.tabIdiomas = new System.Windows.Forms.TabPage();
            this.tabPermisos = new System.Windows.Forms.TabPage();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.tabBitacora = new System.Windows.Forms.TabPage();
            this.tabCerrar = new System.Windows.Forms.TabPage();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contraseña = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnModificarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabUsuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabInicio);
            this.materialTabControl1.Controls.Add(this.tabUsuarios);
            this.materialTabControl1.Controls.Add(this.tabIdiomas);
            this.materialTabControl1.Controls.Add(this.tabPermisos);
            this.materialTabControl1.Controls.Add(this.tabHistorial);
            this.materialTabControl1.Controls.Add(this.tabBitacora);
            this.materialTabControl1.Controls.Add(this.tabCerrar);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1108, 583);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.pictureBox1);
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Size = new System.Drawing.Size(1100, 557);
            this.tabInicio.TabIndex = 6;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.DistribuidoraLogo;
            this.pictureBox1.Location = new System.Drawing.Point(368, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.Silver;
            this.tabUsuarios.Controls.Add(this.panel1);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(1100, 557);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaUsuarios.AutoSizeTable = false;
            this.listaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Email,
            this.Username,
            this.Contraseña,
            this.Activo});
            this.listaUsuarios.Depth = 0;
            this.listaUsuarios.FullRowSelect = true;
            this.listaUsuarios.HideSelection = false;
            this.listaUsuarios.Location = new System.Drawing.Point(59, 29);
            this.listaUsuarios.MinimumSize = new System.Drawing.Size(200, 100);
            this.listaUsuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listaUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            this.listaUsuarios.MultiSelect = false;
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.OwnerDraw = true;
            this.listaUsuarios.Size = new System.Drawing.Size(977, 364);
            this.listaUsuarios.TabIndex = 0;
            this.listaUsuarios.UseCompatibleStateImageBehavior = false;
            this.listaUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // tabIdiomas
            // 
            this.tabIdiomas.Location = new System.Drawing.Point(4, 22);
            this.tabIdiomas.Name = "tabIdiomas";
            this.tabIdiomas.Padding = new System.Windows.Forms.Padding(3);
            this.tabIdiomas.Size = new System.Drawing.Size(1100, 557);
            this.tabIdiomas.TabIndex = 1;
            this.tabIdiomas.Text = "Idiomas";
            this.tabIdiomas.UseVisualStyleBackColor = true;
            // 
            // tabPermisos
            // 
            this.tabPermisos.Location = new System.Drawing.Point(4, 22);
            this.tabPermisos.Name = "tabPermisos";
            this.tabPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermisos.Size = new System.Drawing.Size(1100, 557);
            this.tabPermisos.TabIndex = 2;
            this.tabPermisos.Text = "Permisos";
            this.tabPermisos.UseVisualStyleBackColor = true;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Location = new System.Drawing.Point(4, 22);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Size = new System.Drawing.Size(1100, 557);
            this.tabHistorial.TabIndex = 3;
            this.tabHistorial.Text = "Historial";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // tabBitacora
            // 
            this.tabBitacora.Location = new System.Drawing.Point(4, 22);
            this.tabBitacora.Name = "tabBitacora";
            this.tabBitacora.Size = new System.Drawing.Size(1100, 557);
            this.tabBitacora.TabIndex = 4;
            this.tabBitacora.Text = "Bitácora";
            this.tabBitacora.UseVisualStyleBackColor = true;
            // 
            // tabCerrar
            // 
            this.tabCerrar.Location = new System.Drawing.Point(4, 22);
            this.tabCerrar.Name = "tabCerrar";
            this.tabCerrar.Size = new System.Drawing.Size(1100, 557);
            this.tabCerrar.TabIndex = 5;
            this.tabCerrar.Text = "Cerrar Sesión";
            this.tabCerrar.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 58;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 124;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 138;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 193;
            // 
            // Username
            // 
            this.Username.Text = "Usuario";
            this.Username.Width = 131;
            // 
            // Contraseña
            // 
            this.Contraseña.Text = "Contraseña";
            this.Contraseña.Width = 231;
            // 
            // Activo
            // 
            this.Activo.Text = "Activo";
            this.Activo.Width = 102;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnEliminarUsuario);
            this.panel1.Controls.Add(this.btnModificarUsuario);
            this.panel1.Controls.Add(this.btnAgregarUsuario);
            this.panel1.Controls.Add(this.listaUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 551);
            this.panel1.TabIndex = 14;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarUsuario.AutoSize = false;
            this.btnEliminarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarUsuario.Depth = 0;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarUsuario.HighEmphasis = true;
            this.btnEliminarUsuario.Icon = global::UI.Properties.Resources.Borrar;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(735, 414);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarUsuario.Size = new System.Drawing.Size(301, 49);
            this.btnEliminarUsuario.TabIndex = 13;
            this.btnEliminarUsuario.Tag = "btnEliminarUsuario";
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarUsuario.UseAccentColor = false;
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarUsuario.AutoSize = false;
            this.btnModificarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarUsuario.Depth = 0;
            this.btnModificarUsuario.HighEmphasis = true;
            this.btnModificarUsuario.Icon = global::UI.Properties.Resources.Edit;
            this.btnModificarUsuario.Location = new System.Drawing.Point(394, 414);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarUsuario.Size = new System.Drawing.Size(333, 49);
            this.btnModificarUsuario.TabIndex = 12;
            this.btnModificarUsuario.Tag = "btnModificarUsuario";
            this.btnModificarUsuario.Text = "Modificar usuario";
            this.btnModificarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnModificarUsuario.UseAccentColor = true;
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarUsuario.AutoSize = false;
            this.btnAgregarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarUsuario.Depth = 0;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarUsuario.HighEmphasis = true;
            this.btnAgregarUsuario.Icon = global::UI.Properties.Resources.Registro;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(58, 414);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarUsuario.Size = new System.Drawing.Size(328, 49);
            this.btnAgregarUsuario.TabIndex = 11;
            this.btnAgregarUsuario.Tag = "btnAgregarUsuario";
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarUsuario.UseAccentColor = true;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 650);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Home";
            this.Text = "Distribuidora Del Haras";
            this.materialTabControl1.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabUsuarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TabPage tabIdiomas;
        private System.Windows.Forms.TabPage tabPermisos;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TabPage tabBitacora;
        private System.Windows.Forms.TabPage tabCerrar;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialListView listaUsuarios;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Contraseña;
        private System.Windows.Forms.ColumnHeader Activo;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnEliminarUsuario;
        private MaterialSkin.Controls.MaterialButton btnModificarUsuario;
        private MaterialSkin.Controls.MaterialButton btnAgregarUsuario;
    }
}