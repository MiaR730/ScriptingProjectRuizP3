using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int gernaades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            gernaades = gre;
            rockets = roc;
        }
    }

    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletprefab;
    public Transform firePosition;
    public float bulletSpeed;


    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }

    void Movement ()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

    void Shoot ()
    {
        if(Input.GetButtonDown("Fire") && myStuff.bullets > 0) 
        {
            Rigidbody bulletInstance = Instantiate(bulletprefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }
}
