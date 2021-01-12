using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void initUI()
        {
            lblTime.Text = "--";
            txtNum.Clear();
            txtOut.Clear();
        }

        private void btnIsPrime_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            lblTime.Text = "--";
            txtOut.Clear();

            DateTime d1 = DateTime.Now;

            txtOut.AppendText(isPrime(int.Parse(txtNum.Text)));

            txtNum.Focus();
            txtNum.SelectAll();

            DateTime d2 = DateTime.Now;
            var ts = d2 - d1;
            lblTime.Text = ts.ToString();
            this.Cursor = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initUI();
            this.ActiveControl = txtNum;
            txtNum.SelectAll();
        }

        private string isPrime(int num)
        {
            var sb = new StringBuilder();

            bool isprime = true;
            int limit = (int)Math.Sqrt(num);
            for (int i = 2; i <= limit; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime)
            {
                sb.Append("素数");
            }
            else
            {
                sb.Append("非素数");
                sb.Append(Environment.NewLine);
                string s = getDivsStr(num);
                sb.Append(s.Substring(0, s.Length - 1));
            }

            return sb.ToString();
        }

        private string getDivsStr(int num)
        {
            string ret = "";

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    ret = string.Format(" {0} *", i);
                    ret += getDivsStr(num / i);
                    break;
                }
            }

            return ret;
        }

        private void btnPrimes_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            lblTime.Text = "--";
            txtOut.Clear();

            DateTime d1 = DateTime.Now;

            txtOut.AppendText(getPrimesStr(int.Parse(txtNum.Text)));

            txtNum.Focus();
            txtNum.SelectAll();

            DateTime d2 = DateTime.Now;
            var ts = d2 - d1;
            lblTime.Text = ts.ToString();
            this.Cursor = Cursors.Default;
        }

        private string getPrimesStr(int num)
        {
            bool[] primes = new bool[num+1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = false;
            primes[1] = false;
            int limit = (int)Math.Sqrt(num);
            //int limit = num;

            for (int i = 2; i <= limit; i++)
            {
                if (primes[i] == false) continue;

                for (int j = i + i; j <= num; j += i)
                {
                    primes[j] = false;
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 2; i <= num; i++)
            {
                if (primes[i] == true)
                {
                    sb.AppendFormat(" {0},", i);
                }
            }

            primes = null;
            string ret = sb.ToString();
            sb.Clear();
            return ret.Substring(0, ret.Length - 1);
        }
    }
}
