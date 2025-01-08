using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.App;

namespace UnitTest.Test
{
    public class CalculatorTest
    {
        public Calculator calculator;
        public Mock<ICalculatorService> myMock;

        public CalculatorTest()
        {
            myMock = new Mock<ICalculatorService>();
            calculator =new Calculator(myMock.Object);
        }

        [Fact]
        public void AddTest()
        {
            ////Arrange

            //int a = 5, b = 20;
            //Calculator calculator = new();

            ////Act

            //var value = calculator.Add(a, b);

            ////Assert

            //Assert.Equal<int>(25, value);

            //Assert.Contains("Murat", "Murat Cengiz");
            //Assert.DoesNotContain("Emre", "Murat");

            //List<string> list = new() { "Murat","Fatih","Cengiz"};
            //Assert.Contains("Murat", list);

            //Assert.True(5<7);
            //Assert.False(5<3);

            //Assert.Matches("^dog", "dogqwe");
            //Assert.Matches("dog$", "asdasddog");
            //Assert.DoesNotMatch("^dog", "qweqwe");

            //Assert.StartsWith("murat", "muratcengiz");
            //Assert.EndsWith("cengiz", "muratcengiz");

            //List<int> list = new();
            //Assert.Empty(list);
            //Assert.NotEmpty(list); //fail

            //Assert.InRange(34, 30, 50);
            //Assert.NotInRange(45, 30, 40);

            //List<int> list = new() { 1};
            //Assert.Single(list);

            //int a = 3;
            //string b = "123";
            //Assert.IsType<int>(a);
            //Assert.IsNotType<int>(b);

            //Assert.IsAssignableFrom<List<int>>(new List<int> { 1, 2, 3, });
            //string[] arr = {"1"};
            //Assert.IsNotAssignableFrom<IEnumerable<int>>(arr);


            //string value = null;
            //Assert.Null(value);

        }

        [Theory]
        [InlineData(2,5,7)]
        [InlineData(5,8,13)]
        public void AddTest2(int a,int b,int expectedTotal)
        {
            myMock.Setup(x=>x.Add(a,b)).Returns(expectedTotal);
            

            var actualTotal = calculator.Add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
        }
        [Theory]
        [InlineData(2,5,7)]
        [InlineData(8,2,10)]
        [InlineData(12,13,25)]
        public void Add_SimpleValues_ReturnTotalValue(int a,int b, int expectedTotal)
        {
            myMock.Setup(x => x.Add(a, b)).Returns(expectedTotal);

            var actualTotal = calculator.Add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
            myMock.Verify(x => x.Add(a, b), Times.Once);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(8, 0, 0)]
        public void Add_ZeroValues_ReturnZeroValue(int a, int b, int expectedTotal)
        {
            myMock.Setup(x => x.Add(a, b)).Returns(expectedTotal);
            var actualTotal = calculator.Add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(3,5,15)]
        public void Multip_SimpleValues_ReturnsMultipValur(int a,int b, int expectedValue)
        {
            int actualMultip =0;
            myMock.Setup(x => x.Multip(It.IsAny<int>(),It.IsAny<int>())).Callback<int,int>((x,y)=>actualMultip=x*y);
            calculator.Multip(a, b);
            Assert.Equal(expectedValue, actualMultip);

            calculator.Multip(5, 20);
            Assert.Equal(100, actualMultip);
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(4,0)]
        public void Multip_ZeroValues_ReturnsException(int a, int b)
        {
            myMock.Setup(x => x.Multip(a, b)).Throws(new Exception("a veya b 0 olamaz"));

            Exception exception = Assert.Throws<Exception>(() => calculator.Multip(a, b));
            Assert.Equal("a veya b 0 olamaz", exception.Message);
        }

    }
}
