# OpenAI API — commands reference

Full per-command reference derived from the OpenAPI spec. For the short overview + credentials flow see [SKILL.md](./SKILL.md).

## `agent`

| Command | Route | Description |
|---------|-------|-------------|
| `create-agent` | `POST /agents` | Create an agent |
| `create-agent-environment-file` | `POST /agents/environments/{environment_id}/files` | Create an agent environment file |
| `create-agent-environment-template` | `POST /agents/environments/templates` | Create an agent environment template |
| `create-agent-session` | `POST /agents/sessions` | Create an agent session |
| `create-agent-session-events` | `POST /agents/sessions/{session_id}/events` | Create agent session input events |
| `delete-agent` | `DELETE /agents/{agent_id}` | Delete an agent |
| `delete-agent-environment-template` | `DELETE /agents/environments/templates/{environment_template_id}` | Delete an agent environment template |
| `delete-agent-session` | `DELETE /agents/sessions/{session_id}` | Delete an agent session |
| `delete-agent-session-artifact` | `DELETE /agents/sessions/{session_id}/artifacts/{artifact_id}` | Delete an agent session artifact |
| `list-agent-environment-files` | `GET /agents/environments/{environment_id}/files` | List agent environment files |
| `list-agent-environment-templates` | `GET /agents/environments/templates` | List agent environment templates |
| `list-agent-session-artifacts` | `GET /agents/sessions/{session_id}/artifacts` | List agent session artifacts |
| `list-agent-session-events` | `GET /agents/sessions/{session_id}/events` | Stream agent session events |
| `list-agent-session-items` | `GET /agents/sessions/{session_id}/items` | List agent session items |
| `list-agent-session-subagent-items` | `GET /agents/sessions/{session_id}/subagents/{subagent_id}/items` | List subagent items |
| `list-agent-session-subagent-turn-items` | `GET /agents/sessions/{session_id}/subagents/{subagent_id}/turns/{turn_id}/items` | List subagent turn items |
| `list-agent-session-subagent-turns` | `GET /agents/sessions/{session_id}/subagents/{subagent_id}/turns` | List subagent turns |
| `list-agent-session-subagents` | `GET /agents/sessions/{session_id}/subagents` | List session subagents |
| `list-agent-session-turns` | `GET /agents/sessions/{session_id}/turns` | List agent session turns |
| `list-agent-sessions` | `GET /agents/sessions` | List agent sessions |
| `list-agents` | `GET /agents` | List agents |
| `retrieve-agent` | `GET /agents/{agent_id}` | Retrieve an agent |
| `retrieve-agent-environment` | `GET /agents/environments/{environment_id}` | Retrieve an agent environment |
| `retrieve-agent-environment-template` | `GET /agents/environments/templates/{environment_template_id}` | Retrieve an agent environment template |
| `retrieve-agent-session` | `GET /agents/sessions/{session_id}` | Retrieve an agent session |
| `retrieve-agent-session-artifact` | `GET /agents/sessions/{session_id}/artifacts/{artifact_id}` | Retrieve an agent session artifact |
| `retrieve-agent-session-artifact-content` | `GET /agents/sessions/{session_id}/artifacts/{artifact_id}/content` | Retrieve agent session artifact content |
| `retrieve-agent-session-subagent` | `GET /agents/sessions/{session_id}/subagents/{subagent_id}` | Retrieve a session subagent |
| `retrieve-agent-session-subagent-turn` | `GET /agents/sessions/{session_id}/subagents/{subagent_id}/turns/{turn_id}` | Retrieve a subagent turn |
| `retrieve-agent-session-turn` | `GET /agents/sessions/{session_id}/turns/{turn_id}` | Retrieve an agent session turn |
| `update-agent` | `POST /agents/{agent_id}` | Update an agent |
| `update-agent-environment-template` | `POST /agents/environments/templates/{environment_template_id}` | Update an agent environment template |
| `update-agent-session` | `POST /agents/sessions/{session_id}` | Update an agent session |

## `assistant`

