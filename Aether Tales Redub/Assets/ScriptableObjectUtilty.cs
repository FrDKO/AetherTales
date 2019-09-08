using UnityEngine;
using UnityEditor;
using System.IO;
 
public class ScriptableObjectUtility
{
	/// <summary>
	//	This makes it easy to create, name and place unique new ScriptableObject asset files.
	/// </summary>

	public void CreateAsset<T> (Card c) where T : ScriptableObject
	{
		Card asset = c;
 
	
 
		string assetPathAndName =   "Assets/Cards/" + asset.cardName + ".asset";
 
		AssetDatabase.CreateAsset (asset, assetPathAndName);
		AssetDatabase.SaveAssets ();
        AssetDatabase.Refresh();
		EditorUtility.FocusProjectWindow ();
		Selection.activeObject = asset;
	}
}