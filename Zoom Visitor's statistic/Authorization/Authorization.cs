using Leaf.xNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom_Visitor_s_statistic.JSONS;

namespace Zoom_Visitor_s_statistic.Authorization
{
    public class Authorization
    {
        public string autorize(int flag, string url)
        {

            using (var request = new HttpRequest())
            {
                request.ConnectTimeout = 180000;

                string content = request.Get(
                    $"https://localhost:44353/autorize/{flag}?url={url}").ToString();

                if (content == "1") { return "1"; }
                else return content;
            }
        }
    }
}
