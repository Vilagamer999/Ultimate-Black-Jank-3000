using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using CardClasses;
using BlackJackGUI.Properties;


namespace CardGameGUI
{
    public partial class FormBlackJack : Form 
    {
        Pack pack;
        BlackJackHand hand;

        // A resource manager provides convenient access to culture-specific resources at run time.
        // We need this to access the images that Resources for this project
        ResourceManager rm = Resources.ResourceManager;
        Graphics g;

        System.Media.SoundPlayer MusicPlayer = new System.Media.SoundPlayer();

        /// <summary>
        /// Form Constructor
        /// </summary>
        public FormBlackJack()
        {
            InitializeComponent();
        }

        private void FormBlackJack_Load(object sender, EventArgs e)
        {
            pack = new Pack();
            hand = new BlackJackHand();
            g = CreateGraphics();

            // C# ImageList Use: Windows Forms. 
            //ImageList provides a container for image data. 
            //The control is not visible directly. It is instead referenced from other controls such as ListView, 
            // which acquire the images from index values into the ImageList.
            imageList.ImageSize = new Size(72, 96); // Sets the size of the images in the image list.
            imageList2.ImageSize = new Size(72, 96);
            pack.Shuffle();
            
            PlayerWinText.Visible = false;
            
            MusicPlayer.SoundLocation = "BG.wav";

            MusicPlayer.PlayLooping();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            // Hand is emptied, any card in hand is returned to the pack 
            while (!hand.IsEmpty())
            {
                pack.AddCard(hand.RemoveCard(hand.First()));
            }

            imageList.Images.Clear();
            Invalidate(); // forces to repaint the form

            imageList2.Images.Clear();
            Invalidate(); // forces to repaint the form

            P1CurrentScoreLabel.Visible = true;
            P1CurrentScoreLabel.Text = "0";

            P2CurrentScoreLabel.Visible = true;
            P2CurrentScoreLabel.Text = "0";

            Player2DealButton.Visible = true;
            Player1DealButton.Visible = true;

            Player2DealButton.Enabled = true;
            Player1DealButton.Enabled = true;

            Player2Skip.Visible = true;
            Player1Skip.Visible = true;

            PlayerWinText.Visible = false;
        }

        private void Player1DealButton_Click(object sender, EventArgs e)
        {
            imageList.Images.Clear();

            hand.AddCard(pack.DealCard());
            CreateImage(hand.Last(), hand.Size - 1);
            P1CurrentScoreLabel.Text = Convert.ToString(hand.GetScore());

            if (ScoreOver21())
            {
                P1ScoreLabel.Text = Convert.ToString(Convert.ToInt32(P1ScoreLabel.Text) + 1);
                
                Player2DealButton.Visible = false;
                Player1DealButton.Visible = false;

                Player2Skip.Visible = false;
                Player1Skip.Visible = false;

                PlayerWinText.Visible = true;
                PlayerWinText.Text = "Player 1 Wins!";
            }

            Player1DealButton.Enabled = false;
            Player2DealButton.Enabled = true;

            Player1Skip.Enabled = false;
            Player2Skip.Enabled = true;
        }

        
        private void Player2DealButton_Click(object sender, EventArgs e)
        {
            imageList2.Images.Clear();
            
            hand.AddCard(pack.DealCard());
            CreateImage2(hand.Last(), hand.Size - 1);
            P2CurrentScoreLabel.Text = Convert.ToString(hand.GetScore());

            if (ScoreOver21())
            {
                P2ScoreLabel.Text = Convert.ToString(Convert.ToInt32(P1ScoreLabel.Text) + 1);
                
                Player2DealButton.Visible = false;
                Player1DealButton.Visible = false;

                Player2Skip.Visible = false;
                Player1Skip.Visible = false;

                PlayerWinText.Visible = true;
                PlayerWinText.Text = "Player 2 Wins!";
            }

            Player2DealButton.Enabled = false;
            Player1DealButton.Enabled = true;

            Player2Skip.Enabled = false;
            Player1Skip.Enabled = true;
        }

        private void Player2Skip_Click(object sender, EventArgs e)
        {
            Player2DealButton.Enabled = false;
            Player1DealButton.Enabled = true;

            Player2Skip.Enabled = false;
            Player1Skip.Enabled = true;
        }

        private void Player1Skip_Click(object sender, EventArgs e)
        {
            Player1DealButton.Enabled = false;
            Player2DealButton.Enabled = true;

            Player1Skip.Enabled = false;
            Player2Skip.Enabled = true;
        }

        private bool ScoreOver21()
        {
            if (Convert.ToInt32(P2CurrentScoreLabel.Text) > 21)
            {
                P2ScoreLabel.Text = Convert.ToString(Convert.ToInt32(P1ScoreLabel.Text) + 1);
                
                Player2DealButton.Visible = false;
                Player1DealButton.Visible = false;

                Player2Skip.Visible = false;
                Player1Skip.Visible = false;

                PlayerWinText.Visible = true;
                PlayerWinText.Text = "Player 1 Wins!";

            }

            if (Convert.ToInt32(P1CurrentScoreLabel.Text) > 21)
            {
                P1ScoreLabel.Text = Convert.ToString(Convert.ToInt32(P1ScoreLabel.Text) + 1);
                
                Player2DealButton.Visible = false;
                Player1DealButton.Visible = false;

                Player2Skip.Visible = false;
                Player1Skip.Visible = false;

                PlayerWinText.Visible = true;
                PlayerWinText.Text = "Player 2 Wins!";
            }

            if (Convert.ToInt32(P1CurrentScoreLabel.Text) == 21 || Convert.ToInt32(P2CurrentScoreLabel.Text) == 21)
            {
                return true;
            }

            return false;
        }

        private void CreateImage(Card card, int index)
        {
            // Image name exampke: _1c 1 is the rank, c first character of suit (clubs)  
            string imagename = "_" + card.GetRank().ToString() + card.GetSuitAsString().ToLower()[0];
            // get the resource from Resources (casted to Image)
            Image cardimage = (Image)rm.GetObject(imagename);

            imageList.Images.Add(cardimage);
            // force a call to the Paint method of the form
            Invalidate();
        }

        private void CreateImage2(Card card, int index)
        {
            // Image name exampke: _1c 1 is the rank, c first character of suit (clubs)  
            string imagename = "_" + card.GetRank().ToString() + card.GetSuitAsString().ToLower()[0];
            // get the resource from Resources (casted to Image)
            Image cardimage = (Image)rm.GetObject(imagename);

            imageList2.Images.Add(cardimage);
            // force a call to the Paint method of the form
            Invalidate();
        }


        private void FormBlackJack_Paint(object sender, PaintEventArgs e)
        {
            for(int i=0;i<imageList.Images.Count;i++)
            {
                // (image, X, Y, Width, Height) 
                // cards will be spaced every 100 pixels (i*100)
                g.DrawImage(imageList.Images[i], 100, 100, 72, 96);
            }

            for (int i = 0; i < imageList2.Images.Count; i++)
            {
                // (image, X, Y, Width, Height) 
                // cards will be spaced every 100 pixels (i*100)
                g.DrawImage(imageList2.Images[i], 300, 100, 72, 96);
            }
        }

        private void PauseMusic_Click(object sender, EventArgs e)
        {
            
            
            if (PauseMusic.Text == "Pause Music")
            {
                MusicPlayer.Stop();
                PauseMusic.Text = "Play Music";
            }

            else if (PauseMusic.Text == "Play Music")
            {
                MusicPlayer.PlayLooping();
                PauseMusic.Text = "Pause Music";
            }            
            
        }
    }
}

