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
    public partial class cUsuarios : Form
    {
        List<Usuarios> lista = new List<Usuarios>();
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
                        
            
            if(FiltroActivoCheckBox.Checked)
            {
                if (TodosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //para UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //para Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text.ToUpper()) || r.Alias.Contains(CriterioTextBox.Text.ToLower()));
                                break;
                            case 2: //para Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) || r.Nombres.Contains(CriterioTextBox.Text.ToLower()));
                                break;
                            case 3: //para Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text.ToUpper()) || r.Email.Contains(CriterioTextBox.Text.ToLower()));
                                break;
                            case 4: //para RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = UsuariosBLL.GetList(r => true);
                }
                else if (ActivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //para UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 1: //para Alias
                                lista = UsuariosBLL.GetList(r => (r.Alias.Contains(CriterioTextBox.Text.ToUpper()) && r.Activo) || (r.Alias.Contains(CriterioTextBox.Text.ToLower()) && r.Activo));
                                break;
                            case 2: //para Nombres
                                lista = UsuariosBLL.GetList(r => (r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) && r.Activo) || (r.Nombres.Contains(CriterioTextBox.Text.ToLower()) && r.Activo));
                                break;
                            case 3: //para Email
                                lista = UsuariosBLL.GetList(r => (r.Email.Contains(CriterioTextBox.Text.ToUpper()) && r.Activo) || (r.Email.Contains(CriterioTextBox.Text.ToLower()) && r.Activo));
                                break;
                            case 4: //para RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = UsuariosBLL.GetList(r => true && r.Activo);
                }
                else if (InactivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //para UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 1: //para Alias
                                lista = UsuariosBLL.GetList(r => (r.Alias.Contains(CriterioTextBox.Text.ToUpper()) && !r.Activo) || (r.Alias.Contains(CriterioTextBox.Text.ToLower()) && !r.Activo));
                                break;
                            case 2: //para Nombres
                                lista = UsuariosBLL.GetList(r => (r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) && !r.Activo) || (r.Nombres.Contains(CriterioTextBox.Text.ToLower()) && !r.Activo));
                                break;
                            case 3: //para Email
                                lista = UsuariosBLL.GetList(r => (r.Email.Contains(CriterioTextBox.Text.ToUpper()) && !r.Activo) || (r.Email.Contains(CriterioTextBox.Text.ToLower()) && !r.Activo));
                                break;
                            case 4: //para RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = UsuariosBLL.GetList(r => true && !r.Activo);
                }
            }
            else
            {
                
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //para UsuarioId
                            lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //para Alias
                            lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text.ToUpper()) || r.Alias.Contains(CriterioTextBox.Text.ToLower()));
                            break;
                        case 2: //para Nombres
                            lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) || r.Nombres.Contains(CriterioTextBox.Text.ToLower()));
                            break;
                        case 3: //para Email
                            lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text.ToUpper()) || r.Email.Contains(CriterioTextBox.Text.ToLower()));
                            break;
                        case 4: //para RolId
                            lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    lista = UsuariosBLL.GetList(r => true);
                }
            }


           
            if (FiltroFechaCheckBox.Checked)
            {
                lista = UsuariosBLL.GetList(l => l.FechaIngreso >= DesdeDateTimePicker.Value && l.FechaIngreso <= HastaDateTimePicker.Value);
            }


            UsuariosConsultaDataGridView.DataSource = null;
            UsuariosConsultaDataGridView.DataSource = lista;
        }

        private void cUsuarios_Load(object sender, EventArgs e)
        {
            
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

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("No hay datos a imprimir");
                return;
            }
            
            
        }
    }
}
