using System;
using System.Collections.Generic;
using Unity.XR.CoreUtils.Datums;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme
{
	[Serializable]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public abstract class BaseAffordanceTheme<T> : IEquatable<BaseAffordanceTheme<T>> where T : struct
	{
		[SerializeField]
		[Tooltip("Curve used to evaluate the target value of the animation state according to the affordance state's transition amount value.")]
		private AnimationCurveDatumProperty m_StateAnimationCurve;

		[SerializeField]
		[Tooltip("List of affordance states supported by this theme. The entry index is how states are mapped to their theme data.\nDo not re-order entries.")]
		private List<AffordanceThemeData<T>> m_List;

		public AnimationCurve animationCurve => null;

		internal void ValidateTheme()
		{
		}

		public AffordanceThemeData<T> GetAffordanceThemeDataForIndex(byte stateIndex)
		{
			return null;
		}

		public void SetAffordanceThemeDataList(List<AffordanceThemeData<T>> newList)
		{
		}

		public virtual void CopyFrom(BaseAffordanceTheme<T> other)
		{
		}

		public void SetAnimationCurve(AnimationCurve newAnimationCurve)
		{
		}

		public bool Equals(BaseAffordanceTheme<T> other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
