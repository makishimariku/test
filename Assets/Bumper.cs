using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class Bumper : MonoBehaviour
    {
        public float bounce = 10f;
        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Ball")
            {
                other.rigidbody.AddForce(0f, bounce / 2, -bounce, ForceMode.Impulse);
            }
        }
 }
