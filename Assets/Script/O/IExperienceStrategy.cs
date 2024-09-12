namespace Script.O
{
    
    /// <summary>
    /// Biz burda bir interface olusturup gem siniflarimiz icin ayri ayri tecrube puanlarini hesaplayabilecek sekilde kodumuzu yeni ozellikler eklemeye acik hale getirmis olduk.
    /// </summary>
    public interface IExperienceStrategy
    {
        /// <summary>
        /// Kazanilacak tecrube degerlerini belirlemek icin kullanilir.
        /// </summary>
        /// <param name="experienceHolder">Experience Holder Script</param>
        /// <param name="amount">amount of experience</param>
        void GainExperience(ExperienceHolder experienceHolder, float amount);
    }
}
