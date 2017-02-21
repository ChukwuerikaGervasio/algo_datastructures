using NUnit.Framework;

namespace ConsoleApplication
{
    [TestFixture]
    public class ConsoleApplicationTests
    {
        public Trie trie;

        [OneTimeSetUp]
        public void Init()
        {
            trie = new Trie();
            trie.addPrefixRecursively("mr");
            trie.addPrefixRecursively("mrs");
            trie.addPrefixRecursively("miss");
            trie.addPrefixRecursively("ms");
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
            Assert.IsFalse(trie.containsPrefix(""));
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
