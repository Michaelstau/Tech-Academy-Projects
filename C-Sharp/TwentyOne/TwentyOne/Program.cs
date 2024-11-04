using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args) //void means returns nothing, static means not creating an object of the class.
        {
            Console.WriteLine("What's your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money will you be spending today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}. Would you like to play a game of 21?.", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "yep")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks you for Playing");
            }
            Console.WriteLine("Bye for now");
            Console.ReadLine();




            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "jesse", "mike", "shelly" };
            //game.ListPlayers();
            //Console.ReadLine();
            //game.Play();

            //TwentyOneGame game = new TwentyOneGame(); ;
            //game.Players = new List<string>() { "jesse", "mike", "shelly" };
            //game.ListPlayers();


            //operation overloading
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Michael";
            //game += player;
            //game -= player;


            //Deck deck = new Deck();
            //int timesShuffled = 0;
            //deck.Shuffle(3);
            ////deck = Shuffle(deck: deck, out timesShuffled, times: 8);
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("timesShuffled: {0}", timesShuffled);
            //Console.ReadLine();
        }


        // throw new Exception("a specific message");
        // in exception
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.message);
        //     UpdateDbWithException(ex);
        // }
        private static void UpdateWithException(Exception ex)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        //prints out a list of DB entries
        // List<ExceptionEntity> Exceptions = ReadExceptions();
        // foreach (Exception excpetion in Exceptions)
        // {
        //    Console.WriteLine(exception.Id + " | ");
        //    Console.WriteLine(exception.ExceptionType + " | ");
        //    Console.WriteLine(exception.ExceptionMessage + " | ");
        //    Console.WriteLine(exception.TimeStamp + " | ");
        // {

        // string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";




        // polymorhpism
        // TwentyOneGame Tgame = new TwentyOneGame();
        // Game Pgame = new PokerGame();
        // List<Games> games = new List<game>() { Pgame }
        // games.add(Tgame)
        //
        // Both Pgame, and Tgame are now type Game, and on the same list of type game


        //making a method

        //overloading a method
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;


        //using out params to update other variables.
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //{
        //    timesShuffled = 0;
        //    for (int i = 0; i < times; i++)
        //    {
        //        timesShuffled ++;
        //        List<Card> tempList = new List<Card>();
        //        Random random = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            tempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);
        //        }
        //        deck.Cards = tempList;
        //        Console.WriteLine("Deck shuffled");
        //    }
        //    return deck;
        //}

        // object initialization
        // Card card = new Card() {Face = "King", Suit = "Spades"}
        //
        // instead of
        // Card card = new Card()
        // card.Face = "king"
        // card.Suit = "Spades"

        //lambdas:
        // x => x*x
        // (input params) => (Evaluation)

        // int counter = 0;
        // foreach (Card card in deck.Cards)
        // {
        //     if (card.Face == Face.Ace)
        //     {
        //         counter++
        //     }
        // }
        // Console.WriteLine(counter)

        // lambda version of above for loop
        // int count = deck.Cards.count(x => x.Face == Face.Ace);
        // Conosle.WriteLine(count);

        // List<Card> newList = deck.cards.Where(x => x.Face == Face.King).ToList();
        // inserts all the king faced cards in deck to newList
    }
}