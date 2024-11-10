namespace Pico.Platform
{
	public enum CancelReason
	{
		None = 0,
		UserCancelsExpiration = 1,
		DeductionFailedExpired = 2,
		NoMainApplicationInterest = 3
	}
}
