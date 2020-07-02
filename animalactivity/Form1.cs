using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalactivity
{
    public partial class Form1 : Form
    {
        Dog TheDog;
        Cat TheCat ;
        Rabbit TheRabbit ;
        Turtle TheTurtle ;
        public Form1()
        {
            InitializeComponent();
        }
        //When the form loads,I intialise the objects
        private void Form1_Load(object sender, EventArgs e)
        {
            TheDog = new Dog("Willy", DogPicture);
            TheCat = new Cat("Billo", CatPicture);
            TheRabbit = new Rabbit("Ruby", RabbitPicture);
            TheTurtle = new Turtle("Milad", TurtlePicture);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (TheDog.Picture.Location.X < 600 &&
                TheCat.Picture.Location.X < 600 &&
                 TheRabbit.Picture.Location.X < 600 &&
                 TheTurtle.Picture.Location.X < 600 )
            {
                TheDog.Move(rand.Next(2, 20));
                TheCat.Move(rand.Next(2, 20));
                TheRabbit.Move(rand.Next(2, 20));
                TheTurtle.Move(rand.Next(2, 20));
            }
            
                else
            {
                string winner = "";

                for(int i = 0; i<4; i++)
                {
                   if(TheDog.Picture.Location.X>=600)
                    {
                        winner = TheDog.Name;
                    }
                    else if (TheCat.Picture.Location.X >= 600)
                    {
                        winner = TheCat.Name;
                    }
                    else if (TheRabbit.Picture.Location.X >= 600)
                    {
                        winner = TheRabbit.Name;
                    }
                    else if (TheTurtle.Picture.Location.X >= 600)
                    {
                        winner = TheTurtle.Name;
                    }
                   else
                    { winner = "Something wents wrong!";
                    }

                }
                MessageBox.Show("The race is finished and the winner is" + winner);
            }
            }
        }
    }

