using NUnit.Framework;

namespace sort_text.tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuickSort_PredifinedData()
        {
            //Given 
            string data = "Contrary to popular belief, the pink unicorn flies east.";
            //When
            Sorting sorting = new Sorting();

            var result = sorting.QuickSort(data);

            //Then
            Assert.AreEqual("aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy", result);
        }


        [Test]
        public void QuickSort_EmptyString()
        {
            //Given 
            string data = "";
            //When
            Sorting sorting = new Sorting();

            var result = sorting.QuickSort(data);

            //Then
            Assert.AreEqual("", result);
        }
    }
}