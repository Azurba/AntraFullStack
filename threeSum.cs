public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        //Use List of Lists with result
        List<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                int c1 = i + 1; //counter/pointer 1
                int c2 = nums.Length - 1; //counter/pointer 2
                int sum = 0 - nums[i];

                while (c1 < c2)
                {
                    if (nums[c1] + nums[c2] == sum)
                    {
                        var list = new List<int>();
                        list.Add(nums[i]);
                        list.Add(nums[c1]);
                        list.Add(nums[c2]);
                        result.Add(list);
                        while (c1 < c2 && (nums[c1] == nums[c1 + 1])) c1++;
                        while (c1 < c2 && (nums[c2] == nums[c2 - 1])) c2--;
                        c1++;
                        c2--;
                    }
                    else if (nums[c1] + nums[c2] < sum)
                        c1++;
                    else
                        c2--;
                    }
                }
            }
        return result;
    }
}
