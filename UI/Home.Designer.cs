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
            this.components = new System.ComponentModel.Container();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabCerrar = new System.Windows.Forms.TabPage();
            this.tabBitacora = new System.Windows.Forms.TabPage();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.tabPermisos = new System.Windows.Forms.TabPage();
            this.tabIdiomas = new System.Windows.Forms.TabPage();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlUsuarios = new MaterialSkin.Controls.MaterialTabControl();
            this.tabListaUsuarios = new System.Windows.Forms.TabPage();
            this.listaUsuarios = new MaterialSkin.Controls.MaterialListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contraseña = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnModificarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnRegistro = new MaterialSkin.Controls.MaterialButton();
            this.txtPsw = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.tabSelectorUsuarios = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.toolTipUsuarios = new System.Windows.Forms.ToolTip(this.components);
            this.tabUsuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlUsuarios.SuspendLayout();
            this.tabListaUsuarios.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tabInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 634);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "Modificar Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabCerrar
            // 
            this.tabCerrar.Location = new System.Drawing.Point(4, 22);
            this.tabCerrar.Name = "tabCerrar";
            this.tabCerrar.Size = new System.Drawing.Size(1100, 634);
            this.tabCerrar.TabIndex = 5;
            this.tabCerrar.Text = "Cerrar Sesión";
            this.tabCerrar.UseVisualStyleBackColor = true;
            // 
            // tabBitacora
            // 
            this.tabBitacora.Location = new System.Drawing.Point(4, 22);
            this.tabBitacora.Name = "tabBitacora";
            this.tabBitacora.Size = new System.Drawing.Size(1100, 634);
            this.tabBitacora.TabIndex = 4;
            this.tabBitacora.Text = "Bitácora";
            this.tabBitacora.UseVisualStyleBackColor = true;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Location = new System.Drawing.Point(4, 22);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Size = new System.Drawing.Size(1100, 634);
            this.tabHistorial.TabIndex = 3;
            this.tabHistorial.Text = "Historial";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // tabPermisos
            // 
            this.tabPermisos.Location = new System.Drawing.Point(4, 22);
            this.tabPermisos.Name = "tabPermisos";
            this.tabPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermisos.Size = new System.Drawing.Size(1100, 634);
            this.tabPermisos.TabIndex = 2;
            this.tabPermisos.Text = "Permisos";
            this.tabPermisos.UseVisualStyleBackColor = true;
            // 
            // tabIdiomas
            // 
            this.tabIdiomas.Location = new System.Drawing.Point(4, 22);
            this.tabIdiomas.Name = "tabIdiomas";
            this.tabIdiomas.Padding = new System.Windows.Forms.Padding(3);
            this.tabIdiomas.Size = new System.Drawing.Size(1100, 634);
            this.tabIdiomas.TabIndex = 1;
            this.tabIdiomas.Text = "Idiomas";
            this.tabIdiomas.UseVisualStyleBackColor = true;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.Silver;
            this.tabUsuarios.Controls.Add(this.panel1);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(1100, 634);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.tabControlUsuarios);
            this.panel1.Controls.Add(this.tabSelectorUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 628);
            this.panel1.TabIndex = 14;
            // 
            // tabControlUsuarios
            // 
            this.tabControlUsuarios.Controls.Add(this.tabListaUsuarios);
            this.tabControlUsuarios.Controls.Add(this.tabRegistrar);
            this.tabControlUsuarios.Depth = 0;
            this.tabControlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUsuarios.Location = new System.Drawing.Point(0, 58);
            this.tabControlUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlUsuarios.Multiline = true;
            this.tabControlUsuarios.Name = "tabControlUsuarios";
            this.tabControlUsuarios.SelectedIndex = 0;
            this.tabControlUsuarios.Size = new System.Drawing.Size(1094, 570);
            this.tabControlUsuarios.TabIndex = 15;
            // 
            // tabListaUsuarios
            // 
            this.tabListaUsuarios.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabListaUsuarios.Controls.Add(this.listaUsuarios);
            this.tabListaUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.tabListaUsuarios.Controls.Add(this.btnModificarUsuario);
            this.tabListaUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.tabListaUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabListaUsuarios.Name = "tabListaUsuarios";
            this.tabListaUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaUsuarios.Size = new System.Drawing.Size(1086, 544);
            this.tabListaUsuarios.TabIndex = 1;
            this.tabListaUsuarios.Text = "Lista Usuarios";
            // 
            // listaUsuarios
            // 
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
            this.listaUsuarios.Location = new System.Drawing.Point(19, 6);
            this.listaUsuarios.MinimumSize = new System.Drawing.Size(200, 100);
            this.listaUsuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listaUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            this.listaUsuarios.MultiSelect = false;
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.OwnerDraw = true;
            this.listaUsuarios.Size = new System.Drawing.Size(1045, 368);
            this.listaUsuarios.TabIndex = 0;
            this.listaUsuarios.UseCompatibleStateImageBehavior = false;
            this.listaUsuarios.View = System.Windows.Forms.View.Details;
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
            this.btnAgregarUsuario.Location = new System.Drawing.Point(29, 463);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarUsuario.Size = new System.Drawing.Size(328, 49);
            this.btnAgregarUsuario.TabIndex = 11;
            this.btnAgregarUsuario.Tag = "btnAgregarUsuario";
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarUsuario.UseAccentColor = false;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
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
            this.btnModificarUsuario.Location = new System.Drawing.Point(393, 463);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarUsuario.Size = new System.Drawing.Size(333, 49);
            this.btnModificarUsuario.TabIndex = 12;
            this.btnModificarUsuario.Tag = "btnModificarUsuario";
            this.btnModificarUsuario.Text = "Modificar usuario";
            this.btnModificarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnModificarUsuario.UseAccentColor = false;
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
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
            this.btnEliminarUsuario.Location = new System.Drawing.Point(750, 463);
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
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabRegistrar.Controls.Add(this.materialCard2);
            this.tabRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(1086, 544);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnRegistro);
            this.materialCard2.Controls.Add(this.txtPsw);
            this.materialCard2.Controls.Add(this.txtNombre);
            this.materialCard2.Controls.Add(this.txtUsername);
            this.materialCard2.Controls.Add(this.txtApellido);
            this.materialCard2.Controls.Add(this.txtEmail);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(99, 49);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(904, 366);
            this.materialCard2.TabIndex = 23;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistro.AutoSize = false;
            this.btnRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistro.Depth = 0;
            this.btnRegistro.HighEmphasis = true;
            this.btnRegistro.Icon = global::UI.Properties.Resources.Registro;
            this.btnRegistro.Location = new System.Drawing.Point(26, 279);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistro.Size = new System.Drawing.Size(853, 67);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Tag = "btnRegistrarUsuario";
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistro.UseAccentColor = false;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtPsw
            // 
            this.txtPsw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPsw.AnimateReadOnly = false;
            this.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPsw.Depth = 0;
            this.txtPsw.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPsw.Hint = "Contraseña";
            this.txtPsw.LeadingIcon = global::UI.Properties.Resources.Password;
            this.txtPsw.Location = new System.Drawing.Point(456, 184);
            this.txtPsw.MaxLength = 50;
            this.txtPsw.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPsw.Multiline = false;
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(424, 50);
            this.txtPsw.TabIndex = 5;
            this.txtPsw.Tag = "registroContrasena";
            this.txtPsw.Text = "";
            this.txtPsw.TrailingIcon = null;
            this.txtPsw.UseAccent = false;
            this.txtPsw.TextChanged += new System.EventHandler(this.txtPsw_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(26, 14);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(424, 50);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tag = "registroNombre";
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseAccent = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Usuario";
            this.txtUsername.LeadingIcon = global::UI.Properties.Resources.Username;
            this.txtUsername.Location = new System.Drawing.Point(26, 184);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(424, 50);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Tag = "registroUsuario";
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseAccent = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(456, 14);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(424, 50);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Tag = "registroApellido";
            this.txtApellido.Text = "";
            this.txtApellido.TrailingIcon = null;
            this.txtApellido.UseAccent = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = global::UI.Properties.Resources.Correo;
            this.txtEmail.Location = new System.Drawing.Point(26, 102);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(854, 50);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "registroEmail";
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseAccent = false;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // tabSelectorUsuarios
            // 
            this.tabSelectorUsuarios.BaseTabControl = this.tabControlUsuarios;
            this.tabSelectorUsuarios.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorUsuarios.Depth = 0;
            this.tabSelectorUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelectorUsuarios.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tabSelectorUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorUsuarios.Name = "tabSelectorUsuarios";
            this.tabSelectorUsuarios.Size = new System.Drawing.Size(1094, 58);
            this.tabSelectorUsuarios.TabIndex = 14;
            this.tabSelectorUsuarios.Text = "materialTabSelector1";
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.pictureBox1);
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Size = new System.Drawing.Size(1100, 634);
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
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabInicio);
            this.materialTabControl1.Controls.Add(this.tabUsuarios);
            this.materialTabControl1.Controls.Add(this.tabIdiomas);
            this.materialTabControl1.Controls.Add(this.tabPermisos);
            this.materialTabControl1.Controls.Add(this.tabHistorial);
            this.materialTabControl1.Controls.Add(this.tabBitacora);
            this.materialTabControl1.Controls.Add(this.tabCerrar);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1108, 660);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 727);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Home";
            this.Text = "Distribuidora Del Haras";
            this.tabUsuarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControlUsuarios.ResumeLayout(false);
            this.tabListaUsuarios.ResumeLayout(false);
            this.tabRegistrar.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabCerrar;
        private System.Windows.Forms.TabPage tabBitacora;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TabPage tabPermisos;
        private System.Windows.Forms.TabPage tabIdiomas;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl tabControlUsuarios;
        private System.Windows.Forms.TabPage tabListaUsuarios;
        private MaterialSkin.Controls.MaterialListView listaUsuarios;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Contraseña;
        private System.Windows.Forms.ColumnHeader Activo;
        private MaterialSkin.Controls.MaterialButton btnAgregarUsuario;
        private MaterialSkin.Controls.MaterialButton btnModificarUsuario;
        private MaterialSkin.Controls.MaterialButton btnEliminarUsuario;
        private System.Windows.Forms.TabPage tabRegistrar;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnRegistro;
        private MaterialSkin.Controls.MaterialTextBox txtPsw;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorUsuarios;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.ToolTip toolTipUsuarios;
    }
}