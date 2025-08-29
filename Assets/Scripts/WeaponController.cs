using UnityEngine;

public class WeaponController : MonoBehaviour
{

    private Player player;

    void Start()
    {
        player = GetComponentInParent<Player>();
        player.controls.Character.Fire.performed += context => Shoot();
    }
    
    private void Shoot()
    {
        GetComponentInChildren<Animator>().SetTrigger("Fire");
    }
}
