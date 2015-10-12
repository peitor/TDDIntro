namespace FractionsLibrary
{
    public class Fraction
    {
        public Fraction(int n, int d)
        {
            this.Nominator = n;

        }

        public int Nominator { get; set; }

        public Fraction Add(Fraction fraction)
        {
            return new Fraction(this.Nominator + fraction.Nominator,0);
        }
    }
}