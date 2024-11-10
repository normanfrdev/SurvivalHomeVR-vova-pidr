namespace Unity.VisualScripting
{
	public sealed class AdditionHandler : BinaryOperatorHandler
	{
		public AdditionHandler()
			: base(null, null, null, null)
		{
		}

		protected override object CustomHandling(object leftOperand, object rightOperand)
		{
			return null;
		}
	}
}
