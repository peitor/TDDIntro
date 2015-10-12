namespace Specs
{
    using Xunit;

    public class AddFractionsSpec
    {
        [Fact]
        public void ZeroPlusZero()
        {
            Fraction sum = new Fraction(0).Plus(new Fraction(0));
            Assert.Equal(0, sum.IntegerValue);
        }
    }

    public class Fraction
    {
        public Fraction(int init)
        {
            
        }

        public int IntegerValue { get; set; }

        public Fraction Plus(Fraction fraction)
        {
            return new Fraction(0);
        }
    }
}
