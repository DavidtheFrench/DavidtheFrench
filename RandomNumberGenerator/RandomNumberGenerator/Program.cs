using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomNumberGenerator;

namespace RandomNumberGenerator
{
    public partial class RandomNumberGenerator : Form
    {
        public RandomNumberGenerator()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void numberGenerator_Click(object sender, EventArgs e)
        {
            int numberGenerator = r.Next(100);
            numberLabel.Text = numberGenerator.ToString();
        }
    }
}
