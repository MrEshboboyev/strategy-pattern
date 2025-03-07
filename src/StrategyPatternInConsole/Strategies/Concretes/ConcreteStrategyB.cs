namespace StrategyPatternInConsole.Strategies.Concretes;

// Concrete Strategies implement the algorithm while following the base Strategy
// interface. The interface makes them interchangeable in the Context.
public class ConcreteStrategyB : IStrategy
{
    public object DoAlgorithm(object data)
    {
        var list = data as List<string>;
        list!.Sort();
        list!.Reverse();
        return list;
    }
}
