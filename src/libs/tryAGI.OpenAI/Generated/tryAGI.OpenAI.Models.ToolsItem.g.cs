#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem : global::System.IEquatable<ToolsItem>
    {
        /// <summary>
        /// A function tool that can be used to generate a response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionTool? ChatCompletionTool { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionTool? ChatCompletionTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatCompletionTool))]
#endif
        public bool IsChatCompletionTool => ChatCompletionTool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::tryAGI.OpenAI.ChatCompletionTool value) => new ToolsItem((global::tryAGI.OpenAI.ChatCompletionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionTool?(ToolsItem @this) => @this.ChatCompletionTool;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::tryAGI.OpenAI.ChatCompletionTool? value)
        {
            ChatCompletionTool = value;
        }

        /// <summary>
        /// A custom tool that processes input using a specified format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolChatCompletions? CustomToolChatCompletions { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolChatCompletions? CustomToolChatCompletions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolChatCompletions))]
#endif
        public bool IsCustomToolChatCompletions => CustomToolChatCompletions != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::tryAGI.OpenAI.CustomToolChatCompletions value) => new ToolsItem((global::tryAGI.OpenAI.CustomToolChatCompletions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolChatCompletions?(ToolsItem @this) => @this.CustomToolChatCompletions;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::tryAGI.OpenAI.CustomToolChatCompletions? value)
        {
            CustomToolChatCompletions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(
            global::tryAGI.OpenAI.ChatCompletionTool? chatCompletionTool,
            global::tryAGI.OpenAI.CustomToolChatCompletions? customToolChatCompletions
            )
        {
            ChatCompletionTool = chatCompletionTool;
            CustomToolChatCompletions = customToolChatCompletions;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolChatCompletions as object ??
            ChatCompletionTool as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatCompletionTool?.ToString() ??
            CustomToolChatCompletions?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatCompletionTool || IsCustomToolChatCompletions;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionTool?, TResult>? chatCompletionTool = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolChatCompletions?, TResult>? customToolChatCompletions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionTool && chatCompletionTool != null)
            {
                return chatCompletionTool(ChatCompletionTool!);
            }
            else if (IsCustomToolChatCompletions && customToolChatCompletions != null)
            {
                return customToolChatCompletions(CustomToolChatCompletions!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionTool?>? chatCompletionTool = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolChatCompletions?>? customToolChatCompletions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatCompletionTool)
            {
                chatCompletionTool?.Invoke(ChatCompletionTool!);
            }
            else if (IsCustomToolChatCompletions)
            {
                customToolChatCompletions?.Invoke(CustomToolChatCompletions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatCompletionTool,
                typeof(global::tryAGI.OpenAI.ChatCompletionTool),
                CustomToolChatCompletions,
                typeof(global::tryAGI.OpenAI.CustomToolChatCompletions),
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
        public bool Equals(ToolsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionTool?>.Default.Equals(ChatCompletionTool, other.ChatCompletionTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolChatCompletions?>.Default.Equals(CustomToolChatCompletions, other.CustomToolChatCompletions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem obj1, ToolsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem obj1, ToolsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem o && Equals(o);
        }
    }
}
