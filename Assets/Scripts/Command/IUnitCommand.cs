using Command;
using Command.Player;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

namespace Command
{
    public abstract class IUnitCommand : ICommand
    {
        public int ActorUnitID;
        public int TargetUnitID;
        public int ActorPlayerID;
        public int TargetPlayerID;

        protected UnitController actorUnit;
        protected UnitController targetUnit;
        public abstract void Execute();

        public abstract bool WillHitTarget();
    }
}
