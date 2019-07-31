
using System;

namespace Api.Common.Entities.RequestRateLimits.DTO
{
	/// <summary>
	/// Represents Request Rate Limit setting for an user/organization or global one
	/// </summary>
	public class RateLimit
	{
		/// <summary>
		/// Gets or sets the rate limit identifier.
		/// </summary>
		public Guid? RateLimitId { get; set; }

		/// <summary>
		/// Gets or sets the name of the rule.
		/// </summary>
		public string RuleName { get; set; }

		/// <summary>
		/// Gets or sets the limit type identifier.
		/// </summary>
		public byte? LimitTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type of the limit.
		/// </summary>
		public string LimitType { get; set; }

		/// <summary>
		/// Gets or sets the limit period identifier.
		/// </summary>
		public byte? LimitPeriodId { get; set; }

		/// <summary>
		/// Gets or sets the limit period.
		/// </summary>
		public string LimitPeriod { get; set; }

		/// <summary>
		/// Gets or sets the limit level identifier.
		/// </summary>
		public byte? LimitLevelId { get; set; }

		/// <summary>
		/// Gets or sets the limit level.
		/// </summary>
		public string LimitLevel { get; set; }

		/// <summary>
		/// Gets or sets the limit.
		/// </summary>
		public int? Limit { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets the user identifier.
		/// </summary>
		public Guid? UserId { get; set; }

		/// <summary>
		/// Gets or sets the name of the user.
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// Gets or sets the organization identifier.
		/// </summary>
		public Guid? OrganizationId { get; set; }

		/// <summary>
		/// Gets or sets the organization no.
		/// </summary>
		public string OrganizationNo { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether active status.
		/// </summary>
		public bool? ActiveStatus { get; set; }

		/// <summary>
		/// Gets or sets the date created.
		/// </summary>
		public DateTime? DateCreated { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		public Guid? CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the name of the created by.
		/// </summary>
		public string CreatedByName { get; set; }

		/// <summary>
		/// Gets or sets the last updated.
		/// </summary>
		public DateTime? LastUpdated { get; set; }

		/// <summary>
		/// Gets or sets the last updated by.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Gets or sets the last name of the updated by.
		/// </summary>
		public string LastUpdatedByName { get; set; }
	}
}
