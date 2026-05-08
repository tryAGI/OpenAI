#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime translation server event.
    /// </summary>
    public readonly partial struct RealtimeTranslationServerEvent : global::System.IEquatable<RealtimeTranslationServerEvent>
    {
        /// <summary>
        /// Returned when an error occurs, which could be a client problem or a server<br/>
        /// problem. Most errors are recoverable and the session will stay open, we<br/>
        /// recommend to implementors to monitor and log error messages by default.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeServerEventError? Error { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventError? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeServerEventError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// Returned when a translation session is created. Emitted automatically when a<br/>
        /// new connection is established as the first server event. This event contains<br/>
        /// the default translation session configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? SessionCreated { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? value)
        {
            value = SessionCreated;
            return IsSessionCreated;
        }

        /// <summary>
        /// Returned when a translation session is updated with a `session.update` event,<br/>
        /// unless there is an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? SessionUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? SessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? value)
        {
            value = SessionUpdated;
            return IsSessionUpdated;
        }

        /// <summary>
        /// Returned when a realtime translation session is closed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? SessionClosed { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? SessionClosed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionClosed))]
#endif
        public bool IsSessionClosed => SessionClosed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionClosed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? value)
        {
            value = SessionClosed;
            return IsSessionClosed;
        }

        /// <summary>
        /// Returned when optional source-language transcript text is available. This event<br/>
        /// is emitted only when `audio.input.transcription` is configured.<br/>
        /// Transcript deltas are append-only text fragments. Clients should not insert<br/>
        /// unconditional spaces between deltas.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? SessionInputTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? SessionInputTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInputTranscriptDelta))]
#endif
        public bool IsSessionInputTranscriptDelta => SessionInputTranscriptDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionInputTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? value)
        {
            value = SessionInputTranscriptDelta;
            return IsSessionInputTranscriptDelta;
        }

        /// <summary>
        /// Returned when translated transcript text is available.<br/>
        /// Transcript deltas are append-only text fragments. Clients should not insert<br/>
        /// unconditional spaces between deltas.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? SessionOutputTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? SessionOutputTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionOutputTranscriptDelta))]
#endif
        public bool IsSessionOutputTranscriptDelta => SessionOutputTranscriptDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionOutputTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? value)
        {
            value = SessionOutputTranscriptDelta;
            return IsSessionOutputTranscriptDelta;
        }

        /// <summary>
        /// Returned when translated output audio is available. Output audio deltas are<br/>
        /// 200 ms frames of PCM16 audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? SessionOutputAudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? SessionOutputAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionOutputAudioDelta))]
