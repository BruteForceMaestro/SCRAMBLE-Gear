using Exiled.API.Interfaces;

namespace SCRAMBLE_Gear
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool NeedToHoldInHand { get; set; } = false;
    }
}
