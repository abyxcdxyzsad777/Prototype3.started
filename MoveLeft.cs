using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20f; // tốc độ dịch chuyển sang trái
    private float leftBound = -15f; // giới hạn trái
    private PlayerController playerControllerScripts; // khai báo scripts PlayerController

    void Start()
    {
        playerControllerScripts = gameObject.Find("Player").GetComponent<PlayerController>();
        // tìm đối tượng player gắn component PlayerController
    }
    
    void Update()
    {
        if (playerControllerScripts.gameOver == false)
        // nếu game chưa kết thúc
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            // di chuyển đối tượng sang trái với tốc độ speed
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        // nếu vị trí x của đối tượng nhỏ hơn giới hạn trái và đối tượng có tag là Obstacle
        {
            Destroy(gameObject);
        }
    }
}
