using System;
using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using Microsoft.Extensions.Configuration;

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
                        "http://localhost:5000"
                    },
                    RedirectUris = new string[]{
                        // "http://localhost:5002/src/oidc/callback.html",
                        "http://localhost:5000/auth-callback"
                    },
                    AllowedCorsOrigins = new string[]{
                        "http://localhost:5000"
                    },
                    // scopes that client has access to
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api"
                    },
                    AllowOfflineAccess = false
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