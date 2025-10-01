// Generated from source/Nuke.Common/Tools/Fastlane/Fastlane.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.Fastlane;

/// <summary><p>For more details, visit the <a href="https://fastlane.tools/">official website</a>.</p></summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[PathTool(Executable = PathExecutable)]
public partial class FastlaneTasks : ToolTasks, IRequirePathTool
{
    public static string FastlanePath { get => new FastlaneTasks().GetToolPathInternal(); set => new FastlaneTasks().SetToolPath(value); }
    public const string PathExecutable = "fastlane";
    /// <summary><p>For more details, visit the <a href="https://fastlane.tools/">official website</a>.</p></summary>
    public static IReadOnlyCollection<Output> Fastlane(ArgumentStringHandler arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Action<OutputType, string> logger = null, Func<IProcess, object> exitHandler = null) => new FastlaneTasks().Run(arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, logger, exitHandler);
    /// <summary><p><c>deliver</c> uploads screenshots, metadata and binaries to App Store Connect. Use deliver to submit your app for App Store review.</p><p>For more details, visit the <a href="https://docs.fastlane.tools/actions/deliver/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--api_key</c> via <see cref="FastlaneDeliverSettings.AppStoreConnectApiKey"/></li><li><c>--api_key_path</c> via <see cref="FastlaneDeliverSettings.AppStoreConnectApiKeyPath"/></li><li><c>--app_identifier</c> via <see cref="FastlaneDeliverSettings.AppIdentifier"/></li><li><c>--app_version</c> via <see cref="FastlaneDeliverSettings.AppVersion"/></li><li><c>--beta_app_description</c> via <see cref="FastlaneDeliverSettings.BetaAppDescription"/></li><li><c>--beta_app_feedback_email</c> via <see cref="FastlaneDeliverSettings.BetaAppFeedbackEmail"/></li><li><c>--beta_app_review_info</c> via <see cref="FastlaneDeliverSettings.BetaAppReviewInfo"/></li><li><c>--build_number</c> via <see cref="FastlaneDeliverSettings.BuildNumber"/></li><li><c>--build_number</c> via <see cref="FastlaneDeliverSettings.Platform"/></li><li><c>--changelog</c> via <see cref="FastlaneDeliverSettings.Changelog"/></li><li><c>--dev_portal_team_id</c> via <see cref="FastlaneDeliverSettings.DevPortalTeamId"/></li><li><c>--distribute_external</c> via <see cref="FastlaneDeliverSettings.DistributeExternal"/></li><li><c>--distribute_only</c> via <see cref="FastlaneDeliverSettings.DistributeOnly"/></li><li><c>--edit_live</c> via <see cref="FastlaneDeliverSettings.EditLive"/></li><li><c>--groups</c> via <see cref="FastlaneDeliverSettings.Groups"/></li><li><c>--ipa</c> via <see cref="FastlaneDeliverSettings.Ipa"/></li><li><c>--itc_provider</c> via <see cref="FastlaneDeliverSettings.ItcProvider"/></li><li><c>--localized_app_info</c> via <see cref="FastlaneDeliverSettings.LocalizedAppInfo"/></li><li><c>--notify_external_testers</c> via <see cref="FastlaneDeliverSettings.NotifyExternalTesters"/></li><li><c>--pkg</c> via <see cref="FastlaneDeliverSettings.Pkg"/></li><li><c>--reject_build_waiting_for_review</c> via <see cref="FastlaneDeliverSettings.RejectBuilderWaitingForReview"/></li><li><c>--skip_confirmation</c> via <see cref="FastlaneDeliverSettings.SkipConfirmation"/></li><li><c>--skip_submission</c> via <see cref="FastlaneDeliverSettings.SkipSubmission"/></li><li><c>--skip_waiting_for_build_processing</c> via <see cref="FastlaneDeliverSettings.SkipWaitingForBuildProcessing"/></li><li><c>--submit_beta_review</c> via <see cref="FastlaneDeliverSettings.SubmitBetaReview"/></li><li><c>--team_id</c> via <see cref="FastlaneDeliverSettings.TeamId"/></li><li><c>--team_name</c> via <see cref="FastlaneDeliverSettings.TeamName"/></li><li><c>--use_live_version</c> via <see cref="FastlaneDeliverSettings.UseLiveVersion"/></li><li><c>--username</c> via <see cref="FastlaneDeliverSettings.Username"/></li><li><c>--uses_non_exempt_encryption</c> via <see cref="FastlaneDeliverSettings.UsesNonExemptEncryption"/></li><li><c>--verbose</c> via <see cref="FastlaneDeliverSettings.Verbose"/></li><li><c>--wait_processing_interval</c> via <see cref="FastlaneDeliverSettings.WaitProcessingInterval"/></li><li><c>--wait_processing_timeout_duration</c> via <see cref="FastlaneDeliverSettings.WaitProcessingTimeoutDuration"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> FastlaneDeliver(FastlaneDeliverSettings options = null) => new FastlaneTasks().Run<FastlaneDeliverSettings>(options);
    /// <inheritdoc cref="FastlaneTasks.FastlaneDeliver(Nuke.Common.Tools.Fastlane.FastlaneDeliverSettings)"/>
    public static IReadOnlyCollection<Output> FastlaneDeliver(Configure<FastlaneDeliverSettings> configurator) => new FastlaneTasks().Run<FastlaneDeliverSettings>(configurator.Invoke(new FastlaneDeliverSettings()));
    /// <inheritdoc cref="FastlaneTasks.FastlaneDeliver(Nuke.Common.Tools.Fastlane.FastlaneDeliverSettings)"/>
    public static IEnumerable<(FastlaneDeliverSettings Settings, IReadOnlyCollection<Output> Output)> FastlaneDeliver(CombinatorialConfigure<FastlaneDeliverSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(FastlaneDeliver, degreeOfParallelism, completeOnFailure);
    /// <summary><p><c>match</c> creates all required certificates & provisioning profiles and stores them in a separate git repository, Google Cloud, or Amazon S3. Every team member with access to the selected storage can use those credentials for code signing. match also automatically repairs broken and expired credentials. It's the easiest way to share signing credentials across teams.</p><p>For more details, visit the <a href="https://docs.fastlane.tools/actions/match/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--api_key</c> via <see cref="FastlaneMatchSettings.AppStoreConnectApiKey"/></li><li><c>--api_key_path</c> via <see cref="FastlaneMatchSettings.AppStoreConnectApiKeyPath"/></li><li><c>--app_identifier</c> via <see cref="FastlaneMatchSettings.AppIdentifier"/></li><li><c>--clone_branch_directly</c> via <see cref="FastlaneMatchSettings.GitCloneBranchDirectly"/></li><li><c>--derive_catalyst_app_identifier</c> via <see cref="FastlaneMatchSettings.DeriveCatalystApplicationIdentifier"/></li><li><c>--fail_on_name_taken</c> via <see cref="FastlaneMatchSettings.FailOnNameTaken"/></li><li><c>--force</c> via <see cref="FastlaneMatchSettings.Force"/></li><li><c>--force_for_new_certificates</c> via <see cref="FastlaneMatchSettings.ForceForNewCertificates"/></li><li><c>--git_basic_authorization</c> via <see cref="FastlaneMatchSettings.GitBasicAuthorization"/></li><li><c>--git_bearer_authorization</c> via <see cref="FastlaneMatchSettings.GitBearerAuthorization"/></li><li><c>--git_branch</c> via <see cref="FastlaneMatchSettings.GitBranch"/></li><li><c>--git_full_name</c> via <see cref="FastlaneMatchSettings.GitFullName"/></li><li><c>--git_private_key</c> via <see cref="FastlaneMatchSettings.GitPrivateKey"/></li><li><c>--git_url</c> via <see cref="FastlaneMatchSettings.GitUrl"/></li><li><c>--git_user_email</c> via <see cref="FastlaneMatchSettings.GitUserEmail"/></li><li><c>--google_cloud_bucket_name</c> via <see cref="FastlaneMatchSettings.GoogleCloudBucketName"/></li><li><c>--google_cloud_keys_file</c> via <see cref="FastlaneMatchSettings.GoogleCloudKeys"/></li><li><c>--google_cloud_project_id</c> via <see cref="FastlaneMatchSettings.GoogleCloudProjectId"/></li><li><c>--include_all_certificates</c> via <see cref="FastlaneMatchSettings.IncludeAllCertificates"/></li><li><c>--include_mac_in_profiles</c> via <see cref="FastlaneMatchSettings.IncludeMacInProfiles"/></li><li><c>--output_path</c> via <see cref="FastlaneMatchSettings.OutputPath"/></li><li><c>--platform</c> via <see cref="FastlaneMatchSettings.Platform"/></li><li><c>--profile_name</c> via <see cref="FastlaneMatchSettings.ProfileName"/></li><li><c>--readonly</c> via <see cref="FastlaneMatchSettings.Readonly"/></li><li><c>--s3_access_key</c> via <see cref="FastlaneMatchSettings.S3AccessKey"/></li><li><c>--s3_bucket</c> via <see cref="FastlaneMatchSettings.S3Bucket"/></li><li><c>--s3_object_prefix</c> via <see cref="FastlaneMatchSettings.S3ObjectPrefix"/></li><li><c>--s3_region</c> via <see cref="FastlaneMatchSettings.S3Region"/></li><li><c>--safe_remove_certs</c> via <see cref="FastlaneMatchSettings.SafeRemoveCertificates"/></li><li><c>--shallow_clone</c> via <see cref="FastlaneMatchSettings.GitShallowClone"/></li><li><c>--skip_certificate_matching</c> via <see cref="FastlaneMatchSettings.SkipCertificateMatching"/></li><li><c>--skip_confirmation</c> via <see cref="FastlaneMatchSettings.SkipConfirmation"/></li><li><c>--skip_docs</c> via <see cref="FastlaneMatchSettings.SkipDocumentation"/></li><li><c>--skip_google_cloud_account_confirmation</c> via <see cref="FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation"/></li><li><c>--team_id</c> via <see cref="FastlaneMatchSettings.TeamId"/></li><li><c>--team_name</c> via <see cref="FastlaneMatchSettings.TeamName"/></li><li><c>--template_name</c> via <see cref="FastlaneMatchSettings.TemplateName"/></li><li><c>--type</c> via <see cref="FastlaneMatchSettings.Type"/></li><li><c>--username</c> via <see cref="FastlaneMatchSettings.Username"/></li><li><c>--verbose</c> via <see cref="FastlaneMatchSettings.Verbose"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> FastlaneMatch(FastlaneMatchSettings options = null) => new FastlaneTasks().Run<FastlaneMatchSettings>(options);
    /// <inheritdoc cref="FastlaneTasks.FastlaneMatch(Nuke.Common.Tools.Fastlane.FastlaneMatchSettings)"/>
    public static IReadOnlyCollection<Output> FastlaneMatch(Configure<FastlaneMatchSettings> configurator) => new FastlaneTasks().Run<FastlaneMatchSettings>(configurator.Invoke(new FastlaneMatchSettings()));
    /// <inheritdoc cref="FastlaneTasks.FastlaneMatch(Nuke.Common.Tools.Fastlane.FastlaneMatchSettings)"/>
    public static IEnumerable<(FastlaneMatchSettings Settings, IReadOnlyCollection<Output> Output)> FastlaneMatch(CombinatorialConfigure<FastlaneMatchSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(FastlaneMatch, degreeOfParallelism, completeOnFailure);
    /// <summary><p><c>pilot</c> pilot uses <a href="https://spaceship.airforce">spaceship.airforce</a> to interact with App Store Connect.</p><p>For more details, visit the <a href="https://docs.fastlane.tools/actions/pilot/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--api_key</c> via <see cref="FastlanePilotSettings.AppStoreConnectApiKey"/></li><li><c>--api_key_path</c> via <see cref="FastlanePilotSettings.AppStoreConnectApiKeyPath"/></li><li><c>--app_identifier</c> via <see cref="FastlanePilotSettings.AppIdentifier"/></li><li><c>--app_version</c> via <see cref="FastlanePilotSettings.AppVersion"/></li><li><c>--apple_id</c> via <see cref="FastlanePilotSettings.AppleId"/></li><li><c>--build_number</c> via <see cref="FastlanePilotSettings.BuildNumber"/></li><li><c>--changelog</c> via <see cref="FastlanePilotSettings.Changelog"/></li><li><c>--demo_account_required</c> via <see cref="FastlanePilotSettings.DemoAccountRequired"/></li><li><c>--dev_portal_team_id</c> via <see cref="FastlanePilotSettings.DevPortalTeamId"/></li><li><c>--dev_portal_team_name</c> via <see cref="FastlanePilotSettings.DevPortalTeamName"/></li><li><c>--distribute_external</c> via <see cref="FastlanePilotSettings.DistributeExternal"/></li><li><c>--distribute_only</c> via <see cref="FastlanePilotSettings.DistributeOnly"/></li><li><c>--expire_previous_builds</c> via <see cref="FastlanePilotSettings.ExpirePreviousBuilds"/></li><li><c>--groups</c> via <see cref="FastlanePilotSettings.Groups"/></li><li><c>--ipa</c> via <see cref="FastlanePilotSettings.Ipa"/></li><li><c>--itc_provider</c> via <see cref="FastlanePilotSettings.ItcProvider"/></li><li><c>--localized_app_info</c> via <see cref="FastlanePilotSettings.LocalizedAppInfo"/></li><li><c>--notify_external_testers</c> via <see cref="FastlanePilotSettings.NotifyExternalTesters"/></li><li><c>--pkg</c> via <see cref="FastlanePilotSettings.Pkg"/></li><li><c>--reject_build_waiting_for_review</c> via <see cref="FastlanePilotSettings.RejectBuilderWaitingForReview"/></li><li><c>--skip_confirmation</c> via <see cref="FastlanePilotSettings.SkipConfirmation"/></li><li><c>--skip_submission</c> via <see cref="FastlanePilotSettings.SkipSubmission"/></li><li><c>--skip_waiting_for_build_processing</c> via <see cref="FastlanePilotSettings.SkipWaitingForBuildProcessing"/></li><li><c>--submit_beta_review</c> via <see cref="FastlanePilotSettings.SubmitBetaReview"/></li><li><c>--team_id</c> via <see cref="FastlanePilotSettings.TeamId"/></li><li><c>--team_name</c> via <see cref="FastlanePilotSettings.TeamName"/></li><li><c>--username</c> via <see cref="FastlanePilotSettings.Username"/></li><li><c>--uses_non_exempt_encryption</c> via <see cref="FastlanePilotSettings.UsesNonExemptEncryption"/></li><li><c>--verbose</c> via <see cref="FastlanePilotSettings.Verbose"/></li><li><c>--wait_processing_interval</c> via <see cref="FastlanePilotSettings.WaitProcessingInterval"/></li><li><c>--wait_processing_timeout_duration</c> via <see cref="FastlanePilotSettings.WaitProcessingTimeoutDuration"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> FastlanePilot(FastlanePilotSettings options = null) => new FastlaneTasks().Run<FastlanePilotSettings>(options);
    /// <inheritdoc cref="FastlaneTasks.FastlanePilot(Nuke.Common.Tools.Fastlane.FastlanePilotSettings)"/>
    public static IReadOnlyCollection<Output> FastlanePilot(Configure<FastlanePilotSettings> configurator) => new FastlaneTasks().Run<FastlanePilotSettings>(configurator.Invoke(new FastlanePilotSettings()));
    /// <inheritdoc cref="FastlaneTasks.FastlanePilot(Nuke.Common.Tools.Fastlane.FastlanePilotSettings)"/>
    public static IEnumerable<(FastlanePilotSettings Settings, IReadOnlyCollection<Output> Output)> FastlanePilot(CombinatorialConfigure<FastlanePilotSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(FastlanePilot, degreeOfParallelism, completeOnFailure);
    /// <summary><p><c>supply</c> uploads app metadata, screenshots, binaries, and app bundles to Google Play. You can also select tracks for builds and promote builds to production.</p><p>For more details, visit the <a href="https://docs.fastlane.tools/actions/supply/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--aab</c> via <see cref="FastlaneSupplySettings.Aab"/></li><li><c>--aab_paths</c> via <see cref="FastlaneSupplySettings.AabPaths"/></li><li><c>--ack_bundle_installation_warning</c> via <see cref="FastlaneSupplySettings.AckBundleInstallationWarning"/></li><li><c>--apk</c> via <see cref="FastlaneSupplySettings.Apk"/></li><li><c>--apk_paths</c> via <see cref="FastlaneSupplySettings.ApkPaths"/></li><li><c>--changes_not_sent_for_review</c> via <see cref="FastlaneSupplySettings.ChangesNotSentForReview"/></li><li><c>--in_app_update_priority</c> via <see cref="FastlaneSupplySettings.InAppUpdatePriority"/></li><li><c>--json_key</c> via <see cref="FastlaneSupplySettings.JsonKey"/></li><li><c>--json_key_data</c> via <see cref="FastlaneSupplySettings.JsonKeyData"/></li><li><c>--mapping</c> via <see cref="FastlaneSupplySettings.Mapping"/></li><li><c>--mapping_paths</c> via <see cref="FastlaneSupplySettings.MappingPaths"/></li><li><c>--mapping_paths</c> via <see cref="FastlaneSupplySettings.RootUrl"/></li><li><c>--metadata_path</c> via <see cref="FastlaneSupplySettings.MetadataPath"/></li><li><c>--obb_main_file_size</c> via <see cref="FastlaneSupplySettings.ObbMainFileSize"/></li><li><c>--obb_main_references_version</c> via <see cref="FastlaneSupplySettings.ObbMainReferencesVersion"/></li><li><c>--obb_patch_file_size</c> via <see cref="FastlaneSupplySettings.ObbPatchFileSize"/></li><li><c>--obb_patch_references_version</c> via <see cref="FastlaneSupplySettings.ObbPatchReferencesVersion"/></li><li><c>--package_name</c> via <see cref="FastlaneSupplySettings.PackageName"/></li><li><c>--release_status</c> via <see cref="FastlaneSupplySettings.ReleaseStatus"/></li><li><c>--rescue_changes_not_sent_for_review</c> via <see cref="FastlaneSupplySettings.RescueChangesNotSentForReview"/></li><li><c>--rollout</c> via <see cref="FastlaneSupplySettings.Rollout"/></li><li><c>--skip_upload_aab</c> via <see cref="FastlaneSupplySettings.SkipUploadAab"/></li><li><c>--skip_upload_apk</c> via <see cref="FastlaneSupplySettings.SkipUploadApk"/></li><li><c>--skip_upload_changelogs</c> via <see cref="FastlaneSupplySettings.SkipUploadChangelogs"/></li><li><c>--skip_upload_images</c> via <see cref="FastlaneSupplySettings.SkipUploadImages"/></li><li><c>--skip_upload_metadata</c> via <see cref="FastlaneSupplySettings.SkipUploadMetadata"/></li><li><c>--skip_upload_screenshots</c> via <see cref="FastlaneSupplySettings.SkipUploadScreenshots"/></li><li><c>--team_id</c> via <see cref="FastlaneSupplySettings.TeamId"/></li><li><c>--team_name</c> via <see cref="FastlaneSupplySettings.TeamName"/></li><li><c>--timeout</c> via <see cref="FastlaneSupplySettings.Timeout"/></li><li><c>--track</c> via <see cref="FastlaneSupplySettings.Track"/></li><li><c>--track_promote_release_status</c> via <see cref="FastlaneSupplySettings.PromotedTrackReleaseStatus"/></li><li><c>--track_promote_to</c> via <see cref="FastlaneSupplySettings.TrackToPromote"/></li><li><c>--validate_only</c> via <see cref="FastlaneSupplySettings.ValidateOnly"/></li><li><c>--verbose</c> via <see cref="FastlaneSupplySettings.Verbose"/></li><li><c>--version_code</c> via <see cref="FastlaneSupplySettings.VersionCode"/></li><li><c>--version_codes_to_retain</c> via <see cref="FastlaneSupplySettings.VersionCodesToRetain"/></li><li><c>--version_name</c> via <see cref="FastlaneSupplySettings.VersionName"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> FastlaneSupply(FastlaneSupplySettings options = null) => new FastlaneTasks().Run<FastlaneSupplySettings>(options);
    /// <inheritdoc cref="FastlaneTasks.FastlaneSupply(Nuke.Common.Tools.Fastlane.FastlaneSupplySettings)"/>
    public static IReadOnlyCollection<Output> FastlaneSupply(Configure<FastlaneSupplySettings> configurator) => new FastlaneTasks().Run<FastlaneSupplySettings>(configurator.Invoke(new FastlaneSupplySettings()));
    /// <inheritdoc cref="FastlaneTasks.FastlaneSupply(Nuke.Common.Tools.Fastlane.FastlaneSupplySettings)"/>
    public static IEnumerable<(FastlaneSupplySettings Settings, IReadOnlyCollection<Output> Output)> FastlaneSupply(CombinatorialConfigure<FastlaneSupplySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(FastlaneSupply, degreeOfParallelism, completeOnFailure);
}
#region FastlaneDeliverSettings
/// <inheritdoc cref="FastlaneTasks.FastlaneDeliver(Nuke.Common.Tools.Fastlane.FastlaneDeliverSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(FastlaneTasks), Command = nameof(FastlaneTasks.FastlaneDeliver), Arguments = "deliver")]
public partial class FastlaneDeliverSettings : ToolOptions
{
    /// <summary>Your Apple ID Username.</summary>
    [Argument(Format = "--username {value}")] public string Username => Get<string>(() => Username);
    /// <summary>The bundle identifier of the app to upload or manage testers (optional).</summary>
    [Argument(Format = "--app_identifier {value}")] public string AppIdentifier => Get<string>(() => AppIdentifier);
    /// <summary>The version number of the application build to distribute. If the version number is not specified, then the most recent build uploaded to TestFlight will be distributed. If specified, the most recent build for the version number will be distributed.</summary>
    [Argument(Format = "--app_version {value}")] public string AppVersion => Get<string>(() => AppVersion);
    /// <summary>If set the given build number (already uploaded to iTC) will be used instead of the current built one.</summary>
    [Argument(Format = "--build_number {value}")] public string BuildNumber => Get<string>(() => BuildNumber);
    /// <summary>The platform to use (optional).</summary>
    [Argument(Format = "--build_number {value}")] public string Platform => Get<string>(() => Platform);
    /// <summary>	Modify live metadata, this option disables ipa upload and screenshot upload.</summary>
    [Argument(Format = "--edit_live")] public bool? EditLive => Get<bool?>(() => EditLive);
    /// <summary>Force usage of live version rather than edit version.</summary>
    [Argument(Format = "--use_live_version")] public bool? UseLiveVersion => Get<bool?>(() => UseLiveVersion);
    /// <summary>The short ID of your team in the developer portal, if you're in multiple teams. Different from your iTC team ID!.</summary>
    [Argument(Format = "--dev_portal_team_id {value}")] public string DevPortalTeamId => Get<string>(() => DevPortalTeamId);
    /// <summary>The provider short name to be used with the iTMSTransporter to identify your team. This value will override the automatically detected provider short name. To get provider short name run pathToXcode.app/Contents/Applications/Application\ Loader.app/Contents/itms/bin/iTMSTransporter -m provider -u 'USERNAME' -p 'PASSWORD' -account_type itunes_connect -v off. The short names of providers should be listed in the second column.</summary>
    [Argument(Format = "--itc_provider {value}")] public string ItcProvider => Get<string>(() => ItcProvider);
    /// <summary>Beta app review information for contact info and demo account.</summary>
    [Argument(Format = "--beta_app_review_info {value}")] public string BetaAppReviewInfo => Get<string>(() => BetaAppReviewInfo);
    /// <summary>Provide the 'Beta App Description' when uploading a new build.</summary>
    [Argument(Format = "--beta_app_description {value}")] public string BetaAppDescription => Get<string>(() => BetaAppDescription);
    /// <summary>Provide the beta app email when uploading a new build.</summary>
    [Argument(Format = "--beta_app_feedback_email {value}")] public string BetaAppFeedbackEmail => Get<string>(() => BetaAppFeedbackEmail);
    /// <summary>Localized beta app test info for description, feedback email, marketing url, and privacy policy.</summary>
    [Argument(Format = "--localized_app_info {value}")] public string LocalizedAppInfo => Get<string>(() => LocalizedAppInfo);
    /// <summary>Provide the 'What to Test' text when uploading a new build.</summary>
    [Argument(Format = "--changelog {value}")] public string Changelog => Get<string>(() => Changelog);
    /// <summary>Skip the distributing action of pilot and only upload the ipa file.</summary>
    [Argument(Format = "--skip_submission")] public bool? SkipSubmission => Get<bool?>(() => SkipSubmission);
    /// <summary>If set to true, the distribute_external option won't work and no build will be distributed to testers. (You might want to use this option if you are using this action on CI and have to pay for 'minutes used' on your CI plan). If set to true and a changelog is provided, it will partially wait for the build to appear on AppStore Connect so the changelog can be set, and skip the remaining processing steps.</summary>
    [Argument(Format = "--skip_waiting_for_build_processing")] public bool? SkipWaitingForBuildProcessing => Get<bool?>(() => SkipWaitingForBuildProcessing);
    /// <summary>	Should the build be distributed to external testers? If set to true, use of groups option is required.</summary>
    [Argument(Format = "--distribute_external")] public bool? DistributeExternal => Get<bool?>(() => DistributeExternal);
    /// <summary>Distribute a previously uploaded build (equivalent to the fastlane pilot distribute command).</summary>
    [Argument(Format = "--distribute_only")] public bool? DistributeOnly => Get<bool?>(() => DistributeOnly);
    /// <summary>Should notify external testers? (Not setting a value will use App Store Connect's default which is to notify).</summary>
    [Argument(Format = "--notify_external_testers")] public bool? NotifyExternalTesters => Get<bool?>(() => NotifyExternalTesters);
    /// <summary>Associate tester to one group or more by group name / group id. E.g. -g "Team 1","Team 2" This is required when distribute_external option is set to true or when we want to add a tester to one or more external testing groups.</summary>
    [Argument(Format = "--groups {value}")] public IReadOnlyList<string> Groups => Get<List<string>>(() => Groups);
    /// <summary>Provide the 'Uses Non-Exempt Encryption' for export compliance. This is used if there is 'ITSAppUsesNonExemptEncryption' is not set in the Info.plist.</summary>
    [Argument(Format = "--uses_non_exempt_encryption")] public bool? UsesNonExemptEncryption => Get<bool?>(() => UsesNonExemptEncryption);
    /// <summary>Disables confirmation prompts during nuke, answering them with yes.</summary>
    [Argument(Format = "--skip_confirmation")] public bool? SkipConfirmation => Get<bool?>(() => SkipConfirmation);
    /// <summary>Expire previous if it's 'waiting for review'.</summary>
    [Argument(Format = "--reject_build_waiting_for_review")] public bool? RejectBuilderWaitingForReview => Get<bool?>(() => RejectBuilderWaitingForReview);
    /// <summary>Send the build for a beta review.</summary>
    [Argument(Format = "--submit_beta_review")] public bool? SubmitBetaReview => Get<bool?>(() => SubmitBetaReview);
    /// <summary>Disables confirmation prompts during nuke, answering them with yes.</summary>
    [Argument(Format = "--wait_processing_interval {value}")] public int? WaitProcessingInterval => Get<int?>(() => WaitProcessingInterval);
    /// <summary>Timeout duration in seconds to wait for App Store Connect processing. If set, after exceeding timeout duration, this will force stop to wait for App Store Connect processing and exit with exception.</summary>
    [Argument(Format = "--wait_processing_timeout_duration {value}")] public int? WaitProcessingTimeoutDuration => Get<int?>(() => WaitProcessingTimeoutDuration);
    /// <summary>Path to your App Store Connect API Key JSON file <a href="https://docs.fastlane.tools/app-store-connect-api/#using-fastlane-api-key-json-file">Using Fastlane Api Key Json file</a>.</summary>
    [Argument(Format = "--api_key_path {value}")] public string AppStoreConnectApiKeyPath => Get<string>(() => AppStoreConnectApiKeyPath);
    /// <summary>Your App Store Connect API Key information () <a href="https://docs.fastlane.tools/app-store-connect-api/#using-fastlane-api-key-hash-option">Using Fastlane Api Key hash option</a>.</summary>
    [Argument(Format = "--api_key {value}", Secret = true)] public string AppStoreConnectApiKey => Get<string>(() => AppStoreConnectApiKey);
    /// <summary>Print out extra information and all commands.</summary>
    [Argument(Format = "--verbose")] public bool? Verbose => Get<bool?>(() => Verbose);
    /// <summary>Path to the ipa file to upload.</summary>
    [Argument(Format = "--ipa {value}")] public string Ipa => Get<string>(() => Ipa);
    /// <summary>Path to your pkg file.</summary>
    [Argument(Format = "--pkg {value}")] public string Pkg => Get<string>(() => Pkg);
    /// <summary>The ID of your Developer Portal team if you're in multiple teams.</summary>
    [Argument(Format = "--team_id {value}")] public string TeamId => Get<string>(() => TeamId);
    /// <summary>The ID of your Developer Portal team if you're in multiple teams.</summary>
    [Argument(Format = "--team_name {value}")] public string TeamName => Get<string>(() => TeamName);
}
#endregion
#region FastlaneMatchSettings
/// <inheritdoc cref="FastlaneTasks.FastlaneMatch(Nuke.Common.Tools.Fastlane.FastlaneMatchSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(FastlaneTasks), Command = nameof(FastlaneTasks.FastlaneMatch), Arguments = "match")]
public partial class FastlaneMatchSettings : ToolOptions
{
    /// <summary>The bundle identifier(s) of your app (comma-separated string or array of strings).</summary>
    [Argument(Format = "--app_identifier {value}")] public IReadOnlyList<string> AppIdentifier => Get<List<string>>(() => AppIdentifier);
    /// <summary>Your Apple ID Username.</summary>
    [Argument(Format = "--username {value}")] public string Username => Get<string>(() => Username);
    /// <summary>Define the profile type, can be appstore, adhoc, development, enterprise, developer_id, mac_installer_distribution.</summary>
    [Argument(Format = "--type {value}")] public MatchProfile Type => Get<MatchProfile>(() => Type);
    /// <summary>force	Renew the provisioning profiles every time you run match.</summary>
    [Argument(Format = "--force")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Include all matching certificates in the provisioning profile. Works only for the 'development' provisioning profile type.</summary>
    [Argument(Format = "--include_all_certificates")] public bool? IncludeAllCertificates => Get<bool?>(() => IncludeAllCertificates);
    /// <summary>Renew the provisioning profiles if the certificate count on the developer portal has changed. Works only for the 'development' provisioning profile type. Requires 'include_all_certificates' option to be 'true'.</summary>
    [Argument(Format = "--force_for_new_certificates")] public bool? ForceForNewCertificates => Get<bool?>(() => ForceForNewCertificates);
    /// <summary>Remove certs from repository during nuke without revoking them on the developer portal.</summary>
    [Argument(Format = "--safe_remove_certs")] public bool? SafeRemoveCertificates => Get<bool?>(() => SafeRemoveCertificates);
    /// <summary>Set to true if there is no access to Apple developer portal but there are certificates, keys and profiles provided. Only works with match import action.</summary>
    [Argument(Format = "--skip_certificate_matching")] public bool? SkipCertificateMatching => Get<bool?>(() => SkipCertificateMatching);
    /// <summary>Set the provisioning profile's platform to work with (i.e. ios, tvos, macos, catalyst).</summary>
    [Argument(Format = "--platform {value}")] public ProvisioningPlatform Platform => Get<ProvisioningPlatform>(() => Platform);
    /// <summary>Only fetch existing certificates and profiles, don't generate new ones.</summary>
    [Argument(Format = "--readonly")] public bool? Readonly => Get<bool?>(() => Readonly);
    /// <summary>Skip generation of a README.md for the created git repository.</summary>
    [Argument(Format = "--skip_docs")] public bool? SkipDocumentation => Get<bool?>(() => SkipDocumentation);
    /// <summary>Disables confirmation prompts during nuke, answering them with yes.</summary>
    [Argument(Format = "--skip_confirmation")] public bool? SkipConfirmation => Get<bool?>(() => SkipConfirmation);
    /// <summary>Should the command fail if it was about to create a duplicate of an existing provisioning profile. It can happen due to issues on Apple Developer Portal, when profile to be recreated was not properly deleted first.</summary>
    [Argument(Format = "--fail_on_name_taken {value}", Secret = true)] public string FailOnNameTaken => Get<string>(() => FailOnNameTaken);
    /// <summary>Enable this if you have the Mac Catalyst capability enabled and your project was created with Xcode 11.3 or earlier. Prepends 'maccatalyst.' to the app identifier for the provisioning profile mapping.</summary>
    [Argument(Format = "--derive_catalyst_app_identifier")] public bool? DeriveCatalystApplicationIdentifier => Get<bool?>(() => DeriveCatalystApplicationIdentifier);
    /// <summary>Include Apple Silicon Mac devices in provisioning profiles for iOS/iPadOS apps.</summary>
    [Argument(Format = "--include_mac_in_profiles")] public bool? IncludeMacInProfiles => Get<bool?>(() => IncludeMacInProfiles);
    /// <summary>A custom name for the provisioning profile. This will replace the default provisioning profile name if specified.</summary>
    [Argument(Format = "--profile_name {value}")] public string ProfileName => Get<string>(() => ProfileName);
    /// <summary>The name of provisioning profile template. If the developer account has provisioning profile templates (aka: custom entitlements), the template name can be found by inspecting the Entitlements drop-down while creating/editing a provisioning profile (e.g. "Apple Pay Pass Suppression Development").</summary>
    [Argument(Format = "--template_name {value}")] public string TemplateName => Get<string>(() => TemplateName);
    /// <summary>Path in which to export certificates, key and profile.</summary>
    [Argument(Format = "--output_path {value}")] public string OutputPath => Get<string>(() => OutputPath);
    /// <summary>Path to your App Store Connect API Key JSON file <a href="https://docs.fastlane.tools/app-store-connect-api/#using-fastlane-api-key-json-file">Using Fastlane Api Key Json file</a>.</summary>
    [Argument(Format = "--api_key_path {value}")] public string AppStoreConnectApiKeyPath => Get<string>(() => AppStoreConnectApiKeyPath);
    /// <summary>Your App Store Connect API Key information () <a href="https://docs.fastlane.tools/app-store-connect-api/#using-fastlane-api-key-hash-option">Using Fastlane Api Key hash option</a>.</summary>
    [Argument(Format = "--api_key {value}", Secret = true)] public string AppStoreConnectApiKey => Get<string>(() => AppStoreConnectApiKey);
    /// <summary>Print out extra information and all commands.</summary>
    [Argument(Format = "--verbose")] public bool? Verbose => Get<bool?>(() => Verbose);
    /// <summary>URL to the git repo containing all the certificates.</summary>
    [Argument(Format = "--git_url {value}")] public string GitUrl => Get<string>(() => GitUrl);
    /// <summary>Specific git branch to use.</summary>
    [Argument(Format = "--git_branch {value}")] public string GitBranch => Get<string>(() => GitBranch);
    /// <summary>git user full name to commit.</summary>
    [Argument(Format = "--git_full_name {value}")] public string GitFullName => Get<string>(() => GitFullName);
    /// <summary>git user email to commit.</summary>
    [Argument(Format = "--git_user_email {value}")] public string GitUserEmail => Get<string>(() => GitUserEmail);
    /// <summary>Make a shallow clone of the repository (truncate the history to 1 revision).</summary>
    [Argument(Format = "--shallow_clone")] public bool? GitShallowClone => Get<bool?>(() => GitShallowClone);
    /// <summary>Clone just the branch specified, instead of the whole repo. This requires that the branch already exists. Otherwise the command will fail.</summary>
    [Argument(Format = "--clone_branch_directly")] public bool? GitCloneBranchDirectly => Get<bool?>(() => GitCloneBranchDirectly);
    /// <summary>Use a basic authorization header to access the git repo (e.g.: access via HTTPS, GitHub Actions, etc), usually a string in Base64.</summary>
    [Argument(Format = "--git_basic_authorization {value}")] public string GitBasicAuthorization => Get<string>(() => GitBasicAuthorization);
    /// <summary>Use a bearer authorization header to access the git repo (e.g.: access to an Azure DevOps repository), usually a string in Base64.</summary>
    [Argument(Format = "--git_bearer_authorization {value}")] public string GitBearerAuthorization => Get<string>(() => GitBearerAuthorization);
    /// <summary>Use a private key to access the git repo (e.g.: access to GitHub repository via Deploy keys), usually a id_rsa named file or the contents hereof.</summary>
    [Argument(Format = "--git_private_key {value}")] public string GitPrivateKey => Get<string>(() => GitPrivateKey);
    /// <summary>Name of the Google Cloud Storage bucket to use.</summary>
    [Argument(Format = "--google_cloud_bucket_name {value}")] public string GoogleCloudBucketName => Get<string>(() => GoogleCloudBucketName);
    /// <summary>Name of the Google Cloud Storage bucket to use.</summary>
    [Argument(Format = "--google_cloud_keys_file {value}")] public string GoogleCloudKeys => Get<string>(() => GoogleCloudKeys);
    /// <summary>Name of the Google Cloud Storage bucket to use.</summary>
    [Argument(Format = "--google_cloud_project_id {value}")] public string GoogleCloudProjectId => Get<string>(() => GoogleCloudProjectId);
    /// <summary>Skips confirming to use the system google account.</summary>
    [Argument(Format = "--skip_google_cloud_account_confirmation")] public bool? SkipGoogleCloudAccountConfirmation => Get<bool?>(() => SkipGoogleCloudAccountConfirmation);
    /// <summary>S3 access key.</summary>
    [Argument(Format = "--s3_access_key {value}")] public string S3AccessKey => Get<string>(() => S3AccessKey);
    /// <summary>Name of the S3 bucket.</summary>
    [Argument(Format = "--s3_bucket {value}")] public string S3Bucket => Get<string>(() => S3Bucket);
    /// <summary>Prefix to be used on all objects uploaded to S3.</summary>
    [Argument(Format = "--s3_object_prefix {value}")] public string S3ObjectPrefix => Get<string>(() => S3ObjectPrefix);
    /// <summary>Name of the S3 region.</summary>
    [Argument(Format = "--s3_region {value}")] public string S3Region => Get<string>(() => S3Region);
    /// <summary>The ID of your Developer Portal team if you're in multiple teams.</summary>
    [Argument(Format = "--team_id {value}")] public string TeamId => Get<string>(() => TeamId);
    /// <summary>The ID of your Developer Portal team if you're in multiple teams.</summary>
    [Argument(Format = "--team_name {value}")] public string TeamName => Get<string>(() => TeamName);
}
#endregion
#region FastlanePilotSettings
/// <inheritdoc cref="FastlaneTasks.FastlanePilot(Nuke.Common.Tools.Fastlane.FastlanePilotSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(FastlaneTasks), Command = nameof(FastlaneTasks.FastlanePilot), Arguments = "pilot")]
public partial class FastlanePilotSettings : ToolOptions
{
    /// <summary>The version number of the application build to distribute. If the version number is not specified, then the most recent build uploaded to TestFlight will be distributed. If specified, the most recent build for the version number will be distributed.</summary>
    [Argument(Format = "--app_version {value}")] public string AppVersion => Get<string>(() => AppVersion);
    /// <summary>The bundle identifier(s) of your app (comma-separated string or array of strings).</summary>
    [Argument(Format = "--apple_id {value}")] public string AppleId => Get<string>(() => AppleId);
    /// <summary>The bundle identifier of the app to upload or manage testers (optional).</summary>
    [Argument(Format = "--app_identifier {value}")] public string AppIdentifier => Get<string>(() => AppIdentifier);
    /// <summary>The build number of the application build to distribute. If the build number is not specified, the most recent build is distributed.</summary>
    [Argument(Format = "--build_number {value}")] public string BuildNumber => Get<string>(() => BuildNumber);
    /// <summary>Should expire previous builds?.</summary>
    [Argument(Format = "--expire_previous_builds")] public bool? ExpirePreviousBuilds => Get<bool?>(() => ExpirePreviousBuilds);
    /// <summary>Do you need a demo account when Apple does review?.</summary>
    [Argument(Format = "--demo_account_required")] public bool? DemoAccountRequired => Get<bool?>(() => DemoAccountRequired);
    /// <summary>The short ID of your Developer Portal team, if you're in multiple teams. Different from your iTC team ID!.</summary>
    [Argument(Format = "--dev_portal_team_id {value}")] public string DevPortalTeamId => Get<string>(() => DevPortalTeamId);
    /// <summary>The name of your Developer Portal team if you're in multiple teams.</summary>
    [Argument(Format = "--dev_portal_team_name {value}")] public string DevPortalTeamName => Get<string>(() => DevPortalTeamName);
    /// <summary>The provider short name to be used with the iTMSTransporter to identify your team. This value will override the automatically detected provider short name. To get provider short name run pathToXcode.app/Contents/Applications/Application\ Loader.app/Contents/itms/bin/iTMSTransporter -m provider -u 'USERNAME' -p 'PASSWORD' -account_type itunes_connect -v off. The short names of providers should be listed in the second column.</summary>
    [Argument(Format = "--itc_provider {value}")] public string ItcProvider => Get<string>(() => ItcProvider);
    /// <summary>Localized beta app test info for description, feedback email, marketing url, and privacy policy.</summary>
    [Argument(Format = "--localized_app_info {value}")] public string LocalizedAppInfo => Get<string>(() => LocalizedAppInfo);
    /// <summary>Provide the 'What to Test' text when uploading a new build.</summary>
    [Argument(Format = "--changelog {value}")] public string Changelog => Get<string>(() => Changelog);
    /// <summary>Skip the distributing action of pilot and only upload the ipa file.</summary>
    [Argument(Format = "--skip_submission")] public bool? SkipSubmission => Get<bool?>(() => SkipSubmission);
    /// <summary>If set to true, the distribute_external option won't work and no build will be distributed to testers. (You might want to use this option if you are using this action on CI and have to pay for 'minutes used' on your CI plan). If set to true and a changelog is provided, it will partially wait for the build to appear on AppStore Connect so the changelog can be set, and skip the remaining processing steps.</summary>
    [Argument(Format = "--skip_waiting_for_build_processing")] public bool? SkipWaitingForBuildProcessing => Get<bool?>(() => SkipWaitingForBuildProcessing);
    /// <summary>	Should the build be distributed to external testers? If set to true, use of groups option is required.</summary>
    [Argument(Format = "--distribute_external")] public bool? DistributeExternal => Get<bool?>(() => DistributeExternal);
    /// <summary>Distribute a previously uploaded build (equivalent to the fastlane pilot distribute command).</summary>
    [Argument(Format = "--distribute_only")] public bool? DistributeOnly => Get<bool?>(() => DistributeOnly);
    /// <summary>Should notify external testers? (Not setting a value will use App Store Connect's default which is to notify).</summary>
    [Argument(Format = "--notify_external_testers")] public bool? NotifyExternalTesters => Get<bool?>(() => NotifyExternalTesters);
    /// <summary>Associate tester to one group or more by group name / group id. E.g. -g "Team 1","Team 2" This is required when distribute_external option is set to true or when we want to add a tester to one or more external testing groups.</summary>
    [Argument(Format = "--groups {value}")] public IReadOnlyList<string> Groups => Get<List<string>>(() => Groups);
    /// <summary>Provide the 'Uses Non-Exempt Encryption' for export compliance. This is used if there is 'ITSAppUsesNonExemptEncryption' is not set in the Info.plist.</summary>
    [Argument(Format = "--uses_non_exempt_encryption")] public bool? UsesNonExemptEncryption => Get<bool?>(() => UsesNonExemptEncryption);
    /// <summary>Disables confirmation prompts during nuke, answering them with yes.</summary>
    [Argument(Format = "--skip_confirmation")] public bool? SkipConfirmation => Get<bool?>(() => SkipConfirmation);
    /// <summary>Expire previous if it's 'waiting for review'.</summary>
    [Argument(Format = "--reject_build_waiting_for_review")] public bool? RejectBuilderWaitingForReview => Get<bool?>(() => RejectBuilderWaitingForReview);
    /// <summary>Send the build for a beta review.</summary>
    [Argument(Format = "--submit_beta_review")] public bool? SubmitBetaReview => Get<bool?>(() => SubmitBetaReview);
    /// <summary>Disables confirmation prompts during nuke, answering them with yes.</summary>
    [Argument(Format = "--wait_processing_interval {value}")] public int? WaitProcessingInterval => Get<int?>(() => WaitProcessingInterval);
    /// <summary>Timeout duration in seconds to wait for App Store Connect processing. If set, after exceeding timeout duration, this will force stop to wait for App Store Connect processing and exit with exception.</summary>
    [Argument(Format = "--wait_processing_timeout_duration {value}")] public int? WaitProcessingTimeoutDuration => Get<int?>(() => WaitProcessingTimeoutDuration);
    /// <summary>Path to your App Store Connect API Key JSON file <a href="https://docs.fastlane.tools/app-store-connect-api/#using-fastlane-api-key-json-file">Using Fastlane Api Key Json file</a>.</summary>
    [Argument(Format = "--api_key_path {value}")] public string AppStoreConnectApiKeyPath => Get<string>(() => AppStoreConnectApiKeyPath);
    /// <summary>Your App Store Connect API Key information () <a href="https://docs.fastlane.tools/app-store-connect-api/#using-fastlane-api-key-hash-option">Using Fastlane Api Key hash option</a>.</summary>
    [Argument(Format = "--api_key {value}", Secret = true)] public string AppStoreConnectApiKey => Get<string>(() => AppStoreConnectApiKey);
    /// <summary>Your Apple ID Username.</summary>
    [Argument(Format = "--username {value}")] public string Username => Get<string>(() => Username);
    /// <summary>Print out extra information and all commands.</summary>
    [Argument(Format = "--verbose")] public bool? Verbose => Get<bool?>(() => Verbose);
    /// <summary>Path to the ipa file to upload.</summary>
    [Argument(Format = "--ipa {value}")] public string Ipa => Get<string>(() => Ipa);
    /// <summary>Path to your pkg file.</summary>
    [Argument(Format = "--pkg {value}")] public string Pkg => Get<string>(() => Pkg);
    /// <summary>The ID of your Developer Portal team if you're in multiple teams.</summary>
    [Argument(Format = "--team_id {value}")] public string TeamId => Get<string>(() => TeamId);
    /// <summary>The ID of your Developer Portal team if you're in multiple teams.</summary>
    [Argument(Format = "--team_name {value}")] public string TeamName => Get<string>(() => TeamName);
}
#endregion
#region FastlaneSupplySettings
/// <inheritdoc cref="FastlaneTasks.FastlaneSupply(Nuke.Common.Tools.Fastlane.FastlaneSupplySettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(FastlaneTasks), Command = nameof(FastlaneTasks.FastlaneSupply), Arguments = "supply")]
public partial class FastlaneSupplySettings : ToolOptions
{
    /// <summary>The package name of the application to use.</summary>
    [Argument(Format = "--package_name {value}")] public string PackageName => Get<string>(() => PackageName);
    /// <summary>Version name (used when uploading new apks/aabs) - defaults to 'versionName' in build.gradle or AndroidManifest.xml.</summary>
    [Argument(Format = "--version_name {value}")] public string VersionName => Get<string>(() => VersionName);
    /// <summary>Version code (used when updating rollout or promoting specific versions).</summary>
    [Argument(Format = "--version_code {value}")] public string VersionCode => Get<string>(() => VersionCode);
    /// <summary>Release status (used when uploading new apks/aabs) - valid values are completed, draft, halted, inProgress.</summary>
    [Argument(Format = "--release_status {value}")] public GooglePlayStoreReleaseStatus ReleaseStatus => Get<GooglePlayStoreReleaseStatus>(() => ReleaseStatus);
    /// <summary>The track of the application to use. The default available tracks are: production, beta, alpha, internal.</summary>
    [Argument(Format = "--track {value}")] public GooglePlayStoreTrack Track => Get<GooglePlayStoreTrack>(() => Track);
    /// <summary>The percentage of the user fraction when uploading to the rollout track (setting to 1 will complete the rollout).</summary>
    [Argument(Format = "--rollout {value}")] public double? Rollout => Get<double?>(() => Rollout);
    /// <summary>Path to the directory containing the metadata files.</summary>
    [Argument(Format = "--metadata_path {value}")] public string MetadataPath => Get<string>(() => MetadataPath);
    /// <summary>The path to a file containing service account JSON, used to authenticate with Google.</summary>
    [Argument(Format = "--json_key {value}")] public string JsonKey => Get<string>(() => JsonKey);
    /// <summary>The raw service account JSON data used to authenticate with Google.</summary>
    [Argument(Format = "--json_key_data {value}")] public string JsonKeyData => Get<string>(() => JsonKeyData);
    /// <summary>Path to the APK file to upload.</summary>
    [Argument(Format = "--apk {value}")] public string Apk => Get<string>(() => Apk);
    /// <summary>An array of paths to APK files to upload.</summary>
    [Argument(Format = "--apk_paths {value}")] public IReadOnlyList<string> ApkPaths => Get<List<string>>(() => ApkPaths);
    /// <summary>Path to the AAB file to upload.</summary>
    [Argument(Format = "--aab {value}")] public string Aab => Get<string>(() => Aab);
    /// <summary>An array of paths to AAB files to upload.</summary>
    [Argument(Format = "--aab_paths {value}")] public IReadOnlyList<string> AabPaths => Get<List<string>>(() => AabPaths);
    /// <summary>Whether to skip uploading APK.</summary>
    [Argument(Format = "--skip_upload_apk")] public bool? SkipUploadApk => Get<bool?>(() => SkipUploadApk);
    /// <summary>Whether to skip uploading AAB.</summary>
    [Argument(Format = "--skip_upload_aab")] public bool? SkipUploadAab => Get<bool?>(() => SkipUploadAab);
    /// <summary>Whether to skip uploading metadata, changelogs not included.</summary>
    [Argument(Format = "--skip_upload_metadata")] public bool? SkipUploadMetadata => Get<bool?>(() => SkipUploadMetadata);
    /// <summary>Whether to skip uploading changelogs.</summary>
    [Argument(Format = "--skip_upload_changelogs")] public bool? SkipUploadChangelogs => Get<bool?>(() => SkipUploadChangelogs);
    /// <summary>Whether to skip uploading images, screenshots not included.</summary>
    [Argument(Format = "--skip_upload_images")] public bool? SkipUploadImages => Get<bool?>(() => SkipUploadImages);
    /// <summary>Whether to skip uploading SCREENSHOTS.</summary>
    [Argument(Format = "--skip_upload_screenshots")] public bool? SkipUploadScreenshots => Get<bool?>(() => SkipUploadScreenshots);
    /// <summary>The track to promote to. The default available tracks are: production, beta, alpha, internal.</summary>
    [Argument(Format = "--track_promote_to {value}")] public GooglePlayStoreTrack TrackToPromote => Get<GooglePlayStoreTrack>(() => TrackToPromote);
    /// <summary>Promoted track release status (used when promoting a track) - valid values are completed, draft, halted, inProgress.</summary>
    [Argument(Format = "--track_promote_release_status {value}")] public GooglePlayStoreReleaseStatus PromotedTrackReleaseStatus => Get<GooglePlayStoreReleaseStatus>(() => PromotedTrackReleaseStatus);
    /// <summary>Only validate changes with Google Play rather than actually publish.</summary>
    [Argument(Format = "--validate_only")] public bool? ValidateOnly => Get<bool?>(() => ValidateOnly);
    /// <summary>Path to the mapping file to upload (mapping.txt or native-debug-symbols.zip alike).</summary>
    [Argument(Format = "--mapping {value}")] public string Mapping => Get<string>(() => Mapping);
    /// <summary>An array of paths to mapping files to upload (mapping.txt or native-debug-symbols.zip alike).</summary>
    [Argument(Format = "--mapping_paths {value}")] public IReadOnlyList<string> MappingPaths => Get<List<string>>(() => MappingPaths);
    /// <summary>Root URL for the Google Play API. The provided URL will be used for API calls in place of https://www.googleapis.com/.</summary>
    [Argument(Format = "--mapping_paths {value}")] public string RootUrl => Get<string>(() => RootUrl);
    /// <summary>Timeout for read, open, and send (in seconds).</summary>
    [Argument(Format = "--timeout {value}")] public int? Timeout => Get<int?>(() => Timeout);
    /// <summary>An array of version codes to retain when publishing a new APK.</summary>
    [Argument(Format = "--version_codes_to_retain {value}")] public IReadOnlyList<string> VersionCodesToRetain => Get<List<string>>(() => VersionCodesToRetain);
    /// <summary>Indicates that the changes in this edit will not be reviewed until they are explicitly sent for review from the Google Play Console UI.</summary>
    [Argument(Format = "--changes_not_sent_for_review")] public bool? ChangesNotSentForReview => Get<bool?>(() => ChangesNotSentForReview);
    /// <summary>Indicates that the changes in this edit will not be reviewed until they are explicitly sent for review from the Google Play Console UI.</summary>
    [Argument(Format = "--rescue_changes_not_sent_for_review")] public bool? RescueChangesNotSentForReview => Get<bool?>(() => RescueChangesNotSentForReview);
    /// <summary>In-app update priority for all the newly added apks in the release. Can take values between [0,5].</summary>
    [Argument(Format = "--in_app_update_priority {value}")] public int? InAppUpdatePriority => Get<int?>(() => InAppUpdatePriority);
    /// <summary>References version of 'main' expansion file.</summary>
    [Argument(Format = "--obb_main_references_version {value}")] public string ObbMainReferencesVersion => Get<string>(() => ObbMainReferencesVersion);
    /// <summary>Size of 'main' expansion file in bytes.</summary>
    [Argument(Format = "--obb_main_file_size {value}")] public int? ObbMainFileSize => Get<int?>(() => ObbMainFileSize);
    /// <summary>References version of 'patch' expansion file.</summary>
    [Argument(Format = "--obb_patch_references_version {value}")] public string ObbPatchReferencesVersion => Get<string>(() => ObbPatchReferencesVersion);
    /// <summary>Size of 'patch' expansion file in bytes.</summary>
    [Argument(Format = "--obb_patch_file_size {value}")] public int? ObbPatchFileSize => Get<int?>(() => ObbPatchFileSize);
    /// <summary>Must be set to true if the bundle installation may trigger a warning on user devices (e.g can only be downloaded over wifi). Typically this is required for bundles over 150MB.</summary>
    [Argument(Format = "--ack_bundle_installation_warning")] public bool? AckBundleInstallationWarning => Get<bool?>(() => AckBundleInstallationWarning);
    /// <summary>Print out extra information and all commands.</summary>
    [Argument(Format = "--verbose")] public bool? Verbose => Get<bool?>(() => Verbose);
    /// <summary>The ID of your Developer Portal team if you're in multiple teams.</summary>
    [Argument(Format = "--team_id {value}")] public string TeamId => Get<string>(() => TeamId);
    /// <summary>The ID of your Developer Portal team if you're in multiple teams.</summary>
    [Argument(Format = "--team_name {value}")] public string TeamName => Get<string>(() => TeamName);
}
#endregion
#region FastlaneDeliverSettingsExtensions
/// <inheritdoc cref="FastlaneTasks.FastlaneDeliver(Nuke.Common.Tools.Fastlane.FastlaneDeliverSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class FastlaneDeliverSettingsExtensions
{
    #region Username
    /// <inheritdoc cref="FastlaneDeliverSettings.Username"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Username))]
    public static T SetUsername<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Username, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Username"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Username))]
    public static T ResetUsername<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.Username));
    #endregion
    #region AppIdentifier
    /// <inheritdoc cref="FastlaneDeliverSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.AppIdentifier))]
    public static T SetAppIdentifier<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.AppIdentifier, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.AppIdentifier))]
    public static T ResetAppIdentifier<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.AppIdentifier));
    #endregion
    #region AppVersion
    /// <inheritdoc cref="FastlaneDeliverSettings.AppVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.AppVersion))]
    public static T SetAppVersion<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.AppVersion, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.AppVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.AppVersion))]
    public static T ResetAppVersion<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.AppVersion));
    #endregion
    #region BuildNumber
    /// <inheritdoc cref="FastlaneDeliverSettings.BuildNumber"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.BuildNumber))]
    public static T SetBuildNumber<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.BuildNumber, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.BuildNumber"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.BuildNumber))]
    public static T ResetBuildNumber<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.BuildNumber));
    #endregion
    #region Platform
    /// <inheritdoc cref="FastlaneDeliverSettings.Platform"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Platform))]
    public static T SetPlatform<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Platform, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Platform"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Platform))]
    public static T ResetPlatform<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.Platform));
    #endregion
    #region EditLive
    /// <inheritdoc cref="FastlaneDeliverSettings.EditLive"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.EditLive))]
    public static T SetEditLive<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.EditLive, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.EditLive"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.EditLive))]
    public static T ResetEditLive<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.EditLive));
    /// <inheritdoc cref="FastlaneDeliverSettings.EditLive"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.EditLive))]
    public static T EnableEditLive<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.EditLive, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.EditLive"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.EditLive))]
    public static T DisableEditLive<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.EditLive, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.EditLive"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.EditLive))]
    public static T ToggleEditLive<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.EditLive, !o.EditLive));
    #endregion
    #region UseLiveVersion
    /// <inheritdoc cref="FastlaneDeliverSettings.UseLiveVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UseLiveVersion))]
    public static T SetUseLiveVersion<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.UseLiveVersion, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.UseLiveVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UseLiveVersion))]
    public static T ResetUseLiveVersion<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.UseLiveVersion));
    /// <inheritdoc cref="FastlaneDeliverSettings.UseLiveVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UseLiveVersion))]
    public static T EnableUseLiveVersion<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.UseLiveVersion, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.UseLiveVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UseLiveVersion))]
    public static T DisableUseLiveVersion<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.UseLiveVersion, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.UseLiveVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UseLiveVersion))]
    public static T ToggleUseLiveVersion<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.UseLiveVersion, !o.UseLiveVersion));
    #endregion
    #region DevPortalTeamId
    /// <inheritdoc cref="FastlaneDeliverSettings.DevPortalTeamId"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DevPortalTeamId))]
    public static T SetDevPortalTeamId<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.DevPortalTeamId, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.DevPortalTeamId"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DevPortalTeamId))]
    public static T ResetDevPortalTeamId<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.DevPortalTeamId));
    #endregion
    #region ItcProvider
    /// <inheritdoc cref="FastlaneDeliverSettings.ItcProvider"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.ItcProvider))]
    public static T SetItcProvider<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.ItcProvider, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.ItcProvider"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.ItcProvider))]
    public static T ResetItcProvider<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.ItcProvider));
    #endregion
    #region BetaAppReviewInfo
    /// <inheritdoc cref="FastlaneDeliverSettings.BetaAppReviewInfo"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.BetaAppReviewInfo))]
    public static T SetBetaAppReviewInfo<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.BetaAppReviewInfo, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.BetaAppReviewInfo"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.BetaAppReviewInfo))]
    public static T ResetBetaAppReviewInfo<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.BetaAppReviewInfo));
    #endregion
    #region BetaAppDescription
    /// <inheritdoc cref="FastlaneDeliverSettings.BetaAppDescription"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.BetaAppDescription))]
    public static T SetBetaAppDescription<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.BetaAppDescription, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.BetaAppDescription"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.BetaAppDescription))]
    public static T ResetBetaAppDescription<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.BetaAppDescription));
    #endregion
    #region BetaAppFeedbackEmail
    /// <inheritdoc cref="FastlaneDeliverSettings.BetaAppFeedbackEmail"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.BetaAppFeedbackEmail))]
    public static T SetBetaAppFeedbackEmail<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.BetaAppFeedbackEmail, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.BetaAppFeedbackEmail"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.BetaAppFeedbackEmail))]
    public static T ResetBetaAppFeedbackEmail<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.BetaAppFeedbackEmail));
    #endregion
    #region LocalizedAppInfo
    /// <inheritdoc cref="FastlaneDeliverSettings.LocalizedAppInfo"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.LocalizedAppInfo))]
    public static T SetLocalizedAppInfo<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.LocalizedAppInfo, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.LocalizedAppInfo"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.LocalizedAppInfo))]
    public static T ResetLocalizedAppInfo<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.LocalizedAppInfo));
    #endregion
    #region Changelog
    /// <inheritdoc cref="FastlaneDeliverSettings.Changelog"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Changelog))]
    public static T SetChangelog<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Changelog, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Changelog"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Changelog))]
    public static T ResetChangelog<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.Changelog));
    #endregion
    #region SkipSubmission
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipSubmission))]
    public static T SetSkipSubmission<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipSubmission, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipSubmission))]
    public static T ResetSkipSubmission<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.SkipSubmission));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipSubmission))]
    public static T EnableSkipSubmission<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipSubmission, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipSubmission))]
    public static T DisableSkipSubmission<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipSubmission, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipSubmission))]
    public static T ToggleSkipSubmission<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipSubmission, !o.SkipSubmission));
    #endregion
    #region SkipWaitingForBuildProcessing
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipWaitingForBuildProcessing))]
    public static T SetSkipWaitingForBuildProcessing<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipWaitingForBuildProcessing, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipWaitingForBuildProcessing))]
    public static T ResetSkipWaitingForBuildProcessing<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.SkipWaitingForBuildProcessing));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipWaitingForBuildProcessing))]
    public static T EnableSkipWaitingForBuildProcessing<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipWaitingForBuildProcessing, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipWaitingForBuildProcessing))]
    public static T DisableSkipWaitingForBuildProcessing<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipWaitingForBuildProcessing, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipWaitingForBuildProcessing))]
    public static T ToggleSkipWaitingForBuildProcessing<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipWaitingForBuildProcessing, !o.SkipWaitingForBuildProcessing));
    #endregion
    #region DistributeExternal
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeExternal))]
    public static T SetDistributeExternal<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.DistributeExternal, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeExternal))]
    public static T ResetDistributeExternal<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.DistributeExternal));
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeExternal))]
    public static T EnableDistributeExternal<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.DistributeExternal, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeExternal))]
    public static T DisableDistributeExternal<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.DistributeExternal, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeExternal))]
    public static T ToggleDistributeExternal<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.DistributeExternal, !o.DistributeExternal));
    #endregion
    #region DistributeOnly
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeOnly))]
    public static T SetDistributeOnly<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.DistributeOnly, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeOnly))]
    public static T ResetDistributeOnly<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.DistributeOnly));
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeOnly))]
    public static T EnableDistributeOnly<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.DistributeOnly, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeOnly))]
    public static T DisableDistributeOnly<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.DistributeOnly, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.DistributeOnly))]
    public static T ToggleDistributeOnly<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.DistributeOnly, !o.DistributeOnly));
    #endregion
    #region NotifyExternalTesters
    /// <inheritdoc cref="FastlaneDeliverSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.NotifyExternalTesters))]
    public static T SetNotifyExternalTesters<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.NotifyExternalTesters, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.NotifyExternalTesters))]
    public static T ResetNotifyExternalTesters<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.NotifyExternalTesters));
    /// <inheritdoc cref="FastlaneDeliverSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.NotifyExternalTesters))]
    public static T EnableNotifyExternalTesters<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.NotifyExternalTesters, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.NotifyExternalTesters))]
    public static T DisableNotifyExternalTesters<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.NotifyExternalTesters, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.NotifyExternalTesters))]
    public static T ToggleNotifyExternalTesters<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.NotifyExternalTesters, !o.NotifyExternalTesters));
    #endregion
    #region Groups
    /// <inheritdoc cref="FastlaneDeliverSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Groups))]
    public static T SetGroups<T>(this T o, params string[] v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Groups, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Groups))]
    public static T SetGroups<T>(this T o, IEnumerable<string> v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Groups, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Groups))]
    public static T AddGroups<T>(this T o, params string[] v) where T : FastlaneDeliverSettings => o.Modify(b => b.AddCollection(() => o.Groups, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Groups))]
    public static T AddGroups<T>(this T o, IEnumerable<string> v) where T : FastlaneDeliverSettings => o.Modify(b => b.AddCollection(() => o.Groups, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Groups))]
    public static T RemoveGroups<T>(this T o, params string[] v) where T : FastlaneDeliverSettings => o.Modify(b => b.RemoveCollection(() => o.Groups, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Groups))]
    public static T RemoveGroups<T>(this T o, IEnumerable<string> v) where T : FastlaneDeliverSettings => o.Modify(b => b.RemoveCollection(() => o.Groups, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Groups))]
    public static T ClearGroups<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.ClearCollection(() => o.Groups));
    #endregion
    #region UsesNonExemptEncryption
    /// <inheritdoc cref="FastlaneDeliverSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UsesNonExemptEncryption))]
    public static T SetUsesNonExemptEncryption<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.UsesNonExemptEncryption, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UsesNonExemptEncryption))]
    public static T ResetUsesNonExemptEncryption<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.UsesNonExemptEncryption));
    /// <inheritdoc cref="FastlaneDeliverSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UsesNonExemptEncryption))]
    public static T EnableUsesNonExemptEncryption<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.UsesNonExemptEncryption, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UsesNonExemptEncryption))]
    public static T DisableUsesNonExemptEncryption<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.UsesNonExemptEncryption, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.UsesNonExemptEncryption))]
    public static T ToggleUsesNonExemptEncryption<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.UsesNonExemptEncryption, !o.UsesNonExemptEncryption));
    #endregion
    #region SkipConfirmation
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipConfirmation))]
    public static T SetSkipConfirmation<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipConfirmation))]
    public static T ResetSkipConfirmation<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.SkipConfirmation));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipConfirmation))]
    public static T EnableSkipConfirmation<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipConfirmation))]
    public static T DisableSkipConfirmation<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SkipConfirmation))]
    public static T ToggleSkipConfirmation<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, !o.SkipConfirmation));
    #endregion
    #region RejectBuilderWaitingForReview
    /// <inheritdoc cref="FastlaneDeliverSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.RejectBuilderWaitingForReview))]
    public static T SetRejectBuilderWaitingForReview<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.RejectBuilderWaitingForReview, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.RejectBuilderWaitingForReview))]
    public static T ResetRejectBuilderWaitingForReview<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.RejectBuilderWaitingForReview));
    /// <inheritdoc cref="FastlaneDeliverSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.RejectBuilderWaitingForReview))]
    public static T EnableRejectBuilderWaitingForReview<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.RejectBuilderWaitingForReview, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.RejectBuilderWaitingForReview))]
    public static T DisableRejectBuilderWaitingForReview<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.RejectBuilderWaitingForReview, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.RejectBuilderWaitingForReview))]
    public static T ToggleRejectBuilderWaitingForReview<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.RejectBuilderWaitingForReview, !o.RejectBuilderWaitingForReview));
    #endregion
    #region SubmitBetaReview
    /// <inheritdoc cref="FastlaneDeliverSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SubmitBetaReview))]
    public static T SetSubmitBetaReview<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SubmitBetaReview, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SubmitBetaReview))]
    public static T ResetSubmitBetaReview<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.SubmitBetaReview));
    /// <inheritdoc cref="FastlaneDeliverSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SubmitBetaReview))]
    public static T EnableSubmitBetaReview<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SubmitBetaReview, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SubmitBetaReview))]
    public static T DisableSubmitBetaReview<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SubmitBetaReview, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.SubmitBetaReview))]
    public static T ToggleSubmitBetaReview<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.SubmitBetaReview, !o.SubmitBetaReview));
    #endregion
    #region WaitProcessingInterval
    /// <inheritdoc cref="FastlaneDeliverSettings.WaitProcessingInterval"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.WaitProcessingInterval))]
    public static T SetWaitProcessingInterval<T>(this T o, int? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.WaitProcessingInterval, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.WaitProcessingInterval"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.WaitProcessingInterval))]
    public static T ResetWaitProcessingInterval<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.WaitProcessingInterval));
    #endregion
    #region WaitProcessingTimeoutDuration
    /// <inheritdoc cref="FastlaneDeliverSettings.WaitProcessingTimeoutDuration"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.WaitProcessingTimeoutDuration))]
    public static T SetWaitProcessingTimeoutDuration<T>(this T o, int? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.WaitProcessingTimeoutDuration, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.WaitProcessingTimeoutDuration"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.WaitProcessingTimeoutDuration))]
    public static T ResetWaitProcessingTimeoutDuration<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.WaitProcessingTimeoutDuration));
    #endregion
    #region AppStoreConnectApiKeyPath
    /// <inheritdoc cref="FastlaneDeliverSettings.AppStoreConnectApiKeyPath"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.AppStoreConnectApiKeyPath))]
    public static T SetAppStoreConnectApiKeyPath<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.AppStoreConnectApiKeyPath, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.AppStoreConnectApiKeyPath"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.AppStoreConnectApiKeyPath))]
    public static T ResetAppStoreConnectApiKeyPath<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.AppStoreConnectApiKeyPath));
    #endregion
    #region AppStoreConnectApiKey
    /// <inheritdoc cref="FastlaneDeliverSettings.AppStoreConnectApiKey"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.AppStoreConnectApiKey))]
    public static T SetAppStoreConnectApiKey<T>(this T o, [Secret] string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.AppStoreConnectApiKey, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.AppStoreConnectApiKey"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.AppStoreConnectApiKey))]
    public static T ResetAppStoreConnectApiKey<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.AppStoreConnectApiKey));
    #endregion
    #region Verbose
    /// <inheritdoc cref="FastlaneDeliverSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Verbose))]
    public static T SetVerbose<T>(this T o, bool? v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Verbose, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Verbose))]
    public static T ResetVerbose<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.Verbose));
    /// <inheritdoc cref="FastlaneDeliverSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Verbose))]
    public static T EnableVerbose<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Verbose, true));
    /// <inheritdoc cref="FastlaneDeliverSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Verbose))]
    public static T DisableVerbose<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Verbose, false));
    /// <inheritdoc cref="FastlaneDeliverSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Verbose))]
    public static T ToggleVerbose<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Verbose, !o.Verbose));
    #endregion
    #region Ipa
    /// <inheritdoc cref="FastlaneDeliverSettings.Ipa"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Ipa))]
    public static T SetIpa<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Ipa, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Ipa"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Ipa))]
    public static T ResetIpa<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.Ipa));
    #endregion
    #region Pkg
    /// <inheritdoc cref="FastlaneDeliverSettings.Pkg"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Pkg))]
    public static T SetPkg<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.Pkg, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.Pkg"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.Pkg))]
    public static T ResetPkg<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.Pkg));
    #endregion
    #region TeamId
    /// <inheritdoc cref="FastlaneDeliverSettings.TeamId"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.TeamId))]
    public static T SetTeamId<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.TeamId, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.TeamId"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.TeamId))]
    public static T ResetTeamId<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.TeamId));
    #endregion
    #region TeamName
    /// <inheritdoc cref="FastlaneDeliverSettings.TeamName"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.TeamName))]
    public static T SetTeamName<T>(this T o, string v) where T : FastlaneDeliverSettings => o.Modify(b => b.Set(() => o.TeamName, v));
    /// <inheritdoc cref="FastlaneDeliverSettings.TeamName"/>
    [Pure] [Builder(Type = typeof(FastlaneDeliverSettings), Property = nameof(FastlaneDeliverSettings.TeamName))]
    public static T ResetTeamName<T>(this T o) where T : FastlaneDeliverSettings => o.Modify(b => b.Remove(() => o.TeamName));
    #endregion
}
#endregion
#region FastlaneMatchSettingsExtensions
/// <inheritdoc cref="FastlaneTasks.FastlaneMatch(Nuke.Common.Tools.Fastlane.FastlaneMatchSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class FastlaneMatchSettingsExtensions
{
    #region AppIdentifier
    /// <inheritdoc cref="FastlaneMatchSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppIdentifier))]
    public static T SetAppIdentifier<T>(this T o, params string[] v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.AppIdentifier, v));
    /// <inheritdoc cref="FastlaneMatchSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppIdentifier))]
    public static T SetAppIdentifier<T>(this T o, IEnumerable<string> v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.AppIdentifier, v));
    /// <inheritdoc cref="FastlaneMatchSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppIdentifier))]
    public static T AddAppIdentifier<T>(this T o, params string[] v) where T : FastlaneMatchSettings => o.Modify(b => b.AddCollection(() => o.AppIdentifier, v));
    /// <inheritdoc cref="FastlaneMatchSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppIdentifier))]
    public static T AddAppIdentifier<T>(this T o, IEnumerable<string> v) where T : FastlaneMatchSettings => o.Modify(b => b.AddCollection(() => o.AppIdentifier, v));
    /// <inheritdoc cref="FastlaneMatchSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppIdentifier))]
    public static T RemoveAppIdentifier<T>(this T o, params string[] v) where T : FastlaneMatchSettings => o.Modify(b => b.RemoveCollection(() => o.AppIdentifier, v));
    /// <inheritdoc cref="FastlaneMatchSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppIdentifier))]
    public static T RemoveAppIdentifier<T>(this T o, IEnumerable<string> v) where T : FastlaneMatchSettings => o.Modify(b => b.RemoveCollection(() => o.AppIdentifier, v));
    /// <inheritdoc cref="FastlaneMatchSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppIdentifier))]
    public static T ClearAppIdentifier<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.ClearCollection(() => o.AppIdentifier));
    #endregion
    #region Username
    /// <inheritdoc cref="FastlaneMatchSettings.Username"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Username))]
    public static T SetUsername<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Username, v));
    /// <inheritdoc cref="FastlaneMatchSettings.Username"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Username))]
    public static T ResetUsername<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.Username));
    #endregion
    #region Type
    /// <inheritdoc cref="FastlaneMatchSettings.Type"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Type))]
    public static T SetType<T>(this T o, MatchProfile v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Type, v));
    /// <inheritdoc cref="FastlaneMatchSettings.Type"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Type))]
    public static T ResetType<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.Type));
    #endregion
    #region Force
    /// <inheritdoc cref="FastlaneMatchSettings.Force"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="FastlaneMatchSettings.Force"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Force))]
    public static T ResetForce<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="FastlaneMatchSettings.Force"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Force))]
    public static T EnableForce<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="FastlaneMatchSettings.Force"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Force))]
    public static T DisableForce<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="FastlaneMatchSettings.Force"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region IncludeAllCertificates
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeAllCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeAllCertificates))]
    public static T SetIncludeAllCertificates<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.IncludeAllCertificates, v));
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeAllCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeAllCertificates))]
    public static T ResetIncludeAllCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.IncludeAllCertificates));
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeAllCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeAllCertificates))]
    public static T EnableIncludeAllCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.IncludeAllCertificates, true));
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeAllCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeAllCertificates))]
    public static T DisableIncludeAllCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.IncludeAllCertificates, false));
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeAllCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeAllCertificates))]
    public static T ToggleIncludeAllCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.IncludeAllCertificates, !o.IncludeAllCertificates));
    #endregion
    #region ForceForNewCertificates
    /// <inheritdoc cref="FastlaneMatchSettings.ForceForNewCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.ForceForNewCertificates))]
    public static T SetForceForNewCertificates<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.ForceForNewCertificates, v));
    /// <inheritdoc cref="FastlaneMatchSettings.ForceForNewCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.ForceForNewCertificates))]
    public static T ResetForceForNewCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.ForceForNewCertificates));
    /// <inheritdoc cref="FastlaneMatchSettings.ForceForNewCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.ForceForNewCertificates))]
    public static T EnableForceForNewCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.ForceForNewCertificates, true));
    /// <inheritdoc cref="FastlaneMatchSettings.ForceForNewCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.ForceForNewCertificates))]
    public static T DisableForceForNewCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.ForceForNewCertificates, false));
    /// <inheritdoc cref="FastlaneMatchSettings.ForceForNewCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.ForceForNewCertificates))]
    public static T ToggleForceForNewCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.ForceForNewCertificates, !o.ForceForNewCertificates));
    #endregion
    #region SafeRemoveCertificates
    /// <inheritdoc cref="FastlaneMatchSettings.SafeRemoveCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SafeRemoveCertificates))]
    public static T SetSafeRemoveCertificates<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SafeRemoveCertificates, v));
    /// <inheritdoc cref="FastlaneMatchSettings.SafeRemoveCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SafeRemoveCertificates))]
    public static T ResetSafeRemoveCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.SafeRemoveCertificates));
    /// <inheritdoc cref="FastlaneMatchSettings.SafeRemoveCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SafeRemoveCertificates))]
    public static T EnableSafeRemoveCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SafeRemoveCertificates, true));
    /// <inheritdoc cref="FastlaneMatchSettings.SafeRemoveCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SafeRemoveCertificates))]
    public static T DisableSafeRemoveCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SafeRemoveCertificates, false));
    /// <inheritdoc cref="FastlaneMatchSettings.SafeRemoveCertificates"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SafeRemoveCertificates))]
    public static T ToggleSafeRemoveCertificates<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SafeRemoveCertificates, !o.SafeRemoveCertificates));
    #endregion
    #region SkipCertificateMatching
    /// <inheritdoc cref="FastlaneMatchSettings.SkipCertificateMatching"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipCertificateMatching))]
    public static T SetSkipCertificateMatching<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipCertificateMatching, v));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipCertificateMatching"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipCertificateMatching))]
    public static T ResetSkipCertificateMatching<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.SkipCertificateMatching));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipCertificateMatching"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipCertificateMatching))]
    public static T EnableSkipCertificateMatching<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipCertificateMatching, true));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipCertificateMatching"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipCertificateMatching))]
    public static T DisableSkipCertificateMatching<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipCertificateMatching, false));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipCertificateMatching"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipCertificateMatching))]
    public static T ToggleSkipCertificateMatching<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipCertificateMatching, !o.SkipCertificateMatching));
    #endregion
    #region Platform
    /// <inheritdoc cref="FastlaneMatchSettings.Platform"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Platform))]
    public static T SetPlatform<T>(this T o, ProvisioningPlatform v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Platform, v));
    /// <inheritdoc cref="FastlaneMatchSettings.Platform"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Platform))]
    public static T ResetPlatform<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.Platform));
    #endregion
    #region Readonly
    /// <inheritdoc cref="FastlaneMatchSettings.Readonly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Readonly))]
    public static T SetReadonly<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Readonly, v));
    /// <inheritdoc cref="FastlaneMatchSettings.Readonly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Readonly))]
    public static T ResetReadonly<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.Readonly));
    /// <inheritdoc cref="FastlaneMatchSettings.Readonly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Readonly))]
    public static T EnableReadonly<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Readonly, true));
    /// <inheritdoc cref="FastlaneMatchSettings.Readonly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Readonly))]
    public static T DisableReadonly<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Readonly, false));
    /// <inheritdoc cref="FastlaneMatchSettings.Readonly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Readonly))]
    public static T ToggleReadonly<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Readonly, !o.Readonly));
    #endregion
    #region SkipDocumentation
    /// <inheritdoc cref="FastlaneMatchSettings.SkipDocumentation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipDocumentation))]
    public static T SetSkipDocumentation<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipDocumentation, v));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipDocumentation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipDocumentation))]
    public static T ResetSkipDocumentation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.SkipDocumentation));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipDocumentation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipDocumentation))]
    public static T EnableSkipDocumentation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipDocumentation, true));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipDocumentation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipDocumentation))]
    public static T DisableSkipDocumentation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipDocumentation, false));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipDocumentation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipDocumentation))]
    public static T ToggleSkipDocumentation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipDocumentation, !o.SkipDocumentation));
    #endregion
    #region SkipConfirmation
    /// <inheritdoc cref="FastlaneMatchSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipConfirmation))]
    public static T SetSkipConfirmation<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, v));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipConfirmation))]
    public static T ResetSkipConfirmation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.SkipConfirmation));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipConfirmation))]
    public static T EnableSkipConfirmation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, true));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipConfirmation))]
    public static T DisableSkipConfirmation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, false));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipConfirmation))]
    public static T ToggleSkipConfirmation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, !o.SkipConfirmation));
    #endregion
    #region FailOnNameTaken
    /// <inheritdoc cref="FastlaneMatchSettings.FailOnNameTaken"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.FailOnNameTaken))]
    public static T SetFailOnNameTaken<T>(this T o, [Secret] string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.FailOnNameTaken, v));
    /// <inheritdoc cref="FastlaneMatchSettings.FailOnNameTaken"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.FailOnNameTaken))]
    public static T ResetFailOnNameTaken<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.FailOnNameTaken));
    #endregion
    #region DeriveCatalystApplicationIdentifier
    /// <inheritdoc cref="FastlaneMatchSettings.DeriveCatalystApplicationIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.DeriveCatalystApplicationIdentifier))]
    public static T SetDeriveCatalystApplicationIdentifier<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.DeriveCatalystApplicationIdentifier, v));
    /// <inheritdoc cref="FastlaneMatchSettings.DeriveCatalystApplicationIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.DeriveCatalystApplicationIdentifier))]
    public static T ResetDeriveCatalystApplicationIdentifier<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.DeriveCatalystApplicationIdentifier));
    /// <inheritdoc cref="FastlaneMatchSettings.DeriveCatalystApplicationIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.DeriveCatalystApplicationIdentifier))]
    public static T EnableDeriveCatalystApplicationIdentifier<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.DeriveCatalystApplicationIdentifier, true));
    /// <inheritdoc cref="FastlaneMatchSettings.DeriveCatalystApplicationIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.DeriveCatalystApplicationIdentifier))]
    public static T DisableDeriveCatalystApplicationIdentifier<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.DeriveCatalystApplicationIdentifier, false));
    /// <inheritdoc cref="FastlaneMatchSettings.DeriveCatalystApplicationIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.DeriveCatalystApplicationIdentifier))]
    public static T ToggleDeriveCatalystApplicationIdentifier<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.DeriveCatalystApplicationIdentifier, !o.DeriveCatalystApplicationIdentifier));
    #endregion
    #region IncludeMacInProfiles
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeMacInProfiles"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeMacInProfiles))]
    public static T SetIncludeMacInProfiles<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.IncludeMacInProfiles, v));
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeMacInProfiles"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeMacInProfiles))]
    public static T ResetIncludeMacInProfiles<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.IncludeMacInProfiles));
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeMacInProfiles"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeMacInProfiles))]
    public static T EnableIncludeMacInProfiles<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.IncludeMacInProfiles, true));
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeMacInProfiles"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeMacInProfiles))]
    public static T DisableIncludeMacInProfiles<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.IncludeMacInProfiles, false));
    /// <inheritdoc cref="FastlaneMatchSettings.IncludeMacInProfiles"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.IncludeMacInProfiles))]
    public static T ToggleIncludeMacInProfiles<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.IncludeMacInProfiles, !o.IncludeMacInProfiles));
    #endregion
    #region ProfileName
    /// <inheritdoc cref="FastlaneMatchSettings.ProfileName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.ProfileName))]
    public static T SetProfileName<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.ProfileName, v));
    /// <inheritdoc cref="FastlaneMatchSettings.ProfileName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.ProfileName))]
    public static T ResetProfileName<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.ProfileName));
    #endregion
    #region TemplateName
    /// <inheritdoc cref="FastlaneMatchSettings.TemplateName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.TemplateName))]
    public static T SetTemplateName<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.TemplateName, v));
    /// <inheritdoc cref="FastlaneMatchSettings.TemplateName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.TemplateName))]
    public static T ResetTemplateName<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.TemplateName));
    #endregion
    #region OutputPath
    /// <inheritdoc cref="FastlaneMatchSettings.OutputPath"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.OutputPath))]
    public static T SetOutputPath<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.OutputPath, v));
    /// <inheritdoc cref="FastlaneMatchSettings.OutputPath"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.OutputPath))]
    public static T ResetOutputPath<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.OutputPath));
    #endregion
    #region AppStoreConnectApiKeyPath
    /// <inheritdoc cref="FastlaneMatchSettings.AppStoreConnectApiKeyPath"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppStoreConnectApiKeyPath))]
    public static T SetAppStoreConnectApiKeyPath<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.AppStoreConnectApiKeyPath, v));
    /// <inheritdoc cref="FastlaneMatchSettings.AppStoreConnectApiKeyPath"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppStoreConnectApiKeyPath))]
    public static T ResetAppStoreConnectApiKeyPath<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.AppStoreConnectApiKeyPath));
    #endregion
    #region AppStoreConnectApiKey
    /// <inheritdoc cref="FastlaneMatchSettings.AppStoreConnectApiKey"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppStoreConnectApiKey))]
    public static T SetAppStoreConnectApiKey<T>(this T o, [Secret] string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.AppStoreConnectApiKey, v));
    /// <inheritdoc cref="FastlaneMatchSettings.AppStoreConnectApiKey"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.AppStoreConnectApiKey))]
    public static T ResetAppStoreConnectApiKey<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.AppStoreConnectApiKey));
    #endregion
    #region Verbose
    /// <inheritdoc cref="FastlaneMatchSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Verbose))]
    public static T SetVerbose<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Verbose, v));
    /// <inheritdoc cref="FastlaneMatchSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Verbose))]
    public static T ResetVerbose<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.Verbose));
    /// <inheritdoc cref="FastlaneMatchSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Verbose))]
    public static T EnableVerbose<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Verbose, true));
    /// <inheritdoc cref="FastlaneMatchSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Verbose))]
    public static T DisableVerbose<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Verbose, false));
    /// <inheritdoc cref="FastlaneMatchSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.Verbose))]
    public static T ToggleVerbose<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.Verbose, !o.Verbose));
    #endregion
    #region GitUrl
    /// <inheritdoc cref="FastlaneMatchSettings.GitUrl"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitUrl))]
    public static T SetGitUrl<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitUrl, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GitUrl"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitUrl))]
    public static T ResetGitUrl<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GitUrl));
    #endregion
    #region GitBranch
    /// <inheritdoc cref="FastlaneMatchSettings.GitBranch"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitBranch))]
    public static T SetGitBranch<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitBranch, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GitBranch"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitBranch))]
    public static T ResetGitBranch<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GitBranch));
    #endregion
    #region GitFullName
    /// <inheritdoc cref="FastlaneMatchSettings.GitFullName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitFullName))]
    public static T SetGitFullName<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitFullName, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GitFullName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitFullName))]
    public static T ResetGitFullName<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GitFullName));
    #endregion
    #region GitUserEmail
    /// <inheritdoc cref="FastlaneMatchSettings.GitUserEmail"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitUserEmail))]
    public static T SetGitUserEmail<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitUserEmail, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GitUserEmail"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitUserEmail))]
    public static T ResetGitUserEmail<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GitUserEmail));
    #endregion
    #region GitShallowClone
    /// <inheritdoc cref="FastlaneMatchSettings.GitShallowClone"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitShallowClone))]
    public static T SetGitShallowClone<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitShallowClone, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GitShallowClone"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitShallowClone))]
    public static T ResetGitShallowClone<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GitShallowClone));
    /// <inheritdoc cref="FastlaneMatchSettings.GitShallowClone"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitShallowClone))]
    public static T EnableGitShallowClone<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitShallowClone, true));
    /// <inheritdoc cref="FastlaneMatchSettings.GitShallowClone"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitShallowClone))]
    public static T DisableGitShallowClone<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitShallowClone, false));
    /// <inheritdoc cref="FastlaneMatchSettings.GitShallowClone"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitShallowClone))]
    public static T ToggleGitShallowClone<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitShallowClone, !o.GitShallowClone));
    #endregion
    #region GitCloneBranchDirectly
    /// <inheritdoc cref="FastlaneMatchSettings.GitCloneBranchDirectly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitCloneBranchDirectly))]
    public static T SetGitCloneBranchDirectly<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitCloneBranchDirectly, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GitCloneBranchDirectly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitCloneBranchDirectly))]
    public static T ResetGitCloneBranchDirectly<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GitCloneBranchDirectly));
    /// <inheritdoc cref="FastlaneMatchSettings.GitCloneBranchDirectly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitCloneBranchDirectly))]
    public static T EnableGitCloneBranchDirectly<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitCloneBranchDirectly, true));
    /// <inheritdoc cref="FastlaneMatchSettings.GitCloneBranchDirectly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitCloneBranchDirectly))]
    public static T DisableGitCloneBranchDirectly<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitCloneBranchDirectly, false));
    /// <inheritdoc cref="FastlaneMatchSettings.GitCloneBranchDirectly"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitCloneBranchDirectly))]
    public static T ToggleGitCloneBranchDirectly<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitCloneBranchDirectly, !o.GitCloneBranchDirectly));
    #endregion
    #region GitBasicAuthorization
    /// <inheritdoc cref="FastlaneMatchSettings.GitBasicAuthorization"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitBasicAuthorization))]
    public static T SetGitBasicAuthorization<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitBasicAuthorization, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GitBasicAuthorization"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitBasicAuthorization))]
    public static T ResetGitBasicAuthorization<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GitBasicAuthorization));
    #endregion
    #region GitBearerAuthorization
    /// <inheritdoc cref="FastlaneMatchSettings.GitBearerAuthorization"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitBearerAuthorization))]
    public static T SetGitBearerAuthorization<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitBearerAuthorization, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GitBearerAuthorization"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitBearerAuthorization))]
    public static T ResetGitBearerAuthorization<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GitBearerAuthorization));
    #endregion
    #region GitPrivateKey
    /// <inheritdoc cref="FastlaneMatchSettings.GitPrivateKey"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitPrivateKey))]
    public static T SetGitPrivateKey<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GitPrivateKey, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GitPrivateKey"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GitPrivateKey))]
    public static T ResetGitPrivateKey<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GitPrivateKey));
    #endregion
    #region GoogleCloudBucketName
    /// <inheritdoc cref="FastlaneMatchSettings.GoogleCloudBucketName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GoogleCloudBucketName))]
    public static T SetGoogleCloudBucketName<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GoogleCloudBucketName, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GoogleCloudBucketName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GoogleCloudBucketName))]
    public static T ResetGoogleCloudBucketName<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GoogleCloudBucketName));
    #endregion
    #region GoogleCloudKeys
    /// <inheritdoc cref="FastlaneMatchSettings.GoogleCloudKeys"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GoogleCloudKeys))]
    public static T SetGoogleCloudKeys<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GoogleCloudKeys, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GoogleCloudKeys"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GoogleCloudKeys))]
    public static T ResetGoogleCloudKeys<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GoogleCloudKeys));
    #endregion
    #region GoogleCloudProjectId
    /// <inheritdoc cref="FastlaneMatchSettings.GoogleCloudProjectId"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GoogleCloudProjectId))]
    public static T SetGoogleCloudProjectId<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.GoogleCloudProjectId, v));
    /// <inheritdoc cref="FastlaneMatchSettings.GoogleCloudProjectId"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.GoogleCloudProjectId))]
    public static T ResetGoogleCloudProjectId<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.GoogleCloudProjectId));
    #endregion
    #region SkipGoogleCloudAccountConfirmation
    /// <inheritdoc cref="FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation))]
    public static T SetSkipGoogleCloudAccountConfirmation<T>(this T o, bool? v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipGoogleCloudAccountConfirmation, v));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation))]
    public static T ResetSkipGoogleCloudAccountConfirmation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.SkipGoogleCloudAccountConfirmation));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation))]
    public static T EnableSkipGoogleCloudAccountConfirmation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipGoogleCloudAccountConfirmation, true));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation))]
    public static T DisableSkipGoogleCloudAccountConfirmation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipGoogleCloudAccountConfirmation, false));
    /// <inheritdoc cref="FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.SkipGoogleCloudAccountConfirmation))]
    public static T ToggleSkipGoogleCloudAccountConfirmation<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.SkipGoogleCloudAccountConfirmation, !o.SkipGoogleCloudAccountConfirmation));
    #endregion
    #region S3AccessKey
    /// <inheritdoc cref="FastlaneMatchSettings.S3AccessKey"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.S3AccessKey))]
    public static T SetS3AccessKey<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.S3AccessKey, v));
    /// <inheritdoc cref="FastlaneMatchSettings.S3AccessKey"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.S3AccessKey))]
    public static T ResetS3AccessKey<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.S3AccessKey));
    #endregion
    #region S3Bucket
    /// <inheritdoc cref="FastlaneMatchSettings.S3Bucket"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.S3Bucket))]
    public static T SetS3Bucket<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.S3Bucket, v));
    /// <inheritdoc cref="FastlaneMatchSettings.S3Bucket"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.S3Bucket))]
    public static T ResetS3Bucket<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.S3Bucket));
    #endregion
    #region S3ObjectPrefix
    /// <inheritdoc cref="FastlaneMatchSettings.S3ObjectPrefix"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.S3ObjectPrefix))]
    public static T SetS3ObjectPrefix<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.S3ObjectPrefix, v));
    /// <inheritdoc cref="FastlaneMatchSettings.S3ObjectPrefix"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.S3ObjectPrefix))]
    public static T ResetS3ObjectPrefix<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.S3ObjectPrefix));
    #endregion
    #region S3Region
    /// <inheritdoc cref="FastlaneMatchSettings.S3Region"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.S3Region))]
    public static T SetS3Region<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.S3Region, v));
    /// <inheritdoc cref="FastlaneMatchSettings.S3Region"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.S3Region))]
    public static T ResetS3Region<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.S3Region));
    #endregion
    #region TeamId
    /// <inheritdoc cref="FastlaneMatchSettings.TeamId"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.TeamId))]
    public static T SetTeamId<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.TeamId, v));
    /// <inheritdoc cref="FastlaneMatchSettings.TeamId"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.TeamId))]
    public static T ResetTeamId<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.TeamId));
    #endregion
    #region TeamName
    /// <inheritdoc cref="FastlaneMatchSettings.TeamName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.TeamName))]
    public static T SetTeamName<T>(this T o, string v) where T : FastlaneMatchSettings => o.Modify(b => b.Set(() => o.TeamName, v));
    /// <inheritdoc cref="FastlaneMatchSettings.TeamName"/>
    [Pure] [Builder(Type = typeof(FastlaneMatchSettings), Property = nameof(FastlaneMatchSettings.TeamName))]
    public static T ResetTeamName<T>(this T o) where T : FastlaneMatchSettings => o.Modify(b => b.Remove(() => o.TeamName));
    #endregion
}
#endregion
#region FastlanePilotSettingsExtensions
/// <inheritdoc cref="FastlaneTasks.FastlanePilot(Nuke.Common.Tools.Fastlane.FastlanePilotSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class FastlanePilotSettingsExtensions
{
    #region AppVersion
    /// <inheritdoc cref="FastlanePilotSettings.AppVersion"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppVersion))]
    public static T SetAppVersion<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.AppVersion, v));
    /// <inheritdoc cref="FastlanePilotSettings.AppVersion"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppVersion))]
    public static T ResetAppVersion<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.AppVersion));
    #endregion
    #region AppleId
    /// <inheritdoc cref="FastlanePilotSettings.AppleId"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppleId))]
    public static T SetAppleId<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.AppleId, v));
    /// <inheritdoc cref="FastlanePilotSettings.AppleId"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppleId))]
    public static T ResetAppleId<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.AppleId));
    #endregion
    #region AppIdentifier
    /// <inheritdoc cref="FastlanePilotSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppIdentifier))]
    public static T SetAppIdentifier<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.AppIdentifier, v));
    /// <inheritdoc cref="FastlanePilotSettings.AppIdentifier"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppIdentifier))]
    public static T ResetAppIdentifier<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.AppIdentifier));
    #endregion
    #region BuildNumber
    /// <inheritdoc cref="FastlanePilotSettings.BuildNumber"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.BuildNumber))]
    public static T SetBuildNumber<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.BuildNumber, v));
    /// <inheritdoc cref="FastlanePilotSettings.BuildNumber"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.BuildNumber))]
    public static T ResetBuildNumber<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.BuildNumber));
    #endregion
    #region ExpirePreviousBuilds
    /// <inheritdoc cref="FastlanePilotSettings.ExpirePreviousBuilds"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.ExpirePreviousBuilds))]
    public static T SetExpirePreviousBuilds<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.ExpirePreviousBuilds, v));
    /// <inheritdoc cref="FastlanePilotSettings.ExpirePreviousBuilds"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.ExpirePreviousBuilds))]
    public static T ResetExpirePreviousBuilds<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.ExpirePreviousBuilds));
    /// <inheritdoc cref="FastlanePilotSettings.ExpirePreviousBuilds"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.ExpirePreviousBuilds))]
    public static T EnableExpirePreviousBuilds<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.ExpirePreviousBuilds, true));
    /// <inheritdoc cref="FastlanePilotSettings.ExpirePreviousBuilds"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.ExpirePreviousBuilds))]
    public static T DisableExpirePreviousBuilds<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.ExpirePreviousBuilds, false));
    /// <inheritdoc cref="FastlanePilotSettings.ExpirePreviousBuilds"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.ExpirePreviousBuilds))]
    public static T ToggleExpirePreviousBuilds<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.ExpirePreviousBuilds, !o.ExpirePreviousBuilds));
    #endregion
    #region DemoAccountRequired
    /// <inheritdoc cref="FastlanePilotSettings.DemoAccountRequired"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DemoAccountRequired))]
    public static T SetDemoAccountRequired<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DemoAccountRequired, v));
    /// <inheritdoc cref="FastlanePilotSettings.DemoAccountRequired"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DemoAccountRequired))]
    public static T ResetDemoAccountRequired<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.DemoAccountRequired));
    /// <inheritdoc cref="FastlanePilotSettings.DemoAccountRequired"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DemoAccountRequired))]
    public static T EnableDemoAccountRequired<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DemoAccountRequired, true));
    /// <inheritdoc cref="FastlanePilotSettings.DemoAccountRequired"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DemoAccountRequired))]
    public static T DisableDemoAccountRequired<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DemoAccountRequired, false));
    /// <inheritdoc cref="FastlanePilotSettings.DemoAccountRequired"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DemoAccountRequired))]
    public static T ToggleDemoAccountRequired<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DemoAccountRequired, !o.DemoAccountRequired));
    #endregion
    #region DevPortalTeamId
    /// <inheritdoc cref="FastlanePilotSettings.DevPortalTeamId"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DevPortalTeamId))]
    public static T SetDevPortalTeamId<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DevPortalTeamId, v));
    /// <inheritdoc cref="FastlanePilotSettings.DevPortalTeamId"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DevPortalTeamId))]
    public static T ResetDevPortalTeamId<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.DevPortalTeamId));
    #endregion
    #region DevPortalTeamName
    /// <inheritdoc cref="FastlanePilotSettings.DevPortalTeamName"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DevPortalTeamName))]
    public static T SetDevPortalTeamName<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DevPortalTeamName, v));
    /// <inheritdoc cref="FastlanePilotSettings.DevPortalTeamName"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DevPortalTeamName))]
    public static T ResetDevPortalTeamName<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.DevPortalTeamName));
    #endregion
    #region ItcProvider
    /// <inheritdoc cref="FastlanePilotSettings.ItcProvider"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.ItcProvider))]
    public static T SetItcProvider<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.ItcProvider, v));
    /// <inheritdoc cref="FastlanePilotSettings.ItcProvider"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.ItcProvider))]
    public static T ResetItcProvider<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.ItcProvider));
    #endregion
    #region LocalizedAppInfo
    /// <inheritdoc cref="FastlanePilotSettings.LocalizedAppInfo"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.LocalizedAppInfo))]
    public static T SetLocalizedAppInfo<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.LocalizedAppInfo, v));
    /// <inheritdoc cref="FastlanePilotSettings.LocalizedAppInfo"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.LocalizedAppInfo))]
    public static T ResetLocalizedAppInfo<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.LocalizedAppInfo));
    #endregion
    #region Changelog
    /// <inheritdoc cref="FastlanePilotSettings.Changelog"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Changelog))]
    public static T SetChangelog<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Changelog, v));
    /// <inheritdoc cref="FastlanePilotSettings.Changelog"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Changelog))]
    public static T ResetChangelog<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.Changelog));
    #endregion
    #region SkipSubmission
    /// <inheritdoc cref="FastlanePilotSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipSubmission))]
    public static T SetSkipSubmission<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipSubmission, v));
    /// <inheritdoc cref="FastlanePilotSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipSubmission))]
    public static T ResetSkipSubmission<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.SkipSubmission));
    /// <inheritdoc cref="FastlanePilotSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipSubmission))]
    public static T EnableSkipSubmission<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipSubmission, true));
    /// <inheritdoc cref="FastlanePilotSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipSubmission))]
    public static T DisableSkipSubmission<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipSubmission, false));
    /// <inheritdoc cref="FastlanePilotSettings.SkipSubmission"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipSubmission))]
    public static T ToggleSkipSubmission<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipSubmission, !o.SkipSubmission));
    #endregion
    #region SkipWaitingForBuildProcessing
    /// <inheritdoc cref="FastlanePilotSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipWaitingForBuildProcessing))]
    public static T SetSkipWaitingForBuildProcessing<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipWaitingForBuildProcessing, v));
    /// <inheritdoc cref="FastlanePilotSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipWaitingForBuildProcessing))]
    public static T ResetSkipWaitingForBuildProcessing<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.SkipWaitingForBuildProcessing));
    /// <inheritdoc cref="FastlanePilotSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipWaitingForBuildProcessing))]
    public static T EnableSkipWaitingForBuildProcessing<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipWaitingForBuildProcessing, true));
    /// <inheritdoc cref="FastlanePilotSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipWaitingForBuildProcessing))]
    public static T DisableSkipWaitingForBuildProcessing<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipWaitingForBuildProcessing, false));
    /// <inheritdoc cref="FastlanePilotSettings.SkipWaitingForBuildProcessing"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipWaitingForBuildProcessing))]
    public static T ToggleSkipWaitingForBuildProcessing<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipWaitingForBuildProcessing, !o.SkipWaitingForBuildProcessing));
    #endregion
    #region DistributeExternal
    /// <inheritdoc cref="FastlanePilotSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeExternal))]
    public static T SetDistributeExternal<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DistributeExternal, v));
    /// <inheritdoc cref="FastlanePilotSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeExternal))]
    public static T ResetDistributeExternal<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.DistributeExternal));
    /// <inheritdoc cref="FastlanePilotSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeExternal))]
    public static T EnableDistributeExternal<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DistributeExternal, true));
    /// <inheritdoc cref="FastlanePilotSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeExternal))]
    public static T DisableDistributeExternal<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DistributeExternal, false));
    /// <inheritdoc cref="FastlanePilotSettings.DistributeExternal"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeExternal))]
    public static T ToggleDistributeExternal<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DistributeExternal, !o.DistributeExternal));
    #endregion
    #region DistributeOnly
    /// <inheritdoc cref="FastlanePilotSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeOnly))]
    public static T SetDistributeOnly<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DistributeOnly, v));
    /// <inheritdoc cref="FastlanePilotSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeOnly))]
    public static T ResetDistributeOnly<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.DistributeOnly));
    /// <inheritdoc cref="FastlanePilotSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeOnly))]
    public static T EnableDistributeOnly<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DistributeOnly, true));
    /// <inheritdoc cref="FastlanePilotSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeOnly))]
    public static T DisableDistributeOnly<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DistributeOnly, false));
    /// <inheritdoc cref="FastlanePilotSettings.DistributeOnly"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.DistributeOnly))]
    public static T ToggleDistributeOnly<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.DistributeOnly, !o.DistributeOnly));
    #endregion
    #region NotifyExternalTesters
    /// <inheritdoc cref="FastlanePilotSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.NotifyExternalTesters))]
    public static T SetNotifyExternalTesters<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.NotifyExternalTesters, v));
    /// <inheritdoc cref="FastlanePilotSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.NotifyExternalTesters))]
    public static T ResetNotifyExternalTesters<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.NotifyExternalTesters));
    /// <inheritdoc cref="FastlanePilotSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.NotifyExternalTesters))]
    public static T EnableNotifyExternalTesters<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.NotifyExternalTesters, true));
    /// <inheritdoc cref="FastlanePilotSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.NotifyExternalTesters))]
    public static T DisableNotifyExternalTesters<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.NotifyExternalTesters, false));
    /// <inheritdoc cref="FastlanePilotSettings.NotifyExternalTesters"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.NotifyExternalTesters))]
    public static T ToggleNotifyExternalTesters<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.NotifyExternalTesters, !o.NotifyExternalTesters));
    #endregion
    #region Groups
    /// <inheritdoc cref="FastlanePilotSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Groups))]
    public static T SetGroups<T>(this T o, params string[] v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Groups, v));
    /// <inheritdoc cref="FastlanePilotSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Groups))]
    public static T SetGroups<T>(this T o, IEnumerable<string> v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Groups, v));
    /// <inheritdoc cref="FastlanePilotSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Groups))]
    public static T AddGroups<T>(this T o, params string[] v) where T : FastlanePilotSettings => o.Modify(b => b.AddCollection(() => o.Groups, v));
    /// <inheritdoc cref="FastlanePilotSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Groups))]
    public static T AddGroups<T>(this T o, IEnumerable<string> v) where T : FastlanePilotSettings => o.Modify(b => b.AddCollection(() => o.Groups, v));
    /// <inheritdoc cref="FastlanePilotSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Groups))]
    public static T RemoveGroups<T>(this T o, params string[] v) where T : FastlanePilotSettings => o.Modify(b => b.RemoveCollection(() => o.Groups, v));
    /// <inheritdoc cref="FastlanePilotSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Groups))]
    public static T RemoveGroups<T>(this T o, IEnumerable<string> v) where T : FastlanePilotSettings => o.Modify(b => b.RemoveCollection(() => o.Groups, v));
    /// <inheritdoc cref="FastlanePilotSettings.Groups"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Groups))]
    public static T ClearGroups<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.ClearCollection(() => o.Groups));
    #endregion
    #region UsesNonExemptEncryption
    /// <inheritdoc cref="FastlanePilotSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.UsesNonExemptEncryption))]
    public static T SetUsesNonExemptEncryption<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.UsesNonExemptEncryption, v));
    /// <inheritdoc cref="FastlanePilotSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.UsesNonExemptEncryption))]
    public static T ResetUsesNonExemptEncryption<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.UsesNonExemptEncryption));
    /// <inheritdoc cref="FastlanePilotSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.UsesNonExemptEncryption))]
    public static T EnableUsesNonExemptEncryption<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.UsesNonExemptEncryption, true));
    /// <inheritdoc cref="FastlanePilotSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.UsesNonExemptEncryption))]
    public static T DisableUsesNonExemptEncryption<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.UsesNonExemptEncryption, false));
    /// <inheritdoc cref="FastlanePilotSettings.UsesNonExemptEncryption"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.UsesNonExemptEncryption))]
    public static T ToggleUsesNonExemptEncryption<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.UsesNonExemptEncryption, !o.UsesNonExemptEncryption));
    #endregion
    #region SkipConfirmation
    /// <inheritdoc cref="FastlanePilotSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipConfirmation))]
    public static T SetSkipConfirmation<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, v));
    /// <inheritdoc cref="FastlanePilotSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipConfirmation))]
    public static T ResetSkipConfirmation<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.SkipConfirmation));
    /// <inheritdoc cref="FastlanePilotSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipConfirmation))]
    public static T EnableSkipConfirmation<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, true));
    /// <inheritdoc cref="FastlanePilotSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipConfirmation))]
    public static T DisableSkipConfirmation<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, false));
    /// <inheritdoc cref="FastlanePilotSettings.SkipConfirmation"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SkipConfirmation))]
    public static T ToggleSkipConfirmation<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SkipConfirmation, !o.SkipConfirmation));
    #endregion
    #region RejectBuilderWaitingForReview
    /// <inheritdoc cref="FastlanePilotSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.RejectBuilderWaitingForReview))]
    public static T SetRejectBuilderWaitingForReview<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.RejectBuilderWaitingForReview, v));
    /// <inheritdoc cref="FastlanePilotSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.RejectBuilderWaitingForReview))]
    public static T ResetRejectBuilderWaitingForReview<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.RejectBuilderWaitingForReview));
    /// <inheritdoc cref="FastlanePilotSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.RejectBuilderWaitingForReview))]
    public static T EnableRejectBuilderWaitingForReview<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.RejectBuilderWaitingForReview, true));
    /// <inheritdoc cref="FastlanePilotSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.RejectBuilderWaitingForReview))]
    public static T DisableRejectBuilderWaitingForReview<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.RejectBuilderWaitingForReview, false));
    /// <inheritdoc cref="FastlanePilotSettings.RejectBuilderWaitingForReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.RejectBuilderWaitingForReview))]
    public static T ToggleRejectBuilderWaitingForReview<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.RejectBuilderWaitingForReview, !o.RejectBuilderWaitingForReview));
    #endregion
    #region SubmitBetaReview
    /// <inheritdoc cref="FastlanePilotSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SubmitBetaReview))]
    public static T SetSubmitBetaReview<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SubmitBetaReview, v));
    /// <inheritdoc cref="FastlanePilotSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SubmitBetaReview))]
    public static T ResetSubmitBetaReview<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.SubmitBetaReview));
    /// <inheritdoc cref="FastlanePilotSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SubmitBetaReview))]
    public static T EnableSubmitBetaReview<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SubmitBetaReview, true));
    /// <inheritdoc cref="FastlanePilotSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SubmitBetaReview))]
    public static T DisableSubmitBetaReview<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SubmitBetaReview, false));
    /// <inheritdoc cref="FastlanePilotSettings.SubmitBetaReview"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.SubmitBetaReview))]
    public static T ToggleSubmitBetaReview<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.SubmitBetaReview, !o.SubmitBetaReview));
    #endregion
    #region WaitProcessingInterval
    /// <inheritdoc cref="FastlanePilotSettings.WaitProcessingInterval"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.WaitProcessingInterval))]
    public static T SetWaitProcessingInterval<T>(this T o, int? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.WaitProcessingInterval, v));
    /// <inheritdoc cref="FastlanePilotSettings.WaitProcessingInterval"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.WaitProcessingInterval))]
    public static T ResetWaitProcessingInterval<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.WaitProcessingInterval));
    #endregion
    #region WaitProcessingTimeoutDuration
    /// <inheritdoc cref="FastlanePilotSettings.WaitProcessingTimeoutDuration"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.WaitProcessingTimeoutDuration))]
    public static T SetWaitProcessingTimeoutDuration<T>(this T o, int? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.WaitProcessingTimeoutDuration, v));
    /// <inheritdoc cref="FastlanePilotSettings.WaitProcessingTimeoutDuration"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.WaitProcessingTimeoutDuration))]
    public static T ResetWaitProcessingTimeoutDuration<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.WaitProcessingTimeoutDuration));
    #endregion
    #region AppStoreConnectApiKeyPath
    /// <inheritdoc cref="FastlanePilotSettings.AppStoreConnectApiKeyPath"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppStoreConnectApiKeyPath))]
    public static T SetAppStoreConnectApiKeyPath<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.AppStoreConnectApiKeyPath, v));
    /// <inheritdoc cref="FastlanePilotSettings.AppStoreConnectApiKeyPath"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppStoreConnectApiKeyPath))]
    public static T ResetAppStoreConnectApiKeyPath<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.AppStoreConnectApiKeyPath));
    #endregion
    #region AppStoreConnectApiKey
    /// <inheritdoc cref="FastlanePilotSettings.AppStoreConnectApiKey"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppStoreConnectApiKey))]
    public static T SetAppStoreConnectApiKey<T>(this T o, [Secret] string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.AppStoreConnectApiKey, v));
    /// <inheritdoc cref="FastlanePilotSettings.AppStoreConnectApiKey"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.AppStoreConnectApiKey))]
    public static T ResetAppStoreConnectApiKey<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.AppStoreConnectApiKey));
    #endregion
    #region Username
    /// <inheritdoc cref="FastlanePilotSettings.Username"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Username))]
    public static T SetUsername<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Username, v));
    /// <inheritdoc cref="FastlanePilotSettings.Username"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Username))]
    public static T ResetUsername<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.Username));
    #endregion
    #region Verbose
    /// <inheritdoc cref="FastlanePilotSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Verbose))]
    public static T SetVerbose<T>(this T o, bool? v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Verbose, v));
    /// <inheritdoc cref="FastlanePilotSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Verbose))]
    public static T ResetVerbose<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.Verbose));
    /// <inheritdoc cref="FastlanePilotSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Verbose))]
    public static T EnableVerbose<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Verbose, true));
    /// <inheritdoc cref="FastlanePilotSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Verbose))]
    public static T DisableVerbose<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Verbose, false));
    /// <inheritdoc cref="FastlanePilotSettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Verbose))]
    public static T ToggleVerbose<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Verbose, !o.Verbose));
    #endregion
    #region Ipa
    /// <inheritdoc cref="FastlanePilotSettings.Ipa"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Ipa))]
    public static T SetIpa<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Ipa, v));
    /// <inheritdoc cref="FastlanePilotSettings.Ipa"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Ipa))]
    public static T ResetIpa<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.Ipa));
    #endregion
    #region Pkg
    /// <inheritdoc cref="FastlanePilotSettings.Pkg"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Pkg))]
    public static T SetPkg<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.Pkg, v));
    /// <inheritdoc cref="FastlanePilotSettings.Pkg"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.Pkg))]
    public static T ResetPkg<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.Pkg));
    #endregion
    #region TeamId
    /// <inheritdoc cref="FastlanePilotSettings.TeamId"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.TeamId))]
    public static T SetTeamId<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.TeamId, v));
    /// <inheritdoc cref="FastlanePilotSettings.TeamId"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.TeamId))]
    public static T ResetTeamId<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.TeamId));
    #endregion
    #region TeamName
    /// <inheritdoc cref="FastlanePilotSettings.TeamName"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.TeamName))]
    public static T SetTeamName<T>(this T o, string v) where T : FastlanePilotSettings => o.Modify(b => b.Set(() => o.TeamName, v));
    /// <inheritdoc cref="FastlanePilotSettings.TeamName"/>
    [Pure] [Builder(Type = typeof(FastlanePilotSettings), Property = nameof(FastlanePilotSettings.TeamName))]
    public static T ResetTeamName<T>(this T o) where T : FastlanePilotSettings => o.Modify(b => b.Remove(() => o.TeamName));
    #endregion
}
#endregion
#region FastlaneSupplySettingsExtensions
/// <inheritdoc cref="FastlaneTasks.FastlaneSupply(Nuke.Common.Tools.Fastlane.FastlaneSupplySettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class FastlaneSupplySettingsExtensions
{
    #region PackageName
    /// <inheritdoc cref="FastlaneSupplySettings.PackageName"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.PackageName))]
    public static T SetPackageName<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.PackageName, v));
    /// <inheritdoc cref="FastlaneSupplySettings.PackageName"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.PackageName))]
    public static T ResetPackageName<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.PackageName));
    #endregion
    #region VersionName
    /// <inheritdoc cref="FastlaneSupplySettings.VersionName"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionName))]
    public static T SetVersionName<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.VersionName, v));
    /// <inheritdoc cref="FastlaneSupplySettings.VersionName"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionName))]
    public static T ResetVersionName<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.VersionName));
    #endregion
    #region VersionCode
    /// <inheritdoc cref="FastlaneSupplySettings.VersionCode"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionCode))]
    public static T SetVersionCode<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.VersionCode, v));
    /// <inheritdoc cref="FastlaneSupplySettings.VersionCode"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionCode))]
    public static T ResetVersionCode<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.VersionCode));
    #endregion
    #region ReleaseStatus
    /// <inheritdoc cref="FastlaneSupplySettings.ReleaseStatus"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ReleaseStatus))]
    public static T SetReleaseStatus<T>(this T o, GooglePlayStoreReleaseStatus v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ReleaseStatus, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ReleaseStatus"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ReleaseStatus))]
    public static T ResetReleaseStatus<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.ReleaseStatus));
    #endregion
    #region Track
    /// <inheritdoc cref="FastlaneSupplySettings.Track"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Track))]
    public static T SetTrack<T>(this T o, GooglePlayStoreTrack v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Track, v));
    /// <inheritdoc cref="FastlaneSupplySettings.Track"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Track))]
    public static T ResetTrack<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.Track));
    #endregion
    #region Rollout
    /// <inheritdoc cref="FastlaneSupplySettings.Rollout"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Rollout))]
    public static T SetRollout<T>(this T o, double? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Rollout, v));
    /// <inheritdoc cref="FastlaneSupplySettings.Rollout"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Rollout))]
    public static T ResetRollout<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.Rollout));
    #endregion
    #region MetadataPath
    /// <inheritdoc cref="FastlaneSupplySettings.MetadataPath"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.MetadataPath))]
    public static T SetMetadataPath<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.MetadataPath, v));
    /// <inheritdoc cref="FastlaneSupplySettings.MetadataPath"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.MetadataPath))]
    public static T ResetMetadataPath<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.MetadataPath));
    #endregion
    #region JsonKey
    /// <inheritdoc cref="FastlaneSupplySettings.JsonKey"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.JsonKey))]
    public static T SetJsonKey<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.JsonKey, v));
    /// <inheritdoc cref="FastlaneSupplySettings.JsonKey"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.JsonKey))]
    public static T ResetJsonKey<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.JsonKey));
    #endregion
    #region JsonKeyData
    /// <inheritdoc cref="FastlaneSupplySettings.JsonKeyData"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.JsonKeyData))]
    public static T SetJsonKeyData<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.JsonKeyData, v));
    /// <inheritdoc cref="FastlaneSupplySettings.JsonKeyData"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.JsonKeyData))]
    public static T ResetJsonKeyData<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.JsonKeyData));
    #endregion
    #region Apk
    /// <inheritdoc cref="FastlaneSupplySettings.Apk"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Apk))]
    public static T SetApk<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Apk, v));
    /// <inheritdoc cref="FastlaneSupplySettings.Apk"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Apk))]
    public static T ResetApk<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.Apk));
    #endregion
    #region ApkPaths
    /// <inheritdoc cref="FastlaneSupplySettings.ApkPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ApkPaths))]
    public static T SetApkPaths<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ApkPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ApkPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ApkPaths))]
    public static T SetApkPaths<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ApkPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ApkPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ApkPaths))]
    public static T AddApkPaths<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.AddCollection(() => o.ApkPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ApkPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ApkPaths))]
    public static T AddApkPaths<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.AddCollection(() => o.ApkPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ApkPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ApkPaths))]
    public static T RemoveApkPaths<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.RemoveCollection(() => o.ApkPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ApkPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ApkPaths))]
    public static T RemoveApkPaths<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.RemoveCollection(() => o.ApkPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ApkPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ApkPaths))]
    public static T ClearApkPaths<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.ClearCollection(() => o.ApkPaths));
    #endregion
    #region Aab
    /// <inheritdoc cref="FastlaneSupplySettings.Aab"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Aab))]
    public static T SetAab<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Aab, v));
    /// <inheritdoc cref="FastlaneSupplySettings.Aab"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Aab))]
    public static T ResetAab<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.Aab));
    #endregion
    #region AabPaths
    /// <inheritdoc cref="FastlaneSupplySettings.AabPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AabPaths))]
    public static T SetAabPaths<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.AabPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.AabPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AabPaths))]
    public static T SetAabPaths<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.AabPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.AabPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AabPaths))]
    public static T AddAabPaths<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.AddCollection(() => o.AabPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.AabPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AabPaths))]
    public static T AddAabPaths<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.AddCollection(() => o.AabPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.AabPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AabPaths))]
    public static T RemoveAabPaths<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.RemoveCollection(() => o.AabPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.AabPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AabPaths))]
    public static T RemoveAabPaths<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.RemoveCollection(() => o.AabPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.AabPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AabPaths))]
    public static T ClearAabPaths<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.ClearCollection(() => o.AabPaths));
    #endregion
    #region SkipUploadApk
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadApk"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadApk))]
    public static T SetSkipUploadApk<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadApk, v));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadApk"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadApk))]
    public static T ResetSkipUploadApk<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.SkipUploadApk));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadApk"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadApk))]
    public static T EnableSkipUploadApk<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadApk, true));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadApk"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadApk))]
    public static T DisableSkipUploadApk<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadApk, false));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadApk"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadApk))]
    public static T ToggleSkipUploadApk<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadApk, !o.SkipUploadApk));
    #endregion
    #region SkipUploadAab
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadAab"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadAab))]
    public static T SetSkipUploadAab<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadAab, v));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadAab"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadAab))]
    public static T ResetSkipUploadAab<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.SkipUploadAab));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadAab"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadAab))]
    public static T EnableSkipUploadAab<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadAab, true));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadAab"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadAab))]
    public static T DisableSkipUploadAab<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadAab, false));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadAab"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadAab))]
    public static T ToggleSkipUploadAab<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadAab, !o.SkipUploadAab));
    #endregion
    #region SkipUploadMetadata
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadMetadata"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadMetadata))]
    public static T SetSkipUploadMetadata<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadMetadata, v));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadMetadata"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadMetadata))]
    public static T ResetSkipUploadMetadata<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.SkipUploadMetadata));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadMetadata"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadMetadata))]
    public static T EnableSkipUploadMetadata<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadMetadata, true));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadMetadata"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadMetadata))]
    public static T DisableSkipUploadMetadata<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadMetadata, false));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadMetadata"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadMetadata))]
    public static T ToggleSkipUploadMetadata<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadMetadata, !o.SkipUploadMetadata));
    #endregion
    #region SkipUploadChangelogs
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadChangelogs"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadChangelogs))]
    public static T SetSkipUploadChangelogs<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadChangelogs, v));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadChangelogs"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadChangelogs))]
    public static T ResetSkipUploadChangelogs<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.SkipUploadChangelogs));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadChangelogs"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadChangelogs))]
    public static T EnableSkipUploadChangelogs<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadChangelogs, true));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadChangelogs"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadChangelogs))]
    public static T DisableSkipUploadChangelogs<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadChangelogs, false));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadChangelogs"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadChangelogs))]
    public static T ToggleSkipUploadChangelogs<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadChangelogs, !o.SkipUploadChangelogs));
    #endregion
    #region SkipUploadImages
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadImages"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadImages))]
    public static T SetSkipUploadImages<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadImages, v));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadImages"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadImages))]
    public static T ResetSkipUploadImages<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.SkipUploadImages));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadImages"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadImages))]
    public static T EnableSkipUploadImages<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadImages, true));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadImages"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadImages))]
    public static T DisableSkipUploadImages<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadImages, false));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadImages"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadImages))]
    public static T ToggleSkipUploadImages<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadImages, !o.SkipUploadImages));
    #endregion
    #region SkipUploadScreenshots
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadScreenshots"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadScreenshots))]
    public static T SetSkipUploadScreenshots<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadScreenshots, v));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadScreenshots"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadScreenshots))]
    public static T ResetSkipUploadScreenshots<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.SkipUploadScreenshots));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadScreenshots"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadScreenshots))]
    public static T EnableSkipUploadScreenshots<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadScreenshots, true));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadScreenshots"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadScreenshots))]
    public static T DisableSkipUploadScreenshots<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadScreenshots, false));
    /// <inheritdoc cref="FastlaneSupplySettings.SkipUploadScreenshots"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.SkipUploadScreenshots))]
    public static T ToggleSkipUploadScreenshots<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.SkipUploadScreenshots, !o.SkipUploadScreenshots));
    #endregion
    #region TrackToPromote
    /// <inheritdoc cref="FastlaneSupplySettings.TrackToPromote"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.TrackToPromote))]
    public static T SetTrackToPromote<T>(this T o, GooglePlayStoreTrack v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.TrackToPromote, v));
    /// <inheritdoc cref="FastlaneSupplySettings.TrackToPromote"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.TrackToPromote))]
    public static T ResetTrackToPromote<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.TrackToPromote));
    #endregion
    #region PromotedTrackReleaseStatus
    /// <inheritdoc cref="FastlaneSupplySettings.PromotedTrackReleaseStatus"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.PromotedTrackReleaseStatus))]
    public static T SetPromotedTrackReleaseStatus<T>(this T o, GooglePlayStoreReleaseStatus v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.PromotedTrackReleaseStatus, v));
    /// <inheritdoc cref="FastlaneSupplySettings.PromotedTrackReleaseStatus"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.PromotedTrackReleaseStatus))]
    public static T ResetPromotedTrackReleaseStatus<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.PromotedTrackReleaseStatus));
    #endregion
    #region ValidateOnly
    /// <inheritdoc cref="FastlaneSupplySettings.ValidateOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ValidateOnly))]
    public static T SetValidateOnly<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ValidateOnly, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ValidateOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ValidateOnly))]
    public static T ResetValidateOnly<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.ValidateOnly));
    /// <inheritdoc cref="FastlaneSupplySettings.ValidateOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ValidateOnly))]
    public static T EnableValidateOnly<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ValidateOnly, true));
    /// <inheritdoc cref="FastlaneSupplySettings.ValidateOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ValidateOnly))]
    public static T DisableValidateOnly<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ValidateOnly, false));
    /// <inheritdoc cref="FastlaneSupplySettings.ValidateOnly"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ValidateOnly))]
    public static T ToggleValidateOnly<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ValidateOnly, !o.ValidateOnly));
    #endregion
    #region Mapping
    /// <inheritdoc cref="FastlaneSupplySettings.Mapping"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Mapping))]
    public static T SetMapping<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Mapping, v));
    /// <inheritdoc cref="FastlaneSupplySettings.Mapping"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Mapping))]
    public static T ResetMapping<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.Mapping));
    #endregion
    #region MappingPaths
    /// <inheritdoc cref="FastlaneSupplySettings.MappingPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.MappingPaths))]
    public static T SetMappingPaths<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.MappingPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.MappingPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.MappingPaths))]
    public static T SetMappingPaths<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.MappingPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.MappingPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.MappingPaths))]
    public static T AddMappingPaths<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.AddCollection(() => o.MappingPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.MappingPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.MappingPaths))]
    public static T AddMappingPaths<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.AddCollection(() => o.MappingPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.MappingPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.MappingPaths))]
    public static T RemoveMappingPaths<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.RemoveCollection(() => o.MappingPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.MappingPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.MappingPaths))]
    public static T RemoveMappingPaths<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.RemoveCollection(() => o.MappingPaths, v));
    /// <inheritdoc cref="FastlaneSupplySettings.MappingPaths"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.MappingPaths))]
    public static T ClearMappingPaths<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.ClearCollection(() => o.MappingPaths));
    #endregion
    #region RootUrl
    /// <inheritdoc cref="FastlaneSupplySettings.RootUrl"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.RootUrl))]
    public static T SetRootUrl<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.RootUrl, v));
    /// <inheritdoc cref="FastlaneSupplySettings.RootUrl"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.RootUrl))]
    public static T ResetRootUrl<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.RootUrl));
    #endregion
    #region Timeout
    /// <inheritdoc cref="FastlaneSupplySettings.Timeout"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Timeout))]
    public static T SetTimeout<T>(this T o, int? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="FastlaneSupplySettings.Timeout"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
    #region VersionCodesToRetain
    /// <inheritdoc cref="FastlaneSupplySettings.VersionCodesToRetain"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionCodesToRetain))]
    public static T SetVersionCodesToRetain<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.VersionCodesToRetain, v));
    /// <inheritdoc cref="FastlaneSupplySettings.VersionCodesToRetain"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionCodesToRetain))]
    public static T SetVersionCodesToRetain<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.VersionCodesToRetain, v));
    /// <inheritdoc cref="FastlaneSupplySettings.VersionCodesToRetain"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionCodesToRetain))]
    public static T AddVersionCodesToRetain<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.AddCollection(() => o.VersionCodesToRetain, v));
    /// <inheritdoc cref="FastlaneSupplySettings.VersionCodesToRetain"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionCodesToRetain))]
    public static T AddVersionCodesToRetain<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.AddCollection(() => o.VersionCodesToRetain, v));
    /// <inheritdoc cref="FastlaneSupplySettings.VersionCodesToRetain"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionCodesToRetain))]
    public static T RemoveVersionCodesToRetain<T>(this T o, params string[] v) where T : FastlaneSupplySettings => o.Modify(b => b.RemoveCollection(() => o.VersionCodesToRetain, v));
    /// <inheritdoc cref="FastlaneSupplySettings.VersionCodesToRetain"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionCodesToRetain))]
    public static T RemoveVersionCodesToRetain<T>(this T o, IEnumerable<string> v) where T : FastlaneSupplySettings => o.Modify(b => b.RemoveCollection(() => o.VersionCodesToRetain, v));
    /// <inheritdoc cref="FastlaneSupplySettings.VersionCodesToRetain"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.VersionCodesToRetain))]
    public static T ClearVersionCodesToRetain<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.ClearCollection(() => o.VersionCodesToRetain));
    #endregion
    #region ChangesNotSentForReview
    /// <inheritdoc cref="FastlaneSupplySettings.ChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ChangesNotSentForReview))]
    public static T SetChangesNotSentForReview<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ChangesNotSentForReview, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ChangesNotSentForReview))]
    public static T ResetChangesNotSentForReview<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.ChangesNotSentForReview));
    /// <inheritdoc cref="FastlaneSupplySettings.ChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ChangesNotSentForReview))]
    public static T EnableChangesNotSentForReview<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ChangesNotSentForReview, true));
    /// <inheritdoc cref="FastlaneSupplySettings.ChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ChangesNotSentForReview))]
    public static T DisableChangesNotSentForReview<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ChangesNotSentForReview, false));
    /// <inheritdoc cref="FastlaneSupplySettings.ChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ChangesNotSentForReview))]
    public static T ToggleChangesNotSentForReview<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ChangesNotSentForReview, !o.ChangesNotSentForReview));
    #endregion
    #region RescueChangesNotSentForReview
    /// <inheritdoc cref="FastlaneSupplySettings.RescueChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.RescueChangesNotSentForReview))]
    public static T SetRescueChangesNotSentForReview<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.RescueChangesNotSentForReview, v));
    /// <inheritdoc cref="FastlaneSupplySettings.RescueChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.RescueChangesNotSentForReview))]
    public static T ResetRescueChangesNotSentForReview<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.RescueChangesNotSentForReview));
    /// <inheritdoc cref="FastlaneSupplySettings.RescueChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.RescueChangesNotSentForReview))]
    public static T EnableRescueChangesNotSentForReview<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.RescueChangesNotSentForReview, true));
    /// <inheritdoc cref="FastlaneSupplySettings.RescueChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.RescueChangesNotSentForReview))]
    public static T DisableRescueChangesNotSentForReview<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.RescueChangesNotSentForReview, false));
    /// <inheritdoc cref="FastlaneSupplySettings.RescueChangesNotSentForReview"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.RescueChangesNotSentForReview))]
    public static T ToggleRescueChangesNotSentForReview<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.RescueChangesNotSentForReview, !o.RescueChangesNotSentForReview));
    #endregion
    #region InAppUpdatePriority
    /// <inheritdoc cref="FastlaneSupplySettings.InAppUpdatePriority"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.InAppUpdatePriority))]
    public static T SetInAppUpdatePriority<T>(this T o, int? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.InAppUpdatePriority, v));
    /// <inheritdoc cref="FastlaneSupplySettings.InAppUpdatePriority"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.InAppUpdatePriority))]
    public static T ResetInAppUpdatePriority<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.InAppUpdatePriority));
    #endregion
    #region ObbMainReferencesVersion
    /// <inheritdoc cref="FastlaneSupplySettings.ObbMainReferencesVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ObbMainReferencesVersion))]
    public static T SetObbMainReferencesVersion<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ObbMainReferencesVersion, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ObbMainReferencesVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ObbMainReferencesVersion))]
    public static T ResetObbMainReferencesVersion<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.ObbMainReferencesVersion));
    #endregion
    #region ObbMainFileSize
    /// <inheritdoc cref="FastlaneSupplySettings.ObbMainFileSize"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ObbMainFileSize))]
    public static T SetObbMainFileSize<T>(this T o, int? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ObbMainFileSize, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ObbMainFileSize"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ObbMainFileSize))]
    public static T ResetObbMainFileSize<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.ObbMainFileSize));
    #endregion
    #region ObbPatchReferencesVersion
    /// <inheritdoc cref="FastlaneSupplySettings.ObbPatchReferencesVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ObbPatchReferencesVersion))]
    public static T SetObbPatchReferencesVersion<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ObbPatchReferencesVersion, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ObbPatchReferencesVersion"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ObbPatchReferencesVersion))]
    public static T ResetObbPatchReferencesVersion<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.ObbPatchReferencesVersion));
    #endregion
    #region ObbPatchFileSize
    /// <inheritdoc cref="FastlaneSupplySettings.ObbPatchFileSize"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ObbPatchFileSize))]
    public static T SetObbPatchFileSize<T>(this T o, int? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.ObbPatchFileSize, v));
    /// <inheritdoc cref="FastlaneSupplySettings.ObbPatchFileSize"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.ObbPatchFileSize))]
    public static T ResetObbPatchFileSize<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.ObbPatchFileSize));
    #endregion
    #region AckBundleInstallationWarning
    /// <inheritdoc cref="FastlaneSupplySettings.AckBundleInstallationWarning"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AckBundleInstallationWarning))]
    public static T SetAckBundleInstallationWarning<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.AckBundleInstallationWarning, v));
    /// <inheritdoc cref="FastlaneSupplySettings.AckBundleInstallationWarning"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AckBundleInstallationWarning))]
    public static T ResetAckBundleInstallationWarning<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.AckBundleInstallationWarning));
    /// <inheritdoc cref="FastlaneSupplySettings.AckBundleInstallationWarning"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AckBundleInstallationWarning))]
    public static T EnableAckBundleInstallationWarning<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.AckBundleInstallationWarning, true));
    /// <inheritdoc cref="FastlaneSupplySettings.AckBundleInstallationWarning"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AckBundleInstallationWarning))]
    public static T DisableAckBundleInstallationWarning<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.AckBundleInstallationWarning, false));
    /// <inheritdoc cref="FastlaneSupplySettings.AckBundleInstallationWarning"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.AckBundleInstallationWarning))]
    public static T ToggleAckBundleInstallationWarning<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.AckBundleInstallationWarning, !o.AckBundleInstallationWarning));
    #endregion
    #region Verbose
    /// <inheritdoc cref="FastlaneSupplySettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Verbose))]
    public static T SetVerbose<T>(this T o, bool? v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Verbose, v));
    /// <inheritdoc cref="FastlaneSupplySettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Verbose))]
    public static T ResetVerbose<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.Verbose));
    /// <inheritdoc cref="FastlaneSupplySettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Verbose))]
    public static T EnableVerbose<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Verbose, true));
    /// <inheritdoc cref="FastlaneSupplySettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Verbose))]
    public static T DisableVerbose<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Verbose, false));
    /// <inheritdoc cref="FastlaneSupplySettings.Verbose"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.Verbose))]
    public static T ToggleVerbose<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.Verbose, !o.Verbose));
    #endregion
    #region TeamId
    /// <inheritdoc cref="FastlaneSupplySettings.TeamId"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.TeamId))]
    public static T SetTeamId<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.TeamId, v));
    /// <inheritdoc cref="FastlaneSupplySettings.TeamId"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.TeamId))]
    public static T ResetTeamId<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.TeamId));
    #endregion
    #region TeamName
    /// <inheritdoc cref="FastlaneSupplySettings.TeamName"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.TeamName))]
    public static T SetTeamName<T>(this T o, string v) where T : FastlaneSupplySettings => o.Modify(b => b.Set(() => o.TeamName, v));
    /// <inheritdoc cref="FastlaneSupplySettings.TeamName"/>
    [Pure] [Builder(Type = typeof(FastlaneSupplySettings), Property = nameof(FastlaneSupplySettings.TeamName))]
    public static T ResetTeamName<T>(this T o) where T : FastlaneSupplySettings => o.Modify(b => b.Remove(() => o.TeamName));
    #endregion
}
#endregion
#region MatchProfile
/// <summary>Used within <see cref="FastlaneTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<MatchProfile>))]
public partial class MatchProfile : Enumeration
{
    public static MatchProfile development = (MatchProfile) "development";
    public static MatchProfile adhoc = (MatchProfile) "adhoc";
    public static MatchProfile appstore = (MatchProfile) "appstore";
    public static MatchProfile enterprise = (MatchProfile) "enterprise";
    public static MatchProfile developer_id = (MatchProfile) "developer_id";
    public static MatchProfile mac_installer_distribution = (MatchProfile) "mac_installer_distribution";
    public static implicit operator MatchProfile(string value)
    {
        return new MatchProfile { Value = value };
    }
}
#endregion
#region ProvisioningPlatform
/// <summary>Used within <see cref="FastlaneTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<ProvisioningPlatform>))]
public partial class ProvisioningPlatform : Enumeration
{
    public static ProvisioningPlatform ios = (ProvisioningPlatform) "ios";
    public static ProvisioningPlatform tvos = (ProvisioningPlatform) "tvos";
    public static ProvisioningPlatform macos = (ProvisioningPlatform) "macos";
    public static ProvisioningPlatform catalyst = (ProvisioningPlatform) "catalyst";
    public static implicit operator ProvisioningPlatform(string value)
    {
        return new ProvisioningPlatform { Value = value };
    }
}
#endregion
#region GooglePlayStoreReleaseStatus
/// <summary>Used within <see cref="FastlaneTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<GooglePlayStoreReleaseStatus>))]
public partial class GooglePlayStoreReleaseStatus : Enumeration
{
    public static GooglePlayStoreReleaseStatus completed = (GooglePlayStoreReleaseStatus) "completed";
    public static GooglePlayStoreReleaseStatus draft = (GooglePlayStoreReleaseStatus) "draft";
    public static GooglePlayStoreReleaseStatus inProgress = (GooglePlayStoreReleaseStatus) "inProgress";
    public static GooglePlayStoreReleaseStatus halted = (GooglePlayStoreReleaseStatus) "halted";
    public static implicit operator GooglePlayStoreReleaseStatus(string value)
    {
        return new GooglePlayStoreReleaseStatus { Value = value };
    }
}
#endregion
#region GooglePlayStoreTrack
/// <summary>Used within <see cref="FastlaneTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<GooglePlayStoreTrack>))]
public partial class GooglePlayStoreTrack : Enumeration
{
    public static GooglePlayStoreTrack production = (GooglePlayStoreTrack) "production";
    public static GooglePlayStoreTrack beta = (GooglePlayStoreTrack) "beta";
    public static GooglePlayStoreTrack alpha = (GooglePlayStoreTrack) "alpha";
    public static GooglePlayStoreTrack internal_ = (GooglePlayStoreTrack) "internal";
    public static implicit operator GooglePlayStoreTrack(string value)
    {
        return new GooglePlayStoreTrack { Value = value };
    }
}
#endregion
