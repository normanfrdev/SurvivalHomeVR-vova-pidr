using System;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorTextAreaAttribute : Attribute
	{
		private float? _minLines;

		private float? _maxLines;

		public float minLines
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool hasMinLines => false;

		public float maxLines
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool hasMaxLines => false;
	}
}
