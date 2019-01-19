using System;

namespace Api.Common.Entities.Usages.DTO
{

	/// <summary>
	/// Class UsageProcedure.
	/// </summary>
	public class UsageProcedure
	{
		/// <summary>
		/// Gets or sets the usage procedure identifier.
		/// </summary>
		public Guid? UsageProcedureId { get; set; }

		/// <summary>
		/// Gets or sets the usage identifier.
		/// </summary>
		public Guid? UsageId { get; set; }

		/// <summary>
		/// Gets or sets the procedure no.
		/// </summary>
		public string ProcedureNo { get; set; }
	}
}
