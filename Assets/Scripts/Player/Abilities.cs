using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Abilities : MonoBehaviour
{

    [SerializeField] private PlayerStats _PlayerStats;

    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject arrow;
    [SerializeField] private GameObject mouse;

    public float shootTime = 1f;
    [SerializeField] private float shootCounter;

    public Vector3 shootTowardsMouse;
    public Vector3 spawnPosition;

    private void Update()
    {
        GetReferences();

        //HitDetection();
        spawnPosition = projectile.transform.position;

        ShootProjectile();

        ShootArrow();
    }

    private void ShootProjectile()
    {
        if (_PlayerStats.magicStaffPrefab.activeInHierarchy)
        {
            shootTowardsMouse = new Vector3(mouse.transform.position.x - spawnPosition.x, mouse.transform.position.y - spawnPosition.y, 0).normalized;

            shootCounter += Time.deltaTime;

            if (shootCounter >= shootTime)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Instantiate(projectile, transform.position, Quaternion.identity);

                    shootCounter = 0;
                }
            }
        }
    }

    private void ShootArrow()
    {
        if (_PlayerStats.bowPrefab.activeInHierarchy)
        {
            shootTime = 1;

            shootTowardsMouse = new Vector3(mouse.transform.position.x - spawnPosition.x, mouse.transform.position.y - spawnPosition.y, 0).normalized;

            shootCounter += Time.deltaTime;

            if (shootCounter >= shootTime)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Instantiate(arrow, transform.position, Quaternion.identity);

                    shootCounter = 0;
                }
            }
        }
    }

    //private void ActivateSword()
    //{
    //    if (_PlayerStats.swordPrefab.activeInHierarchy)
    //    {
            
    //    }
    //}

    private void GetReferences()
    {
        if (_PlayerStats == null)
        {
            _PlayerStats = FindAnyObjectByType<PlayerStats>();
        }
    }

   
}
