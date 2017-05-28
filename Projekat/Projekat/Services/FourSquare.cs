using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Security.Authentication.Web;

namespace Projekat.Services
{
    class FourSquare
    {
        private string OAuthToken = "";
        public async void authenticate()
        {
            try
            {
                String clientId = "N0WUQ4XMWOAX5DMQN0LCZEFHRMTDQCHZNU4C20L4MH2U4DIX";
                //url za poziv na api koji trazi code string
                String foursqareApiUrl = "https://foursquare.com/oauth2/authenticate?client_id=" + clientId + "&response_type=code&redirect_uri=https://www.google.ba/";
                System.Uri StartUri = new Uri(foursqareApiUrl);
                WebAuthenticationResult WebAuthentication = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.None, StartUri,new Uri("https://www.google.ba/"));
                if (WebAuthentication.ResponseStatus == WebAuthenticationStatus.Success)
                {
                    await getOauthToken(WebAuthentication.ResponseData.ToString());
                }
                else if (WebAuthentication.ResponseStatus == WebAuthenticationStatus.ErrorHttp)
                {
                  
                throw new Exception("HTTP Error returned by AuthenticateAsync(): " + WebAuthentication.ResponseErrorDetail.ToString());
                }
                else
                {
                    throw new Exception("Error returned by AuthenticateAsync() : " + WebAuthentication.ResponseStatus.ToString());
                }
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
 private async Task getOauthToken(string webAuthResultResponseData)
        {
            //izdvajanje code parametra iz dobivenog stringa
            string responseData = webAuthResultResponseData.Substring(webAuthResultResponseData.IndexOf("code"));
            String[] keyValPairs = responseData.Split('&');
            string code = null;
            for (int i = 0; i < keyValPairs.Length; i++)
            {
                String[] splits = keyValPairs[i].Split('=');
                if (splits[0].Equals("code"))
                {
                    code = splits[1];
                }
            }
            //Koristenje code za dobivanje acess tokena pozivom
            HttpClient httpClient = new HttpClient();
            string response = await httpClient.GetStringAsync(new Uri("https://foursquare.com/oauth2/access_token?client_id=" +
           "N0WUQ4XMWOAX5DMQN0LCZEFHRMTDQCHZNU4C20L4MH2U4DIX" + "&client_secret=" + "5TBRLQEPCWJ0TXFBHVAHG2GF4XDL0C1TXNCANTISNF2USVB0" +
           "&grant_type=authorization_code&redirect_uri=https://www.google.ba/&code=" + code));
            JsonObject value = JsonValue.Parse(response).GetObject();
            OAuthToken = value.GetNamedString("access_token");
        }
        //koristenje OAuthTokena da se dobije json response koji sadrzi sve venus
        public async void getVenus()
        {
            HttpClient httpClient = new HttpClient();
            string response = await httpClient.GetStringAsync(new Uri("https://api.foursquare.com/v2/venues/search?ll=43.9,17.7&categoryId=4bf58dd8d48988d17f941735&oauth_token=" + OAuthToken + "&v=20160410"));
            JsonObject value = JsonValue.Parse(response).GetObject();
            value.GetNamedString("venus");
        }
   
}
}
