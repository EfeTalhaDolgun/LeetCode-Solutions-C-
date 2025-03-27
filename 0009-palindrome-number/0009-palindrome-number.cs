public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;

        int originalX = x;
        int reverse = 0;

        while (x > 0) {
            int digit = x % 10;
            reverse = reverse * 10 + digit;
            x = x / 10;
        }

        if (reverse == originalX)
            return true;
        else
            return false;
    }
}