Build Assistants that can call models and use tools.

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-run` | `POST /threads/{thread_id}/runs/{run_id}/cancel` | Cancel a run |
| `create-message` | `POST /threads/{thread_id}/messages` | Create message |
| `create-run` | `POST /threads/{thread_id}/runs` | Create run |
| `create-thread` | `POST /threads` | Create thread |
| `create-thread-and-run` | `POST /threads/runs` | Create thread and run |
| `delete-message` | `DELETE /threads/{thread_id}/messages/{message_id}` | Delete message |
| `delete-thread` | `DELETE /threads/{thread_id}` | Delete thread |
| `get-message` | `GET /threads/{thread_id}/messages/{message_id}` | Retrieve message |
| `get-run` | `GET /threads/{thread_id}/runs/{run_id}` | Retrieve run |
| `get-run-step` | `GET /threads/{thread_id}/runs/{run_id}/steps/{step_id}` | Retrieve run step |
| `get-thread` | `GET /threads/{thread_id}` | Retrieve thread |
| `list-messages` | `GET /threads/{thread_id}/messages` | List messages |
| `list-run-steps` | `GET /threads/{thread_id}/runs/{run_id}/steps` | List run steps |
| `list-runs` | `GET /threads/{thread_id}/runs` | List runs |
| `modify-message` | `POST /threads/{thread_id}/messages/{message_id}` | Modify message |
| `modify-run` | `POST /threads/{thread_id}/runs/{run_id}` | Modify run |
| `modify-thread` | `POST /threads/{thread_id}` | Modify thread |
| `submit-tool-ouputs-to-run` | `POST /threads/{thread_id}/runs/{run_id}/submit_tool_outputs` | Submit tool outputs to run |

## `audio`

Turn audio into text or text into audio.

| Command | Route | Description |
|---------|-------|-------------|
| `create-speech` | `POST /audio/speech` | Create speech |
| `create-transcription` | `POST /audio/transcriptions` | Create transcription |
| `create-translation` | `POST /audio/translations` | Create translation |
| `create-voice` | `POST /audio/voices` | Create voice |
| `create-voice-consent` | `POST /audio/voice_consents` | Create voice consent |
| `delete-voice-consent` | `DELETE /audio/voice_consents/{consent_id}` | Delete voice consent |
| `get-voice-consent` | `GET /audio/voice_consents/{consent_id}` | Retrieve voice consent |
| `list-voice-consents` | `GET /audio/voice_consents` | List voice consents |
| `update-voice-consent` | `POST /audio/voice_consents/{consent_id}` | Update voice consent |

## `audit-log`

List user actions and configuration changes within this organization.

| Command | Route | Description |
|---------|-------|-------------|
| `list-audit-logs` | `GET /organization/audit_logs` | List audit logs |

## `batch`

Create large batches of API requests to run asynchronously.

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-batch` | `POST /batches/{batch_id}/cancel` | Cancel batch |
| `create-batch` | `POST /batches` | Create batch |
| `list-batches` | `GET /batches` | List batches |
| `retrieve-batch` | `GET /batches/{batch_id}` | Retrieve batch |

## `certificate`

| Command | Route | Description |
|---------|-------|-------------|
| `activate-organization-certificates` | `POST /organization/certificates/activate` | Activate certificates for organization |
| `activate-project-certificates` | `POST /organization/projects/{project_id}/certificates/activate` | Activate certificates for project |
| `deactivate-organization-certificates` | `POST /organization/certificates/deactivate` | Deactivate certificates for organization |
| `deactivate-project-certificates` | `POST /organization/projects/{project_id}/certificates/deactivate` | Deactivate certificates for project |
| `delete-certificate` | `DELETE /organization/certificates/{certificate_id}` | Delete certificate |
| `get-certificate` | `GET /organization/certificates/{certificate_id}` | Get certificate |
| `list-organization-certificates` | `GET /organization/certificates` | List organization certificates |
| `list-project-certificates` | `GET /organization/projects/{project_id}/certificates` | List project certificates |
| `modify-certificate` | `POST /organization/certificates/{certificate_id}` | Modify certificate |
| `upload-certificate` | `POST /organization/certificates` | Upload certificate |

## `chat`

Given a list of messages comprising a conversation, the model will return a response.

| Command | Route | Description |
|---------|-------|-------------|
| `create-chat-completion` | `POST /chat/completions` | Create chat completion |
| `delete-chat-completion` | `DELETE /chat/completions/{completion_id}` | Delete chat completion |
| `get-chat-completion` | `GET /chat/completions/{completion_id}` | Get chat completion |
| `get-chat-completion-messages` | `GET /chat/completions/{completion_id}/messages` | Get chat messages |
| `list-chat-completions` | `GET /chat/completions` | List Chat Completions |
| `update-chat-completion` | `POST /chat/completions/{completion_id}` | Update chat completion |

## `completion`

Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of alternative tokens at each position.

| Command | Route | Description |
|---------|-------|-------------|
| `create-completion` | `POST /completions` | Create completion |

## `conversation`

Manage conversations and conversation items.

| Command | Route | Description |
|---------|-------|-------------|
| `create-conversation` | `POST /conversations` | Create a conversation |
| `create-conversation-items` | `POST /conversations/{conversation_id}/items` | Create items |
| `delete-conversation` | `DELETE /conversations/{conversation_id}` | Delete a conversation |
| `delete-conversation-item` | `DELETE /conversations/{conversation_id}/items/{item_id}` | Delete an item |
| `get-conversation` | `GET /conversations/{conversation_id}` | Retrieve a conversation |
| `get-conversation-item` | `GET /conversations/{conversation_id}/items/{item_id}` | Retrieve an item |
| `list-conversation-items` | `GET /conversations/{conversation_id}/items` | List items |
| `update-conversation` | `POST /conversations/{conversation_id}` | Update a conversation |

