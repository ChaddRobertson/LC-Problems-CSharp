

public class EasyProblems {


    /// <summary>
    /// Problem 1:
    /// <para>Given an array of integers nums and an integer target, return indices of the
    /// two numbers such that they add up to target.</para>
    /// <para>You may assume that each input would have exactly one solution, and you may not
    /// use the same element twice. You can return the answer in any order.</para>
    /// </summary>
    public static int[] Problem_1(int[] nums, int target) {

        int[] indeces = {0, 0};

        for (int i = 0; i < nums.Length; i++)
        {
            int differenceIndex = Array.IndexOf(nums, target - nums[i]);

            if (differenceIndex != -1 && differenceIndex != i) {

                indeces[0] = differenceIndex;
                indeces[1] = i;

                break;
            }
        }

        return indeces;
    }


    /// <summary>
    /// </summary>
    public static void Problem_9(int x) {

        List<int> values = new List<int>();

        for (int i = 1; i <= x; i *= 10) {

            
        }
    }

}