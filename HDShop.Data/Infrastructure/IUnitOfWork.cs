namespace HDShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}