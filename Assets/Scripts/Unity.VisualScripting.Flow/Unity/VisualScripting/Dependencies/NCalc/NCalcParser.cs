using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.Antlr3.Runtime;
using Unity.VisualScripting.Antlr3.Runtime.Tree;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class NCalcParser : Parser
	{
		public class ncalcExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class logicalExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class conditionalExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class booleanAndExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class bitwiseOrExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class bitwiseXOrExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class bitwiseAndExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class equalityExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class relationalExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class shiftExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class additiveExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class multiplicativeExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class unaryExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class primaryExpression_return : ParserRuleReturnScope
		{
			public LogicalExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class value_return : ParserRuleReturnScope
		{
			public ValueExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class identifier_return : ParserRuleReturnScope
		{
			public IdentifierExpression value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class expressionList_return : ParserRuleReturnScope
		{
			public List<LogicalExpression> value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class arguments_return : ParserRuleReturnScope
		{
			public List<LogicalExpression> value;

			private CommonTree tree;

			public override object Tree
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		protected ITreeAdaptor adaptor;

		public const int T__29 = 29;

		public const int T__28 = 28;

		public const int T__27 = 27;

		public const int T__26 = 26;

		public const int T__25 = 25;

		public const int T__24 = 24;

		public const int T__23 = 23;

		public const int LETTER = 12;

		public const int T__22 = 22;

		public const int T__21 = 21;

		public const int T__20 = 20;

		public const int FLOAT = 5;

		public const int ID = 10;

		public const int EOF = -1;

		public const int HexDigit = 17;

		public const int T__19 = 19;

		public const int NAME = 11;

		public const int DIGIT = 13;

		public const int T__42 = 42;

		public const int INTEGER = 4;

		public const int E = 14;

		public const int T__43 = 43;

		public const int T__40 = 40;

		public const int T__41 = 41;

		public const int T__46 = 46;

		public const int T__47 = 47;

		public const int T__44 = 44;

		public const int T__45 = 45;

		public const int T__48 = 48;

		public const int DATETIME = 7;

		public const int TRUE = 8;

		public const int T__30 = 30;

		public const int T__31 = 31;

		public const int T__32 = 32;

		public const int WS = 18;

		public const int T__33 = 33;

		public const int T__34 = 34;

		public const int T__35 = 35;

		public const int T__36 = 36;

		public const int T__37 = 37;

		public const int T__38 = 38;

		public const int T__39 = 39;

		public const int UnicodeEscape = 16;

		public const int FALSE = 9;

		public const int EscapeSequence = 15;

		public const int STRING = 6;

		private const char BS = '\\';

		public static readonly string[] tokenNames;

		private static NumberFormatInfo numberFormatInfo;

		public static readonly BitSet FOLLOW_logicalExpression_in_ncalcExpression56;

		public static readonly BitSet FOLLOW_EOF_in_ncalcExpression58;

		public static readonly BitSet FOLLOW_conditionalExpression_in_logicalExpression78;

		public static readonly BitSet FOLLOW_19_in_logicalExpression84;

		public static readonly BitSet FOLLOW_conditionalExpression_in_logicalExpression88;

		public static readonly BitSet FOLLOW_20_in_logicalExpression90;

		public static readonly BitSet FOLLOW_conditionalExpression_in_logicalExpression94;

		public static readonly BitSet FOLLOW_booleanAndExpression_in_conditionalExpression121;

		public static readonly BitSet FOLLOW_set_in_conditionalExpression130;

		public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression146;

		public static readonly BitSet FOLLOW_bitwiseOrExpression_in_booleanAndExpression180;

		public static readonly BitSet FOLLOW_set_in_booleanAndExpression189;

		public static readonly BitSet FOLLOW_bitwiseOrExpression_in_booleanAndExpression205;

		public static readonly BitSet FOLLOW_bitwiseXOrExpression_in_bitwiseOrExpression237;

		public static readonly BitSet FOLLOW_25_in_bitwiseOrExpression246;

		public static readonly BitSet FOLLOW_bitwiseOrExpression_in_bitwiseOrExpression256;

		public static readonly BitSet FOLLOW_bitwiseAndExpression_in_bitwiseXOrExpression290;

		public static readonly BitSet FOLLOW_26_in_bitwiseXOrExpression299;

		public static readonly BitSet FOLLOW_bitwiseAndExpression_in_bitwiseXOrExpression309;

		public static readonly BitSet FOLLOW_equalityExpression_in_bitwiseAndExpression341;

		public static readonly BitSet FOLLOW_27_in_bitwiseAndExpression350;

		public static readonly BitSet FOLLOW_equalityExpression_in_bitwiseAndExpression360;

		public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression394;

		public static readonly BitSet FOLLOW_set_in_equalityExpression405;

		public static readonly BitSet FOLLOW_set_in_equalityExpression422;

		public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression441;

		public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression474;

		public static readonly BitSet FOLLOW_32_in_relationalExpression485;

		public static readonly BitSet FOLLOW_33_in_relationalExpression495;

		public static readonly BitSet FOLLOW_34_in_relationalExpression506;

		public static readonly BitSet FOLLOW_35_in_relationalExpression516;

		public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression528;

		public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression560;

		public static readonly BitSet FOLLOW_36_in_shiftExpression571;

		public static readonly BitSet FOLLOW_37_in_shiftExpression581;

		public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression593;

		public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression625;

		public static readonly BitSet FOLLOW_38_in_additiveExpression636;

		public static readonly BitSet FOLLOW_39_in_additiveExpression646;

		public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression658;

		public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression690;

		public static readonly BitSet FOLLOW_40_in_multiplicativeExpression701;

		public static readonly BitSet FOLLOW_41_in_multiplicativeExpression711;

		public static readonly BitSet FOLLOW_42_in_multiplicativeExpression721;

		public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression733;

		public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression760;

		public static readonly BitSet FOLLOW_set_in_unaryExpression771;

		public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression779;

		public static readonly BitSet FOLLOW_45_in_unaryExpression791;

		public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression794;

		public static readonly BitSet FOLLOW_39_in_unaryExpression805;

		public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression807;

		public static readonly BitSet FOLLOW_46_in_primaryExpression829;

		public static readonly BitSet FOLLOW_logicalExpression_in_primaryExpression831;

		public static readonly BitSet FOLLOW_47_in_primaryExpression833;

		public static readonly BitSet FOLLOW_value_in_primaryExpression843;

		public static readonly BitSet FOLLOW_identifier_in_primaryExpression851;

		public static readonly BitSet FOLLOW_arguments_in_primaryExpression856;

		public static readonly BitSet FOLLOW_INTEGER_in_value876;

		public static readonly BitSet FOLLOW_FLOAT_in_value884;

		public static readonly BitSet FOLLOW_STRING_in_value892;

		public static readonly BitSet FOLLOW_DATETIME_in_value901;

		public static readonly BitSet FOLLOW_TRUE_in_value908;

		public static readonly BitSet FOLLOW_FALSE_in_value916;

		public static readonly BitSet FOLLOW_ID_in_identifier934;

		public static readonly BitSet FOLLOW_NAME_in_identifier942;

		public static readonly BitSet FOLLOW_logicalExpression_in_expressionList966;

		public static readonly BitSet FOLLOW_48_in_expressionList973;

		public static readonly BitSet FOLLOW_logicalExpression_in_expressionList977;

		public static readonly BitSet FOLLOW_46_in_arguments1006;

		public static readonly BitSet FOLLOW_expressionList_in_arguments1010;

		public static readonly BitSet FOLLOW_47_in_arguments1017;

		public ITreeAdaptor TreeAdaptor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] TokenNames => null;

		public override string GrammarFileName => null;

		public List<string> Errors
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NCalcParser(ITokenStream input)
			: base(null)
		{
		}

		public NCalcParser(ITokenStream input, RecognizerSharedState state)
			: base(null)
		{
		}

		private void InitializeCyclicDFAs()
		{
		}

		private string extractString(string text)
		{
			return null;
		}

		public override void DisplayRecognitionError(string[] tokenNames, RecognitionException e)
		{
		}

		public ncalcExpression_return ncalcExpression()
		{
			return null;
		}

		public logicalExpression_return logicalExpression()
		{
			return null;
		}

		public conditionalExpression_return conditionalExpression()
		{
			return null;
		}

		public booleanAndExpression_return booleanAndExpression()
		{
			return null;
		}

		public bitwiseOrExpression_return bitwiseOrExpression()
		{
			return null;
		}

		public bitwiseXOrExpression_return bitwiseXOrExpression()
		{
			return null;
		}

		public bitwiseAndExpression_return bitwiseAndExpression()
		{
			return null;
		}

		public equalityExpression_return equalityExpression()
		{
			return null;
		}

		public relationalExpression_return relationalExpression()
		{
			return null;
		}

		public shiftExpression_return shiftExpression()
		{
			return null;
		}

		public additiveExpression_return additiveExpression()
		{
			return null;
		}

		public multiplicativeExpression_return multiplicativeExpression()
		{
			return null;
		}

		public unaryExpression_return unaryExpression()
		{
			return null;
		}

		public primaryExpression_return primaryExpression()
		{
			return null;
		}

		public value_return value()
		{
			return null;
		}

		public identifier_return identifier()
		{
			return null;
		}

		public expressionList_return expressionList()
		{
			return null;
		}

		public arguments_return arguments()
		{
			return null;
		}
	}
}
