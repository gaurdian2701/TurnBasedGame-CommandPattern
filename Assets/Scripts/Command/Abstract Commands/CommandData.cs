public struct CommandData
{
    public int ActorUnitID;
    public int TargetUnitID;
    public int ActorPlayerID;
    public int TargetPlayerID;

    public CommandData(int _ActorUnitID, int _TargetUnitID, int _ActorPlayerID, int _TargetPlayerID)
    {
        this.ActorUnitID = _ActorUnitID;
        this.TargetUnitID = _TargetUnitID;
        this.ActorPlayerID = _ActorPlayerID;
        this.TargetPlayerID = _TargetPlayerID;
    }
}