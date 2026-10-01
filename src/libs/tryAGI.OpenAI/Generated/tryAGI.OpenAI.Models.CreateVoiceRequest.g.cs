#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateVoiceRequest : global::System.IEquatable<CreateVoiceRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Creates a voice from a consent recording and an audio sample. Requires multipart/form-data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? Consent { get; init; }
#else
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? Consent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Consent))]
#endif
        public bool IsConsent => Consent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConsent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? value)
        {
            value = Consent;
            return IsConsent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequest PickConsent() => Consent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Consent' but the value was {ToString()}.");

        /// <summary>
        /// Creates a synthetic voice from a text description. Supports application/json or multipart/form-data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateVoicePromptRequest? Prompt { get; init; }
#else
        public global::tryAGI.OpenAI.CreateVoicePromptRequest? Prompt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Prompt))]
#endif
        public bool IsPrompt => Prompt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPrompt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CreateVoicePromptRequest? value)
        {
            value = Prompt;
            return IsPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVoicePromptRequest PickPrompt() => Prompt is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Prompt' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVoiceRequest(global::tryAGI.OpenAI.CreateVoiceFromConsentRequest value) => new CreateVoiceRequest((global::tryAGI.OpenAI.CreateVoiceFromConsentRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateVoiceFromConsentRequest?(CreateVoiceRequest @this) => @this.Consent;

        /// <summary>
        ///
        /// </summary>
        public CreateVoiceRequest(global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? value)
        {
            Consent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVoiceRequest FromConsent(global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? value) => new CreateVoiceRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVoiceRequest(global::tryAGI.OpenAI.CreateVoicePromptRequest value) => new CreateVoiceRequest((global::tryAGI.OpenAI.CreateVoicePromptRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateVoicePromptRequest?(CreateVoiceRequest @this) => @this.Prompt;

        /// <summary>
        ///
        /// </summary>
        public CreateVoiceRequest(global::tryAGI.OpenAI.CreateVoicePromptRequest? value)
        {
            Prompt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVoiceRequest FromPrompt(global::tryAGI.OpenAI.CreateVoicePromptRequest? value) => new CreateVoiceRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateVoiceRequest(
            global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType? type,
            global::tryAGI.OpenAI.CreateVoiceFromConsentRequest? consent,
            global::tryAGI.OpenAI.CreateVoicePromptRequest? prompt
            )
        {
            Type = type;

            Consent = consent;
            Prompt = prompt;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Prompt as object ??
            Consent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Consent?.ToString() ??
            Prompt?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConsent && !IsPrompt || !IsConsent && IsPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CreateVoiceFromConsentRequest, TResult>? consent = null,
            global::System.Func<global::tryAGI.OpenAI.CreateVoicePromptRequest, TResult>? prompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Consent is { } __value0 && consent != null)
            {
                return consent(__value0);
            }
            else if (Prompt is { } __value1 && prompt != null)
            {
                return prompt(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CreateVoiceFromConsentRequest>? consent = null,

            global::System.Action<global::tryAGI.OpenAI.CreateVoicePromptRequest>? prompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Consent is { } __value0)
            {
                consent?.Invoke(__value0);
            }
            else if (Prompt is { } __value1)
            {
                prompt?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.CreateVoiceFromConsentRequest>? consent = null,
            global::System.Action<global::tryAGI.OpenAI.CreateVoicePromptRequest>? prompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Consent is { } __value0)
            {
                consent?.Invoke(__value0);
            }
            else if (Prompt is { } __value1)
            {
                prompt?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Consent,
                typeof(global::tryAGI.OpenAI.CreateVoiceFromConsentRequest),
                Prompt,
                typeof(global::tryAGI.OpenAI.CreateVoicePromptRequest),
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
        public bool Equals(CreateVoiceRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateVoiceFromConsentRequest?>.Default.Equals(Consent, other.Consent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateVoicePromptRequest?>.Default.Equals(Prompt, other.Prompt)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateVoiceRequest obj1, CreateVoiceRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVoiceRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateVoiceRequest obj1, CreateVoiceRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVoiceRequest o && Equals(o);
        }
    }
}
