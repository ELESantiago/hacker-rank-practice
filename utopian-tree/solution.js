
function utopianTree(n) {
    let height = 1;
    for (let i = 0; i < n; i++) {
        if (i % 2 === 0) { // Odd are spring
            height *= 2;
        } else {
            height++;
        }
    }
    return height;
}