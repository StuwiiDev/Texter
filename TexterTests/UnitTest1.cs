using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texter;

namespace Test_TXT
{
    [TestClass]
    public class UnitTest1
    {
        private const string OldFile = @"C:\test\sqlDeveloperOutput.txt";
        private const string NewFile = @"C:\test\tester.txt";


        [TestMethod]
        public void ExpectedOutput_OnFirstLine_IsCorrect()
        {
            // Arrange
            var firstLine = new NewStringText();           
            var expected = "13,L,LP,480,CC2801405000100,HID-PV 140/S CPO WHITE";
            // Act
            firstLine.ToTxt(OldFile, NewFile);
            // Test
            Assert.AreEqual(expected, firstLine.FirstLine);
        }

        [TestMethod]
        public void HasTheSameNumberOfLines_Input_Output()
        {
            // Arrange
            var numberOfLines = new NewStringText();
            var expected = 77;
            // Act
            numberOfLines.ToTxt(OldFile, NewFile);
            // Test
            Assert.AreEqual(expected, numberOfLines.NumberOfLines);
        }
    }
}
