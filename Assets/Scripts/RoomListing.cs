using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class RoomListing : MonoBehaviourPunCallbacks {
    [SerializeField]
    private Text text;

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        text.text = roomInfo.MaxPlayers + ", " + roomInfo.Name;
    }
}