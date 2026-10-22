public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        HashSet<string> operators = new HashSet<string> { "+", "-", "*", "/" };

        foreach (string token in tokens) {
            if (!operators.Contains(token)) {
                stack.Push(int.Parse(token));
            } else {
                int b = stack.Pop();
                int a = stack.Pop();
                stack.Push(PerformTheCorrespondingOperation(a, b, token));
            }
        }
        return stack.Pop();
    }

    public int PerformTheCorrespondingOperation(int a, int b, string op) {
        switch (op) {
            case "+":
                return add(a, b);
            case "-":
                return subtract(a, b);
            case "*":
                return multiply(a, b);
            case "/":
                return divide(a, b);
            default:
                throw new InvalidOperationException("Invalid operator");
        }
    }
    public int add(int a, int b) {
        return a + b;
    }

    public int subtract(int a, int b) {
        return a - b;
    }

    public int multiply(int a, int b) {
        return a * b;
    }
    public int divide(int a, int b) {
        return a / b;
    }
}