

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace laba04
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void ShouldInsertAndRetrieveElementsCorrectly()
        {
            var bst = new BinarySearchTree();
            bst.Insert(10, "Value 1");
            bst.Insert(5, "Value 2");
            bst.Insert(15, "Value 3");

            Assert.AreEqual("Value 1", bst.Search(10));
            Assert.AreEqual("Value 2", bst.Search(5));
            Assert.AreEqual("Value 3", bst.Search(15));

            Console.WriteLine("Test 1 passed");
        }

        [TestMethod]
        public void ShouldUpdateValueIfKeyAlreadyExistsDuringInsertion()
        {
            var bst = new BinarySearchTree();
            bst.Insert(10, "Value 1");
            bst.Insert(10, "Updated Value");

            Assert.AreEqual("Updated Value", bst.Search(10));
            Console.WriteLine("Test 2 passed");
        }

        [TestMethod]
        public void ShouldReturnNullForNonExistingKeys()
        {
            var bst = new BinarySearchTree();
            Assert.IsNull(bst.Search(1));
            Console.WriteLine("Test 3 passed");
        }

        [TestMethod]
        public void ShouldRemoveElementsCorrectly()
        {
            var bst = new BinarySearchTree();
            bst.Insert(10, "Value 1");
            bst.Insert(5, "Value 2");
            bst.Insert(15, "Value 3");

            bst.Remove(5);
            Assert.IsNull(bst.Search(5));
            Assert.AreEqual(2, bst.Traverse().Count);
            Console.WriteLine("Test 4 passed");
        }

        [TestMethod]
        public void ShouldHandleTreeTraversalCorrectly()
        {
            var bst = new BinarySearchTree();
            bst.Insert(10, "Value 1");
            bst.Insert(5, "Value 2");
            bst.Insert(15, "Value 3");

            var result = bst.Traverse();
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(new KeyValuePair<int, string>(5, "Value 2"), result[0]);
            Assert.AreEqual(new KeyValuePair<int, string>(10, "Value 1"), result[1]);
            Assert.AreEqual(new KeyValuePair<int, string>(15, "Value 3"), result[2]);
            Console.WriteLine("Test 5 passed");
        }
    }
}
