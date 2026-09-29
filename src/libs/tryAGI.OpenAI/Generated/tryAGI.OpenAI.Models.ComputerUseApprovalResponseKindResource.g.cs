#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ComputerUseApprovalResponseKindResource : global::System.IEquatable<ComputerUseApprovalResponseKindResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction? Action { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? Submit { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? Submit { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Submit))]
#endif
        public bool IsSubmit => Submit != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubmit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? value)
        {
            value = Submit;
            return IsSubmit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource PickSubmit() => Submit is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Submit' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? Cancel { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? Cancel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cancel))]
#endif
        public bool IsCancel => Cancel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCancel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? value)
        {
            value = Cancel;
            return IsCancel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource PickCancel() => Cancel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cancel' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerUseApprovalResponseKindResource(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource value) => new ComputerUseApprovalResponseKindResource((global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource?(ComputerUseApprovalResponseKindResource @this) => @this.Submit;

        /// <summary>
        ///
        /// </summary>
        public ComputerUseApprovalResponseKindResource(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? value)
        {
            Submit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseApprovalResponseKindResource FromSubmit(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? value) => new ComputerUseApprovalResponseKindResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerUseApprovalResponseKindResource(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource value) => new ComputerUseApprovalResponseKindResource((global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource?(ComputerUseApprovalResponseKindResource @this) => @this.Cancel;

        /// <summary>
        ///
        /// </summary>
        public ComputerUseApprovalResponseKindResource(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? value)
        {
            Cancel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseApprovalResponseKindResource FromCancel(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? value) => new ComputerUseApprovalResponseKindResource(value);

        /// <summary>
        ///
        /// </summary>
        public ComputerUseApprovalResponseKindResource(
            global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction? action,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource? submit,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource? cancel
            )
        {
            Action = action;

            Submit = submit;
            Cancel = cancel;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Cancel as object ??
            Submit as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Submit?.ToString() ??
            Cancel?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSubmit && !IsCancel || !IsSubmit && IsCancel;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource, TResult>? submit = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource, TResult>? cancel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Submit is { } __value0 && submit != null)
            {
                return submit(__value0);
            }
            else if (Cancel is { } __value1 && cancel != null)
            {
                return cancel(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource>? submit = null,

            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource>? cancel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Submit is { } __value0)
            {
                submit?.Invoke(__value0);
            }
            else if (Cancel is { } __value1)
            {
                cancel?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource>? submit = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource>? cancel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Submit is { } __value0)
            {
                submit?.Invoke(__value0);
            }
            else if (Cancel is { } __value1)
            {
                cancel?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Submit,
                typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource),
                Cancel,
                typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource),
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
        public bool Equals(ComputerUseApprovalResponseKindResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource?>.Default.Equals(Submit, other.Submit) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource?>.Default.Equals(Cancel, other.Cancel)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ComputerUseApprovalResponseKindResource obj1, ComputerUseApprovalResponseKindResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputerUseApprovalResponseKindResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ComputerUseApprovalResponseKindResource obj1, ComputerUseApprovalResponseKindResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerUseApprovalResponseKindResource o && Equals(o);
        }
    }
}
