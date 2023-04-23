namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact]
        public void ReverString()
        {
            StringOperations operations = new StringOperations();

            string result = operations.ReverseString("Hello");

            Assert.Equal("olleH", result);
        }
    }
}