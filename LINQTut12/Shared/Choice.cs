namespace Shared
{
    public class Choice
    {
        public int Order { get; set; }
        public string Description { get; set; }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            var other = obj as Choice; // (Choise)obj

            return this.Order == other.Order
                && this.Description.Equals(other.Description);
        }

        public override int GetHashCode()
        {
            int hash = 7;
            //check null

            hash = hash * 23 + this.Order.GetHashCode();
            hash = hash * 23 + this.Description.GetHashCode();

            return hash;
        }
    }
}