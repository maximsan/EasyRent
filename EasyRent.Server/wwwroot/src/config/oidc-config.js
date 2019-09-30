import { WebStorageStateStore } from 'oidc-client';
import { identityServerUrl, easyRentServerUrl } from './constants';

export const IDENTITY_CONFIG = {
  authority: identityServerUrl,
  client_id: 'client',
  scope: `openid profile api`,
  response_type: 'id_token token',
  loadUserInfo: true,
  redirect_uri: `${easyRentServerUrl}/singin`,
  post_logout_redirect_uri: `${easyRentServerUrl}/signin`,
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
