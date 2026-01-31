using UnityEditor.UI;
using UnityEngine;

public class MaskPickup : Interactible
{
    [SerializeField] MaskType maskType;

    public override void OnInteract()
    {
        FindFirstObjectByType<PlayerController>().ObtainMask(maskType);
        gameObject.SetActive(false);
    }
}
