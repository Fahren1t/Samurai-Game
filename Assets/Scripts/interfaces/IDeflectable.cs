using UnityEngine;

public interface IDeflectable
{
    public void Deflect(Vector2 direction);

    public float returnSpeed {  get; set; }
}
