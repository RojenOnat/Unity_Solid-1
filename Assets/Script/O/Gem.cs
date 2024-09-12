using UnityEngine;

namespace Script.O
{
    /// <summary>
    /// burda float tipinde bir deger olusturabilirdik ancak daha hiyerarsik bir yapı olusturmak adina bir BaseExperience sinifi acip o siniftan base degeri miras almak daha mantikli olacaktir.
    /// </summary>
    public class Gem : BaseExperience,IExperienceStrategy
    {
        
        /// <summary>
        /// Kazanacagimiz tecrube puanini belirler.
        /// </summary>
        /// <param name="experienceHolder"></param>
        /// <param name="amount"></param>
        public void GainExperience(ExperienceHolder experienceHolder, float amount)
        {
            experienceHolder.GainExperience(amount * _baseExperienceAmount);
        }
    }
}
