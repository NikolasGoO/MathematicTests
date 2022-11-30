namespace MathematicTests
{
    public partial class FrmChallenge : Form
    {
        Random random = new Random();
        int numberOne, numberTwo;
        int timeLeft;
        int response; 
        int points;
        int timeGame = 360;

        private void FrmChallenge_Load(object sender, EventArgs e)
        {

        }

        public FrmChallenge()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            txtLeftTime.Text = timeLeft + " segundos";

            int pointsAnswers = CheckTheAnswer();

            if(pointsAnswers == 4 || timeLeft == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;

                string message = "";
                if (timeLeft == 0)
                {
                    message = "Você acertou " + pointsAnswers + "questões em: " + (timeLeft - timeGame);
                }
                else 
                {
                    message = ("Parabéns você acertou as 4 questões em: " + (timeLeft - timeGame));
                }

                MessageBox.Show(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnEndQuiz.Visible = true;
            btnStartQuiz.Enabled = false;

            numberOne = random.Next(100);
            numberTwo = random.Next(100);

            lblFirstNumberSun.Text = numberOne.ToString();
            lblSecondNumberSun.Text = numberTwo.ToString();

            numberOne = random.Next(100);
            numberTwo = random.Next(100);

            lblFirstNumberSub.Text = numberOne.ToString();
            lblSecondNumberSub.Text = numberTwo.ToString();

            numberOne = random.Next(100);
            numberTwo = random.Next(100);

            lblFirstNumberMulti.Text = numberOne.ToString();    
            lblSecondNumberMulti.Text = numberTwo.ToString();

            numberOne = random.Next(100);
            numberTwo = random.Next(1, 100);

            lblFirstNumberDiv.Text = numberOne.ToString();
            lblSecondNumberDiv.Text = numberTwo.ToString();

            timeLeft = 60;
            timer1.Enabled = true;  
            timer1.Start();
        }

        public int CheckTheAnswer()
        {
            points = 0;
            numberOne = Convert.ToInt32(lblFirstNumberSun.Text);
            numberTwo = Convert.ToInt32(lblSecondNumberSun.Text);
            response = Convert.ToInt32(numericUpDownSun.Value);

            if((numberOne + numberTwo) == response)
            {
                points++;
            }

            numberOne = Convert.ToInt32(lblFirstNumberSub.Text);
            numberTwo = Convert.ToInt32(lblSecondNumberSub.Text);
            response = Convert.ToInt32(numericUpDownSub.Value);

            if ((numberOne - numberTwo) == response)
            {
                points++;
            }

            numberOne = Convert.ToInt32(lblFirstNumberMulti.Text);
            numberTwo = Convert.ToInt32(lblSecondNumberMulti.Text);
            response = Convert.ToInt32(numericUpDownMulti.Value);

            if ((numberOne * numberTwo) == response)
            {
                points++;
            }

            numberOne = Convert.ToInt32(lblFirstNumberDiv.Text);
            numberTwo = Convert.ToInt32(lblSecondNumberDiv.Text);
            response = Convert.ToInt32(numericUpDownDiv.Value);

            if ((numberOne / numberTwo) == response)
            {
                points++;
            }

            return points;
        }
    }
}