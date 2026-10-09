#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an agent environment is suspended and can resume from a snapshot.
    /// </summary>
    public readonly partial struct WebhookAgentEnvironmentSuspended : global::System.IEquatable<WebhookAgentEnvironmentSuspended>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? SessionEnvelope { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? SessionEnvelope { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionEnvelope))]
#endif
        public bool IsSessionEnvelope => SessionEnvelope != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionEnvelope(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            value = SessionEnvelope;
            return IsSessionEnvelope;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope PickSessionEnvelope() => SessionEnvelope is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionEnvelope' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? WebhookAgentEnvironmentSuspendedVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? WebhookAgentEnvironmentSuspendedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAgentEnvironmentSuspendedVariant2))]
#endif
        public bool IsWebhookAgentEnvironmentSuspendedVariant2 => WebhookAgentEnvironmentSuspendedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAgentEnvironmentSuspendedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? value)
        {
            value = WebhookAgentEnvironmentSuspendedVariant2;
            return IsWebhookAgentEnvironmentSuspendedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2 PickWebhookAgentEnvironmentSuspendedVariant2() => WebhookAgentEnvironmentSuspendedVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAgentEnvironmentSuspendedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentEnvironmentSuspended(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope value) => new WebhookAgentEnvironmentSuspended((global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?(WebhookAgentEnvironmentSuspended @this) => @this.SessionEnvelope;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentSuspended(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            SessionEnvelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentEnvironmentSuspended FromSessionEnvelope(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value) => new WebhookAgentEnvironmentSuspended(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentEnvironmentSuspended(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2 value) => new WebhookAgentEnvironmentSuspended((global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2?(WebhookAgentEnvironmentSuspended @this) => @this.WebhookAgentEnvironmentSuspendedVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentSuspended(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? value)
        {
            WebhookAgentEnvironmentSuspendedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentEnvironmentSuspended FromWebhookAgentEnvironmentSuspendedVariant2(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? value) => new WebhookAgentEnvironmentSuspended(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentSuspended(
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? sessionEnvelope,
            global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2? webhookAgentEnvironmentSuspendedVariant2
            )
        {
            SessionEnvelope = sessionEnvelope;
            WebhookAgentEnvironmentSuspendedVariant2 = webhookAgentEnvironmentSuspendedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAgentEnvironmentSuspendedVariant2 as object ??
            SessionEnvelope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SessionEnvelope?.ToString() ??
            WebhookAgentEnvironmentSuspendedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSessionEnvelope && IsWebhookAgentEnvironmentSuspendedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope, TResult>? sessionEnvelope = null,
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2, TResult>? webhookAgentEnvironmentSuspendedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionEnvelope is { } __value0 && sessionEnvelope != null)
            {
                return sessionEnvelope(__value0);
            }
            else if (WebhookAgentEnvironmentSuspendedVariant2 is { } __value1 && webhookAgentEnvironmentSuspendedVariant2 != null)
            {
                return webhookAgentEnvironmentSuspendedVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? sessionEnvelope = null,

            global::System.Action<global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2>? webhookAgentEnvironmentSuspendedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionEnvelope is { } __value0)
            {
                sessionEnvelope?.Invoke(__value0);
            }
            else if (WebhookAgentEnvironmentSuspendedVariant2 is { } __value1)
            {
                webhookAgentEnvironmentSuspendedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? sessionEnvelope = null,
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2>? webhookAgentEnvironmentSuspendedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionEnvelope is { } __value0)
            {
                sessionEnvelope?.Invoke(__value0);
            }
            else if (WebhookAgentEnvironmentSuspendedVariant2 is { } __value1)
            {
                webhookAgentEnvironmentSuspendedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionEnvelope,
                typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope),
                WebhookAgentEnvironmentSuspendedVariant2,
                typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2),
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
        public bool Equals(WebhookAgentEnvironmentSuspended other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?>.Default.Equals(SessionEnvelope, other.SessionEnvelope) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2?>.Default.Equals(WebhookAgentEnvironmentSuspendedVariant2, other.WebhookAgentEnvironmentSuspendedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAgentEnvironmentSuspended obj1, WebhookAgentEnvironmentSuspended obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAgentEnvironmentSuspended>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAgentEnvironmentSuspended obj1, WebhookAgentEnvironmentSuspended obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAgentEnvironmentSuspended o && Equals(o);
        }
    }
}
