namespace Unity.VisualScripting.FullSerializer.Internal
{
	public struct fsOption<T>
	{
		private bool _hasValue;

		private T _value;

		public static fsOption<T> Empty;

		public bool HasValue => false;

		public bool IsEmpty => false;

		public T Value => default(T);

		public fsOption(T value)
		{
		}
	}
	public static class fsOption
	{
		public static fsOption<T> Just<T>(T value)
		{
			return default(fsOption<T>);
		}
	}
}
