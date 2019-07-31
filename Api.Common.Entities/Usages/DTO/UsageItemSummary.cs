namespace Api.Common.Entities.Usages.DTO
{

	public class UsageItemSummary : UsageItem
	{
		/// <summary>
		/// UsageIds
		/// </summary>
		public string UsageIds { get; set; }

		/// <summary>
		/// DepartmentIds
		/// </summary>
		public string DepartmentIds { get; set; }

		/// <summary>
		/// Dates
		/// </summary>
		public string Dates { get; set; }
	}
}
