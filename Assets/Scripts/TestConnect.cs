using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class TestConnect : MonoBehaviourPunCallbacks
{
    private void Start()
    {
//        PhotonNetwork.ConnectToMaster();
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Connecting to server");

    }

    public override void OnConnectedToMaster()
    {
//        base.OnConnectedToMaster();
        Debug.Log("Connected to server");
        Debug.Log(PhotonNetwork.LocalPlayer.NickName);

    }

    public override void OnDisconnected(DisconnectCause cause)
    {
//        base.OnDisconnected(cause);
        Debug.Log("Disconnected for: " + cause);
//        DisconnectedCause.
    }

}