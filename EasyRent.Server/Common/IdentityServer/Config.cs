using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace EasyRent.Server.Common.IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> GeClients()
        {
            return new List<Client>
            {
                new Client
                {
                    AccessTokenType = AccessTokenType.Jwt,
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.Address,
                        "ApiResource"
                    },
                    ClientId = "react",
                    ClientName = "ReactClient",
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },
                    RequireClientSecret = false,
                    RequirePkce = true
                }
            };
        }

        public static IEnumerable<ApiResource> GetApisApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("ApiResource", "Rent API Resource")
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
            };
        }
    }
}