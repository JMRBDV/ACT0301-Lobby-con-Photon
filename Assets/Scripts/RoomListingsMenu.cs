using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class RoomListingsMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Transform content;
    [SerializeField]
    private RoomListing roomListing;

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
//        base.OnRoomListUpdate(roomList);
        foreach (RoomInfo info in roomList)
        {
            RoomListing listing = Instantiate(roomListing, content);
            if (listing != null)
                listing.SetRoomInfo(info);
        }
    }
}