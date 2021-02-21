using System;
using NUnit.Framework;
using Assignment1QA;

namespace Assignment1Test
{
    public class TestClass
    {
        [SetUp]
        public void Setup()
        {
            TestGetLenght();
            TestChangeLenght();
            TestGetWidth();
            TestChangeWidth();
            TestChangeWidth();
            TestGetArea();
        }

        [Test]
        public void TestGetLenght()
        {
            Rectangle r = new Rectangle();
            int lenght = r.GetLenght();
            Assert.AreEqual(1, lenght);
        }

        [Test]
        public void TestChangeLenght()
        {
            Rectangle r = new Rectangle();
            int lenght = r.SetLength(5);

            Assert.AreNotEqual(1, lenght);
        }

        [Test]
        public void TestGetWidth()
        {
            Rectangle r = new Rectangle();
            int width = r.GetWidth();

            Assert.AreEqual(1, width);
        }

        [Test]
        public void TestChangeWidth()
        {
            Rectangle r = new Rectangle();
            int width = r.SetWidth(5);

            Assert.AreNotEqual(1, width);
        }

        [Test]
        public void TestGetPerimeter()
        {
            //default data
            Rectangle r = new Rectangle();
            int per = r.GetPerimeter();

            Assert.AreEqual(4, per);



        }

        [Test]
        public void TestGetArea()
        {
            //default data
            Rectangle r = new Rectangle();
            int area = r.GetArea();

            Assert.AreEqual(1, area);
        }
    }
}
