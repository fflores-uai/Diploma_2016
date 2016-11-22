namespace Presentacion.UI.Areas
{
    partial class Home
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
            DevComponents.DotNetBar.Metro.MetroTileFrame metroTileFrame1;
            this.mtpMenu = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.btnTickets = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            metroTileFrame1 = new DevComponents.DotNetBar.Metro.MetroTileFrame();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtpMenu
            // 
            this.mtpMenu.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.mtpMenu.BackgroundStyle.Class = "MetroTilePanel";
            this.mtpMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtpMenu.ContainerControlProcessDialogKey = true;
            this.mtpMenu.DragDropSupport = true;
            this.mtpMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.mtpMenu.Location = new System.Drawing.Point(12, 82);
            this.mtpMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtpMenu.Name = "mtpMenu";
            this.mtpMenu.Size = new System.Drawing.Size(984, 467);
            this.mtpMenu.TabIndex = 0;
            this.mtpMenu.Text = "Menu";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTickets,
            this.metroTileItem1});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTilePanel";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleStyle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer1.TitleStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far;
            this.itemContainer1.TitleText = "Menu";
            this.itemContainer1.TitleVisible = false;
            // 
            // btnTickets
            // 
            this.btnTickets.AutoRotateFramesInterval = 900;
            this.btnTickets.Frames.Add(metroTileFrame1);
            this.btnTickets.Image = global::Presentacion.UI.Properties.Resources.monitor50x50;
            this.btnTickets.ImageIndent = new System.Drawing.Point(10, 10);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.SymbolColor = System.Drawing.Color.Empty;
            this.btnTickets.Text = "Gestion de Tickets";
            this.btnTickets.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.btnTickets.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnTickets.TitleText = "Tickets";
            this.btnTickets.TitleTextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Image = global::Presentacion.UI.Properties.Resources.bookW50x50;
            this.metroTileItem1.ImageIndent = new System.Drawing.Point(10, 10);
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.Text = "Gestion de Clientes";
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TitleText = "Clientes";
            this.metroTileItem1.TitleTextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem3.TitleText = " Inicio";
            this.metroTileItem3.TitleTextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem4.TitleText = " Inicio";
            this.metroTileItem4.TitleTextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileFrame1
            // 
            metroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            metroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.Black;
            this.TitlePanel.BackgroundImage = global::Presentacion.UI.Properties.Resources.BotonBlack;
            this.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitlePanel.Controls.Add(this.buttonX1);
            this.TitlePanel.Controls.Add(this.labelX1);
            this.TitlePanel.ForeColor = System.Drawing.Color.Transparent;
            this.TitlePanel.Location = new System.Drawing.Point(-1, -1);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1010, 76);
            this.TitlePanel.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(13, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(550, 69);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Menu Principal";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX1.HoverImage = global::Presentacion.UI.Properties.Resources.exit35x35;
            this.buttonX1.Image = global::Presentacion.UI.Properties.Resources.bookW50x50;
            this.buttonX1.Location = new System.Drawing.Point(947, 13);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(50, 50);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.buttonX1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.mtpMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.TitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel mtpMenu;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnTickets;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private System.Windows.Forms.Panel TitlePanel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}