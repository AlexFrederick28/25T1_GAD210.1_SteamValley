using System.Collections;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    //private Ray upRay;
    //private Ray downRay;
    //private Ray rightRay;
    //private Ray leftRay;

    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject mouse;

    [SerializeField] private float shootTime = 1f;
    [SerializeField] private float shootCounter;

    public Vector3 shootTowardsMouse;

    private void Update()
    {
        //HitDetection();

        ShootProjectile();
    }

    //private void HitDetection()
    //{
    //    Vector3 rayUp = transform.TransformDirection(Vector3.up) * 2;
    //    Debug.DrawRay(transform.position, rayUp, Color.white);
    //    upRay = new Ray(transform.position, rayUp);

    //    Vector3 rayDown = transform.TransformDirection(Vector3.down) * 2;
    //    Debug.DrawRay(transform.position, rayDown, Color.white);
    //    downRay = new Ray(transform.position, rayDown);

    //    Vector3 rayRight = transform.TransformDirection(Vector3.right) * 2;
    //    Debug.DrawRay(transform.position, rayRight, Color.white);
    //    rightRay = new Ray(transform.position, rayRight);

    //    Vector3 rayLeft = transform.TransformDirection(Vector3.left) * 2;
    //    Debug.DrawRay(transform.position, rayLeft, Color.white);
    //    leftRay = new Ray(transform.position, rayLeft);

    //    if (Physics.Raycast(upRay, out RaycastHit hit))
    //    {
    //        Debug.Log(hit.collider.gameObject.name + " Was hit!");
    //    }
    //}

    private void ShootProjectile()
    {
        shootTowardsMouse = new Vector3(mouse.transform.position.x - transform.position.x, mouse.transform.position.y - transform.position.y, 0).normalized;

        shootCounter += Time.deltaTime;

        if (shootCounter >= shootTime)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);

            shootCounter = 0;
        }
    }

   
}
