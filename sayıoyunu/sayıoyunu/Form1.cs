using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace sayıoyunu
{
    public partial class Form1 : Form
    {
        List<int> listsayi = new List<int>();
        Random rnd = new Random();
        int[,] sayılar = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int mssayac = 0;
        int ssayac = 0;
        int dsayac = 0;
        bool son = false;
        public Form1()
        {
            InitializeComponent();
            List<TextBox> tlist = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25 };
            foreach (var textbox in tlist)
            { textbox.MaxLength = 1; }
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            List<TextBox> tbbblist = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25 };
            foreach (var tbox in tbbblist)
            { tbox.Text = ""; }
            son = true;
            timer1.Stop();
            timer1.Start();
            for (int a = 0; a < 3; a++)
            {
                for (int i = 1; i < 6; i++)
                { listsayi.Add(i); }
                for (int i = 0; i < 5; i++)
                {
                    int rast = rnd.Next(0, listsayi.Count);
                    sayılar[a, i] = listsayi[rast];
                    listsayi.RemoveAt(rast);
                }
            }
            bool aaa = true;
            int sayaca = 0;
            while (aaa == true)
            {
                for (int i = 1; i < 6; i++)
                { listsayi.Add(i); }
                for (int i = 0; i < 5; i++)
                {
                    int rast = rnd.Next(0, listsayi.Count);
                    sayılar[1, i] = listsayi[rast];
                    listsayi.RemoveAt(rast);
                    if (sayılar[0, i] != sayılar[1, i])
                    { sayaca++; }
                    else { sayaca = 0; }
                }
                if (sayaca == 5) { aaa = false; }
            }
            bool aab = true;
            int sayacb = 0;
            while (aab == true)
            {
                for (int i = 1; i < 6; i++)
                { listsayi.Add(i); }
                for (int i = 0; i < 5; i++)
                {
                    int rast = rnd.Next(0, listsayi.Count);
                    sayılar[2, i] = listsayi[rast];
                    listsayi.RemoveAt(rast);
                    if (sayılar[0, i] != sayılar[2, i] && sayılar[1, i] != sayılar[2, i])
                    { sayacb++; }
                    else { sayacb = 0; }
                }
                if (sayacb == 5) { aab = false; }
            }
            bool aac = true;
            int sayacc = 0;
            while (aac == true)
            {
                for (int i = 1; i < 6; i++)
                { listsayi.Add(i); }
                for (int i = 0; i < 5; i++)
                {
                    int rast = rnd.Next(0, listsayi.Count);
                    sayılar[3, i] = listsayi[rast];
                    listsayi.RemoveAt(rast);
                    if (sayılar[0, i] != sayılar[3, i] && sayılar[1, i] != sayılar[3, i] && sayılar[2, i] != sayılar[3, i])
                    { sayacc++; }
                    else { sayacc = 0; }
                }
                if (sayacc == 5) { aac = false; }
            }
            bool aad = true;
            int sayacd = 0;
            while (aad == true)
            {
                for (int i = 1; i < 6; i++)
                { listsayi.Add(i); }
                for (int i = 0; i < 5; i++)
                {
                    int rast = rnd.Next(0, listsayi.Count);
                    sayılar[4, i] = listsayi[rast];
                    listsayi.RemoveAt(rast);
                    if (sayılar[0, i] != sayılar[4, i] && sayılar[1, i] != sayılar[4, i] && sayılar[2, i] != sayılar[4, i] && sayılar[3, i] != sayılar[4, i])
                    { sayacd++; }
                    else { sayacd = 0; }
                }
                if (sayacd == 5) { aad = false; }
            }

            List<TextBox> tblist = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25};
            List<Label> lablist = new List<Label>();
            lablist.Add(label2);
            lablist.Add(label3);
            lablist.Add(label4);
            lablist.Add(label5);
            lablist.Add(label6);
            lablist.Add(label7);
            lablist.Add(label8);
            int labrast = rnd.Next(3, 8);
            List<int> labellist = new List<int>();
            for (int i=0;i<labrast;i++)
            {
                int rastabca = rnd.Next(0, tblist.Count);
                while (rastabca==4 || rastabca == 9 || rastabca == 14 || rastabca == 19 || rastabca == 24 )
                {rastabca = rnd.Next(0, tblist.Count); }
                labellist.Add(rastabca);
            }
            foreach (var label in lablist)
            { label.Text = ""; }
            int labsayac;
            labsayac = 0;
            foreach (var textbox in tblist)
            {
                for (int i = 0; i < labrast; i++)
                {
                    if (labsayac == labellist[i])
                    {
                        int rast = rnd.Next(0,lablist.Count);

                        if (labsayac%2==0 || labsayac==20 || labsayac==21 || labsayac==22 || labsayac==23)
                        {
                            lablist[rast].Location = new Point(textbox.Location.X + 50, textbox.Location.Y + 15);
                            if (sayılar[labsayac / 5, labsayac % 5] > sayılar[labsayac / 5, labsayac % 5 + 1])
                            {
                                lablist[rast].Text = ">";
                            }
                            else { lablist[rast].Text = "<"; }
                            lablist.RemoveAt(rast);
                        }
                        else
                        {
                            lablist[rast].Location = new Point(textbox.Location.X + 15, textbox.Location.Y + 50);
                            if (sayılar[labsayac / 5, labsayac % 5] > sayılar[labsayac / 5+1, labsayac % 5])
                            {
                                lablist[rast].Text = "v";
                            }
                            else { lablist[rast].Text = "^"; }
                            lablist.RemoveAt(rast);
                        }
                    }
                    textbox.Text = "";
                }
                labsayac++;
                timer1.Stop();
                timer1.Start();
                mssayac = 0;
                ssayac = 0;
                dsayac = 0;
                label9.Text = "00";
                label10.Text = "00";
                label11.Text = "00";
            }
            List<int> ipucu = new List<int>();
            List<int> sayilarr = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            int aa = rnd.Next(3, 8);
            for (int i = 0; i < aa; i++)
            {
                int rast = rnd.Next(0, sayilarr.Count);
                ipucu.Add(sayilarr[rast]);
                sayilarr.Remove(rast);
            }
            int sasayac = 0;
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    for (int c = 0; c < ipucu.Count; c++)
                    {
                        if (sasayac == ipucu[c])
                        {
                            tblist[sasayac].Text=Convert.ToString(sayılar[a, b]);
                            ipucu.RemoveAt(0);
                        }
                    }
                    sasayac++;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int dorusayac = 0;
            int kontrolsayac = 0;
            List<TextBox> tbblist = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25 };
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    if (tbblist[kontrolsayac].Text == Convert.ToString(sayılar[a, b]))
                    {
                        tbblist[kontrolsayac].BackColor = Color.Green;
                        dorusayac++;
                    }
                    else { tbblist[kontrolsayac].BackColor = Color.Red; }
                    kontrolsayac++;
                }
            }
            if (dorusayac == 25)
            { label14.Text = "Tebrikler Hepsi Doğru !!!"; }
            else { label14.Text = "Hatalar Var !!!"; }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            son = false;
            int sonsayac = 0;
            List<TextBox> tbblist = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25 };
            int dorusayac = 0;
            int yansayac = 0;
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    if (tbblist[sonsayac].Text == Convert.ToString(sayılar[a, b]))
                    {
                        dorusayac++;
                    }
                    else { tbblist[sonsayac].BackColor = Color.Red; yansayac++; }
                    sonsayac++;
                }
            }
            if (dorusayac == 25)
            { label14.Text = "Tebrikler Kazandınız !!!"; }
            else { label14.Text = "Kaybettiniz !!!"; }
            sonsayac = 0;
            for (int a=0;a<5;a++)
            {
                for (int b=0;b<5;b++)
                {
                    tbblist[sonsayac].Text = Convert.ToString(sayılar[a, b]);
                    sonsayac++;
                }
            }
            label15.Text = Convert.ToString(dorusayac)+" Doğru";
            label16.Text = Convert.ToString(yansayac) + " Yanlış";
            button2.Enabled = false;
            mssayac = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            mssayac++;
            if (son == true)
            { 
            if(mssayac==10)
            { ssayac++;label10.Text = Convert.ToString(ssayac) ; mssayac = 0; }
            label11.Text = Convert.ToString(mssayac);
            if (ssayac == 60)
            { dsayac++; label9.Text = Convert.ToString(dsayac); ; ssayac = 0; }

            }
            if (mssayac == 50 && son == false)
            {
                List<TextBox> tbblist = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25 };
                foreach (var tbox in tbblist)
                { tbox.Text = ""; button2.Enabled = true; }
            }
        }
    }
}