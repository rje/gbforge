using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gbforge2.Data;
using gbforge2.Forms;

namespace gbforge2
{
    public partial class MainView : UserControl
    {
        private BindingSource comboBoxSource;
        public MainView()
        {
            InitializeComponent();
            SetRowStyles();
            BindComboBox();
        }

        void SetRowStyles()
        {
            var styles = this.TilesetTableLayout.RowStyles;
            styles[0].SizeType = SizeType.Absolute;
            styles[0].Height = 100;
        }

        void BindComboBox()
        {
            comboBoxSource = new BindingSource() {DataSource = Model.Instance.Tilesets};
            comboBox1.DataSource = comboBoxSource;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new NewTilesetDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var name = dialog.TilesetName;
                Model.Instance.AddTileset(name);
                comboBoxSource.ResetBindings(false);
            }
        }
    }
}
