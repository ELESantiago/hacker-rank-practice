function circularArrayRotation(a, k, queries) {
    const values = [];
    for (let i = 0; i < k; i++) {
        a.unshift(a.pop());
    }
    for (let i = 0; i < queries.length; i++) {
        values[i] = a[queries[i]];
    }
    return values;
}