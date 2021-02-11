using System.Reflection;
using HarmonyLib;
using IPA;
using IPA.Logging;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace DontFuckWithMyPlayButton
{
	[Plugin(RuntimeOptions.DynamicInit)]
	public class Plugin
	{
		private const string HARMONY_ID = "com.github.kevga.playbutton";
		private Harmony _harmonyInstance = null!;
		public static Logger Logger = null!;

		[Init]
		public void Init(Logger ipaLogger)
		{
			Logger = ipaLogger;
		}

		[OnEnable]
		public void OnEnable()
		{
			_harmonyInstance = new Harmony(HARMONY_ID);
			_harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
		}

		[OnDisable]
		public void OnDisable()
		{
			_harmonyInstance.UnpatchAll(HARMONY_ID);
		}
	}
}