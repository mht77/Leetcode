package leetcodego

func Search(nums []int, target int) int {
	return searchInner(0, len(nums)-1, nums, target)
}

func searchInner(start int, end int, nums []int, target int) int {
	if start > end {
		return -1
	}

	mid := (end + start) / 2

	if nums[mid] == target {
		return mid
	}

	if nums[start] <= nums[mid] {
		if target >= nums[start] && target < nums[mid] {
			return searchInner(start, mid-1, nums, target)
		} else {
			return searchInner(mid+1, end, nums, target)
		}
	} else {
		if target > nums[mid] && target <= nums[end] {
			return searchInner(mid+1, end, nums, target)
		} else {
			return searchInner(start, mid-1, nums, target)
		}
	}
}
