using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystemVisualSingle : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;

    public void Show(Material materail)
    {
        meshRenderer.enabled = true;
        meshRenderer.material = materail;
    }

    public void Hide()
    {
        meshRenderer.enabled = false;
    }
}
