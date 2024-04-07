namespace SqrtX;
public class Solution {
    public int MySqrt(int x) {
        if (x == 0 || x == 1)
        {
            return x;
        }

        double result = x / 2.0;

        while (result * result - x > 0.9)
        {
            result = (result + x / result) / 2;
        }

        return (int)result;
    }
}