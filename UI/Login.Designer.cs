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
            this.inputUsuario = new MetroFramework.Controls.MetroTextBox();
            this.inputPsw = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // inputUsuario
            // 
            this.inputUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.inputUsuario.CustomButton.Image = null;
            this.inputUsuario.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.inputUsuario.CustomButton.Name = "";
            this.inputUsuario.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.inputUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputUsuario.CustomButton.TabIndex = 1;
            this.inputUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputUsuario.CustomButton.UseSelectable = true;
            this.inputUsuario.CustomButton.Visible = false;
            this.inputUsuario.DisplayIcon = true;
            this.inputUsuario.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.inputUsuario.Icon = global::UI.Properties.Resources.Username;
            this.inputUsuario.Lines = new string[0];
            this.inputUsuario.Location = new System.Drawing.Point(88, 178);
            this.inputUsuario.MaxLength = 32767;
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.PasswordChar = '\0';
            this.inputUsuario.PromptText = "Username";
            this.inputUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputUsuario.SelectedText = "";
            this.inputUsuario.SelectionLength = 0;
            this.inputUsuario.SelectionStart = 0;
            this.inputUsuario.ShortcutsEnabled = true;
            this.inputUsuario.Size = new System.Drawing.Size(252, 35);
            this.inputUsuario.TabIndex = 0;
            this.inputUsuario.UseSelectable = true;
            this.inputUsuario.WaterMark = "Username";
            this.inputUsuario.WaterMarkColor = System.Drawing.Color.Gray;
            this.inputUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // inputPsw
            // 
            this.inputPsw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.inputPsw.CustomButton.Image = null;
            this.inputPsw.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.inputPsw.CustomButton.Name = "";
            this.inputPsw.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.inputPsw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputPsw.CustomButton.TabIndex = 1;
            this.inputPsw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputPsw.CustomButton.UseSelectable = true;
            this.inputPsw.CustomButton.Visible = false;
            this.inputPsw.DisplayIcon = true;
            this.inputPsw.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.inputPsw.Icon = global::UI.Properties.Resources.Password;
            this.inputPsw.Lines = new string[0];
            this.inputPsw.Location = new System.Drawing.Point(88, 228);
            this.inputPsw.MaxLength = 32767;
            this.inputPsw.Name = "inputPsw";
            this.inputPsw.PasswordChar = '*';
            this.inputPsw.PromptText = "Password";
            this.inputPsw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputPsw.SelectedText = "";
            this.inputPsw.SelectionLength = 0;
            this.inputPsw.SelectionStart = 0;
            this.inputPsw.ShortcutsEnabled = true;
            this.inputPsw.Size = new System.Drawing.Size(252, 35);
            this.inputPsw.TabIndex = 1;
            this.inputPsw.UseSelectable = true;
            this.inputPsw.WaterMark = "Password";
            this.inputPsw.WaterMarkColor = System.Drawing.Color.Gray;
            this.inputPsw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroPanel3.BackgroundImage = global::UI.Properties.Resources.Login;
            this.metroPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(160, 30);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(107, 103);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
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
            this.btnIngresar.Location = new System.Drawing.Point(86, 288);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(127, 72);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
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
            this.btnRegistrar.Location = new System.Drawing.Point(221, 288);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(119, 72);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = true;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 469);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.inputPsw);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.inputUsuario);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox inputPsw;
        private MetroFramework.Controls.MetroTextBox inputUsuario;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
    }
}