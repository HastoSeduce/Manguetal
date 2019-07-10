using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    [SerializeField]private float speed = 0;
    private float horizontal;
    private TiroBehaviour forcaTiro;
    private float force;

    private InimigoBehaviour inimigo;
    void Start()
    {

    }

    void Update()
    {
        Movimentar();
        if(inimigo.GetComponent<InimigoBehaviour>().life <= 7)
        {
            speed = 12;
        }
    }

    void Movimentar()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Tiro")
        {
            collision.GetComponent<TiroBehaviour>().AtirarPlayer();

        }
    }
}
