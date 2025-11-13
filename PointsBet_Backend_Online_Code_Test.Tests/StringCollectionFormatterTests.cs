using PointsBet_Backend_Online_Code_Test;

namespace PointsBet_Backend_Online_Code_Test.Tests;

    [TestClass]
    public class StringCollectionFormatterTests
    {
        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithValidItemsAndQuote_ReturnsFormattedString()
        {
            // Arrange
            string[] items = { "apple", "banana", "cherry" };
            string quote = "\"";

            // Act
            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            // Assert
            Assert.AreEqual("\"apple\", \"banana\", \"cherry\"", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithValidItemsAndSingleQuote_ReturnsFormattedString()
        {
            // Arrange
            string[] items = { "apple", "banana", "cherry" };
            string quote = "'";

            // Act
            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            // Assert
            Assert.AreEqual("'apple', 'banana', 'cherry'", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithValidItemsAndAsterisk_ReturnsFormattedString()
        {
            // Arrange
            string[] items = { "apple", "banana", "cherry" };
            string quote = "*";

            // Act
            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            // Assert
            Assert.AreEqual("*apple*, *banana*, *cherry*", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithEmptyItems_ReturnsEmptyString()
        {
            // Arrange
            string[] items = { };
            string quote = "\"";

            // Act
            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithNullItems_ReturnsEmptyString()
        {
            // Arrange
            string[] items = null;
            string quote = "\"";

            // Act
            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithNullQuote_ReturnsEmptyString()
        {
            // Arrange
            string[] items = { "apple", "banana" };
            string quote = null;

            // Act
            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithEmptyQuote_ReturnsEmptyString()
        {
            // Arrange
            string[] items = { "apple", "banana" };
            string quote = "";

            // Act
            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithItemsContainingEmptyStrings_IgnoresEmptyItems()
        {
            // Arrange
            string[] items = { "apple", "", "banana" };
            string quote = "'";

            // Act
            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            // Assert
            Assert.AreEqual("'apple', 'banana'", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedString_WithNullItems_IgnoresNullItems()
        {
            // Arrange
            string[] items = { "apple", null, "banana" };
            string quote = "'";

            // Act
            string result = StringCollectionFormatter.ToCommaSeparatedQuotedString(items, quote);

            // Assert
            Assert.AreEqual("'apple', 'banana'", result);
        }
    }
