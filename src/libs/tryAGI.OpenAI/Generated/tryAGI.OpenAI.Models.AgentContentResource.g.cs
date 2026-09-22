#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A plaintext or encrypted content part exchanged between agents.
    /// </summary>
    public readonly partial struct AgentContentResource : global::System.IEquatable<AgentContentResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A text content part produced by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OutputTextResource? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.OutputTextResource? OutputText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputText))]
#endif
        public bool IsOutputText => OutputText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.OutputTextResource? value)
        {
            value = OutputText;
            return IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextResource PickOutputText() => IsOutputText
            ? OutputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputText' but the value was {ToString()}.");

        /// <summary>
        /// Encrypted content exchanged between agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EncryptedContentResource? EncryptedContent { get; init; }
#else
        public global::tryAGI.OpenAI.EncryptedContentResource? EncryptedContent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EncryptedContent))]
#endif
        public bool IsEncryptedContent => EncryptedContent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEncryptedContent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.EncryptedContentResource? value)
        {
            value = EncryptedContent;
            return IsEncryptedContent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EncryptedContentResource PickEncryptedContent() => IsEncryptedContent
            ? EncryptedContent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EncryptedContent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentContentResource(global::tryAGI.OpenAI.OutputTextResource value) => new AgentContentResource((global::tryAGI.OpenAI.OutputTextResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputTextResource?(AgentContentResource @this) => @this.OutputText;

        /// <summary>
        ///
        /// </summary>
        public AgentContentResource(global::tryAGI.OpenAI.OutputTextResource? value)
        {
            OutputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentContentResource FromOutputText(global::tryAGI.OpenAI.OutputTextResource? value) => new AgentContentResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentContentResource(global::tryAGI.OpenAI.EncryptedContentResource value) => new AgentContentResource((global::tryAGI.OpenAI.EncryptedContentResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EncryptedContentResource?(AgentContentResource @this) => @this.EncryptedContent;

        /// <summary>
        ///
        /// </summary>
        public AgentContentResource(global::tryAGI.OpenAI.EncryptedContentResource? value)
        {
            EncryptedContent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentContentResource FromEncryptedContent(global::tryAGI.OpenAI.EncryptedContentResource? value) => new AgentContentResource(value);

        /// <summary>
        ///
        /// </summary>
        public AgentContentResource(
            global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.OutputTextResource? outputText,
            global::tryAGI.OpenAI.EncryptedContentResource? encryptedContent
            )
        {
            Type = type;

            OutputText = outputText;
            EncryptedContent = encryptedContent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EncryptedContent as object ??
            OutputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputText?.ToString() ??
            EncryptedContent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputText && !IsEncryptedContent || !IsOutputText && IsEncryptedContent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.OutputTextResource, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.EncryptedContentResource, TResult>? encryptedContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputText && outputText != null)
            {
                return outputText(OutputText!);
            }
            else if (IsEncryptedContent && encryptedContent != null)
            {
                return encryptedContent(EncryptedContent!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.OutputTextResource>? outputText = null,

            global::System.Action<global::tryAGI.OpenAI.EncryptedContentResource>? encryptedContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
            else if (IsEncryptedContent)
            {
                encryptedContent?.Invoke(EncryptedContent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.OutputTextResource>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.EncryptedContentResource>? encryptedContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
            else if (IsEncryptedContent)
            {
                encryptedContent?.Invoke(EncryptedContent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputText,
                typeof(global::tryAGI.OpenAI.OutputTextResource),
                EncryptedContent,
                typeof(global::tryAGI.OpenAI.EncryptedContentResource),
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
        public bool Equals(AgentContentResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputTextResource?>.Default.Equals(OutputText, other.OutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EncryptedContentResource?>.Default.Equals(EncryptedContent, other.EncryptedContent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentContentResource obj1, AgentContentResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentContentResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentContentResource obj1, AgentContentResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentContentResource o && Equals(o);
        }
    }
}
