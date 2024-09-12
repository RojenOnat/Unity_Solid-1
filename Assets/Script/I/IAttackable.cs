namespace Script.I
{
    /// <summary>
    /// Saldiri islemlerini sinif'a kazandirabilmek adina olustudugumuz Interface yapimiz.
    /// </summary>
    public interface IAttackable
    {
        /// <summary>
        /// Saldiri islemini tetikleyen method.
        /// </summary>
        void OnAttack();
    }
}
