﻿namespace Purview.Telemetry.Metrics;

/// <summary>
/// Specifies the meter type generated corresponds to a <see cref="global::System.Diagnostics.Metrics.Counter{T}"/>.
/// </summary>
{CodeGen}
[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
[global::System.Diagnostics.Conditional("PURVIEW_TELEMETRY_ATTRIBUTES")]
[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1019:Define accessors for attribute arguments")]
sealed class CounterAttribute : global::System.Attribute
{
	/// <summary>
	/// Creates a new instance of the <see cref="CounterAttribute"/> class.
	/// </summary>
	public CounterAttribute()
	{
	}

	/// <summary>
	/// Creates a new instance of the <see cref="CounterAttribute"/> class, and specifies the
	/// <see cref="AutoIncrement"/>.
	/// </summary>
	/// <param name="autoIncrement">Specifies the <see cref="AutoIncrement"/>.</param>
	public CounterAttribute(bool autoIncrement)
	{
		AutoIncrement = autoIncrement;
	}

	/// <summary>
	/// Creates a new instance of the <see cref="CounterAttribute"/> class, and specifies the
	/// <see cref="Name"/>, and optionally the <see cref="Unit"/>, <see cref="Description"/>
	/// and <see cref="AutoIncrement"/>.
	/// </summary>
	/// <param name="name">Specifies the <see cref="Name"/>.</param>
	/// <param name="unit">Optionally specifies the <see cref="Unit"/>.</param>
	/// <param name="description">Optionally specifies the <see cref="Description"/>.</param>
	/// <param name="autoIncrement">Optionally specifies if the counter is <see cref="AutoIncrement">auto incremented</see>.</param>
	public CounterAttribute(string name, string? unit = null, string? description = null, bool autoIncrement = false)
	{
		Name = name;
		Unit = unit;
		Description = description;
		AutoIncrement = autoIncrement;
	}

	/// <summary>
	/// If true, when the method is called the counter is automatically incremented (+1).
	/// Otherwise a parameter value must be specified (either inferred or via using
	/// the <see cref="InstrumentMeasurementAttribute" />).
	/// </summary>
	public bool AutoIncrement { get; set; }

	/// <summary>
	/// Optionally specifies the name of the meter. If one is not specified, the name
	/// of the method is used.
	/// </summary>

	public string? Name { get; set; }

	/// <summary>
	/// Optionally specifies the unit of the meter.
	/// </summary>
	public string? Unit { get; set; }

	/// <summary>
	/// Optionally specifies the description of the meter.
	/// </summary>
	public string? Description { get; set; }
}
