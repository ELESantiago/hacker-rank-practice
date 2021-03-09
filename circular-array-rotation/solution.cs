namespace CircularArrayRotation
{

    public class Solution
    {

        public static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            var values = new int[queries.Length];
            var aList = a.ToList();
            for (var i = 0; i < k; i++)
            {
                var hold = aList.Last();
                aList.RemoveAt(aList.Count() - 1);
                aList.Insert(0, hold);
            }

            for (var i = 0; i < queries.Length; i++)
            {
                values[i] = aList[queries[i]];
            }

            return values;
        }
    }
}