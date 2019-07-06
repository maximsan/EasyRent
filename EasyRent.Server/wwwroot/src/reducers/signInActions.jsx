import { SIGN_IN, SIGN_UP } from './actionTypes';

export const signIn = (data) => {
  return {
    type: SIGN_IN,
    data,
  };
};

export const signUp = (data) => {
  return {
    type: SIGN_UP,
    data,
  };
};
