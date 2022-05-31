using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsHorseApp1
{

    public class Horse
    {

        public string Name { get; set; }
        public int Speed { get; set; }
        public bool WinningStatus { get; set; }
        public Horse(string name, int speed)
        {
            Name = name;
            Speed = speed;
            //At the start of the race everyhorse wining status is set as false
            WinningStatus = false;
        }
        
        int positionY = 0;


        public int finishLine { get; } = 741;
        public int startY(string name)
        {
            if (name == "horse1")
            {
                positionY = 37;
            }
            else if (name == "horse2")
            {
                positionY = 105;
            }

            else if (name == "horse3")
            {
                positionY = 175;
            }

            else if (name == "horse4")
            {
                positionY = 251;
            }

            return positionY;
        }

        public int speed()
        {
            var random = new Random();
            return random.Next(1, 100);
        }

        public int startX()
        {
            int positionX = 69;
            return positionX;
        }

        public void reset(PictureBox picturebox, string name)
        {
            picturebox.Location = new Point(startX(), startY(name));
        }
    }
}


