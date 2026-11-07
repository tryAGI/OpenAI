#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RealtimeResponseInputMessageDeveloper : global::System.IEquatable<RealtimeResponseInputMessageDeveloper>
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
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2? RealtimeResponseInputMessageDeveloperVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2? RealtimeResponseInputMessageDeveloperVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeResponseInputMessageDeveloperVariant2))]
#endif
        public bool IsRealtimeResponseInputMessageDeveloperVariant2 => RealtimeResponseInputMessageDeveloperVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeResponseInputMessageDeveloperVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2? value)
        {
            value = RealtimeResponseInputMessageDeveloperVariant2;
            return IsRealtimeResponseInputMessageDeveloperVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2 PickRealtimeResponseInputMessageDeveloperVariant2() => RealtimeResponseInputMessageDeveloperVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeResponseInputMessageDeveloperVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputMessageDeveloper(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields value) => new RealtimeResponseInputMessageDeveloper((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields?(RealtimeResponseInputMessageDeveloper @this) => @this.RealtimeResponseInputMessageFields;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageDeveloper(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? value)
        {
            RealtimeResponseInputMessageFields = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputMessageDeveloper FromRealtimeResponseInputMessageFields(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? value) => new RealtimeResponseInputMessageDeveloper(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputMessageDeveloper(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2 value) => new RealtimeResponseInputMessageDeveloper((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2?(RealtimeResponseInputMessageDeveloper @this) => @this.RealtimeResponseInputMessageDeveloperVariant2;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageDeveloper(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2? value)
        {
            RealtimeResponseInputMessageDeveloperVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputMessageDeveloper FromRealtimeResponseInputMessageDeveloperVariant2(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2? value) => new RealtimeResponseInputMessageDeveloper(value);

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputMessageDeveloper(
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields? realtimeResponseInputMessageFields,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2? realtimeResponseInputMessageDeveloperVariant2
            )
        {
            RealtimeResponseInputMessageFields = realtimeResponseInputMessageFields;
            RealtimeResponseInputMessageDeveloperVariant2 = realtimeResponseInputMessageDeveloperVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RealtimeResponseInputMessageDeveloperVariant2 as object ??
            RealtimeResponseInputMessageFields as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RealtimeResponseInputMessageFields?.ToString() ??
            RealtimeResponseInputMessageDeveloperVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeResponseInputMessageFields && IsRealtimeResponseInputMessageDeveloperVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields, TResult>? realtimeResponseInputMessageFields = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2, TResult>? realtimeResponseInputMessageDeveloperVariant2 = null,
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
            else if (RealtimeResponseInputMessageDeveloperVariant2 is { } __value1 && realtimeResponseInputMessageDeveloperVariant2 != null)
            {
                return realtimeResponseInputMessageDeveloperVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields>? realtimeResponseInputMessageFields = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2>? realtimeResponseInputMessageDeveloperVariant2 = null,
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
            else if (RealtimeResponseInputMessageDeveloperVariant2 is { } __value1)
            {
                realtimeResponseInputMessageDeveloperVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields>? realtimeResponseInputMessageFields = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2>? realtimeResponseInputMessageDeveloperVariant2 = null,
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
            else if (RealtimeResponseInputMessageDeveloperVariant2 is { } __value1)
            {
                realtimeResponseInputMessageDeveloperVariant2?.Invoke(__value1);
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
                RealtimeResponseInputMessageDeveloperVariant2,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2),
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
        public bool Equals(RealtimeResponseInputMessageDeveloper other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageFields?>.Default.Equals(RealtimeResponseInputMessageFields, other.RealtimeResponseInputMessageFields) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloperVariant2?>.Default.Equals(RealtimeResponseInputMessageDeveloperVariant2, other.RealtimeResponseInputMessageDeveloperVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RealtimeResponseInputMessageDeveloper obj1, RealtimeResponseInputMessageDeveloper obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeResponseInputMessageDeveloper>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RealtimeResponseInputMessageDeveloper obj1, RealtimeResponseInputMessageDeveloper obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeResponseInputMessageDeveloper o && Equals(o);
        }
    }
}
