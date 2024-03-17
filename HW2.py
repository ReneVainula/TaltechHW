class Solution:
    def maximumGap(self, nums: List[int]) -> int:
        max_gap = -1
        if len(nums) < 2:
            return 0
        nums.sort()
        for i in range(1, len(nums)-1):
            if nums[i+1] - nums[i] > max_gap:
                max_gap = nums[i+1] - nums[i]
        return max_gap
