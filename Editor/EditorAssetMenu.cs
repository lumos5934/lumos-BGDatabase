using UnityEditor;

namespace LumosLib.BGDatabase
{
    public static class EditorAssetMenu
    {
        #region >--------------------------------------------------- SO

        
        [MenuItem("Assets/Create/Prefab/Manager/BGDatabase", false, int.MinValue)]
        public static void CreateBGManager()
        {
            LumosLib.EditorAssetMenu.CreatePrefab<BGManager>();
        }
        
        #endregion
    }
}