import React from 'react';
import axios from 'axios';
import _ from 'lodash';
import {
  SIGN_IN,
  SIGN_UP,
  START_REQUEST,
  STOP_REQUEST,
  RECEIVED_DATA,
} from './actionTypes';
import AuthCallback from '../components/auth/AuthCallback';
import { identityServerUrl } from '../config/constants';

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
    url: `${identityServerUrl}/account/sign-in?returnUrl=${returnUrl}`,
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
    url: `${identityServerUrl}/account/sign-up`,
    data,
  };

  dispatch({ type: START_REQUEST, payload: { isLoading: true } });

  const handleSuccess = (response) => {
    dispatch({ type: STOP_REQUEST, payload: { isLoading: false } });
    debugger;
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

const signInReducer = (state = {}, action) => {
  switch (action.type) {
    case SIGN_IN: {
      return { ...state, isSigned: action.payload };
    }
    case START_REQUEST: {
      return { ...state, loading: action.payload.isLoading };
    }
    case STOP_REQUEST: {
      return { ...state, loading: action.payload.isLoading };
    }
    default:
      return state;
  }
};

export default signInReducer;
