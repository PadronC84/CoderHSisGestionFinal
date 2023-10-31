using SistemaGestionBusiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string NombreUsuario;
            string Contraseña;
            // UsuarioBusiness.Login(NombreUsuario,Contraseña);

            NombreUsuario = txtlabelUsuario.Text;
            Contraseña = txtlabelContraseña.Text;
            bool logueado = UsuarioBusiness.Login(NombreUsuario, Contraseña);
            // return logueado;

            if (logueado == true)
            {
                Form formulario = new Menu_principal();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void txtlabelUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
