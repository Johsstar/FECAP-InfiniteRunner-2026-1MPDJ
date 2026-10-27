using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private float moveX;
    // Update is called once per frame
    void Update()
    {
        //Fazendo com que o obstáculo se mova para esquerda <-
        moveX = -1 * Time.deltaTime * moveSpeed;

        transform.Translate(moveX, 0, 0);
    }
}
