function searchRange(nums: number[], target: number): number[] {
    let result: number[] = [-1, -1];

    let i = 0;
    for (; i < nums.length; i++) {
        if (nums[i] === target){
            result[0] = i;
            break;
        }
    }

    if (result[0] !== -1) {
        while (i < nums.length && nums[i] === target)
            i++;
        result[1] = i - 1;
    }

    return result;
};

console.log('1: ', searchRange([5,7,7,8,8,10], 8));
console.log('2: ', searchRange([5,7,7,8,8,10], 6));
console.log('3: ', searchRange([], 0));
