using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos; // vị trí bắt đầu
    private float RepeatWidth; // chiều rộng lặp lại

    void Start()
    {
        startPos = transform.position;
        // vị trí bắt đầu = vị trí hiện tại
        RepeatWidth = GetComponent<BoxCollider>().size.x / 2;
        // chiều rộng lặp lại bằng chiều rộng của box collider chia 2
    }
    
    void Update()
    {
        if (transform.position.x < startPos.x - RepeatWidth)
        // nếu vị trí x của đối tượng nhỏ hơn vị trí x bắt đầu trừ đi chiều rộng lặp lại
        {
            transform.position = startPos;
            // đặt lại vị trí của đối tượng về vị trí ban đầu
        }
    }
}