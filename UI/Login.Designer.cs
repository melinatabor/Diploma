namespace UI
{
    partial class Login
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputPsw = new MaterialSkin.Controls.MaterialTextBox2();
            this.inputUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrar.AutoSize = false;
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.HighEmphasis = true;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(400, 335);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(174, 50);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.DistribuidoraLogo;
            this.pictureBox1.Location = new System.Drawing.Point(322, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.AutoSize = false;
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = global::UI.Properties.Resources.Username;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(206, 335);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(177, 50);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.inputPsw);
            this.panel1.Controls.Add(this.inputUsuario);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(60, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 439);
            this.panel1.TabIndex = 9;
            // 
            // inputPsw
            // 
            this.inputPsw.AnimateReadOnly = false;
            this.inputPsw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inputPsw.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputPsw.Depth = 0;
            this.inputPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputPsw.HideSelection = true;
            this.inputPsw.Hint = "Contraseña";
            this.inputPsw.LeadingIcon = global::UI.Properties.Resources.Password;
            this.inputPsw.Location = new System.Drawing.Point(206, 260);
            this.inputPsw.MaxLength = 32767;
            this.inputPsw.MouseState = MaterialSkin.MouseState.OUT;
            this.inputPsw.Name = "inputPsw";
            this.inputPsw.PasswordChar = '●';
            this.inputPsw.PrefixSuffixText = null;
            this.inputPsw.ReadOnly = false;
            this.inputPsw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputPsw.SelectedText = "";
            this.inputPsw.SelectionLength = 0;
            this.inputPsw.SelectionStart = 0;
            this.inputPsw.ShortcutsEnabled = true;
            this.inputPsw.Size = new System.Drawing.Size(368, 48);
            this.inputPsw.TabIndex = 2;
            this.inputPsw.TabStop = false;
            this.inputPsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputPsw.TrailingIcon = null;
            this.inputPsw.UseAccent = false;
            this.inputPsw.UseSystemPasswordChar = true;
            // 
            // inputUsuario
            // 
            this.inputUsuario.AnimateReadOnly = false;
            this.inputUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inputUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputUsuario.Depth = 0;
            this.inputUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputUsuario.HideSelection = false;
            this.inputUsuario.Hint = "Usuario";
            this.inputUsuario.LeadingIcon = global::UI.Properties.Resources.Username;
            this.inputUsuario.Location = new System.Drawing.Point(206, 182);
            this.inputUsuario.MaxLength = 32767;
            this.inputUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.PasswordChar = '\0';
            this.inputUsuario.PrefixSuffixText = null;
            this.inputUsuario.ReadOnly = false;
            this.inputUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputUsuario.SelectedText = "";
            this.inputUsuario.SelectionLength = 0;
            this.inputUsuario.SelectionStart = 0;
            this.inputUsuario.ShortcutsEnabled = true;
            this.inputUsuario.Size = new System.Drawing.Size(368, 48);
            this.inputUsuario.TabIndex = 1;
            this.inputUsuario.TabStop = false;
            this.inputUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputUsuario.TrailingIcon = null;
            this.inputUsuario.UseAccent = false;
            this.inputUsuario.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 439);
            this.panel2.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox2 inputUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 inputPsw;
    }
}