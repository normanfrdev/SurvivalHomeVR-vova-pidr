using System;
using System.Collections.Concurrent;

namespace Pico.Platform
{
	public class Looper
	{
		private static readonly ConcurrentDictionary<ulong, Delegate> TaskMap;

		private static readonly ConcurrentDictionary<MessageType, Delegate> NotifyMap;

		public static readonly ConcurrentDictionary<MessageType, MessageParser> MessageParserMap;

		public static void ProcessMessages(uint limit = 0u)
		{
		}

		public static Message PopMessage()
		{
			return null;
		}

		private static void dispatchMessage(Message msg)
		{
		}

		public static void RegisterTaskHandler(ulong taskId, Delegate handler)
		{
		}

		public static void RegisterNotifyHandler(MessageType type, Delegate handler)
		{
		}

		public static void RegisterMessageParser(MessageType messageType, MessageParser messageParser)
		{
		}

		public static void Clear()
		{
		}
	}
}
