using UnityEngine;

[CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUp")]
public class PowerUp: ScriptableObject, VisitorInterface {
    public string PowerUpName;
    public GameObject PowerUpPrefab;
    public string powerupDescription;

    [Tooltip("Fully heal shield")]
    public bool healShield;

    [Range(0.0f, 50f)]
    [Tooltip("Boost turbo settings up to increments of 50/mph")]
    public float turboBoost;

    [Range(0.0f, 50f)]
    [Tooltip("Boost weapon strength in increments of up to 50%")]
    public float weaponStrength;


    public void Visit(SpaceshipShield spaceshipShield) {
        if(healShield) {
            spaceshipShield.health = 100f;
        }
    }
    public void Visit(SpaceshipMover spaceshipMover) {
        float boost = spaceshipMover.turboBoost += turboBoost;
        if (boost < 0.0f) {
            spaceshipMover.turboBoost = 0.0f;
        }
        if (boost >= spaceshipMover.maxTurboBoost) {
            spaceshipMover.turboBoost = spaceshipMover.maxTurboBoost;
        }
    }
    public void Visit(SpaceshipWeapon spaceshipWeapon) {
        float strength = spaceshipWeapon.strength += Mathf.Round(spaceshipWeapon.strength*weaponStrength/100);
        if (strength >= spaceshipWeapon.maxStrength) {
            spaceshipWeapon.strength = spaceshipWeapon.maxStrength;
        } else {
            spaceshipWeapon.strength = strength;
        }
    }
}
