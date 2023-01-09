using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Text roomName;

    private RoomsCanvases _roomCanvases;

    public void FirstInitialize(RoomsCanvases canvases)
    {
        _roomCanvases = canvases;
    }

    public void OnClickCreateRoom()
    {
        if (!PhotonNetwork.IsConnected)
            return;

        RoomOptions options = new();
        options.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom("basic", options, TypedLobby.Default);

    }

    public override void OnCreatedRoom()
    {
//        base.OnCreatedRoom();
        Debug.Log("Created room.");
        _roomCanvases.CurrentRoomCanvas.Show();
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
//        base.OnCreatedRoomFailed(returnCode, message);
        Debug.Log("Room Creation failed: " + message);   
    }
    
}