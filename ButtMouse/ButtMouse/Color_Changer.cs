using System;
using System.Drawing;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class Color_Changer : Form
    {
        public Color_Changer()
        {
            InitializeComponent();
            NewColor();
        }

        private void NewColor()
        {
            ColorPanel.BackColor = Color.FromArgb(tb_red.Value, tb_green.Value, tb_blue.Value);
            Clipboard.Clear();
            Clipboard.SetText($"#{tb_red.Value:X}{tb_green.Value:X}{tb_blue.Value:X}");
            toolTip.SetToolTip(ColorPanel, Clipboard.GetText());
        }

        private void color_scroll(object sender, EventArgs e)
        {
            NewColor();
        }

    }

}
