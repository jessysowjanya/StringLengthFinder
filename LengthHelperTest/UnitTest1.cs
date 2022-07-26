using Xunit;
using System;
using stringlengthHelper;
using System.Net;

namespace LengthHelperTest
{
    public class UnitTest1
    {
       [Theory]
       [InlineData("123",3)]
       [InlineData("123456789010",12)]
       public void StringLength_WhenNumberGiven(string mystring, int expected)
       {
          var length = LengthHelper.FindLength(mystring);
          Assert.Equal(expected, length);
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

