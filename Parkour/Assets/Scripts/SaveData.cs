using System.IO; 
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine; 

[System.Serializable]
public class Data
{
    public float sensitivity { get; private set; }
    public Data(float s)
    { 
        this.sensitivity = s;
    }
}

public static class SaveMe
{
    static string path = $"{Application.persistentDataPath}/Data.me";
    
    public static void Save(Data data)
    {
        BinaryFormatter formatter = new BinaryFormatter(); 
        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, data);
        stream.Close(); 
    }

    public static Data Load()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Data data = formatter.Deserialize(stream) as Data;
            stream.Close();
            return data; 
        }
        else
        {
            return new Data(250f); 
        }
    }
}