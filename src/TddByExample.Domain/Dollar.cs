﻿namespace TddByExample.Domain
{
    public class Dollar
    {
        private int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            return _amount == ((Dollar)obj)._amount;
        }
    }
}