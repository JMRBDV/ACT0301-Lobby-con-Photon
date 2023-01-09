using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

/**
 * Changes the Room Listing text. 
 */
public class RoomListing : MonoBehaviourPunCallbacks {
    [SerializeField]
    private Text text;

    public RoomInfo RoomInfo { get; private set; }

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        RoomInfo = roomInfo;
        text.text = roomInfo.MaxPlayers + ", " + roomInfo.Name;
    }
}