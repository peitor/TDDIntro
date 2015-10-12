namespace FractionsLibrary
{
    public class Fraction
    {
        public Fraction(int n, int d)
        {
            this.Nominator = n;
            this.Denominator = d;
        }

        public int Nominator { get; }

        public int Denominator { get; }

        public Fraction Add(Fraction fraction)
        {
            return new Fraction(this.Nominator + fraction.Nominator, fraction.Denominator);
        }

        public override string ToString()
        {
            return Nominator + "/" + Denominator;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Fraction input = obj as Fraction;

            return input != null 
                && this.Nominator == input.Nominator
                && this.Denominator == input.Denominator;

        }

        public override int GetHashCode()
        {
            return this.Nominator ^ this.Denominator;
        }
    }
}