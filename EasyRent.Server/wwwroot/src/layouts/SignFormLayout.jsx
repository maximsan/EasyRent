import React from 'react';
import PropTypes, { bool } from 'prop-types';
import { Grid, Paper } from '@material-ui/core';
import {
  EmailOutlined,
  LockOutlined,
  PersonOutlined,
} from '@material-ui/icons';
import Email from '../components/common/email/Email';
import Password from '../components/common/password/Password';
import TextInput from '../components/common/text-input/TextInput';
import { ContainedButton } from '../components/common/button';
import FacebookIcon from '../components/icons/social-icons/FacebookIcon';
import GoogleIcon from '../components/icons/social-icons/GoogleIcon';
import TelegramIcon from '../components/icons/social-icons/TelegramIcon';
import useSignInClasses from '../pages/sign-in/signin-styles';

const SignFormLayout = ({
  gridClasses,
  onChange,
  onHandleClick,
  value,
  header,
  hint,
  isSignIn,
}) => {
  const classes = useSignInClasses();

  const { userName, email, password, confirmPassword } = value;

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
            <FacebookIcon fontSize='large' title='Log in via Facebook' />
          </Grid>
          <Grid item className={classes.googleIcon}>
            <GoogleIcon fontSize='large' title='Log in via Google' />
          </Grid>
          <Grid item>
            <TelegramIcon fontSize='large' title='Log in via Telegram' />
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
              value={userName}
              onChange={onChange('userName')}
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
              onChange={onChange('email')}
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
              onChange={onChange('password')}
              labelText='Password'
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
          <Grid container justify='center'>
            {!isSignIn && (
              <Password
                variant='filled'
                value={confirmPassword}
                onChange={onChange('confirmPassword')}
                labelText='Confirm password'
                required
                error={false}
                startIcon={
                  <LockOutlined
                    classes={{ root: classes.svgIconRoot }}
                    fontSize='small'
                  />
                }
              />
            )}
          </Grid>
        </Grid>
        {isSignIn && (
          <Grid container justify='center'>
            <h3 className={classes.question}>Forgot your password?</h3>
          </Grid>
        )}
        <Grid container justify='center'>
          <ContainedButton
            extraClasses={{
              root: classes.btnLeftRoot,
              label: classes.btnLabel,
            }}
            onClick={onHandleClick}
          >
            {isSignIn ? 'Sign In' : 'Sign Up'}
          </ContainedButton>
        </Grid>
      </Grid>
    </div>
  );
};

SignFormLayout.defaultProps = {
  header: '',
  hint: '',
  onHandleChange: () => {},
};

SignFormLayout.propTypes = {
  header: PropTypes.string,
  hint: PropTypes.string,
  onHandleChange: PropTypes.func,
  value: PropTypes.any,
};

export default SignFormLayout;
