#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RealtimeResponseInputMessageAssistant : global::System.IEquatable<RealtimeResponseInputMessageAssistant>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? RealtimeResponseInputMessageFields { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? RealtimeResponseInputMessageFields { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeResponseInputMessageFields))]
#endif
        public bool IsRealtimeResponseInputMessageFields => RealtimeResponseInputMessageFields != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeResponseInputMessageFields(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? value)
        {
            value = RealtimeResponseInputMessageFields;
            return IsRealtimeResponseInputMessageFields;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields PickRealtimeResponseInputMessageFields() => RealtimeResponseInputMessageFields is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeResponseInputMessageFields' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2? RealtimeResponseInputMessageAssistantVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2? RealtimeResponseInputMessageAssistantVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeResponseInputMessageAssistantVariant2))]
#endif
        public bool IsRealtimeResponseInputMessageAssistantVariant2 => RealtimeResponseInputMessageAssistantVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeResponseInputMessageAssistantVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2? value)
        {
            value = RealtimeResponseInputMessageAssistantVariant2;
            return IsRealtimeResponseInputMessageAssistantVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2 PickRealtimeResponseInputMessageAssistantVariant2() => RealtimeResponseInputMessageAssistantVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeResponseInputMessageAssistantVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputMessageAssistant(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields value) => new RealtimeResponseInputMessageAssistant((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields?(RealtimeResponseInputMessageAssistant @this) => @this.RealtimeResponseInputMessageFields;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageAssistant(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? value)
        {
            RealtimeResponseInputMessageFields = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputMessageAssistant FromRealtimeResponseInputMessageFields(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? value) => new RealtimeResponseInputMessageAssistant(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputMessageAssistant(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2 value) => new RealtimeResponseInputMessageAssistant((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2?(RealtimeResponseInputMessageAssistant @this) => @this.RealtimeResponseInputMessageAssistantVariant2;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageAssistant(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2? value)
        {
            RealtimeResponseInputMessageAssistantVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputMessageAssistant FromRealtimeResponseInputMessageAssistantVariant2(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2? value) => new RealtimeResponseInputMessageAssistant(value);

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageAssistant(
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? realtimeResponseInputMessageFields,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2? realtimeResponseInputMessageAssistantVariant2
            )
        {
            RealtimeResponseInputMessageFields = realtimeResponseInputMessageFields;
            RealtimeResponseInputMessageAssistantVariant2 = realtimeResponseInputMessageAssistantVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RealtimeResponseInputMessageAssistantVariant2 as object ??
            RealtimeResponseInputMessageFields as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RealtimeResponseInputMessageFields?.ToString() ??
            RealtimeResponseInputMessageAssistantVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeResponseInputMessageFields && IsRealtimeResponseInputMessageAssistantVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields, TResult>? realtimeResponseInputMessageFields = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2, TResult>? realtimeResponseInputMessageAssistantVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RealtimeResponseInputMessageFields is { } __value0 && realtimeResponseInputMessageFields != null)
            {
                return realtimeResponseInputMessageFields(__value0);
            }
            else if (RealtimeResponseInputMessageAssistantVariant2 is { } __value1 && realtimeResponseInputMessageAssistantVariant2 != null)
            {
                return realtimeResponseInputMessageAssistantVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields>? realtimeResponseInputMessageFields = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2>? realtimeResponseInputMessageAssistantVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RealtimeResponseInputMessageFields is { } __value0)
            {
                realtimeResponseInputMessageFields?.Invoke(__value0);
            }
            else if (RealtimeResponseInputMessageAssistantVariant2 is { } __value1)
            {
                realtimeResponseInputMessageAssistantVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields>? realtimeResponseInputMessageFields = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2>? realtimeResponseInputMessageAssistantVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RealtimeResponseInputMessageFields is { } __value0)
            {
                realtimeResponseInputMessageFields?.Invoke(__value0);
            }
            else if (RealtimeResponseInputMessageAssistantVariant2 is { } __value1)
            {
                realtimeResponseInputMessageAssistantVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RealtimeResponseInputMessageFields,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields),
                RealtimeResponseInputMessageAssistantVariant2,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2),
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
        public bool Equals(RealtimeResponseInputMessageAssistant other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields?>.Default.Equals(RealtimeResponseInputMessageFields, other.RealtimeResponseInputMessageFields) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2?>.Default.Equals(RealtimeResponseInputMessageAssistantVariant2, other.RealtimeResponseInputMessageAssistantVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RealtimeResponseInputMessageAssistant obj1, RealtimeResponseInputMessageAssistant obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeResponseInputMessageAssistant>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RealtimeResponseInputMessageAssistant obj1, RealtimeResponseInputMessageAssistant obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeResponseInputMessageAssistant o && Equals(o);
        }
    }
}
