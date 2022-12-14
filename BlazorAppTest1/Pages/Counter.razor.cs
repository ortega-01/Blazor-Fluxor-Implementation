using BlazorAppTest1.Store.CounterUseCase;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorAppTest1.Pages;

public partial class Counter
{
    [Inject] private IState<CounterState>? CounterState { get; set; }
    [Inject] private IServiceProvider serviceProvider { get; init; } = null!; 
    [Inject] public IDispatcher? Dispatcher { get; set; }
    [Inject] public IStore Store { get; set; }

    protected override async Task OnInitializedAsync()
    {
    }

    private void IncrementCount()
    {
        var action = new IncrementCounterAction();
        Dispatcher?.Dispatch(action); //Dispatch our action to increment our CounterState and let the Reducers / Effects do their thing
    }
}