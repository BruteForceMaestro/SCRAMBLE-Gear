using Exiled.API.Features;

namespace SCRAMBLE_Gear
{
    public class Main : Plugin<Config>
    {
        public ci_gear Scramble;
        public override void OnEnabled()
        {
            base.OnEnabled();

            ci_enable();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Scramble.TryUnregister();
        }

        public void ci_enable()
        {
            Scramble = new ci_gear { Type = ItemType.SCP268 };
            Scramble.TryRegister();
            Log.Info("Scramble gear initialized");
        }
    }
}
