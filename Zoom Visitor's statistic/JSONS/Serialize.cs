using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom_Visitor_s_statistic.JSONS
{
    public static class Serialize
    {
        public static string ToJson(this UserData self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
