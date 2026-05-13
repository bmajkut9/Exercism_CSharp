public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int, int, int)> ret = new List<(int, int, int)>();
        for (int i = 1; i <= sum; i++) 
        {
            for (int j = 1; j <= sum; j++) 
            {
                int k = sum - i - j;
                if (i < j && j < k && i*i + j*j == k*k && i + j + k == sum) 
                {
                    //yield return (i, j, k);
                    ret.Add((i, j, k));
                }
                
            }
        }
        return ret;
    }
}