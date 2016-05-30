﻿using DiscogsClient.Data.Query;
using DiscogsClient.Data.Result;
using RestSharpInfra.OAuth1;
using System.Threading.Tasks;
using Xunit;

namespace DiscogsClient.Test
{
    public class DiscogsClientTest
    {
        private readonly DiscogsClient _DiscogsClient;
        private readonly OAuthCompleteInformation _OAuthCompleteInformation;

        public DiscogsClientTest()
        {
            //_OAuthCompleteInformation = new OAuthCompleteInformation();
            _DiscogsClient = new DiscogsClient(_OAuthCompleteInformation);
        }

        [Fact]
        public async Task Search_Artist()
        {
            var discogsSearch = new DiscogsSearch()
            {
                artist = "Ornette Coleman",
                release_title = "The Shape Of a Jazz To Come"
            };
            var res = await  _DiscogsClient.Search<DiscogsRelease>(discogsSearch);

            //res.
        }
    }
}