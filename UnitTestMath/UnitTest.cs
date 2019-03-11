
using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTest.Model;

namespace UnitTestMath
{
    [TestClass]
    public class UnitTest1
    {
        //test methode attribute, test methode must return void and can not have parameters
        //must be in a class with test class attribute.
        [TestMethod] 
        public void TestMethod1()
        {
            Assert.AreEqual(0, 0); // assert class: if the condition not met , an exeption is thrown
        }

        [TestMethod]
        public void RootTest()
        {
            Rooter rooter = new Rooter();
            double expected = 1;
            double actual = rooter.SquareRooter(expected * expected);
            Assert.AreEqual(expected, actual); // assert class: if the condition not met , an exeption is thrown
        }

        [TestMethod]
        public void AddSubTest()
        {
            AddSub addSub = new AddSub();
            int expected = 10;
            int actual = addSub.Cal_AddSub(5, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PersonTest0_1()
        {
            Person person = new Person();
            Assert.IsInstanceOfType(person,typeof(Person));
        }

        [TestMethod]
        public void PersonTest()
        {
            string message;
            Person person;
            int ID = 100;
            string Name = "Hello";
            int Phone = 66666666;
            try
            {
               
                // should raise an exeption
                person = new Person(ID,Name,Phone);
                message = String.Format("No exception for input {0}{1}{2}", ID,Name,Phone);
                Assert.Fail(message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // correct exeption
            }
            catch (Exception e)
            {
                message = String.Format("Incorrect exception for {0}{1}{2}", ID,Name,Phone);
                Assert.Fail(message);
            }

        }
    }
}
