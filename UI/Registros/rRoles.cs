using Crear_Registro_Completo_Con_LogIn.BLL;
using Crear_Registro_Completo_Con_LogIn.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crear_Registro_Completo_Con_LogIn.UI
{
    public partial class rRoles : Form
    {
        public List<RolesDetalle> rolDetalle { get; set; } 
        public List<RolesDetalle> detalle { get; set; } 
        public rRoles()
        {
            InitializeComponent();
            this.rolDetalle = new List<RolesDetalle>();
        }

        private void LlenarGrid()
        {
            RolesDataGridView.DataSource = null;
            RolesDataGridView.DataSource = rolDetalle;
        }

        private void AgregarFila()
        {
            RolesDataGridView.DataSource = null;
            RolesDataGridView.DataSource = detalle;
        }

        private void Limpiar()
        {
            RolIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            if(detalle != null)
                detalle.Clear();
            RolesDataGridView.DataSource = null;
        }


       
        private bool Validar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == "")
            {
                RolErrorProvider.SetError(DescripcionTextBox, "Campo obligatorio");
                paso = false;
            }

            return paso;
        }


        private Roles LlenaClase()
        {
            Roles roles = new Roles();
            roles.RolId = (int)RolIdNumericUpDown.Value;
            roles.Descripcion = DescripcionTextBox.Text;
            roles.FechaCreacion = DateTime.Now;
            roles.RolesDetalle = this.rolDetalle;
            roles.esActivo = ActivoCheckBox.Checked;
            LlenarGrid();

            return roles;
        }

        private void LLenaCampos(Roles roles)
        {
            RolIdNumericUpDown.Value = roles.RolId;
            DescripcionTextBox.Text = roles.Descripcion;
            this.rolDetalle = roles.RolesDetalle;
            ActivoCheckBox.Checked = roles.esActivo;
            LlenarGrid();
        }

        

        private void NuevoRolButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

      
        private void BuscarRolButton_Click_1(object sender, EventArgs e)
        {
            var roles = new Roles();
            int id = (int)RolIdNumericUpDown.Value;

            Limpiar();
            roles = RolesBLL.Buscar(id);
            if (roles != null)
            {
                LLenaCampos(roles);
            }
            else
            {
                MessageBox.Show("Rol no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles roles;

            if (!Validar())
                return;
            roles = LlenaClase();

            var paso = RolesBLL.Guardar(roles);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("El rol ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El rol no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //Este es el evento del boton eliminar y sirve para eliminar los datos correspondiente al id ingresado
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)RolIdNumericUpDown.Value;
            RolErrorProvider.Clear();

            if (RolesBLL.Eliminar(id))
            {
                MessageBox.Show("El rol ha sido eliminado", "Logrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                RolErrorProvider.SetError(RolIdNumericUpDown, "Este Id no existe en la base de datos");
        }

        private void AgregarButton_Click_1(object sender, EventArgs e)
        {
            
            if (RolesDataGridView.DataSource != null)
                this.rolDetalle = (List<RolesDetalle>)RolesDataGridView.DataSource;

            this.rolDetalle.Add(
                new RolesDetalle(){
                    RolId = (int)RolIdNumericUpDown.Value,
                    PermisoId = Convert.ToInt32(PermisoIdComboBox.Text),
                    EsAsignado = EsAsignadoCheckBox.Checked
                });

            detalle = rolDetalle;
            AgregarFila();
            EsAsignadoCheckBox.Checked = false;
        }

        //Llenamos el ComboBox de permio ID, usando el metodo GetPermisos
        private void rRoles_Load_1(object sender, EventArgs e)
        {

            PermisoIdComboBox.DataSource = PermisosBLL.GetPermisos();
            PermisoIdComboBox.DisplayMember = "PermisoId";
            PermisoIdComboBox.ValueMember = "PermisoId";
        }

        private void RemoverButton_Click_1(object sender, EventArgs e)
        {
            if (RolesDataGridView.Rows.Count > 0 && RolesDataGridView.CurrentRow != null)
            {
                rolDetalle.RemoveAt(RolesDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }
    }
}
