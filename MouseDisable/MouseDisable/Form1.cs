using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseDisable
{
    public partial class MouseDisable : Form
    {
        public MouseDisable()
        {
            InitializeComponent();
            timer1.Start();
        }
        Point dPosition;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dPosition.X = 0;
            dPosition.Y = 0;
            Cursor.Position = dPosition;
        }
    }
}
