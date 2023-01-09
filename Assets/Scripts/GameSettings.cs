using UnityEngine;
/**
 * Stores PUN 2 net settings.
 */
[CreateAssetMenu(menuName="Singletons/GameSettings")]
public class GameSettings : ScriptableObject
{
    [SerializeField]
    private string gameVersion = "0.0.0";
    /**
     * Game version net identifier.
     */
    public string GameVersion
    {
        get => gameVersion;
    }

    [SerializeField]
    private string _nickName = "JMaster";
    
    /**
     * Player nickname.
     */
    public string NickName
    {
        get
        {
            // TODO: Random name just for test purposes.
            var value = Random.Range(0, 10000);
            return _nickName + value;
        }
    }
}