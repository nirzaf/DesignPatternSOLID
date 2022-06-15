namespace DesignPatternSOLID._5.D
{
    public class BusinessLayer
    {
        private readonly IRepositoryLayer _repositoryLayer;

        public BusinessLayer(IRepositoryLayer repositoryLayer)
        {
            _repositoryLayer = repositoryLayer;
        }
        public void AddItem(int itemId)
        {
            if (!string.IsNullOrEmpty(_repositoryLayer.GetItem(itemId)))
                _repositoryLayer.Update();
            else
                _repositoryLayer.Create();
        }
    }
    public interface IRepositoryLayer
    {
        void Create();

        void Delete();

        void Update();

        string GetItem(int itemId);
    }
}
