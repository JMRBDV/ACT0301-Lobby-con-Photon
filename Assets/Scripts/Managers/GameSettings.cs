using UnityEngine;

[CreateAssetMenu(menuName="Singletons/GameSettings")]
public class GameSettings : ScriptableObject
{
    [SerializeField]
    private string gameVersion = "0.0.0";
    public string GameVersion
    {
        get => gameVersion;
    }

    [SerializeField]
    private string _nickName = "JMaster";
    public string NickName
    {
        get
        {
            var value = Random.Range(0, 10000);
            return _nickName + value;
        }
    }
}