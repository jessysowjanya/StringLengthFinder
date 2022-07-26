using Xunit;
using System;
using stringlengthHelper;
using System.Net;

namespace LengthHelperTest
{
    public class UnitTest1
    {
       [Theory]
       [InlineData("123")]
       public void StringLength_WhenNumberGiven(string mystring)
       {
          int length = LengthHelper.FindLength(mystring);
          Assert.Equal(3, length);
       }
        [Theory]
        [InlineData("123456789010")]
        public void StringLength_WhenStringNumberGiven(string mystring)
        {
            int length = LengthHelper.FindLength(mystring);
            Assert.Equal(12, length);
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

