using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaJugador : MonoBehaviour
{
    public float velocidad; 
    //velocidad del personaje
    public float fuerzaSalto; 
    //fuerza de salto del personaje
    public float posX; 
    //movimiento del personaje de izq a der
    public Rigidbody2D rb; 
    //con este componente el personaje realiza el salto

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        posX = Input.GetAxis("Horizontal");
        //obtiene el valor de los botones presionados 
        transform.position += (Vector3)new Vector2(posX * velocidad * Time.deltaTime, 0f);
        // dependiendo la tecla que se precione el personaje se movera de cierta manera

        if (Input.GetKeyDown(KeyCode.Space))
        // si apreto el space en el teclado...
        {
            rb.AddForce(transform.up * fuerzaSalto, ForceMode2D.Impulse);
            // se le da un impulso
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Limite")
        // si el personaje choca con un limite..
        {
            Destroy(gameObject);
            //se destruye
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
