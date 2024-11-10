using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class UnitRelation : IUnitRelation, IConnection<IUnitPort, IUnitPort>
	{
		public IUnitPort source
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public IUnitPort destination
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public UnitRelation(IUnitPort source, IUnitPort destination)
		{
		}
	}
}
