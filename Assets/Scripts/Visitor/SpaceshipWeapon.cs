using UnityEngine;

public class SpaceshipWeapon : MonoBehaviour, SpaceshipElementInterface {
    
    void OnGUI() {
        GUI.color = Color.green;

        GUI.Label(new Rect(125, 40, 200, 20),"Weapon Strength: " + strength);
    }

    [Header("Range")]
    public int range = 25;

    [Header("Strength")]
    public float strength = 25.0f;
    public float maxStrength = 50.0f;

    public void Fire() {
        
    }

    public void Accept(VisitorInterface visitor) {
        visitor.Visit(this);
    }
}
