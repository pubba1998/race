namespace WinFormsHorseApp1
{
    public partial class Form1 : Form
    {
        PictureBox[] horses;
        public Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();

            horses = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            timer1.Enabled = false;
            controller.reset(horses);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 250;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += controller.Horses[0].Speed;
            pictureBox2.Left += controller.Horses[1].Speed;
            pictureBox3.Left += controller.Horses[2].Speed;
            pictureBox4.Left += controller.Horses[3].Speed;

            if (pictureBox1.Left >= panel1.Left)
            {
                timer1.Stop();
                timer1.Dispose();
                timer1.Enabled = false;

            }
            if (pictureBox2.Left >= panel1.Left)
            {
                timer1.Stop();
                timer1.Dispose();
                timer1.Enabled = false;
            }
            if (pictureBox3.Left >= panel1.Left)
            {
                timer1.Stop();
                timer1.Dispose();
                timer1.Enabled = false;
            }
            if (pictureBox4.Left >= panel1.Left)
            {
                timer1.Stop();
                timer1.Dispose();
                timer1.Enabled = false;
            }
            

            for (int i = 0; i < 10; i++)
            {
                controller.Race(horses[i]);

                //if(controller.CheackForWinner(horses[i], checkedRadioButton().timer1))
                //{
                //    controller.
                //}                //if(controller.CheackForWinner(horses[i], checkedRadioButton().timer1))
                //{
                //    controller.
                //}

            }
        } 
    }
}

   
