import { makeStyles } from '@material-ui/core/styles';

const SignInClasses = makeStyles((theme) => ({
  // root: {
  //   height: '70vh',
  //   width: '450px',
  //   maxWidth: '100%',
  //   display: 'flex',
  //   borderRadius: '0px',
  //   position: 'relative',
  // },
  rootLeft: {
    display: 'flex',
    width: '600px',
  },
  rootMainLayout: {
    display: 'flex',
    zIndex: '101',
    // width: '50%',
    background: '#fff',
  },
  // rootOverlayLayoutRight: {
  //   display: 'flex',
  //   width: '450px',
  //   background: '#086574',
  //   position: 'absolute',
  //   left: '50%',
  //   height: '70vh',
  //   overflow: 'hidden',
  //   zIndex: 100,
  // },
  // rootOverlayLayoutLeft: {
  //   display: 'flex',
  //   // width: '450px',
  //   background: '#086574',
  //   position: 'absolute',
  //   // top: 0,
  //   // left: '50%',
  //   // width: '50%',
  //   height: '70vh',
  //   overflow: 'hidden',
  //   zIndex: 100,
  // },
  leftHeader: {
    color: '#0C9EB5',
  },
  rightHeader: {
    color: '#fff',
    opacity: '0.8',
  },
  rowIcons: {
    margin: '0.5rem 0rem 2rem',
  },
  facebookIcon: {
    marginRight: '1rem !important',
  },
  googleIcon: {
    marginRight: '1rem !important',
  },
  leftHint: {
    fontWeight: 400,
    opacity: 0.6,
    color: '#020F11',
  },
  rightHint: {
    textAlign: 'center',
    color: '#fff',
    marginBottom: '1.5rem',
    opacity: '0.8',
    width: '200px',
  },
  question: {
    opacity: 0.8,
    color: '#020F11',
    borderBottom: '1.5px solid rgba(12,158,181,0.5)',
    boxShadow: '0 6px 8px -8px #0C9EB5',
    lineHeight: '34px',
    marginBottom: '0px',
  },
  btnLeftRoot: {
    background: '#E8F6F8 !important',
    border: '1.5px solid #0C9EB5 !important',
    padding: '8px 44px !important',
    borderRadius: '22px !important',
    outline: 'none !important',
    '&:hover': {
      background: '#0C9EB5 !important',
    },
    marginTop: '1.25rem !important',
  },
  btnRightRoot: {
    background: '#E8F6F8 !important',
    border: '1.5px solid #fff !important',
    padding: '8px 44px !important',
    borderRadius: '22px !important',
    outline: 'none !important',
    '&:hover': {
      background: '#fff !important',
    },
  },
  btnLabel: {
    color: '#020F11',
  },
  svgIconRoot: {
    opacity: '0.6',
  },
  inputGroupRoot: {},
}));

export default SignInClasses;