## `data-retention`

| Command | Route | Description |
|---------|-------|-------------|
| `retrieve-organization-data-retention` | `GET /organization/data_retention` | Retrieve organization data retention |
| `retrieve-project-data-retention` | `GET /organization/projects/{project_id}/data_retention` | Retrieve project data retention |
| `update-organization-data-retention` | `POST /organization/data_retention` | Update organization data retention |
| `update-project-data-retention` | `POST /organization/projects/{project_id}/data_retention` | Update project data retention |

## `embedding`

Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.

| Command | Route | Description |
|---------|-------|-------------|
| `create-embedding` | `POST /embeddings` | Create embeddings |

## `eval`

Manage and run evals in the OpenAI platform.

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-eval-run` | `POST /evals/{eval_id}/runs/{run_id}` | Cancel eval run |
| `create-eval` | `POST /evals` | Create eval |
| `create-eval-run` | `POST /evals/{eval_id}/runs` | Create eval run |
| `delete-eval` | `DELETE /evals/{eval_id}` | Delete an eval |
| `delete-eval-run` | `DELETE /evals/{eval_id}/runs/{run_id}` | Delete eval run |
| `get-eval` | `GET /evals/{eval_id}` | Get an eval |
| `get-eval-run` | `GET /evals/{eval_id}/runs/{run_id}` | Get an eval run |
| `get-eval-run-output-item` | `GET /evals/{eval_id}/runs/{run_id}/output_items/{output_item_id}` | Get an output item of an eval run |
| `get-eval-run-output-items` | `GET /evals/{eval_id}/runs/{run_id}/output_items` | Get eval run output items |
| `get-eval-runs` | `GET /evals/{eval_id}/runs` | Get eval runs |
| `list-evals` | `GET /evals` | List evals |
| `update-eval` | `POST /evals/{eval_id}` | Update an eval |

## `file`

Files are used to upload documents that can be used with features like Assistants and Fine-tuning.

| Command | Route | Description |
|---------|-------|-------------|
| `create-file` | `POST /files` | Upload file |
| `delete-file` | `DELETE /files/{file_id}` | Delete file |
| `download-file` | `GET /files/{file_id}/content` | Retrieve file content |
| `list-files` | `GET /files` | List files |
| `retrieve-file` | `GET /files/{file_id}` | Retrieve file |

## `fine-tuning`

Manage fine-tuning jobs to tailor a model to your specific training data.

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-fine-tuning-job` | `POST /fine_tuning/jobs/{fine_tuning_job_id}/cancel` | Cancel fine-tuning |
| `create-fine-tuning-checkpoint-permission` | `POST /fine_tuning/checkpoints/{fine_tuned_model_checkpoint}/permissions` | Create checkpoint permissions |
| `create-fine-tuning-job` | `POST /fine_tuning/jobs` | Create fine-tuning job |
| `delete-fine-tuning-checkpoint-permission` | `DELETE /fine_tuning/checkpoints/{fine_tuned_model_checkpoint}/permissions/{permission_id}` | Delete checkpoint permission |
| `list-fine-tuning-checkpoint-permissions` | `GET /fine_tuning/checkpoints/{fine_tuned_model_checkpoint}/permissions` | List checkpoint permissions |
| `list-fine-tuning-events` | `GET /fine_tuning/jobs/{fine_tuning_job_id}/events` | List fine-tuning events |
| `list-fine-tuning-job-checkpoints` | `GET /fine_tuning/jobs/{fine_tuning_job_id}/checkpoints` | List fine-tuning checkpoints |
| `list-paginated-fine-tuning-jobs` | `GET /fine_tuning/jobs` | List fine-tuning jobs |
| `pause-fine-tuning-job` | `POST /fine_tuning/jobs/{fine_tuning_job_id}/pause` | Pause fine-tuning |
| `resume-fine-tuning-job` | `POST /fine_tuning/jobs/{fine_tuning_job_id}/resume` | Resume fine-tuning |
| `retrieve-fine-tuning-job` | `GET /fine_tuning/jobs/{fine_tuning_job_id}` | Retrieve fine-tuning job |
| `run-grader` | `POST /fine_tuning/alpha/graders/run` | Run grader |
| `validate-grader` | `POST /fine_tuning/alpha/graders/validate` | Validate grader |

## `group`

