import React from 'react';
import PropTypes, { bool } from 'prop-types';
import { Grid, Paper } from '@material-ui/core';
import {
  EmailOutlined,
  LockOutlined,
  PersonOutlined,
} from '@material-ui/icons';

import Email from '../email/Email';
import Password from '../password/Password';
import TextInput from '../text-input/TextInput';
import Button from '../button/Button';
import FacebookIcon from '../icons/FacebookIcon';
import GoogleIcon from '../icons/GoogleIcon';
import TelegramIcon from '../icons/TelegramIcon';
import useSignInClasses from '../sign-in/signin-styles';

const SignFormLayout = ({
  gridClasses,
  onHandleChange,
  onHandleClick,
  value,
  header,
  hint,
  isSignIn,
}) => {
  const classes = useSignInClasses();

  const { name, email, password } = value;

  return (
    <div className={classes.rootMainLayout}>
      <Grid
        classes={{ ...gridClasses }}
        container
        justify='center'
        alignItems='center'
        alignContent='center'
      >
        <Grid container justify='center' className={classes.leftHeader}>
          <h1>{header}</h1>
        </Grid>
        <Grid container justify='center' className={classes.rowIcons}>
          <Grid item className={classes.facebookIcon}>
            <FacebookIcon />
          </Grid>
          <Grid item className={classes.googleIcon}>
            <GoogleIcon />
          </Grid>
          <Grid item>
            <TelegramIcon />
          </Grid>
        </Grid>
        <Grid container justify='center' className={classes.leftHint}>
          {hint}
        </Grid>
        <Grid>
          {!isSignIn && (
            <TextInput
              id='name'
              labelText='Name'
              variant='filled'
              value={name}
              onChange={onHandleChange('name')}
              required
              hasError={false}
              startIcon={
                <PersonOutlined
                  classes={{ root: classes.svgIconRoot }}
                  fontSize='small'
                />
              }
            />
          )}
        </Grid>
        <Grid
          container
          justify='center'
          classes={{ root: classes.inputGroupRoot }}
        >
          <Grid container justify='center'>
            <Email
              variant='filled'
              value={email}
              onChange={onHandleChange('email')}
              required
              error={false}
              startIcon={
                <EmailOutlined
                  classes={{ root: classes.svgIconRoot }}
                  fontSize='small'
                />
              }
            />
          </Grid>
          <Grid container justify='center'>
            <Password
              variant='filled'
              value={password}
              onChange={onHandleChange('password')}
              required
              error={false}
              startIcon={
                <LockOutlined
                  classes={{ root: classes.svgIconRoot }}
                  fontSize='small'
                />
              }
            />
          </Grid>
        </Grid>
        {isSignIn && (
          <Grid container justify='center'>
            <h3 className={classes.question}>Forgot your password?</h3>
          </Grid>
        )}
        <Grid container justify='center'>
          <Button
            addClasses={{ root: classes.btnLeftRoot, label: classes.btnLabel }}
            onClick={onHandleClick}
          >
            {isSignIn ? 'Sign In' : 'Sign Up'}
          </Button>
        </Grid>
      </Grid>
    </div>
  );
};

SignFormLayout.propTypes = {
  header: PropTypes.string.isRequired,
  hint: PropTypes.string,
  onHandleChange: PropTypes.func,
  value: PropTypes.any,
};

SignFormLayout.defaultProps = {
  header: '',
  hint: '',
};

export default SignFormLayout;
