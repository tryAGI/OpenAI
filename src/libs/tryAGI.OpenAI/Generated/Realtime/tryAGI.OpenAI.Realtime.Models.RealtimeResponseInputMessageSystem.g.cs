#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RealtimeResponseInputMessageSystem : global::System.IEquatable<RealtimeResponseInputMessageSystem>
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
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2? RealtimeResponseInputMessageSystemVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2? RealtimeResponseInputMessageSystemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeResponseInputMessageSystemVariant2))]
#endif
        public bool IsRealtimeResponseInputMessageSystemVariant2 => RealtimeResponseInputMessageSystemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeResponseInputMessageSystemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2? value)
        {
            value = RealtimeResponseInputMessageSystemVariant2;
            return IsRealtimeResponseInputMessageSystemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2 PickRealtimeResponseInputMessageSystemVariant2() => RealtimeResponseInputMessageSystemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeResponseInputMessageSystemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputMessageSystem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields value) => new RealtimeResponseInputMessageSystem((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields?(RealtimeResponseInputMessageSystem @this) => @this.RealtimeResponseInputMessageFields;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageSystem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? value)
        {
            RealtimeResponseInputMessageFields = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputMessageSystem FromRealtimeResponseInputMessageFields(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? value) => new RealtimeResponseInputMessageSystem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputMessageSystem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2 value) => new RealtimeResponseInputMessageSystem((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2?(RealtimeResponseInputMessageSystem @this) => @this.RealtimeResponseInputMessageSystemVariant2;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageSystem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2? value)
        {
            RealtimeResponseInputMessageSystemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputMessageSystem FromRealtimeResponseInputMessageSystemVariant2(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2? value) => new RealtimeResponseInputMessageSystem(value);

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageSystem(
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? realtimeResponseInputMessageFields,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2? realtimeResponseInputMessageSystemVariant2
            )
        {
            RealtimeResponseInputMessageFields = realtimeResponseInputMessageFields;
            RealtimeResponseInputMessageSystemVariant2 = realtimeResponseInputMessageSystemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RealtimeResponseInputMessageSystemVariant2 as object ??
            RealtimeResponseInputMessageFields as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RealtimeResponseInputMessageFields?.ToString() ??
            RealtimeResponseInputMessageSystemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeResponseInputMessageFields && IsRealtimeResponseInputMessageSystemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields, TResult>? realtimeResponseInputMessageFields = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2, TResult>? realtimeResponseInputMessageSystemVariant2 = null,
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
            else if (RealtimeResponseInputMessageSystemVariant2 is { } __value1 && realtimeResponseInputMessageSystemVariant2 != null)
            {
                return realtimeResponseInputMessageSystemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields>? realtimeResponseInputMessageFields = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2>? realtimeResponseInputMessageSystemVariant2 = null,
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
            else if (RealtimeResponseInputMessageSystemVariant2 is { } __value1)
            {
                realtimeResponseInputMessageSystemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields>? realtimeResponseInputMessageFields = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2>? realtimeResponseInputMessageSystemVariant2 = null,
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
            else if (RealtimeResponseInputMessageSystemVariant2 is { } __value1)
            {
                realtimeResponseInputMessageSystemVariant2?.Invoke(__value1);
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
                RealtimeResponseInputMessageSystemVariant2,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2),
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
        public bool Equals(RealtimeResponseInputMessageSystem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields?>.Default.Equals(RealtimeResponseInputMessageFields, other.RealtimeResponseInputMessageFields) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystemVariant2?>.Default.Equals(RealtimeResponseInputMessageSystemVariant2, other.RealtimeResponseInputMessageSystemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RealtimeResponseInputMessageSystem obj1, RealtimeResponseInputMessageSystem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeResponseInputMessageSystem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RealtimeResponseInputMessageSystem obj1, RealtimeResponseInputMessageSystem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeResponseInputMessageSystem o && Equals(o);
        }
    }
}
