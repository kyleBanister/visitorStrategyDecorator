using UnityEngine;

public class SpaceshipMover : MonoBehaviour, SpaceshipElementInterface {
    private bool _isTurboOn;
    public float turboBoost = 25f;
    public float maxTurboBoost = 200f;
    private float _defaultSpeed = 300.0f;

    public float CurrentSpeed {
        get {
            if (_isTurboOn) {
                return _defaultSpeed + turboBoost;
            }
            return _defaultSpeed;
        }
    }

    public void ToggleTurbo() {
        _isTurboOn = !_isTurboOn;
    }

    public void Accept(VisitorInterface visitor) {
        visitor.Visit(this);
    }

    void OnGUI() {
        GUI.color = Color.green;
        GUI.Label(new Rect(125, 20, 200, 20), "Turbo Boost: " + turboBoost);
    }
}