| Command | Route | Description |
|---------|-------|-------------|
| `create-group` | `POST /organization/groups` | Create group |
| `delete-group` | `DELETE /organization/groups/{group_id}` | Delete group |
| `list-groups` | `GET /organization/groups` | List groups |
| `retrieve-group` | `GET /organization/groups/{group_id}` | Retrieve group |
| `update-group` | `POST /organization/groups/{group_id}` | Update group |

## `group-organization-role-assignment`

| Command | Route | Description |
|---------|-------|-------------|
| `assign-group-role` | `POST /organization/groups/{group_id}/roles` | Assign organization role to group |
| `list-group-role-assignments` | `GET /organization/groups/{group_id}/roles` | List group organization role assignments |
| `retrieve-group-role` | `GET /organization/groups/{group_id}/roles/{role_id}` | Retrieve group organization role |
| `unassign-group-role` | `DELETE /organization/groups/{group_id}/roles/{role_id}` | Unassign organization role from group |

## `group-user`

| Command | Route | Description |
|---------|-------|-------------|
| `add-group-user` | `POST /organization/groups/{group_id}/users` | Add group user |
| `list-group-users` | `GET /organization/groups/{group_id}/users` | List group users |
| `remove-group-user` | `DELETE /organization/groups/{group_id}/users/{user_id}` | Remove group user |
| `retrieve-group-user` | `GET /organization/groups/{group_id}/users/{user_id}` | Retrieve group user |

## `hosted-tool`

| Command | Route | Description |
|---------|-------|-------------|
| `retrieve-project-hosted-tool-permissions` | `GET /organization/projects/{project_id}/hosted_tool_permissions` | Retrieve project hosted tool permissions |
| `update-project-hosted-tool-permissions` | `POST /organization/projects/{project_id}/hosted_tool_permissions` | Modify project hosted tool permissions |

## `image`

Given a prompt and/or an input image, the model will generate a new image.

| Command | Route | Description |
|---------|-------|-------------|
| `create-image` | `POST /images/generations` | Create image |
| `create-image-edit` | `POST /images/edits` | Create image edit |
| `create-image-variation` | `POST /images/variations` | Create image variation |

## `invite`

| Command | Route | Description |
|---------|-------|-------------|
| `delete-invite` | `DELETE /organization/invites/{invite_id}` | Delete invite |
| `invite-user` | `POST /organization/invites` | Create invite |
| `list-invites` | `GET /organization/invites` | List invites |
| `retrieve-invite` | `GET /organization/invites/{invite_id}` | Retrieve invite |

## `live`

| Command | Route | Description |
|---------|-------|-------------|
| `accept-live-session` | `POST /live/sessions/{session_id}/accept` | Accept call |
| `create-live` | `POST /live/sessions` | Create session |
| `download-live-recording` | `GET /live/sessions/{session_id}/content` | Download recording |
| `fork-live-session` | `POST /live/sessions/{session_id}/fork` | Fork session |
| `hangup-live-session` | `POST /live/sessions/{session_id}/hangup` | Hang up session |
| `refer-live-session` | `POST /live/sessions/{session_id}/refer` | Transfer call |
| `reject-live-session` | `POST /live/sessions/{session_id}/reject` | Reject call |

## `model`

List and describe the various models available in the API.

| Command | Route | Description |
|---------|-------|-------------|
| `delete-model` | `DELETE /models/{model}` | Delete a fine-tuned model |
| `list-models` | `GET /models` | List models |
| `retrieve-model` | `GET /models/{model}` | Retrieve model |

## `moderation`

Given text and/or image inputs, classifies if those inputs are potentially harmful.

| Command | Route | Description |
|---------|-------|-------------|
| `create-moderation` | `POST /moderations` | Create moderation |

## `project`

