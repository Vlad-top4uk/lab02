using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Kosenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 16);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 16);
            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 16);
            textBox_C.Text = strC;
            string strP2 = textBox_P2.Text;
            int intP2 = Convert.ToInt32(strP2, 2);
            string strKey2 = textBox_Key2.Text;
            int intKey2 = Convert.ToInt32(strKey2, 16);
            int intC2 = intP2 ^ intKey2;
            string strC2 = Convert.ToString(intC2, 16);
            textBox_C2.Text = strC2;
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "" ;
            textBox_Key.Text = "";
            textBox_C.Text = "";
            textBox_P2.Text = "";
            textBox_Key2.Text = "";
            textBox_C2.Text = "";
        }

        private void textBox_P_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
