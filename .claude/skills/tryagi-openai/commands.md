# OpenAI API — commands reference

Full per-command reference derived from the OpenAPI spec. For the short overview + credentials flow see [SKILL.md](./SKILL.md).

## `assistant`

Build Assistants that can call models and use tools.

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-arun` | `POST /threads/{thread_id}/runs/{run_id}/cancel` | Cancels a run that is `in_progress`. |
| `create-message` | `POST /threads/{thread_id}/messages` | Create a message. |
| `create-run` | `POST /threads/{thread_id}/runs` | Create a run. |
| `create-thread` | `POST /threads` | Create a thread. |
| `create-thread-and-run` | `POST /threads/runs` | Create a thread and run it in one request. |
| `delete-message` | `DELETE /threads/{thread_id}/messages/{message_id}` | Deletes a message. |
| `delete-thread` | `DELETE /threads/{thread_id}` | Delete a thread. |
| `list-messages` | `GET /threads/{thread_id}/messages` | Returns a list of messages for a given thread. |
| `list-run-steps` | `GET /threads/{thread_id}/runs/{run_id}/steps` | Returns a list of run steps belonging to a run. |
| `list-runs` | `GET /threads/{thread_id}/runs` | Returns a list of runs belonging to a thread. |
| `modify-message` | `POST /threads/{thread_id}/messages/{message_id}` | Modifies a message. |
| `modify-run` | `POST /threads/{thread_id}/runs/{run_id}` | Modifies a run. |
| `modify-thread` | `POST /threads/{thread_id}` | Modifies a thread. |
| `retrieve-message` | `GET /threads/{thread_id}/messages/{message_id}` | Retrieve a message. |
| `retrieve-run` | `GET /threads/{thread_id}/runs/{run_id}` | Retrieves a run. |
| `retrieve-run-step` | `GET /threads/{thread_id}/runs/{run_id}/steps/{step_id}` | Retrieves a run step. |
| `retrieve-thread` | `GET /threads/{thread_id}` | Retrieves a thread. |
| `submit-tool-outputs-to-run` | `POST /threads/{thread_id}/runs/{run_id}/submit_tool_outputs` | When a run has the `status: "requires_action"` and `required_action.type` is `submit_tool_outputs`, this endpoint can be used to submit the outputs from the tool calls once they're all completed. All outputs must be submitted in a single request. |

## `audio`

Turn audio into text or text into audio.

| Command | Route | Description |
|---------|-------|-------------|
| `create-speech` | `POST /audio/speech` | Generates audio from the input text.  Returns the audio file content, or a stream of audio events. |
| `create-transcription` | `POST /audio/transcriptions` | Transcribes audio into the input language.  Returns a transcription object in `json`, `diarized_json`, or `verbose_json` format, or a stream of transcript events. |
| `create-translation` | `POST /audio/translations` | Translates audio into English. |
| `create-voice` | `POST /audio/voices` | Creates a custom voice. |
| `create-voice-consent` | `POST /audio/voice_consents` | Upload a voice consent recording. |
| `delete-voice-consent` | `DELETE /audio/voice_consents/{consent_id}` | Deletes a voice consent recording. |
| `list-voice-consents` | `GET /audio/voice_consents` | Returns a list of voice consent recordings. |
| `retrieve-voice-consent` | `GET /audio/voice_consents/{consent_id}` | Retrieves a voice consent recording. |
| `update-voice-consent` | `POST /audio/voice_consents/{consent_id}` | Updates a voice consent recording (metadata only). |

## `audit-log`

List user actions and configuration changes within this organization.

| Command | Route | Description |
|---------|-------|-------------|
| `list-audit-logs` | `GET /organization/audit_logs` | List user actions and configuration changes within this organization. |

## `batch`

Create large batches of API requests to run asynchronously.

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-batch` | `POST /batches/{batch_id}/cancel` | Cancels an in-progress batch. The batch will be in status `cancelling` for up to 10 minutes, before changing to `cancelled`, where it will have partial results (if any) available in the output file. |
| `create-batch` | `POST /batches` | Creates and executes a batch from an uploaded file of requests |
| `list-batches` | `GET /batches` | List your organization's batches. |
| `retrieve-batch` | `GET /batches/{batch_id}` | Retrieves a batch. |

## `certificate`

