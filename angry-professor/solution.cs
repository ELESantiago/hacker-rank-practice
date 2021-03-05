class Solution
{
    static string angryProfessor(int k, int[] a) {
        var classCancel = k > a.Count(s => s <= 0);
        return classCancel ? "YES" : "NO";
    }

}