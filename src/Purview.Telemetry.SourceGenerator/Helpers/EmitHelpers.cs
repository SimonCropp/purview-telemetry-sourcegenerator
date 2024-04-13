﻿using System.Text;

namespace Purview.Telemetry.SourceGenerator.Helpers;

static class EmitHelpers
{
	public static int EmitNamespaceStart(string? classNamespace, string[] parentClasses, StringBuilder builder, CancellationToken token)
	{
		token.ThrowIfCancellationRequested();

		var indent = 0;
		if (classNamespace != null)
		{
			builder
				.Append("namespace ")
				.AppendLine(classNamespace)
			;

			builder
				.Append('{')
				.AppendLine();

			indent++;
		}

		if (parentClasses.Length > 0)
		{
			foreach (var parentClass in parentClasses.Reverse())
			{
				builder
					.Append(indent, "partial class ", withNewLine: false)
					.Append(parentClass)
					.AppendLine()
					.Append(indent, "{");

				indent++;
			}
		}

		return indent++;
	}

	public static void EmitNamespaceEnd(string? classNamespace, string[] parentClasses, int indent, StringBuilder builder, CancellationToken token)
	{
		token.ThrowIfCancellationRequested();

		if (parentClasses.Length > 0)
		{
			foreach (var parentClass in parentClasses)
				builder.Append(--indent, '}');
		}

		if (classNamespace != null)
			builder.Append('}');
	}

	public static int EmitClassStart(string className, string fullyQualifiedInterface, StringBuilder builder, int indent, CancellationToken token)
	{
		token.ThrowIfCancellationRequested();

		builder
			.Append(indent, "sealed partial class ", withNewLine: false)
			.Append(className)
			.Append(" : ")
			.Append(fullyQualifiedInterface)
			.AppendLine()
			.Append(indent, '{')
		;

		return indent;
	}

	public static void EmitClassEnd(StringBuilder builder, int indent)
		=> builder.Append(indent, '}');
}
