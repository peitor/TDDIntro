namespace Specs
{
    using System;

    using FractionsLibrary;

    using NUnit.Framework;

    public class AddFractionsSpec
    {
        // TODO LIST
        // 0/1 + 0/2 = 0/??   0 nominator addition
        // 1/1 + 1/1 = 2/1    1 denominator addition
        // 1/4 + 2/4 = 3/4    same denominator
        // 1/3 + 2/3 = 3/3    result full number
        // 1/2 + 1/3 = 5/6    
        // 7/3 + 4/5 = 47/15  complex example, no simplification
        // 3/3 + 4/4 = ??     whole numbers, expressed as fraction
        // 3 + 4 = 7          whole integers  
        // 5/2 +           
        // 1/3 + 1/2 = 5/6    denominator expansion
        // 1/0 ??             Error - 0 division
        // 2 1/2 ??           Error - not allowed


        [ExpectedException(typeof(ArgumentException))]
        [Test]
        public void ShouldThrow_WhenDenominator0()
        {
            new Fraction(1, 0);
        }

        [Test]
        public void ShouldReturn0_WhenAdding0()
        {
            // 0/3 + 0/4 = 0
            Fraction sum = new Fraction(0, 1).Add(new Fraction(0, 1));
            Assert.AreEqual(0, sum.Nominator);
        }

        [Test]
        public void ShouldSum_WhenDenominator1()
        {
            Fraction sum = new Fraction(1, 1).Add(new Fraction(1, 1));
            Assert.AreEqual(2, sum.Nominator);
        }


        [Test]
        public void ShouldSum_WhenDenominatorSame()
        {
            Fraction sum = new Fraction(1, 3).Add(new Fraction(1, 3));
            Assert.AreEqual(new Fraction(2, 3), sum);
        }

        [Test]
        public void ShouldSum_WhenDenominatorSame_Complex()
        {
            Fraction sum = new Fraction(1, 4).Add(new Fraction(2, 4));
            Assert.AreEqual(new Fraction(3, 4), sum);
        }

        [Test]
        public void ShouldKeepDenominator_WhenDenominatorSame()
        {
            Fraction sum = new Fraction(1, 4).Add(new Fraction(2, 4));
            Assert.AreEqual(4, sum.Denominator);
        }

        [Test]
        public void ShouldExpandDenominator_WhenDenominatorsAreNotSame_Simple2()
        {
            Fraction sum = new Fraction(1, 6).Add(new Fraction(1, 2));
            Assert.AreEqual(new Fraction(4, 6), sum);
        }

        [Test]
        public void ShouldExpandDenominator_WhenDenominatorsAreNotSame()
        {
            // 1 / 2 + 1 / 6 = 4 / 6
            var sum = new Fraction(1, 2).Add(new Fraction(1, 6));
            Assert.AreEqual(new Fraction(4, 6), sum);
        }

        [Test]
        public void ShouldExpandDenominator_WhenDenominatorsAreNotSame_NoEasyDenominator()
        {
            // 1 / 2 + 1 / 3 = 5 / 6
            Fraction sum = new Fraction(1, 2).Add(new Fraction(1, 3));
            Assert.AreEqual(new Fraction(5, 6), sum);
        }


        [Test]
        public void Should_ReturnNumber_When_PassingComplexFractions()
        {
            // 7/3 + 4/5 = 47/15  complex example, no simplification
            Fraction sum = new Fraction(7, 3).Add(new Fraction(4, 5));
            Assert.AreEqual(new Fraction(47, 15), sum);
        }

        [Test]
        public void Should_ReturnSimplified_WhenPossible()
        {
            // 3/3 + 4/4 = 2/1 and not 24/12     whole numbers, expressed as fraction
            Fraction sum = new Fraction(3, 3).Add(new Fraction(4, 4));
            Assert.AreEqual(new Fraction(2, 1), sum);

        }

        [Test]
        public void Should_Simplify_When_LargerNominator()
        {
            var f = new Fraction(8, 4);
            Assert.AreEqual(new Fraction(2,1 ), f);
        }


        [Test]
        public void Should_Simplify_When_LargerDenominator()
        {
            Assert.Inconclusive();
            var f = new Fraction(4, 8);
            Assert.AreEqual(new Fraction(1, 2), f);
        }

        [Test]
        public void Should_Simplify_When_PassingPotential()
        {
            Assert.Inconclusive();
            var f = new Fraction(4, 6);
            Assert.AreEqual(new Fraction(2, 3), f);
        }

        [Test]
        public void ToString_NiceString()
        {
            Assert.Inconclusive();
            Assert.AreEqual("2 / 5", new Fraction(2, 5).ToString());
        }


        [Test]
        public void Should_ReturnDifferentHashCode_When_ProvidingDifferentFractions()
        {
            Assert.AreNotEqual(new Fraction(1, 2), new Fraction(1, 3));
            Assert.AreNotEqual(new Fraction(1, 2), new Fraction(2, 2));
        }

        [Test]
        public void Should_ReturnSameHashCode_When_ProvidingSameFractions()
        {
            Assert.AreEqual(new Fraction(1, 2), new Fraction(1, 2));
            Assert.AreEqual(new Fraction(2, 3), new Fraction(2, 3));
        }
    }
}