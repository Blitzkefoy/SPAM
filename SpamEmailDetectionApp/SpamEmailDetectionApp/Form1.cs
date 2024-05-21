using System;
using System.Windows.Forms;

namespace SpamEmailDetectionApp
{
    public partial class Form1 : Form
    {
        // List of spam keywords
        private readonly string[] spamKeywords = { "win", "free", "prize", "money", "urgent", "exclusive", "click", "won" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckSpam_Click(object sender, EventArgs e)
        {
            string emailText = txtEmail.Text.ToLower();
            bool isSpam = false;

            // Check if the email contains any spam keywords
            foreach (string keyword in spamKeywords)
            {
                if (emailText.Contains(keyword))
                {
                    isSpam = true;
                    break;
                }
            }

            // Display the result
            lblResult.Text = isSpam ? "Spam detected!" : "No spam detected.";
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}