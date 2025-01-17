using UnityEngine;

namespace Game.EnemyScripts
{
    public interface IDeflectable
    {
        //resend the entered object
        public void Deflect(Vector2 direction);

        //speed of the particle
        public float ReturnSpeed { get; set; }
    }
}