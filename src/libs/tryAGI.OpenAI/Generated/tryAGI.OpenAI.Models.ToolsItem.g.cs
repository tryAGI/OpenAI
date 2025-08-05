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
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantToolsCode? AssistantCode { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantToolsCode? AssistantCode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantCode))]
#endif
        public bool IsAssistantCode => AssistantCode != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::tryAGI.OpenAI.AssistantToolsCode value) => new ToolsItem((global::tryAGI.OpenAI.AssistantToolsCode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantToolsCode?(ToolsItem @this) => @this.AssistantCode;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::tryAGI.OpenAI.AssistantToolsCode? value)
        {
            AssistantCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly? AssistantFileSearchTypeOnly { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly? AssistantFileSearchTypeOnly { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantFileSearchTypeOnly))]
#endif
        public bool IsAssistantFileSearchTypeOnly => AssistantFileSearchTypeOnly != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly value) => new ToolsItem((global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly?(ToolsItem @this) => @this.AssistantFileSearchTypeOnly;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly? value)
        {
            AssistantFileSearchTypeOnly = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(
            global::tryAGI.OpenAI.AssistantToolsCode? assistantCode,
            global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly? assistantFileSearchTypeOnly
            )
        {
            AssistantCode = assistantCode;
            AssistantFileSearchTypeOnly = assistantFileSearchTypeOnly;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AssistantFileSearchTypeOnly as object ??
            AssistantCode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AssistantCode?.ToString() ??
            AssistantFileSearchTypeOnly?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAssistantCode || IsAssistantFileSearchTypeOnly;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AssistantToolsCode?, TResult>? assistantCode = null,
            global::System.Func<global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly?, TResult>? assistantFileSearchTypeOnly = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistantCode && assistantCode != null)
            {
                return assistantCode(AssistantCode!);
            }
            else if (IsAssistantFileSearchTypeOnly && assistantFileSearchTypeOnly != null)
            {
                return assistantFileSearchTypeOnly(AssistantFileSearchTypeOnly!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AssistantToolsCode?>? assistantCode = null,
            global::System.Action<global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly?>? assistantFileSearchTypeOnly = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistantCode)
            {
                assistantCode?.Invoke(AssistantCode!);
            }
            else if (IsAssistantFileSearchTypeOnly)
            {
                assistantFileSearchTypeOnly?.Invoke(AssistantFileSearchTypeOnly!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AssistantCode,
                typeof(global::tryAGI.OpenAI.AssistantToolsCode),
                AssistantFileSearchTypeOnly,
                typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantToolsCode?>.Default.Equals(AssistantCode, other.AssistantCode) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly?>.Default.Equals(AssistantFileSearchTypeOnly, other.AssistantFileSearchTypeOnly) 
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
