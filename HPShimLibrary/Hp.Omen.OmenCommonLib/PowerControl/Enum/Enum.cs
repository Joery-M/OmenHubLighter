using System;
using System.Configuration;

namespace Hp.Omen.OmenCommonLib.PowerControl.Enum
{
    public enum ThermalPolicyVersion
    {
        V0,
        V1
    }

    public enum PerformanceMode
    {
        Default = 0,
        Performance = 1,
        Cool = 2,
        Quiet = 3,
        Extreme = 4,
        L8 = 4,
        L0 = 16, // 0x00000010
        L5 = 17, // 0x00000011
        L1 = 32, // 0x00000020
        L6 = 33, // 0x00000021
        L2 = 48, // 0x00000030
        L7 = 49, // 0x00000031
        L3 = 64, // 0x00000040
        L4 = 80, // 0x00000050
        Eco = 256, // 0x00000100
        Off = 0,
        Max = 0
    }

    public enum MaxFanMode
    {
        Off,
        On
    }

    public enum SupportOcControlResult
    {
        DISCONNECTED = -1,
        UNSUPPORT,
        SUPPORT
    }
    public enum FanType
    {
        Unsupported,
        Cpu,
        Gpu,
        Exhaust,
        Pump,
        Intake
    }
    public enum SmartAdapterStatus
    {
        Error = -1,
        NotSupported,
        MeetsRequirement,
        BelowRequirement,
        BatteryPower,
        NotFunctioning
    }
}