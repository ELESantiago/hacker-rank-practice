function beautifulDays(i, j, k) {
    let beatifulDay = 0;
    for (; i <= j; i++) {
        const reverse = getReverse(i);
        if (Math.abs(i - reverse) % k === 0) {
            beatifulDay++;
        }
    }
    return beatifulDay;
}

function getReverse(n) {
    let newNumber = 0;
    if (n < 10)
        return n;
    while (n > 0) {
        newNumber = newNumber * 10 + (n % 10);
        n = Math.floor(n / 10);
    }
    return newNumber;
}