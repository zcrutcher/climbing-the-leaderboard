const ranking = (score, leaderboard) => {
    
    const unique = [... new Set(leaderboard)];
    let i = 0;
    for(i; i < unique.length; i++){
        if(score >= unique[i]){
            return i+1;
        }
    }
    return i+1;
}

module.exports = ranking;