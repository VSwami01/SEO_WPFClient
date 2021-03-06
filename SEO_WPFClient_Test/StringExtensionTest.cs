using NUnit.Framework;
using SEO_WPFCLient_Lib.Extentions;

namespace SEO_WPFClient_Test
{
    public class StringExtensionTest
    {
        /// <summary>
        /// Test with empty text parameter returning empty list
        /// </summary>
        [Test]
        public void TrimSpecialChars_EmptyText_ReturnEmpty()
        {
            // Arrange
            var text = string.Empty;
            var expected = string.Empty;

            // Act
            var actual = text.TrimSpecialChars();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with null text parameter returning empty list
        /// </summary>
        [Test]
        public void TrimSpecialChars_NullText_ReturnEmpty()
        {
            // Arrange
            string text = null;
            var expected = string.Empty;

            // Act
            var actual = text.TrimSpecialChars();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with text parameter having dots returning string without dots
        /// </summary>
        [Test]
        public void TrimSpecialChars_StringWithDot_ReturnTrimmedWithoutDot()
        {
            // Arrange
            var text = ".this.";
            var expected = "this";

            // Act
            var actual = text.TrimSpecialChars();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with text parameter having stars returning string without stars
        /// </summary>
        [Test]
        public void TrimSpecialChars_StringWithStar_ReturnTrimmedWithoutStar()
        {
            // Arrange
            var text = "*this*";
            var expected = "this";

            // Act
            var actual = text.TrimSpecialChars();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with text parameter having spaces returning string without spaces
        /// </summary>
        [Test]
        public void TrimSpecialChars_StringWithSpace_ReturnTrimmedWithoutSpace()
        {
            // Arrange
            var text = " this ";
            var expected = "this";

            // Act
            var actual = text.TrimSpecialChars();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with text parameter forward slashes returning string without forward slashes
        /// </summary>
        [Test]
        public void TrimSpecialChars_StringForwardSlash_ReturnTrimmedWithoutForwardSlash()
        {
            // Arrange
            var text = "/this/";
            var expected = "this";

            // Act
            var actual = text.TrimSpecialChars();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with text parameter backward slashes returning string without backward slashes
        /// </summary>
        [Test]
        public void TrimSpecialChars_StringBackwardSlash_ReturnTrimmedWithoutBackwardSlash()
        {
            // Arrange
            var text = "\\this\\";
            var expected = "this";

            // Act
            var actual = text.TrimSpecialChars();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with null text parameter returning true
        /// </summary>
        [Test]
        public void IsNullOrEmpty_NullText_ReturnTrue()
        {
            // Arrange
            string text = null;
            var expected = true;

            // Act
            var actual = text.IsNullOrEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with empty text parameter returning true
        /// </summary>
        [Test]
        public void IsNullOrEmpty_EmptyText_ReturnTrue()
        {
            // Arrange
            var text = string.Empty;
            var expected = true;

            // Act
            var actual = text.IsNullOrEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Test with null text parameter returning false
        /// </summary>
        [Test]
        public void IsNullOrEmpty_NonEmptyText_ReturnFalse()
        {
            // Arrange
            var text = "test";
            var expected = false;

            // Act
            var actual = text.IsNullOrEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}