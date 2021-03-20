using Crear_Registro_Completo_Con_LogIn.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crear_Registro_Completo_Con_LogIn.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Registros
            this.rolesToolStripMenuItem.Click += new EventHandler(this.rolesToolStripMenuItem_ItemClicked);
            this.UsuariosToolStripMenuItem.Click += new EventHandler(this.UsuariosToolStripMenuItem_ItemClicked);

            //Consultas
            this.ConsultaRolesToolStripMenuItem.Click += new EventHandler(this.ConsultaRolesToolStripMenuItem_ItemClicked);
            this.ConsultaUsuariosToolStripMenuItem.Click += new EventHandler(this.ConsultaUsuariosToolStripMenuItem_ItemClicked);
        }

        private void ConsultaUsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Usuarios = new cUsuarios();
            Usuarios.MdiParent = this;
            Usuarios.Show();
        }

        private void UsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Usuarios = new rUsuarios();
            Usuarios.MdiParent = this;
            Usuarios.Show();
        }

        private void ConsultaRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new cRoles();
            Roles.MdiParent = this;
            Roles.Show();
        }

        private void rolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new rRoles();
            Roles.MdiParent = this;
            Roles.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