| Command | Route | Description |
|---------|-------|-------------|
| `activate-certificates-for-organization` | `POST /organization/certificates/activate` | Activate certificates at the organization level.  You can atomically and idempotently activate up to 10 certificates at a time. |
| `activate-certificates-for-project` | `POST /organization/projects/{project_id}/certificates/activate` | Activate certificates at the project level.  You can atomically and idempotently activate up to 10 certificates at a time. |
| `deactivate-certificates-for-organization` | `POST /organization/certificates/deactivate` | Deactivate certificates at the organization level.  You can atomically and idempotently deactivate up to 10 certificates at a time. |
| `deactivate-certificates-for-project` | `POST /organization/projects/{project_id}/certificates/deactivate` | Deactivate certificates at the project level. You can atomically and  idempotently deactivate up to 10 certificates at a time. |
| `delete-certificate` | `DELETE /organization/certificates/{certificate_id}` | Delete a certificate from the organization.  The certificate must be inactive for the organization and all projects. |
| `get-certificate` | `GET /organization/certificates/{certificate_id}` | Get a certificate that has been uploaded to the organization.  You can get a certificate regardless of whether it is active or not. |
| `list-organization-certificates` | `GET /organization/certificates` | List uploaded certificates for this organization. |
| `list-project-certificates` | `GET /organization/projects/{project_id}/certificates` | List certificates for this project. |
| `modify-certificate` | `POST /organization/certificates/{certificate_id}` | Modify a certificate. Note that only the name can be modified. |
| `upload-certificate` | `POST /organization/certificates` | Upload a certificate to the organization. This does **not** automatically activate the certificate.  Organizations can upload up to 50 certificates. |

## `chat`

Given a list of messages comprising a conversation, the model will return a response.

| Command | Route | Description |
|---------|-------|-------------|
| `create-chat-completion` | `POST /chat/completions` | **Starting a new project?** We recommend trying [Responses](/docs/api-reference/responses) to take advantage of the latest OpenAI platform features. Compare [Chat Completions with Responses](/docs/guides/responses-vs-chat-completions?api-mode=responses).  ---  Creates a model response for the given chat conversation. Learn more in the [text generation](/docs/guides/text-generation), [vision](/docs/guides/vision), and [audio](/docs/guides/audio) guides.  Parameter support can differ depending on the model used to generate the response, particularly for newer reasoning models. Parameters that are only supported for reasoning models are noted below. For the current state of unsupported parameters in reasoning models, [refer to the reasoning guide](/docs/guides/reasoning).  Returns a chat completion object, or a streamed sequence of chat completion chunk objects if the request is streamed. |
| `delete-chat-completion` | `DELETE /chat/completions/{completion_id}` | Delete a stored chat completion. Only Chat Completions that have been created with the `store` parameter set to `true` can be deleted. |
| `get-chat-completion` | `GET /chat/completions/{completion_id}` | Get a stored chat completion. Only Chat Completions that have been created with the `store` parameter set to `true` will be returned. |
| `get-chat-messages` | `GET /chat/completions/{completion_id}/messages` | Get the messages in a stored chat completion. Only Chat Completions that have been created with the `store` parameter set to `true` will be returned. |
| `list-chat-completions` | `GET /chat/completions` | List stored Chat Completions. Only Chat Completions that have been stored with the `store` parameter set to `true` will be returned. |
| `update-chat-completion` | `POST /chat/completions/{completion_id}` | Modify a stored chat completion. Only Chat Completions that have been created with the `store` parameter set to `true` can be modified. Currently, the only supported modification is to update the `metadata` field. |

## `completion`

Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of alternative tokens at each position.

| Command | Route | Description |
|---------|-------|-------------|
| `create-completion` | `POST /completions` | Creates a completion for the provided prompt and parameters.  Returns a completion object, or a sequence of completion objects if the request is streamed. |

## `conversation`

Manage conversations and conversation items.

| Command | Route | Description |
|---------|-------|-------------|
| `create-aconversation` | `POST /conversations` | Create a conversation. |
| `create-items` | `POST /conversations/{conversation_id}/items` | Create items in a conversation with the given ID. |
| `delete-aconversation` | `DELETE /conversations/{conversation_id}` | Delete a conversation. Items in the conversation will not be deleted. |
| `delete-an-item` | `DELETE /conversations/{conversation_id}/items/{item_id}` | Delete an item from a conversation with the given IDs. |
| `list-items` | `GET /conversations/{conversation_id}/items` | List all items for a conversation with the given ID. |
| `retrieve-aconversation` | `GET /conversations/{conversation_id}` | Get a conversation |
| `retrieve-an-item` | `GET /conversations/{conversation_id}/items/{item_id}` | Get a single item from a conversation with the given IDs. |
| `update-aconversation` | `POST /conversations/{conversation_id}` | Update a conversation |

## `embedding`

Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.

| Command | Route | Description |
|---------|-------|-------------|
| `create-embeddings` | `POST /embeddings` | Creates an embedding vector representing the input text. |

## `eval`

