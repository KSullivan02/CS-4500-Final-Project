// Deck.cs
// This subfile makes sure that four cards are selected before sending the information
// for those four cards and the date over to the external file, CardsDealt.txt.
// This subfile also makes sure that the image holds the correct image for the card.
// Latest Revision: 03/21/2024 by Kanaan and Noor
using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace CS4500HW1
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        private Random random = new Random();
        string logPath = Application.StartupPath + "CardsDealt.txt";
        string filePath = Application.StartupPath + "LastWon.txt";
        string outlog = "";
        public string Outlog => outlog;

        public Deck()
        {
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            // On startup create the Date in the log file for the session.
            using (StreamWriter sw = File.AppendText(logPath)) {
                sw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            }
            
            

            var suits = new[] { "Hearts", "Diamonds", "Clubs", "Spades" };
            var values = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" ,"12", "13", "14" };

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    var imageName = $"{value}_of_{suit}.png"; // Assuming image names are formatted like "2_of_Hearts.png"
                    var image = LoadCardImage(imageName);
                    cards.Add(new Card(suit, value, image));
                }
            }
        }


        //Method for loading card images by image name
        private Image LoadCardImage(string imageName)
        {
            try
            {
                // Path to the runtime directory of the application
                var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                // Construct the path to the image, assuming the Images folder is copied to the output directory
                var imagePath = Path.Combine(assemblyPath ?? string.Empty, "Images", imageName);
                return Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                // Handle exceptions or log them as needed
                Console.WriteLine($"Error loading image: {ex.Message}");
                return null;
            }
        }


        // Co-opted this to do the actual legwork of Dealer Selection since it's no longer used to show cards anymore
        // Created by Kanaan
        public List<Card> DealSelectedCards(string[] selectedSuits, string[] selectedValues)
        {
            List<Card> dealtCards = new List<Card>();
            outlog = "";
            
                for (int i = 0; i < selectedSuits.Length; i++)
            {
                // Map face card values to numbers
                string value = MapFaceCardValue(selectedValues[i]);
                string suit = selectedSuits[i];

                // Find the card with the matching suit and value
                Card cardToDeal = cards.FirstOrDefault(card => card.Suit == suit && card.Value == value);

                if (cardToDeal != null)
                {


                    using (StreamReader reader = new StreamReader(filePath)) 
                    {
                        switch (reader.ReadLine().Trim())
                        {
                            case "0":
                                if (cardToDeal.Suit == "Hearts" || cardToDeal.Suit == "Diamonds")
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += "*" + cardToDeal.Log() + "*" + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                else
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += cardToDeal.Log() + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                break;
                            case "1":
                                if (cardToDeal.Suit == "Clubs")
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += "*" + cardToDeal.Log() + "*" + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                else
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += cardToDeal.Log() + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                break;
                            case "2":
                                if (cardToDeal.Value == "11" || cardToDeal.Value == "12" || cardToDeal.Value == "13")
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += "*" + cardToDeal.Log() + "*" + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                else
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += cardToDeal.Log() + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                break;
                            case "3":
                                if (cardToDeal.Value == "2" || cardToDeal.Value == "3" || cardToDeal.Value == "4" || cardToDeal.Value == "5" || cardToDeal.Value == "6" || cardToDeal.Value == "7" || cardToDeal.Value == "8" || cardToDeal.Value == "9")
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += "*" + cardToDeal.Log() + "*" + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                else
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += cardToDeal.Log() + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                break;
                            case "4":
                                if (cardToDeal.Value == "2" || cardToDeal.Value == "3" || cardToDeal.Value == "5" || cardToDeal.Value == "7")
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += "*" + cardToDeal.Log() + "*" + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                else
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += cardToDeal.Log() + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                break;
                            case "5":
                                string[] copyDraw = selectedValues;
                                for (int j = 0; j < copyDraw.Length; j++)
                                {
                                    switch (copyDraw[j])
                                    {
                                        case "J": copyDraw[j] = "11"; break;
                                        case "Q": copyDraw[j] = "12"; break;
                                        case "K": copyDraw[j] = "13"; break;
                                        case "A": copyDraw[j] = "14"; break;
                                    }
                                }
                                int[] copyNum = Array.ConvertAll(copyDraw, int.Parse);
                                int max = copyNum[0];
                                
                                for (int j = 0; j < selectedSuits.Length; j++)
                                {
                                    if (copyNum[j] > max)
                                    {
                                        max = copyNum[j];
                                    }
                                }

                                if (int.Parse(cardToDeal.Value) == max)
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += "*" + cardToDeal.Log() + "*" + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                else
                                {
                                    dealtCards.Add(cardToDeal);
                                    outlog += cardToDeal.Log() + (i < selectedSuits.Length - 1 ? "," : "");
                                }
                                break;
                        }
                    }
                        
                }
                else
                {
                    // If a card is not found, write a message to the debug output
                    System.Diagnostics.Debug.WriteLine($"Card with suit {suit} and value {value} not found or already dealt.");
                }
            }

            string[] items = outlog.Split(',');
            Array.Sort(items);
            outlog = "";
            outlog = string.Join(',', items);

            // Log the cards dealt
            using (StreamWriter sw = File.AppendText(logPath))
            {
                sw.WriteLine(outlog);
            }

            System.Diagnostics.Debug.WriteLine(outlog);

            // Check if the correct number of cards were dealt
            if (dealtCards.Count != selectedSuits.Length)
            {
                throw new InvalidOperationException("Not enough cards were dealt.");
            }

            return dealtCards;
        }

        private string MapFaceCardValue(string value)
        {
            switch (value)
            {
                case "J": return "11";
                case "Q": return "12";
                case "K": return "13";
                case "A": return "14";
                default: return value; // For number cards, the value does not change
            }
        }

    }
}

