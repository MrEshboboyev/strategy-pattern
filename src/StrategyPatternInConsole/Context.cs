using StrategyPatternInConsole.Strategies;

namespace StrategyPatternInConsole;

// The Context defines the interface of interest to clients.
public class Context
{
    // The Context maintains a reference to one of the Strategy objects. The
    // Context does not know the concrete class of a strategy. It should work
    // with all strategies via the Strategy interface.
    private IStrategy _strategy;
    public Context()
    {
        
    }
    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }
    // Usually, the Context allows replacing a Strategy object at runtime.
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }
    // The Context delegates some work to the Strategy object instead of
    // implementing multiple versions of the algorithm on its own.
    public void DoSomeBusinessLogic()
    {
        var result = _strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

        string resultStr = string.Empty;
        foreach (var element in result as List<string>)
        {
            resultStr += element + ",";
        }

        Console.WriteLine(resultStr);
    }
}
