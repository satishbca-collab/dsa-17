/**
 * @param {number[]} nums
 * @return {number[]}
 */
var sortArray = function(nums) {
    return mergesort(nums);
};

function quickSort(nums, low, high){
    if(low >= high) return;

    const pivot = partition(nums, low, high);
    quickSort(nums, low, pivot-1);
    quickSort(nums, pivot+1, high);
}

function partition(nums, low, high){
    const pivot = nums[high];
    let i = low, j = high - 1;

    while(i <= j){
        while(i <= j && nums[i] < pivot){
            i++;
        }
        while(i <= j && nums[j] > pivot){
            j--;
        }

        if(i <= j){
            swap(nums, i, j);
            i++;
            j--;
        }
    }

    swap(nums, i, high);

    return i;
}

function mergesort(nums){
    const n = nums.length;
    if(n <= 1) return nums;
    const mid = Math.floor(n/2);

    const leftArr = new Array(mid), rightArr = new Array(n-mid);

    for(let i = 0; i < mid; i++){
        leftArr[i] = nums[i];
    }

    for(let i = 0; i < n-mid; i++){
        rightArr[i] = nums[i+mid];
    }

    const sortedLeft = mergesort(leftArr);
    const sortedRight = mergesort(rightArr);

    return merge(sortedLeft, sortedRight);
}

function merge(left, right){
    const m = left.length, n = right.length;

    let i = 0, j = 0, k = 0;
    const result = new Array(m+n);
    while(i < m && j < n){
        if(left[i] < right[j]){
            result[k++] = left[i++];
        }
        else {
            result[k++] = right[j++];
        }
    }
    while(i < m){
        result[k++] = left[i++];
    }
    while(j < n){
        result[k++] = right[j++];
    }

    return result;
}

function counting(nums){
    const n = nums.length;
    let min = nums[0], max = nums[0];

    for(let i = 1; i < n; i++){
        min = Math.min(min, nums[i]);
        max = Math.max(max, nums[i]);
    }

    const range = max - min + 1;

    const freqTable = new Array(range).fill(0);

    for(let i = 0; i < n; i++){
        freqTable[nums[i]-min]++;
    }

    for(let i = 1; i < range; i++){
        freqTable[i] = freqTable[i] + freqTable[i-1];
    }

    const result = new Array(n);
    for(let i = 0; i < n; i++){
        const pos = freqTable[nums[i] - min];
        result[pos-1] = nums[i];
        freqTable[nums[i] - min]--;
    }
    return result;
}

function bubble(nums){
    const n = nums.length;
    for(let i = 0; i < n; i++){ // # of passes
        let isSwapped = false;
        for(let j = 0; j < n-1-i; j++){ // comparisons in each pass
            if(nums[j] > nums[j+1]){
                swap(nums, j, j+1);
                isSwapped = true;
            }
        }
        if(!isSwapped){
            return nums;
        }
    }
    return nums;
}

function selection(nums){
    const n = nums.length;
    for(let i = 0; i < n; i++){
        let min = i;
        for(let j = i+1; j < n; j++){
            if(nums[j] < nums[min]){
                min = j;
            }
        }
        if(min != i){
            swap(nums, i, min);
        }
    }
    return nums;
}

function insertion(nums){
    const n = nums.length;
    for(let i = 1; i < n; i++){
        const key = nums[i];
        let j = i-1;
        while(j >= 0 && nums[j] > key){
            nums[j+1] = nums[j];
            j--;
        }
        nums[j+1] = key;
    }

    return nums;
}

function swap(nums, i, j){
    const temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
}