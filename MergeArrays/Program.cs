namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            int count1 = array1.Length;
            int count2 = array2.Length;
            int[] arrayResult = new int[count1 + count2];

            int a = 0, b = 0;
            int i = 0;

            while (a < count1 && b < count2)
            {
                if (array1[a] <= array2[b])
                {
                    arrayResult[i++] = array1[a++];
                }
                else
                {
                    arrayResult[i++] = array2[b++];
                }
            }


            if (a < count1)
            {
                for (int j = a; j < count1; j++)
                {
                    arrayResult[i++] = array1[j];
                }
            }
            else
            {
                for (int j = b; j < count2; j++)
                {
                    arrayResult[i++] = array2[j];
                }
            }
            return arrayResult;
        }
    }

}
