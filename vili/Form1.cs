using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;      // NIGGGGSSSSSA AAAAA
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string utvonal = "";
        public Dictionary<char, string> szotar = new Dictionary<char, string>();

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream folyam = new FileStream("morzeabc.txt", FileMode.Open);
            StreamReader olvas = new StreamReader(folyam);
            // (3 dolgot csinál) Constructor: lefoglalja a memoriat, castolja, kitolti kezdoerteket ad a valtozoknak
            string elso = olvas.ReadLine();
            string[] resz;


            while (!olvas.EndOfStream)
            {
                resz = elso.Split(';');
                if (!szotar.ContainsKey(Convert.ToChar(resz[0])))
                {
                    szotar.Add((Convert.ToChar(resz[0])), resz[1]);
                }
                elso = olvas.ReadLine();
            }

            
            /* binaris váltás
            int szam = Convert.ToInt32(textBox1.Text);
            string kesz = "";
            int szamrendszer = 2;
            while (szam > 0)
            {
                kesz += szam % szamrendszer;
                szam = szam / szamrendszer;
            }

            char[] stringArray = kesz.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);

            label1.Text = reversedStr + ", " + kesz;
            */

            /*
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                utvonal = openFileDialog1.FileName;
            }
            */

        }
    }
}
