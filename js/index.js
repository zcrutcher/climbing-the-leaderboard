const ranking = (score, leaderboard) => {    
    const unique = [... new Set(leaderboard)];

    const placement = unique.findIndex((element) => {
        return score >= element
    })

    return placement > -1 ? placement + 1 : unique.length + 1;
}

module.exports = ranking;