namespace Unity.VisualScripting.Antlr3.Runtime
{
	public static class Token
	{
		public const int EOR_TOKEN_TYPE = 1;

		public const int DOWN = 2;

		public const int UP = 3;

		public const int INVALID_TOKEN_TYPE = 0;

		public const int DEFAULT_CHANNEL = 0;

		public const int HIDDEN_CHANNEL = 99;

		public static readonly int MIN_TOKEN_TYPE;

		public static readonly int EOF;

		public static readonly IToken EOF_TOKEN;

		public static readonly IToken INVALID_TOKEN;

		public static readonly IToken SKIP_TOKEN;
	}
}
