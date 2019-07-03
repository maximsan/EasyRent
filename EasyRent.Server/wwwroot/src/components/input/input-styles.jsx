import { makeStyles } from '@material-ui/core/styles';

const InputClasses = makeStyles((theme) => ({
  formControlRoot: {
    marginTop: '1rem',
    outline: 'none',
  },
  focusedLabel: {
    color: '#0C9EB5 !important',
  },
  rootInput: {
    '&:hover': {
      borderBottom: '#0C9EB5',
    },
    '&:after': {
      borderBottom: '2px solid #0C9EB5',
    },
    height: '52px',
    width: '280px',
  },
}));

export default InputClasses;
