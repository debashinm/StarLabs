using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace AddItemToBasket
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addItem()
        {
            //Assign
            var T = new Tshirt();
            int expected = 20;
            T.Size = "m";


            //Act    
            int actual = T.GetTotal();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
