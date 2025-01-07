#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem8 : global::System.IEquatable<ToolsItem8>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.RunObjectToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantToolsCode? CodeInterpreter { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantToolsCode? CodeInterpreter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreter))]
#endif
        public bool IsCodeInterpreter => CodeInterpreter != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem8(global::tryAGI.OpenAI.AssistantToolsCode value) => new ToolsItem8(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantToolsCode?(ToolsItem8 @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem8(global::tryAGI.OpenAI.AssistantToolsCode? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantToolsFileSearch? FileSearch { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantToolsFileSearch? FileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearch))]
#endif
        public bool IsFileSearch => FileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem8(global::tryAGI.OpenAI.AssistantToolsFileSearch value) => new ToolsItem8(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantToolsFileSearch?(ToolsItem8 @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem8(global::tryAGI.OpenAI.AssistantToolsFileSearch? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantToolsFunction? Function { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantToolsFunction? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem8(global::tryAGI.OpenAI.AssistantToolsFunction value) => new ToolsItem8(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantToolsFunction?(ToolsItem8 @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem8(global::tryAGI.OpenAI.AssistantToolsFunction? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem8(
            global::tryAGI.OpenAI.RunObjectToolDiscriminatorType? type,
            global::tryAGI.OpenAI.AssistantToolsCode? codeInterpreter,
            global::tryAGI.OpenAI.AssistantToolsFileSearch? fileSearch,
            global::tryAGI.OpenAI.AssistantToolsFunction? function
            )
        {
            Type = type;

            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
            Function = function;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Function as object ??
            FileSearch as object ??
            CodeInterpreter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreter && !IsFileSearch && !IsFunction || !IsCodeInterpreter && IsFileSearch && !IsFunction || !IsCodeInterpreter && !IsFileSearch && IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AssistantToolsCode?, TResult>? codeInterpreter = null,
            global::System.Func<global::tryAGI.OpenAI.AssistantToolsFileSearch?, TResult>? fileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.AssistantToolsFunction?, TResult>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreter && codeInterpreter != null)
            {
                return codeInterpreter(CodeInterpreter!);
            }
            else if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AssistantToolsCode?>? codeInterpreter = null,
            global::System.Action<global::tryAGI.OpenAI.AssistantToolsFileSearch?>? fileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.AssistantToolsFunction?>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreter)
            {
                codeInterpreter?.Invoke(CodeInterpreter!);
            }
            else if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeInterpreter,
                typeof(global::tryAGI.OpenAI.AssistantToolsCode),
                FileSearch,
                typeof(global::tryAGI.OpenAI.AssistantToolsFileSearch),
                Function,
                typeof(global::tryAGI.OpenAI.AssistantToolsFunction),
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
        public bool Equals(ToolsItem8 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantToolsCode?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantToolsFileSearch?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantToolsFunction?>.Default.Equals(Function, other.Function) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem8 obj1, ToolsItem8 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem8>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem8 obj1, ToolsItem8 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem8 o && Equals(o);
        }
    }
}
