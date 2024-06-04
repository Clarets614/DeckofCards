using Microsoft.AspNetCore.DataProtection;
using Newtonsoft.Json;
using System.Net;

namespace DeckofCards.Models
{
    public class DrawCardDAL
    {

        public static DrawCardModel GetCard(string deckId)//Adjust
        {
            //adjust
            //setup
            string url = $"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count=5";


            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //Convert to c#
            //Install Newtonsoft.json
            DrawCardModel result = JsonConvert.DeserializeObject<DrawCardModel>(JSON);
            return result;
        }


    }
}
