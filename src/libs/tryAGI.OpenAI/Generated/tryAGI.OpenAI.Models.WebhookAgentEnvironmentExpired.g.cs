#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an agent environment expires and can no longer resume from a snapshot.
    /// </summary>
    public readonly partial struct WebhookAgentEnvironmentExpired : global::System.IEquatable<WebhookAgentEnvironmentExpired>
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
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? WebhookAgentEnvironmentExpiredVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? WebhookAgentEnvironmentExpiredVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAgentEnvironmentExpiredVariant2))]
#endif
        public bool IsWebhookAgentEnvironmentExpiredVariant2 => WebhookAgentEnvironmentExpiredVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAgentEnvironmentExpiredVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? value)
        {
            value = WebhookAgentEnvironmentExpiredVariant2;
            return IsWebhookAgentEnvironmentExpiredVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2 PickWebhookAgentEnvironmentExpiredVariant2() => WebhookAgentEnvironmentExpiredVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAgentEnvironmentExpiredVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentEnvironmentExpired(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope value) => new WebhookAgentEnvironmentExpired((global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?(WebhookAgentEnvironmentExpired @this) => @this.SessionEnvelope;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentExpired(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            SessionEnvelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentEnvironmentExpired FromSessionEnvelope(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value) => new WebhookAgentEnvironmentExpired(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentEnvironmentExpired(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2 value) => new WebhookAgentEnvironmentExpired((global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2?(WebhookAgentEnvironmentExpired @this) => @this.WebhookAgentEnvironmentExpiredVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentExpired(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? value)
        {
            WebhookAgentEnvironmentExpiredVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentEnvironmentExpired FromWebhookAgentEnvironmentExpiredVariant2(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? value) => new WebhookAgentEnvironmentExpired(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentExpired(
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? sessionEnvelope,
            global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2? webhookAgentEnvironmentExpiredVariant2
            )
        {
            SessionEnvelope = sessionEnvelope;
            WebhookAgentEnvironmentExpiredVariant2 = webhookAgentEnvironmentExpiredVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAgentEnvironmentExpiredVariant2 as object ??
            SessionEnvelope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SessionEnvelope?.ToString() ??
            WebhookAgentEnvironmentExpiredVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSessionEnvelope && IsWebhookAgentEnvironmentExpiredVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope, TResult>? sessionEnvelope = null,
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2, TResult>? webhookAgentEnvironmentExpiredVariant2 = null,
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
            else if (WebhookAgentEnvironmentExpiredVariant2 is { } __value1 && webhookAgentEnvironmentExpiredVariant2 != null)
            {
                return webhookAgentEnvironmentExpiredVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? sessionEnvelope = null,

            global::System.Action<global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2>? webhookAgentEnvironmentExpiredVariant2 = null,
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
            else if (WebhookAgentEnvironmentExpiredVariant2 is { } __value1)
            {
                webhookAgentEnvironmentExpiredVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? sessionEnvelope = null,
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2>? webhookAgentEnvironmentExpiredVariant2 = null,
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
            else if (WebhookAgentEnvironmentExpiredVariant2 is { } __value1)
            {
                webhookAgentEnvironmentExpiredVariant2?.Invoke(__value1);
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
                WebhookAgentEnvironmentExpiredVariant2,
                typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2),
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
        public bool Equals(WebhookAgentEnvironmentExpired other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?>.Default.Equals(SessionEnvelope, other.SessionEnvelope) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2?>.Default.Equals(WebhookAgentEnvironmentExpiredVariant2, other.WebhookAgentEnvironmentExpiredVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAgentEnvironmentExpired obj1, WebhookAgentEnvironmentExpired obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAgentEnvironmentExpired>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAgentEnvironmentExpired obj1, WebhookAgentEnvironmentExpired obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAgentEnvironmentExpired o && Equals(o);
        }
    }
}
