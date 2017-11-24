using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CardShuffling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string[] cards = { "club10",
                            "club2",
                            "club3",
                            "club4",
                            "club5",
                            "club6",
                            "club7",
                            "club8",
                            "club9",
                            "clubace",
                            "clubjack",
                            "clubking",
                            "clubqueen",
                            "diamond10",
                            "diamond2",
                            "diamond3",
                            "diamond4",
                            "diamond5",
                            "diamond6",
                            "diamond7",
                            "diamond8",
                            "diamond9",
                            "diamondace",
                            "diamondjack",
                            "diamondking",
                            "diamondqueen",
                            "heart10",
                            "heart2",
                            "heart3",
                            "heart4",
                            "heart5",
                            "heart6",
                            "heart7",
                            "heart8",
                            "heart9",
                            "heartace",
                            "heartjack",
                            "heartking",
                            "heartqueen",
                            "spade10",
                            "spade2",
                            "spade3",
                            "spade4",
                            "spade5",
                            "spade6",
                            "spade7",
                            "spade8",
                            "spade9",
                            "spadeace",
                            "spadejack",
                            "spadeking",
                            "spadequeen" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShuffleButton_Click(object sender, RoutedEventArgs e)
        {    
            // Cards need to be shuffled  randomly.
            Random random = new Random();
            for (int i = 0; i <1000; i++)
            {
                // Pick two random cards
                int randomcard1 = random.Next(52);
                int randomcard2 = random.Next(52);

                // shuffle them
                string temp = cards[randomcard1];
                cards[randomcard1] = cards[randomcard2];
                cards[randomcard2] = temp;
            }

            // Print out cards into the the text block to the side
            ShuffledCards.Document.Blocks.Clear();
            for (int i = 0; i <  cards.Length; i++)
            {
                ShuffledCards.AppendText(cards[i] +"\r");
            }

            // 5 cards need to be displayed on screen
            Card1Image.Source = new BitmapImage(new Uri("Cards/" + cards[0] + ".gif", UriKind.Relative));
            Card2Image.Source = new BitmapImage(new Uri("Cards/" + cards[1] + ".gif", UriKind.Relative));
            Card3Image.Source = new BitmapImage(new Uri("Cards/" + cards[2] + ".gif", UriKind.Relative));
            Card4Image.Source = new BitmapImage(new Uri("Cards/" + cards[3] + ".gif", UriKind.Relative));
            Card5Image.Source = new BitmapImage(new Uri("Cards/" + cards[4] + ".gif", UriKind.Relative));
        }
    }
}
