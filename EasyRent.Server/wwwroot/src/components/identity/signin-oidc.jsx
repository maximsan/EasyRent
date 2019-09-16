import * as Oidc from 'oidc-client';

const config = {
  authority: process.env.IDENTITY_SERVER_URL,
  client_id: process.env.CLIENT_NAME,
  scope: `openid profile ${process.env.API_NAME}`,
  response_type: 'id_token token',
  loadUserInfo: true,
  redirect_uri: `${process.env.PUBLIC_URL}/src/oidc/callback.html`,
  // login: `${process.env.PUBLIC_URL}/signin`,
  post_logout_redirect_uri: `${process.env.PUBLIC_URL}/signin`,
};

Oidc.Log.logger = console;
Oidc.Log.level = 4;

const SignInOidc = new Oidc().UserManager(config);

export default SignInOidc;
