using UnityEngine;

namespace Script.D
{
    public class Sword : IWeapon
    {
        public void OnUseWeapon()
        {
            Debug.Log("Kilic kullaniliyor.");
        }
    }
}
