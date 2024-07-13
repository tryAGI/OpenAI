// ReSharper disable once CheckNamespace
namespace OpenAI;

public static partial class Prices
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
    public static double GetPriceInUsd(
        this CreateImageRequestModel model,
        CreateImageRequestSize size,
        CreateImageRequestQuality? quality = null)
    {
        quality ??= CreateImageRequestQuality.Standard;
        
        return (model, quality.Value, size) switch
        {
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Standard, CreateImageRequestSize._1024x1024) => 0.040,
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Standard, CreateImageRequestSize._1024x1792) => 0.080,
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Standard, CreateImageRequestSize._1792x1024) => 0.080,
            
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Hd, CreateImageRequestSize._1024x1024) => 0.080,
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Hd, CreateImageRequestSize._1024x1792) => 0.120,
            (CreateImageRequestModel.DallE3, CreateImageRequestQuality.Hd, CreateImageRequestSize._1792x1024) => 0.120,
            
            (CreateImageRequestModel.DallE2, _, CreateImageRequestSize._1024x1024) => 0.020,
            (CreateImageRequestModel.DallE2, _, CreateImageRequestSize._512x512) => 0.018,
            (CreateImageRequestModel.DallE2, _, CreateImageRequestSize._256x256) => 0.016,
            
            _ => throw new NotImplementedException(),
        };
    }
}