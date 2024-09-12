using UnityEngine;

namespace Script.D
{
    public class Axe : IWeapon
    {
        public void OnUseWeapon()
        {
            Debug.Log("Balta kullaniliyor.");
        }
    }
}
