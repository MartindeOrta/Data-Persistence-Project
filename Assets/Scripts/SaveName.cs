using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;

using System.IO;

public class SaveName : MonoBehaviour
{
    public string NombreText;
    public string NombrebestText;
    public int bestScore;
    public static SaveName instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
     
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    [System.Serializable]



    class saveDate
    {
        public string nameBestScore;
        public int bestScore;
    }


    public void SaveNameBestScore()
    {
        saveDate data = new saveDate();
        data.nameBestScore = NombreText;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "savefileName.json", json);

    }
    public void LoadNameBestScore()
    {
        string path = Application.persistentDataPath + "savefileName.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            saveDate data = JsonUtility.FromJson<saveDate>(json);
            NombrebestText  = data.nameBestScore;

        }



    }
    public void SavePointBest()
    {
        saveDate data = new saveDate();
        data.bestScore = bestScore;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "savefilePoint.json", json);

    }
    public void LoadPointBest()
    {
        string path = Application.persistentDataPath + "savefilePoint.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            saveDate data = JsonUtility.FromJson<saveDate>(json);
            bestScore = data.bestScore;

        }



    }
}
