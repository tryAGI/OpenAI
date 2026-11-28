#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The session configuration for either a realtime or transcription session.
    /// </summary>
    public readonly partial struct Session5 : global::System.IEquatable<Session5>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType? Type { get; }

        /// <summary>
        /// A Realtime session configuration object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? Realtime { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? Realtime { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Realtime))]
#endif
        public bool IsRealtime => Realtime != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? value)
        {
            value = Realtime;
            return IsRealtime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA PickRealtime() => Realtime is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Realtime' but the value was {ToString()}.");

        /// <summary>
        /// A Realtime transcription session configuration object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? Transcription { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? Transcription { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Transcription))]
#endif
        public bool IsTranscription => Transcription != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTranscription(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? value)
        {
            value = Transcription;
            return IsTranscription;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA PickTranscription() => Transcription is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transcription' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Session5(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA value) => new Session5((global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?(Session5 @this) => @this.Realtime;

        /// <summary>
        ///
        /// </summary>
        public Session5(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? value)
        {
            Realtime = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Session5 FromRealtime(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? value) => new Session5(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Session5(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA value) => new Session5((global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?(Session5 @this) => @this.Transcription;

        /// <summary>
        ///
        /// </summary>
        public Session5(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? value)
        {
            Transcription = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Session5 FromTranscription(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? value) => new Session5(value);

        /// <summary>
        ///
        /// </summary>
        public Session5(
            global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType? type,
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? realtime,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? transcription
            )
        {
            Type = type;

            Realtime = realtime;
            Transcription = transcription;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Transcription as object ??
            Realtime as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Realtime?.ToString() ??
            Transcription?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRealtime && !IsTranscription || !IsRealtime && IsTranscription;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, TResult>? realtime = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA, TResult>? transcription = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Realtime is { } __value0 && realtime != null)
            {
                return realtime(__value0);
            }
            else if (Transcription is { } __value1 && transcription != null)
            {
                return transcription(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA>? realtime = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>? transcription = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Realtime is { } __value0)
            {
                realtime?.Invoke(__value0);
            }
            else if (Transcription is { } __value1)
            {
                transcription?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA>? realtime = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>? transcription = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Realtime is { } __value0)
            {
                realtime?.Invoke(__value0);
            }
            else if (Transcription is { } __value1)
            {
                transcription?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Realtime,
                typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA),
                Transcription,
                typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA),
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
        public bool Equals(Session5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?>.Default.Equals(Realtime, other.Realtime) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?>.Default.Equals(Transcription, other.Transcription)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Session5 obj1, Session5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Session5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Session5 obj1, Session5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Session5 o && Equals(o);
        }
    }
}
