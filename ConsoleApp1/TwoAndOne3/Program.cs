using System;

class Program
{
static bool ContainsDuplicate (int[] nums)
{
    Array.Sort(nums);
    
    for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] == nums [i - 1])
    {
        return true;
    }
    
}
    return false;
}

static void Main()
{
    int[] nums = {1,1,1,3,3,4,3,2,4,2};
    
    bool result = ContainsDuplicate(nums);
    Console.WriteLine(result);
    }
}