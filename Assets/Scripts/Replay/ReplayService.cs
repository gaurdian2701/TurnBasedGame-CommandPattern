using Command.Commands;
using Command.Main;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayService : MonoBehaviour
{
    private Stack<ICommand> replayCommandStack;

    public ReplayState ReplayState { get; private set; }

    public ReplayService() => SetReplayState(ReplayState.INACTIVE);
    public void SetReplayState(ReplayState state) => ReplayState = state;

    public void SetCommandStack(Stack<ICommand> commandsToSet) => replayCommandStack = new Stack<ICommand>(commandsToSet);

    public void ExecuteNextCommand()
    {
        if(replayCommandStack.Count > 0)
            GameService.Instance.ProcessUnitCommand(replayCommandStack.Pop());  
    }
}
