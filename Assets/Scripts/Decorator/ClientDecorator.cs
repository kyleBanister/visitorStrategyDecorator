using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    private SpaceshipWeaponSystem _spaceshipWeapon;
    private bool _isWeaponDecorated;

    void Start() {
        _spaceshipWeapon = (SpaceshipWeaponSystem) FindAnyObjectByType(typeof(SpaceshipWeaponSystem));
    }

    void OnGUI() {
        GUILayout.Space(90);
        if (!_isWeaponDecorated) { 
            if (GUILayout.Button("Decorate Weapon")) {
                _spaceshipWeapon.Decorate();
                _isWeaponDecorated = !_isWeaponDecorated;
            }
        }

        if (_isWeaponDecorated) {
            if (GUILayout.Button("Reset Weapon")) {
                _spaceshipWeapon.Reset();
                _isWeaponDecorated = !_isWeaponDecorated;
            }
        }

        if (GUILayout.Button("Toggle Fire")) {
            _spaceshipWeapon.ToggleFire();
        }
    }
}
