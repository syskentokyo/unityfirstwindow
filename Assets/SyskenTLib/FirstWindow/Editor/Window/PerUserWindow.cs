using UnityEditor;
using UnityEngine;

namespace SyskenTLib.FirstWindowsEditor.Window
{
    public class PerUserWindow : EditorWindow
    {
        [MenuItem("SyskenTLib/FirstWindow/PerUserWindow",priority = 9)]
        public static void ShowWindow()
        {
            var window = GetWindow<PerUserWindow>();
            window.titleContent = new GUIContent("PerUserWindow");
            window.Show();
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginVertical("Box");

            
                        
            EditorGUILayout.LabelField("Init");
            
                        
            EditorGUILayout.Space(5);
            EditorGUILayout.LabelField("Initボタンを押すと、プロジェクトのユーザごとの設定ファイルに、初期化したことを保存します。");
            EditorGUILayout.LabelField("他の人が同じプロジェクトを開くと、初期化してないことなります。");
            if (GUILayout.Button("Delete Key"))
            {
                TouchedDeleteKeyButton();
            }


            
            
            if (GUILayout.Button("Init1"))
            {
                InitCommon();
                TouchedInit1Button();
            }
            
            EditorGUILayout.Space(10);
            if (GUILayout.Button("Init2"))
            {
                InitCommon();
                TouchedInit2Button();
            }
            
            EditorGUILayout.Space(10);
            EditorGUILayout.Space(10);

            
            EditorGUILayout.EndVertical();
        }


        private void InitCommon()
        {
            //Init実行したことを保存する
            SaveDataManager saveDataManager = new SaveDataManager();
            saveDataManager.SaveUserConfig();
        }

        private void TouchedInit1Button()
        {
            this.Close();
        }
        
        private void TouchedInit2Button()
        {
            this.Close();
        }
        
        private void TouchedDeleteKeyButton()
        {
            //もう１度、初回表示されるようにします。
            SaveDataManager saveDataManager = new SaveDataManager();
            saveDataManager.RemoveUserConfig();
        }
    }
}