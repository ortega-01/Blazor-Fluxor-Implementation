using Fluxor;

namespace BlazorAppTest1.Store.CounterUseCase;

public class CounterStateReducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action)
    {
        return new CounterState(state.ClickCount + 1);
    }
}
