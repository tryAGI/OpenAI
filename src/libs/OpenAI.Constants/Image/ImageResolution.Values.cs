// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/images/introduction
/// </summary>
public readonly partial record struct ImageResolutions
{
    /// <summary>
    /// Supported models: DALL·E 2. <br/>
    /// </summary>
    internal const string _256x256Value = "256x256";
    
    /// <summary>
    /// Supported models: DALL·E 2. <br/>
    /// </summary>
    internal const string _512x512Value = "512x512";

    /// <summary>
    /// Supported models: DALL·E 2, DALL·E 3. <br/>
    /// Supported qualities: Standard and HD. <br/>
    /// </summary>
    internal const string _1024x1024Value = "1024x1024";

    /// <summary>
    /// Supported models: DALL·E 3. <br/>
    /// Supported qualities: Standard and HD. <br/>
    /// </summary>
    internal const string _1024x1792Value = "1024x1792";

    /// <summary>
    /// Supported models: DALL·E 3. <br/>
    /// Supported qualities: Standard and HD. <br/>
    /// </summary>
    internal const string _1792x1024Value = "1792x1024";
    
    /// <inheritdoc cref="_256x256Value"/>
    public static ImageResolutions _256x256 { get; } = new(_256x256Value);
    
    /// <inheritdoc cref="_512x512Value"/>
    public static ImageResolutions _512x512 { get; } = new(_512x512Value);
    
    /// <inheritdoc cref="_1024x1024Value"/>
    public static ImageResolutions _1024x1024 { get; } = new(_1024x1024Value);
    
    /// <inheritdoc cref="_1024x1792Value"/>
    public static ImageResolutions _1024x1792 { get; } = new(_1024x1792Value);
    
    /// <inheritdoc cref="_1792x1024Value"/>
    public static ImageResolutions _1792x1024 { get; } = new(_1792x1024Value);
}