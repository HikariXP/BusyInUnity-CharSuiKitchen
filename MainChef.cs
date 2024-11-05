/*
 * Copyright (c) PeroPeroGames Co., Ltd.
 * Author: CharSui
 * Created On: 2024.11.04
 * Description: Manage all chef and let them work
 *
 * Feature we need:
 * Define some Step we need : Build Asset? Import Asset? Build Player Script?
 * Set how long can one step cost : too long or endless is useless.
 * Start our rest time.
 */

using UnityEditor;

namespace CharSuiKitchen
{
	public class MainChef
	{
		// public List<BaseChef>
		//
		[MenuItem("Help/Take a Break...")]
		public static void StartBuildAsset()
		{
			new AssetBuildChef().Cook(null);
		}
		
		// private static Dictionary<string, BaseChef> chefs = new Dictionary<string, BaseChef>()
		// {
		// 	{"AssetBuildChef", new AssetBuildChef()}
		// };
		//
		// [MenuItem("Help/Take a Break...")]
		// public static void StartBuildAsset()
		// {
		// 	chefs["AssetBuildChef"].Cook(null);
		// }
	}
}