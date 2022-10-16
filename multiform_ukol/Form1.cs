using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiform_ukol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int pocet = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (pocet < 10)
            {
                Button button1 = new Button();
                button1.DialogResult = DialogResult.OK;
                button1.Location = new Point(5, 30);
                button1.Size = new Size(50, 25);
                button1.Text = "Ulož";

                Button button2 = new Button();
                button2.DialogResult = DialogResult.Cancel;
                button2.Location = new Point(95, 30);
                button2.Size = new Size(50, 25);
                button2.Text = "Zrušit";

                TextBox textBox = new TextBox();
                textBox.Location = new Point(5, 5);
                textBox.Size = new Size(140, 50);
                textBox.Clear();

                Form form2 = new Form();
                form2.Location = new Point(0, 1000);
                form2.Size = new Size(165, 100);
                form2.MaximizeBox = false;
                form2.MinimizeBox = false;
                form2.FormBorderStyle = FormBorderStyle.FixedDialog;
                form2.Controls.Add(textBox);
                form2.Controls.Add(button2);
                form2.Controls.Add(button1);
                form2.Text = "Zadávání";

                form2.AcceptButton = button1;
                form2.ActiveControl = textBox;

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(textBox.Text);
                    pocet++;
                }
            }
            else
            {
                MessageBox.Show("V listBoxu může být jen 10 položek!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pocet = 0;
        }
    }
}
