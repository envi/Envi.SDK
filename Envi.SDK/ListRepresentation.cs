using System.Collections.Generic;
using Newtonsoft.Json;

namespace Envi.SDK;

/// <summary>
/// Class ListRepresentation.
/// </summary>
public class ListRepresentation<T>
{
	#region Members

	/// <summary>
	/// Gets or sets the value.
	/// </summary>
	[JsonProperty("value")]
	public List<T> Value { get; set; }

	#endregion
}