using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GestorPhoton : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
       PhotonNetwork.ConnectUsingSettings();
        //para poder conectarnos al servidor
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        //conecta al servidor
    }
    public override void OnJoinedLobby()
    //se conecta a un "cuarto"
    {
        PhotonNetwork.JoinOrCreateRoom("Cuarto", new RoomOptions { MaxPlayers = 2 }, TypedLobby.Default);
        //se une a un cuarto creado con sus respectivos parametros
    }
    public override void OnJoinedRoom()
    //lo que pasa si nos unimos a este cuarto
    {
        PhotonNetwork.Instantiate("Personaje", new Vector2(Random.Range(-7, 7), 2), Quaternion.identity);

        //instanciamos al jugador
    }
}
