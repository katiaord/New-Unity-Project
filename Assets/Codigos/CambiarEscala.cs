using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarEscala : MonoBehaviour
{
    public float aumentarTama�o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(aumentarTama�o, aumentarTama�o, 1) * Time.deltaTime;
    }
 
}
