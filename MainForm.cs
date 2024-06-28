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
    public partial class MainForm : Form
    {
        //当前默认语言
        public static string Language_chinease = "zh-CN";
        public static string Language_english = "en-US";
        public static string DefaultLanguage = Language_chinease;

        private NewWindow newWindow = new NewWindow();
        public MainForm()
        {
            InitializeComponent();

            DefaultLanguage = Properties.Settings.Default.DefaultLanguage;
            SetMultiLang.SetLanguage(DefaultLanguage);
        }

        private void button_zh_Click(object sender, EventArgs e)
        {
            SetMultiLang.SetLanguage(Language_chinease);
        }

        private void button_en_Click(object sender, EventArgs e)
        {
            SetMultiLang.SetLanguage(Language_english);
        }


        private void newForm_Click(object sender, EventArgs e)
        {
            newWindow.Show();
            newWindow.TopMost = true;//始终位于屏幕顶层
        }

        private void button_showMsg_Click(object sender, EventArgs e)
        {
            try
            {
                string res = SetMultiLang.getResource(this, "showMsgText");
                MessageBox.Show("res: " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
