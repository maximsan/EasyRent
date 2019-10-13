import {
  SIGN_IN,
  SIGN_UP,
  START_REQUEST,
  STOP_REQUEST,
  HANDLE_ERROR,
} from './actionTypes';

export const signIn = (data) => {
  return {
    type: SIGN_IN,
    data,
  };
};

export const startRequest = () => {
  return {
    type: START_REQUEST,
  };
};

export const stopRequest = () => {
  return {
    type: STOP_REQUEST,
  };
};

export const handleRequestError = (data) => {
  return {
    type: HANDLE_ERROR,
    errors: data,
  };
};