#endif
        public bool IsSessionOutputAudioDelta => SessionOutputAudioDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionOutputAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? value)
        {
            value = SessionOutputAudioDelta;
            return IsSessionOutputAudioDelta;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeServerEventError value) => new RealtimeTranslationServerEvent((global::tryAGI.OpenAI.RealtimeServerEventError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventError?(RealtimeTranslationServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeServerEventError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated value) => new RealtimeTranslationServerEvent((global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated?(RealtimeTranslationServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated value) => new RealtimeTranslationServerEvent((global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated?(RealtimeTranslationServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed value) => new RealtimeTranslationServerEvent((global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed?(RealtimeTranslationServerEvent @this) => @this.SessionClosed;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? value)
        {
            SessionClosed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta value) => new RealtimeTranslationServerEvent((global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta?(RealtimeTranslationServerEvent @this) => @this.SessionInputTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? value)
        {
            SessionInputTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta value) => new RealtimeTranslationServerEvent((global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta?(RealtimeTranslationServerEvent @this) => @this.SessionOutputTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? value)
        {
            SessionOutputTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta value) => new RealtimeTranslationServerEvent((global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta?(RealtimeTranslationServerEvent @this) => @this.SessionOutputAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationServerEvent(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? value)
        {
            SessionOutputAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationServerEvent(
            global::tryAGI.OpenAI.RealtimeServerEventError? error,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? sessionCreated,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? sessionUpdated,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? sessionClosed,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? sessionInputTranscriptDelta,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? sessionOutputTranscriptDelta,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? sessionOutputAudioDelta
            )
        {
            Error = error;
            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            SessionClosed = sessionClosed;
            SessionInputTranscriptDelta = sessionInputTranscriptDelta;
            SessionOutputTranscriptDelta = sessionOutputTranscriptDelta;
            SessionOutputAudioDelta = sessionOutputAudioDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SessionOutputAudioDelta as object ??
            SessionOutputTranscriptDelta as object ??
            SessionInputTranscriptDelta as object ??
            SessionClosed as object ??
            SessionUpdated as object ??
            SessionCreated as object ??
            Error as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Error?.ToString() ??
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            SessionClosed?.ToString() ??
            SessionInputTranscriptDelta?.ToString() ??
            SessionOutputTranscriptDelta?.ToString() ??
            SessionOutputAudioDelta?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsError || IsSessionCreated || IsSessionUpdated || IsSessionClosed || IsSessionInputTranscriptDelta || IsSessionOutputTranscriptDelta || IsSessionOutputAudioDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventError, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated, TResult>? sessionCreated = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated, TResult>? sessionUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed, TResult>? sessionClosed = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta, TResult>? sessionInputTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta, TResult>? sessionOutputTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta, TResult>? sessionOutputAudioDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsSessionCreated && sessionCreated != null)
            {
                return sessionCreated(SessionCreated!);
            }
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsSessionClosed && sessionClosed != null)
            {
                return sessionClosed(SessionClosed!);
            }
            else if (IsSessionInputTranscriptDelta && sessionInputTranscriptDelta != null)
            {
                return sessionInputTranscriptDelta(SessionInputTranscriptDelta!);
            }
            else if (IsSessionOutputTranscriptDelta && sessionOutputTranscriptDelta != null)
            {
                return sessionOutputTranscriptDelta(SessionOutputTranscriptDelta!);
            }
            else if (IsSessionOutputAudioDelta && sessionOutputAudioDelta != null)
            {
                return sessionOutputAudioDelta(SessionOutputAudioDelta!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventError>? error = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated>? sessionCreated = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated>? sessionUpdated = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed>? sessionClosed = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta>? sessionInputTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta>? sessionOutputTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta>? sessionOutputAudioDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsSessionClosed)
            {
                sessionClosed?.Invoke(SessionClosed!);
            }
            else if (IsSessionInputTranscriptDelta)
            {
                sessionInputTranscriptDelta?.Invoke(SessionInputTranscriptDelta!);
            }
            else if (IsSessionOutputTranscriptDelta)
            {
                sessionOutputTranscriptDelta?.Invoke(SessionOutputTranscriptDelta!);
            }
            else if (IsSessionOutputAudioDelta)
            {
                sessionOutputAudioDelta?.Invoke(SessionOutputAudioDelta!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventError>? error = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated>? sessionCreated = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated>? sessionUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed>? sessionClosed = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta>? sessionInputTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta>? sessionOutputTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta>? sessionOutputAudioDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsSessionClosed)
            {
                sessionClosed?.Invoke(SessionClosed!);
            }
            else if (IsSessionInputTranscriptDelta)
            {
                sessionInputTranscriptDelta?.Invoke(SessionInputTranscriptDelta!);
            }
            else if (IsSessionOutputTranscriptDelta)
            {
                sessionOutputTranscriptDelta?.Invoke(SessionOutputTranscriptDelta!);
            }
            else if (IsSessionOutputAudioDelta)
            {
                sessionOutputAudioDelta?.Invoke(SessionOutputAudioDelta!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Error,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventError),
                SessionCreated,
                typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated),
                SessionUpdated,
                typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated),
                SessionClosed,
                typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed),
                SessionInputTranscriptDelta,
                typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta),
                SessionOutputTranscriptDelta,
                typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta),
                SessionOutputAudioDelta,
                typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta),
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
        public bool Equals(RealtimeTranslationServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed?>.Default.Equals(SessionClosed, other.SessionClosed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta?>.Default.Equals(SessionInputTranscriptDelta, other.SessionInputTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta?>.Default.Equals(SessionOutputTranscriptDelta, other.SessionOutputTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta?>.Default.Equals(SessionOutputAudioDelta, other.SessionOutputAudioDelta) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeTranslationServerEvent obj1, RealtimeTranslationServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeTranslationServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeTranslationServerEvent obj1, RealtimeTranslationServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeTranslationServerEvent o && Equals(o);
        }
    }
}
