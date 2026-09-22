
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>), TypeInfoPropertyName = "AnyOfByteArrayIListByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground), TypeInfoPropertyName = "CreateImageEditRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel), TypeInfoPropertyName = "CreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>), TypeInfoPropertyName = "AnyOfStringCreateImageEditRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize), TypeInfoPropertyName = "CreateImageEditRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat), TypeInfoPropertyName = "CreateImageEditRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat), TypeInfoPropertyName = "CreateImageEditRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFidelity), TypeInfoPropertyName = "InputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality), TypeInfoPropertyName = "CreateImageEditRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestModel), TypeInfoPropertyName = "CreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestQuality), TypeInfoPropertyName = "CreateImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat), TypeInfoPropertyName = "CreateImageRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat), TypeInfoPropertyName = "CreateImageRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>), TypeInfoPropertyName = "AnyOfStringCreateImageRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestSize), TypeInfoPropertyName = "CreateImageRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestModeration), TypeInfoPropertyName = "CreateImageRequestModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestBackground), TypeInfoPropertyName = "CreateImageRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestStyle), TypeInfoPropertyName = "CreateImageRequestStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageVariationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequestModel), TypeInfoPropertyName = "CreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat), TypeInfoPropertyName = "CreateImageVariationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequestSize), TypeInfoPropertyName = "CreateImageVariationRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?, object>), TypeInfoPropertyName = "AnyOfStringEditImageBodyJsonParamModelObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel), TypeInfoPropertyName = "EditImageBodyJsonParamModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ImageRefParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageRefParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality), TypeInfoPropertyName = "EditImageBodyJsonParamQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity), TypeInfoPropertyName = "EditImageBodyJsonParamInputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?, object>), TypeInfoPropertyName = "AnyOfStringEditImageBodyJsonParamSizeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize), TypeInfoPropertyName = "EditImageBodyJsonParamSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat), TypeInfoPropertyName = "EditImageBodyJsonParamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration), TypeInfoPropertyName = "EditImageBodyJsonParamModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground), TypeInfoPropertyName = "EditImageBodyJsonParamBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Image2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventType), TypeInfoPropertyName = "ImageEditCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditCompletedEventSize?>), TypeInfoPropertyName = "AnyOfStringImageEditCompletedEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventSize), TypeInfoPropertyName = "ImageEditCompletedEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventQuality), TypeInfoPropertyName = "ImageEditCompletedEventQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventBackground), TypeInfoPropertyName = "ImageEditCompletedEventBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat), TypeInfoPropertyName = "ImageEditCompletedEventOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventType), TypeInfoPropertyName = "ImageEditPartialImageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditPartialImageEventSize?>), TypeInfoPropertyName = "AnyOfStringImageEditPartialImageEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventSize), TypeInfoPropertyName = "ImageEditPartialImageEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventQuality), TypeInfoPropertyName = "ImageEditPartialImageEventQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventBackground), TypeInfoPropertyName = "ImageEditPartialImageEventBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat), TypeInfoPropertyName = "ImageEditPartialImageEventOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditStreamEvent), TypeInfoPropertyName = "ImageEditStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType), TypeInfoPropertyName = "ImageEditStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType), TypeInfoPropertyName = "ImageGenCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>), TypeInfoPropertyName = "AnyOfStringImageGenCompletedEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize), TypeInfoPropertyName = "ImageGenCompletedEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality), TypeInfoPropertyName = "ImageGenCompletedEventQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground), TypeInfoPropertyName = "ImageGenCompletedEventBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat), TypeInfoPropertyName = "ImageGenCompletedEventOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType), TypeInfoPropertyName = "ImageGenPartialImageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>), TypeInfoPropertyName = "AnyOfStringImageGenPartialImageEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize), TypeInfoPropertyName = "ImageGenPartialImageEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality), TypeInfoPropertyName = "ImageGenPartialImageEventQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground), TypeInfoPropertyName = "ImageGenPartialImageEventBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat), TypeInfoPropertyName = "ImageGenPartialImageEventOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenStreamEvent), TypeInfoPropertyName = "ImageGenStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType), TypeInfoPropertyName = "ImageGenStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Image2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseBackground), TypeInfoPropertyName = "ImagesResponseBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseOutputFormat), TypeInfoPropertyName = "ImagesResponseOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImagesResponseSize?>), TypeInfoPropertyName = "AnyOfStringImagesResponseSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseSize), TypeInfoPropertyName = "ImagesResponseSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseQuality), TypeInfoPropertyName = "ImagesResponseQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenInputUsageDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>?), TypeInfoPropertyName = "NullableAnyOfByteArrayIListByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground?), TypeInfoPropertyName = "NullableCreateImageEditRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel?), TypeInfoPropertyName = "NullableCreateImageEditRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageEditRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize?), TypeInfoPropertyName = "NullableCreateImageEditRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImageEditRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateImageEditRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFidelity?), TypeInfoPropertyName = "NullableInputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality?), TypeInfoPropertyName = "NullableCreateImageEditRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestModel?), TypeInfoPropertyName = "NullableCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestQuality?), TypeInfoPropertyName = "NullableCreateImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImageRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateImageRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestSize?), TypeInfoPropertyName = "NullableCreateImageRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestModeration?), TypeInfoPropertyName = "NullableCreateImageRequestModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestBackground?), TypeInfoPropertyName = "NullableCreateImageRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageRequestStyle?), TypeInfoPropertyName = "NullableCreateImageRequestStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageVariationRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequestModel?), TypeInfoPropertyName = "NullableCreateImageVariationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImageVariationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateImageVariationRequestSize?), TypeInfoPropertyName = "NullableCreateImageVariationRequestSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?, object>?), TypeInfoPropertyName = "NullableAnyOfStringEditImageBodyJsonParamModelObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel?), TypeInfoPropertyName = "NullableEditImageBodyJsonParamModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality?), TypeInfoPropertyName = "NullableEditImageBodyJsonParamQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity?), TypeInfoPropertyName = "NullableEditImageBodyJsonParamInputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?, object>?), TypeInfoPropertyName = "NullableAnyOfStringEditImageBodyJsonParamSizeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize?), TypeInfoPropertyName = "NullableEditImageBodyJsonParamSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat?), TypeInfoPropertyName = "NullableEditImageBodyJsonParamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration?), TypeInfoPropertyName = "NullableEditImageBodyJsonParamModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground?), TypeInfoPropertyName = "NullableEditImageBodyJsonParamBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventType?), TypeInfoPropertyName = "NullableImageEditCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditCompletedEventSize?>?), TypeInfoPropertyName = "NullableAnyOfStringImageEditCompletedEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventSize?), TypeInfoPropertyName = "NullableImageEditCompletedEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventQuality?), TypeInfoPropertyName = "NullableImageEditCompletedEventQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventBackground?), TypeInfoPropertyName = "NullableImageEditCompletedEventBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat?), TypeInfoPropertyName = "NullableImageEditCompletedEventOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventType?), TypeInfoPropertyName = "NullableImageEditPartialImageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageEditPartialImageEventSize?>?), TypeInfoPropertyName = "NullableAnyOfStringImageEditPartialImageEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventSize?), TypeInfoPropertyName = "NullableImageEditPartialImageEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventQuality?), TypeInfoPropertyName = "NullableImageEditPartialImageEventQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventBackground?), TypeInfoPropertyName = "NullableImageEditPartialImageEventBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat?), TypeInfoPropertyName = "NullableImageEditPartialImageEventOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditStreamEvent?), TypeInfoPropertyName = "NullableImageEditStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableImageEditStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType?), TypeInfoPropertyName = "NullableImageGenCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>?), TypeInfoPropertyName = "NullableAnyOfStringImageGenCompletedEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize?), TypeInfoPropertyName = "NullableImageGenCompletedEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality?), TypeInfoPropertyName = "NullableImageGenCompletedEventQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground?), TypeInfoPropertyName = "NullableImageGenCompletedEventBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat?), TypeInfoPropertyName = "NullableImageGenCompletedEventOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType?), TypeInfoPropertyName = "NullableImageGenPartialImageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>?), TypeInfoPropertyName = "NullableAnyOfStringImageGenPartialImageEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize?), TypeInfoPropertyName = "NullableImageGenPartialImageEventSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality?), TypeInfoPropertyName = "NullableImageGenPartialImageEventQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground?), TypeInfoPropertyName = "NullableImageGenPartialImageEventBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat?), TypeInfoPropertyName = "NullableImageGenPartialImageEventOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenStreamEvent?), TypeInfoPropertyName = "NullableImageGenStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableImageGenStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseBackground?), TypeInfoPropertyName = "NullableImagesResponseBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseOutputFormat?), TypeInfoPropertyName = "NullableImagesResponseOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImagesResponseSize?>?), TypeInfoPropertyName = "NullableAnyOfStringImagesResponseSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseSize?), TypeInfoPropertyName = "NullableImagesResponseSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImagesResponseQuality?), TypeInfoPropertyName = "NullableImagesResponseQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.List<byte[]>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ImageRefParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Image2>))]
    internal sealed partial class ImagesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ImageEditStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ImageGenStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageRequestSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageVariationRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageEditCompletedEventSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageEditPartialImageEventSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImagesResponseSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.Error, string>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestResponseFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageVariationRequestSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamInputFidelityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamInputFidelityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditPartialImageEventOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditPartialImageEventOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageEditStreamEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageEditStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImagesResponseBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImagesResponseBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImagesResponseOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImagesResponseOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImagesResponseSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImagesResponseSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImagesResponseQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImagesResponseQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImagesResponseQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFidelityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFidelityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ImagesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}