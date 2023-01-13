using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathSample;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorAddTests
    {
        [TestMethod]
        public void Add_WhenBothPositive_ReturnSum()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Add(1, 2);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Add_WhenAddendPosAugendNeg_ReturnDifferenceWithNegatedAugend()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Add(3, -2);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Add_WhenAddendNegAugendPos_ReturnDifferenceWithNegatedAddendAndSwitchedElements()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Add(-3, 5);

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Add_WhenBothNegative_ReturnNegativeSumWithNegatedElements()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Add(-3, -5);

            //Assert
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void Add_WhenAddendNegAugendPosAugendGreaterThanNegatedAddend_SumGreaterThanZero()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Add(-3, 5);

            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Add_WhenAddendPosAugendNegNegatedAugendGreaterThanAddend_SumLesserThanZero()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Add(3, -5);

            //Assert
            Assert.IsTrue(result < 0);
        }
    }

    [TestClass]
    public class CalculatorSubtractTests
    {
        [TestMethod]
        public void Subtract_WhenBothPositive_ReturnDifference()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Subtract(3, 2);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Subtract_WhenMinuendPosSubtrahendNeg_ReturnSumWithNegatedSubtrahend()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Subtract(3, -2);

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_WhenMinuendNegSubtrahendPos_ReturnNegatedSumWithNegatedMinuend()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Subtract(-3, 5);

            //Assert
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void Subtract_WhenBothNegative_ReturnNegatedDifferenceWithNegatedElements()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Subtract(-3, -5);

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Subtract_WhenBothPosSubtrahendGreaterThanMinuend_DifferenceLesserThanZero()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Subtract(3, 5);

            //Assert
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void Subtract_WhenBothNegSubtrahendLesserThanMinuend_DifferenceGreaterThanZero()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Subtract(-3, -5);

            //Assert
            Assert.IsTrue(result > 0);
        }
    }

    [TestClass]
    public class CalculatorMultiplyTests
    {
        [TestMethod]
        public void Multiply_WhenBothPositive_ReturnProduct()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Multiply(3, 4);

            //Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Multiply_WhenMultiplicandPosMultiplierNeg_ReturnNegativeProduct()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Multiply(3, -2);

            //Assert
            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void Multiply_WhenMultiplicandNegMultiplierPos_ReturnNegativeProduct()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Multiply(-3, 5);

            //Assert
            Assert.AreEqual(-15, result);
        }

        [TestMethod]
        public void Multiply_WhenBothNegative_ReturnPositiveProduct()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Multiply(-3, -5);

            //Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Multiply_WhenFactorsSwitched_ProductsAreEqual()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result1 = calculator.Multiply(3, 5);
            var result2 = calculator.Multiply(5, 3);

            //Assert
            Assert.AreEqual(result1, result2);
        }
    }

    [TestClass]
    public class CalculatorDivideTests
    {
        [TestMethod]
        public void Divide_WhenBothPositive_ReturnQuotient()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Divide(12, 4);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Divide_WhenDividendPosDivisorNeg_ReturnNegativeQuotient()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Divide(6, -2);

            //Assert
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void Divide_WhenDividendNegDivisorPos_ReturnNegativeQuotient()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Divide(-10, 5);

            //Assert
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Divide_WhenBothNegative_ReturnPositiveQuotient()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Divide(-15, -5);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Divide_WhenElementsSwitched_QuotientsAreNotEqual()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result1 = calculator.Divide(10, 5);
            var result2 = calculator.Divide(5, 10);

            //Assert
            Assert.AreNotEqual(result1, result2);
        }

        [TestMethod]
        public void Divide_WhenDivisorEqualsZero_ThrowArithmeticException()
        {
            //Arrange
            var calculator = new Calculator();

            //Act and Assert
            Assert.ThrowsException<System.ArithmeticException>(() => calculator.Divide(10, 0));
        }
    }

    [TestClass]
    public class CalculatorPowerTests
    {
        [TestMethod]
        public void Power_WhenBothPositive_ReturnPower()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Power(3, 4);

            //Assert
            Assert.AreEqual(81, result);
        }

        [TestMethod]
        public void Power_WhenBaseNegExponentEven_ReturnPositivePower()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Power(-6, 2);

            //Assert
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void Power_WhenBaseNegExponentOdd_ReturnNegativePower()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Power(-6, 3);

            //Assert
            Assert.AreEqual(-216, result);
        }

        [TestMethod]
        public void Power_WhenBasePosExponentNeg_ReturnDivisionPower()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Power(2, -4);

            //Assert
            Assert.AreEqual(0.0625, result);
        }

        [TestMethod]
        public void Power_WhenBaseNegExponentNegAndEven_ReturnPosDivisionPower()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Power(-2, -4);

            //Assert
            Assert.AreEqual(0.0625, result);
        }

        [TestMethod]
        public void Power_WhenBaseNegExponentNegAndOdd_ReturnNegDivisionPower()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Power(-2, -3);

            //Assert
            Assert.AreEqual(-0.125, result);
        }

        [TestMethod]
        public void Power_WhenExponentZero_ReturnOne()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Power(6, 0);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Power_WhenExponentOne_ReturnBase()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Power(-8, 1);

            //Assert
            Assert.AreEqual(-8, result);
        }
    }

    [TestClass]
    public class CalculatorRootTests
    {
        [TestMethod]
        public void Root_WhenBothPositive_ReturnRoot()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Root(9, 2);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Root_WhenRadicantNeg_ThrowArithmeticException()
        {
            //Arrange
            var calculator = new Calculator();

            //Act and Assert
            Assert.ThrowsException<System.ArithmeticException>(() => calculator.Root(-8, 3));
        }

        [TestMethod]
        public void Root_WhenDegreeNeg_ReturnReciprocalRootWithNegatedDegree()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Root(16, -4);

            //Assert
            Assert.AreEqual(0.5, result);
        }
    }
}
