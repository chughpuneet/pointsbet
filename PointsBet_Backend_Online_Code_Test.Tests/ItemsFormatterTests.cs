using PointsBet_Backend_Online_Code_Test;

namespace PointsBet_Backend_Online_Code_Test.Tests;

    [TestClass]
    public class ItemsFormatterTests
    {
        [TestMethod]
        public void ToCommaSeparatedQuotedItems_WithValidItemsAndQuote_ReturnsFormattedString()
        {
            // Arrange
            string[] items = { "apple", "banana", "cherry" };
            string quote = "\"";

            // Act
            string result = ItemsFormatter.ToCommaSeparatedQuotedItems(items, quote);

            // Assert
            Assert.AreEqual("\"apple\", \"banana\", \"cherry\"", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedItems_WithEmptyItems_ReturnsEmptyString()
        {
            // Arrange
            string[] items = { };
            string quote = "\"";

            // Act
            string result = ItemsFormatter.ToCommaSeparatedQuotedItems(items, quote);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedItems_WithNullItems_ReturnsEmptyString()
        {
            // Arrange
            string[] items = null;
            string quote = "\"";

            // Act
            string result = ItemsFormatter.ToCommaSeparatedQuotedItems(items, quote);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedItems_WithNullQuote_ReturnsEmptyString()
        {
            // Arrange
            string[] items = { "apple", "banana" };
            string quote = null;

            // Act
            string result = ItemsFormatter.ToCommaSeparatedQuotedItems(items, quote);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedItems_WithEmptyQuote_ReturnsEmptyString()
        {
            // Arrange
            string[] items = { "apple", "banana" };
            string quote = "";

            // Act
            string result = ItemsFormatter.ToCommaSeparatedQuotedItems(items, quote);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedItems_WithItemsContainingEmptyStrings_IgnoresEmptyItems()
        {
            // Arrange
            string[] items = { "apple", "", "banana" };
            string quote = "'";

            // Act
            string result = ItemsFormatter.ToCommaSeparatedQuotedItems(items, quote);

            // Assert
            Assert.AreEqual("'apple', 'banana'", result);
        }

        [TestMethod]
        public void ToCommaSeparatedQuotedItems_WithNullItems_IgnoresNullItems()
        {
            // Arrange
            string[] items = { "apple", null, "banana" };
            string quote = "'";

            // Act
            string result = ItemsFormatter.ToCommaSeparatedQuotedItems(items, quote);

            // Assert
            Assert.AreEqual("'apple', 'banana'", result);
        }
    }
