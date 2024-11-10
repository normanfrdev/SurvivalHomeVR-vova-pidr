namespace Unity.VisualScripting
{
	[UnitCategory("Math/Generic")]
	[UnitTitle("Subtract")]
	public sealed class GenericSubtract : Subtract<object>
	{
		public override object Operation(object a, object b)
		{
			return null;
		}

		public GenericSubtract()
		{
			((Subtract<>)(object)this)._002Ector();
		}
	}
}
