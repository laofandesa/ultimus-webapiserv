using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace TCC_CoreApi.Common.Tool
{
    public static class JsonSerializationExtension
    {
        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public static string ToJson<T>(this T toSerialize)
        {
            return JsonConvert.SerializeObject(toSerialize, JsonSerializerSettings);
        }

        public static T FromJson<T>(this T fromSerialize, string json)
        {
            return JsonConvert.DeserializeObject<T>(json, JsonSerializerSettings);
        }
    }
}
