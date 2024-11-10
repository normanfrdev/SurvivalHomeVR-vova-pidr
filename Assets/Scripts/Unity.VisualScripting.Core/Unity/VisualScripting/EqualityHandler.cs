namespace Unity.VisualScripting
{
	public class EqualityHandler : BinaryOperatorHandler
	{
		public EqualityHandler()
			: base(null, null, null, null)
		{
		}

		protected override object BothNullHandling()
		{
			return null;
		}

		protected override object SingleNullHandling()
		{
			return null;
		}

		protected override object CustomHandling(object leftOperand, object rightOperand)
		{
			return null;
		}
	}
}
