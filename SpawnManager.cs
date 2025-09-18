using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefabs; // đối tượng để spawn
    private Vector3 spawnPos = new Vector3(25, 0 ,0); // vị trí spawn
    private float startDelay = 2; // thời gian bắt đầu
    private float repeatRate = 2; // thời gian lặp lại
    private PlayerController playerControllerScripts;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        // gọi hàm SpawnObstacle lặp lại với thời gian bắt đầu, thời gian lặp lại
        playerControllerScripts = gameObject.Find("Player").GetComponent<PlayerController>();
        // tìm đối tượng player gắn component PlayerController.cs
    }
    
    void SpawnObstacle()
    {
        if (playerControllerScripts.gameOver == false)
        // nếu game chưa kết thúc
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            // khởi tạo đối tượng obstaclePrefabs tại vị trí spawnPos và góc xoay cố định
        }
    }

    void Update()
    {
        
    }
}