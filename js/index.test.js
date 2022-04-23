const ranking = require("./index");

test('Returns the rank of score based on other existing scores', () => {
    expect(ranking(35, [100, 80, 80, 25])).toBe(3);
    expect(ranking(5, [100,100,50,40,40,20,10])).toBe(6);
    expect(ranking(25, [100,100,50,40,40,20,10])).toBe(4);
    expect(ranking(50, [100,100,50,50,40,40,20,10])).toBe(2);
    expect(ranking(120, [100,100,50,40,40,20,10])).toBe(1);
});