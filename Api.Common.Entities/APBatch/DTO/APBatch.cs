using System;

namespace Api.Common.Entities.APBatch.DTO
{
	/// <summary>
	/// Represents a batch entity.
	/// </summary>
	public class APBatch
	{
		#region Public Properties

		/// <summary>
		/// Gets or sets an ap batch id.
		/// </summary>
		public Guid? APBatchId { get; set; }

		/// <summary>
		/// Gets or sets a purchase batch no.
		/// </summary>
		public string BatchNo { get; set; }

		/// <summary>
		/// Gets or sets a reference.
		/// </summary>
		public string Reference { get; set; }

		/// <summary>
		/// Gets or sets a matched batch status id.
		/// </summary>
		public byte? BatchStatusId { get; set; }

		/// <summary>
		/// Gets or sets a matched batch status.
		/// </summary>
		public string BatchStatus { get; set; }

		/// <summary>
		/// Gets or sets an invoice batch total.
		/// </summary>
		public decimal? BatchTotal { get; set; }

		/// <summary>
		/// Gets or sets an invoice count.
		/// </summary>
		public int? InvoiceCount { get; set; }

		/// <summary>
		/// Gets or sets is scheduled exporting.
		/// </summary>
		public bool? IsScheduledExporting { get; set; }

		/// <summary>
		/// Gets or sets a last export date.
		/// </summary>
		public DateTimeOffset? LastExportDate { get; set; }

		/// <summary>
		/// Gets or sets a date created.
		/// </summary>
		public DateTimeOffset? DateCreated { get; set; }

		/// <summary>
		/// Gets or sets a created by.
		/// </summary>
		public Guid? CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets a created by user name.
		/// </summary>
		public string CreatedByUserName { get; set; }

		/// <summary>
		/// Gets or sets a last updated.
		/// </summary>
		public DateTimeOffset? LastUpdated { get; set; }

		/// <summary>
		/// Gets or sets a last updated by.
		/// </summary>
		public Guid? LastUpdatedBy { get; set; }

		/// <summary>
		/// Gets or sets a last updated by user name.
		/// </summary>
		public string LastUpdatedByUserName { get; set; }

		#endregion
	}
}
