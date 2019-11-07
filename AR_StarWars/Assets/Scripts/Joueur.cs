using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    private DeplacementRobot deplacementRobot;
    // Start is called before the first frame update
    void Start()
    {
        deplacementRobot = this.GetComponent<DeplacementRobot>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.Z))
            {
                deplacementRobot.Avancer(1);
            }
            if (Input.GetKey(KeyCode.S))
            {
                deplacementRobot.Avancer(-1);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                deplacementRobot.Tourner(-1);
            }
            if (Input.GetKey(KeyCode.D))
            {
                deplacementRobot.Tourner(1);
            }

    }
}
