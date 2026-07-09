#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ReasoningModeEnum : global::System.IEquatable<ReasoningModeEnum>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ReasoningModeEnumVariant1 { get; init; }
#else
        public string? ReasoningModeEnumVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningModeEnumVariant1))]
#endif
        public bool IsReasoningModeEnumVariant1 => ReasoningModeEnumVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningModeEnumVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ReasoningModeEnumVariant1;
            return IsReasoningModeEnumVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickReasoningModeEnumVariant1() => IsReasoningModeEnumVariant1
            ? ReasoningModeEnumVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningModeEnumVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ReasoningModeEnumEnum? ReasoningModeEnumEnum { get; init; }
#else
        public global::tryAGI.OpenAI.ReasoningModeEnumEnum? ReasoningModeEnumEnum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningModeEnumEnum))]
#endif
        public bool IsReasoningModeEnumEnum => ReasoningModeEnumEnum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningModeEnumEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ReasoningModeEnumEnum? value)
        {
            value = ReasoningModeEnumEnum;
            return IsReasoningModeEnumEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningModeEnumEnum PickReasoningModeEnumEnum() => IsReasoningModeEnumEnum
            ? ReasoningModeEnumEnum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningModeEnumEnum' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningModeEnum(string value) => new ReasoningModeEnum((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ReasoningModeEnum @this) => @this.ReasoningModeEnumVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningModeEnum(string? value)
        {
            ReasoningModeEnumVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReasoningModeEnum FromReasoningModeEnumVariant1(string? value) => new ReasoningModeEnum(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningModeEnum(global::tryAGI.OpenAI.ReasoningModeEnumEnum value) => new ReasoningModeEnum((global::tryAGI.OpenAI.ReasoningModeEnumEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ReasoningModeEnumEnum?(ReasoningModeEnum @this) => @this.ReasoningModeEnumEnum;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningModeEnum(global::tryAGI.OpenAI.ReasoningModeEnumEnum? value)
        {
            ReasoningModeEnumEnum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReasoningModeEnum FromReasoningModeEnumEnum(global::tryAGI.OpenAI.ReasoningModeEnumEnum? value) => new ReasoningModeEnum(value);

        /// <summary>
        /// 
        /// </summary>
        public ReasoningModeEnum(
            string? reasoningModeEnumVariant1,
            global::tryAGI.OpenAI.ReasoningModeEnumEnum? reasoningModeEnumEnum
            )
        {
            ReasoningModeEnumVariant1 = reasoningModeEnumVariant1;
            ReasoningModeEnumEnum = reasoningModeEnumEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReasoningModeEnumEnum as object ??
            ReasoningModeEnumVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReasoningModeEnumVariant1?.ToString() ??
            ReasoningModeEnumEnum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReasoningModeEnumVariant1 || IsReasoningModeEnumEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? reasoningModeEnumVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningModeEnumEnum?, TResult>? reasoningModeEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningModeEnumVariant1 && reasoningModeEnumVariant1 != null)
            {
                return reasoningModeEnumVariant1(ReasoningModeEnumVariant1!);
            }
            else if (IsReasoningModeEnumEnum && reasoningModeEnumEnum != null)
            {
                return reasoningModeEnumEnum(ReasoningModeEnumEnum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? reasoningModeEnumVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.ReasoningModeEnumEnum?>? reasoningModeEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningModeEnumVariant1)
            {
                reasoningModeEnumVariant1?.Invoke(ReasoningModeEnumVariant1!);
            }
            else if (IsReasoningModeEnumEnum)
            {
                reasoningModeEnumEnum?.Invoke(ReasoningModeEnumEnum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? reasoningModeEnumVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningModeEnumEnum?>? reasoningModeEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningModeEnumVariant1)
            {
                reasoningModeEnumVariant1?.Invoke(ReasoningModeEnumVariant1!);
            }
            else if (IsReasoningModeEnumEnum)
            {
                reasoningModeEnumEnum?.Invoke(ReasoningModeEnumEnum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReasoningModeEnumVariant1,
                typeof(string),
                ReasoningModeEnumEnum,
                typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum),
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
        public bool Equals(ReasoningModeEnum other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ReasoningModeEnumVariant1, other.ReasoningModeEnumVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningModeEnumEnum?>.Default.Equals(ReasoningModeEnumEnum, other.ReasoningModeEnumEnum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReasoningModeEnum obj1, ReasoningModeEnum obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningModeEnum>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReasoningModeEnum obj1, ReasoningModeEnum obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningModeEnum o && Equals(o);
        }
    }
}
