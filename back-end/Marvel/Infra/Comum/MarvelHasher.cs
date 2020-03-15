using Dominio.Interface.Infra;
using Microsoft.Extensions.Configuration;
using System;

namespace Infra.Comum
{
    public class MarvelHasher : IMarvelHasher
    {
        private readonly IConfiguration configuration;

        public string PublicKey { get; private set; }
        public string PrivateKey { get; private set; }
        public string TimeStamp { get; private set; }

        public MarvelHasher(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.PublicKey = configuration.GetSection("Marvel").GetSection("APIConnection").GetSection("PublicKey").Value;
            this.PrivateKey = configuration.GetSection("Marvel").GetSection("APIConnection").GetSection("PrivateKey").Value;
            this.TimeStamp = ObterTimeStamp();
        }

        public string ObterHash()
        {
            return new MD5().ObterHash(TimeStamp + PrivateKey + PublicKey);
        }

        private string ObterTimeStamp()
        {
            return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
        }
    }
}
