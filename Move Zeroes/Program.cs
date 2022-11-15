using System;

namespace Move_Zeroes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }


  public class Solution
  {
    // Space = O(1)
    // Time - O(N)
    public void MoveZeroes(int[] nums)
    {
      // Step 1 - Push all non zero elements at the begining
      // Step - after stap 1 rest of the array index fill with 0
      int nonZeroIndex = 0;
      // Step 1
      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] != 0)
        {
          nums[nonZeroIndex] = nums[i];
          nonZeroIndex++;
        }
      }
      // Step 2
      for (int i = nonZeroIndex; i < nums.Length; i++)
        nums[i] = 0;
    }

    // Space = O(N)
    // Time - O(N)
    public void MoveZeroes_(int[] nums)
    {
      var ans = new int[nums.Length];
      int j = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        // push non zero elements at the begining of the new array, rest of unfilled index will have 0's
        if (nums[i] != 0) ans[j++] = nums[i];
      }
      for (int i = 0; i < nums.Length; i++)
      {
        // copy the new array into input array
        nums[i] = ans[i];
      }
    }
  }
}
