// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/images/introduction
/// </summary>
public readonly partial record struct ImageQuality
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
    public static ImageQuality Standard { get; } = new(StandardValue);
    
    /// <inheritdoc cref="HdValue"/>
    public static ImageQuality Hd { get; } = new(HdValue);
}