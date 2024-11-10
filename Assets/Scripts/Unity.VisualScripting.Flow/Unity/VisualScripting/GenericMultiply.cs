namespace Unity.VisualScripting
{
	[UnitCategory("Math/Generic")]
	[UnitTitle("Multiply")]
	public sealed class GenericMultiply : Multiply<object>
	{
		public override object Operation(object a, object b)
		{
			return null;
		}

		public GenericMultiply()
		{
			((Multiply<>)(object)this)._002Ector();
		}
	}
}
