#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A content part that makes up an input or output item.
    /// </summary>
    public readonly partial struct ContentItem6 : global::System.IEquatable<ContentItem6>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputTextContent? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputTextContent? InputText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInputTextContent? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContent PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// A text output from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaOutputTextContent? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.BetaOutputTextContent? OutputText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputText))]
#endif
        public bool IsOutputText => OutputText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaOutputTextContent? value)
        {
            value = OutputText;
            return IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContent PickOutputText() => IsOutputText
            ? OutputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputText' but the value was {ToString()}.");

        /// <summary>
        /// A text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaTextContent? Text { get; init; }
#else
        public global::tryAGI.OpenAI.BetaTextContent? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaTextContent? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextContent PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// A summary text from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaSummaryTextContent? SummaryText { get; init; }
#else
        public global::tryAGI.OpenAI.BetaSummaryTextContent? SummaryText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SummaryText))]
#endif
        public bool IsSummaryText => SummaryText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSummaryText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaSummaryTextContent? value)
        {
            value = SummaryText;
            return IsSummaryText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaSummaryTextContent PickSummaryText() => IsSummaryText
            ? SummaryText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SummaryText' but the value was {ToString()}.");

        /// <summary>
        /// Reasoning text from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaReasoningTextContent? ReasoningText { get; init; }
#else
        public global::tryAGI.OpenAI.BetaReasoningTextContent? ReasoningText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningText))]
#endif
        public bool IsReasoningText => ReasoningText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoningText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaReasoningTextContent? value)
        {
            value = ReasoningText;
            return IsReasoningText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContent PickReasoningText() => IsReasoningText
            ? ReasoningText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningText' but the value was {ToString()}.");

        /// <summary>
        /// A refusal from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaRefusalContent? Refusal { get; init; }
#else
        public global::tryAGI.OpenAI.BetaRefusalContent? Refusal { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaRefusalContent? value)
        {
            value = Refusal;
            return IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContent PickRefusal() => IsRefusal
            ? Refusal!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Refusal' but the value was {ToString()}.");

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputImageContent? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputImageContent? InputImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInputImageContent? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContent PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        /// A screenshot of a computer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaComputerScreenshotContent? ComputerScreenshot { get; init; }
#else
        public global::tryAGI.OpenAI.BetaComputerScreenshotContent? ComputerScreenshot { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerScreenshot))]
#endif
        public bool IsComputerScreenshot => ComputerScreenshot != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerScreenshot(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaComputerScreenshotContent? value)
        {
            value = ComputerScreenshot;
            return IsComputerScreenshot;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerScreenshotContent PickComputerScreenshot() => IsComputerScreenshot
            ? ComputerScreenshot!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerScreenshot' but the value was {ToString()}.");

        /// <summary>
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputFileContent? InputFile { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputFileContent? InputFile { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFile))]
#endif
        public bool IsInputFile => InputFile != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInputFileContent? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContent PickInputFile() => IsInputFile
            ? InputFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFile' but the value was {ToString()}.");

        /// <summary>
        /// Opaque encrypted content that Responses API decrypts inside trusted model execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaEncryptedContent? EncryptedContent { get; init; }
#else
        public global::tryAGI.OpenAI.BetaEncryptedContent? EncryptedContent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EncryptedContent))]
