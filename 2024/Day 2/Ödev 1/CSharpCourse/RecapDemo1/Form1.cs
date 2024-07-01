using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form   //Form1 : Form Inheritance--Miras
    {
        public Form1()  //Classın ismi ile blok görüyorsun void yada döndüreccek bi şey yazmıyor direk classın ismi -- CONSTRUCTURE-- insaat
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            char[] columns = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                


                for (int j = 0; j <=buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = 50;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                        buttons[i, j].ForeColor = Color.White;
                    }
                    else
                    {
                        
                        buttons[i, j].BackColor = Color.White;
                        buttons[i, j].ForeColor = Color.Black;

                    }


                    buttons[i, j].Text = $"{columns[j]}{8 - i}";
                    buttons[i, j].Click += Button_Click;  // Click olayı ekleniyor
                    this.Controls.Add(buttons[i, j]);
                    


                }
                left = 0;
                top += 50;
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show(clickedButton.Text);  // Butonun metni gösteriliyor
        }


    }
}
