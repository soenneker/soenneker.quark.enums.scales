using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// A specification of scale in .NET enumeration form
/// </summary>
[Intellenum<string>]
public sealed partial class ScaleType
{
    public static readonly ScaleType S0 = new("0");
    public static readonly ScaleType S1 = new("1");
    public static readonly ScaleType S2 = new("2");
    public static readonly ScaleType S3 = new("3");
    public static readonly ScaleType S4 = new("4");
    public static readonly ScaleType S5 = new("5");
    public static readonly ScaleType S6 = new("6");
}
