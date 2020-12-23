namespace Esentis.BlueWaves.Persistence.Identity
{
	using System;

	using Esentis.BlueWaves.Persistence.Abstractions;

	using Microsoft.AspNetCore.Identity;

	public class BlueWavesUser : IdentityUser<Guid>, IEntity<Guid>, ITimestamped
	{
		public DateTimeOffset CreatedAt { get; set; }

		public DateTimeOffset UpdatedAt { get; set; }
	}
}
