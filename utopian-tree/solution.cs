class Solution {

    static int utopianTree(int n) {
        var height = 1;
        for (var i = 0; i < n; i++) {
            if (i % 2 == 0) {
                height *= 2;
            } else {
                height++;
            }
        }
        return height;
    }
}