Manage and run evals in the OpenAI platform.

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-eval-run` | `POST /evals/{eval_id}/runs/{run_id}` | Cancel an ongoing evaluation run. |
| `create-eval` | `POST /evals` | Create the structure of an evaluation that can be used to test a model's performance. An evaluation is a set of testing criteria and the config for a data source, which dictates the schema of the data used in the evaluation. After creating an evaluation, you can run it on different models and model parameters. We support several types of graders and datasources. For more information, see the [Evals guide](/docs/guides/evals). |
| `create-eval-run` | `POST /evals/{eval_id}/runs` | Kicks off a new run for a given evaluation, specifying the data source, and what model configuration to use to test. The datasource will be validated against the schema specified in the config of the evaluation. |
| `delete-an-eval` | `DELETE /evals/{eval_id}` | Delete an evaluation. |
| `delete-eval-run` | `DELETE /evals/{eval_id}/runs/{run_id}` | Delete an eval run. |
| `get-an-eval` | `GET /evals/{eval_id}` | Get an evaluation by ID. |
| `get-an-eval-run` | `GET /evals/{eval_id}/runs/{run_id}` | Get an evaluation run by ID. |
| `get-an-output-item-of-an-eval-run` | `GET /evals/{eval_id}/runs/{run_id}/output_items/{output_item_id}` | Get an evaluation run output item by ID. |
| `get-eval-run-output-items` | `GET /evals/{eval_id}/runs/{run_id}/output_items` | Get a list of output items for an evaluation run. |
| `get-eval-runs` | `GET /evals/{eval_id}/runs` | Get a list of runs for an evaluation. |
| `list-evals` | `GET /evals` | List evaluations for a project. |
| `update-an-eval` | `POST /evals/{eval_id}` | Update certain properties of an evaluation. |

## `file`

Files are used to upload documents that can be used with features like Assistants and Fine-tuning.

| Command | Route | Description |
|---------|-------|-------------|
| `delete-file` | `DELETE /files/{file_id}` | Delete a file and remove it from all vector stores. |
| `list-files` | `GET /files` | Returns a list of files. |
| `retrieve-file` | `GET /files/{file_id}` | Returns information about a specific file. |
| `retrieve-file-content` | `GET /files/{file_id}/content` | Returns the contents of the specified file. |
| `upload-file` | `POST /files` | Upload a file that can be used across various endpoints. Individual files can be up to 512 MB, and each project can store up to 2.5 TB of files in total. There is no organization-wide storage limit. Uploads to this endpoint are rate-limited to 2,000 files per minute per organization.  - The Assistants API supports files up to 2 million tokens and of specific   file types. See the [Assistants Tools guide](/docs/assistants/tools) for   details. - The Fine-tuning API only supports `.jsonl` files. The input also has   certain required formats for fine-tuning   [chat](/docs/api-reference/fine-tuning/chat-input) or   [completions](/docs/api-reference/fine-tuning/completions-input) models. - The Batch API only supports `.jsonl` files up to 200 MB in size. The input   also has a specific required   [format](/docs/api-reference/batch/request-input). - For Retrieval or `file_search` ingestion, upload files here first. If   you need to attach multiple uploaded files to the same vector store, use   [`/vector_stores/{vector_store_id}/file_batches`](/docs/api-reference/vector-stores-file-batches/createBatch)   instead of attaching them one by one.  Please [contact us](https://help.openai.com/) if you need to increase these storage limits. |

## `fine-tuning`

Manage fine-tuning jobs to tailor a model to your specific training data.

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-fine-tuning` | `POST /fine_tuning/jobs/{fine_tuning_job_id}/cancel` | Immediately cancel a fine-tune job. |
| `create-checkpoint-permissions` | `POST /fine_tuning/checkpoints/{fine_tuned_model_checkpoint}/permissions` | **NOTE:** Calling this endpoint requires an [admin API key](../admin-api-keys).  This enables organization owners to share fine-tuned models with other projects in their organization. |
| `create-fine-tuning-job` | `POST /fine_tuning/jobs` | Creates a fine-tuning job which begins the process of creating a new model from a given dataset.  Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.  [Learn more about fine-tuning](/docs/guides/model-optimization) |
| `delete-checkpoint-permission` | `DELETE /fine_tuning/checkpoints/{fine_tuned_model_checkpoint}/permissions/{permission_id}` | **NOTE:** This endpoint requires an [admin API key](../admin-api-keys).  Organization owners can use this endpoint to delete a permission for a fine-tuned model checkpoint. |
| `list-checkpoint-permissions` | `GET /fine_tuning/checkpoints/{fine_tuned_model_checkpoint}/permissions` | **NOTE:** This endpoint requires an [admin API key](../admin-api-keys).  Organization owners can use this endpoint to view all permissions for a fine-tuned model checkpoint. |
| `list-fine-tuning-checkpoints` | `GET /fine_tuning/jobs/{fine_tuning_job_id}/checkpoints` | List checkpoints for a fine-tuning job. |
| `list-fine-tuning-events` | `GET /fine_tuning/jobs/{fine_tuning_job_id}/events` | Get status updates for a fine-tuning job. |
| `list-fine-tuning-jobs` | `GET /fine_tuning/jobs` | List your organization's fine-tuning jobs |
| `pause-fine-tuning` | `POST /fine_tuning/jobs/{fine_tuning_job_id}/pause` | Pause a fine-tune job. |
| `resume-fine-tuning` | `POST /fine_tuning/jobs/{fine_tuning_job_id}/resume` | Resume a fine-tune job. |
| `retrieve-fine-tuning-job` | `GET /fine_tuning/jobs/{fine_tuning_job_id}` | Get info about a fine-tuning job.  [Learn more about fine-tuning](/docs/guides/model-optimization) |
| `run-grader` | `POST /fine_tuning/alpha/graders/run` | Run a grader. |
| `validate-grader` | `POST /fine_tuning/alpha/graders/validate` | Validate a grader. |

