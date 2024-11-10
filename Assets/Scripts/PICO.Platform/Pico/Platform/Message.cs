using System;
using Pico.Platform.Models;

namespace Pico.Platform
{
	public class Message
	{
		public delegate void Handler(Message message);

		public readonly MessageType Type;

		public readonly ulong RequestID;

		public readonly Error Error;

		public bool IsError => false;

		public Message(IntPtr msgPointer)
		{
		}

		[Obsolete("Use Error instead")]
		public Error GetError()
		{
			return null;
		}
	}
	public class Message<T> : Message
	{
		public new delegate void Handler(Message<T> message);

		public delegate T GetDataFromMessage(IntPtr msgPointer);

		public readonly T Data;

		public Message(IntPtr msgPointer, GetDataFromMessage getData)
			: base((IntPtr)0)
		{
		}
	}
}
