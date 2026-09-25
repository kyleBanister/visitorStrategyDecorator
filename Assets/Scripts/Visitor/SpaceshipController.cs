using UnityEngine;
using System.Collections.Generic;

public class SpaceshipController : MonoBehaviour, SpaceshipElementInterface {
    private List<SpaceshipElementInterface> _spaceshipElements = 
        new List<SpaceshipElementInterface>();

    void Start() {
        _spaceshipElements.Add(gameObject.AddComponent<SpaceshipShield>());
        _spaceshipElements.Add(gameObject.AddComponent<SpaceshipMover>());
        _spaceshipElements.Add(gameObject.AddComponent<SpaceshipWeapon>());
    }

    public void Accept(VisitorInterface visitor) {//Shield Mover Weapon
        
        foreach (SpaceshipElementInterface element in _spaceshipElements) {
            element.Accept(visitor);
        }
    }
}
