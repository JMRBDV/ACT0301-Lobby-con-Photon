using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using Unity.IO.LowLevel.Unsafe;
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

    private List<RoomListing> _listings;

    /**
     * Instantiates the room list element and sets the room info when a room is created.
     */
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach (RoomInfo  info in roomList){

            if (info.RemovedFromList)
            {
                int index = _listings.FindIndex(x => x.RoomInfo.Name == info.Name);
                if (index != -1)
                {
                    Destroy(_listings[index].gameObject);
                    _listings.RemoveAt(index);
                }
            }
            else
            {
                RoomListing listing = Instantiate(roomListing, content);
                if (listing != null)
                    listing.SetRoomInfo(info);
            }

        }
        
 
        
    }
}