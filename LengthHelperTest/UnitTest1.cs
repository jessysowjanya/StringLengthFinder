using Xunit;
using System;
using stringlengthHelper;

namespace LengthHelperTest
{
    public class UnitTest1
    {
       [Theory]
       [InlineData("123")]
       [InlineData("123456789010")]
       public void StringLength_WhenNumberGiven(string mystring)
       {
          Assert.Throws<InvalidOperationException>(() => LengthHelper.FindLength(mystring));
       }

       [Fact]
       public void StringLength_WhenEmptyStringGiven()
       {
            string length = "";
            Assert.Equal(0, LengthHelper.FindLength(length));
       }

       [Fact]
       public void StringLength_WhenNULLGiven()
       {
            string length = string.Empty;
            Assert.Equal(0, LengthHelper.FindLength(length));
       }      
    }
}

