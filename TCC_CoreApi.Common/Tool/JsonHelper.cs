using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TCC_CoreApi.Common.Tool
{
    public class JsonHelper
    {
        /// <summary>
        /// 序列化为json
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string SerializeObject(object source)
        {
            string json = string.Empty;
            IsoDateTimeConverter dateFomatter = new IsoDateTimeConverter();
            dateFomatter.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            json = JsonConvert.SerializeObject(source, Formatting.Indented, dateFomatter);

            return json;
        }

        /// <summary>
        /// 反序列化为对象
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static Tresult DeserializeObject<Tresult>(string json)
        {
            return JsonConvert.DeserializeObject<Tresult>(json);
        }
    }
}
