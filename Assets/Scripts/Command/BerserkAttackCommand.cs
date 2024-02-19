using Command.Commands;
using Command.Main;
using Command.Actions;
using UnityEngine;
public class BerserkAttackCommand : UnitCommand
{
    private bool willHitTarget;
    private const float hitChance = 0.66f;

    public BerserkAttackCommand(CommandData commandData)
    {
        this.commandData = commandData;
        willHitTarget = WillHitTarget();
    }
    public override void Execute() =>
        GameService.Instance.ActionService.GetActionByType(CommandType.AttackStance).PerformAction(actorUnit, targetUnit, willHitTarget);

    public override bool WillHitTarget() => Random.Range(0f, 1f) < hitChance;
   
}
