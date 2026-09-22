#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseSteerInputItem : global::System.IEquatable<ResponseSteerInputItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UserMessageItemParam? Message { get; init; }
#else
        public global::tryAGI.OpenAI.UserMessageItemParam? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UserMessageItemParam? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.UserMessageItemParam PickMessage() => IsMessage
            ? Message!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? FunctionCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutput))]
#endif
        public bool IsFunctionCallOutput => FunctionCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.FunctionCallOutputItemParam? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam PickFunctionCallOutput() => IsFunctionCallOutput
            ? FunctionCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerInputItem(global::tryAGI.OpenAI.UserMessageItemParam value) => new ResponseSteerInputItem((global::tryAGI.OpenAI.UserMessageItemParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UserMessageItemParam?(ResponseSteerInputItem @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerInputItem(global::tryAGI.OpenAI.UserMessageItemParam? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerInputItem FromMessage(global::tryAGI.OpenAI.UserMessageItemParam? value) => new ResponseSteerInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerInputItem(global::tryAGI.OpenAI.FunctionCallOutputItemParam value) => new ResponseSteerInputItem((global::tryAGI.OpenAI.FunctionCallOutputItemParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionCallOutputItemParam?(ResponseSteerInputItem @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerInputItem(global::tryAGI.OpenAI.FunctionCallOutputItemParam? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerInputItem FromFunctionCallOutput(global::tryAGI.OpenAI.FunctionCallOutputItemParam? value) => new ResponseSteerInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerInputItem(
            global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType? type,
            global::tryAGI.OpenAI.UserMessageItemParam? message,
            global::tryAGI.OpenAI.FunctionCallOutputItemParam? functionCallOutput
            )
        {
            Type = type;

            Message = message;
            FunctionCallOutput = functionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FunctionCallOutput as object ??
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            FunctionCallOutput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage || IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.UserMessageItemParam, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionCallOutputItemParam, TResult>? functionCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsFunctionCallOutput && functionCallOutput != null)
            {
                return functionCallOutput(FunctionCallOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.UserMessageItemParam>? message = null,

            global::System.Action<global::tryAGI.OpenAI.FunctionCallOutputItemParam>? functionCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.UserMessageItemParam>? message = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionCallOutputItemParam>? functionCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::tryAGI.OpenAI.UserMessageItemParam),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam),
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
        public bool Equals(ResponseSteerInputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UserMessageItemParam?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionCallOutputItemParam?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseSteerInputItem obj1, ResponseSteerInputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseSteerInputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseSteerInputItem obj1, ResponseSteerInputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseSteerInputItem o && Equals(o);
        }
    }
}
