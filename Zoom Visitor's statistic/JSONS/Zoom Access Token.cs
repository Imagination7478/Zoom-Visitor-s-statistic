using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Zoom_Visitor_s_statistic.JSONS
{
    public partial class ZoomAccessToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public partial class ZoomAccessToken
    {
        public static ZoomAccessToken FromJson(string json) => JsonConvert.DeserializeObject<ZoomAccessToken>(json, Converter.Settings);
    }
}
