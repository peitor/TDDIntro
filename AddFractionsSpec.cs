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

        // Kent Beck would write 2 PLUS 5 as 1st test
        //[Fact]
        //public void TwoPlusTen()
        //{
        //    Fraction sum = new Fraction(2).Plus(new Fraction(5));
        //    Assert.Equal(10, sum.IntegerValue);
        //}
    }
}