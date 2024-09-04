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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRODIGY_SD_02
{
    public partial class GuessingGame : Form
    {
        public GuessingGame()
        {
            InitializeComponent();
        }
        int number=new Random().Next(1,101);
        int count = 0;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = int.Parse(txtGuess.Text);

                count = count + 1;
                if (guess < number)
                {
                    lblFeedback.Text = "Your guess is too low! Try again";
                }
                else if (guess > number)
                {
                    lblFeedback.Text = "Your guess is too high! Try again";
                }
                else
                {
                    lblFeedback.Text = "Your guess is Correct! Congratulations";
                    btnSubmit.Enabled = false;
                }
                lblAttempts.Text = "Attempts:" + count;
            }
            catch (FormatException) { MessageBox.Show("Invalid input! Enter a number"); }
        }
    }
 }