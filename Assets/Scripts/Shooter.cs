using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    


    void Update()
    {
        var pos = new Vector2((float)(transform.position.x + 1.3), (float)(transform.position.y + 0.3));
        if (Input.GetButtonDown("Fire1"))
        {
            var projectile = Instantiate(
                projectilePrefab,
                pos,
                projectilePrefab.transform.rotation);

        }

    }
}
