import React from 'react';
import PropTypes, { bool } from 'prop-types';
import { Grid, Paper } from '@material-ui/core';
import {
  EmailOutlined,
  LockOutlined,
  PersonOutlined,
} from '@material-ui/icons';
import Email from '../components/email/Email';
import Password from '../components/password/Password';
import TextInput from '../components/text-input/TextInput';
import Button from '../components/button/Button';
import FacebookIcon from '../components/icons/cosialIcons/FacebookIcon';
import GoogleIcon from '../components/icons/cosialIcons/GoogleIcon';
import TelegramIcon from '../components/icons/cosialIcons/TelegramIcon';
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

  const { name, email, password, confirmPassword } = value;

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
              onChange={onChange('name')}
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
  header: PropTypes.string,
  hint: PropTypes.string,
  onHandleChange: PropTypes.func,
  value: PropTypes.any,
};

SignFormLayout.defaultProps = {
  header: '',
  hint: '',
  onHandleChange: () => {},
};

export default SignFormLayout;
