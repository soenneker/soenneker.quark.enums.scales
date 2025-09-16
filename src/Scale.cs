using Intellenum;

namespace Soenneker.Quark.Enums.Scales;

/// <summary>
/// A specification of scale in .NET enumeration form
/// </summary>
[Intellenum<string>]
public sealed partial class Scale
{
    public static readonly Scale S1 = new("1");
    public static readonly Scale S2 = new("2");
    public static readonly Scale S3 = new("3");
    public static readonly Scale S4 = new("4");
    public static readonly Scale S5 = new("5");
    public static readonly Scale S6 = new("6");
}