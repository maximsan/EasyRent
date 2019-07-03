import React from 'react';
import PropTypes from 'prop-types';
import { Grid, Paper } from '@material-ui/core';
import useSignInClasses from '../sign-in/signin-styles';

import Button from '../button/Button';

const SignBackLayout = ({
  gridClasses,
  onHandleClick,
  buttonName,
  header,
  hint,
}) => {
  const classes = useSignInClasses();

  return (
    <Grid
      classes={{ ...gridClasses }}
      container
      justify='center'
      alignItems='center'
      alignContent='center'
    >
      <Grid container justify='center' className={classes.rightHeader}>
        <h1>{header}</h1>
      </Grid>
      <Grid container justify='center' className={classes.rightHint}>
        {hint}
      </Grid>
      <Grid container justify='center'>
        <Button
          addClasses={{ root: classes.btnRightRoot }}
          onClick={onHandleClick}
        >
          {buttonName}
        </Button>
      </Grid>
    </Grid>
  );
};

SignBackLayout.propTypes = {};

SignBackLayout.defaultProps = {};

export default SignBackLayout;
