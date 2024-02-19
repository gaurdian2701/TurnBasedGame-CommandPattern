using Command;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    private Stack<ICommand> commandRegistry = new Stack<ICommand>();

    public void ProcessCommand(ICommand commandToProcess)
    {
        ExecuteCommand(commandToProcess);
        RegisterCommand(commandToProcess);
    }

    public void ExecuteCommand(ICommand command) => command.Execute();
    private void RegisterCommand(ICommand commandToProcess)
    {
        commandRegistry.Push(commandToProcess);
    }
}
