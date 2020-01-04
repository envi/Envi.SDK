using System;

namespace Api.Common.Entities.RequestRateLimits.DTO
{
	/// <summary>
	/// Limit White List
	/// </summary>
	public class LimitWhiteList
	{
		/// <summary>
		/// Gets or sets the entry identifier.
		/// </summary>
		public Guid EntryId { get; set; }

		/// <summary>
		/// Gets or sets the limit type identifier.
		/// </summary>
		public byte LimitTypeId { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [active status].
		/// </summary>
		/// <value>
		public bool ActiveStatus { get; set; }

		/// <summary>
		/// Gets or sets the date created.
		/// </summary>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		public Guid CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the last updated.
		/// </summary>
		public DateTime LastUpdated { get; set; }

		/// <summary>
		/// Gets or sets the last updated by.
		/// </summary>
		public Guid LastUpdatedBy { get; set; }

		/// <summary>
		/// Gets or sets the type of the limit.
		/// </summary>
		public string LimitType { get; set; }

		/// <summary>
		/// Gets or sets the created by user.
		/// </summary>
		public string CreatedByUser { get; set; }

		/// <summary>
		/// Gets or sets the last updated by user.
		/// </summary>
		public string LastUpdatedByUser { get; set; }
	}
}
