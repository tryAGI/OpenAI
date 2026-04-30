// ReSharper disable once CheckNamespace
namespace tryAGI.OpenAI;

/// <summary>
/// Predefined providers uses OpenAI SDK compatible API.
/// </summary>
public static class CustomProviders
{
    /// <summary>
    /// https://github.com/marketplace/models
    /// </summary>
    public const string GitHubModelsBaseUrl = "https://models.inference.ai.azure.com/";
    
    /// <summary>
    /// 
    /// </summary>
    public const string DeepInfraBaseUrl = "https://api.deepinfra.com/v1/openai";
    
    /// <summary>
    /// 
    /// </summary>
    public const string GroqBaseUrl = "https://api.groq.com/openai/v1/";
    
    /// <summary>
    /// 
    /// </summary>
    public const string XAiBaseUrl = "https://api.x.ai/v1/";
    
    /// <summary>
    /// 
    /// </summary>
    public const string DeepSeekBaseUrl = "https://api.deepseek.com/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string FireworksBaseUrl = "https://api.fireworks.ai/inference/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string OpenRouterBaseUrl = "https://openrouter.ai/api/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string TogetherBaseUrl = "https://api.together.xyz/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string PerplexityBaseUrl = "https://api.perplexity.ai/";
    
    /// <summary>
    /// 
    /// </summary>
    public const string SambaNovaBaseUrl = "https://api.sambanova.ai/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string MistralBaseUrl = "https://api.mistral.ai/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string CodestralBaseUrl = "https://codestral.mistral.ai/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string HyperbolicBaseUrl = "https://api.hyperbolic.xyz/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string CohereBaseUrl = "https://api.cohere.ai/compatibility/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string OllamaBaseUrl = "http://localhost:11434/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string LmStudioBaseUrl = "http://localhost:1234/v1";

    /// <summary>
    /// https://inference-docs.cerebras.ai/openai
    /// </summary>
    public const string CerebrasBaseUrl = "https://api.cerebras.ai/v1";

    /// <summary>
    /// https://docs.nebius.com/studio/inference/api
    /// </summary>
    public const string NebiusBaseUrl = "https://api.studio.nebius.ai/v1/";

    /// <summary>
    /// https://build.nvidia.com/
    /// </summary>
    public const string NvidiaBaseUrl = "https://integrate.api.nvidia.com/v1";

    /// <summary>
    /// https://ollama.com/
    /// </summary>
    public const string OllamaCloudBaseUrl = "https://ollama.com/api/v1";

    /// <summary>
    /// https://platform.minimax.io/docs/api-reference
    /// </summary>
    public const string MinimaxBaseUrl = "https://api.minimax.io/v1";

    /// <summary>
    /// https://novita.ai/docs
    /// </summary>
    public const string NovitaAIBaseUrl = "https://api.novita.ai/v3/openai";

    /// <summary>
    /// https://help.aliyun.com/zh/model-studio/
    /// </summary>
    public const string QwenBaseUrl = "https://dashscope-intl.aliyuncs.com/compatible-mode/v1";

    /// <summary>
    /// https://www.lepton.ai/docs
    /// </summary>
    public const string LeptonAIBaseUrl = "https://api.lepton.ai/v1";

    /// <summary>
    /// https://cleanlab.ai/docs/
    /// </summary>
    public const string CleanlabBaseUrl = "https://api.cleanlab.ai/api/v1/openai_trustworthy_llm/";

    /// <summary>
    /// https://docs.siliconflow.cn/
    /// </summary>
    public const string SiliconFlowBaseUrl = "https://api.siliconflow.cn/v1";

    /// <summary>
    /// https://docs.inworld.ai/api-reference/routerAPI/
    /// Inworld LLM Router exposes OpenAI-compatible chat completions over many upstream models.
    /// Expects `Authorization: Basic &lt;base64-api-key&gt;` — the Inworld Portal already Base64-encodes the key.
    /// </summary>
    public const string InworldBaseUrl = "https://api.inworld.ai/v1";

    /// <summary>
    /// https://portal.nousresearch.com/api-docs
    /// </summary>
    public const string NousPortalBaseUrl = "https://inference-api.nousresearch.com/v1";

    /// <summary>
    /// https://vercel.com/docs/ai-gateway
    /// </summary>
    public const string VercelAIGatewayBaseUrl = "https://ai-gateway.vercel.sh/v1";

    /// <summary>
    /// https://huggingface.co/docs/hub/en/models-inference
    /// </summary>
    public const string HuggingFaceRouterBaseUrl = "https://router.huggingface.co/v1";

    /// <summary>
    /// https://ai.google.dev/gemini-api/docs/openai
    /// </summary>
    public const string GoogleAIStudioBaseUrl = "https://generativelanguage.googleapis.com/v1beta/openai/";

    /// <summary>
    /// https://platform.xiaomimimo.com/#/docs
    /// </summary>
    public const string XiaomiMiMoBaseUrl = "https://api.xiaomimimo.com/v1";

