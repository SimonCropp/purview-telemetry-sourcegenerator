﻿//HintName: Testing.TestLoggerCore.Logging.g.cs
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

namespace Testing
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
	sealed partial class TestLoggerCore : global::Testing.ITestLogger
	{
		readonly global::Microsoft.Extensions.Logging.ILogger<global::Testing.ITestLogger> _logger;

		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		public TestLoggerCore(global::Microsoft.Extensions.Logging.ILogger<global::Testing.ITestLogger> logger)
		{
			_logger = logger;
		}

		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public global::System.IDisposable? BasicScoped(int intValue, string? nullableStringValue, System.UInt32 uintValue)
		{
			var state = global::Microsoft.Extensions.Logging.LoggerMessageHelper.ThreadLocalState;
			state.ReserveTagSpace(4);

			state.TagArray[0] = new("{OriginalFormat}", "BasicScoped: IntValue = {IntValue}, NullableStringValue = {NullableStringValue}, UintValue = {UintValue}");
			state.TagArray[1] = new("intValue", intValue);
			state.TagArray[2] = new("nullableStringValue", nullableStringValue);
			state.TagArray[3] = new("uintValue", uintValue);

			var v0 = state.TagArray[1].Value ?? "(null)";
			var v1 = state.TagArray[2].Value ?? "(null)";
			var v2 = state.TagArray[3].Value ?? "(null)";

			var formattedMessage = 
#if NET
				string.Create(global::System.Globalization.CultureInfo.InvariantCulture, $"BasicScoped: IntValue = {v0}, NullableStringValue = {v1}, UintValue = {v2}");
#else
				global::System.FormattableString.Invariant($"BasicScoped: IntValue = {v0}, NullableStringValue = {v1}, UintValue = {v2}");
#endif
			;

			state.AddTag("FormattedMessage", formattedMessage);

			return _logger.BeginScope(state);
		}

	}
}
