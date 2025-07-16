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
        public global::tryAGI.OpenAI.ImageEditPartialImageEvent? Partial { get; init; }
#else
        public global::tryAGI.OpenAI.ImageEditPartialImageEvent? Partial { get; }
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
        public static implicit operator ImageEditStreamEvent(global::tryAGI.OpenAI.ImageEditPartialImageEvent value) => new ImageEditStreamEvent((global::tryAGI.OpenAI.ImageEditPartialImageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageEditPartialImageEvent?(ImageEditStreamEvent @this) => @this.Partial;

        /// <summary>
        /// 
        /// </summary>
        public ImageEditStreamEvent(global::tryAGI.OpenAI.ImageEditPartialImageEvent? value)
        {
            Partial = value;
        }

        /// <summary>
        /// Emitted when image editing has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ImageEditCompletedEvent? Completed { get; init; }
#else
        public global::tryAGI.OpenAI.ImageEditCompletedEvent? Completed { get; }
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
        public static implicit operator ImageEditStreamEvent(global::tryAGI.OpenAI.ImageEditCompletedEvent value) => new ImageEditStreamEvent((global::tryAGI.OpenAI.ImageEditCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageEditCompletedEvent?(ImageEditStreamEvent @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public ImageEditStreamEvent(global::tryAGI.OpenAI.ImageEditCompletedEvent? value)
        {
            Completed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageEditStreamEvent(
            global::tryAGI.OpenAI.ImageEditPartialImageEvent? partial,
            global::tryAGI.OpenAI.ImageEditCompletedEvent? completed
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
            global::System.Func<global::tryAGI.OpenAI.ImageEditPartialImageEvent?, TResult>? partial = null,
            global::System.Func<global::tryAGI.OpenAI.ImageEditCompletedEvent?, TResult>? completed = null,
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
            global::System.Action<global::tryAGI.OpenAI.ImageEditPartialImageEvent?>? partial = null,
            global::System.Action<global::tryAGI.OpenAI.ImageEditCompletedEvent?>? completed = null,
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
                typeof(global::tryAGI.OpenAI.ImageEditPartialImageEvent),
                Completed,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageEditPartialImageEvent?>.Default.Equals(Partial, other.Partial) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageEditCompletedEvent?>.Default.Equals(Completed, other.Completed) 
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
