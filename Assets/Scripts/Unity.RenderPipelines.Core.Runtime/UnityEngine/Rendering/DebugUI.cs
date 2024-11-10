using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace UnityEngine.Rendering
{
	public class DebugUI
	{
		public class Container : Widget, IContainer
		{
			private const string k_IDToken = "#";

			internal bool hideDisplayName => false;

			public ObservableList<Widget> children
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

			public override Panel panel
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public Container()
			{
			}

			public Container(string id)
			{
			}

			public Container(string displayName, ObservableList<Widget> children)
			{
			}

			internal override void GenerateQueryPath()
			{
			}

			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public class Foldout : Container, IValueField
		{
			public struct ContextMenuItem
			{
				public string displayName;

				public Action action;
			}

			public bool opened;

			public bool isHeader;

			public List<ContextMenuItem> contextMenuItems;

			public bool isReadOnly => false;

			public string[] columnLabels
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string[] columnTooltips
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Foldout()
			{
			}

			public Foldout(string displayName, ObservableList<Widget> children, string[] columnLabels = null, string[] columnTooltips = null)
			{
			}

			public bool GetValue()
			{
				return false;
			}

			object IValueField.GetValue()
			{
				return null;
			}

			public void SetValue(object value)
			{
			}

			public object ValidateValue(object value)
			{
				return null;
			}

			public void SetValue(bool value)
			{
			}
		}

		public class HBox : Container
		{
		}

		public class VBox : Container
		{
		}

		public class Table : Container
		{
			public class Row : Foldout
			{
			}

			public bool isReadOnly;

			private bool[] m_Header;

			public bool[] VisibleColumns => null;

			public void SetColumnVisibility(int index, bool visible)
			{
			}

			public bool GetColumnVisibility(int index)
			{
				return false;
			}

			protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}
		}

		[Flags]
		public enum Flags
		{
			None = 0,
			EditorOnly = 2,
			RuntimeOnly = 4,
			EditorForceUpdate = 8,
			FrequentlyUsed = 0x10
		}

		public abstract class Widget
		{
			public struct NameAndTooltip
			{
				public string name;

				public string tooltip;
			}

			protected Panel m_Panel;

			protected IContainer m_Parent;

			public Func<bool> isHiddenCallback;

			public virtual Panel panel
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public virtual IContainer parent
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public Flags flags
			{
				[CompilerGenerated]
				get
				{
					return default(Flags);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string displayName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string tooltip
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string queryPath
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

			public bool isEditorOnly => false;

			public bool isRuntimeOnly => false;

			public bool isInactiveInEditor => false;

			public bool isHidden => false;

			public NameAndTooltip nameAndTooltip
			{
				set
				{
				}
			}

			internal virtual void GenerateQueryPath()
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public interface IContainer
		{
			ObservableList<Widget> children { get; }

			string displayName { get; set; }

			string queryPath { get; }
		}

		public interface IValueField
		{
			object GetValue();

			void SetValue(object value);

			object ValidateValue(object value);
		}

		public class Button : Widget
		{
			public Action action
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		public class Value : Widget
		{
			public float refreshRate;

			public string formatString;

			public Func<object> getter
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public virtual object GetValue()
			{
				return null;
			}

			public virtual string FormatString(object value)
			{
				return null;
			}
		}

		public class ProgressBarValue : Value
		{
			public float min;

			public float max;

			public override string FormatString(object value)
			{
				return null;
			}
		}

		public class ValueTuple : Widget
		{
			public Value[] values;

			public int pinnedElementIndex;

			public int numElements => 0;

			public float refreshRate => 0f;
		}

		public abstract class Field<T> : Widget, IValueField
		{
			public Action<Field<T>, T> onValueChanged;

			public Func<T> getter
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Action<T> setter
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			object IValueField.ValidateValue(object value)
			{
				return null;
			}

			public virtual T ValidateValue(T value)
			{
				return default(T);
			}

			object IValueField.GetValue()
			{
				return null;
			}

			public T GetValue()
			{
				return default(T);
			}

			public void SetValue(object value)
			{
			}

			public virtual void SetValue(T value)
			{
			}
		}

		public class BoolField : Field<bool>
		{
			public BoolField()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class HistoryBoolField : BoolField
		{
			public Func<bool>[] historyGetter
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int historyDepth => 0;

			public bool GetHistoryValue(int historyIndex)
			{
				return false;
			}
		}

		public class IntField : Field<int>
		{
			public Func<int> min;

			public Func<int> max;

			public int incStep;

			public int intStepMult;

			public override int ValidateValue(int value)
			{
				return 0;
			}

			public IntField()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class UIntField : Field<uint>
		{
			public Func<uint> min;

			public Func<uint> max;

			public uint incStep;

			public uint intStepMult;

			public override uint ValidateValue(uint value)
			{
				return 0u;
			}

			public UIntField()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class FloatField : Field<float>
		{
			public Func<float> min;

			public Func<float> max;

			public float incStep;

			public float incStepMult;

			public int decimals;

			public override float ValidateValue(float value)
			{
				return 0f;
			}

			public FloatField()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public abstract class EnumField<T> : Field<T>
		{
			public GUIContent[] enumNames;

			private int[] m_EnumValues;

			private static Regex s_NicifyRegEx;

			public int[] enumValues
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			protected void AutoFillFromType(Type enumType)
			{
			}

			protected EnumField()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class EnumField : EnumField<int>
		{
			internal int[] quickSeparators;

			private int[] m_Indexes;

			internal int[] indexes => null;

			public Func<int> getIndex
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Action<int> setIndex
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int currentIndex
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public Type autoEnum
			{
				set
				{
				}
			}

			internal void InitQuickSeparators()
			{
			}

			public override void SetValue(int value)
			{
			}

			public EnumField()
			{
				((EnumField<>)(object)this)._002Ector();
			}
		}

		public class ObjectPopupField : Field<Object>
		{
			public Func<IEnumerable<Object>> getObjects
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public ObjectPopupField()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class HistoryEnumField : EnumField
		{
			public Func<int>[] historyIndexGetter
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int historyDepth => 0;

			public int GetHistoryValue(int historyIndex)
			{
				return 0;
			}
		}

		public class BitField : EnumField<Enum>
		{
			private Type m_EnumType;

			public Type enumType
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public BitField()
			{
				((EnumField<>)(object)this)._002Ector();
			}
		}

		public class ColorField : Field<Color>
		{
			public bool hdr;

			public bool showAlpha;

			public bool showPicker;

			public float incStep;

			public float incStepMult;

			public int decimals;

			public override Color ValidateValue(Color value)
			{
				return default(Color);
			}

			public ColorField()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class Vector2Field : Field<Vector2>
		{
			public float incStep;

			public float incStepMult;

			public int decimals;

			public Vector2Field()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class Vector3Field : Field<Vector3>
		{
			public float incStep;

			public float incStepMult;

			public int decimals;

			public Vector3Field()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class Vector4Field : Field<Vector4>
		{
			public float incStep;

			public float incStepMult;

			public int decimals;

			public Vector4Field()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class ObjectField : Field<Object>
		{
			public Type type;

			public ObjectField()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class ObjectListField : Field<Object[]>
		{
			public Type type;

			public ObjectListField()
			{
				((Field<>)(object)this)._002Ector();
			}
		}

		public class MessageBox : Widget
		{
			public enum Style
			{
				Info = 0,
				Warning = 1,
				Error = 2
			}

			public Style style;
		}

		public class Panel : IContainer, IComparable<Panel>
		{
			public Flags flags
			{
				[CompilerGenerated]
				get
				{
					return default(Flags);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string displayName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int groupIndex
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string queryPath => null;

			public bool isEditorOnly => false;

			public bool isRuntimeOnly => false;

			public bool isInactiveInEditor => false;

			public bool editorForceUpdate => false;

			public ObservableList<Widget> children
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

			public event Action<Panel> onSetDirty
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			public void SetDirty()
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}

			int IComparable<Panel>.CompareTo(Panel other)
			{
				return 0;
			}
		}
	}
}
