namespace laba04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testClass = new BinarySearchTreeTests();
            testClass.ShouldInsertAndRetrieveElementsCorrectly();
            testClass.ShouldUpdateValueIfKeyAlreadyExistsDuringInsertion();
            testClass.ShouldReturnNullForNonExistingKeys();
            testClass.ShouldRemoveElementsCorrectly();
            testClass.ShouldHandleTreeTraversalCorrectly();
        }
    }
}