using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubExperiment
{
    public partial class ButtonGame : Form
    {
        public ButtonGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMessage(button1.Text);
        }   
     public void ShowMessage(string message)
        {
        MessageBox.Show(message);
        }    
    }
}

       
