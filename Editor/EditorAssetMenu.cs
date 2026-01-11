using UnityEditor;

namespace Lumos.Firebase
{
    public static class EditorAssetMenu
    {
        #region >--------------------------------------------------- SO

        
        [MenuItem("Assets/Create/Prefab/Manager/BGDatabase", false, int.MinValue)]
        public static void CreateBGManager()
        {
            Lumos.EditorAssetMenu.CreatePrefab<BGManager>();
        }
        
        #endregion
    }
}