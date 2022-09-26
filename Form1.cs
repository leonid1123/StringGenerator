using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringGenerator
{
    public partial class Form1 : Form
    {
        string[] words = { "Варкалось. Хливкие шорьки", " Пырялись по наве,", " И хрюкотали зелюки,","Как мюмзики в мове.",
            "О бойся Бармаглота, сын!","Он так свирлеп и дик,","А в глуще рымит исполин —","Злопастный Брандашмыг",
            "Но взял он меч, и взял он щит,","Высоких полон дум.","В глущобу путь его лежит","Под дерево Тумтум." };
        StringBuilder sb = new StringBuilder();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                int x = random.Next(words.Length);
                sb.Append(words[x]+" ");
            }
            listBox1.Items.Add(sb);
            sb.Clear();
        }
    }
}
