using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a CSS overflow keyword.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class OverflowKeyword
{
    /// <summary>
    /// Adds scrolling when the content requires it.
    /// </summary>
    public static readonly OverflowKeyword Auto = new("auto");
    /// <summary>
    /// Clips overflow while retaining a scroll container.
    /// </summary>
    public static readonly OverflowKeyword Hidden = new("hidden");
    /// <summary>
    /// Clips overflow without creating a scroll container.
    /// </summary>
    public static readonly OverflowKeyword Clip = new("clip");
    /// <summary>
    /// Allows content to paint outside the box.
    /// </summary>
    public static readonly OverflowKeyword Visible = new("visible");
    /// <summary>
    /// Creates a scroll container.
    /// </summary>
    public static readonly OverflowKeyword Scroll = new("scroll");
}
