using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody projectilePrefab;
    private bool launchAvailable = true;
    public int speed;
    public int torqueSpeed;
    public Transform projectileSpawnPoint;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    public void Update()
    {
        while (Input.GetKeyDown(KeyCode.Space) && launchAvailable == true && gameManager.isGameActive == true)
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation) as Rigidbody;
            projectileInstance.AddForce(new Vector3(-1, 1, 0) * speed, ForceMode.Impulse);
            projectileInstance.AddTorque(Vector3.back * torqueSpeed);
            StartCoroutine(WaitToLaunch());
        }
    }

    IEnumerator WaitToLaunch()
    {
        launchAvailable = false;
        yield return new WaitForSeconds(0.5f);
        launchAvailable = true;
    }
}
