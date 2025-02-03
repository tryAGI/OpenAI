// ReSharper disable once CheckNamespace
namespace tryAGI.OpenAI;

public static partial class MetadataExtensions
{
    /// <summary>
    /// All prices in USD. <br/>
    /// According https://platform.openai.com/docs/guides/images/introduction <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="size"></param>
    /// <param name="quality"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double? TryGetPriceInUsd(
        this CreateImageRequestModel model,
        CreateImageRequestSize size,
        CreateImageRequestQuality? quality = null)
    {
        quality ??= CreateImageRequestQuality.Standard;
        
        return (model, quality.Value, size) switch
        {
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Standard, CreateImageRequestSize.x1024x1024) => 0.040,
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Standard, CreateImageRequestSize.x1024x1792) => 0.080,
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Standard, CreateImageRequestSize.x1792x1024) => 0.080,
            
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Hd, CreateImageRequestSize.x1024x1024) => 0.080,
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Hd, CreateImageRequestSize.x1024x1792) => 0.120,
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Hd, CreateImageRequestSize.x1792x1024) => 0.120,
            
            (CreateImageRequestModel.DallE2, _, CreateImageRequestSize.x1024x1024) => 0.020,
            (CreateImageRequestModel.DallE2, _, CreateImageRequestSize.x512x512) => 0.018,
            (CreateImageRequestModel.DallE2, _, CreateImageRequestSize.x256x256) => 0.016,
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGetPriceInUsd(CreateImageRequestModel, CreateImageRequestSize, CreateImageRequestQuality?)"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double GetPriceInUsd(
        this CreateImageRequestModel model,
        CreateImageRequestSize size,
        CreateImageRequestQuality? quality = null)
    {
        return model.TryGetPriceInUsd(size, quality) ??
               throw new InvalidOperationException(
                   $"Prices are not available for {model.ToValueString()}.");
    }
}