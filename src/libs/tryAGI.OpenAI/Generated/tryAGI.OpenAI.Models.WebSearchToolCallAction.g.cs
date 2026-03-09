#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object describing the specific action taken in this web search call.<br/>
    /// Includes details on how the model used the web (search, open_page, find_in_page).
    /// </summary>
    public readonly partial struct WebSearchToolCallAction : global::System.IEquatable<WebSearchToolCallAction>
    {
        /// <summary>
        /// Action type "search" - Performs a web search query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionSearch? Search { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionSearch? Search { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Search))]
#endif
        public bool IsSearch => Search != null;

        /// <summary>
        /// Action type "open_page" - Opens a specific URL from search results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionOpenPage? OpenPage { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionOpenPage? OpenPage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenPage))]
#endif
        public bool IsOpenPage => OpenPage != null;

        /// <summary>
        /// Action type "find_in_page": Searches for a pattern within a loaded page.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionFind? FindInPage { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionFind? FindInPage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FindInPage))]
#endif
        public bool IsFindInPage => FindInPage != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionSearch value) => new WebSearchToolCallAction((global::tryAGI.OpenAI.WebSearchActionSearch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionSearch?(WebSearchToolCallAction @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionSearch? value)
        {
            Search = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionOpenPage value) => new WebSearchToolCallAction((global::tryAGI.OpenAI.WebSearchActionOpenPage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionOpenPage?(WebSearchToolCallAction @this) => @this.OpenPage;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionOpenPage? value)
        {
            OpenPage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionFind value) => new WebSearchToolCallAction((global::tryAGI.OpenAI.WebSearchActionFind?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionFind?(WebSearchToolCallAction @this) => @this.FindInPage;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionFind? value)
        {
            FindInPage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolCallAction(
            global::tryAGI.OpenAI.WebSearchActionSearch? search,
            global::tryAGI.OpenAI.WebSearchActionOpenPage? openPage,
            global::tryAGI.OpenAI.WebSearchActionFind? findInPage
            )
        {
            Search = search;
            OpenPage = openPage;
            FindInPage = findInPage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FindInPage as object ??
            OpenPage as object ??
            Search as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Search?.ToString() ??
            OpenPage?.ToString() ??
            FindInPage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearch && !IsOpenPage && !IsFindInPage || !IsSearch && IsOpenPage && !IsFindInPage || !IsSearch && !IsOpenPage && IsFindInPage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionSearch?, TResult>? search = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionOpenPage?, TResult>? openPage = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionFind?, TResult>? findInPage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearch && search != null)
            {
                return search(Search!);
            }
            else if (IsOpenPage && openPage != null)
            {
                return openPage(OpenPage!);
            }
            else if (IsFindInPage && findInPage != null)
            {
                return findInPage(FindInPage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionSearch?>? search = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionOpenPage?>? openPage = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionFind?>? findInPage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsOpenPage)
            {
                openPage?.Invoke(OpenPage!);
            }
            else if (IsFindInPage)
            {
                findInPage?.Invoke(FindInPage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Search,
                typeof(global::tryAGI.OpenAI.WebSearchActionSearch),
                OpenPage,
                typeof(global::tryAGI.OpenAI.WebSearchActionOpenPage),
                FindInPage,
                typeof(global::tryAGI.OpenAI.WebSearchActionFind),
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
        public bool Equals(WebSearchToolCallAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionSearch?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionOpenPage?>.Default.Equals(OpenPage, other.OpenPage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionFind?>.Default.Equals(FindInPage, other.FindInPage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebSearchToolCallAction obj1, WebSearchToolCallAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSearchToolCallAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebSearchToolCallAction obj1, WebSearchToolCallAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchToolCallAction o && Equals(o);
        }
    }
}
