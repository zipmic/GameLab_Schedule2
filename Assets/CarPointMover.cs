using UnityEngine;
using UnityEngine.Splines;

public class CarFollowSpline : MonoBehaviour
{
    public SplineContainer spline;
    public float duration = 10f;
    public bool loop = true;

    public float laneOffset = 1.5f; // positive = right lane, negative = left lane

    private float t = 0f;

    void Update()
    {
        if (spline == null) return;

        t += Time.deltaTime / duration;

        if (loop)
            t %= 1f;
        else
            t = Mathf.Clamp01(t);

        Vector3 pos = spline.EvaluatePosition(t);
        Vector3 forward = spline.EvaluateTangent(t);
        Vector3 up = spline.EvaluateUpVector(t);

        // Calculate right vector
        Vector3 right = Vector3.Cross(up, forward).normalized;

        // Apply lane offset
        pos += right * laneOffset;

        transform.position = pos;
        transform.rotation = Quaternion.LookRotation(forward, up);
    }
}