| Command | Route | Description |
|---------|-------|-------------|
| `archive-project` | `POST /organization/projects/{project_id}/archive` | Archive project |
| `create-project` | `POST /organization/projects` | Create project |
| `create-project-service-account` | `POST /organization/projects/{project_id}/service_accounts` | Create project service account |
| `create-project-user` | `POST /organization/projects/{project_id}/users` | Create project user |
| `delete-project-api-key` | `DELETE /organization/projects/{project_id}/api_keys/{api_key_id}` | Delete project API key |
| `delete-project-model-permissions` | `DELETE /organization/projects/{project_id}/model_permissions` | Delete project model permissions |
| `delete-project-service-account` | `DELETE /organization/projects/{project_id}/service_accounts/{service_account_id}` | Delete project service account |
| `delete-project-user` | `DELETE /organization/projects/{project_id}/users/{user_id}` | Delete project user |
| `list-project-api-keys` | `GET /organization/projects/{project_id}/api_keys` | List project API keys |
| `list-project-rate-limits` | `GET /organization/projects/{project_id}/rate_limits` | List project rate limits |
| `list-project-service-accounts` | `GET /organization/projects/{project_id}/service_accounts` | List project service accounts |
| `list-project-users` | `GET /organization/projects/{project_id}/users` | List project users |
| `list-projects` | `GET /organization/projects` | List projects |
| `modify-project` | `POST /organization/projects/{project_id}` | Modify project |
| `modify-project-user` | `POST /organization/projects/{project_id}/users/{user_id}` | Modify project user |
| `retrieve-project` | `GET /organization/projects/{project_id}` | Retrieve project |
| `retrieve-project-api-key` | `GET /organization/projects/{project_id}/api_keys/{api_key_id}` | Retrieve project API key |
| `retrieve-project-model-permissions` | `GET /organization/projects/{project_id}/model_permissions` | Retrieve project model permissions |
| `retrieve-project-service-account` | `GET /organization/projects/{project_id}/service_accounts/{service_account_id}` | Retrieve project service account |
| `retrieve-project-user` | `GET /organization/projects/{project_id}/users/{user_id}` | Retrieve project user |
| `update-project-model-permissions` | `POST /organization/projects/{project_id}/model_permissions` | Modify project model permissions |
| `update-project-rate-limits` | `POST /organization/projects/{project_id}/rate_limits/{rate_limit_id}` | Modify project rate limit |
| `update-project-service-account` | `POST /organization/projects/{project_id}/service_accounts/{service_account_id}` | Update project service account |

## `project-group`

| Command | Route | Description |
|---------|-------|-------------|
| `add-project-group` | `POST /organization/projects/{project_id}/groups` | Add project group |
| `list-project-groups` | `GET /organization/projects/{project_id}/groups` | List project groups |
| `remove-project-group` | `DELETE /organization/projects/{project_id}/groups/{group_id}` | Remove project group |
| `retrieve-project-group` | `GET /organization/projects/{project_id}/groups/{group_id}` | Retrieve project group |

## `project-group-role-assignment`

| Command | Route | Description |
|---------|-------|-------------|
| `assign-project-group-role` | `POST /projects/{project_id}/groups/{group_id}/roles` | Assign project role to group |
| `list-project-group-role-assignments` | `GET /projects/{project_id}/groups/{group_id}/roles` | List project group role assignments |
| `retrieve-project-group-role` | `GET /projects/{project_id}/groups/{group_id}/roles/{role_id}` | Retrieve project group role |
| `unassign-project-group-role` | `DELETE /projects/{project_id}/groups/{group_id}/roles/{role_id}` | Unassign project role from group |

## `project-user-role-assignment`

| Command | Route | Description |
|---------|-------|-------------|
| `assign-project-user-role` | `POST /projects/{project_id}/users/{user_id}/roles` | Assign project role to user |
| `list-project-user-role-assignments` | `GET /projects/{project_id}/users/{user_id}/roles` | List project user role assignments |
| `retrieve-project-user-role` | `GET /projects/{project_id}/users/{user_id}/roles/{role_id}` | Retrieve project user role |
| `unassign-project-user-role` | `DELETE /projects/{project_id}/users/{user_id}/roles/{role_id}` | Unassign project role from user |

## `realtime`

| Command | Route | Description |
|---------|-------|-------------|
| `accept-realtime-call` | `POST /realtime/calls/{call_id}/accept` | Accept call |
| `create-realtime-call` | `POST /realtime/calls` | Create call |
| `create-realtime-client-secret` | `POST /realtime/client_secrets` | Create client secret |
| `create-realtime-session` | `POST /realtime/sessions` | Create session |
| `create-realtime-transcription-session` | `POST /realtime/transcription_sessions` | Create transcription session |
| `create-realtime-translation-client-secret` | `POST /realtime/translations/client_secrets` | Create translation client secret |
| `hangup-realtime-call` | `POST /realtime/calls/{call_id}/hangup` | Hang up call |
| `refer-realtime-call` | `POST /realtime/calls/{call_id}/refer` | Refer call |
| `reject-realtime-call` | `POST /realtime/calls/{call_id}/reject` | Reject call |

## `response`

Create and manage model responses.

| Command | Route | Description |
|---------|-------|-------------|
| `beta-cancel-response` | `POST /responses/{response_id}/cancel?beta=true` | Cancel a response |
| `beta-compactconversation` | `POST /responses/compact?beta=true` | Compact conversation |
| `beta-create-response` | `POST /responses?beta=true` | Create a model response |
| `beta-delete-response` | `DELETE /responses/{response_id}?beta=true` | Delete a model response |
| `beta-get-response` | `GET /responses/{response_id}?beta=true` | Get a model response |
| `beta-getinputtokencounts` | `POST /responses/input_tokens?beta=true` | Get input token counts |
| `beta-list-input-items` | `GET /responses/{response_id}/input_items?beta=true` | List input items |
| `cancel-response` | `POST /responses/{response_id}/cancel` | Cancel a response |
| `compactconversation` | `POST /responses/compact` | Compact conversation |
| `create-response` | `POST /responses` | Create a model response |
| `delete-response` | `DELETE /responses/{response_id}` | Delete a model response |
| `get-response` | `GET /responses/{response_id}` | Get a model response |
| `getinputtokencounts` | `POST /responses/input_tokens` | Get input token counts |
| `list-input-items` | `GET /responses/{response_id}/input_items` | List input items |

