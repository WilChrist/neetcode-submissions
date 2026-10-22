public class MinStack
{
    Stack<int> stack;
    Stack<int> extraStack;

    public MinStack()
    {
        stack = new Stack<int>();
        extraStack = new Stack<int>();
    }

    public void Push(int val)
    {
        this.stack.Push(val);
        if(this.extraStack.Count == 0)
        {
            this.extraStack.Push(val);

        }
        else
        {
            this.extraStack.Push(Math.Min(val, this.extraStack.Peek()));
        }
    }

    public void Pop()
    {
        this.stack.Pop();
        this.extraStack.Pop();
    }

    public int Top()
    {
        return this.stack.Peek();
    }

    public int GetMin()
    {
        return this.extraStack.Peek();
    }
}