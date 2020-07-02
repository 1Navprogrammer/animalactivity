using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalactivity
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract PictureBox Picture { get; set; }

        public abstract void Move(int distance);

    }
}
