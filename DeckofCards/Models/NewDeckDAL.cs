using Newtonsoft.Json;
using System.Net;

namespace DeckofCards.Models
{
    public class NewDeckDAL
    {
        public static NewDeck NewDeck()//Adjust
        {
            //adjust
            //setup
            string url = $"https://deckofcardsapi.com/api/deck/new/";


            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //Convert to c#
            //Install Newtonsoft.json
            NewDeck result = JsonConvert.DeserializeObject<NewDeck>(JSON);
            return result;
        }

        public static void Shuffle()
        {
            string url = "https://deckofcardsapi.com/api/deck/d8kaq0l4c52m/shuffle/";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();


        }
    }
}
