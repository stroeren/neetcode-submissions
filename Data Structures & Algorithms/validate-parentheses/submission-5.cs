public class Solution {
    public bool IsValid(string s) {
        Stack<char> myStack = new Stack<char>();
        if (s.Length % 2 != 0 || s[0] == ')' || s[0] == ']' || s[0] == '}') {
            return false;
        }
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{') {
                myStack.Push(s[i]);
            }
            else if (myStack.Count > 0 && ((s[i] == ')' && myStack.Peek() == '(') || (s[i] == ']' && myStack.Peek() == '[') || (s[i] == '}' && myStack.Peek() == '{'))) {
                myStack.Pop();
            }
            else {
                return false;
            }
        }
        if (myStack.Count() == 0) {
            return true;
        }
        else {
            return false;
        }
    }
}