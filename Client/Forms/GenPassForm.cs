using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class GenPassForm : Form
    {
        public GenPassForm()
        {
            InitializeComponent();
        }
        int leng = 0;
        string sir = "";
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out leng);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sir = textbox.Text;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (leng == 0)
            {
                PassGenerator(24);
            }

            else if (leng > 0)
            {
                PassGenerator(leng);
            }
        }
        public void PassGenerator(int len)
        {
            int nrCar = 0;
            int lenght = len;
            double ore,ani=0;
            const string SpecialChar = "`!@#$%^&*()_+-=[]{}|;':',./?";
            const string CapitalChar = "QWERTYUIOPASDFGHJKLZXCVBNM";
            const string SmallChar = "qwertyuiopasdfghjklzxcvbnm";
            const string DigitsChar = "1234567890";
            const string ValidChar = SpecialChar + CapitalChar + SmallChar + DigitsChar;
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len)
            {
                if (!(bool)checkBox2.Checked && !(bool)checkBox3.Checked && !(bool)checkBox4.Checked && !(bool)checkBox5.Checked)
                {
                    result.Append(ValidChar[rand.Next(ValidChar.Length)]);
                    len--;

                }
                if (len == 0)
                    break;
                if ((bool)checkBox2.Checked)
                {
                    result.Append(CapitalChar[rand.Next(CapitalChar.Length)]);
                    len--;
                }
                if (len == 0)
                    break;
                if ((bool)checkBox3.Checked)
                {
                    result.Append(SmallChar[rand.Next(SmallChar.Length)]);
                    len--;
                }
                if (len == 0)
                    break;
                if ((bool)checkBox4.Checked)
                {
                    result.Append(DigitsChar[rand.Next(DigitsChar.Length)]);
                    len--;
                }
                if (len == 0)
                    break;
                if ((bool)checkBox5.Checked)
                {
                    result.Append(SpecialChar[rand.Next(SpecialChar.Length)]);
                    len--;
                    
                }
                if (len == 0)
                    break;

            }
            if (!(bool)checkBox2.Checked && !(bool)checkBox3.Checked && !(bool)checkBox4.Checked && !(bool)checkBox5.Checked)
            {
                nrCar =90;
            }
            if ((bool)checkBox2.Checked)
            {
                nrCar += 26;
            }
            if ((bool)checkBox3.Checked)
            {
                nrCar += 26;
            }
            if ((bool)checkBox4.Checked)
            {
                nrCar += 10;
            }
            if ((bool)checkBox5.Checked)
            {
                nrCar += 28;
            }
            double possibleP = Math.Pow(nrCar, lenght);
            ore = (possibleP / (Math.Pow(10, 9) * 3600 * 2));
            if (ore < 1)
                ore = 0;
            if (ore > 8760)
                ani = ore / 8760;
            Random num = new Random();
            string randul = new string(result.ToString().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
            textbox.Text = randul.ToString();
            int x=(int) Math.Log(possibleP, 2);
            textbox3.Text = x.ToString();
            if (x < 28)
                label7.Text = "Very Weak; might\n keep out family members";
            if (x >= 28 && x < 35)
                label7.Text = "Weak; should keep out most people, \noften good for desktop login passwords";
            if (x >= 35 && x < 60)
                label7.Text = "Reasonable; fairly secure passwords \nfor network and company passwords";
            if (x >= 60 && x < 128)
                label7.Text = "Strong; can be good for guarding \nfinancial information";
            if (x > 128)
                label7.Text = "Very Strong; often overkill";
            label8.Text = "The password would be cracked in " + ore.ToString()+" hours";
            if(ani!=0)
                label8.Text = "The password would be cracked in " + ani.ToString() + " years";        
        }

        private void PassCheck(object sender, EventArgs e)
        {
            double ore, ani = 0;
            int lungimeL = sir.Length;
            int lungimeC = 0;
            Regex SpecialC = new Regex("[^A-Za-z0-9]");
            Regex CapitalC = new Regex("[A-Z]");
            Regex SmallC = new Regex("[a-z]");
            Regex DigitC = new Regex("[0-9]");
            if(SpecialC.IsMatch(sir))
            {
                lungimeC += 28;
            }
            if (CapitalC.IsMatch(sir))
            {
                lungimeC += 26;
            }
            if (SmallC.IsMatch(sir))
            {
                lungimeC += 26;
            }
            if (DigitC.IsMatch(sir))
            {
                lungimeC += 10;
            }
            double possibleP = Math.Pow(lungimeC, lungimeL);
            ore = (possibleP / (Math.Pow(10, 9) * 3600 * 2));
            if (ore < 1)
                ore = 0;
            if (ore > 8760)
                ani = ore / 8760;
            int x = (int)Math.Log(possibleP, 2);
            textbox3.Text = x.ToString();
            if (x < 28)
                label7.Text = "Very Weak; might\n keep out family members";
            if (x >= 28 && x < 35)
                label7.Text = "Weak; should keep out most people, \noften good for desktop login passwords";
            if (x >= 35 && x < 60)
                label7.Text = "Reasonable; fairly secure passwords \nfor network and company passwords";
            if (x >= 60 && x < 128)
                label7.Text = "Strong; can be good for guarding \nfinancial information";
            if (x > 128)
                label7.Text = "Very Strong; often overkill";
            label8.Text = "The password would be cracked in " + ore.ToString() + " hours";
            if (ani != 0)
                label8.Text = "The password would be cracked in " + ani.ToString() + " years";
        }
    }
}

