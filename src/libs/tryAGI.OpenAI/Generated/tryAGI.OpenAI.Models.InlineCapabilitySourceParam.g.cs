#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The encoded ZIP archive for an inline skill or plugin.
    /// </summary>
    public readonly partial struct InlineCapabilitySourceParam : global::System.IEquatable<InlineCapabilitySourceParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Provides ZIP bytes encoded with standard base64.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? Base64 { get; init; }
#else
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? Base64 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64))]
#endif
        public bool IsBase64 => Base64 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase64(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? value)
        {
            value = Base64;
            return IsBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64 PickBase64() => IsBase64
            ? Base64!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base64' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InlineCapabilitySourceParam(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64 value) => new InlineCapabilitySourceParam((global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64?(InlineCapabilitySourceParam @this) => @this.Base64;

        /// <summary>
        ///
        /// </summary>
        public InlineCapabilitySourceParam(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? value)
        {
            Base64 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InlineCapabilitySourceParam FromBase64(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? value) => new InlineCapabilitySourceParam(value);

        /// <summary>
        ///
        /// </summary>
        public InlineCapabilitySourceParam(
            global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType? type,
            global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64? base64
            )
        {
            Type = type;

            Base64 = base64;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Base64 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64, TResult>? base64 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64 && base64 != null)
            {
                return base64(Base64!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64>? base64 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64)
            {
                base64?.Invoke(Base64!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64>? base64 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64)
            {
                base64?.Invoke(Base64!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base64,
                typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64),
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
        public bool Equals(InlineCapabilitySourceParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64?>.Default.Equals(Base64, other.Base64)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InlineCapabilitySourceParam obj1, InlineCapabilitySourceParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineCapabilitySourceParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InlineCapabilitySourceParam obj1, InlineCapabilitySourceParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineCapabilitySourceParam o && Equals(o);
        }
    }
}
