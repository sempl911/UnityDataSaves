using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;
    public string userName;
    public int bestScore;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string name;
        public int bestScore;

    }
        public void SaveDataPlayer()
        {
            SaveData dataName = new SaveData();

            dataName.name = userName;
            dataName.bestScore = bestScore;

            string json = JsonUtility.ToJson(dataName);

            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("saved");
        }
        public void LoadDataPlayer()
        {
            string path = Application.persistentDataPath + "/savefile.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                SaveData data = JsonUtility.FromJson<SaveData>(json);
                userName = data.name;
                bestScore = data.bestScore;
            Debug.Log("Loaded" + userName);
            }
        }
    
}
