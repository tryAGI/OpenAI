#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text, image, or file inputs to the model, used to generate a response.<br/>
    /// Learn more:<br/>
    /// - [Text inputs and outputs](/docs/guides/text)<br/>
    /// - [Image inputs](/docs/guides/images)<br/>
    /// - [File inputs](/docs/guides/pdf-files)<br/>
    /// - [Conversation state](/docs/guides/conversation-state)<br/>
    /// - [Function calling](/docs/guides/function-calling)
    /// </summary>
    public readonly partial struct InputParam : global::System.IEquatable<InputParam>
    {
        /// <summary>
        /// A text input to the model, equivalent to a text input with the<br/>
        /// `user` role.
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
        /// A list of one or many input items to the model, containing<br/>
        /// different content types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? InputItemList { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? InputItemList { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputItemList))]
#endif
        public bool IsInputItemList => InputItemList != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputParam(string value) => new InputParam((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(InputParam @this) => @this.TextInput;

        /// <summary>
        /// 
        /// </summary>
        public InputParam(string? value)
        {
            TextInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputParam(
            string? textInput,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? inputItemList
            )
        {
            TextInput = textInput;
            InputItemList = inputItemList;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputItemList as object ??
            TextInput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextInput?.ToString() ??
            InputItemList?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextInput && !IsInputItemList || !IsTextInput && IsInputItemList;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? textInput = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>?, TResult>? inputItemList = null,
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
            else if (IsInputItemList && inputItemList != null)
            {
                return inputItemList(InputItemList!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? textInput = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>?>? inputItemList = null,
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
            else if (IsInputItemList)
            {
                inputItemList?.Invoke(InputItemList!);
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
                InputItemList,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>),
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
        public bool Equals(InputParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TextInput, other.TextInput) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>?>.Default.Equals(InputItemList, other.InputItemList) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputParam obj1, InputParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputParam obj1, InputParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputParam o && Equals(o);
        }
    }
}
