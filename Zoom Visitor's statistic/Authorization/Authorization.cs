using Leaf.xNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom_Visitor_s_statistic.JSONS;

namespace Zoom_Visitor_s_statistic.Authorization
{
    public class Authorization
    {
        public void autorize(string AccessCode, string url)
        {
            ZoomAccessToken parsedZoomAccessToken;
            using (var request = new HttpRequest())
            {
                var reqParams = new RequestParams();

                request.AddHeader("Authorization", "Basic a3FUQVFGZ1ZRaHVaVExyUmxFNko0QTplN2luRzVQVzBnUng1ZmYzb1VKSm9FeTJ0MzdWUms2VQ==");
                request.AddHeader("Content-Type:", "application/x-www-form-urlencoded");

                reqParams["code"] = AccessCode;
                reqParams["grant_type"] = "authorization_code";
                reqParams["code_verifier"] = "1111"; // ПОЛУЧЕНИЕ CODE_VERIFIER И CODE CHALLENGE ИЗМЕНИТЬ НА РАНДОМНЫЕ, НО ОДИНАКОВЫЕ
                reqParams["redirect_uri"] = url;

                //TODO: Хранить все access_token на сервере в бд,
                //идти по токенам циклом, если находится необходимый токен, 
                //у которого совпадают code_challenge и code_verifier, то делается запрос на Authentication

                string content = request.Post(
                    "https://zoom.us/oauth/token", reqParams).ToString();

                parsedZoomAccessToken = ZoomAccessToken.FromJson(content);


            }
            
            UserData parsedUserData;
            using (var request = new HttpRequest())
            {
                var reqParams = new RequestParams();

                request.AddHeader("Authorization", $"Bearer {parsedZoomAccessToken.AccessToken}");

                string content = request.Get(
                    "https://api.zoom.us/v2/users/me", reqParams).ToString();

                parsedUserData = UserData.FromJson(content);
            }
        }
    }
}
