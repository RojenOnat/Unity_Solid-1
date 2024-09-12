using UnityEngine;

namespace Script.S
{
    /// <summary>
    /// Bizim ilk amacimiz her sinifin sadece bir tanimi karsilamasidir.
    /// Ornek olarak eger sinifim movement sinifi ise burda playerHealth kontrol islemlerini yapmamam gerekir.
    /// Eger bu sinifta playerHealth kontrollerinide yapmaya kalkarsam sonucu S.O.L.I.D prensiplerinin ilk harfi olan "Single Responsibility Principle" ilkesini ihlal etmis olurum.
    /// Peki ben neden bunu kullanmak zorundayim diye sordugumda , pekala bir cok islemi burda tek bir scriptte gerceklestirebilirim ancak bunu gerceklestirdigim zaman bu yazdigim kodlarin degistirilmesi ya da iglestirilmesi gerektiginde
    /// bu kodlari inceleyen adam yarim saatini ayirmak zorunda kalacaktir ayrica bir gelistirme eklemek istedigi zaman da bu karisiklik projenin devamliligina zarar vermekle birlikte ileride cozulmesi daha karmasik bug lar ile dolduracaktir
    /// Peki biz bu siniflari ayirdigimizda ne olacak ? Mesela movement ile ilgili bir sey degistirecegimiz yahut ekleyecegimiz zaman direk ilgili scripte erisip hemen degisiklikleri yapmamiz ve bu degisiklikleri zaman icinde kontrol edebilmemizi kolaylastiracagi icin
    /// olusabilecek karisikligin onune gecmis olacagiz.
    ///
    /// Daha da somutlastirmak gerekirse bir cekmece bolmesini dusunebiliriz.Karisik bir cekmecede aradigimizi bulamayabiliriz.Ancak her cekmece kendine ozgu oldugu zaman bir sey aradigimizda
    /// nereye bakacagimizi daha kolay bulabiliriz ve o cekmecenin ici kapsam disi esyalarla dolu olmadigi zaman kolaylikla cekmecemizi duzenleyebiliriz.
    /// </summary>
    public class PlayerMovement : MonoBehaviour
    {
        [Tooltip("Speed Of Player")] public int PlayerSpeed;

        public void OnMovementStart()
        {
            //hareket ile ilgili kodlarimizi icerir.
            Debug.Log("The movement has begun.");
        }

        public void OnMovementEnd()
        {
            //hareketimiz tamamlandiginda yapilmasini istedigimiz kodlari icerir.
            Debug.Log("The movement is over!");

        }
    
        void Update()
        {
            OnMovementStart();
        }
    }
}
