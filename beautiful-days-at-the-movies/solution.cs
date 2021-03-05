class Solution
{

    // Complete the beautifulDays function below.
    static int beautifulDays(int i, int j, int k)
    {
        var beatifulDays = 0;
        for (; i <= j; i++)
        {
            if (Math.Abs(i - reverseNumber(i)) % k == 0)
                beatifulDays++;
        }
        return beatifulDays;
    }

    static int reverseNumber(int number)
    {
        var reverseNumber = 0;
        while (number > 0)
        {
            reverseNumber = (reverseNumber * 10) + (number % 10);
            number = number / 10;
        }

        return reverseNumber;
    }
}