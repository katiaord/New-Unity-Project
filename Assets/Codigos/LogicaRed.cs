using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LogicaRed : MonoBehaviourPunCallbacks
{
    public static LogicaRed intancia;
    void Awake()
    {
        intancia = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Estas conectado");
    }
}
