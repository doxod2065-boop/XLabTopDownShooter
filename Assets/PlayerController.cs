using Unity.VisualScripting;
using UnityEngine;

namespace Players
{
    public class PlayerController : MonoBehaviour
    {
    private void Start()
    {
    m_navMeshMouseResolver.Initialize(Camera.main);
    }

    private void Update()
    {
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
         
        }
    }
    }
}
