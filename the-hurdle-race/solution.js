function hurdleRace(k, height) {

    const maxHurdle = Math.max(...height);

    if (k >= maxHurdle) {
        return 0;
    }

    return maxHurdle - k;
}
