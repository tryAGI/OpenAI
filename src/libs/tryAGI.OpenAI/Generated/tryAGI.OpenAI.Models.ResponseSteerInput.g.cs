#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Input to queue for a continuation of the response. Uses the same string or<br/>
    /// input-item shape as `response.create.input`, with a non-empty array when<br/>
    /// supplying input items.<br/>
    /// Steering accepts only messages with the `user` role. Each message may<br/>
    /// contain only `type`, `role`, and `content`, with `content` as a string or an<br/>
    /// array of `input_text`, `input_image`, and `input_file` parts. The optional<br/>
    /// `type` must be `message`. Other roles, tool outputs, and item types are not<br/>
    /// supported for steering.
    /// </summary>
    public readonly partial struct ResponseSteerInput : global::System.IEquatable<ResponseSteerInput>
    {
        /// <summary>
        /// A text input, equivalent to a message with the `user` role.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TextInput { get; init; }
#else
        public string? TextInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextInput))]
#endif
        public bool IsTextInput => TextInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = TextInput;
            return IsTextInput;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickTextInput() => IsTextInput
            ? TextInput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextInput' but the value was {ToString()}.");

        /// <summary>
        /// A non-empty list of message inputs to queue for the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>? ResponseSteerInputItemList { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>? ResponseSteerInputItemList { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseSteerInputItemList))]
#endif
        public bool IsResponseSteerInputItemList => ResponseSteerInputItemList != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseSteerInputItemList(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>? value)
        {
            value = ResponseSteerInputItemList;
            return IsResponseSteerInputItemList;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem> PickResponseSteerInputItemList() => IsResponseSteerInputItemList
            ? ResponseSteerInputItemList!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSteerInputItemList' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerInput(string value) => new ResponseSteerInput((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(ResponseSteerInput @this) => @this.TextInput;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerInput(string? value)
        {
            TextInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerInput FromTextInput(string? value) => new ResponseSteerInput(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerInput(
            string? textInput,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>? responseSteerInputItemList
            )
        {
            TextInput = textInput;
            ResponseSteerInputItemList = responseSteerInputItemList;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseSteerInputItemList as object ??
            TextInput as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TextInput?.ToString() ??
            ResponseSteerInputItemList?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTextInput && !IsResponseSteerInputItemList || !IsTextInput && IsResponseSteerInputItemList;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? textInput = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>, TResult>? responseSteerInputItemList = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextInput && textInput != null)
            {
                return textInput(TextInput!);
            }
            else if (IsResponseSteerInputItemList && responseSteerInputItemList != null)
            {
                return responseSteerInputItemList(ResponseSteerInputItemList!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? textInput = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>>? responseSteerInputItemList = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextInput)
            {
                textInput?.Invoke(TextInput!);
            }
            else if (IsResponseSteerInputItemList)
            {
                responseSteerInputItemList?.Invoke(ResponseSteerInputItemList!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? textInput = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>>? responseSteerInputItemList = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextInput)
            {
                textInput?.Invoke(TextInput!);
            }
            else if (IsResponseSteerInputItemList)
            {
                responseSteerInputItemList?.Invoke(ResponseSteerInputItemList!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextInput,
                typeof(string),
                ResponseSteerInputItemList,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>),
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
        public bool Equals(ResponseSteerInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TextInput, other.TextInput) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>?>.Default.Equals(ResponseSteerInputItemList, other.ResponseSteerInputItemList)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseSteerInput obj1, ResponseSteerInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseSteerInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseSteerInput obj1, ResponseSteerInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseSteerInput o && Equals(o);
        }
    }
}
