

public class Program {

    public static void Main(String[] args) {

        int[] myArray = {1, 2, 3, 4, 8, 9};
        int[] answer = EasyProblems.Problem_1(nums: myArray, target: 6);

        foreach (int item in answer)
        {
            Console.WriteLine(item);
        }

    }
}