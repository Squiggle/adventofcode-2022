namespace Day2;

public static class StringExtensions {
    public static RpsMove ParseMove(this string move) =>
        move switch {
            "A" => RpsMove.Rock,
            "B" => RpsMove.Paper,
            "C" => RpsMove.Scissors,
            "Y" => RpsMove.Paper,
            "X" => RpsMove.Rock,
            "Z" => RpsMove.Scissors,
            _ => throw new System.Exception($"Unknown move {move}")
        };
}