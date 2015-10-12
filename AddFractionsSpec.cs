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
}