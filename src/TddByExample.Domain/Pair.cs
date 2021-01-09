namespace TddByExample.Domain
{
    public class Pair
    {
        private string _from;
        private string _to;

        public Pair(string from, string to)
        {
            _from = from;
            _to = to;
        }

        public override bool Equals(object other)
        {

            if (this == other)
                return true;

            if (other == null)
                return false;

            if (!(other is Pair))
                return false;

            var pair = (Pair)other;
            return _from == pair._from && _to == pair._to;

        }

        public static bool operator ==(Pair obj1, Pair obj2)
        {
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Pair obj1, Pair obj2)
        {
            return !(obj1 == obj2);
        }


        public override int GetHashCode()
        {
            return 0;

        }
    }
}