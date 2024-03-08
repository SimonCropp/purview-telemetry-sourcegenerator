﻿
using Microsoft.CodeAnalysis;

namespace Purview.Telemetry.SourceGenerator.Records;

sealed record TelemetryDiagnosticDescriptor(
	string Id,
	string Title,
	string Description,
	DiagnosticSeverity Severity,
	string Category = Constants.Diagnostics.Activity.Usage,
	bool EnabledByDefault = true
);
