class Solution
{
    static int designerPdfViewer(int[] h, string word)
    {
        var aCharIntValue = 97;
        var maxValue = 0;
        foreach (var c in word.ToCharArray())
        {
            var charValue = (int)c;
            var hValue = h[(charValue - aCharIntValue)];
            if (hValue > maxValue)
                maxValue = hValue;
        }
        return maxValue * word.Length;
    }

}