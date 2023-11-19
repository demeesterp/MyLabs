namespace Labs
{
    public class ListSum
    {


        public static List<int> Sum(List<List<int>> jaggedArray)
        {
            List<int> retval = new int [jaggedArray.Count].ToList();

            for (int i = 0; i < jaggedArray.Count; i++)
            {
                retval[i] = jaggedArray.Sum( ax => ax[i]);
            }

            return retval;
        }

    }
}
