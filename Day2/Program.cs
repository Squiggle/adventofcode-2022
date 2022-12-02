using Day2;

var lines = File.ReadAllLines("input.txt");

/*
The score for a single round is the score for the shape you selected
1 for Rock
2 for Paper
3 for Scissors

plus the score for the outcome of the round
0 if you lost
3 if the round was a draw
6 if you won.
*/

/**
Score a round of RPS (response is your move)
Returns (score, success)
*/
int ScoreRound(RpsMove challenge, RpsMove response) =>
    (response == challenge
        // draw
        ? 3
        // win or lose
        : challenge switch {
            // rock beats scissors
            RpsMove.Scissors => response is RpsMove.Rock ? 6 : 1,
            // paper beats rock
            RpsMove.Rock => response is RpsMove.Paper ? 6 : 1,
            // scissors beats paper
            RpsMove.Paper => response is RpsMove.Scissors ? 6 : 1
    }) + (int)response;

(RpsMove challenge, RpsMove response) ParseLine(string line) =>
    line.Split(" ") is [string challenge, string response]
        ? (challenge.ParseMove(), response.ParseMove())
        : throw new System.Exception("Parse line failed");

foreach (var line in lines) {
    ParseLine(line)
}