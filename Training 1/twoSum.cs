public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Wanted to use List here for practice
        List<int> res = new List<int>();
        //loop for first counter/iterator
        for(var i = 0; i < nums.Length; i++){
            //loop for second counter/iterator
            for(var k = i + 1; k < nums.Length; k++){
                if(nums[i] + nums[k] == target){
                    res.Add(i);
                    res.Add(k);
                }
            }
        }
        int[] result = res.ToArray();
        return result;
    }
}
