#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object describing the specific action taken in this web search call.<br/>
    /// Includes details on how the model used the web (search, open_page, find_in_page).
    /// </summary>
    public readonly partial struct BetaWebSearchToolCallAction : global::System.IEquatable<BetaWebSearchToolCallAction>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType? Type { get; }

        /// <summary>
        /// Action type "search" - Performs a web search query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaWebSearchActionSearch? Search { get; init; }
#else
        public global::tryAGI.OpenAI.BetaWebSearchActionSearch? Search { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Search))]
#endif
        public bool IsSearch => Search != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaWebSearchActionSearch? value)
        {
            value = Search;
            return IsSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionSearch PickSearch() => IsSearch
            ? Search!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Search' but the value was {ToString()}.");

        /// <summary>
        /// Action type "open_page" - Opens a specific URL from search results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? OpenPage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? OpenPage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenPage))]
#endif
        public bool IsOpenPage => OpenPage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenPage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? value)
        {
            value = OpenPage;
            return IsOpenPage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionOpenPage PickOpenPage() => IsOpenPage
            ? OpenPage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenPage' but the value was {ToString()}.");

        /// <summary>
        /// Action type "find_in_page": Searches for a pattern within a loaded page.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaWebSearchActionFind? FindInPage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaWebSearchActionFind? FindInPage { get; }
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
        public bool TryPickFindInPage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaWebSearchActionFind? value)
        {
            value = FindInPage;
            return IsFindInPage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchActionFind PickFindInPage() => IsFindInPage
            ? FindInPage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FindInPage' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebSearchToolCallAction(global::tryAGI.OpenAI.BetaWebSearchActionSearch value) => new BetaWebSearchToolCallAction((global::tryAGI.OpenAI.BetaWebSearchActionSearch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaWebSearchActionSearch?(BetaWebSearchToolCallAction @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebSearchToolCallAction(global::tryAGI.OpenAI.BetaWebSearchActionSearch? value)
        {
            Search = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebSearchToolCallAction FromSearch(global::tryAGI.OpenAI.BetaWebSearchActionSearch? value) => new BetaWebSearchToolCallAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebSearchToolCallAction(global::tryAGI.OpenAI.BetaWebSearchActionOpenPage value) => new BetaWebSearchToolCallAction((global::tryAGI.OpenAI.BetaWebSearchActionOpenPage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaWebSearchActionOpenPage?(BetaWebSearchToolCallAction @this) => @this.OpenPage;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebSearchToolCallAction(global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? value)
        {
            OpenPage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebSearchToolCallAction FromOpenPage(global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? value) => new BetaWebSearchToolCallAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebSearchToolCallAction(global::tryAGI.OpenAI.BetaWebSearchActionFind value) => new BetaWebSearchToolCallAction((global::tryAGI.OpenAI.BetaWebSearchActionFind?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaWebSearchActionFind?(BetaWebSearchToolCallAction @this) => @this.FindInPage;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebSearchToolCallAction(global::tryAGI.OpenAI.BetaWebSearchActionFind? value)
        {
            FindInPage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebSearchToolCallAction FromFindInPage(global::tryAGI.OpenAI.BetaWebSearchActionFind? value) => new BetaWebSearchToolCallAction(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaWebSearchToolCallAction(
            global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaWebSearchActionSearch? search,
            global::tryAGI.OpenAI.BetaWebSearchActionOpenPage? openPage,
            global::tryAGI.OpenAI.BetaWebSearchActionFind? findInPage
            )
        {
            Type = type;

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
            global::System.Func<global::tryAGI.OpenAI.BetaWebSearchActionSearch, TResult>? search = null,
            global::System.Func<global::tryAGI.OpenAI.BetaWebSearchActionOpenPage, TResult>? openPage = null,
            global::System.Func<global::tryAGI.OpenAI.BetaWebSearchActionFind, TResult>? findInPage = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchActionSearch>? search = null,

            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchActionOpenPage>? openPage = null,

            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchActionFind>? findInPage = null,
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
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchActionSearch>? search = null,
            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchActionOpenPage>? openPage = null,
            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchActionFind>? findInPage = null,
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
                typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearch),
                OpenPage,
                typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPage),
                FindInPage,
                typeof(global::tryAGI.OpenAI.BetaWebSearchActionFind),
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
        public bool Equals(BetaWebSearchToolCallAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaWebSearchActionSearch?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaWebSearchActionOpenPage?>.Default.Equals(OpenPage, other.OpenPage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaWebSearchActionFind?>.Default.Equals(FindInPage, other.FindInPage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaWebSearchToolCallAction obj1, BetaWebSearchToolCallAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaWebSearchToolCallAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaWebSearchToolCallAction obj1, BetaWebSearchToolCallAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaWebSearchToolCallAction o && Equals(o);
        }
    }
}
