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
        public Calculator calculator { get; set; }

        public CalculatorTest()
        {
            this.calculator = new Calculator();    
        }
        [Fact]
        public void AddTest()
        {
            #region Arrenge (initialize ve instance)

            ////Arrange
            //int a = 5;
            //int b = 20;

            //var calculator = new Calculator();
            #endregion

            #region Act (aksiyon. method kullanılır)

            ////Act

            //var total = calculator.Add(a, b);
            #endregion

            #region Assert (Assert methodlarıya değerlendirme yapılır)
            ////Assert
            ///

            #region Equal / NotEqual
            //Assert.Equal<int>(25,calculator.Add(20,5) );
            //Assert.NotEqual<int>(25, total);
            #endregion

            #region Contains / DoesNotContain
            //Assert.Contains("Murat", "Murat Cengiz");
            //Assert.DoesNotContain("Emre", "Murat Cengiz");
            //var names = new List<string> { "Murat", "Emre", "Hasan" };
            //Assert.DoesNotContain(names, x => x == "Hakan");
            #endregion

            #region True / False
            //Assert.True(5 > 2);
            //Assert.False(5 < 2);
            //Assert.True("".GetType()==typeof(string));
            #endregion

            #region Regex Mathces / DoesNotMatch
            //var regEx = "cat$";
            //Assert.Matches(regEx, "cat dog cat");
            //Assert.Matches(regEx, "cat dog cat");
            #endregion

            #region StartsWith / EndsWith
            //var _string = "Günaydın Murat Cengiz";
            //Assert.EndsWith("t Cengiz",_string);
            //Assert.StartsWith("Günaydın M", _string);
            #endregion
            #region Empty / NotEmpty
            //var myList = new List<int>() {1};
            //Assert.Empty(myList);
            //Assert.NotEmpty(myList);
            #endregion

            #region InRange / NotInRange

            //Assert.InRange(10, 2, 20);
            //Assert.NotInRange(25, 2, 20);
            #endregion

            #region Single

            //Assert.Single<int>(new List<int>() { 2});
            #endregion

            #region IsType / IsNotType

            //Assert.IsType<string>("Murat");
            //Assert.IsNotType<string>(1);

            #endregion

            #region IsAssignableFrom

            //Assert.IsAssignableFrom<IEnumerable<string>> (new List<string>());
            //Assert.IsAssignableFrom<Object>("Murat");
            #endregion

            #region Null / NotNull

            string deger = null;
            Assert.Null(deger);
            #endregion



            #endregion


        }


        [Theory]
        [InlineData(2,5,7)]
        [InlineData(12,5,17)]
        public void TestWithParameter(int a, int b, int expectedTotal)
        {
           

            Assert.Equal(expectedTotal, calculator.Add(a,b));
        }

        [Theory]
        [InlineData(3,5,15)]
        [InlineData(4,8,32)]

        public void Multiplicate_simpleValues_ReturnMultiplicationValue(int a, int b, int expectedMultiplication)
        {
            Assert.Equal(expectedMultiplication, calculator.Multiplicate(a, b));
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(14, 0, 0)]

        public void Multiplicate_zeroValues_ReturnMultiplicationValue(int a, int b, int expectedMultiplication)
        {
            Assert.Equal(expectedMultiplication, calculator.Multiplicate(a, b));
        }
    }
}
