import { useContext } from 'react';
import axios from 'axios';
import _ from 'lodash';
import {
  SIGN_IN,
  SIGN_UP,
  START_REQUEST,
  STOP_REQUEST,
  RECEIVED_DATA,
} from './actionTypes';
import { startRequest, stopRequest, handleRequestError } from './signInActions';
import { identityServerUrl } from '../config/constants';
import AuthContext from '../context/AuthContext';

export const signIn = (data) => (dispatch, getState) => {
  const { email, password, returnUrl } = data;

  const { signinRedirectCallback } = useContext(AuthContext);

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

export const signUp = (data) => (dispatch, getState) => {
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

  const handleSuccess = (response) => {
    dispatch(stopRequest);
    debugger;
    //window.location.pathname = 'main';
    // dispatch(receiveRequest);
  };
  const handleError = (response) => {
    debugger;
    dispatch(stopRequest);
    dispatch(handleRequestError(response));
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
    default:
      return state;
  }
};

export default signInReducer;
