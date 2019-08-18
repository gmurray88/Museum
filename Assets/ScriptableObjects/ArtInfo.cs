using UnityEngine;

[CreateAssetMenu(menuName = "My Objects/Art Info")]
public class ArtInfo : ScriptableObject
{
    public Texture image;
    public string title;
    public string artist;
    public float orig_height;
    public float orig_width;
    [Multiline]
    public string description;
}