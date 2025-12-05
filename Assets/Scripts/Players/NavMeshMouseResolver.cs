using JetBrains.Annotations;
using UnityEngine;

public class NavMeshMouseResolver : MonoBehaviour
{
    [SerializeField] private LayerMask m_layerMask;
    [SerializeField][Min(0)] private float m_raycastDistance = 1000f;
    [SerializeField][Min(0)] public float m_maxRaycastDistance = 100f;

    private Camera m_camera;

    public Vector3? GetNavMeshPoint(Vector3 mousePosition)
    {
        var ray = m_camera.ScreenPointToRay(mousePosition);

        if (Physics.Raycast(ray, out RaycasterHit hit, m_raycastDistance, m_layerMask))
        {
            if (NavMesh.SamplePosition)
        }
    }
}
