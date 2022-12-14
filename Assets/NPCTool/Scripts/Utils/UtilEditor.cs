using UnityEngine;

/* util that provide the necessary misc for the editor */

namespace EdgarDev.NPCTool.Utils
{
	public class UtilEditor
	{
		private static GUIStyle button_fixed_big_height;
		public static GUIStyle BUTTON_FIXED_BIG_HEIGHT
		{
			get
			{
				if (button_fixed_big_height == null)
				{
					button_fixed_big_height = new GUIStyle(GUI.skin.button);
					button_fixed_big_height.fixedHeight = 40;
				}
				return button_fixed_big_height;
			}
		}

		private static GUIStyle button_fixed_mid_height;
		public static GUIStyle BUTTON_FIXED_MID_HEIGHT
		{
			get
			{
				if (button_fixed_mid_height == null)
				{
					button_fixed_mid_height = new GUIStyle(GUI.skin.button);
					button_fixed_mid_height.fixedHeight = 20;
				}
				return button_fixed_mid_height;
			}
		}

		public static void ClearLog()
		{
			var assembly = System.Reflection.Assembly.GetAssembly(typeof(UnityEditor.Editor));
			var type = assembly.GetType("UnityEditor.LogEntries");
			var method = type.GetMethod("Clear");
			method.Invoke(new object(), null);
		}

		[UnityEditor.Callbacks.DidReloadScripts()]
		private static void OnScriptsReloaded()
		{
			ClearLog();

/*			Debug.LogWarning("UNSTABLE : Clear logs (after reload on editor window scripts bug)");
			UtilNPC.GetMinMaxOfScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene());*/
		}
	}
}