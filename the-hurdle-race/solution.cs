class Solution {

    static int hurdleRace(int k, int[] height) {
        var maxHurdle = height.Max();
        if (k >= maxHurdle)
            return 0;
            
        return maxHurdle - k;
    }
}