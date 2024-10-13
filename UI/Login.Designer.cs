namespace UI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPsw = new MaterialSkin.Controls.MaterialTextBox();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.btnRegistrarse = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialDivider1.Location = new System.Drawing.Point(3, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(456, 828);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnRegistrarse);
            this.materialCard1.Controls.Add(this.btnIngresar);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.txtPsw);
            this.materialCard1.Controls.Add(this.txtUsuario);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(459, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(831, 828);
            this.materialCard1.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(229, 376);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(394, 50);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // txtPsw
            // 
            this.txtPsw.AnimateReadOnly = false;
            this.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPsw.Depth = 0;
            this.txtPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPsw.Hint = "Contraseña";
            this.txtPsw.LeadingIcon = null;
            this.txtPsw.Location = new System.Drawing.Point(229, 463);
            this.txtPsw.MaxLength = 50;
            this.txtPsw.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPsw.Multiline = false;
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(394, 50);
            this.txtPsw.TabIndex = 1;
            this.txtPsw.Text = "";
            this.txtPsw.TrailingIcon = null;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = false;
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(229, 561);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(194, 57);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.AutoSize = false;
            this.btnRegistrarse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarse.Depth = 0;
            this.btnRegistrarse.HighEmphasis = true;
            this.btnRegistrarse.Icon = null;
            this.btnRegistrarse.Location = new System.Drawing.Point(445, 561);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarse.Size = new System.Drawing.Size(178, 57);
            this.btnRegistrarse.TabIndex = 3;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRegistrarse.UseAccentColor = false;
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1293, 831);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialDivider1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora del Haras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialTextBox txtPsw;
        private MaterialSkin.Controls.MaterialButton btnRegistrarse;
    }
}

