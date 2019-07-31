using System;

namespace Api.Common.Entities.RequestRateLimits.DTO
{
	public class LimitWhiteList
	{
		public Guid EntryId { get; set; }
		public byte LimitTypeId { get; set; }
		public string Value { get; set; }
		public bool ActiveStatus { get; set; }
		public DateTime DateCreated { get; set; }
		public Guid CreatedBy { get; set; }
		public DateTime LastUpdated { get; set; }
		public Guid LastUpdatedBy { get; set; }
		public string LimitType { get; set; }
		public string CreatedByUser { get; set; }
		public string LastUpdatedByUser { get; set; }
	}
}
