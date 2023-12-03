using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice.PR4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArraysAB a = new ArraysAB(100);
            FileWrite f = new FileWrite();
            FileRead f2 = new FileRead();
            ShowArray show = new ShowArray();
            string patch = @"1.txt";
            string patch1 = @"2.txt";
            f2.read(patch, a);
            a.calculate();
            f.write(patch1, a);
            label2.Text = show.writeArray(a.a);
            label4.Text = show.writeArray(a.b);
        }
    }
}
