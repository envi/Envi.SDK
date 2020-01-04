using System;

namespace Api.Common.Entities.Usages.DTO
{
	/// <summary>
	/// Usage Procedure DTO
	/// </summary>
	public class UsageProcedure
	{
		/// <summary>
		/// Usage Procedure Id
		/// </summary>
		public Guid? UsageProcedureId { get; set; }

		/// <summary>
		/// Usage Id
		/// </summary>
		public Guid? UsageId { get; set; }

		/// <summary>
		/// Holds Procedure No to add
		/// </summary>
		public string ProcedureNo { get; set; }
	}
}
