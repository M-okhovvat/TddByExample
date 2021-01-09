﻿using System.Collections.Generic;

namespace TddByExample.Domain
{
    public class Bank
    {
        private Dictionary<Pair, decimal> _rates = new Dictionary<Pair, decimal>();

        public Money Reduce(IMoneyExpression expression, string toCurrency)
        {

            return expression.Reduce(toCurrency, this);
        }

        public void AddRate(string from, string to, decimal rate)
        {
            var pair = new Pair(from, to);
            _rates.Add(pair, rate);
        }

        public decimal GetRate(string from, string to)
        {
            var key = new Pair(from, to);
            var rate = _rates.GetValueOrDefault(key);
            return rate;

        }
    }
}