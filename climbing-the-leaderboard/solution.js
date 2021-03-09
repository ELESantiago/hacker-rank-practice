function climbingLeaderboard(scores, alice) {
    const positions = [];
    let nonRepeatedScores = [...new Set(scores)];

    let i = nonRepeatedScores.length - 1;

    for (let score of alice) {
        while (score >= nonRepeatedScores[i]) {
            i--;
        }
        positions.push(i + 2);
    }

    return positions;
}