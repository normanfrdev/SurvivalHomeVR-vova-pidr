using System;

namespace Pico.Platform.Models
{
	public class DetectSensitiveResult
	{
		public readonly string FilteredText;

		public readonly SensitiveProposal Proposal;

		public DetectSensitiveResult(IntPtr o)
		{
		}
	}
}
