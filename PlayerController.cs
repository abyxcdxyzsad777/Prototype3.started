using System.Runtime.CompilerService;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private RigiBody playerRb; // khai báo biến điều khiển vật lý
    public float jumpForce = 10f; // lực nhảy
    public float gravityModifier; // hệ số trọng lực
    public bool isOnGround = true; // kiểm tra nhân vật có nhảy không
    public bool gameOver = false; // kiểm tra nhân vật có chạm đất không

    void Start()
    {
        playerRb = GetComponent<RigidBody>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        // nếu nhân vật ấn nút space và isOnGround = true thì
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // thêm lực nhảy
            isOnGround = false;
            // đặt lại để không nhảy tiếp
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    // kiểm tra va chạm
    {
        if (collision.gameObject.CompareTag("Ground"))
        // nếu va chạm với ground
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        // nếu va chạm với Obstacle
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}