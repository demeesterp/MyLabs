using Labs;

namespace LabsTest
{
    public class ListSumTest
    {
        [Fact]
        public void TestSumming()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            var list2 = new List<int>();
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);


            var list3 = new List<int>();
            list3.Add(6);
            list3.Add(7);
            list3.Add(8);

            var jaggedArray = new List<List<int>>();
            jaggedArray.Add(list);
            jaggedArray.Add(list2);
            jaggedArray.Add(list3);


            var result = ListSum.Sum(jaggedArray);


            Assert.Equal(11, result[0]);
            Assert.Equal(14, result[1]);
            Assert.Equal(17, result[2]);

        }
    }
}