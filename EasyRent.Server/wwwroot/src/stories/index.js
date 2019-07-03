import React from 'react';

import { storiesOf } from '@storybook/react';
import { action } from '@storybook/addon-actions';
import { linkTo } from '@storybook/addon-links';

import SignIn from '../components/sign-in/SignIn';
import Button from '../components/Button';

storiesOf('Sign in', module).add('sign in button', () => (
  <Button>Sign In</Button>
));

storiesOf('Sign in', module).add('default sign in', () => <SignIn />);
