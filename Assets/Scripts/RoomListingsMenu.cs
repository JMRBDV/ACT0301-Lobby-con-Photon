using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

/**
 * 
 */
public class RoomListingsMenu : MonoBehaviourPunCallbacks
{
    // Transform to instantiate the room list in.
    [SerializeField]
    private Transform content;
    
    // The room list.
    [SerializeField]
    private RoomListing roomListing;

    /**
     * Instantiates the room list element and sets the room info when a room is created.
     */
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