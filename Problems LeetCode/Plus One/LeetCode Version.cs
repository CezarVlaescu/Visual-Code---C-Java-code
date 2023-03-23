public class Solution {
    public int[] PlusOne(int[] digits) {
        bool carry = true;

        for (int i = digits.Length - 1 ; carry && i >= 0 ; i--) {
            digits[i] = (digits[i] + 1) % 10;
            carry = digits[i] == 0;
        }

        if (carry) {
            digits = new int[digits.Length + 1];
            digits[0] = 1;
        }

        return digits;
    }
}
