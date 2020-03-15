namespace Dominio.Interface.Infra
{
    public interface IMarvelHasher
    {
        string PublicKey { get; }
        string PrivateKey { get; }
        string TimeStamp { get; }
        string ObterHash();
    }
}
