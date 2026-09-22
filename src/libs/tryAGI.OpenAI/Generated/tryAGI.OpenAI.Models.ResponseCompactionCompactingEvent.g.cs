#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseCompactionCompactingEvent : global::System.IEquatable<ResponseCompactionCompactingEvent>
    {
        /// <summary>
        /// Emitted when new summary content is sampled for a compaction trigger. Contains no summary content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? Streaming { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? Streaming { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Streaming))]
#endif
        public bool IsStreaming => Streaming != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreaming(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? value)
        {
            value = Streaming;
            return IsStreaming;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent PickStreaming() => IsStreaming
            ? Streaming!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Streaming' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseCompactionCompactingEvent(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent value) => new ResponseCompactionCompactingEvent((global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent?(ResponseCompactionCompactingEvent @this) => @this.Streaming;

        /// <summary>
        ///
        /// </summary>
        public ResponseCompactionCompactingEvent(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? value)
        {
            Streaming = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseCompactionCompactingEvent FromStreaming(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? value) => new ResponseCompactionCompactingEvent(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Streaming as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Streaming?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStreaming;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, TResult>? streaming = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreaming && streaming != null)
            {
                return streaming(Streaming!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent>? streaming = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreaming)
            {
                streaming?.Invoke(Streaming!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent>? streaming = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreaming)
            {
                streaming?.Invoke(Streaming!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Streaming,
                typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent),
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
        public bool Equals(ResponseCompactionCompactingEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent?>.Default.Equals(Streaming, other.Streaming)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseCompactionCompactingEvent obj1, ResponseCompactionCompactingEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseCompactionCompactingEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseCompactionCompactingEvent obj1, ResponseCompactionCompactingEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseCompactionCompactingEvent o && Equals(o);
        }
    }
}