## `role`

| Command | Route | Description |
|---------|-------|-------------|
| `create-project-role` | `POST /projects/{project_id}/roles` | Create project role |
| `create-role` | `POST /organization/roles` | Create organization role |
| `delete-project-role` | `DELETE /projects/{project_id}/roles/{role_id}` | Delete project role |
| `delete-role` | `DELETE /organization/roles/{role_id}` | Delete organization role |
| `list-project-roles` | `GET /projects/{project_id}/roles` | List project roles |
| `list-roles` | `GET /organization/roles` | List organization roles |
| `retrieve-project-role` | `GET /projects/{project_id}/roles/{role_id}` | Retrieve project role |
| `retrieve-role` | `GET /organization/roles/{role_id}` | Retrieve organization role |
| `update-project-role` | `POST /projects/{project_id}/roles/{role_id}` | Update project role |
| `update-role` | `POST /organization/roles/{role_id}` | Update organization role |

## `skill`

| Command | Route | Description |
|---------|-------|-------------|
| `create-skill` | `POST /skills` | Create Skill |
| `create-skill-version` | `POST /skills/{skill_id}/versions` | Create Skill Version |
| `delete-skill` | `DELETE /skills/{skill_id}` | Delete Skill |
| `delete-skill-version` | `DELETE /skills/{skill_id}/versions/{version}` | Delete Skill Version |
| `get-skill` | `GET /skills/{skill_id}` | Get Skill |
| `get-skill-content` | `GET /skills/{skill_id}/content` | Get Skill Content |
| `get-skill-version` | `GET /skills/{skill_id}/versions/{version}` | Get Skill Version |
| `get-skill-version-content` | `GET /skills/{skill_id}/versions/{version}/content` | Get Skill Version Content |
| `list-skill-versions` | `GET /skills/{skill_id}/versions` | List Skill Versions |
| `list-skills` | `GET /skills` | List Skills |
| `update-skill-default-version` | `POST /skills/{skill_id}` | Update Skill Default Version |

## `spend-alert`

| Command | Route | Description |
|---------|-------|-------------|
| `create-organization-spend-alert` | `POST /organization/spend_alerts` | Create organization spend alert |
| `create-project-spend-alert` | `POST /organization/projects/{project_id}/spend_alerts` | Create project spend alert |
| `delete-organization-spend-alert` | `DELETE /organization/spend_alerts/{alert_id}` | Delete organization spend alert |
| `delete-project-spend-alert` | `DELETE /organization/projects/{project_id}/spend_alerts/{alert_id}` | Delete project spend alert |
| `list-organization-spend-alerts` | `GET /organization/spend_alerts` | List organization spend alerts |
| `list-project-spend-alerts` | `GET /organization/projects/{project_id}/spend_alerts` | List project spend alerts |
| `retrieve-organization-spend-alert` | `GET /organization/spend_alerts/{alert_id}` | Retrieve organization spend alert |
| `retrieve-project-spend-alert` | `GET /organization/projects/{project_id}/spend_alerts/{alert_id}` | Retrieve project spend alert |
| `update-organization-spend-alert` | `POST /organization/spend_alerts/{alert_id}` | Update organization spend alert |
| `update-project-spend-alert` | `POST /organization/projects/{project_id}/spend_alerts/{alert_id}` | Update project spend alert |

## `upload`

Use Uploads to upload large files in multiple parts.

| Command | Route | Description |
|---------|-------|-------------|
| `add-upload-part` | `POST /uploads/{upload_id}/parts` | Add upload part |
| `cancel-upload` | `POST /uploads/{upload_id}/cancel` | Cancel upload |
| `complete-upload` | `POST /uploads/{upload_id}/complete` | Complete upload |
| `create-upload` | `POST /uploads` | Create upload |

## `usage`

