using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adversaire : MonoBehaviour
{
    public GameObject joueur;
    private DeplacementRobot deplacementRobot;
    // Start is called before the first frame update
    void Start()
    {
        deplacementRobot = this.GetComponent<DeplacementRobot>();

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.localPosition.y >= joueur.transform.localPosition.y - 0.2)
        transform.position = Vector3.Lerp(transform.position, joueur.transform.position, deplacementRobot.speed * Time.deltaTime * 0.001f);

    }
}
