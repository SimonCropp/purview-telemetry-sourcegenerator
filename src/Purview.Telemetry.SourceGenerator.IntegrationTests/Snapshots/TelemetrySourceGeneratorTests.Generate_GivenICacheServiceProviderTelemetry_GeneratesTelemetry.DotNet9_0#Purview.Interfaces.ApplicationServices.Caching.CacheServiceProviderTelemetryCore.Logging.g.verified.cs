﻿//HintName: Purview.Interfaces.ApplicationServices.Caching.CacheServiceProviderTelemetryCore.Logging.g.cs
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

namespace Purview.Interfaces.ApplicationServices.Caching
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
	sealed partial class CacheServiceProviderTelemetryCore : global::Purview.Interfaces.ApplicationServices.Caching.ICacheServiceProviderTelemetry
	{
		readonly global::Microsoft.Extensions.Logging.ILogger<global::Purview.Interfaces.ApplicationServices.Caching.ICacheServiceProviderTelemetry> _logger;

		static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, int, global::System.Exception?> _failedToDeserializePayloadAction = global::Microsoft.Extensions.Logging.LoggerMessage.Define<int>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(1974069882, "FailedToDeserializePayload"), "FailedToDeserializePayload: DataLength = {DataLength}");
		static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, string, global::System.Exception?> _failedToGetFromCacheAction = global::Microsoft.Extensions.Logging.LoggerMessage.Define<string>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(747016249, "FailedToGetFromCache"), "FailedToGetFromCache: Key = {Key}");
		static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, string, global::System.Exception?> _failedToRefreshAction = global::Microsoft.Extensions.Logging.LoggerMessage.Define<string>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(1433994932, "FailedToRefresh"), "FailedToRefresh: CacheKey = {CacheKey}");
		static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, string, global::System.Exception?> _failedToRemoveAction = global::Microsoft.Extensions.Logging.LoggerMessage.Define<string>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(2020798325, "FailedToRemove"), "FailedToRemove: Key = {Key}");
		static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, string?, global::System.Exception?> _failedToSerializePayloadAction = global::Microsoft.Extensions.Logging.LoggerMessage.Define<string?>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(1661509127, "FailedToSerializePayload"), "FailedToSerializePayload: FullName = {FullName}");
		static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, string, global::System.Exception?> _failedToSetValueInCacheAction = global::Microsoft.Extensions.Logging.LoggerMessage.Define<string>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(1198289509, "FailedToSetValueInCache"), "FailedToSetValueInCache: Key = {Key}");
		static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, string?, bool, global::System.Exception?> _usingDistributedCacheAction = global::Microsoft.Extensions.Logging.LoggerMessage.Define<string?, bool>(global::Microsoft.Extensions.Logging.LogLevel.Information, new global::Microsoft.Extensions.Logging.EventId(1000100306, "UsingDistributedCache"), "UsingDistributedCache: FullName = {FullName}, IsNullCache = {IsNullCache}");

		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		public CacheServiceProviderTelemetryCore(global::Microsoft.Extensions.Logging.ILogger<global::Purview.Interfaces.ApplicationServices.Caching.ICacheServiceProviderTelemetry> logger)
		{
			_logger = logger;
		}

		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void FailedToDeserializePayload(int dataLength, System.Exception ex)
		{
			if (!_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
			{
				return;
			}

			_failedToDeserializePayloadAction(_logger, dataLength, ex);
		}


		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void FailedToGetFromCache(string key, System.Exception ex)
		{
			if (!_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
			{
				return;
			}

			_failedToGetFromCacheAction(_logger, key, ex);
		}


		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void FailedToRefresh(string cacheKey, System.Exception ex)
		{
			if (!_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
			{
				return;
			}

			_failedToRefreshAction(_logger, cacheKey, ex);
		}


		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void FailedToRemove(string key, System.Exception ex)
		{
			if (!_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
			{
				return;
			}

			_failedToRemoveAction(_logger, key, ex);
		}


		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void FailedToSerializePayload(string? fullName, System.Exception ex)
		{
			if (!_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
			{
				return;
			}

			_failedToSerializePayloadAction(_logger, fullName, ex);
		}


		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void FailedToSetValueInCache(string key, System.Exception ex)
		{
			if (!_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
			{
				return;
			}

			_failedToSetValueInCacheAction(_logger, key, ex);
		}


		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Purview.Telemetry.SourceGenerator", "0.1.0.0")]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void UsingDistributedCache(string? fullName, bool isNullCache)
		{
			if (!_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Information))
			{
				return;
			}

			_usingDistributedCacheAction(_logger, fullName, isNullCache, null);
		}

	}
}
