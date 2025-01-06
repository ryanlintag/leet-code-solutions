namespace LeetCodeSolutions;

public class ArraySolutions {
    /// <summary>
    /// Given an array of integers nums and an integer target, 
    /// return indices of the two numbers such that they add up to target.
    /// 
    /// You may assume that each input would have exactly one solution,
    /// and you may not use the same element twice.
    /// 
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            //subtract the current number from the target
            int complement = target - nums[i];
            //if the complement is in the dictionary, return the index of the complement and the current index
            if(dict.ContainsKey(complement))
            {
                return new int[] { dict[complement], i };
            }
            //if the complement is not in the dictionary, add the current number to the dictionary
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        //return empty array if no solution is found
        return new int[]{}; 
    }
}
