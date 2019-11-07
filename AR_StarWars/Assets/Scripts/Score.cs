using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject adversaire;
    public GameObject joueur;
    public GameObject startAdversaire;
    public GameObject startJoueur;
    public GameObject textVictoire;
    public GameObject textDefaite;
    public int scoreJoueur;
    public int scoreAdversaire;
    const int SCORE_MAX = 3;

    // Start is called before the first frame update
    void Start()
    {
        textVictoire.SetActive(false);
        textDefaite.SetActive(false);
        scoreAdversaire = 0;
        scoreJoueur = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Adversaire")
        {
            scoreJoueur++;
        }
        else if(other.tag=="Player")
        {
            scoreAdversaire++;
        }

        GameObject.Find("Game").GetComponent<TimeControl>().Wait(3);

        if(scoreJoueur == SCORE_MAX || scoreAdversaire == SCORE_MAX)
        {
            StartCoroutine(AfficherFinPartie());
            scoreJoueur = 0;
            scoreAdversaire = 0;
        }

        this.adversaire.transform.position = this.startAdversaire.transform.position;
        this.adversaire.transform.rotation = this.startAdversaire.transform.rotation;
        this.joueur.transform.position = this.startJoueur.transform.position;
        this.joueur.transform.position = this.startJoueur.transform.position;
    }

    private IEnumerator AfficherFinPartie()
    {
        if(scoreJoueur > scoreAdversaire)
        {
            textVictoire.SetActive(true);
        }
        else
        {
            textDefaite.SetActive(true);
        }

        while(Time.timeScale == 0)
        {
            yield return 0;
        }
        textVictoire.SetActive(false);
        textDefaite.SetActive(false);
    }
}
