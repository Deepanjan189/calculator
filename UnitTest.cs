namespace TestProject
{
    public class StringCalculatorKata
    {
       
        [Test]
        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {
            Assert.AreEqual(5, StringCalculator.Add("5"));
        }
        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {
            Assert.AreEqual(0, StringCalculator.Add(string.Empty));
        }
        [Test]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "7,8";
            var expectedResult = 15;
            Assert.AreEqual(expectedResult, StringCalculator.Add(numbers));
        }

        //[Test]
        //public void Test2()
        //{
        //    Assert.Fail();
        //}

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [TestCase("1,2,3,4,5,-5")]
        [TestCase("-1,1,2,9")]
        [TestCase("5,6,8,-5")]
        public void Add_StringContainingNegativeNumbers_Throws(string numbers)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
        }

    }
}