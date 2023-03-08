using UnityEngine;

public class ScreenBox : MonoBehaviour
{
    public Vector2 minCamPos;
    public Vector2 maxCamPos;
    public bool isCurScreenBox;
    public Camera mainCamera;

    Vector2[] screenBoxCorners = new Vector2[4];
    void onDrawGizmos()
    {
        float halfCamHeight = mainCamera.orthographicSize;
        float halfCamWidth = halfCamHeight * mainCamera.aspect;

        Vector2 minSBDimentions = new Vector2(minCamPos.x - halfCamWidth + transform.position.x,
                                              minCamPos.y - halfCamHeight + transform.position.y);
        
        Vector2 maxSBDimentions = new Vector2(maxCamPos.x - halfCamWidth + transform.position.x,
                                              maxCamPos.y - halfCamWidth + transform.position.y);

        
        screenBoxCorners[0] = new Vector2(minSBDimentions.x, minSBDimentions.y);
        screenBoxCorners[1] = new Vector2(minSBDimentions.x, minSBDimentions.y);
        screenBoxCorners[2] = new Vector2(maxSBDimentions.x, maxSBDimentions.y);
        screenBoxCorners[3] = new Vector2(maxSBDimentions.x, maxSBDimentions.y);

        Gizmos.color = isCurScreenBox ? Color.green : Color.red;

        for(int i = 0; i < screenBoxCorners.Length; i++)
        {
            int nextPos = (i + 1) % 4;
            Gizmos.DrawLine(screenBoxCorners[i], screenBoxCorners[nextPos]);
        }
    }
}
