using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class creationSaveSystem
{
 
    public static void saveCreation(statManager player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/stats.bin";
        FileStream stream = new FileStream(path, FileMode.Create);

        creationData data = new creationData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static creationData LoadCreation()
    {
        string path = Application.persistentDataPath + "/stats.bin";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            creationData data = formatter.Deserialize(stream) as creationData;
            stream.Close();
            return data;
            

        } else
        {
            Debug.LogError("No Save File Found in " + path);
            return null;
        }
    }
}