## `group`

| Command | Route | Description |
|---------|-------|-------------|
| `create-group` | `POST /organization/groups` | Creates a new group in the organization. |
| `delete-group` | `DELETE /organization/groups/{group_id}` | Deletes a group from the organization. |
| `list-groups` | `GET /organization/groups` | Lists all groups in the organization. |
| `update-group` | `POST /organization/groups/{group_id}` | Updates a group's information. |

## `group-organization-role-assignment`

| Command | Route | Description |
|---------|-------|-------------|
| `assign-organization-role-to-group` | `POST /organization/groups/{group_id}/roles` | Assigns an organization role to a group within the organization. |
| `list-group-organization-role-assignments` | `GET /organization/groups/{group_id}/roles` | Lists the organization roles assigned to a group within the organization. |
| `unassign-organization-role-from-group` | `DELETE /organization/groups/{group_id}/roles/{role_id}` | Unassigns an organization role from a group within the organization. |

## `group-user`

| Command | Route | Description |
|---------|-------|-------------|
| `add-group-user` | `POST /organization/groups/{group_id}/users` | Adds a user to a group. |
| `list-group-users` | `GET /organization/groups/{group_id}/users` | Lists the users assigned to a group. |
| `remove-group-user` | `DELETE /organization/groups/{group_id}/users/{user_id}` | Removes a user from a group. |

## `image`

Given a prompt and/or an input image, the model will generate a new image.

| Command | Route | Description |
|---------|-------|-------------|
| `create-image` | `POST /images/generations` | Creates an image given a prompt. [Learn more](/docs/guides/images). |
| `create-image-edit` | `POST /images/edits` | Creates an edited or extended image given one or more source images and a prompt. This endpoint supports GPT Image models (`gpt-image-1.5`, `gpt-image-1`, `gpt-image-1-mini`, and `chatgpt-image-latest`) and `dall-e-2`. |
| `create-image-variation` | `POST /images/variations` | Creates a variation of a given image. This endpoint only supports `dall-e-2`. |

## `invite`

| Command | Route | Description |
|---------|-------|-------------|
| `create-invite` | `POST /organization/invites` | Create an invite for a user to the organization. The invite must be accepted by the user before they have access to the organization. |
| `delete-invite` | `DELETE /organization/invites/{invite_id}` | Delete an invite. If the invite has already been accepted, it cannot be deleted. |
| `list-invites` | `GET /organization/invites` | Returns a list of invites in the organization. |
| `retrieve-invite` | `GET /organization/invites/{invite_id}` | Retrieves an invite. |

## `model`

List and describe the various models available in the API.

| Command | Route | Description |
|---------|-------|-------------|
| `delete-afine-tuned-model` | `DELETE /models/{model}` | Delete a fine-tuned model. You must have the Owner role in your organization to delete a model. |
| `list-models` | `GET /models` | Lists the currently available models, and provides basic information about each one such as the owner and availability. |
| `retrieve-model` | `GET /models/{model}` | Retrieves a model instance, providing basic information about the model such as the owner and permissioning. |

## `moderation`

Given text and/or image inputs, classifies if those inputs are potentially harmful.

| Command | Route | Description |
|---------|-------|-------------|
| `create-moderation` | `POST /moderations` | Classifies if text and/or image inputs are potentially harmful. Learn more in the [moderation guide](/docs/guides/moderation). |

## `project`

