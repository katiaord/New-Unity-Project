using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RedesDeJugador : MonoBehaviour
{
    public MonoBehaviour[] codigosQueIgnorar;

    private PhotonView photoView;
    // Start is called before the first frame update
    void Start()
    {
        photoView = GetComponent<PhotonView>();
        if (!photoView.IsMine)
        {
            foreach (var codigo in codigosQueIgnorar)
            {
                codigo.enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
