using HarmonyLib;
using JetBrains.Annotations;

namespace DontFuckWithMyPlayButton.Patches
{
	[HarmonyPatch(typeof(ScoreSaber.UI.Other.ScoreSaberLeaderboardView), "SetPlayButtonState")]
	[UsedImplicitly]
	public class ScoreSaberPatch
	{
		[UsedImplicitly]
		// ReSharper disable once InconsistentNaming
		// ReSharper disable once RedundantAssignment
		private static void Prefix(ref bool state)
		{
			state = true;
		}
	}
}