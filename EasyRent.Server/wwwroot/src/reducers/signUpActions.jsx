import { SIGN_UP_SUCCESS } from '../reducers/actionTypes';
export const signUpSuccess = (data) => {
  return {
    type: SIGN_UP_SUCCESS,
    data,
  };
};
