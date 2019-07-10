import axios from 'axios';
import _ from 'lodash';
import { SIGN_IN, SIGN_UP } from './actionTypes';
// import Utils from '../utils';

export const signIn = (data) => (dispatch, getState) => {
  const { email, password } = data;

  if (_.isEmpty(data) || email === '' || password === '') {
    return;
  }

  const request = {
    method: 'POST',
    url: `${process.env.REACT_APP_BASE_URL}/account/sign-in`,
    data,
  };

  // dispatch(startRequest);

  const handleSuccess = (response) => {
    window.location.pathname = 'main';
    // dispatch(receiveRequest);
  };
  const handleError = (response) => {
    // dispatch(handleError);
  };

  axios(request)
    .then(handleSuccess)
    .catch(handleError);
};

export const signUp = (data) => (dispatch, getState) => {
  const { email, password, name } = data;

  if (_.isEmpty(data) || email === '' || password === '' || name === '') {
    return;
  }

  const request = {
    method: 'POST',
    url: `${process.env.REACT_APP_BASE_URL}/account/sign-up`,
    data,
  };

  // dispatch(startRequest);

  const handleSuccess = (response) => {
    window.location.pathname = 'main';
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
