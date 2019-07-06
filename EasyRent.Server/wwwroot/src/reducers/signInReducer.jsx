import axios from 'axios';
import { SIGN_IN, SIGN_UP } from './actionTypes';
import Utils from '../utils';

export const signIn = (data) => (dispatch, getState) => {
  if (Utils.isEmpty(data)) {
    return;
  }

  const request = {
    method: 'POST',
    url: `${process.env.REACT_APP_BASE_URL}/account/sign-in`,
    data,
  };

  // dispatch(startRequest);

  const handleSuccess = (response) => {
    console.log('Fine!');
    // dispatch(receiveRequest);
  };
  const handleError = (response) => {
    // dispatch(handleError);
  };

  axios(request)
    .then(handleSuccess)
    .catch(handleError);
};

export const signUp = (data) => (dispatch, getState) => {};

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