| Command | Route | Description |
|---------|-------|-------------|
| `usage-audio-speeches` | `GET /organization/usage/audio_speeches` | Audio speeches |
| `usage-audio-transcriptions` | `GET /organization/usage/audio_transcriptions` | Audio transcriptions |
| `usage-code-interpreter-sessions` | `GET /organization/usage/code_interpreter_sessions` | Code interpreter sessions |
| `usage-completions` | `GET /organization/usage/completions` | Completions |
| `usage-costs` | `GET /organization/costs` | Costs |
| `usage-embeddings` | `GET /organization/usage/embeddings` | Embeddings |
| `usage-file-search-calls` | `GET /organization/usage/file_search_calls` | File search calls |
| `usage-images` | `GET /organization/usage/images` | Images |
| `usage-moderations` | `GET /organization/usage/moderations` | Moderations |
| `usage-vector-stores` | `GET /organization/usage/vector_stores` | Vector stores |
| `usage-web-search-calls` | `GET /organization/usage/web_search_calls` | Web search calls |

## `user`

| Command | Route | Description |
|---------|-------|-------------|
| `delete-user` | `DELETE /organization/users/{user_id}` | Delete user |
| `list-users` | `GET /organization/users` | List users |
| `modify-user` | `POST /organization/users/{user_id}` | Modify user |
| `retrieve-user` | `GET /organization/users/{user_id}` | Retrieve user |

## `user-organization-role-assignment`

| Command | Route | Description |
|---------|-------|-------------|
| `assign-user-role` | `POST /organization/users/{user_id}/roles` | Assign organization role to user |
| `list-user-role-assignments` | `GET /organization/users/{user_id}/roles` | List user organization role assignments |
| `retrieve-user-role` | `GET /organization/users/{user_id}/roles/{role_id}` | Retrieve user organization role |
| `unassign-user-role` | `DELETE /organization/users/{user_id}/roles/{role_id}` | Unassign organization role from user |

## `vault`

| Command | Route | Description |
|---------|-------|-------------|
| `create-vault` | `POST /vaults` | Create a vault |
| `create-vault-credential` | `POST /vaults/{vault_id}/credentials` | Create a vault credential |
| `delete-vault` | `DELETE /vaults/{vault_id}` | Delete a vault |
| `delete-vault-credential` | `DELETE /vaults/{vault_id}/credentials/{credential_id}` | Delete a vault credential |
| `list-vault-credentials` | `GET /vaults/{vault_id}/credentials` | List vault credentials |
| `list-vaults` | `GET /vaults` | List vaults |
| `retrieve-vault` | `GET /vaults/{vault_id}` | Retrieve a vault |
| `retrieve-vault-credential` | `GET /vaults/{vault_id}/credentials/{credential_id}` | Retrieve a vault credential |
| `rotate-vault-credential` | `POST /vaults/{vault_id}/credentials/{credential_id}` | Rotate a vault credential |

## `vector-store`

| Command | Route | Description |
|---------|-------|-------------|
| `cancel-vector-store-file-batch` | `POST /vector_stores/{vector_store_id}/file_batches/{batch_id}/cancel` | Cancel vector store file batch |
| `create-vector-store` | `POST /vector_stores` | Create vector store |
| `create-vector-store-file` | `POST /vector_stores/{vector_store_id}/files` | Create vector store file |
| `create-vector-store-file-batch` | `POST /vector_stores/{vector_store_id}/file_batches` | Create vector store file batch |
| `delete-vector-store` | `DELETE /vector_stores/{vector_store_id}` | Delete vector store |
| `delete-vector-store-file` | `DELETE /vector_stores/{vector_store_id}/files/{file_id}` | Delete vector store file |
| `get-vector-store` | `GET /vector_stores/{vector_store_id}` | Retrieve vector store |
| `get-vector-store-file` | `GET /vector_stores/{vector_store_id}/files/{file_id}` | Retrieve vector store file |
| `get-vector-store-file-batch` | `GET /vector_stores/{vector_store_id}/file_batches/{batch_id}` | Retrieve vector store file batch |
| `list-files-in-vector-store-batch` | `GET /vector_stores/{vector_store_id}/file_batches/{batch_id}/files` | List vector store files in a batch |
| `list-vector-store-files` | `GET /vector_stores/{vector_store_id}/files` | List vector store files |
| `list-vector-stores` | `GET /vector_stores` | List vector stores |
| `modify-vector-store` | `POST /vector_stores/{vector_store_id}` | Modify vector store |
| `retrieve-vector-store-file-content` | `GET /vector_stores/{vector_store_id}/files/{file_id}/content` | Retrieve vector store file content |
| `search-vector-store` | `POST /vector_stores/{vector_store_id}/search` | Search vector store |
| `update-vector-store-file-attributes` | `POST /vector_stores/{vector_store_id}/files/{file_id}` | Update vector store file attributes |

## `default`

