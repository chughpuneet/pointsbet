using PointsBet_Backend_Online_Code_Test;

namespace PointsBet_Backend_Online_Code_Test.Tests;

    [TestClass]
    public class StringCollectionFormatterTests
    {
        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithValidItemsAndQuote_ReturnsFormattedString()
        {
            string[] items = { "apple", "banana", "cherry" };
            string quote = "\"";

            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            Assert.AreEqual("\"apple\", \"banana\", \"cherry\"", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithValidItemsAndSingleQuote_ReturnsFormattedString()
        {
            string[] items = { "apple", "banana", "cherry" };
            string quote = "'";

            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            Assert.AreEqual("'apple', 'banana', 'cherry'", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithValidItemsAndAsterisk_ReturnsFormattedString()
        {
            string[] items = { "apple", "banana", "cherry" };
            string quote = "*";

            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            Assert.AreEqual("*apple*, *banana*, *cherry*", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithEmptyItems_ReturnsEmptyString()
        {
            string[] items = { };
            string quote = "\"";

            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithNullItems_ReturnsEmptyString()
        {
            string[] items = null;
            string quote = "\"";

            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithNullQuote_ReturnsEmptyString()
        {
            string[] items = { "apple", "banana" };
            string quote = null;

            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithEmptyQuote_ReturnsEmptyString()
        {
            string[] items = { "apple", "banana" };
            string quote = "";

            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithItemsContainingEmptyStrings_IgnoresEmptyItems()
        {
            string[] items = { "apple", "", "banana" };
            string quote = "'";

            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            Assert.AreEqual("'apple', 'banana'", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithNullItems_IgnoresNullItems()
        {
            string[] items = { "apple", null, "banana" };
            string quote = "'";

            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            Assert.AreEqual("'apple', 'banana'", result);
        }
    }
