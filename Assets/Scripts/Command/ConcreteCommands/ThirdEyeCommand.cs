using Command.Main;

namespace Command.Commands
{
    public class ThirdEyeCommand : UnitCommand
    {
        private bool willHitTarget;
        private int previousHealth;
        private int previousPowerStat;

        public ThirdEyeCommand(CommandData commandData)
        {
            this.commandData = commandData;
            willHitTarget = WillHitTarget();
        }

        public override void Execute()
        {
            previousHealth = targetUnit.CurrentHealth;
            previousPowerStat = targetUnit.CurrentPower;
            GameService.Instance.ActionService.GetActionByType(CommandType.ThirdEye).PerformAction(actorUnit, targetUnit, willHitTarget);
        }

        public override void Undo()
        {
            if(willHitTarget)
            {
                if(!targetUnit.IsAlive())
                    targetUnit.Revive();

                var healthToRestore = previousHealth - targetUnit.CurrentHealth;
                targetUnit.RestoreHealth(healthToRestore);
                targetUnit.CurrentPower = previousPowerStat;
            }

            actorUnit.Owner.ResetCurrentActiveUnit();
        }

        public override bool WillHitTarget() => true;
    } 
}
