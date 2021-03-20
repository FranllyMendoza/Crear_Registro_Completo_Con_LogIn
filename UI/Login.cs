using Crear_Registro_Completo_Con_LogIn.BLL;
using Crear_Registro_Completo_Con_LogIn.DAL;
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

namespace Crear_Registro_Completo_Con_LogIn.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsuariosBLL.ExisteCorreo(CorreoTextBox.Text, ClaveTextBox.Text))
            {
                var ventana = new MainForm();
                ventana.Show();
            }
            else
            {
                LoginErrorProvider.SetError(CorreoTextBox, "El usuario o la contraseña ingresadas son erroneos");
                LoginErrorProvider.SetError(ClaveTextBox, "El usuario o la contraseña ingresadas son erroneos");
                ClaveTextBox.Clear();
            }
        }

    }
}
