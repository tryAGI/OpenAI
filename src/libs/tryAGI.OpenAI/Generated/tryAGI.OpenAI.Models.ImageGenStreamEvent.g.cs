#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageGenStreamEvent : global::System.IEquatable<ImageGenStreamEvent>
    {
        /// <summary>
        /// Emitted when a partial image is available during image generation streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ImageGenPartialImageEvent? ImageGenerationPartialImage { get; init; }
#else
        public global::tryAGI.OpenAI.ImageGenPartialImageEvent? ImageGenerationPartialImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationPartialImage))]
#endif
        public bool IsImageGenerationPartialImage => ImageGenerationPartialImage != null;

        /// <summary>
        /// Emitted when image generation has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ImageGenCompletedEvent? ImageGenerationCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ImageGenCompletedEvent? ImageGenerationCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationCompleted))]
#endif
        public bool IsImageGenerationCompleted => ImageGenerationCompleted != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenStreamEvent(global::tryAGI.OpenAI.ImageGenPartialImageEvent value) => new ImageGenStreamEvent((global::tryAGI.OpenAI.ImageGenPartialImageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenPartialImageEvent?(ImageGenStreamEvent @this) => @this.ImageGenerationPartialImage;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenStreamEvent(global::tryAGI.OpenAI.ImageGenPartialImageEvent? value)
        {
            ImageGenerationPartialImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenStreamEvent(global::tryAGI.OpenAI.ImageGenCompletedEvent value) => new ImageGenStreamEvent((global::tryAGI.OpenAI.ImageGenCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenCompletedEvent?(ImageGenStreamEvent @this) => @this.ImageGenerationCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenStreamEvent(global::tryAGI.OpenAI.ImageGenCompletedEvent? value)
        {
            ImageGenerationCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageGenStreamEvent(
            global::tryAGI.OpenAI.ImageGenPartialImageEvent? imageGenerationPartialImage,
            global::tryAGI.OpenAI.ImageGenCompletedEvent? imageGenerationCompleted
            )
        {
            ImageGenerationPartialImage = imageGenerationPartialImage;
            ImageGenerationCompleted = imageGenerationCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageGenerationCompleted as object ??
            ImageGenerationPartialImage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageGenerationPartialImage?.ToString() ??
            ImageGenerationCompleted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageGenerationPartialImage || IsImageGenerationCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ImageGenPartialImageEvent?, TResult>? imageGenerationPartialImage = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenCompletedEvent?, TResult>? imageGenerationCompleted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageGenerationPartialImage && imageGenerationPartialImage != null)
            {
                return imageGenerationPartialImage(ImageGenerationPartialImage!);
            }
            else if (IsImageGenerationCompleted && imageGenerationCompleted != null)
            {
                return imageGenerationCompleted(ImageGenerationCompleted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ImageGenPartialImageEvent?>? imageGenerationPartialImage = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenCompletedEvent?>? imageGenerationCompleted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageGenerationPartialImage)
            {
                imageGenerationPartialImage?.Invoke(ImageGenerationPartialImage!);
            }
            else if (IsImageGenerationCompleted)
            {
                imageGenerationCompleted?.Invoke(ImageGenerationCompleted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageGenerationPartialImage,
                typeof(global::tryAGI.OpenAI.ImageGenPartialImageEvent),
                ImageGenerationCompleted,
                typeof(global::tryAGI.OpenAI.ImageGenCompletedEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ImageGenStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenPartialImageEvent?>.Default.Equals(ImageGenerationPartialImage, other.ImageGenerationPartialImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenCompletedEvent?>.Default.Equals(ImageGenerationCompleted, other.ImageGenerationCompleted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageGenStreamEvent obj1, ImageGenStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageGenStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageGenStreamEvent obj1, ImageGenStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenStreamEvent o && Equals(o);
        }
    }
}
