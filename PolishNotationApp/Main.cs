using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolishNotationApp
{
    public partial class Main : Form
    {
        public int h = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void exptxtbox_TextChanged(object sender, EventArgs e)
        {
            anss.Text = "";
        }

        private void DRPN_Click(object sender, EventArgs e)
        {
            anss.Text = "";
            stack L = new stack();
            L.get_array(1000);
            string x = exptxtbox.Text;
            string num = "",opp="";
            string pop1 = "";
            int ans = 0;
            foreach (char i in x)
            {
                if (Char.IsDigit(i))
                {
                    L.push(i - 48);
                    num += i;
                }
                else
                {
                    opp += i;
                    switch (i)
                    {
                        case '+':
                            ans = L.pop() + L.pop();
                            L.push(ans);
                            break;
                        case '-':
                            ans = L.pop() - L.pop();
                            L.push(ans);
                            break;
                        case '*':
                            ans = L.pop() * L.pop();
                            L.push(ans);
                            break;
                        case '/':
                            ans = L.pop() / L.pop();
                            L.push(ans);
                            break;
                    }
                }
            }
            anss.Text = L.pop().ToString();
        }

        private void ERPN_Click(object sender, EventArgs e)
        {
            anss.Text = "";
            stack L = new stack();
            string y = "", z = "";
            string x = exptxtbox.Text;
            if (!Char.IsDigit(x[x.Length - 1]) || !Char.IsDigit(x[0]))
            {
                MessageBox.Show("Error!");
                exptxtbox.Text = "";
                anss.Text = "";
            }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (Char.IsDigit(x[i]))
                    {
                        y += x[i];
                    }
                    else
                    {
                        z += x[i];
                    }
                }
                anss.Text += y + z +"\nAnswer = ";
                string n = y + z;
                /////////////////////////////////
                //stack L = new stack();
                L.get_array(100);
                x = n;
                int ans = 0;
                foreach (char i in x)
                {
                    if (Char.IsDigit(i))
                    {
                        L.push(i - 48);
                    }
                    else
                    {
                        switch (i)
                        {
                            case '+':
                                ans = L.pop() + L.pop();
                                L.push(ans);
                                break;
                            case '-':
                                ans = L.pop() - L.pop();
                                L.push(ans);
                                break;
                            case '*':
                                ans = L.pop() * L.pop();
                                L.push(ans);
                                break;
                            case '/':
                                ans = L.pop() / L.pop();
                                L.push(ans);
                                break;
                        }
                    }
                }
                anss.Text += L.pop().ToString();
            }
        }
        private void DPN_Click(object sender, EventArgs e)
        {
            anss.Text = "";
            stack L = new stack();
            L.get_array(1000);
            string y = "";
            string x = exptxtbox.Text;
            string norm = "";
//Abdulsayed
            int ans = 0;
            if (Char.IsDigit(x[0]) || !Char.IsDigit(x[x.Length - 1]))
            {
                MessageBox.Show("Error!");
                exptxtbox.Text = "";
                anss.Text = "";
            }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == '+' || x[i] == '-' || x[i] == '/' || x[i] == '*')
                    {
                        L.push(x[i]);
                    }
                    else
                    {
                        y += x[i];
                    }
                }
                ans = y[y.Length-1] - 48;
                for (int i = y.Length-2; i >= 0; i--)
                {
                    int f = ans;
                    int l = y[i] - 48;
                    if (L.peek() == '-')
                    {
                        ans = Math.Abs(f - l);
                        L.pop();
                    }
                    else if (L.peek() == '+')
                    {
                        ans = f + l;
                        L.pop();
                    }
                    else if (L.peek() == '/')
                    {
                        ans = f / l;
                        L.pop();
                    }
                    else if (L.peek() == '*')
                    {
                        ans = f * l;
                        L.pop();
                    }
                }
                anss.Text = ans.ToString();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void EPN_Click(object sender, EventArgs e)
        {
            anss.Text = "";
            stack L = new stack();
            L.get_array(1000);
            string y = "", z = "";
            string x = exptxtbox.Text;
            for (int i = 0; i < x.Length; i++)
            {
                if (Char.IsDigit(x[i]))
                {
                    y += x[i];
                }
                else
                {
                    z += x[i];
                }
            }
            anss.Text += z + y +"\nAnswer = ";
            string na = z + y;
            y = "";
            x = na;
            int ans = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '+' || x[i] == '-' || x[i] == '/' || x[i] == '*')
                {
                    L.push(x[i]);
                }
                else
                {
                    y += x[i];
                }
            }
            ans = y[y.Length - 1] - 48;
            for (int i = y.Length - 2; i >= 0; i--)
            {
                int f = ans;
                int l = y[i] - 48;
                if (L.peek() == '-')
                {
                    ans = Math.Abs(f - l);
                    L.pop();
                }
                else if (L.peek() == '+')
                {
                    ans = f + l;
                    L.pop();
                }
                else if (L.peek() == '/')
                {
                    ans = f / l;
                    L.pop();
                }
                else if (L.peek() == '*')
                {
                    ans = f * l;
                    L.pop();
                }
            }
            anss.Text += ans.ToString();
        }
    }
    
}
