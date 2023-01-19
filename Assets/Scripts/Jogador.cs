using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float salu;
    public float direccione;
    public float damageru;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Estas yendo a " + direccione);
        Debug.Log(message: $"Tu salú es {salu}");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: $"No hay problema!");

        MasDamageru();

        salu --;

        MoviditoMovidito();
    }

    void MoviditoMovidito()
    {
        transform.position += new Vector3 (direccione, 0f, 0f) * Time.deltaTime;
    }

    void MasDamageru()
    {
        damageru++;
    }
}
