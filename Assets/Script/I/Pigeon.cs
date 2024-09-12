namespace Script.I
{
    public class Pigeon : Bird
    {
        /*
         * Ne yaptik burda Pigeon sinifi Bird sinifindan kalitim aliyor,ancak saldiri ozelligine sahip olmadigi icin biz ana sinifimizda(Bird) saldiri methodu olusturmadik cunku her kusun saldirma ozelligi olmayabilir
         * Liskov prensibini hatirlarsak alt siniflar ana sinifin yerine gecebilmesi lazimdi yani ana sinif saldiriyorsa kalitim alan siniflarda saldirmasi lazimdi haliyle bu prensibimize uyabilmek adina
         * Interface lerden yardim alarak saldiri islemini anasinifimizda kullanmayip IAttackable adinda olusturdugumuz interface ile tanimlamis olup LSP-ISP prensiplerimize uyum saglayan bir yapi olusturmus olduk.
         */
    }
}
