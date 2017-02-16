using NUnit.Framework;

namespace ConsoleApplication
{
    [TestFixture]
    public class ConsoleApplicationTests
    {
        [Test]
        public void TestCount()
        {
            var c = new Sum();
            Assert.AreEqual(c.Count(1,2,3), 3);
        }
        
        public Trie trie;

        [OneTimeSetUp]
        public void Init()
        {
            trie = new Trie();
            trie.addPrefix("mr");
            trie.addPrefix("mrs");
            trie.addPrefix("miss");
            trie.addPrefix("ms");
        }

        [Test]
        public void TestSearchExists()
        {
            Assert.IsTrue(trie.containsPrefix("mrs"));
        }

        [Test]
        public void TestSearchNull()
        {
            Assert.IsFalse(trie.containsPrefix(null));
        }

        [Test]
        public void TestSearchEmptyString()
        {
            Assert.IsTrue(trie.containsPrefix(""));
        }

        [Test]
        public void TestSearchUpperCase()
        {
            Assert.IsFalse(trie.containsPrefix("MR"));
        }

        [Test]
        public void TestSearchIncompletePrefix()
        {
            Assert.IsFalse(trie.containsPrefix("m"));
        }
    }
}
