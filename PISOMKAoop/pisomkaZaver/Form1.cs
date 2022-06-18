using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisomkaZaver
{
    public partial class Form1 : Form
    {
        List<Classa> supiska = new List<Classa>
        {
            new Classa("ko", "nina", "4ag", "photoshop"),
            new Classa("ko", "tana", "4ag", "powerpoint"),
            new Classa("re", "lara", "4at", "unity"),
            new Classa("pi", "kaja", "4ai", "fusion360"),
            new Classa("pa", "sara", "4bi", "cisco")
        };

        List<TextBox> filterBoxy;

        public Form1()
        {
            InitializeComponent();
            filterBoxy = new List<TextBox>{textBox1, textBox2, textBox3, textBox4};
            vypis();
        }

        private void vypis()
        {
            richTextBox1.Clear();
            foreach (var item in supiska)
            {
                if (fiterCheck(item))
                {
                    richTextBox1.AppendText(item.Ucitel + "  " + item.Meno + "  " + item.Tieda + "  " + item.Projekt + "\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vypis();
        }
        private bool fiterCheck(Classa item)
        {
            string[] itemy = { item.Ucitel, item.Meno, item.Tieda, item.Projekt};
            for (int i = 0; i < 4; i++)
            {
                if(!(filterBoxy[i].Text == "" || itemy[i].ToLower().Contains(filterBoxy[i].Text.ToLower())))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
