export const METHODS = {
  get: 'get',
  post: 'post',
  put: 'put',
  delete: 'delete',
};

export const API_NAME = 'api';
export const CLIENT_NAME = 'client';

export const url = `photos/?per_page=18&client_id=${process.env.REACT_APP_PHOTO_ACCESS_KEY}`;

export const identityServerUrl = `${process.env.REACT_APP_IDENTITY_SERVER_URL}`;
export const easyRentServerUrl = `${process.env.REACT_APP_EASY_RENT_API_URL}`;
