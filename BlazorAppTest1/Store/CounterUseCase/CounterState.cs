﻿using Fluxor;

namespace BlazorAppTest1.Store.CounterUseCase;

[FeatureState]
public partial class CounterState
{
    public int ClickCount { get; }

    private CounterState() { } // Required for creating initial state

    public CounterState(int clickCount)
    {
        ClickCount = clickCount;
    }
}
public record IncrementCounterAction();
