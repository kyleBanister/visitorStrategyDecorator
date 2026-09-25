using UnityEngine;

public class ClientVisitor : MonoBehaviour {
    public PowerUp moverPowerUp;
    public PowerUp shieldPowerUp;
    public PowerUp weaponPowerUp;

    private SpaceshipController _spaceshipController;

        void Start() {
            _spaceshipController = gameObject.AddComponent<SpaceshipController>();
        }
    void OnGUI() {
        if (GUILayout.Button("PowerUp Shield")) {
            _spaceshipController.Accept(shieldPowerUp);
        }

        if (GUILayout.Button("PowerUp Mover")) {
            _spaceshipController.Accept(moverPowerUp);
        }

        if (GUILayout.Button("PowerUp Weapon")) {
            _spaceshipController.Accept(weaponPowerUp);
        }
    }
}
