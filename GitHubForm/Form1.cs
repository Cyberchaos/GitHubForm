using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubForm
{
    public partial class Form1 : Form
    {

        string[,] map;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSux_Click(object sender, EventArgs e)
        {
            map = new string[10, 10];
            initialiseMap();
            redraw();

        }

        private void initialiseMap()
        {
            Random r = new Random();

            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    map[k, j] = " " + Convert.ToChar(r.Next(66, 91)) + " ";
                }
            }
        }

        private void redraw()
        {
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    lblMap.Text += map[k, j];
                }
                lblMap.Text += "\n";
            }
        }
    }
}
