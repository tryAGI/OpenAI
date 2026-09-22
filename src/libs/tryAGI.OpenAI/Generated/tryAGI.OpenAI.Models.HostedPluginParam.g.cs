#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A plugin installed in an OpenAI-hosted environment.
    /// </summary>
    public readonly partial struct HostedPluginParam : global::System.IEquatable<HostedPluginParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Supplies a plugin ZIP directly in the session request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedPluginParamInline? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.HostedPluginParamInline? Inline { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inline))]
#endif
        public bool IsInline => Inline != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInline(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.HostedPluginParamInline? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedPluginParamInline PickInline() => IsInline
            ? Inline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedPluginParam(global::tryAGI.OpenAI.HostedPluginParamInline value) => new HostedPluginParam((global::tryAGI.OpenAI.HostedPluginParamInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedPluginParamInline?(HostedPluginParam @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public HostedPluginParam(global::tryAGI.OpenAI.HostedPluginParamInline? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedPluginParam FromInline(global::tryAGI.OpenAI.HostedPluginParamInline? value) => new HostedPluginParam(value);

        /// <summary>
        ///
        /// </summary>
        public HostedPluginParam(
            global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType? type,
            global::tryAGI.OpenAI.HostedPluginParamInline? inline
            )
        {
            Type = type;

            Inline = inline;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Inline as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Inline?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.HostedPluginParamInline, TResult>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInline && inline != null)
            {
                return inline(Inline!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.HostedPluginParamInline>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInline)
            {
                inline?.Invoke(Inline!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.HostedPluginParamInline>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInline)
            {
                inline?.Invoke(Inline!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Inline,
                typeof(global::tryAGI.OpenAI.HostedPluginParamInline),
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
        public bool Equals(HostedPluginParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedPluginParamInline?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HostedPluginParam obj1, HostedPluginParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HostedPluginParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HostedPluginParam obj1, HostedPluginParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HostedPluginParam o && Equals(o);
        }
    }
}