| Command | Route | Description |
|---------|-------|-------------|
| `archive-project` | `POST /organization/projects/{project_id}/archive` | Archives a project in the organization. Archived projects cannot be used or updated. |
| `create-project` | `POST /organization/projects` | Create a new project in the organization. Projects can be created and archived, but cannot be deleted. |
| `create-project-service-account` | `POST /organization/projects/{project_id}/service_accounts` | Creates a new service account in the project. This also returns an unredacted API key for the service account. |
| `create-project-user` | `POST /organization/projects/{project_id}/users` | Adds a user to the project. Users must already be members of the organization to be added to a project. |
| `delete-project-api-key` | `DELETE /organization/projects/{project_id}/api_keys/{key_id}` | Deletes an API key from the project.  Returns confirmation of the key deletion, or an error if the key belonged to a service account. |
| `delete-project-service-account` | `DELETE /organization/projects/{project_id}/service_accounts/{service_account_id}` | Deletes a service account from the project.  Returns confirmation of service account deletion, or an error if the project is archived (archived projects have no service accounts). |
| `delete-project-user` | `DELETE /organization/projects/{project_id}/users/{user_id}` | Deletes a user from the project.  Returns confirmation of project user deletion, or an error if the project is archived (archived projects have no users). |
| `list-project-api-keys` | `GET /organization/projects/{project_id}/api_keys` | Returns a list of API keys in the project. |
| `list-project-rate-limits` | `GET /organization/projects/{project_id}/rate_limits` | Returns the rate limits per model for a project. |
| `list-project-service-accounts` | `GET /organization/projects/{project_id}/service_accounts` | Returns a list of service accounts in the project. |
| `list-project-users` | `GET /organization/projects/{project_id}/users` | Returns a list of users in the project. |
| `list-projects` | `GET /organization/projects` | Returns a list of projects. |
| `modify-project` | `POST /organization/projects/{project_id}` | Modifies a project in the organization. |
| `modify-project-rate-limit` | `POST /organization/projects/{project_id}/rate_limits/{rate_limit_id}` | Updates a project rate limit. |
| `modify-project-user` | `POST /organization/projects/{project_id}/users/{user_id}` | Modifies a user's role in the project. |
| `retrieve-project` | `GET /organization/projects/{project_id}` | Retrieves a project. |
| `retrieve-project-api-key` | `GET /organization/projects/{project_id}/api_keys/{key_id}` | Retrieves an API key in the project. |
| `retrieve-project-service-account` | `GET /organization/projects/{project_id}/service_accounts/{service_account_id}` | Retrieves a service account in the project. |
| `retrieve-project-user` | `GET /organization/projects/{project_id}/users/{user_id}` | Retrieves a user in the project. |

## `project-group`

| Command | Route | Description |
|---------|-------|-------------|
| `add-project-group` | `POST /organization/projects/{project_id}/groups` | Grants a group access to a project. |
| `list-project-groups` | `GET /organization/projects/{project_id}/groups` | Lists the groups that have access to a project. |
| `remove-project-group` | `DELETE /organization/projects/{project_id}/groups/{group_id}` | Revokes a group's access to a project. |

## `project-group-role-assignment`

| Command | Route | Description |
|---------|-------|-------------|
| `assign-project-role-to-group` | `POST /projects/{project_id}/groups/{group_id}/roles` | Assigns a project role to a group within a project. |
| `list-project-group-role-assignments` | `GET /projects/{project_id}/groups/{group_id}/roles` | Lists the project roles assigned to a group within a project. |
| `unassign-project-role-from-group` | `DELETE /projects/{project_id}/groups/{group_id}/roles/{role_id}` | Unassigns a project role from a group within a project. |

## `project-user-role-assignment`

| Command | Route | Description |
|---------|-------|-------------|
| `assign-project-role-to-user` | `POST /projects/{project_id}/users/{user_id}/roles` | Assigns a project role to a user within a project. |
| `list-project-user-role-assignments` | `GET /projects/{project_id}/users/{user_id}/roles` | Lists the project roles assigned to a user within a project. |
| `unassign-project-role-from-user` | `DELETE /projects/{project_id}/users/{user_id}/roles/{role_id}` | Unassigns a project role from a user within a project. |

## `realtime`

| Command | Route | Description |
|---------|-------|-------------|
| `accept-call` | `POST /realtime/calls/{call_id}/accept` | Accept an incoming SIP call and configure the realtime session that will handle it. |
| `create-call` | `POST /realtime/calls` | Create a new Realtime API call over WebRTC and receive the SDP answer needed to complete the peer connection. |
| `create-client-secret` | `POST /realtime/client_secrets` | Create a Realtime client secret with an associated session configuration.  Client secrets are short-lived tokens that can be passed to a client app, such as a web frontend or mobile client, which grants access to the Realtime API without leaking your main API key. You can configure a custom TTL for each client secret.  You can also attach session configuration options to the client secret, which will be applied to any sessions created using that client secret, but these can also be overridden by the client connection.  [Learn more about authentication with client secrets over WebRTC](/docs/guides/realtime-webrtc).  Returns the created client secret and the effective session object. The client secret is a string that looks like `ek_1234`. |
| `create-session` | `POST /realtime/sessions` | Create an ephemeral API token for use in client-side applications with the Realtime API. Can be configured with the same session parameters as the `session.update` client event.  It responds with a session object, plus a `client_secret` key which contains a usable ephemeral API token that can be used to authenticate browser clients for the Realtime API.  Returns the created Realtime session object, plus an ephemeral key. |
| `create-transcription-session` | `POST /realtime/transcription_sessions` | Create an ephemeral API token for use in client-side applications with the Realtime API specifically for realtime transcriptions.  Can be configured with the same session parameters as the `transcription_session.update` client event.  It responds with a session object, plus a `client_secret` key which contains a usable ephemeral API token that can be used to authenticate browser clients for the Realtime API.  Returns the created Realtime transcription session object, plus an ephemeral key. |
| `hang-up-call` | `POST /realtime/calls/{call_id}/hangup` | End an active Realtime API call, whether it was initiated over SIP or WebRTC. |
| `refer-call` | `POST /realtime/calls/{call_id}/refer` | Transfer an active SIP call to a new destination using the SIP REFER verb. |
| `reject-call` | `POST /realtime/calls/{call_id}/reject` | Decline an incoming SIP call by returning a SIP status code to the caller. |

