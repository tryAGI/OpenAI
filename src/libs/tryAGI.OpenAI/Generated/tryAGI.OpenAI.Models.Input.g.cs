#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Moderation for the request input.
    /// </summary>
    public readonly partial struct Input : global::System.IEquatable<Input>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType? Type { get; }

        /// <summary>
        /// Successful moderation results for the request input or generated output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionModerationResults? ModerationResults { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionModerationResults? ModerationResults { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModerationResults))]
#endif
        public bool IsModerationResults => ModerationResults != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModerationResults(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ChatCompletionModerationResults? value)
        {
            value = ModerationResults;
            return IsModerationResults;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationResults PickModerationResults() => IsModerationResults
            ? ModerationResults!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModerationResults' but the value was {ToString()}.");

        /// <summary>
        /// An error produced while attempting moderation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionModerationError? Error { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionModerationError? Error { get; }
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
            out global::tryAGI.OpenAI.ChatCompletionModerationError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionModerationError PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::tryAGI.OpenAI.ChatCompletionModerationResults value) => new Input((global::tryAGI.OpenAI.ChatCompletionModerationResults?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionModerationResults?(Input @this) => @this.ModerationResults;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::tryAGI.OpenAI.ChatCompletionModerationResults? value)
        {
            ModerationResults = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Input FromModerationResults(global::tryAGI.OpenAI.ChatCompletionModerationResults? value) => new Input(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::tryAGI.OpenAI.ChatCompletionModerationError value) => new Input((global::tryAGI.OpenAI.ChatCompletionModerationError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionModerationError?(Input @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::tryAGI.OpenAI.ChatCompletionModerationError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Input FromError(global::tryAGI.OpenAI.ChatCompletionModerationError? value) => new Input(value);

        /// <summary>
        /// 
        /// </summary>
        public Input(
            global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType? type,
            global::tryAGI.OpenAI.ChatCompletionModerationResults? moderationResults,
            global::tryAGI.OpenAI.ChatCompletionModerationError? error
            )
        {
            Type = type;

            ModerationResults = moderationResults;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            ModerationResults as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModerationResults?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModerationResults && !IsError || !IsModerationResults && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionModerationResults, TResult>? moderationResults = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionModerationError, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationResults && moderationResults != null)
            {
                return moderationResults(ModerationResults!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionModerationResults>? moderationResults = null,

            global::System.Action<global::tryAGI.OpenAI.ChatCompletionModerationError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationResults)
            {
                moderationResults?.Invoke(ModerationResults!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionModerationResults>? moderationResults = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionModerationError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationResults)
            {
                moderationResults?.Invoke(ModerationResults!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModerationResults,
                typeof(global::tryAGI.OpenAI.ChatCompletionModerationResults),
                Error,
                typeof(global::tryAGI.OpenAI.ChatCompletionModerationError),
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
        public bool Equals(Input other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionModerationResults?>.Default.Equals(ModerationResults, other.ModerationResults) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionModerationError?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Input obj1, Input obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Input>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Input obj1, Input obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Input o && Equals(o);
        }
    }
}
