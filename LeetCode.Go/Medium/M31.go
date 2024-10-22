package leetcodego

func NextPermutation(nums []int) {

	if len(nums) == 1 {
		return
	}

	right := len(nums) - 1
	left := len(nums) - 1

	for {
		if nums[left] > nums[left-1] {
			maxIndex := left
			for i := left + 1; i <= right; i++ {
				if nums[i] < nums[maxIndex] && nums[i] > nums[left-1] {
					maxIndex = i
				}
			}
			nums[left-1], nums[maxIndex] = nums[maxIndex], nums[left-1]
			bubbleSort(nums, left, right)
			break
		} else {
			left--
			if left == 0 {
				bubbleSort(nums, left, right)
				break
			}
		}

	}
}

func bubbleSort(nums []int, left int, right int) {
	for i := left; i < right; i++ {
		for j := i + 1; j <= right; j++ {
			if nums[i] > nums[j] {
				nums[i], nums[j] = nums[j], nums[i]
			}
		}
	}
}
