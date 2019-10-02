using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class Tests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {

            //Arrange
            _calculator = new Calculator();
        }

        //[Test]
        //public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        //{
        //    // Act 
        //    double result = _calculator.Add(10, 20);
        //    // Assert 
        //    Assert.That(result, Is.EqualTo(30));
        //}
        //[Test]

        //public void Add_WhenAddingTwoNagativeNumbers_ResultEqualToSum()
        //{
        //    // Act 
        //    double result = _calculator.Add(10, -10);
        //    // Assert 
        //    Assert.That(result, Is.EqualTo(0));
        //}
        //[Test]
        //public void Add_WhenAddingOneZeroNumbers_ResultEqualToSum()
        //{
        //    // Act 
        //    double result = _calculator.Add(0, 0);
        //    // Assert 
        //    Assert.That(result, Is.EqualTo(0));
        //}
        //[Test]
        //public void Add_WhenSubtractOneZeroNumbers_ResultEqualToSum()
        //{
        //    // Act 
        //    double result = _calculator.Subtract(0, 10);
        //    // Assert 
        //    Assert.That(result, Is.EqualTo(-10));
        //}

        //[Test]
        //public void Add_WhenMutltOneZeroNumbers_ResultEqualToSum()
        //{
        //    // Act 
        //    double result = _calculator.Multiply(10, 0);
        //    // Assert 
        //    Assert.That(result, Is.EqualTo(0));
        //}
        //[Test]
        //public void Divide_WithNegativeInputs_ResultThrowArgumentException()
        //{
        //    Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        //}

        //[Test]
        //[TestCase(0, 0)]
        //[TestCase(0, 10)]
        //[TestCase(10, 0)]
        //public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        //{
        //    Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        //}
        //[Test]
        //public void AreaOfTri_WhenCalculatingAreaTriWtihTwoNumbers_ResultEqualToSum()
        //{

        //    double result = _calculator.areaOfTriangle(5, 1);
        //    Assert.That(result, Is.EqualTo(2.5));
        //}
        //[Test]

        //public void AreaOfCrile_WhenCalculateAreaOfCricleWtihTwoNumbers_ResultEqualToSum()
        //{

        //    double result = _calculator.AOC(5);
        //    Assert.That(result, Is.EqualTo(78.54));
        //}
        //[Test]
        //public void UnknownFunctionA_WhenGivenTest0_Result()
        //{
        //    // Act double result = _calculator.UnknownFunctionA(5, 5); // Assert Assert.That(result, Is.EqualTo(1));
        //}
        //[Test]
        //public void UnknownFunctionA_WhenGivenTest1_Result()
        //{
        //    // Act double result = _calculator.UnknownFunctionA(5, 4); // Assert Assert.That(result, Is.EqualTo(5));
        //}
        //[Test]
        //public void UnknownFunctionA_WhenGivenTest2_Result()
        //{
        //    // Act double result = _calculator.UnknownFunctionA(5, 3); // Assert Assert.That(result, Is.EqualTo(10));
        //}
        //[Test]
        //public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        //{
        //    // Act // Assert Assert.That(() => _calculator.UnknownFunctionA(-4,5), Throws.ArgumentException);
        //}
        //[Test]
        //public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        //{
        //    // Act // Assert Assert.That(() => _calculator.UnknownFunctionA(4,5), Throws.ArgumentException);
        //}


    }
}