using UnityEngine;
using System.Collections;
using KK.Frame.Persist;

public class Demo : MonoBehaviour {
    IPersist persist = new PlayerPrefsPersist();

    void OnGUI()
    {
        if (GUILayout.Button("SaveInt", GUILayout.Width(100), GUILayout.Height(100)))
        {
            persist.SetInt("intKey", 999);            
            Debug.Log("<color=green>[log]</color>---" + "saveInt");
        }
        if (GUILayout.Button("GetInt", GUILayout.Width(100), GUILayout.Height(100)))
        {
            if (!persist.HasKey("intKey"))
            {
                Debug.LogWarning("<color=orange>[Warning]</color>---" + "不存在intKey");
            }
            else
            {
                Debug.Log("<color=green>[log]</color>---" + persist.GetInt("intKey"));
            }
        }
        if (GUILayout.Button("deleteInt", GUILayout.Width(100), GUILayout.Height(100)))
        {
            persist.DeleteKey("intKey");
            Debug.Log("<color=green>[log]</color>---" + "deleteInt");
        }
        if (GUILayout.Button("deleteAll", GUILayout.Width(100), GUILayout.Height(100)))
        {
            persist.DeleteAll();
            Debug.Log("<color=green>[log]</color>---" + "deleteAll");
        }

    }
}
