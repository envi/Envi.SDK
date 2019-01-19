namespace Api.Common.Entities.RequestRateLimits.Enums
{
	/// <summary>
	/// Enum LimitPeriod
	/// </summary>
	public enum LimitPeriod: byte
	{
		Second = 1,
		Minute,
		Hour,
		Day,
		Week
	}
}
