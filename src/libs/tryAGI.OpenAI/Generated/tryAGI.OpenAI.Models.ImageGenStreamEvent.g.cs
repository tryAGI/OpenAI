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
        public global::tryAGI.OpenAI.ImageGenPartialImageEvent? Partial { get; init; }
#else
        public global::tryAGI.OpenAI.ImageGenPartialImageEvent? Partial { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Partial))]
#endif
        public bool IsPartial => Partial != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenStreamEvent(global::tryAGI.OpenAI.ImageGenPartialImageEvent value) => new ImageGenStreamEvent((global::tryAGI.OpenAI.ImageGenPartialImageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenPartialImageEvent?(ImageGenStreamEvent @this) => @this.Partial;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenStreamEvent(global::tryAGI.OpenAI.ImageGenPartialImageEvent? value)
        {
            Partial = value;
        }

        /// <summary>
        /// Emitted when image generation has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ImageGenCompletedEvent? Completed { get; init; }
#else
        public global::tryAGI.OpenAI.ImageGenCompletedEvent? Completed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenStreamEvent(global::tryAGI.OpenAI.ImageGenCompletedEvent value) => new ImageGenStreamEvent((global::tryAGI.OpenAI.ImageGenCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenCompletedEvent?(ImageGenStreamEvent @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenStreamEvent(global::tryAGI.OpenAI.ImageGenCompletedEvent? value)
        {
            Completed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageGenStreamEvent(
            global::tryAGI.OpenAI.ImageGenPartialImageEvent? partial,
            global::tryAGI.OpenAI.ImageGenCompletedEvent? completed
            )
        {
            Partial = partial;
            Completed = completed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Completed as object ??
            Partial as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Partial?.ToString() ??
            Completed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPartial || IsCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ImageGenPartialImageEvent?, TResult>? partial = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenCompletedEvent?, TResult>? completed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPartial && partial != null)
            {
                return partial(Partial!);
            }
            else if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ImageGenPartialImageEvent?>? partial = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenCompletedEvent?>? completed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPartial)
            {
                partial?.Invoke(Partial!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Partial,
                typeof(global::tryAGI.OpenAI.ImageGenPartialImageEvent),
                Completed,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenPartialImageEvent?>.Default.Equals(Partial, other.Partial) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenCompletedEvent?>.Default.Equals(Completed, other.Completed) 
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
