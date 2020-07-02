using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalactivity
{
    public class Dog:Animal
    {
        public override string Name { get; set; }
        public override PictureBox Picture { get; set; }
        public Dog(string temName, PictureBox tempic)
        {
            Name = temName;
            Picture = tempic;
        }
        public override void Move(int distance)
        {
            Picture.Location = new Point(Picture.Location.X + distance, Picture.Location.Y);
        }

    }
}
