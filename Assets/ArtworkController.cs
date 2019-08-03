using UnityEngine;

public class ArtworkController : MonoBehaviour
{
    public GameObject image;

    public void SetArtInfo(ArtInfo info)
    {
        Renderer rend = image.GetComponent<Renderer>();
        Material material = rend.material;
        material.mainTexture = info.image;
    }
}