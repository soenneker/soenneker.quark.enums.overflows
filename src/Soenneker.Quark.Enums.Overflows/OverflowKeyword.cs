using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Typed values for the CSS overflow property in .NET enumeration form.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class OverflowKeyword
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly OverflowKeyword Auto = new("auto");
    /// <summary>
    /// The hidden.
    /// </summary>
    public static readonly OverflowKeyword Hidden = new("hidden");
    /// <summary>
    /// The clip.
    /// </summary>
    public static readonly OverflowKeyword Clip = new("clip");
    /// <summary>
    /// The visible.
    /// </summary>
    public static readonly OverflowKeyword Visible = new("visible");
    /// <summary>
    /// The scroll.
    /// </summary>
    public static readonly OverflowKeyword Scroll = new("scroll");
}
