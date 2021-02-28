function designerPdfViewer(h, word) {
    const aCharValue = 97;
    let maxValue = 0;

    for (let i = 0; i < word.length; i++) {
        const charValue = word.charCodeAt(i);
        const heightValue = h[(charValue - aCharValue)];
        maxValue = Math.max(heightValue, maxValue);
    }

    return maxValue * word.length;
}