function viralAdvertising(n) {
    let shares = 5;
    let likes = 0;
    for (let i = 1; i <= n; i++) {
        const newLikes = Math.floor(shares / 2);
        likes += newLikes;
        shares = newLikes * 3;
    }
    return likes;
}