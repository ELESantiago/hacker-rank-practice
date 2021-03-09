namespace SaveThePrisoner
{

    public class Solution
    {

        public static int SaveThePrisoner(int n, int m, int s)
        {
            return (s + m - 2) % n + 1;
        }
    }
}