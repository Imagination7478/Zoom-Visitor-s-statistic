using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Zoom_Visitor_s_statistic.JSONS
{
    public partial class UserData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("role_name")]
        public string RoleName { get; set; }

        [JsonProperty("pmi")]
        public long Pmi { get; set; }

        [JsonProperty("use_pmi")]
        public bool UsePmi { get; set; }

        [JsonProperty("vanity_url")]
        public Uri VanityUrl { get; set; }

        [JsonProperty("personal_meeting_url")]
        public Uri PersonalMeetingUrl { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("verified")]
        public long Verified { get; set; }

        [JsonProperty("dept")]
        public string Dept { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("last_login_time")]
        public DateTimeOffset LastLoginTime { get; set; }

        [JsonProperty("last_client_version")]
        public string LastClientVersion { get; set; }

        [JsonProperty("pic_url")]
        public Uri PicUrl { get; set; }

        [JsonProperty("host_key")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long HostKey { get; set; }

        [JsonProperty("jid")]
        public string Jid { get; set; }

        [JsonProperty("group_ids")]
        public List<object> GroupIds { get; set; }

        [JsonProperty("im_group_ids")]
        public List<string> ImGroupIds { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("phone_country")]
        public string PhoneCountry { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("Access_token")]
        public string AccessToken { get; set; }
    }

    public partial class UserData
    {
        public static UserData FromJson(string json) => JsonConvert.DeserializeObject<UserData>(json, Converter.Settings);
    }

    

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
