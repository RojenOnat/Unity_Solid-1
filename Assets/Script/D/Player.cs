using System;
using UnityEngine;

namespace Script.D
{
    public class Player : MonoBehaviour
    {

        private IWeapon _iWeapon;
        
        /// <summary>
        /// Eklemis oldugumuz IWeapon interface ini tanimliyan method.
        /// </summary>
        /// <param name="injectedWeapon"></param>
        public void InitializeWeaponInterface(IWeapon injectedWeapon)
        {
            _iWeapon = injectedWeapon; // Bagimlilik disaridan saglaniyor. Disaridan kasit araci ile dusunebiliriz.
        }
        
        /// <summary>
        /// Oyuncunun silahi kullanmak icin tetikledigi method.
        /// </summary>
        public void UseTheWeapon()
        {
            _iWeapon.OnUseWeapon();
        }

        private void Start()
        {
            /*
             * Ilk olarak burda ne yaptik bizim kullanacagimiz hangi silah turu ise IWeapon interface i uzerinden o sinifi implemente ediyoruz.
             */
            InitializeWeaponInterface(new Axe());
            
            // Diyelim ki bize farkli bir silah lazim oldu , kodun en basina tekrar direk o sinifi eklememize kaldirmamiza degistirmemize gerek kalmadan sadece Interface araciligi ile istedigimiz silaha erisebiliyoruz.
            UseTheWeapon();
        }
    }
}
