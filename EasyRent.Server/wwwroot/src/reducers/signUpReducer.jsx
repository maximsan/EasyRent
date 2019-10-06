import axios from 'axios';
import _ from 'lodash';
import {
  SIGN_UP,
  START_REQUEST,
  STOP_REQUEST,
  HANDLE_ERROR,
} from './actionTypes';
import { startRequest, stopRequest, handleRequestError } from './signInActions';
import { signUpSuccess } from './signUpActions';
import { identityServerUrl } from '../config/constants';

export const signUp = (data) => (dispatch) => {
  const { email, password, userName, confirmPassword } = data;

  if (
    _.isEmpty(data) ||
    email === '' ||
    password === '' ||
    userName === '' ||
    confirmPassword === '' ||
    confirmPassword !== password
  ) {
    return;
  }

  const request = {
    method: 'POST',
    url: `${identityServerUrl}/account/sign-up`,
    data,
  };

  dispatch(startRequest);

  const handleSuccess = () => {
    dispatch(stopRequest);
    dispatch(signUpSuccess);
    window.location.pathname = '/main';
  };
  const handleError = (response) => {
    dispatch(stopRequest);
    dispatch(handleRequestError(response.data));
  };

  axios(request)
    .then(handleSuccess)
    .catch(handleError);
};

export const signUpReducer = (state = {}, action) => {
  switch (action.type) {
    case SIGN_UP: {
      return { ...state, isSigned: action.payload };
    }
    case START_REQUEST: {
      return { ...state, loading: true };
    }
    case STOP_REQUEST: {
      return { ...state, loading: false };
    }
    case HANDLE_ERROR: {
      return {
        ...state,
        erros: {
          ...state.errors,
          signUpErrors: action.payload,
        },
      };
    }
    default:
      return state;
  }
};
