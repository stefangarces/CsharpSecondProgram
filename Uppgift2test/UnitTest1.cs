using System;
using Uppgift2.Calc;
using Xunit;

namespace Uppgift2test
{
    public class UnitTest1
    {
        /* Det absolut mest tidkrävande på hela inlämningsuppgiften.
         * Mycket huvudvärk för att få detta att gå ihop med "public class Comp",
         * och förstå vad man ska lägga till på "using". Känner att jag måste läsa
         * på mer och arbeta mer med tester för att få helt kläm på det. Min uppgift
         * kanske inte var bäst lämpad för test. Jag gjorde en class, "Comp", egentligen
         * för att få det att fungera med ett test på slutet av projektet.
         */

        [Fact]
        public void Add_MathTest()
        {
            // Arrange
            int expect = 25603;

            // act
            int actual = Comp.Add(2749, 22854);

            // Assert
            Assert.Equal(expect, actual);
        }
    }
}