## `response`

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-aresponse` | `POST /responses/{response_id}/cancel` | Cancels a model response with the given ID. Only responses created with the `background` parameter set to `true` can be cancelled.  [Learn more](/docs/guides/background). |
| `create-amodel-response` | `POST /responses` | Creates a model response. Provide [text](/docs/guides/text) or [image](/docs/guides/images) inputs to generate [text](/docs/guides/text) or [JSON](/docs/guides/structured-outputs) outputs. Have the model call your own [custom code](/docs/guides/function-calling) or use built-in [tools](/docs/guides/tools) like [web search](/docs/guides/tools-web-search) or [file search](/docs/guides/tools-file-search) to use your own data as input for the model's response. |
| `delete-amodel-response` | `DELETE /responses/{response_id}` | Deletes a model response with the given ID. |
| `get-amodel-response` | `GET /responses/{response_id}` | Retrieves a model response with the given ID. |
| `list-input-items` | `GET /responses/{response_id}/input_items` | Returns a list of input items for a given response. |

## `role`

| Command | Route | Description |
|---------|-------|-------------|
| `create-organization-role` | `POST /organization/roles` | Creates a custom role for the organization. |
| `create-project-role` | `POST /projects/{project_id}/roles` | Creates a custom role for a project. |
| `delete-organization-role` | `DELETE /organization/roles/{role_id}` | Deletes a custom role from the organization. |
| `delete-project-role` | `DELETE /projects/{project_id}/roles/{role_id}` | Deletes a custom role from a project. |
| `list-organization-roles` | `GET /organization/roles` | Lists the roles configured for the organization. |
| `list-project-roles` | `GET /projects/{project_id}/roles` | Lists the roles configured for a project. |
| `update-organization-role` | `POST /organization/roles/{role_id}` | Updates an existing organization role. |
| `update-project-role` | `POST /projects/{project_id}/roles/{role_id}` | Updates an existing project role. |

## `skill`

| Command | Route | Description |
|---------|-------|-------------|
| `create-skill` | `POST /skills` | Create a new skill. |
| `create-skill-version` | `POST /skills/{skill_id}/versions` | Create a new immutable skill version. |
| `delete-skill` | `DELETE /skills/{skill_id}` | Delete a skill by its ID. |
| `delete-skill-version` | `DELETE /skills/{skill_id}/versions/{version}` | Delete a skill version. |
| `get-skill` | `GET /skills/{skill_id}` | Get a skill by its ID. |
| `get-skill-content` | `GET /skills/{skill_id}/content` | Download a skill zip bundle by its ID. |
| `get-skill-version` | `GET /skills/{skill_id}/versions/{version}` | Get a specific skill version. |
| `get-skill-version-content` | `GET /skills/{skill_id}/versions/{version}/content` | Download a skill version zip bundle. |
| `list-skill-versions` | `GET /skills/{skill_id}/versions` | List skill versions for a skill. |
| `list-skills` | `GET /skills` | List all skills for the current project. |
| `update-skill-default-version` | `POST /skills/{skill_id}` | Update the default version pointer for a skill. |

## `upload`

Use Uploads to upload large files in multiple parts.

| Command | Route | Description |
|---------|-------|-------------|
| `add-upload-part` | `POST /uploads/{upload_id}/parts` | Adds a [Part](/docs/api-reference/uploads/part-object) to an [Upload](/docs/api-reference/uploads/object) object. A Part represents a chunk of bytes from the file you are trying to upload.   Each Part can be at most 64 MB, and you can add Parts until you hit the Upload maximum of 8 GB.  It is possible to add multiple Parts in parallel. You can decide the intended order of the Parts when you [complete the Upload](/docs/api-reference/uploads/complete). |
| `cancel-upload` | `POST /uploads/{upload_id}/cancel` | Cancels the Upload. No Parts may be added after an Upload is cancelled.  Returns the Upload object with status `cancelled`. |
| `complete-upload` | `POST /uploads/{upload_id}/complete` | Completes the [Upload](/docs/api-reference/uploads/object).   Within the returned Upload object, there is a nested [File](/docs/api-reference/files/object) object that is ready to use in the rest of the platform.  You can specify the order of the Parts by passing in an ordered list of the Part IDs.  The number of bytes uploaded upon completion must match the number of bytes initially specified when creating the Upload object. No Parts may be added after an Upload is completed. Returns the Upload object with status `completed`, including an additional `file` property containing the created usable File object. |
| `create-upload` | `POST /uploads` | Creates an intermediate [Upload](/docs/api-reference/uploads/object) object that you can add [Parts](/docs/api-reference/uploads/part-object) to. Currently, an Upload can accept at most 8 GB in total and expires after an hour after you create it.  Once you complete the Upload, we will create a [File](/docs/api-reference/files/object) object that contains all the parts you uploaded. This File is usable in the rest of our platform as a regular File object.  For certain `purpose` values, the correct `mime_type` must be specified.  Please refer to documentation for the  [supported MIME types for your use case](/docs/assistants/tools/file-search#supported-files).  For guidance on the proper filename extensions for each purpose, please follow the documentation on [creating a File](/docs/api-reference/files/create).  Returns the Upload object with status `pending`. |

## `usage`

| Command | Route | Description |
|---------|-------|-------------|
| `audio-speeches` | `GET /organization/usage/audio_speeches` | Get audio speeches usage details for the organization. |
| `audio-transcriptions` | `GET /organization/usage/audio_transcriptions` | Get audio transcriptions usage details for the organization. |
| `code-interpreter-sessions` | `GET /organization/usage/code_interpreter_sessions` | Get code interpreter sessions usage details for the organization. |
| `completions` | `GET /organization/usage/completions` | Get completions usage details for the organization. |
| `costs` | `GET /organization/costs` | Get costs details for the organization. |
| `embeddings` | `GET /organization/usage/embeddings` | Get embeddings usage details for the organization. |
| `images` | `GET /organization/usage/images` | Get images usage details for the organization. |
| `moderations` | `GET /organization/usage/moderations` | Get moderations usage details for the organization. |
| `vector-stores` | `GET /organization/usage/vector_stores` | Get vector stores usage details for the organization. |

## `user`

| Command | Route | Description |
|---------|-------|-------------|
| `delete-user` | `DELETE /organization/users/{user_id}` | Deletes a user from the organization. |
| `list-users` | `GET /organization/users` | Lists all of the users in the organization. |
| `modify-user` | `POST /organization/users/{user_id}` | Modifies a user's role in the organization. |
| `retrieve-user` | `GET /organization/users/{user_id}` | Retrieves a user by their identifier. |

## `user-organization-role-assignment`

| Command | Route | Description |
|---------|-------|-------------|
| `assign-organization-role-to-user` | `POST /organization/users/{user_id}/roles` | Assigns an organization role to a user within the organization. |
| `list-user-organization-role-assignments` | `GET /organization/users/{user_id}/roles` | Lists the organization roles assigned to a user within the organization. |
| `unassign-organization-role-from-user` | `DELETE /organization/users/{user_id}/roles/{role_id}` | Unassigns an organization role from a user within the organization. |

## `vector-store`

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-vector-store-file-batch` | `POST /vector_stores/{vector_store_id}/file_batches/{batch_id}/cancel` | Cancel a vector store file batch. This attempts to cancel the processing of files in this batch as soon as possible. |
| `create-vector-store` | `POST /vector_stores` | Create a vector store. |
| `create-vector-store-file` | `POST /vector_stores/{vector_store_id}/files` | Create a vector store file by attaching a [File](/docs/api-reference/files) to a [vector store](/docs/api-reference/vector-stores/object). |
| `create-vector-store-file-batch` | `POST /vector_stores/{vector_store_id}/file_batches` | Create a vector store file batch. |
| `delete-vector-store` | `DELETE /vector_stores/{vector_store_id}` | Delete a vector store. |
| `delete-vector-store-file` | `DELETE /vector_stores/{vector_store_id}/files/{file_id}` | Delete a vector store file. This will remove the file from the vector store but the file itself will not be deleted. To delete the file, use the [delete file](/docs/api-reference/files/delete) endpoint. |
| `list-vector-store-files` | `GET /vector_stores/{vector_store_id}/files` | Returns a list of vector store files. |
| `list-vector-store-files-in-abatch` | `GET /vector_stores/{vector_store_id}/file_batches/{batch_id}/files` | Returns a list of vector store files in a batch. |
| `list-vector-stores` | `GET /vector_stores` | Returns a list of vector stores. |
| `modify-vector-store` | `POST /vector_stores/{vector_store_id}` | Modifies a vector store. |
| `retrieve-vector-store` | `GET /vector_stores/{vector_store_id}` | Retrieves a vector store. |
| `retrieve-vector-store-file` | `GET /vector_stores/{vector_store_id}/files/{file_id}` | Retrieves a vector store file. |
| `retrieve-vector-store-file-batch` | `GET /vector_stores/{vector_store_id}/file_batches/{batch_id}` | Retrieves a vector store file batch. |
| `retrieve-vector-store-file-content` | `GET /vector_stores/{vector_store_id}/files/{file_id}/content` | Retrieve the parsed contents of a vector store file. |
| `search-vector-store` | `POST /vector_stores/{vector_store_id}/search` | Search a vector store for relevant chunks based on a query and file attributes filter. |
| `update-vector-store-file-attributes` | `POST /vector_stores/{vector_store_id}/files/{file_id}` | Update attributes on a vector store file. |

