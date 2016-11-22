using Servicios.Idioma;
using System.Drawing;

namespace Presentacion.UI.Areas
{
    public partial class Home : DevComponents.DotNetBar.Metro.MetroForm
    {
        private const string TITLETEMPLATE = "<div width=\"150px\" padding=\"10,0,10,0\"><font size=\"12\">{0}</font></div>";

        public Home()
        {
            InitializeComponent();
            mtpMenu.Refresh();
            Traducir();
            ApplyStyle();

        }

        private void ApplyStyle()
        {
            TitlePanel.BackColor = Color.AliceBlue;
            
        }

        private void Traducir()
        {
            btnTickets.Text = string.Format(TITLETEMPLATE, this.btnTickets.Name.AsTitle().Traducir());
            btnTickets.TitleText = this.btnTickets.Name.Traducir();
            btnTickets.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;

            
            //var a = "hola".GetValue();
        }

    }
}