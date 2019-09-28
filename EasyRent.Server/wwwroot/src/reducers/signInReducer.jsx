import axios from 'axios';
import _ from 'lodash';
import { SIGN_IN, SIGN_UP } from './actionTypes';
import AuthCallback from '../components/auth/AuthCallback';
import React from 'react';
// import Utils from '../utils';
// import

export const signIn = (data) => (dispatch, getState) => {
  const { email, password, returnUrl } = data;

  if (_.isEmpty(data) || email === '' || password === '') {
    return;
  }

  if (!returnUrl) {
    throw Error('ReturnUrl cannot be empty');
  }

  const request = {
    method: 'POST',
    url: `http://localhost:5002/account/sign-in?returnUrl=${returnUrl}`,
    data,
    headers: {
      'Access-Control-Allow-Origin': '*',
    },
  };

  // dispatch(startRequest);

  const handleSuccess = (response) => {
    return <AuthCallback />;
    // debugger;
    //window.location.pathname = 'main';
    // dispatch(receiveRequest);
  };
  const handleError = (response) => {
    debugger;
    // dispatch(handleError);
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
    url: `${process.env.PUBLIC_URL}account/sign-up`,
    data,
  };

  // dispatch(startRequest);

  const handleSuccess = (response) => {
    debugger;
    //window.location.pathname = 'main';
    // dispatch(receiveRequest);
  };
  const handleError = (response) => {
    // dispatch(handleError);
  };

  axios(request)
    .then(handleSuccess)
    .catch(handleError);
};

const signInReducer = (state = {}, action) => {
  switch (action.type) {
    case SIGN_IN: {
      signIn(state);
      break;
    }
    default:
      return state;
  }
};

export default signInReducer;
