﻿//HintName: ActivitySourceGenerationAttribute.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Purview.Telemetry.SourceGenerator
//     on {Scrubbed}.
//
//     Changes to this file may cause incorrect behaviour and will be lost
//     when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591 // publicly visible type or member must be documented

#nullable enable

namespace Purview.Telemetry.Activities;

/// <summary>
/// Determines the default <see cref="global::System.Diagnostics.ActivitySource.Name" /> for generated
/// <see cref="global::System.Diagnostics.Activity">activities</see> and <see cref="global::System.Diagnostics.ActivityEvent">events</see>.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = false)]
[global::System.Diagnostics.Conditional("PURVIEW_TELEMETRY_ATTRIBUTES")]
[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1019:Define accessors for attribute arguments")]
sealed class ActivitySourceGenerationAttribute : global::System.Attribute
{
	/// <summary>
	/// Constructs a new <see cref="ActivitySourceGenerationAttribute"/>.
	/// </summary>
	/// <param name="name">The name of the activity source.</param>
	/// <param name="defaultToTags">Determines if the default for method parameters are Tags (default) or Baggage.</param>
	/// <param name="generateDiagnosticsForMissingActivity">Determines if diagnostics are generated for missing activities. Defaults to true.</param>
	/// <exception cref="ArgumentNullException">If the <paramref name="name"/> is null, empty or whitespace.</exception>
	public ActivitySourceGenerationAttribute(string name, bool defaultToTags = true, bool generateDiagnosticsForMissingActivity = true)
	{
		if (string.IsNullOrWhiteSpace(name))
			throw new System.ArgumentNullException(nameof(name));

		Name = name;
		DefaultToTags = defaultToTags;
		GenerateDiagnosticsForMissingActivity = generateDiagnosticsForMissingActivity;
	}

	/// <summary>
	/// Specifies the default <see cref="global::System.Diagnostics.ActivitySource.Name"/> to use.
	/// </summary>
	public string Name { get; }

	/// <summary>
	/// Specifies the default used when inferring between
	/// <see cref="global::Purview.Telemetry.TagAttribute"/>
	/// or <see cref="global::Purview.Telemetry.Activities.BaggageAttribute"/>, unless
	/// explicitly marked. Overridden when specifying <see cref="global::Purview.Telemetry.Activities.ActivitySourceAttribute.DefaultToTags"/>.
	/// </summary>
	public bool DefaultToTags { get; set; } = true;

	/// <summary>
	/// Prefix used to when generating the tag or baggage name. Prepended
	/// before the <see cref="global::Purview.Telemetry.TagAttribute.Name"/> or
	/// <see cref="global::Purview.Telemetry.Activities.BaggageAttribute.Name"/>, unless
	/// explicitly marked. Overridden when specifying <see cref="global::Purview.Telemetry.Activities.ActivitySourceAttribute.BaggageAndTagPrefix"/>.
	/// </summary>
	public string? BaggageAndTagPrefix { get; set; }

	/// <summary>
	/// Determines the separator used between the <see cref="global::System.Diagnostics.ActivitySource.Name"/> and
	/// the various prefix options. The default is a period.
	/// </summary>
	public string BaggageAndTagSeparator { get; set; } = ".";

	/// <summary>
	/// Determines if the <see cref="global::Purview.Telemetry.TagAttribute.Name"/> or
	/// <see cref="global::Purview.Telemetry.Activities.BaggageAttribute.Name"/> (including
	/// any prefixes) are lowercased, unless
	/// explicitly marked. Overridden when specifying <see cref="global::Purview.Telemetry.Activities.ActivitySourceAttribute.LowercaseBaggageAndTagKeys"/>.
	/// </summary>
	public bool LowercaseBaggageAndTagKeys { get; set; } = true;

	/// <summary>
	/// Determines if diagnostics are generated for when an Activity method does not return an activity, or 
	/// when an Event or Context method does not include and Activity as a parameter.
	/// </summary>
	public bool GenerateDiagnosticsForMissingActivity { get; set; } = true;
}
