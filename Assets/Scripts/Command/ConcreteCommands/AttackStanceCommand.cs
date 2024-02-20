using Command.Main;

namespace Command.Commands
{
    public class AttackStanceCommand : UnitCommand
    {
        private bool willHitTarget;
        private int previousPowerStat;

        public AttackStanceCommand(CommandData commandData)
        {
            this.commandData = commandData;
            willHitTarget = WillHitTarget();
        }

        public override void Execute()
        {
            previousPowerStat = targetUnit.CurrentPower;
            GameService.Instance.ActionService.GetActionByType(CommandType.AttackStance).PerformAction(actorUnit, targetUnit, willHitTarget);
        }

        public override void Undo()
        {
            if(willHitTarget)
                targetUnit.CurrentPower = previousPowerStat;
            
            actorUnit.Owner.ResetCurrentActiveUnit();
        }

        public override bool WillHitTarget() => true;
    }
}
