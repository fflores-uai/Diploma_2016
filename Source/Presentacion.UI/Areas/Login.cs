using System;
using System.Drawing;

namespace Presentacion.UI.Areas
{
    public partial class Login : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Home formHome;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ApplyStyle();
        }

        private void btnCacelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            formHome = new Home();
            formHome.Show();
        }

        private void ApplyStyle()
        {
            lblUsuarioNombre.ForeColor = Color.White;
            lblUsuarioClave.ForeColor = Color.White;
            

        }
    }
}