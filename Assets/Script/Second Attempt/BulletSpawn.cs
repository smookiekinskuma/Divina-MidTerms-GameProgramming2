using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public KILL kill;
    public Machine machine;

    public Transform spawnBulletHere;
    public GameObject RedbulletPrefab, YellowbulletPrefab, GreenbulletPrefab, BluebulletPrefab, PurplebulletPrefab;

    public float bulletSpeed;

    public float fireRate = 1;

    private float BaseFireRate;

    // Start is called before the first frame update
    void Start()
    {
        BaseFireRate = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        fireRate -= Time.deltaTime;
        if (fireRate <= 0)
        {
            if (machine.bbulletRed == true)
            {
                ShootRed();
            }
            if (machine.bbulletYellow == true)
            {
                ShootYellow();
            }
            if (machine.bbulletGreen == true)
            {
                ShootGreen();
            }
            if (machine.bbulletBlue == true)
            {
                ShootBlue();
            }
            if (machine.bbulletPurple == true)
            {
                ShootPurple();
            }
        }
    }
    
    //Separate Bullets
    void ShootRed()
    {
        GameObject bullet = Instantiate(RedbulletPrefab, spawnBulletHere.position, spawnBulletHere.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();

        bulletRB.AddForce(spawnBulletHere.forward * bulletSpeed, ForceMode.Impulse);
        fireRate = BaseFireRate;
    }

    void ShootYellow()
    {
        GameObject bullet = Instantiate(YellowbulletPrefab, spawnBulletHere.position, spawnBulletHere.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();

        bulletRB.AddForce(spawnBulletHere.forward * bulletSpeed, ForceMode.Impulse);
        fireRate = BaseFireRate;
    }
    void ShootGreen()
    {
        GameObject bullet = Instantiate(GreenbulletPrefab, spawnBulletHere.position, spawnBulletHere.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();

        bulletRB.AddForce(spawnBulletHere.forward * bulletSpeed, ForceMode.Impulse);
        fireRate = BaseFireRate;
    }
    void ShootBlue()
    {
        GameObject bullet = Instantiate(BluebulletPrefab, spawnBulletHere.position, spawnBulletHere.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();

        bulletRB.AddForce(spawnBulletHere.forward * bulletSpeed, ForceMode.Impulse);
        fireRate = BaseFireRate;
    }
    void ShootPurple()
    {
        GameObject bullet = Instantiate(PurplebulletPrefab, spawnBulletHere.position, spawnBulletHere.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();

        bulletRB.AddForce(spawnBulletHere.forward * bulletSpeed, ForceMode.Impulse);
        fireRate = BaseFireRate;
    }
}
