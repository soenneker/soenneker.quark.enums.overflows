using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Typed values for the CSS overflow property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class OverflowKeywordKeyword
{
    public static readonly OverflowKeyword Auto = new("auto");
    public static readonly OverflowKeyword Hidden = new("hidden");
    public static readonly OverflowKeyword Visible = new("visible");
    public static readonly OverflowKeyword Scroll = new("scroll");

    public static implicit operator OverflowKeyword(GlobalKeyword style) => new(style.Value);
}
