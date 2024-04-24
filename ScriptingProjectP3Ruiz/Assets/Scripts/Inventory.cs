using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int gernades;
        public int rockets;
        public float fual;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            gernades = gre;
            rockets = roc;
        }

        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fual = fu;
        }

        // Constructor
        public Stuff ()
        {
            bullets = 1;
            gernades = 1;
            rockets = 1;
        }
    }

    // Creating an Instance (an Object) of the SStuff class
    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50,  1.5f);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
