using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_Multilanguage
{
    public partial class NewWindow : Form
    {
        public NewWindow()
        {
            InitializeComponent();
        }

        private void button_showMsg_Click(object sender, EventArgs e)
        {
            try
            {
                string res = SetMultiLang.getResource(this, "newMsg");
                MessageBox.Show("res: " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
