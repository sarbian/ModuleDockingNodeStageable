namespace ModuleDockingNodeStageable
{
    public class ModuleDockingNodeStageable : ModuleDockingNode
    {
        public override void OnAwake()
        {
            setStagingState = false;
            base.OnAwake();
        }
    }
}
