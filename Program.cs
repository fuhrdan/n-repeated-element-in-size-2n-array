//*****************************************************************************
//** 961. N-Repeated Element in Size 2N Array                       leetcode **
//*****************************************************************************
//** A crowd of numbers, twice in size,                                      **
//** One lone value wears a clever disguise.                                 **
//** We count each step till truth is seen,                                  **
//** The one repeated n times breaks the routine.                            **
//*****************************************************************************

int repeatedNTimes(int* nums, int numsSize) {
    int n = numsSize / 2;
    int count[100000] = {0};
    for(int i = 0; i < numsSize; i++)
    {
        count[nums[i]]++;
        if(count[nums[i]] == n) return nums[i];
    }
    return -1;
}