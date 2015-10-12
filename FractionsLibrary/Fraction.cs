namespace FractionsLibrary
{
    using System;

    public class Fraction
    {
        public Fraction(int n, int d)
        {
            if (d == 0)
            {
                throw new ArgumentException();
            }

            if (n % d == 0)
            {
                this.Nominator = n / d;
                this.Denominator = 1;
            }
            else
            {
                this.Nominator = n;
                this.Denominator = d;
            }
        }

        public int Nominator { get; }

        public int Denominator { get; }

        public Fraction Add(Fraction fraction)
        {
            if (this.Denominator == fraction.Denominator)
            {
                return new Fraction(this.Nominator + fraction.Nominator, fraction.Denominator);
            }

            if (this.Denominator % fraction.Denominator == 0
                ||
                fraction.Denominator % this.Denominator == 0)
            {
                if (this.Denominator > fraction.Denominator)
                {
                    return this.Add(new Fraction(fraction.Nominator * (this.Denominator / fraction.Denominator), this.Denominator));
                }
                else
                {
                    return fraction.Add(new Fraction(this.Nominator * (fraction.Denominator / this.Denominator), fraction.Denominator));
                }
            }

            return new Fraction(this.Nominator * fraction.Denominator
                + fraction.Nominator * this.Denominator,
                this.Denominator * fraction.Denominator);

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