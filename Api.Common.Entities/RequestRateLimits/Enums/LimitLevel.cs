namespace Api.Common.Entities.RequestRateLimits.Enums
{
	/// <summary>
	/// Enum LimitLevel
	/// </summary>
	public enum LimitLevel: byte
	{
		Global = 1,
		Organization,
		User
	}
}
