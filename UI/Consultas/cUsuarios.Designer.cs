
namespace Crear_Registro_Completo_Con_LogIn.UI.Consultas
{
    partial class cUsuarios
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
            this.FechaGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.esActivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivosRadioButton = new System.Windows.Forms.RadioButton();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.UsuariosConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltroActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaGroupBox.SuspendLayout();
            this.esActivoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaGroupBox
            // 
            this.FechaGroupBox.Controls.Add(this.HastaLabel);
            this.FechaGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeLabel);
            this.FechaGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FechaGroupBox.Location = new System.Drawing.Point(224, 14);
            this.FechaGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FechaGroupBox.Name = "FechaGroupBox";
            this.FechaGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FechaGroupBox.Size = new System.Drawing.Size(522, 62);
            this.FechaGroupBox.TabIndex = 16;
            this.FechaGroupBox.TabStop = false;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(288, 25);
            this.HastaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(57, 25);
            this.HastaLabel.TabIndex = 3;
            this.HastaLabel.Text = "Hasta";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(359, 21);
            this.HastaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(155, 31);
            this.HastaDateTimePicker.TabIndex = 2;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(79, 21);
            this.DesdeDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(155, 31);
            this.DesdeDateTimePicker.TabIndex = 1;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Location = new System.Drawing.Point(8, 25);
            this.DesdeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(62, 25);
            this.DesdeLabel.TabIndex = 0;
            this.DesdeLabel.Text = "Desde";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Usuario Id",
            "Alias",
            "Nombres",
            "Email",
            "RolId"});
            this.FiltroComboBox.Location = new System.Drawing.Point(76, 85);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(146, 33);
            this.FiltroComboBox.TabIndex = 11;
            // 
            // FiltroFechaCheckBox
            // 
            this.FiltroFechaCheckBox.AutoSize = true;
            this.FiltroFechaCheckBox.Location = new System.Drawing.Point(15, 15);
            this.FiltroFechaCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FiltroFechaCheckBox.Name = "FiltroFechaCheckBox";
            this.FiltroFechaCheckBox.Size = new System.Drawing.Size(201, 29);
            this.FiltroFechaCheckBox.TabIndex = 10;
            this.FiltroFechaCheckBox.Text = "Usar Filtro de Fechas";
            this.FiltroFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtro";
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Checked = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(8, 32);
            this.TodosRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(85, 29);
            this.TodosRadioButton.TabIndex = 0;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.Text = "Todos";
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            // 
            // esActivoGroupBox
            // 
            this.esActivoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.esActivoGroupBox.Controls.Add(this.InactivosRadioButton);
            this.esActivoGroupBox.Controls.Add(this.ActivosRadioButton);
            this.esActivoGroupBox.Controls.Add(this.TodosRadioButton);
            this.esActivoGroupBox.Enabled = false;
            this.esActivoGroupBox.Location = new System.Drawing.Point(765, 15);
            this.esActivoGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.esActivoGroupBox.Name = "esActivoGroupBox";
            this.esActivoGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.esActivoGroupBox.Size = new System.Drawing.Size(155, 121);
            this.esActivoGroupBox.TabIndex = 15;
            this.esActivoGroupBox.TabStop = false;
            this.esActivoGroupBox.Text = "esActivo?";
            // 
            // InactivosRadioButton
            // 
            this.InactivosRadioButton.AutoSize = true;
            this.InactivosRadioButton.Location = new System.Drawing.Point(8, 91);
            this.InactivosRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InactivosRadioButton.Name = "InactivosRadioButton";
            this.InactivosRadioButton.Size = new System.Drawing.Size(107, 29);
            this.InactivosRadioButton.TabIndex = 2;
            this.InactivosRadioButton.Text = "Inactivos";
            this.InactivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivosRadioButton
            // 
            this.ActivosRadioButton.AutoSize = true;
            this.ActivosRadioButton.Location = new System.Drawing.Point(8, 62);
            this.ActivosRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActivosRadioButton.Name = "ActivosRadioButton";
            this.ActivosRadioButton.Size = new System.Drawing.Size(95, 29);
            this.ActivosRadioButton.TabIndex = 1;
            this.ActivosRadioButton.Text = "Activos";
            this.ActivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(232, 83);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(522, 31);
            this.CriterioTextBox.TabIndex = 17;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButton.Image = global::Crear_Registro_Completo_Con_LogIn.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.BuscarButton.Location = new System.Drawing.Point(928, 31);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(125, 108);
            this.BuscarButton.TabIndex = 14;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImprimirButton.Location = new System.Drawing.Point(15, 449);
            this.ImprimirButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(144, 55);
            this.ImprimirButton.TabIndex = 13;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // UsuariosConsultaDataGridView
            // 
            this.UsuariosConsultaDataGridView.AllowUserToAddRows = false;
            this.UsuariosConsultaDataGridView.AllowUserToDeleteRows = false;
            this.UsuariosConsultaDataGridView.AllowUserToOrderColumns = true;
            this.UsuariosConsultaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosConsultaDataGridView.Location = new System.Drawing.Point(15, 146);
            this.UsuariosConsultaDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsuariosConsultaDataGridView.Name = "UsuariosConsultaDataGridView";
            this.UsuariosConsultaDataGridView.ReadOnly = true;
            this.UsuariosConsultaDataGridView.RowHeadersWidth = 51;
            this.UsuariosConsultaDataGridView.RowTemplate.Height = 29;
            this.UsuariosConsultaDataGridView.Size = new System.Drawing.Size(1038, 294);
            this.UsuariosConsultaDataGridView.TabIndex = 12;
            // 
            // FiltroActivoCheckBox
            // 
            this.FiltroActivoCheckBox.AutoSize = true;
            this.FiltroActivoCheckBox.Location = new System.Drawing.Point(15, 49);
            this.FiltroActivoCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FiltroActivoCheckBox.Name = "FiltroActivoCheckBox";
            this.FiltroActivoCheckBox.Size = new System.Drawing.Size(192, 29);
            this.FiltroActivoCheckBox.TabIndex = 18;
            this.FiltroActivoCheckBox.Text = "Usar Filtro es activo";
            this.FiltroActivoCheckBox.UseVisualStyleBackColor = true;
            this.FiltroActivoCheckBox.CheckedChanged += new System.EventHandler(this.FiltroActivoCheckBox_CheckedChanged);
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 519);
            this.Controls.Add(this.FiltroActivoCheckBox);
            this.Controls.Add(this.FechaGroupBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroFechaCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esActivoGroupBox);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.UsuariosConsultaDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cUsuarios";
            this.Text = "Consulta de Usuarios";
            this.Load += new System.EventHandler(this.cUsuarios_Load);
            this.FechaGroupBox.ResumeLayout(false);
            this.FechaGroupBox.PerformLayout();
            this.esActivoGroupBox.ResumeLayout(false);
            this.esActivoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FechaGroupBox;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.CheckBox FiltroFechaCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.GroupBox esActivoGroupBox;
        private System.Windows.Forms.RadioButton InactivosRadioButton;
        private System.Windows.Forms.RadioButton ActivosRadioButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.DataGridView UsuariosConsultaDataGridView;
        private System.Windows.Forms.CheckBox FiltroActivoCheckBox;
    }
}