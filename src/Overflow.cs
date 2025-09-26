using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// Typed values for the CSS overflow property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class Overflow
{
    public static readonly Overflow Auto = new("auto");
    public static readonly Overflow Hidden = new("hidden");
    public static readonly Overflow Visible = new("visible");
    public static readonly Overflow Scroll = new("scroll");

    public static implicit operator Overflow(GlobalKeyword style) => new(style.Value);
}
