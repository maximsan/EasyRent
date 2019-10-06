import { SIGN_UP_SUCCESS, SIGN_UP } from './actionTypes';

export const signUp = (data) => {
  return {
    type: SIGN_UP,
    data,
  };
};

export const signUpSuccess = (data) => {
  return {
    type: SIGN_UP_SUCCESS,
    data,
  };
};
