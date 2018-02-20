using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestprogram
    {
        [TestMethod]
        public void input_s_in_correct_type_of_character()
        {
            // arrange
            string s = "string not character";
            bool expected = false;
            //act
            Painter paint = new Painter();
            bool pr = paint.Read(s);
            //assert

            Assert.AreEqual(expected, pr);
        }

        [TestMethod]
        public void input_s_in_inccorrect_character_1()
        {
            // arrange
            string s = "s";
            bool expected = false;
            //act
            Painter paint = new Painter();
            bool pr = paint.Read(s);
            //assert

            Assert.AreEqual(expected, pr);

        }

        [TestMethod]
        public void input_s_in_inccorrect_character_2()
        {
            // arrange
            string s = "1";
            bool expected = false;
            //act
            Painter paint = new Painter();
            bool pr = paint.Read(s);
            //assert

            Assert.AreEqual(expected, pr);

        }

        [TestMethod]
        public void input_s_in_inccorrect_character_3()
        {
            // arrange
            string s = "ф";
            bool expected = false;
            //act
            Painter paint = new Painter();
            bool pr = paint.Read(s);
            //assert

            Assert.AreEqual(expected, pr);

        }

        [TestMethod]
        public void input_s_in_correct_character()
        {
            // arrange
            string s = "D";
            bool expected = true;
            //act
            Painter paint = new Painter();
            bool pr = paint.Read(s);
            //assert

            Assert.AreEqual(expected, pr);

        }
    }
}
