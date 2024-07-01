namespace LeetCode.Problems;

public class Solution605
{
    private const int EMPTY_PLACE = 0;
    private const int FLOWER_PLACE = 1;
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
        {
            return true;
        }
        int flowers = n;
        bool leftEmpty, rightEmpty;
        
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == EMPTY_PLACE)
            {
                leftEmpty = i == 0 || flowerbed[i - 1] == EMPTY_PLACE;
                rightEmpty = i == flowerbed.Length - 1 || flowerbed[i + 1] == EMPTY_PLACE;
                
                if (leftEmpty && rightEmpty)
                {
                    flowerbed[i] = FLOWER_PLACE;
                    flowers--;
                }
            }
            if (flowers == 0)
            {
                return true;
            }
        }

        return flowers == 0;
    }
}