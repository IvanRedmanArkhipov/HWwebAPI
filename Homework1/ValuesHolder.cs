using System.Text.Json;
using System.IO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Homework1;

namespace Homework1
{
    public class ValuesHolder
    {
        private ConcurrentDictionary<DateTime, WeatherValue> input;
        public ValuesHolder()
        {
            input = new ConcurrentDictionary<DateTime, WeatherValue>();
        }

        public ICollection<WeatherValue> Get() => input.Values;

        public WeatherValue Get(DateTime date) =>
            input.TryGetValue(date, out var value) ? value : null;

        public void Add(WeatherValue value)
        {
            input.TryAdd(value.Date, value);
        }

        public bool Update(DateTime date, float newValue)
        {
            if (!input.TryGetValue(date, out var item))
                return false;
            item.Temp = newValue;
            return true;
        }

        public bool Remove(DateTime date)
        {
            return input.TryRemove(date, out _);
        }
    }
}
