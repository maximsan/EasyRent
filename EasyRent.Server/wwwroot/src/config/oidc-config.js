import { WebStorageStateStore } from 'oidc-client';
import { identityServerUrl, easyRentServerUrl, CLIENT_NAME } from './constants';

export const IDENTITY_CONFIG = {
  authority: identityServerUrl,
  client_id: CLIENT_NAME,
  redirect_uri: `${process.env.REACT_APP_BASE_URL}/auth-callback`,
  // login: identityServerUrl + "/login",
  // automaticSilentRenew: (boolean, default: false): Flag to indicate if there should be an automatic attempt to renew the access token prior to its expiration.
  loadUserInfo: true,
  // silent_redirect_uri: (string): The URL for the page containing the code handling the silent renew.
  post_logout_redirect_uri: `${process.env.REACT_APP_BASE_URL}`, // The OIDC post-logout redirect URI.
  response_type: 'id_token token',
  // (string, default: 'id_token'): The type of response desired from the OIDC provider.
  // grantType: "password",
  scope: `openid profile api`, // (string, default: 'openid'): The scope being requested from the OIDC provider.
  // webAuthResponseType: "id_token token",
  checkSessionInterval: 30000,
  userStore: new WebStorageStateStore({
    store: window.localStorage,
  }),
};

export const METADATA_OIDC = {
  jwks_uri: `${identityServerUrl}/.well-known/openid-configuration/jwks`,
  authorization_endpoint: `${identityServerUrl}/connect/authorize`,
  token_endpoint: `${identityServerUrl}/connect/token`,
  userinfo_endpoint: `${identityServerUrl}/connect/userinfo`,
  end_session_endpoint: `${identityServerUrl}/connect/endsession`,
  check_session_iframe: `${identityServerUrl}/connect/checksession`,
  revocation_endpoint: `${identityServerUrl}/connect/revocation`,
  introspection_endpoint: `${identityServerUrl}/connect/introspect`,
};
