#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct MisalignmentErrorType : global::System.IEquatable<MisalignmentErrorType>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MisalignmentErrorTypeVariant1 { get; init; }
#else
        public string? MisalignmentErrorTypeVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MisalignmentErrorTypeVariant1))]
#endif
        public bool IsMisalignmentErrorTypeVariant1 => MisalignmentErrorTypeVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMisalignmentErrorTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = MisalignmentErrorTypeVariant1;
            return IsMisalignmentErrorTypeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickMisalignmentErrorTypeVariant1() => IsMisalignmentErrorTypeVariant1
            ? MisalignmentErrorTypeVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MisalignmentErrorTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? Enum { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MisalignmentErrorTypeEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MisalignmentErrorType(string value) => new MisalignmentErrorType((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(MisalignmentErrorType @this) => @this.MisalignmentErrorTypeVariant1;

        /// <summary>
        ///
        /// </summary>
        public MisalignmentErrorType(string? value)
        {
            MisalignmentErrorTypeVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MisalignmentErrorType FromMisalignmentErrorTypeVariant1(string? value) => new MisalignmentErrorType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MisalignmentErrorType(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum value) => new MisalignmentErrorType((global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?(MisalignmentErrorType @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public MisalignmentErrorType(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MisalignmentErrorType FromEnum(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? value) => new MisalignmentErrorType(value);

        /// <summary>
        ///
        /// </summary>
        public MisalignmentErrorType(
            string? misalignmentErrorTypeVariant1,
            global::tryAGI.OpenAI.MisalignmentErrorTypeEnum? @enum
            )
        {
            MisalignmentErrorTypeVariant1 = misalignmentErrorTypeVariant1;
            Enum = @enum;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Enum as object ??
            MisalignmentErrorTypeVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            MisalignmentErrorTypeVariant1?.ToString() ??
            Enum?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMisalignmentErrorTypeVariant1 || IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? misalignmentErrorTypeVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMisalignmentErrorTypeVariant1 && misalignmentErrorTypeVariant1 != null)
            {
                return misalignmentErrorTypeVariant1(MisalignmentErrorTypeVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? misalignmentErrorTypeVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMisalignmentErrorTypeVariant1)
            {
                misalignmentErrorTypeVariant1?.Invoke(MisalignmentErrorTypeVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? misalignmentErrorTypeVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMisalignmentErrorTypeVariant1)
            {
                misalignmentErrorTypeVariant1?.Invoke(MisalignmentErrorTypeVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MisalignmentErrorTypeVariant1,
                typeof(string),
                Enum,
                typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum),
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
        public bool Equals(MisalignmentErrorType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MisalignmentErrorTypeVariant1, other.MisalignmentErrorTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?>.Default.Equals(Enum, other.Enum)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MisalignmentErrorType obj1, MisalignmentErrorType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MisalignmentErrorType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MisalignmentErrorType obj1, MisalignmentErrorType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MisalignmentErrorType o && Equals(o);
        }
    }
}
