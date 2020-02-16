using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace EasyRent.IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    RequireClientSecret = false,
                    AccessTokenLifetime = 3600,
                    IdentityTokenLifetime = 3600,
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    PostLogoutRedirectUris = new string[]{
                        "http://localhost:5001/logout-callback"
                    },
                    RedirectUris = new string[]{
                        "http://localhost:5001/auth-callback"
                    },
                    AllowedCorsOrigins = new string[]{
                        "http://localhost:5002",
                        "http://localhost:5001"
                    },
                    // scopes that client has access to
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api"
                    },
                    AllowOfflineAccess = false,
                    RequireConsent = false
                },
                new Client
                {
                    ClientId = "api",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    RequireClientSecret = false,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    RequireConsent = false,
                    RequirePkce = false,
                    PostLogoutRedirectUris = new string[]{
                        "http://localhost:5001/logout-callback"
                    },
                    RedirectUris = new string[]{
                        "http://localhost:5001/auth-callback"
                    },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api1"
                    },

                    AllowOfflineAccess = true
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api", "Rent API Resource")
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }
    }
}