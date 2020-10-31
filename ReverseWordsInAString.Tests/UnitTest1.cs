using NUnit.Framework;

namespace ReverseWordsInAString.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var Reverser = new Reverser();
        }

        [Test]
        public void Test1()
        {
            const string expected = "blue is sky the";
            string result = Reverser.ReverseWords("the sky is blue");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            const string expected = "world hello";
            string result = Reverser.ReverseWords("  hello world  ");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {
            const string expected = "example good a";
            string result = Reverser.ReverseWords("a good   example");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test4()
        {
            const string expected = "Alice Loves Bob";
            string result = Reverser.ReverseWords("  Bob    Loves  Alice   ");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test5()
        {
            const string expected = "bob like even not does Alice";
            string result = Reverser.ReverseWords("Alice does not even like bob");
            Assert.AreEqual(expected, result);
        }
    }
}