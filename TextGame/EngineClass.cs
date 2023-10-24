using System;
namespace TextGame
{
	public static class EngineClass
	{
		public static IGame CurrentGame { get; set; }
		public static IState CurrentState { get; set; }
	}
}