## `video`

| Command | Route | Description |
|---------|-------|-------------|
| `create-video` | `POST /videos` | Create a new video generation job from a prompt and optional reference assets. |
| `create-video-character` | `POST /videos/characters` | Create a character from an uploaded video. |
| `create-video-edit` | `POST /videos/edits` | Create a new video generation job by editing a source video or existing generated video. |
| `create-video-extend` | `POST /videos/extensions` | Create an extension of a completed video. |
| `delete-video` | `DELETE /videos/{video_id}` | Permanently delete a completed or failed video and its stored assets. |
| `get-video-character` | `GET /videos/characters/{character_id}` | Fetch a character. |
| `list-videos` | `GET /videos` | List recently generated videos for the current project. |
| `remix-video` | `POST /videos/{video_id}/remix` | Create a remix of a completed video using a refreshed prompt. |
| `retrieve-video` | `GET /videos/{video_id}` | Fetch the latest metadata for a generated video. |
| `retrieve-video-content` | `GET /videos/{video_id}/content` | Download the generated video bytes or a derived preview asset.  Streams the rendered video content for the specified video job. |

## `default`

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-chat-session` | `POST /chatkit/sessions/{session_id}/cancel` | Cancel an active ChatKit session and return its most recent metadata.  Cancelling prevents new requests from using the issued client secret. |
| `compact-aresponse` | `POST /responses/compact` | Compact a conversation. Returns a compacted response object.  Learn when and how to compact long-running conversations in the [conversation state guide](/docs/guides/conversation-state#managing-the-context-window). For ZDR-compatible compaction details, see [Compaction (advanced)](/docs/guides/conversation-state#compaction-advanced). |
| `create-admin-api-key` | `POST /organization/admin_api_keys` | Create an organization admin API key |
| `create-chat-kit-session` | `POST /chatkit/sessions` | Create a ChatKit session. |
| `create-container` | `POST /containers` | Create Container |
| `create-container-file` | `POST /containers/{container_id}/files` | Create a Container File  You can send either a multipart/form-data request with the raw file content, or a JSON request with a file ID. |
| `delete-acontainer` | `DELETE /containers/{container_id}` | Delete Container |
| `delete-acontainer-file` | `DELETE /containers/{container_id}/files/{file_id}` | Delete Container File |
| `delete-admin-api-key` | `DELETE /organization/admin_api_keys/{key_id}` | Delete an organization admin API key |
| `delete-chat-kit-thread` | `DELETE /chatkit/threads/{thread_id}` | Delete a ChatKit thread along with its items and stored attachments. |
| `get-input-token-counts` | `POST /responses/input_tokens` | Returns input token counts of the request.  Returns an object with `object` set to `response.input_tokens` and an `input_tokens` count. |
| `list-all-organization-and-project-api-keys` | `GET /organization/admin_api_keys` | List organization API keys |
| `list-chat-kit-thread-items` | `GET /chatkit/threads/{thread_id}/items` | List items that belong to a ChatKit thread. |
| `list-chat-kit-threads` | `GET /chatkit/threads` | List ChatKit threads with optional pagination and user filters. |
| `list-container-files` | `GET /containers/{container_id}/files` | List Container files |
| `list-containers` | `GET /containers` | List Containers |
| `retrieve-admin-api-key` | `GET /organization/admin_api_keys/{key_id}` | Retrieve a single organization API key |
| `retrieve-chat-kit-thread` | `GET /chatkit/threads/{thread_id}` | Retrieve a ChatKit thread by its identifier. |
| `retrieve-container` | `GET /containers/{container_id}` | Retrieve Container |
| `retrieve-container-file` | `GET /containers/{container_id}/files/{file_id}` | Retrieve Container File |
| `retrieve-container-file-content` | `GET /containers/{container_id}/files/{file_id}/content` | Retrieve Container File Content |

## Usage tips

Every group and command supports `--help`:

```bash
dnx tryAGI.OpenAI.CLI <group> --help
dnx tryAGI.OpenAI.CLI <group> <command> --help
```

Pass `--json` to get raw SDK responses (useful for piping into `jq`). Pass `-o <path>` to write the output to a file instead of stdout.
