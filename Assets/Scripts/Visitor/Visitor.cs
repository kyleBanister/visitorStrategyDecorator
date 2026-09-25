using UnityEngine;

public interface VisitorInterface {
    void Visit(SpaceshipShield spaceshipShield);
    void Visit(SpaceshipMover spaceshipMover);
    void Visit(SpaceshipWeapon spaceshipWeapon);
}
