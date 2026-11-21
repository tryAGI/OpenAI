#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RealtimeResponseInputMessageUser : global::System.IEquatable<RealtimeResponseInputMessageUser>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFields? RealtimeResponseInputMessageFields { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFields? RealtimeResponseInputMessageFields { get; }
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
            out global::tryAGI.OpenAI.RealtimeResponseInputMessageFields? value)
        {
            value = RealtimeResponseInputMessageFields;
            return IsRealtimeResponseInputMessageFields;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFields PickRealtimeResponseInputMessageFields() => RealtimeResponseInputMessageFields is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeResponseInputMessageFields' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2? RealtimeResponseInputMessageUserVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2? RealtimeResponseInputMessageUserVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeResponseInputMessageUserVariant2))]
#endif
        public bool IsRealtimeResponseInputMessageUserVariant2 => RealtimeResponseInputMessageUserVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeResponseInputMessageUserVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2? value)
        {
            value = RealtimeResponseInputMessageUserVariant2;
            return IsRealtimeResponseInputMessageUserVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2 PickRealtimeResponseInputMessageUserVariant2() => RealtimeResponseInputMessageUserVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeResponseInputMessageUserVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputMessageUser(global::tryAGI.OpenAI.RealtimeResponseInputMessageFields value) => new RealtimeResponseInputMessageUser((global::tryAGI.OpenAI.RealtimeResponseInputMessageFields?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeResponseInputMessageFields?(RealtimeResponseInputMessageUser @this) => @this.RealtimeResponseInputMessageFields;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageUser(global::tryAGI.OpenAI.RealtimeResponseInputMessageFields? value)
        {
            RealtimeResponseInputMessageFields = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputMessageUser FromRealtimeResponseInputMessageFields(global::tryAGI.OpenAI.RealtimeResponseInputMessageFields? value) => new RealtimeResponseInputMessageUser(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputMessageUser(global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2 value) => new RealtimeResponseInputMessageUser((global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2?(RealtimeResponseInputMessageUser @this) => @this.RealtimeResponseInputMessageUserVariant2;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageUser(global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2? value)
        {
            RealtimeResponseInputMessageUserVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputMessageUser FromRealtimeResponseInputMessageUserVariant2(global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2? value) => new RealtimeResponseInputMessageUser(value);

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageUser(
            global::tryAGI.OpenAI.RealtimeResponseInputMessageFields? realtimeResponseInputMessageFields,
            global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2? realtimeResponseInputMessageUserVariant2
            )
        {
            RealtimeResponseInputMessageFields = realtimeResponseInputMessageFields;
            RealtimeResponseInputMessageUserVariant2 = realtimeResponseInputMessageUserVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RealtimeResponseInputMessageUserVariant2 as object ??
            RealtimeResponseInputMessageFields as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RealtimeResponseInputMessageFields?.ToString() ??
            RealtimeResponseInputMessageUserVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeResponseInputMessageFields && IsRealtimeResponseInputMessageUserVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeResponseInputMessageFields, TResult>? realtimeResponseInputMessageFields = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2, TResult>? realtimeResponseInputMessageUserVariant2 = null,
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
            else if (RealtimeResponseInputMessageUserVariant2 is { } __value1 && realtimeResponseInputMessageUserVariant2 != null)
            {
                return realtimeResponseInputMessageUserVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputMessageFields>? realtimeResponseInputMessageFields = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2>? realtimeResponseInputMessageUserVariant2 = null,
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
            else if (RealtimeResponseInputMessageUserVariant2 is { } __value1)
            {
                realtimeResponseInputMessageUserVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputMessageFields>? realtimeResponseInputMessageFields = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2>? realtimeResponseInputMessageUserVariant2 = null,
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
            else if (RealtimeResponseInputMessageUserVariant2 is { } __value1)
            {
                realtimeResponseInputMessageUserVariant2?.Invoke(__value1);
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
                typeof(global::tryAGI.OpenAI.RealtimeResponseInputMessageFields),
                RealtimeResponseInputMessageUserVariant2,
                typeof(global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2),
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
        public bool Equals(RealtimeResponseInputMessageUser other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeResponseInputMessageFields?>.Default.Equals(RealtimeResponseInputMessageFields, other.RealtimeResponseInputMessageFields) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2?>.Default.Equals(RealtimeResponseInputMessageUserVariant2, other.RealtimeResponseInputMessageUserVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RealtimeResponseInputMessageUser obj1, RealtimeResponseInputMessageUser obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeResponseInputMessageUser>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RealtimeResponseInputMessageUser obj1, RealtimeResponseInputMessageUser obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeResponseInputMessageUser o && Equals(o);
        }
    }
}
