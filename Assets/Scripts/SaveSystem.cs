using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class SaveSystem : MonoBehaviour
{

    public static void SavePlayer(PlayerData playerData)
    {

        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "player.save";

        FileStream file = new FileStream(path, FileMode.Create);

        formatter.Serialize(file, playerData);

        file.Close();

    }
    
    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "player.save";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;

            stream.Close();

            return data;
        }
        else
        {
            return null;
        }
    }
    
}
