using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfficherScore : MonoBehaviour
{
    public GameObject textScore;
    public GameObject scoreTrigger;

    void Update() 
    {
        int scoreJoueur = scoreTrigger.GetComponent<Score>().scoreJoueur;
        int scoreAdversaire = scoreTrigger.GetComponent<Score>().scoreAdversaire;
        printScore(scoreJoueur, scoreAdversaire);
    }

    public void printScore(int scoreJoueur,int scoreAdv)
    {
        this.textScore.GetComponent<TextMesh>().text = scoreJoueur + " - " + scoreAdv;
    }
}