    /// <summary>
    /// https://cloud.tencent.com/document/product/1823/130079
    /// </summary>
    public const string TencentTokenHubBaseUrl = "https://tokenhub.tencentmaas.com/v1";

    /// <summary>
    /// https://www.tencentcloud.com/document/product/1300/78941
    /// </summary>
    public const string TencentTokenHubIntlBaseUrl = "https://tokenhub-intl.tencentcloudmaas.com/v1";

    /// <summary>
    /// https://docs.bigmodel.cn/api-reference
    /// </summary>
    public const string ZAiBaseUrl = "https://open.bigmodel.cn/api/paas/v4";

    /// <summary>
    /// https://platform.kimi.ai/docs/api/overview
    /// </summary>
    public const string MoonshotBaseUrl = "https://api.moonshot.ai/v1";

    /// <summary>
    /// https://www.kimi.com/code/docs/en/kimi-code/faq.html
    /// </summary>
    public const string KimiForCodingBaseUrl = "https://api.kimi.com/coding/v1";

    /// <summary>
    /// https://platform.kimi.com/docs/api/quickstart
    /// </summary>
    public const string MoonshotChinaBaseUrl = "https://api.moonshot.cn/v1";

    /// <summary>
    /// https://platform.stepfun.ai/docs/en/guide/openai
    /// </summary>
    public const string StepFunBaseUrl = "https://api.stepfun.ai/v1";

    /// <summary>
    /// https://platform.stepfun.ai/docs/en/stepplan/integrations/index
    /// </summary>
    public const string StepFunStepPlanBaseUrl = "https://api.stepfun.ai/step_plan/v1";

    /// <summary>
    /// https://platform.minimaxi.com/docs/token-plan/other-tools
    /// </summary>
    public const string MiniMaxChinaBaseUrl = "https://api.minimaxi.com/v1";

    /// <summary>
    /// https://www.alibabacloud.com/help/en/model-studio/regions/
    /// </summary>
    public const string DashScopeBaseUrl = "https://dashscope-intl.aliyuncs.com/compatible-mode/v1";

    /// <summary>
    /// https://help.aliyun.com/zh/model-studio/getting-started/alibaba-cloud-model-studio-quick-start
    /// </summary>
    public const string DashScopeChinaBaseUrl = "https://dashscope.aliyuncs.com/compatible-mode/v1";

    /// <summary>
    /// https://www.alibabacloud.com/help/en/model-studio/regions/
    /// </summary>
    public const string DashScopeUnitedStatesBaseUrl = "https://dashscope-us.aliyuncs.com/compatible-mode/v1";

    /// <summary>
    /// https://www.alibabacloud.com/help/en/model-studio/other-tools-coding-plan
    /// </summary>
    public const string DashScopeCodingPlanBaseUrl = "https://coding-intl.dashscope.aliyuncs.com/v1";

    /// <summary>
    /// https://docs.arcee.ai/api-reference/your-first-api-call
    /// </summary>
    public const string ArceeAIBaseUrl = "https://api.arcee.ai/api/v1";

    /// <summary>
    /// https://docs.arcee.ai/arcee-conductor/features-and-functionality/api
    /// </summary>
    public const string ArceeConductorBaseUrl = "https://models.arcee.ai/v1";

    /// <summary>
    /// https://docs.gmicloud.ai/inference-engine/api-reference/llm-api-reference
    /// </summary>
    public const string GmiCloudBaseUrl = "https://api.gmi-serving.com/v1";

    /// <summary>
    /// https://docs.kilo.ai/docs/gateway/
    /// </summary>
    public const string KiloGatewayBaseUrl = "https://api.kilo.ai/api/gateway";

    /// <summary>
    /// https://opencode.ai/docs/zen
    /// </summary>
    public const string OpenCodeZenBaseUrl = "https://opencode.ai/zen/v1";

    /// <summary>
    /// https://opencode.ai/docs/go
    /// </summary>
    public const string OpenCodeGoBaseUrl = "https://opencode.ai/zen/go/v1";

