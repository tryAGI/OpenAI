#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageEditStreamEvent : global::System.IEquatable<ImageEditStreamEvent>
    {
        /// <summary>
        /// Emitted when a partial image is available during image editing streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ImageEditPartialImageEvent? ImageEditPartialImage { get; init; }
#else
        public global::tryAGI.OpenAI.ImageEditPartialImageEvent? ImageEditPartialImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageEditPartialImage))]
#endif
        public bool IsImageEditPartialImage => ImageEditPartialImage != null;

        /// <summary>
        /// Emitted when image editing has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ImageEditCompletedEvent? ImageEditCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ImageEditCompletedEvent? ImageEditCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageEditCompleted))]
#endif
        public bool IsImageEditCompleted => ImageEditCompleted != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageEditStreamEvent(global::tryAGI.OpenAI.ImageEditPartialImageEvent value) => new ImageEditStreamEvent((global::tryAGI.OpenAI.ImageEditPartialImageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageEditPartialImageEvent?(ImageEditStreamEvent @this) => @this.ImageEditPartialImage;

        /// <summary>
        /// 
        /// </summary>
        public ImageEditStreamEvent(global::tryAGI.OpenAI.ImageEditPartialImageEvent? value)
        {
            ImageEditPartialImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageEditStreamEvent(global::tryAGI.OpenAI.ImageEditCompletedEvent value) => new ImageEditStreamEvent((global::tryAGI.OpenAI.ImageEditCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageEditCompletedEvent?(ImageEditStreamEvent @this) => @this.ImageEditCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ImageEditStreamEvent(global::tryAGI.OpenAI.ImageEditCompletedEvent? value)
        {
            ImageEditCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageEditStreamEvent(
            global::tryAGI.OpenAI.ImageEditPartialImageEvent? imageEditPartialImage,
            global::tryAGI.OpenAI.ImageEditCompletedEvent? imageEditCompleted
            )
        {
            ImageEditPartialImage = imageEditPartialImage;
            ImageEditCompleted = imageEditCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageEditCompleted as object ??
            ImageEditPartialImage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageEditPartialImage?.ToString() ??
            ImageEditCompleted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageEditPartialImage || IsImageEditCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ImageEditPartialImageEvent?, TResult>? imageEditPartialImage = null,
            global::System.Func<global::tryAGI.OpenAI.ImageEditCompletedEvent?, TResult>? imageEditCompleted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageEditPartialImage && imageEditPartialImage != null)
            {
                return imageEditPartialImage(ImageEditPartialImage!);
            }
            else if (IsImageEditCompleted && imageEditCompleted != null)
            {
                return imageEditCompleted(ImageEditCompleted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ImageEditPartialImageEvent?>? imageEditPartialImage = null,
            global::System.Action<global::tryAGI.OpenAI.ImageEditCompletedEvent?>? imageEditCompleted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageEditPartialImage)
            {
                imageEditPartialImage?.Invoke(ImageEditPartialImage!);
            }
            else if (IsImageEditCompleted)
            {
                imageEditCompleted?.Invoke(ImageEditCompleted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageEditPartialImage,
                typeof(global::tryAGI.OpenAI.ImageEditPartialImageEvent),
                ImageEditCompleted,
                typeof(global::tryAGI.OpenAI.ImageEditCompletedEvent),
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
        public bool Equals(ImageEditStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageEditPartialImageEvent?>.Default.Equals(ImageEditPartialImage, other.ImageEditPartialImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageEditCompletedEvent?>.Default.Equals(ImageEditCompleted, other.ImageEditCompleted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageEditStreamEvent obj1, ImageEditStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageEditStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageEditStreamEvent obj1, ImageEditStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageEditStreamEvent o && Equals(o);
        }
    }
}
