
public class BalancedSupports
{
    public static bool AreBalanced(string text)
    {
        var chars = text.ToCharArray();

        var stack = new Stack<char>();

        var pairings = new Dictionary<char, char>(){
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        foreach (char c in text)
        {
            if (pairings.ContainsKey(c))
            {
                stack.Push(c);
                continue;
            };

            try
            {
                var expectedOpeningSymbol = stack.Pop();

                var value = pairings[expectedOpeningSymbol];

                if (c != pairings[expectedOpeningSymbol]) return false;
            }
            catch (System.Exception)
            {
                return false;
            }

        }

        return stack.Count == 0;
    }
}