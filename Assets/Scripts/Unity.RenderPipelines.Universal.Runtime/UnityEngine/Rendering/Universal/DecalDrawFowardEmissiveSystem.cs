namespace UnityEngine.Rendering.Universal
{
	internal class DecalDrawFowardEmissiveSystem : DecalDrawSystem
	{
		public DecalDrawFowardEmissiveSystem(DecalEntityManager entityManager)
			: base(null, null)
		{
		}

		protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			return 0;
		}
	}
}
