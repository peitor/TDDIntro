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
                this.Numerator = n / d;
                this.Denominator = 1;
                return;
            }

            for (var i = d; i >= 2; i--)
            {
                if (n % i == 0 && d % i == 0)
                {
                    this.Numerator = n / i;
                    this.Denominator = d / i;
                    return;
                }
            }


            this.Numerator = n;
            this.Denominator = d;

        }

        public int Numerator { get; }

        public int Denominator { get; }

        public Fraction Add(Fraction fraction)
        {
            if (this.Denominator == fraction.Denominator)
            {
                return new Fraction(this.Numerator + fraction.Numerator, fraction.Denominator);
            }

            //if (this.Denominator % fraction.Denominator == 0
            //    ||
            //    fraction.Denominator % this.Denominator == 0)
            //{
            //    if (this.Denominator > fraction.Denominator)
            //    {
            //        return this.Add(new Fraction(fraction.Numerator * (this.Denominator / fraction.Denominator), this.Denominator));
            //    }
            //    else
            //    {
            //        return fraction.Add(new Fraction(this.Numerator * (fraction.Denominator / this.Denominator), fraction.Denominator));
            //    }
            //}

            return new Fraction(this.Numerator * fraction.Denominator
                + fraction.Numerator * this.Denominator,
                this.Denominator * fraction.Denominator);

        }

        public override string ToString()
        {
            return this.Numerator + "/" + Denominator;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Fraction input = obj as Fraction;

            return input != null
                && this.Numerator == input.Numerator
                && this.Denominator == input.Denominator;

        }

        public override int GetHashCode()
        {
            return this.Numerator ^ this.Denominator;
        }
    }
}