| Command | Route | Description |
|---------|-------|-------------|
| `admin-api-keys-create` | `POST /organization/admin_api_keys` | Create admin API key |
| `admin-api-keys-delete` | `DELETE /organization/admin_api_keys/{key_id}` | Delete admin API key |
| `admin-api-keys-get` | `GET /organization/admin_api_keys/{key_id}` | Retrieve admin API key |
| `admin-api-keys-list` | `GET /organization/admin_api_keys` | List all organization and project API keys. |
| `cancel-chat-session-method` | `POST /chatkit/sessions/{session_id}/cancel` | Cancel a ChatKit session |
| `create-chat-session-method` | `POST /chatkit/sessions` | Create a ChatKit session |
| `create-container` | `POST /containers` | Create container |
| `create-container-file` | `POST /containers/{container_id}/files` | Create container file |
| `create-webhook-endpoint` | `POST /webhook_endpoints` | Create Webhook Endpoint |
| `createan-apikeyforaserviceaccount` | `POST /organization/projects/{project_id}/service_accounts/{service_account_id}/api_keys` | Create an API key for a service account |
| `createanexternalstorageconfiguration` | `POST /organization/external_storage` | Create an external storage configuration |
| `createcontentprovenancecheck` | `POST /content_provenance_checks` | Create content provenance check |
| `delete-container` | `DELETE /containers/{container_id}` | Delete a container |
| `delete-container-file` | `DELETE /containers/{container_id}/files/{file_id}` | Delete a container file |
| `delete-thread-method` | `DELETE /chatkit/threads/{thread_id}` | Delete a ChatKit thread |
| `delete-webhook-endpoint` | `DELETE /webhook_endpoints/{webhook_endpoint_id}` | Delete Webhook Endpoint |
| `deleteanexternalstorageconfiguration` | `DELETE /organization/external_storage/{external_storage_id}` | Delete an external storage configuration |
| `deleteorganizationspendlimit` | `DELETE /organization/spend_limit` | Delete organization spend limit |
| `deleteprojectspendlimit` | `DELETE /organization/projects/{project_id}/spend_limit` | Delete project spend limit |
| `get-thread-method` | `GET /chatkit/threads/{thread_id}` | Retrieve a ChatKit thread |
| `getanexternalstorageconfiguration` | `GET /organization/external_storage/{external_storage_id}` | Get an external storage configuration |
| `getorganizationspendlimit` | `GET /organization/spend_limit` | Get organization spend limit |
| `getprojectsafetyalert` | `GET /safety/alerts/{id}` | Get project safety alert |
| `getprojectspendlimit` | `GET /organization/projects/{project_id}/spend_limit` | Get project spend limit |
| `getsafetycase` | `GET /safety/cases/{id}` | Get safety case |
| `list-container-files` | `GET /containers/{container_id}/files` | List container files |
| `list-containers` | `GET /containers` | List containers |
| `list-thread-items-method` | `GET /chatkit/threads/{thread_id}/items` | List ChatKit thread items |
| `list-threads-method` | `GET /chatkit/threads` | List ChatKit threads |
| `list-webhook-endpoints` | `GET /webhook_endpoints` | List Webhook Endpoints |
| `list-webhook-event-types` | `GET /webhook_event_types` | List Webhook Event Types |
| `listexternalstorageconfigurations` | `GET /organization/external_storage` | List external storage configurations |
| `retrieve-container` | `GET /containers/{container_id}` | Retrieve container |
| `retrieve-container-file` | `GET /containers/{container_id}/files/{file_id}` | Retrieve container file |
| `retrieve-container-file-content` | `GET /containers/{container_id}/files/{file_id}/content` | Retrieve container file content |
| `retrieve-webhook-endpoint` | `GET /webhook_endpoints/{webhook_endpoint_id}` | Retrieve Webhook Endpoint |
| `rotate-webhook-endpoint-signing-secret` | `POST /webhook_endpoints/{webhook_endpoint_id}/rotate_secret` | Rotate Webhook Endpoint Signing Secret |
| `test-webhook-endpoint` | `POST /webhook_endpoints/{webhook_endpoint_id}/test` | Test Webhook Endpoint |
| `update-webhook-endpoint` | `POST /webhook_endpoints/{webhook_endpoint_id}` | Update Webhook Endpoint |
| `updateorganizationspendlimit` | `POST /organization/spend_limit` | Update organization spend limit |
| `updateprojectspendlimit` | `POST /organization/projects/{project_id}/spend_limit` | Update project spend limit |
| `validateanexternalstorageconfiguration` | `POST /organization/external_storage/{external_storage_id}/validate` | Validate an external storage configuration |

## Usage tips

Every group and command supports `--help`:

```bash
dnx tryAGI.OpenAI.CLI <group> --help
dnx tryAGI.OpenAI.CLI <group> <command> --help
```

Pass `--json` to get raw SDK responses (useful for piping into `jq`). Pass `-o <path>` to write the output to a file instead of stdout.
