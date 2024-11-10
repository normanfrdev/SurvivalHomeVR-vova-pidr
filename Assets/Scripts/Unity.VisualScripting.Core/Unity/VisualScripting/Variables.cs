using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.VisualScripting
{
	[AddComponentMenu("Visual Scripting/Variables")]
	[DisableAnnotation]
	[IncludeInSettings(false)]
	public class Variables : LudiqBehaviour, IAotStubbable
	{
		[CompilerGenerated]
		private sealed class _003CGetAotStubs_003Ed__25 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Variables _003C_003E4__this;

			private IEnumerator<VariableDeclaration> _003C_003E7__wrap1;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetAotStubs_003Ed__25(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Serialize]
		[Inspectable]
		public VariableDeclarations declarations
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public static VariableDeclarations ActiveScene => null;

		public static VariableDeclarations Application => null;

		public static VariableDeclarations Saved => null;

		public static bool ExistInActiveScene => false;

		public static VariableDeclarations Graph(GraphPointer pointer)
		{
			return null;
		}

		public static VariableDeclarations GraphInstance(GraphPointer pointer)
		{
			return null;
		}

		public static VariableDeclarations GraphDefinition(GraphPointer pointer)
		{
			return null;
		}

		public static VariableDeclarations GraphDefinition(IGraphWithVariables graph)
		{
			return null;
		}

		public static VariableDeclarations Object(GameObject go)
		{
			return null;
		}

		public static VariableDeclarations Object(Component component)
		{
			return null;
		}

		public static VariableDeclarations Scene(Scene? scene)
		{
			return null;
		}

		public static VariableDeclarations Scene(GameObject go)
		{
			return null;
		}

		public static VariableDeclarations Scene(Component component)
		{
			return null;
		}

		public static bool ExistOnObject(GameObject go)
		{
			return false;
		}

		public static bool ExistOnObject(Component component)
		{
			return false;
		}

		public static bool ExistInScene(Scene? scene)
		{
			return false;
		}

		[ContextMenu("Show Data...")]
		protected override void ShowData()
		{
		}

		[IteratorStateMachine(typeof(_003CGetAotStubs_003Ed__25))]
		public IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}
	}
}
