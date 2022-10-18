using UnityEngine;

public static class PlayerPrefsUtils
{
  /// <summary>
  /// Store object information to PlayerPrefs.
  /// Attach [Serializable] to the class or struct.
  /// Attach [SerializeField] to the variable you want to save.
  /// </summary>
  public static void SetObject<T>(string key, T obj)
  {
    var json = JsonUtility.ToJson(obj);
    PlayerPrefs.SetString(key, json);
  }

  /// <summary>
  /// Loads object information.
  /// </summary>
  /// <returns>obj</returns>
  public static T GetObject<T>(string key)
  {
    var json = PlayerPrefs.GetString(key);
    var obj = JsonUtility.FromJson<T>(json);
    return obj;
  }

  /// <summary>
  /// Loads object information.
  /// </summary>
  /// <returns>json</returns>
  public static string LoadAsJSON<T>(string key)
  {
    var json = PlayerPrefs.GetString(key);
    return json;
  }

  /// <summary>
  /// Check to see if it exists.
  /// </summary>
  /// <returns>Exists or not</returns>
  public static bool CheckExist(string key)
  {
    return PlayerPrefs.HasKey(key);
  }

}