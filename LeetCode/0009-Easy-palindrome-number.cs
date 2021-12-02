namespace LeetCode;

public partial class Problems
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int value = target - nums[i];
            if (dic.ContainsKey(value))
            {
                return new int[] { dic[value], i };
            }
            dic[nums[i]] = i;
        }

        return null;
    }
}
