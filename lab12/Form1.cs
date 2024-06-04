using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        private static Random rand = new Random(); // random num generator
        private static int currentState = 1; // Start with clear weather
        private static int[] stateCount = new int[3]; // To track occurrences of each state
        private static double[,] transitionMatrix = {
            { -0.4, 0.3, 0.1 },
            { 0.4, -0.8, 0.4 },
            { 0.1, 0.4, -0.5 }
        }; // transition rate matrixx
        private bool isRunning = false;
        private int totalSteps = 0; // total num of steps in the simulation

        public Form1()
        {
            InitializeComponent();
            stateCount[currentState - 1]++; // initialize the state count 
            UpdateWeatherDisplay(); 
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop(); // stop the timer
                buttonStartStop.Text = "Press Start!";
            }
            else
            {
                timer.Start(); // start the timer
                buttonStartStop.Text = "Press Stop!";
            }
            isRunning = !isRunning;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Get next state based on transition probabilities
            int nextState = GetNextState(currentState);
            currentState = nextState;
            stateCount[currentState - 1]++;
            totalSteps++;
            UpdateWeatherDisplay();
            UpdateProbabilities();
        }

        private void UpdateWeatherDisplay()
        {
            string stateName = GetStateName(currentState);
            labelWeatherState.Text = $"Weather: {stateName}";

            switch (currentState)
            {
                case 1:
                    pictureBoxWeather.Image = Image.FromFile("clear.png"); 
                    break;
                case 2:
                    pictureBoxWeather.Image = Image.FromFile("cloudy.jpg"); 
                    break;
                case 3:
                    pictureBoxWeather.Image = Image.FromFile("rainy.png"); 
                    break;
            }
        }

        private void UpdateProbabilities()
        {
            if (totalSteps == 0) return;

            //calculate the empirical probabilities
            double probState1 = (double)stateCount[0] / totalSteps;
            double probState2 = (double)stateCount[1] / totalSteps;
            double probState3 = (double)stateCount[2] / totalSteps;

            // update the lables with the calculated probabilites
            labelState1.Text = $"State 1 (clear): {probState1:F4}";
            labelState2.Text = $"State 2 (cloudy): {probState2:F4}";
            labelState3.Text = $"State 3 (overcast): {probState3:F4}";
        }

        // get the next state based on the transition prob
        private int GetNextState(int currentState)
        {
            double[] probabilities = new double[3];
            double totalRate = 0;

            for (int i = 0; i < 3; i++)
            {
                if (i != currentState - 1)
                {
                    probabilities[i] = transitionMatrix[currentState - 1, i];
                    totalRate += probabilities[i];
                }
            }

            double randValue = rand.NextDouble() * totalRate; // get a random value to the total rate
            double cumulativeProbability = 0;

            for (int i = 0; i < 3; i++) // determine the next state based on the random value
            {
                if (i != currentState - 1)
                {
                    cumulativeProbability += probabilities[i];
                    if (randValue < cumulativeProbability)
                    {
                        return i + 1;
                    }
                }
            }

            return currentState; 
        }

        // convert the state number to a string
        private string GetStateName(int state)
        {
            switch (state)
            {
                case 1:
                    return "Clear";
                case 2:
                    return "Cloudy";
                case 3:
                    return "Overcast";
                default:
                    return "Unknown";
            }
        }
    }
}
