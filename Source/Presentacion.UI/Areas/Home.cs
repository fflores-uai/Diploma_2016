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
        }

        private void Traducir()
        {
            btnTickets.Text = string.Format(TITLETEMPLATE, GetName(this.btnTickets.Name));
            btnTickets.TitleText = this.btnTickets.Name;
            btnTickets.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
        }

        public string GetName(string value)
        {
            return value + "Title";
        }
    }
}