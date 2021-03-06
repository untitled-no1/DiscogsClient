﻿using Newtonsoft.Json;
using System;
using System.Linq;

namespace DiscogsClient.Internal
{
    internal class DiscogsTimeSpanConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
                return null;

            var value = (string)reader.Value;
            var values = value.Split(':').Select(int.Parse).ToList();

            return new TimeSpan(0, values[0], values[1]);
        }

        public override bool CanRead => true;

        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan);
        }
    }
}
