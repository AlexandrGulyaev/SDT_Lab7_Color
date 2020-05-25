using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gulyaev_AG_7_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            uint color = Convert.ToUInt32(trackBarRed.Value<<16) + Convert.ToUInt32(trackBarGreen.Value<<8) + Convert.ToUInt32(trackBarBlue.Value);
            string col = "#" + Convert.ToString(color,16);
            Clipboard.SetText(col);
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            trackBar_Scroll(sender, e);
            ToolTip t = new ToolTip();
            t.SetToolTip(panel1, Clipboard.GetText());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar_Scroll(sender, e);
        }
    }
}
