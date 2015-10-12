namespace Specs
{
    using FractionsLibrary;

    using NUnit.Framework;

    public class AddFractionsSpec
    {
        // 0/1 + 0/2 = 0/??   0 nominator addition
        // 1/3 + 1/3 = 2/3    simple test 
        // 1/4 + 2/4 = 3/4    same denominator
        // 1/3 + 2/3 = 3/3    result full number
        // 1/2 + 1/3 = 5/6    same nominator
        // 7/3 + 4/5 = 47/15  complex example, no simplification
        // 3/3 + 4/4 = ??     whole numbers, expressed as fraction
        // 3 + 4 = 7          whole integers  
        // 5/2 +           
        // 1/3 + 1/2 = 5/6    denominator expansion
        // 1/0 ??             Error - 0 division
        // 2 1/2 ??           Error - not allowed


        [Test]
        public void ZeroPlusZero_0NominatorAddition()
        {
            // 0/3 + 0/4 = 0
            Fraction sum = new Fraction(0,3).Add(new Fraction(0,4));
            Assert.AreEqual(0, sum.Nominator);
        }


        [Test]
        public void Same_Denominator()
        {
            // 1 / 4 + 2 / 4 = 3 / 4    same denominator
            Assert.Inconclusive();
        }

    }
}