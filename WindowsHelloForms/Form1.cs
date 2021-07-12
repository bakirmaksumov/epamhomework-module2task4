using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace WindowsHelloForms
{
    public partial class AppMainForm : Form
    { 
        public AppMainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputTxt=txtMain.Text;
            var lib = new OutputInfo();
            MessageBox.Show(lib.inputInfo(inputTxt));
            
        }
    }
}
