// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ImageQualities
{
    /// <summary>
    /// By default, images are generated at standard quality, but when using DALL·E 3 you can set quality: "hd" for enhanced detail. Square, standard quality images are the fastest to generate. <br/>
    /// </summary>
    internal const string StandardValue = "standard";
    
    /// <summary>
    /// By default, images are generated at standard quality, but when using DALL·E 3 you can set quality: "hd" for enhanced detail. Square, standard quality images are the fastest to generate. <br/>
    /// </summary>
    internal const string HdValue = "hd";
    
    /// <inheritdoc cref="StandardValue"/>
    public static ImageQualities Standard { get; } = new(StandardValue);
    
    /// <inheritdoc cref="HdValue"/>
    public static ImageQualities Hd { get; } = new(HdValue);
}