using UnityEngine;
using System;

public class Pickup : MonoBehaviour {
    public PowerUp powerup;

    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<SpaceshipController>()) {
            other.GetComponent<SpaceshipController>().Accept(powerup);
            Destroy(gameObject);
        }
    }
}
