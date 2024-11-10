using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class Intent
	{
		private string Componentpkg;

		private string Componentcls;

		private string Action;

		private string type;

		private string url;

		private List<string> categoryList;

		private Dictionary<string, string> stringPairs;

		private Dictionary<string, bool> boolPairs;

		private Dictionary<string, int> intPairs;

		private Dictionary<string, float> floatPairs;

		private Dictionary<string, double> doublePairs;

		public void setComponent(string pkg, string cls)
		{
		}

		public void setAction(string _Action)
		{
		}

		public void setType(string _type)
		{
		}

		public void setData(string _url)
		{
		}

		public void addCategory(string _category)
		{
		}

		public void putExtra(string name, string value)
		{
		}

		public void putExtra(string name, int value)
		{
		}

		public void putExtra(string name, float value)
		{
		}

		public void putExtra(string name, double value)
		{
		}

		public void putExtra(string name, bool value)
		{
		}

		public AndroidJavaObject getIntent()
		{
			return null;
		}
	}
}
