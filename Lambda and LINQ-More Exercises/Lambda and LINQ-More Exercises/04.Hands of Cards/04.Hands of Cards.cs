using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var playersCards = new Dictionary<string, HashSet<string>>();
            var playersTotalValue = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "JOKER")
            {
                var tokens = input.Split(new[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var player = tokens[0];

                if (!playersCards.ContainsKey(player))
                {
                    playersCards[player] = new HashSet<string>();
                }

                for (int i = 1; i < tokens.Length; i++)
                {
                    var currentCard = tokens[i];
                    playersCards[player].Add(currentCard);
                }
            }

            foreach (var playerCards in playersCards)
            {
                var player = playerCards.Key;
                var cards = playerCards.Value;

                foreach (var card in cards)
                {
                    var currentCard = card;
                    int power = 0;

                    switch (currentCard[0])
                    {
                        case 'J':
                            power = 11;
                            break;
                        case 'Q':
                            power = 12;
                            break;
                        case 'K':
                            power = 13;
                            break;
                        case 'A':
                            power = 14;
                            break;
                        case '1':
                            power = 10;
                            break;
                        case '2':
                            power = 2;
                            break;
                        case '3':
                            power = 3;
                            break;
                        case '4':
                            power = 4;
                            break;
                        case '5':
                            power = 5;
                            break;
                        case '6':
                            power = 6;
                            break;
                        case '7':
                            power = 7;
                            break;
                        case '8':
                            power = 8;
                            break;
                        case '9':
                            power = 9;
                            break;
                        default:
                            break;
                    }

                    int multiplier = 0;

                    var type = currentCard[currentCard.Length - 1];
                    switch (type)
                    {
                        case 'S':
                            multiplier = 4;
                            break;
                        case 'H':
                            multiplier = 3;
                            break;
                        case 'D':
                            multiplier = 2;
                            break;
                        case 'C':
                            multiplier = 1;
                            break;
                        default:
                            break;
                    }
                    var sum = power * multiplier;

                    if (!playersTotalValue.ContainsKey(player))
                    {
                        playersTotalValue[player] = 0;
                    }

                    playersTotalValue[player] += sum;
                }
            }

            foreach (var player in playersTotalValue)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }
    }
}
