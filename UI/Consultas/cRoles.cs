using Crear_Registro_Completo_Con_LogIn.BLL;
using Crear_Registro_Completo_Con_LogIn.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crear_Registro_Completo_Con_LogIn.UI.Consultas
{
    public partial class cRoles : Form
    {
        public cRoles()
        {
            InitializeComponent();
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cRoles_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Roles>();
            
            
            if (FiltroActivoCheckBox.Checked)
            {
                
                if (TodosRadioButton.Checked)
                {
                   
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //para RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //para Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => true);
                }
                
                else if (ActivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //para RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && r.esActivo);
                                break;
                            case 1: //para Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text.ToUpper()) && r.esActivo || r.Descripcion.Contains(CriterioTextBox.Text.ToLower()) && r.esActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => r.esActivo);
                }
                
                else if (InactivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //para RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && !r.esActivo);
                                break;
                            case 1: //para Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text.ToUpper()) && !r.esActivo || r.Descripcion.Contains(CriterioTextBox.Text.ToLower()) && !r.esActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => !r.esActivo);
                }
            }
            else
            {
                
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //para RolId
                            lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //para Descripcion
                            lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                    lista = RolesBLL.GetList(r => true);
            }

            
            if (FiltroFechaCheckBox.Checked)
            {
                lista = RolesBLL.GetList(l => l.FechaCreacion >= DesdeDateTimePicker.Value && l.FechaCreacion <= HastaDateTimePicker.Value);
            }

            RolesConsultaDataGridView.DataSource = null;
            RolesConsultaDataGridView.DataSource = lista;
        }

        private void FiltroActivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FiltroActivoCheckBox.Checked)
            {
                esActivoGroupBox.Enabled = true;
            }
            else
            {
                esActivoGroupBox.Enabled = false;
            }
        }
    }
}
