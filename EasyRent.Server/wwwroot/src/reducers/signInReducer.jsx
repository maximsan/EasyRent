import { useContext } from 'react';
import axios from 'axios';
import _ from 'lodash';
import {
  SIGN_IN,
  SIGN_UP,
  START_REQUEST,
  STOP_REQUEST,
  RECEIVED_DATA,
  HANDLE_ERROR,
} from './actionTypes';
import { startRequest, stopRequest, handleRequestError } from './signInActions';
import { identityServerUrl } from '../config/constants';

export const signIn = (data) => (dispatch, getState) => {
  const { email, password, returnUrl, signinRedirectCallback } = data;

  if (_.isEmpty(data) || email === '' || password === '') {
    return;
  }

  if (!returnUrl) {
    throw Error('ReturnUrl cannot be empty');
  }

  const request = {
    method: 'POST',
    url: `${identityServerUrl}/account/sign-in?returnUrl=${returnUrl}`,
    data,
    headers: {
      'Access-Control-Allow-Origin': '*',
    },
  };

  dispatch(startRequest);

  const handleSuccess = (response) => {
    debugger;
    dispatch(stopRequest);

    signinRedirectCallback().then(() => {
      window.location = '/main';
    });
  };
  const handleError = (response) => {
    debugger;
    dispatch(handleRequestError(response));
  };

  axios(request)
    .then(handleSuccess)
    .catch(handleError);
};

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

const signInReducer = (state = {}, action) => {
  switch (action.type) {
    case SIGN_IN: {
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

export default signInReducer;