#endif
        public bool IsEncryptedContent => EncryptedContent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEncryptedContent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaEncryptedContent? value)
        {
            value = EncryptedContent;
            return IsEncryptedContent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContent PickEncryptedContent() => IsEncryptedContent
            ? EncryptedContent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EncryptedContent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaInputTextContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaInputTextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputTextContent?(ContentItem6 @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaInputTextContent? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromInputText(global::tryAGI.OpenAI.BetaInputTextContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaOutputTextContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaOutputTextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaOutputTextContent?(ContentItem6 @this) => @this.OutputText;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaOutputTextContent? value)
        {
            OutputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromOutputText(global::tryAGI.OpenAI.BetaOutputTextContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaTextContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaTextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaTextContent?(ContentItem6 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaTextContent? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromText(global::tryAGI.OpenAI.BetaTextContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaSummaryTextContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaSummaryTextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaSummaryTextContent?(ContentItem6 @this) => @this.SummaryText;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaSummaryTextContent? value)
        {
            SummaryText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromSummaryText(global::tryAGI.OpenAI.BetaSummaryTextContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaReasoningTextContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaReasoningTextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaReasoningTextContent?(ContentItem6 @this) => @this.ReasoningText;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaReasoningTextContent? value)
        {
            ReasoningText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromReasoningText(global::tryAGI.OpenAI.BetaReasoningTextContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaRefusalContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaRefusalContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaRefusalContent?(ContentItem6 @this) => @this.Refusal;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaRefusalContent? value)
        {
            Refusal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromRefusal(global::tryAGI.OpenAI.BetaRefusalContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaInputImageContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaInputImageContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputImageContent?(ContentItem6 @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaInputImageContent? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromInputImage(global::tryAGI.OpenAI.BetaInputImageContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaComputerScreenshotContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaComputerScreenshotContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComputerScreenshotContent?(ContentItem6 @this) => @this.ComputerScreenshot;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaComputerScreenshotContent? value)
        {
            ComputerScreenshot = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromComputerScreenshot(global::tryAGI.OpenAI.BetaComputerScreenshotContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaInputFileContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaInputFileContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputFileContent?(ContentItem6 @this) => @this.InputFile;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaInputFileContent? value)
        {
            InputFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromInputFile(global::tryAGI.OpenAI.BetaInputFileContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem6(global::tryAGI.OpenAI.BetaEncryptedContent value) => new ContentItem6((global::tryAGI.OpenAI.BetaEncryptedContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaEncryptedContent?(ContentItem6 @this) => @this.EncryptedContent;

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(global::tryAGI.OpenAI.BetaEncryptedContent? value)
        {
            EncryptedContent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem6 FromEncryptedContent(global::tryAGI.OpenAI.BetaEncryptedContent? value) => new ContentItem6(value);

        /// <summary>
        ///
        /// </summary>
        public ContentItem6(
            global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaInputTextContent? inputText,
            global::tryAGI.OpenAI.BetaOutputTextContent? outputText,
            global::tryAGI.OpenAI.BetaTextContent? text,
            global::tryAGI.OpenAI.BetaSummaryTextContent? summaryText,
            global::tryAGI.OpenAI.BetaReasoningTextContent? reasoningText,
            global::tryAGI.OpenAI.BetaRefusalContent? refusal,
            global::tryAGI.OpenAI.BetaInputImageContent? inputImage,
            global::tryAGI.OpenAI.BetaComputerScreenshotContent? computerScreenshot,
            global::tryAGI.OpenAI.BetaInputFileContent? inputFile,
            global::tryAGI.OpenAI.BetaEncryptedContent? encryptedContent
            )
        {
            Type = type;

            InputText = inputText;
            OutputText = outputText;
            Text = text;
            SummaryText = summaryText;
            ReasoningText = reasoningText;
            Refusal = refusal;
            InputImage = inputImage;
            ComputerScreenshot = computerScreenshot;
            InputFile = inputFile;
            EncryptedContent = encryptedContent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EncryptedContent as object ??
            InputFile as object ??
            ComputerScreenshot as object ??
            InputImage as object ??
            Refusal as object ??
            ReasoningText as object ??
            SummaryText as object ??
            Text as object ??
            OutputText as object ??
            InputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            OutputText?.ToString() ??
            Text?.ToString() ??
            SummaryText?.ToString() ??
            ReasoningText?.ToString() ??
            Refusal?.ToString() ??
            InputImage?.ToString() ??
            ComputerScreenshot?.ToString() ??
            InputFile?.ToString() ??
            EncryptedContent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile && !IsEncryptedContent || !IsInputText && IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile && !IsEncryptedContent || !IsInputText && !IsOutputText && IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile && !IsEncryptedContent || !IsInputText && !IsOutputText && !IsText && IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile && !IsEncryptedContent || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile && !IsEncryptedContent || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile && !IsEncryptedContent || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && IsInputImage && !IsComputerScreenshot && !IsInputFile && !IsEncryptedContent || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && IsComputerScreenshot && !IsInputFile && !IsEncryptedContent || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && IsInputFile && !IsEncryptedContent || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile && IsEncryptedContent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaInputTextContent, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.BetaOutputTextContent, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.BetaTextContent, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.BetaSummaryTextContent, TResult>? summaryText = null,
            global::System.Func<global::tryAGI.OpenAI.BetaReasoningTextContent, TResult>? reasoningText = null,
            global::System.Func<global::tryAGI.OpenAI.BetaRefusalContent, TResult>? refusal = null,
            global::System.Func<global::tryAGI.OpenAI.BetaInputImageContent, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.BetaComputerScreenshotContent, TResult>? computerScreenshot = null,
            global::System.Func<global::tryAGI.OpenAI.BetaInputFileContent, TResult>? inputFile = null,
            global::System.Func<global::tryAGI.OpenAI.BetaEncryptedContent, TResult>? encryptedContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsOutputText && outputText != null)
            {
                return outputText(OutputText!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsSummaryText && summaryText != null)
            {
                return summaryText(SummaryText!);
            }
            else if (IsReasoningText && reasoningText != null)
            {
                return reasoningText(ReasoningText!);
            }
            else if (IsRefusal && refusal != null)
            {
                return refusal(Refusal!);
            }
            else if (IsInputImage && inputImage != null)
            {
                return inputImage(InputImage!);
            }
            else if (IsComputerScreenshot && computerScreenshot != null)
            {
                return computerScreenshot(ComputerScreenshot!);
            }
            else if (IsInputFile && inputFile != null)
            {
                return inputFile(InputFile!);
            }
            else if (IsEncryptedContent && encryptedContent != null)
            {
                return encryptedContent(EncryptedContent!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaInputTextContent>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.BetaOutputTextContent>? outputText = null,

            global::System.Action<global::tryAGI.OpenAI.BetaTextContent>? text = null,

            global::System.Action<global::tryAGI.OpenAI.BetaSummaryTextContent>? summaryText = null,

            global::System.Action<global::tryAGI.OpenAI.BetaReasoningTextContent>? reasoningText = null,

            global::System.Action<global::tryAGI.OpenAI.BetaRefusalContent>? refusal = null,

            global::System.Action<global::tryAGI.OpenAI.BetaInputImageContent>? inputImage = null,

            global::System.Action<global::tryAGI.OpenAI.BetaComputerScreenshotContent>? computerScreenshot = null,

            global::System.Action<global::tryAGI.OpenAI.BetaInputFileContent>? inputFile = null,

            global::System.Action<global::tryAGI.OpenAI.BetaEncryptedContent>? encryptedContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsSummaryText)
            {
                summaryText?.Invoke(SummaryText!);
            }
            else if (IsReasoningText)
            {
                reasoningText?.Invoke(ReasoningText!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsComputerScreenshot)
            {
                computerScreenshot?.Invoke(ComputerScreenshot!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
            else if (IsEncryptedContent)
            {
                encryptedContent?.Invoke(EncryptedContent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaInputTextContent>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.BetaOutputTextContent>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.BetaTextContent>? text = null,
            global::System.Action<global::tryAGI.OpenAI.BetaSummaryTextContent>? summaryText = null,
            global::System.Action<global::tryAGI.OpenAI.BetaReasoningTextContent>? reasoningText = null,
            global::System.Action<global::tryAGI.OpenAI.BetaRefusalContent>? refusal = null,
            global::System.Action<global::tryAGI.OpenAI.BetaInputImageContent>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.BetaComputerScreenshotContent>? computerScreenshot = null,
            global::System.Action<global::tryAGI.OpenAI.BetaInputFileContent>? inputFile = null,
            global::System.Action<global::tryAGI.OpenAI.BetaEncryptedContent>? encryptedContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsSummaryText)
            {
                summaryText?.Invoke(SummaryText!);
            }
            else if (IsReasoningText)
            {
                reasoningText?.Invoke(ReasoningText!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsComputerScreenshot)
            {
                computerScreenshot?.Invoke(ComputerScreenshot!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
            else if (IsEncryptedContent)
            {
                encryptedContent?.Invoke(EncryptedContent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::tryAGI.OpenAI.BetaInputTextContent),
                OutputText,
                typeof(global::tryAGI.OpenAI.BetaOutputTextContent),
                Text,
                typeof(global::tryAGI.OpenAI.BetaTextContent),
                SummaryText,
                typeof(global::tryAGI.OpenAI.BetaSummaryTextContent),
                ReasoningText,
                typeof(global::tryAGI.OpenAI.BetaReasoningTextContent),
                Refusal,
                typeof(global::tryAGI.OpenAI.BetaRefusalContent),
                InputImage,
                typeof(global::tryAGI.OpenAI.BetaInputImageContent),
                ComputerScreenshot,
                typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContent),
                InputFile,
                typeof(global::tryAGI.OpenAI.BetaInputFileContent),
                EncryptedContent,
                typeof(global::tryAGI.OpenAI.BetaEncryptedContent),
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
        public bool Equals(ContentItem6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputTextContent?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaOutputTextContent?>.Default.Equals(OutputText, other.OutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaTextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaSummaryTextContent?>.Default.Equals(SummaryText, other.SummaryText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaReasoningTextContent?>.Default.Equals(ReasoningText, other.ReasoningText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaRefusalContent?>.Default.Equals(Refusal, other.Refusal) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputImageContent?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComputerScreenshotContent?>.Default.Equals(ComputerScreenshot, other.ComputerScreenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputFileContent?>.Default.Equals(InputFile, other.InputFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaEncryptedContent?>.Default.Equals(EncryptedContent, other.EncryptedContent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentItem6 obj1, ContentItem6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentItem6 obj1, ContentItem6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem6 o && Equals(o);
        }
    }
}