    /// <summary>
    /// Creates an API to use for GitHub Models: https://github.com/marketplace/models
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient GitHubModels(string githubToken)
    {
        return new OpenAiClient(githubToken, baseUri: new Uri(GitHubModelsBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Azure.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Azure(string apiKey, string endpoint)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(endpoint));
    }
    
    /// <summary>
    /// Create an API to use for DeepInfra.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient DeepInfra(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(DeepInfraBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Groq.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Groq(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(GroqBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for xAI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient XAi(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(XAiBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for DeepSeek.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient DeepSeek(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(DeepSeekBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Fireworks AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Fireworks(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(FireworksBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Open Router.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient OpenRouter(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(OpenRouterBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Together AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Together(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(TogetherBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Perplexity AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Perplexity(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(PerplexityBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for SambaNova AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient SambaNova(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(SambaNovaBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Mistral.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Mistral(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(MistralBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Codestral.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Codestral(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(CodestralBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Hyperbolic.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Hyperbolic(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(HyperbolicBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Cohere.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Cohere(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(CohereBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Ollama.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Ollama(Uri? baseUri = null)
    {
        return new OpenAiClient(baseUri: baseUri ?? new Uri(OllamaBaseUrl), options: null);
    }
    
    /// <summary>
    /// Create an API to use for LM Studio.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient LmStudio(Uri? baseUri = null)
    {
        return new OpenAiClient(baseUri: baseUri ?? new Uri(LmStudioBaseUrl), options: null);
    }

    /// <summary>
    /// Create an API to use for Cerebras.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Cerebras(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(CerebrasBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Nebius AI Studio.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Nebius(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(NebiusBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Nvidia NIM.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Nvidia(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(NvidiaBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Ollama Cloud.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient OllamaCloud(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(OllamaCloudBaseUrl));
    }

    /// <summary>
    /// Create an API to use for MiniMax.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Minimax(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(MinimaxBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Novita AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient NovitaAI(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(NovitaAIBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Qwen (Alibaba).
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Qwen(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(QwenBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Lepton AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient LeptonAI(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(LeptonAIBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Cleanlab TLM.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Cleanlab(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(CleanlabBaseUrl));
    }

    /// <summary>
    /// Create an API to use for SiliconFlow.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient SiliconFlow(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(SiliconFlowBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Inworld's LLM Router. Accepts either the
    /// Base64 Basic API key or a JWT Bearer token; the shipped OpenAI SDK
    /// sends the raw value as `Authorization: Bearer &lt;value&gt;`, so for
    /// server-side Basic usage callers should either supply a pre-minted JWT
    /// (see <c>InworldJwt.GenerateAsync</c> in <c>tryAGI.Inworld</c>) or
    /// configure a <see cref="System.Net.Http.HttpClient"/> that rewrites the
    /// scheme to `Basic`.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Inworld(string apiKeyOrJwt)
    {
        return new OpenAiClient(apiKeyOrJwt, baseUri: new Uri(InworldBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Nous Portal.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient NousPortal(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(NousPortalBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Vercel AI Gateway.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient VercelAIGateway(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(VercelAIGatewayBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Hugging Face Inference Providers' OpenAI-compatible router.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient HuggingFaceRouter(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(HuggingFaceRouterBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Google AI Studio's Gemini OpenAI-compatible endpoint.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient GoogleAIStudio(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(GoogleAIStudioBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Google Gemini's OpenAI-compatible endpoint.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Gemini(string apiKey)
    {
        return GoogleAIStudio(apiKey);
    }

    /// <summary>
    /// Create an API to use for Xiaomi MiMo.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient XiaomiMiMo(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(XiaomiMiMoBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Tencent TokenHub in Mainland China.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient TencentTokenHub(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(TencentTokenHubBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Tencent TokenHub international.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient TencentTokenHubIntl(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(TencentTokenHubIntlBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Z.AI / Zhipu GLM.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient ZAi(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(ZAiBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Kimi / Moonshot AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Moonshot(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(MoonshotBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Kimi Coding Plan.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient KimiForCoding(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(KimiForCodingBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Kimi / Moonshot China.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient MoonshotChina(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(MoonshotChinaBaseUrl));
    }

    /// <summary>
    /// Create an API to use for StepFun.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient StepFun(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(StepFunBaseUrl));
    }

    /// <summary>
    /// Create an API to use for StepFun Step Plan.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient StepFunStepPlan(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(StepFunStepPlanBaseUrl));
    }

    /// <summary>
    /// Create an API to use for MiniMax China.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient MiniMaxChina(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(MiniMaxChinaBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Alibaba Cloud Model Studio / DashScope international.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient DashScope(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(DashScopeBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Alibaba Cloud Model Studio / DashScope China.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient DashScopeChina(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(DashScopeChinaBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Alibaba Cloud Model Studio / DashScope United States.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient DashScopeUnitedStates(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(DashScopeUnitedStatesBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Alibaba Cloud Coding Plan.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient DashScopeCodingPlan(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(DashScopeCodingPlanBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Arcee AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient ArceeAI(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(ArceeAIBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Arcee Conductor.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient ArceeConductor(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(ArceeConductorBaseUrl));
    }

    /// <summary>
    /// Create an API to use for GMI Cloud.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient GmiCloud(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(GmiCloudBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Kilo Gateway.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient KiloGateway(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(KiloGatewayBaseUrl));
    }

    /// <summary>
    /// Create an API to use for OpenCode Zen.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient OpenCodeZen(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(OpenCodeZenBaseUrl));
    }

    /// <summary>
    /// Create an API to use for OpenCode Go.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient OpenCodeGo(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(OpenCodeGoBaseUrl));
    }
}
