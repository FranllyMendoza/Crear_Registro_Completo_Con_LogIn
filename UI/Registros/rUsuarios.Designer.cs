
namespace Crear_Registro_Completo_Con_LogIn
{
    partial class rUsuarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rUsuarios));
            this.usuariosIdLabel = new System.Windows.Forms.Label();
            this.Aliaslabel = new System.Windows.Forms.Label();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.ConfirmarLabel = new System.Windows.Forms.Label();
            this.RolLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.confirmarTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.UsuarioErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.UsuarioIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosIdLabel
            // 
            this.usuariosIdLabel.AutoSize = true;
            this.usuariosIdLabel.Location = new System.Drawing.Point(19, 34);
            this.usuariosIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuariosIdLabel.Name = "usuariosIdLabel";
            this.usuariosIdLabel.Size = new System.Drawing.Size(30, 25);
            this.usuariosIdLabel.TabIndex = 0;
            this.usuariosIdLabel.Text = "ID";
            // 
            // Aliaslabel
            // 
            this.Aliaslabel.AutoSize = true;
            this.Aliaslabel.Location = new System.Drawing.Point(19, 90);
            this.Aliaslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aliaslabel.Name = "Aliaslabel";
            this.Aliaslabel.Size = new System.Drawing.Size(49, 25);
            this.Aliaslabel.TabIndex = 1;
            this.Aliaslabel.Text = "Alias";
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Location = new System.Drawing.Point(19, 146);
            this.NombresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(86, 25);
            this.NombresLabel.TabIndex = 2;
            this.NombresLabel.Text = "Nombres";
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(19, 262);
            this.ClaveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(54, 25);
            this.ClaveLabel.TabIndex = 3;
            this.ClaveLabel.Text = "Clave";
            this.ClaveLabel.Click += new System.EventHandler(this.ClaveLabel_Click);
            // 
            // ConfirmarLabel
            // 
            this.ConfirmarLabel.AutoSize = true;
            this.ConfirmarLabel.Location = new System.Drawing.Point(342, 259);
            this.ConfirmarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmarLabel.Name = "ConfirmarLabel";
            this.ConfirmarLabel.Size = new System.Drawing.Size(138, 25);
            this.ConfirmarLabel.TabIndex = 4;
            this.ConfirmarLabel.Text = "Confirmar Clave";
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.Location = new System.Drawing.Point(365, 31);
            this.RolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(37, 25);
            this.RolLabel.TabIndex = 5;
            this.RolLabel.Text = "Rol";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(19, 206);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 25);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(114, 203);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(568, 31);
            this.emailTextBox.TabIndex = 8;
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.Location = new System.Drawing.Point(114, 86);
            this.aliasTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(568, 31);
            this.aliasTextBox.TabIndex = 10;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(114, 142);
            this.nombresTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(568, 31);
            this.nombresTextBox.TabIndex = 11;
            // 
            // confirmarTextBox
            // 
            this.confirmarTextBox.Location = new System.Drawing.Point(507, 256);
            this.confirmarTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmarTextBox.Name = "confirmarTextBox";
            this.confirmarTextBox.PasswordChar = '*';
            this.confirmarTextBox.Size = new System.Drawing.Size(175, 31);
            this.confirmarTextBox.TabIndex = 12;
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(114, 259);
            this.claveTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(188, 31);
            this.claveTextBox.TabIndex = 13;
            // 
            // RolComboBox
            // 
            this.RolComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "administrador"});
            this.RolComboBox.Location = new System.Drawing.Point(410, 29);
            this.RolComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(176, 33);
            this.RolComboBox.TabIndex = 15;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(86, 315);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(112, 66);
            this.NuevoButton.TabIndex = 16;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(271, 315);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(112, 66);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(474, 315);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(112, 66);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(309, 29);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(44, 34);
            this.BuscarButton.TabIndex = 19;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // UsuarioErrorProvider
            // 
            this.UsuarioErrorProvider.ContainerControl = this;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.AutoSize = true;
            this.activoCheckBox.Location = new System.Drawing.Point(594, 34);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(88, 29);
            this.activoCheckBox.TabIndex = 20;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsuarioIdNumericUpDown
            // 
            this.UsuarioIdNumericUpDown.Location = new System.Drawing.Point(114, 30);
            this.UsuarioIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsuarioIdNumericUpDown.Name = "UsuarioIdNumericUpDown";
            this.UsuarioIdNumericUpDown.Size = new System.Drawing.Size(188, 31);
            this.UsuarioIdNumericUpDown.TabIndex = 21;
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 414);
            this.Controls.Add(this.UsuarioIdNumericUpDown);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.confirmarTextBox);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.ConfirmarLabel);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.Aliaslabel);
            this.Controls.Add(this.usuariosIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "rUsuarios";
            this.Text = "Registro de usuarios";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuariosIdLabel;
        private System.Windows.Forms.Label Aliaslabel;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.Label ConfirmarLabel;
        private System.Windows.Forms.Label RolLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox confirmarTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider UsuarioErrorProvider;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.NumericUpDown UsuarioIdNumericUpDown;
    }
}

