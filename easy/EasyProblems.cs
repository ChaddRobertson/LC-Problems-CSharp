

public class EasyProblems {


    /// <summary>
    /// Problem 1:
    /// <para>Given an array of integers nums and an integer target, return indices of the
    /// two numbers such that they add up to target.</para>
    /// <para>You may assume that each input would have exactly one solution, and you may not
    /// use the same element twice. You can return the answer in any order.</para>
    /// </summary>
    public static int[] Problem_1(int[] nums, int target) {

        int index_1 = 0; // Answer is expected, so indeces are initialised as zero,
        int index_2 = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            int differenceIndex = Array.IndexOf(nums, difference);

            if (differenceIndex != -1 && differenceIndex != i) {

                index_1 = differenceIndex;
                index_2 = i;
            }
        }

        int[] indeces = {index_1, index_2};

        return indeces;
    }

}