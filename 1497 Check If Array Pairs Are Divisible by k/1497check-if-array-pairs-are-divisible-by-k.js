/**
 * @param {number[]} arr
 * @param {number} k
 * @return {boolean}
 */
var canArrange = function(arr, k) {
    const moduloList = new Array(k).fill(0);
    for (let num of arr) {
        if (num >= 0 || num % k === 0) {
            moduloList[(num % k)]++;
        }
        else {
            moduloList[(num % k) + k]++
        }
    }

    if (moduloList[0] % 2 !== 0){
        return false;
    }

    for (let i = 1; i < k / 2; i++) {
        if (moduloList[i] != moduloList[k - i]) {
            return false;
        }
    }
    return true;
};