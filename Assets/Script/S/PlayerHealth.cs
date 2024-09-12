using UnityEngine;

namespace Script.S
{
    /// <summary>
    ///  !!NOT!!: Olusturdugumuz methodun basina yorum satiri acip varolan methodu aciklayan ufak bir satir birakmamiz bizden sonraki yazilimci arkadasimiza yapacagimiz bir centilmenlik tir,
    ///  bu bir yana dursun bununla birlikte uzun bir aradan sonra tekrar projemize bakmamiz istendiginde acip kontrol edecegimizde yapilan islemi daha net hatirlamamizi saglar.
    /// </summary>
    public class PlayerHealth : MonoBehaviour
    {
        [Tooltip("Health Of Player")] public int CurrentHealth;

        
        /// <summary>
        ///  Bu methodu kullanarak oyuncunun sagligini guncelleyebilirsiniz.
        /// </summary>
        /// <param name="amount">The amount that will change</param>
        public void OnHealthSetter(int amount)
        {
            //Oyuncunun saglik guncellemelerini iceren kodlari buraya yazabilirsiniz.
            
            CurrentHealth += amount;
        }
        
        /// <summary>
        /// Oyuncumuzun oyun icerisinde oldugunu konsola yazdira bilirsiniz.
        /// </summary>
        public void OnPlayerDeath() => Debug.Log("Player is death!");
    }
}
