using UnityEditor;

namespace LumosLib.BGDatabase.Editor
{
    public static class EditorAssetMenu
    {
        #region >--------------------------------------------------- SO

        
        [MenuItem("Assets/Create/Prefab/Manager/BGDatabase", false, int.MinValue)]
        public static void CreateBGManager()
        {
            LumosLib.Editor.EditorAssetMenu.CreatePrefab<BGManager>();
        }
        
        #endregion
    }
}