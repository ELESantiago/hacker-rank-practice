class Solution
{
    static int viralAdvertising(int n)
    {
        var shares = 5;
        var likes = 0;
        for (var day = 1; day <= n; day++)
        {
            // No need of Math.Floor
            var newLikes = shares / 2;
            likes += newLikes;

            shares = newLikes * 3;
        }

        return likes;
    }

}