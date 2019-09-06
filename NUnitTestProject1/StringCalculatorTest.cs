using NUnit.Framework;
using System;
using System.Text;

namespace CodeKata
{
    [TestFixture]
    public class StringCalculatorTest
    {
      

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Sum_Empty_String_to_0()
        {
            var result  = StringCalculator.Sum("");

            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Calculating_One_Number_Should_Return_The_Same_Number()
        {
         
            var result = StringCalculator.Sum("3");

            Assert.That(result, Is.EqualTo(3)); 
        }

        [Test]
        public void Calculating_Two_Number_Should_Return_The_Sum_of_Those_numbers()
        {
            var result = StringCalculator.Sum("2/8");

            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Calculating_Amount_of_Numbers_Should_Return_Sum_All_the_Numbers()
        {
            var result = StringCalculator.Sum("1,2,3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Calculating_Multiple_Numbers_with_Line_and_Comma_Should_Return_Sum_All_Number()
        {
            var result = StringCalculator.Sum("1\n2,3");

            Assert.That(result, Is.EqualTo(6));
        }
        [Test]
        public void Calculating_Multiple_Numbers_with_Custom_Single_Character_Should_Return_Sum_All_Numbers()
        {
            var result = StringCalculator.Sum("//;\n1;2");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Calculating_One_Number_Negative_Should_Return_Throw_Exception()
        {
            Assert.That(() => StringCalculator.Sum("-1"), Throws.TypeOf<ArgumentOutOfRangeException>()
                                         .With
                                         .Message
                                         .EqualTo("negatives not allowed:\r\nParameter name: sumAllNumbers"));
        }

        [Test]
        public void Calculating_Input_Contains_Multiple_number_Negative_Should_Return_Throw_Exception()
        {

            Assert.That(() => StringCalculator.Sum("-1,-2,-3"), Throws.TypeOf<ArgumentOutOfRangeException>()
                               .With
                               .Message
                               .EqualTo("negatives not allowed:\r\nParameter name: sumAllNumbers"));

        }
        [Test]
        public void Calculating_Numbers_Large_Should_Return_The_Sum_Only_Numbers_Less()
        {
            var result = StringCalculator.Sum("1001,2");

            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Calculating_Numbers_Large_Should_Return_0_TheSum_Only_Number_Less()
        {
            var result = StringCalculator.Sum("1001,1002");

            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Calculating_Numbers_Should_Return_0_When_Numbers_Are_Letters()
        {
            var result = StringCalculator.Sum("M");

            Assert.That(result, Is.EqualTo(0));           

        }
        [Test]
        public void Calculating_The_Sum_with_One_Character_Delimiter()
        {
            var result = StringCalculator.Sum("//[***]\n12***3");

            Assert.That(result, Is.EqualTo(6));

        }

        [Test]
        public void Calculating_The_Sum_with_Multiples_Character_Delimiters()
        {
            var result = StringCalculator.Sum("//[][%]\n1*2%3");

            Assert.That(result, Is.EqualTo(6));

        }

    }
}
