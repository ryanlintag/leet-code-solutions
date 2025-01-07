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

    /// <summary>
    /// Remove Duplicates from Sorted Array
    /// </summary>
    /// <param name="ints"></param>
    /// <returns></returns>
    public int[] RemoveIntegerDuplicatesInSortedArray(int[] ints){
        //Edge case: if the array is empty, return an empty array
        if(ints.Length == 0) return new int[]{};
        //create a new array to store the unique numbers
        //initialize the first element of the new array to the first element of the input array
        var returnValue = new int[1]{ ints[0] };
        //initialize a variable to keep track of the index of the unique numbers
        int index = 1;
        //iterate through the array
        for(int i=1; i < ints.Length; i++){
            if(ints[i] != ints[i-1]){
                //Resize Array
                Array.Resize(ref returnValue, index + 1);
                //if the current number is not equal to the next number, add the current number to the new array
                returnValue[index] = ints[i];
                //increment the index
                index++;
            }
        }
        return returnValue;
    }

    /// <summary>
    /// Given a sorted array nums, remove the duplicates in-place such that each element appears only once and returns the new length.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RemoveArrayDuplicates(int[] nums)
    {
        if(nums.Length == 0) return 0;
        int index = 0;
        for(int j = 1; j < nums.Length; j++)
        {
            if(nums[j] != nums[index])
            {
                index++;
                nums[index] = nums[j];
            }
        }
        return index + 1;
    }
}
