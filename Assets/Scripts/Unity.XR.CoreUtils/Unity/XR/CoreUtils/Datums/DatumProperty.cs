using System;
using UnityEngine;

namespace Unity.XR.CoreUtils.Datums
{
	[Serializable]
	public abstract class DatumProperty<TValue, TDatum> where TDatum : Datum<TValue>
	{
		[SerializeField]
		private bool m_UseConstant;

		[SerializeField]
		private TValue m_ConstantValue;

		[SerializeField]
		private TDatum m_Variable;

		public TValue Value
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		protected Datum<TValue> Datum => null;

		protected TValue ConstantValue => default(TValue);

		protected DatumProperty()
		{
		}

		protected DatumProperty(TValue value)
		{
		}

		protected DatumProperty(TDatum datum)
		{
		}

		public static implicit operator TValue(DatumProperty<TValue, TDatum> datumProperty)
		{
			return default(TValue);
		}
	}
}
