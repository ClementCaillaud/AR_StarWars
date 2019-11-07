using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementRobot : MonoBehaviour
{
    #region Constantes

    const float GRAVITY = 9.81f;

    #endregion

    #region Paramètres

    public float speed;
    public float rotationSpeed;
    public GameObject referentiel;

    #endregion
    
    #region Variables globales

    private bool useGravity;

    #endregion
    
    #region Start and Update

    // Start is called before the first frame update
    void Start()
    {
        useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(useGravity)
        {
            ApplyReferentialGravity();
        }

        KeepOrientation();
        
    }

    #endregion

    #region Event trigger

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground")
        {
            useGravity = false;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Ground")
        {
            useGravity = true;
        }
    }

    #endregion

    #region Physics

    private void ApplyReferentialGravity()
    {
        Vector3 gravityForce = referentiel.transform.TransformDirection(new Vector3(0, -GRAVITY*100, 0)) * Time.deltaTime;
        this.GetComponent<Rigidbody>().AddForce(gravityForce);   
    }

    private void KeepOrientation()
    {
        Vector3 orientation = referentiel.transform.localEulerAngles;
        this.transform.localEulerAngles = new Vector3(orientation.x, this.transform.localEulerAngles.y, orientation.z);
    }

    #endregion

    #region Public methods

    public void Avancer(int direction)
    {
        Vector3 deplacement = this.transform.TransformDirection(new Vector3(direction, 0, 0)) * speed * Time.deltaTime;
        this.GetComponent<Rigidbody>().AddForce(deplacement);
    }

    public void Tourner(int direction)
    {
       this.transform.localEulerAngles += new Vector3(0, direction, 0) * rotationSpeed * Time.deltaTime; 
    }

    #endregion
}
