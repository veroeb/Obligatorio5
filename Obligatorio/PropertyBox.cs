using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio
{
    public partial class PropertyBox : UserControl
    {
        public PropertyBox()
        {
            InitializeComponent();

            var pos = PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            //label1.Location = pos;
            label1.BackColor = Color.Transparent;

            var pos1 = PointToScreen(label6.Location);
            pos = pictureBox2.PointToClient(pos);
            label6.Parent = pictureBox2;
            label6.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
