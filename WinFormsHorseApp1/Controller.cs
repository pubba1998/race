using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsHorseApp1
{
    public class Controller
    {
        public List<Horse> Horses;
        Horse horse = new Horse("daffy", new Random().Next(1,30));
        public void Race(PictureBox pictureBox)
        {
            pictureBox.Left += horse.speed();
        }
        public int select { get; set; }


        //Controller Constructor
        public Controller()
        {
            select = 0;

            //Initializing the horse list to hold the hourses 
            Horses = new List<Horse>();

            //creating a random object to generate the speed of the horses 
            var random = new Random();

            //Adding 4 hourses to the list 
            Horses.Add(new Horse("daffy", random.Next(1, 21)));
            Horses.Add(new Horse("pepe", random.Next(1, 21)));
            Horses.Add(new Horse("taz", random.Next(1, 21)));
            Horses.Add(new Horse("wiley", random.Next(1, 21)));
        }

        public void reset(PictureBox[] horses)
        {
            horse.reset(horses[0], horses[0].Name);
            horse.reset(horses[1], horses[1].Name);
            horse.reset(horses[2], horses[2].Name);
            horse.reset(horses[3], horses[3].Name);
        }

        public bool CheckWinner(PictureBox phorse, int userHorse, System.Windows.Forms.Timer timer)
        {
            if(phorse.Left >= horse.finishLine)
            {
                timer.Stop();
                timer.Dispose();
                timer.Enabled = false;

                if (phorse.Name.Contains(userHorse.ToString()))
                {
                    MessageBox.Show("Show Won");
                }
                else
                {
                    MessageBox.Show("You loose\n"+phorse.Name+" won the race!");
                }

                return true;
            }
            else
            {
                return false;
            }  
        }
    }
}