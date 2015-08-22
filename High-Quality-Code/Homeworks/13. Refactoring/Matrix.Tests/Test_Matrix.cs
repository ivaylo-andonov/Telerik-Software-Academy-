namespace Matrix.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// The test_ matrix.
    [TestClass]
    public class Test_Matrix
    {
        /// The matrix 1 element.
        private const string Matrix1Element = "  1\r\n";

        /// The matrix 2 elements.
        private const string Matrix2Elements = "  1  4\r\n  3  2\r\n";

        /// The matrix 3 elements.
        private const string Matrix3Elements = "  1  7  8\r\n  6  2  9\r\n  5  4  3\r\n";

        /// The matrix 4 elements.
        private const string Matrix4Elements = "  1 10 11 12\r\n  9  2 15 13\r\n  8 16  3 14\r\n  7  6  5  4\r\n";

        /// The matrix 10 elements.
        private const string Matrix10Elements =
            "  1 28 29 30 31 32 33 34 35 36\r\n 27  2 51 52 53 54 55 56 57 37\r\n 26 73  3 50 66 67 68 69 58 38\r\n 25 90 74  4 49 65 72 70 59 39\r\n 24 89 91 75  5 48 64 71 60 40\r\n 23 88 99 92 76  6 47 63 61 41\r\n 22 87 98100 93 77  7 46 62 42\r\n 21 86 97 96 95 94 78  8 45 43\r\n 20 85 84 83 82 81 80 79  9 44\r\n 19 18 17 16 15 14 13 12 11 10\r\n";

        /// The test matrix with size 0 should throw.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMatrixWithSize0ShouldThrow()
        {
            var m = new Matrix(0);
        }

        /// The test matrix with size 1 should return correct result.
        [TestMethod]
        public void TestMatrixWithSize1ShouldReturnCorrectResult()
        {
            var m = new Matrix(1);
            Assert.AreEqual(m.ToString(), Matrix1Element);
        }

        /// The test matrix with size 2 should return correct result.
        [TestMethod]
        public void TestMatrixWithSize2ShouldReturnCorrectResult()
        {
            var m = new Matrix(2);
            Assert.AreEqual(m.ToString(), Matrix2Elements);
        }

        /// The test matrix with size 3 should return correct result.
        [TestMethod]
        public void TestMatrixWithSize3ShouldReturnCorrectResult()
        {
            var m = new Matrix(3);
            Assert.AreEqual(m.ToString(), Matrix3Elements);
        }

        /// The test matrix with size 4 should return correct result.
        [TestMethod]
        public void TestMatrixWithSize4ShouldReturnCorrectResult()
        {
            var m = new Matrix(4);
            Assert.AreEqual(m.ToString(), Matrix4Elements);
        }

        /// The test matrix with size 10 should return correct result.
        [TestMethod]
        public void TestMatrixWithSize10ShouldReturnCorrectResult()
        {
            var m = new Matrix(10);
            Assert.AreEqual(m.ToString(), Matrix10Elements);
        }
    }
}