public class Solution {
    public int CalPoints(string[] operations) {
        int operationsLength = operations.Length;
        Stack<int> score = new Stack<int>();
        int finalScore = 0;
        for (int i = 0; i < operationsLength; i++) {
            if (int.TryParse(operations[i], out int result)) {
                score.Push(result);
            }
            if (operations[i] == "+") {
                int temp = score.Peek();
                score.Pop();
                int sum = score.Peek() + temp;
                score.Push(temp);
                score.Push(sum);
            }
            if (operations[i] == "D") {
                score.Push(score.Peek() * 2);
            }
            if (operations[i] == "C") {
                score.Pop();
            }
        }
        int finalScoreLength = score.Count();
        for (int i = 0; i < finalScoreLength; i++) {
            finalScore = score.Peek() + finalScore;
            score.Pop();
        }
        return finalScore;
    }

    public int ConvertToInt(string input) {
        int result = int.Parse(input);
        return result;
    }
}