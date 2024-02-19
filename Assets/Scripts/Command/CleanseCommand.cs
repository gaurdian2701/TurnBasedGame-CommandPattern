using Command.Commands;
using Command.Main;
using Command.Actions;
using UnityEngine;

public class CleanseCommand : UnitCommand
{
    private const float hitChance = 0.2f;
    private bool willHitTarget;
    public CleanseCommand(CommandData commandData)
    {
        this.commandData = commandData;
        willHitTarget = WillHitTarget();
    }
    public override void Execute()
        => GameService.Instance.ActionService.GetActionByType(CommandType.AttackStance).PerformAction(actorUnit, targetUnit, willHitTarget);

    public override bool WillHitTarget() => Random.Range(0f, 1f) < hitChance;
}
