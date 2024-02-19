using Command.Commands;
using Command.Main;
using Command.Actions;

public class ThirdEyeCommand : UnitCommand
{
    private bool willHitTarget;

    public ThirdEyeCommand(CommandData commandData)
    {
        this.commandData = commandData;
        willHitTarget = WillHitTarget();
    }
    public override void Execute() =>
        GameService.Instance.ActionService.GetActionByType(CommandType.AttackStance).PerformAction(actorUnit, targetUnit, willHitTarget);

    public override bool WillHitTarget() => true;
}
